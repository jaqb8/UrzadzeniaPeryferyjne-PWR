using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Video.DirectShow;
using AForge.Video;
using Accord.Video.VFW;
using Accord.Video.FFMPEG;
using AForge.Imaging.Filters;


namespace USBCam
{
    public partial class MainWindow : Form
    {
        FilterInfoCollection videoDevicesList;
        VideoCaptureDevice cameraOne;
        int brightess = 0;
        int contrast = 0;
        int saturation = 0;
        bool isRecording = false;
        VideoFileWriter writer;
        private Bitmap oldBitmap;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            videoDevicesList = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo videoDevice in videoDevicesList)
                camListCmb.Items.Add(videoDevice.Name);
        }

        private void recordEventHandler(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            BrightnessCorrection br = new BrightnessCorrection(brightess);
            ContrastCorrection cr = new ContrastCorrection(contrast);
            SaturationCorrection sr = new SaturationCorrection(saturation);
            bitmap = br.Apply((Bitmap)bitmap.Clone());
            bitmap = cr.Apply((Bitmap)bitmap.Clone());
            bitmap = sr.Apply((Bitmap)bitmap.Clone());

            if (isRecording) writer.WriteVideoFrame(bitmap);
            else
            {
                oldBitmap = bitmap;
                view.Image = bitmap;
            }
        }

        private void start(object sender, EventArgs e)
        {
            cameraOne = new VideoCaptureDevice(videoDevicesList[camListCmb.SelectedIndex].MonikerString);
            cameraOne.NewFrame += new NewFrameEventHandler(recordEventHandler);
            cameraOne.Stop();
            cameraOne.Start();
        }

        private void stop(object sender, EventArgs e)
        {
            cameraOne.Stop();
        }

        private void screenshot(object sender, EventArgs e)
        {
            stop(sender, e);
            Bitmap picture = (Bitmap)view.Image;
            saveFileDialog.Filter = "Bitmap Image|*.bmp";
            saveFileDialog.Title = "Save an Image File";
            saveFileDialog.ShowDialog();
            System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog.OpenFile();
            picture.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
            fs.Close();
        }

        private void record(object sender, EventArgs e)
        {
            if (cameraOne.IsRunning)
            {
                recordButton.Enabled = false;
                stopRecordButton.Enabled = true;

                try
                {
                    saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Avi Files (*.avi)|*.avi";
                    saveFileDialog.Title = "Save a Video File";
                    saveFileDialog.ShowDialog();
                    writer = new VideoFileWriter();
                    writer.Open(saveFileDialog.FileName, view.Image.Width, view.Image.Height, 30, VideoCodec.MPEG4);
                    isRecording = true;
                }
                catch
                {
                    Console.Write("Record exception");
                }
            }
        }
        private void confirm(object sender, EventArgs e)
        {
            if (brightnessTB.Text.Length > 0)  brightess = Int32.Parse(brightnessTB.Text);
            if (contrastTB.Text.Length > 0) contrast = Int32.Parse(contrastTB.Text);
            if (saturationTB.Text.Length > 0) saturation = Int32.Parse(saturationTB.Text);
        }

        private void stopRecording(object sender, EventArgs e)
        {
            if (cameraOne.IsRunning && isRecording)
            {
                isRecording = false;
                writer.Close();

                recordButton.Enabled = true;
            }
        }
    }
}