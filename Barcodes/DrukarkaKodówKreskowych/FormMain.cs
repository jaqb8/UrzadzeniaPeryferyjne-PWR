using Spire.Barcode;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace DrukarkaKodówKreskowych
{
    public partial class FormMain : Form
    {
        Image barcode_img;
        public FormMain()
        {
            InitializeComponent();
        }

        /// Przycięta bitmapa z kodem kreskowym
        private static Image cropImage(Image img, Rectangle cropArea)
        {
            Bitmap bmp_image = new Bitmap(img);
            return bmp_image.Clone(cropArea, bmp_image.PixelFormat);
        }


        /// Generowanie kodu do wydrukowania na podstawie 12 cyfr + cyfra sumy kontrolnej
        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            var code = text_box_bar_codedigits.Text.Trim();
            if (text_box_bar_codedigits.TextLength < 12)
                MessageBox.Show($"Nieprawidłowa ilość cyfr! Wpisz jeszcze {12 - text_box_bar_codedigits.TextLength}");
            else if (text_box_bar_codedigits.TextLength > 12)
                MessageBox.Show($"Nieprawidłowa ilość cyfr! O {text_box_bar_codedigits.TextLength - 12} cyfr za dużo");


            // Parametry generowanego kodu
            var bar_code_generator = new BarCodeGenerator(new BarcodeSettings()
            {
                Type = BarCodeType.EAN13,
                BackColor = Color.White,
                ForeColor = Color.Black,

                Data = code,
                ShowText = true,
                ShowTextOnBottom = true,
                UseChecksum = CheckSumMode.ForceEnable,
                TextAlignment = StringAlignment.Center,

            });

            // Obraz kodu kreskowego
            barcode_img = bar_code_generator.GenerateImage();
            barcode_img = cropImage(barcode_img, new Rectangle(0, 15, barcode_img.Width, barcode_img.Height - 15));

            picture_box_bar_code.Image = barcode_img;
            picture_box_bar_code.Update();
            picture_box_bar_code.Visible = true;
        }


/// Drukowanie
private void buttonPrintBarCode_Click(object sender, EventArgs e)
        {
            // sprawdzenie czy jest co drukować
            if (barcode_img == null)
            {
                MessageBox.Show("obrazek jest pusty");
                return;
            }

            ImageConverter _imageConverter = new ImageConverter();
            byte[] xByte = (byte[])_imageConverter.ConvertTo(barcode_img, typeof(byte[]));

            // drukowany dokument do przekazania do druku
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(PrintPage);
            
            // otworzenie menu drukowania
            PrintDialog pdi = new PrintDialog();
            pdi.Document = pd;
            if (pdi.ShowDialog() == DialogResult.OK)
            {
                pd.Print(); // drukowanie
            }
            else
            {
                MessageBox.Show("drukowanie anulowane");
            }
        }

        /// Dopasowanie rozmiaru obrazka i stworzenie obrazu
        private void PrintPage(object o, PrintPageEventArgs e)
        {
            try
            {
                // rozmiar obrazka
                Rectangle m = e.MarginBounds;
                m.Height = 100;
                m.Width = 300;
     
                // drukowanie kodu kreskowego
                System.Drawing.Image image = barcode_img;
                e.Graphics.DrawImage(image, m);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
