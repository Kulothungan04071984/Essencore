//using System.ComponentModel;
//using System.Net.NetworkInformation;
//using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System;
using OfficeOpenXml;
//using ZXing.QrCode;
using System.Drawing.Imaging;
using System.Text;
//using Microsoft.VisualBasic;
using System.Drawing.Printing;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using BarTender;
//using Microsoft.Office.Interop.BarTender;
using System.Xml.Linq;
//using static OfficeOpenXml.ExcelErrorValue;
//using ZXing;
//using ZXing.QrCode;
//using ZXing.Common;
//using ZXing.Rendering;
//using System.Runtime.InteropServices;




namespace Essencore
{
    public partial class frmBarcode : Form
    {
        private StringBuilder barcodeData = new StringBuilder();
        DbConnection getConn = new DbConnection();
        private System.Windows.Forms.Timer blinkTimer;
        private bool isBlinking;
        private Color originalColor;

        public frmBarcode()
        {
            InitializeComponent();
            this.KeyPreview = true;

        }

        private void lblBarcode_Click(object sender, EventArgs e)
        {

        }

        private void btnBarcodePrint_Click(object sender, EventArgs e)
        {
            // Graphics g = e.Graphics;

            // Path to the Excel file
            //  string excelFilePath = "C:\\kulo\\SerialNumber.xlsx";

            // Read value from Excel
            // string value = ReadValueFromExcel(excelFilePath);


        }

        private void ProcessBarcode(string barcode)
        {
            if (cmbProductType.SelectedIndex != 0)
            {
                var bcode = getConn.DbConnect(barcode);

                if (bcode != "Duplicate" && bcode != "NotFound")
                {
                    string productNo = string.Empty;
                    rtbInstruction.Text = "Print Start";
                    rtbInstruction.BackColor = Color.LightGoldenrodYellow;
                    DataBindings();
                    printLabelBarcode(txtCustomerSerialNo.Text.ToString(), bcode.ToString());

                    lblProductNo.Text = bcode.ToString();
                    rtbInstruction.BackColor = Color.Empty;
                }
                else if (bcode == "Duplicate")
                {

                    txtPCBSerialNo.BackColor = Color.OrangeRed;

                    blinkTimer = new System.Windows.Forms.Timer
                    {
                        Interval = 500 // Set the interval to 500 milliseconds (0.5 seconds)
                    };
                    blinkTimer.Tick += (s, args) => BlinkTextBox();
                    blinkTimer.Start();
                    rtbInstruction.Text = "Duplicate";
                    rtbInstruction.BackColor = Color.OrangeRed;
                }
                else if (bcode == "NotFound")
                {
                    rtbInstruction.Text = "PCB Serial No Not Fount";
                    rtbInstruction.BackColor = Color.Gray;
                }
            }
            else if(cmbProductType.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select the Product Type");
            }
        }

        private void BlinkTextBox()
        {
            if (isBlinking)
            {
                txtPCBSerialNo.BackColor = Color.OrangeRed;
            }
            else
            {
                txtPCBSerialNo.BackColor = Color.Empty;
                //blinkTimer.Stop();// Change to the desired blink color
            }
            if (txtPCBSerialNo.Text == string.Empty)
            {
                blinkTimer.Stop();
                txtPCBSerialNo.BackColor = Color.Empty;
                txtDescription.Text = string.Empty;
            }

            isBlinking = !isBlinking;
        }



        //private void btnClear_Click(object sender, EventArgs e)
        //{
        //    txtCustomerPartNo.Text = string.Empty;
        //    txtPCBSerialNo.Text = string.Empty;
        //    txtCustomerSerialNo.Text = string.Empty;
        //}



        private void btnClear_Click_1(object sender, EventArgs e)
        {
            txtCustomerSerialNo.Text = string.Empty; 
            txtPCBSerialNo.Focus();
            txtPCBSerialNo.Text = string.Empty;
            txtSyrmaPartNo.Text = string.Empty;
            txtCustomerPartNo.Text=string.Empty;
            txtWorkorderNo.Text = string.Empty;
            txtDescription.Text=string.Empty;
            cmbProductType.SelectedIndex = 0;
            rtbInstruction.Text = string.Empty;
            rtbInstruction.BackColor = Color.Empty;
            txtPCBSerialNo.BackColor=Color.Empty;
        }


