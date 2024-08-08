namespace Essencore
{
    partial class frmBarcode
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblBarcode = new Label();
            label1 = new Label();
            txtPCBSerialNo = new TextBox();
            label2 = new Label();
            txtWorkorderNo = new TextBox();
            label3 = new Label();
            txtCustomerPartNo = new TextBox();
            label4 = new Label();
            txtDescription = new TextBox();
            label5 = new Label();
            txtCustomerSerialNo = new TextBox();
            label6 = new Label();
            rtbInstruction = new RichTextBox();
            printDialog1 = new PrintDialog();
            dgvBarcodeDetails = new DataGridView();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            btnClear = new Button();
            cmbProductType = new ComboBox();
            lblProductNo = new Label();
            pictureBox1 = new PictureBox();
            label10 = new Label();
            label11 = new Label();
            lblWeekNumber = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBarcodeDetails).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblBarcode
            // 
            lblBarcode.AutoSize = true;
            lblBarcode.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBarcode.Location = new Point(415, 9);
            lblBarcode.Name = "lblBarcode";
            lblBarcode.Size = new Size(270, 30);
            lblBarcode.TabIndex = 0;
            lblBarcode.Text = "BarCode Generation";
            lblBarcode.Click += lblBarcode_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 94);
            label1.Name = "label1";
            label1.Size = new Size(145, 17);
            label1.TabIndex = 1;
            label1.Text = "Syrma SGS Part No :";
            // 
            // txtPCBSerialNo
            // 
            txtPCBSerialNo.Location = new Point(23, 412);
            txtPCBSerialNo.Name = "txtPCBSerialNo";
            txtPCBSerialNo.Size = new Size(360, 23);
            txtPCBSerialNo.TabIndex = 6;
            txtPCBSerialNo.KeyDown += txtPCBSerialNo_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 149);
            label2.Name = "label2";
            label2.Size = new Size(127, 17);
            label2.TabIndex = 5;
            label2.Text = "Work Order No :";
            // 
            // txtWorkorderNo
            // 
            txtWorkorderNo.Location = new Point(20, 169);
            txtWorkorderNo.Name = "txtWorkorderNo";
            txtWorkorderNo.Size = new Size(363, 23);
            txtWorkorderNo.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(21, 205);
            label3.Name = "label3";
            label3.Size = new Size(146, 17);
            label3.TabIndex = 7;
            label3.Text = "Customer Part No :";
            // 
            // txtCustomerPartNo
            // 
            txtCustomerPartNo.Location = new Point(18, 225);
            txtCustomerPartNo.Name = "txtCustomerPartNo";
            txtCustomerPartNo.Size = new Size(365, 23);
            txtCustomerPartNo.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(20, 392);
            label4.Name = "label4";
            label4.Size = new Size(0, 17);
            label4.TabIndex = 9;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(20, 287);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(363, 23);
            txtDescription.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(20, 267);
            label5.Name = "label5";
            label5.Size = new Size(103, 17);
            label5.TabIndex = 11;
            label5.Text = "Description :";
            label5.Click += lblBarcode_Click;
            // 
            // txtCustomerSerialNo
            // 
            txtCustomerSerialNo.Location = new Point(21, 348);
            txtCustomerSerialNo.Name = "txtCustomerSerialNo";
            txtCustomerSerialNo.Size = new Size(362, 23);
            txtCustomerSerialNo.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(18, 328);
            label6.Name = "label6";
            label6.Size = new Size(151, 17);
            label6.TabIndex = 13;
            label6.Text = "Customer serial no:";
            // 
            // rtbInstruction
            // 
            rtbInstruction.Location = new Point(23, 500);
            rtbInstruction.Name = "rtbInstruction";
            rtbInstruction.Size = new Size(360, 88);
            rtbInstruction.TabIndex = 15;
            rtbInstruction.Text = "";
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // dgvBarcodeDetails
            // 
            dgvBarcodeDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBarcodeDetails.Location = new Point(415, 114);
            dgvBarcodeDetails.Name = "dgvBarcodeDetails";
            dgvBarcodeDetails.Size = new Size(702, 474);
            dgvBarcodeDetails.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(23, 392);
            label7.Name = "label7";
            label7.Size = new Size(106, 17);
            label7.TabIndex = 17;
            label7.Text = "PCB Serial no:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(23, 471);
            label8.Name = "label8";
            label8.Size = new Size(98, 17);
            label8.TabIndex = 18;
            label8.Text = "Instruction";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Showcard Gothic", 12F);
            label9.Location = new Point(415, 76);
            label9.Name = "label9";
            label9.Size = new Size(73, 20);
            label9.TabIndex = 19;
            label9.Text = "Report";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(23, 610);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 20;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click_1;
            // 
            // cmbProductType
            // 
            cmbProductType.FormattingEnabled = true;
            cmbProductType.Location = new Point(23, 112);
            cmbProductType.Name = "cmbProductType";
            cmbProductType.Size = new Size(360, 23);
            cmbProductType.TabIndex = 21;
            cmbProductType.SelectedIndexChanged += cmbProductType_SelectedIndexChanged;
            // 
            // lblProductNo
            // 
            lblProductNo.AutoSize = true;
            lblProductNo.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProductNo.Location = new Point(23, 438);
            lblProductNo.Name = "lblProductNo";
            lblProductNo.Size = new Size(0, 17);
            lblProductNo.TabIndex = 23;
            lblProductNo.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.SyrmaSgs;
            pictureBox1.Location = new Point(960, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(152, 50);
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // label10
            // 
            label10.AllowDrop = true;
            label10.AutoSize = true;
            label10.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(70, 22);
            label10.Name = "label10";
            label10.Size = new Size(100, 15);
            label10.TabIndex = 25;
            label10.Text = "08 August 2024";
            label10.Click += label10_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(20, 20);
            label11.Name = "label11";
            label11.Size = new Size(49, 17);
            label11.TabIndex = 26;
            label11.Text = "Date :";
            // 
            // lblWeekNumber
            // 
            lblWeekNumber.AutoSize = true;
            lblWeekNumber.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWeekNumber.Location = new Point(235, 21);
            lblWeekNumber.Name = "lblWeekNumber";
            lblWeekNumber.Size = new Size(50, 15);
            lblWeekNumber.TabIndex = 27;
            lblWeekNumber.Text = "12:53:18";
            lblWeekNumber.Click += lblWeekNumber_Click;
            // 
            // frmBarcode
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1147, 645);
            Controls.Add(lblWeekNumber);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(pictureBox1);
            Controls.Add(lblProductNo);
            Controls.Add(cmbProductType);
            Controls.Add(btnClear);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(dgvBarcodeDetails);
            Controls.Add(rtbInstruction);
            Controls.Add(txtCustomerSerialNo);
            Controls.Add(label6);
            Controls.Add(txtDescription);
            Controls.Add(label5);
            Controls.Add(txtCustomerPartNo);
            Controls.Add(label4);
            Controls.Add(txtWorkorderNo);
            Controls.Add(label3);
            Controls.Add(txtPCBSerialNo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblBarcode);
            Name = "frmBarcode";
            Text = "BarCode";
            Load += frmBarcode_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBarcodeDetails).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBarcode;
        private Label label1;
        private TextBox txtPCBSerialNo;
        private Label label2;
        private TextBox txtWorkorderNo;
        private Label label3;
        private TextBox txtCustomerPartNo;
        private Label label4;
        private TextBox txtDescription;
        private Label label5;
        private TextBox txtCustomerSerialNo;
        private Label label6;
        private RichTextBox rtbInstruction;
        private PrintDialog printDialog1;
        private DataGridView dgvBarcodeDetails;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button btnClear;
        private ComboBox cmbProductType;
        private Label lblProductNo;
        private PictureBox pictureBox1;
        private Label label10;
        private Label label11;
        private Label lblWeekNumber;
    }
}
