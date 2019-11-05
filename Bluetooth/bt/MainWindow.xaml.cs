using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;
using System.IO;
using InTheHand.Net;
using System.Threading;
using InTheHand.Net.Bluetooth;
using InTheHand.Net.Sockets;

namespace bt
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BackgroundWorker bg;
        BackgroundWorker bg_send;

        public MainWindow()
        {
            InitializeComponent();
            bg = new BackgroundWorker();
            bg_send = new BackgroundWorker();

            bg.DoWork += new DoWorkEventHandler(bg_DoWork);
            bg.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bg_RunWorkerCompleted);

            bg_send.DoWork += new DoWorkEventHandler(bg_send_DoWork);
            bg_send.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bg_send_RunWorkerCompleted);
        }


        void bg_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            deviceList.ItemsSource = (List<Device>)e.Result;
            findBtn.IsEnabled = true;
        }

        void bg_DoWork(object sender, DoWorkEventArgs e)
        {
            List<Device> devices = new List<Device>();
            InTheHand.Net.Sockets.BluetoothClient bc = new InTheHand.Net.Sockets.BluetoothClient();
            InTheHand.Net.Sockets.BluetoothDeviceInfo[] array = bc.DiscoverDevices();
            int count = array.Length;
            for (int i = 0; i < count; i++)
            {
                Device device = new Device(array[i]);
                devices.Add(device);
            }
            e.Result = devices;
        }

        private void findBtnClick(object sender, RoutedEventArgs e)
        {
            if (!bg.IsBusy)
            {
                findBtn.IsEnabled = false;
                bg.RunWorkerAsync();
            }
        }
        private void pairBtnClick(object sender, RoutedEventArgs e)
        {
            string myPin = "1234";
            Device device = (Device)deviceList.SelectedItem;
            var deviceInfo = device.DeviceInfo;
            BluetoothSecurity.PairRequest(deviceInfo, myPin);
        }

        private void deviceListSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (deviceList.SelectedItem != null)
            {
                Device device = (Device)deviceList.SelectedItem;

                authenticatedTB.Text = device.Authenticated.ToString();
                connectedTB.Text = device.Connected.ToString();
                deviceNameTB.Text = device.DeviceName;
                adressTB.Text = device.DeviceInfo.ToString();
            }
        }
        public string FilePath { get; set; }
        private void browseBtnClick(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.FileName = "File To Send";
            dlg.DefaultExt = "*.*";

            Nullable<bool> result = dlg.ShowDialog();

            if (result == true)
            {
                FilePath = dlg.FileName;
                sendBtn.IsEnabled = true;
            }
            else
                sendBtn.IsEnabled = false;
        }


        void bg_send_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result != null)
            {
                ObexStatusCode status = (ObexStatusCode)e.Result;
                MessageBox.Show("Status pliku: - " + status.ToString(), "Informacja");
            }
        }

        void bg_send_DoWork(object sender, DoWorkEventArgs e)
        {
            Device device = (Device)e.Argument;
            ObexStatusCode response_status = Module.SendFile(device.DeviceInfo, FilePath);
            e.Result = response_status;
        }

        private void sendBtnClick(object sender, RoutedEventArgs e)
        {
            if (!bg_send.IsBusy && deviceList.SelectedItem != null && !string.IsNullOrEmpty(FilePath))
            {
                Device device = (Device)deviceList.SelectedItem;
                bg_send.RunWorkerAsync(device);
            }
        }
    }
}
