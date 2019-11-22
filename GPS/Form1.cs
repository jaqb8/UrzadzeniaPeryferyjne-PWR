using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class GPS : Form
    {
        static bool next;
        static SerialPort serialPort;

        static Position latitudeLabelValue;
        static Position longitudeLabelValue;

        public static event EventHandler NewCoordsPresent;


        public GPS()
        {
            InitializeComponent();
        }

        protected static void OnNewCoordsPresent(EventArgs e)
        {
            EventHandler handler = NewCoordsPresent;
            handler?.Invoke(null, e);
        }

        public void Read()
        {

            while (next)
            {
                try
                {
                    string message = serialPort.ReadLine();

                    if (message.Contains("GPGGA"))
                    {
                        Console.Write(message);
                        Position position_N = ConvertToCoords(message.Split(',')[2], message.Split(',')[3],  2);
                        Position position_E = ConvertToCoords(message.Split(',')[4], message.Split(',')[5],  3);

                        GPS.latitudeLabelValue = position_N;
                        GPS.longitudeLabelValue = position_E;

                        time.Invoke((Action)delegate
                        {
                            string timeLocal = message.Split(',')[1];
                            time.Text = timeLocal.Insert(2, ":").Insert(5, ":").Substring(0,timeLocal.Insert(2, ":").Insert(5, ":").Length - 4);
                            Refresh();
                        });
                    }
                }
                catch (TimeoutException) { }
            }
        }
        public static Position ConvertToCoords(string input, string type, int degreeSize = 2)
        {
            Position result = new Position();

            result.Degree = int.Parse(input.Substring(0, degreeSize));
            result.Minutes = int.Parse(input.Substring(degreeSize, 2));
            var secs_string = "" + input.Substring(degreeSize + 2, 4);
            double secs_fraction = double.Parse(secs_string, CultureInfo.InvariantCulture.NumberFormat);
            result.Seconds = (int)Math.Truncate(60 * secs_fraction);
            result.Type = type;

            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringComparer stringComparer = StringComparer.OrdinalIgnoreCase;
            Thread readThread = new Thread(Read);

            // Stwórz instancję klasy SerialPort w celu otwarcia portu szeregowego.
            serialPort = new SerialPort();

            // Ustawienia portu szeregowego.
            serialPort.PortName = "COM3";
            serialPort.BaudRate = 9600;
            serialPort.Parity = Parity.None;
            serialPort.DataBits = 8;
            serialPort.StopBits = StopBits.One;
            serialPort.Handshake = Handshake.None;

            //  Pobierz/ustaw liczbę milisekund przez upływem limitu czasu, gdy operacja odczytu nie zostanie zakończona.
            serialPort.ReadTimeout = 500;
            serialPort.WriteTimeout = 500;

            serialPort.Open();
            next = true;
            readThread.Start();

        }



        public void Refresh()
        {
            label_latitude.Text = GPS.latitudeLabelValue.ToString();
            label_longitude.Text = GPS.longitudeLabelValue.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://maps.google.com/?q=" + latitudeLabelValue.CoordsToOneValue.ToString(CultureInfo.GetCultureInfo("en-US")) + "," + longitudeLabelValue.CoordsToOneValue.ToString(CultureInfo.GetCultureInfo("en-US")));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void time_Click(object sender, EventArgs e)
        {

        }
    }
}