        public void printLabelBarcode(string productno, string cus_serialno)
        {
            string labelFormatPath = @"C:\kulo\kulo\BarCode.btw";

            var externalValues = new Dictionary<string, string>
        {
            { "SerialNumber", cus_serialno },
            { "ProductNumber", productno }
        };

            PrintLabel(labelFormatPath, externalValues);

        }

        public void PrintLabel(string labelFormatPath, Dictionary<string, string> values)
        {

            BarTender.Application btApp = null;
            BarTender.Format btFormat = null;

            try
            {
                // Initialize BarTender application
                btApp = new BarTender.Application();
                // btApp.Visible = true; // Optional: Makes the BarTender application visible

                // Open a BarTender document
                // string labelFile = @"C:\Path\To\Your\LabelFile.btw";
                btFormat = btApp.Formats.Open(labelFormatPath, false, "");

                // Set values for named data sources
                //btFormat.SetNamedSubStringValue("ProductName", values.Keys.ToString());
                //btFormat.SetNamedSubStringValue("ProductCode", values.Values.ToString());

                foreach (var param in values)
                {
                    btFormat.SetNamedSubStringValue(param.Key, param.Value);
                }


                // Print the document
                btFormat.PrintOut(false, false);

                // Close the document
                btFormat.Close(BtSaveOptions.btDoNotSaveChanges);

                rtbInstruction.Text = "Print Successfully Completed";



            }
            catch (COMException comEx)
            {
                MessageBox.Show("COM Error: " + comEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Quit the BarTender application
                if (btApp != null)
                {
                    btApp.Quit(BtSaveOptions.btDoNotSaveChanges);
                    Marshal.ReleaseComObject(btApp);
                }

                if (btFormat != null)
                {
                    Marshal.ReleaseComObject(btFormat);
                }
            }


        }

        private void txtPCBSerialNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Process the barcode
                //  ProcessBarcode(barcodeData.ToString());
                ProcessBarcode(txtPCBSerialNo.Text);

                barcodeData.Clear();
            }
            else
            {
                // Append the keystroke to the barcode data
                barcodeData.Append((char)e.KeyValue);
            }
        }

        public void DataBindings()
        {
            try
            {
                //dgvBarcodeDetails.AutoGenerateColumns = false;
                // dgvBarcodeDetails.Columns.Clear();
                //dgvBarcodeDetails.Columns.Add("Product No", typeof(string));
                string productNo = lblProductNo.Text.ToString();
                var barcodedetails = getConn.GetBarcodeDetails(productNo);
                dgvBarcodeDetails.DataSource = barcodedetails;
                dgvBarcodeDetails.Columns["ProductNo"].Width = 250;
                dgvBarcodeDetails.Columns["CustomerSerialNo"].Width = 250;
                dgvBarcodeDetails.Columns["PCBSerialNo"].Width = 250;
                dgvBarcodeDetails.Columns["SyrmaSGSPartno"].Visible = false;
                dgvBarcodeDetails.Columns["WorkOrderNo"].Visible = false;
                dgvBarcodeDetails.Columns["CustomerPartNo"].Visible = false;
                dgvBarcodeDetails.Columns["Bar_Description"].Visible = false;
                dgvBarcodeDetails.Columns["WeekDetails"].Visible = false;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void frmBarcode_Load(object sender, EventArgs e)
        {
            txtPCBSerialNo.Focus();
           // cmbProductType.Items.Insert(0, "Select ProductType");
           
            var lstLabelDetails = getConn.GetLabels();
            cmbProductType.DataSource = lstLabelDetails;
            cmbProductType.DisplayMember = "labelname";
            cmbProductType.ValueMember = "labelmasterid";
            cmbProductType.SelectedIndex = 0;

        }

        private void cmbProductType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbProductType.SelectedIndex != 0)
                {
                    int labelid = Convert.ToInt32(cmbProductType.SelectedValue);
                    var productdetails = getConn.GetProductDetails(labelid);
                    txtSyrmaPartNo.Text = productdetails.SyrmaSGSPartno;
                    txtWorkorderNo.Text = productdetails.WorkOrderNo;
                    txtCustomerPartNo.Text= productdetails.CustomerPartNo;
                    txtDescription.Text = productdetails.Bar_Description;
                    lblProductNo.Text = productdetails.ProductNo;

                }
                else
                {
                    txtSyrmaPartNo.Text = string.Empty;
                   
                }
                if (isBlinking)
                    blinkTimer.Stop();
            }
            catch(Exception ex)
            {  MessageBox.Show(ex.Message.ToString());}
        }
    }

}


            


    





