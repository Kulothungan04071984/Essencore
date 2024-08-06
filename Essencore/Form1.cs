using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Essencore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            GenerateAndLoadBarcode("1234567890", "C:\\kulo\\barcode\\");

            //var barcodeWriter = new BarcodeWriter<Bitmap>
            //{
            //    Format = BarcodeFormat.CODE_128,
            //    Options = new ZXing.Common.EncodingOptions
            //    {
            //        Width = Convert.ToInt32(17 / 25.4 * 96),  // Convert mm to pixels (96 dpi)
            //        Height = Convert.ToInt32(5 / 25.4 * 96),
            //        PureBarcode = true
            //    }
            //};

            //// Generate the barcode
            //var barcodeBitmap = barcodeWriter.Write("1234567890");

            //// Save the barcode image
            //barcodeBitmap.Save("barcode.png", ImageFormat.Png);
        }

        private void GenerateAndLoadBarcode(string data, string outputPath)
        {
            try
            {
                // Generate barcode using Python script
                string pythonPath = "C:\\Users\\kulothungan\\AppData\\Local\\Programs\\Python\\Python312\\python.exe"; // Path to Python executable
                string scriptPath = "C:\\kulo\\bar.py"; // Path to Python script

                string args = $"\"{scriptPath}\" \"{data}\" \"{outputPath}\"";
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = pythonPath,
                    Arguments = args,
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };
                Process process = Process.Start(psi);
                process.WaitForExit();

                // Load the barcode image into PictureBox
                pictureBoxBarcode.Image = Image.FromFile(outputPath);
                pictureBoxBarcode.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating or loading barcode: {ex.Message}");
            }
        }


    }
}
