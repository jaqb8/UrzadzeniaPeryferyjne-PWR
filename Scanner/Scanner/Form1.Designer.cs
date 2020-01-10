namespace Scanner
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.searchCB = new System.Windows.Forms.ComboBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.scanBtn = new System.Windows.Forms.Button();
            this.bit = new System.Windows.Forms.PictureBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.brightnessLab = new System.Windows.Forms.Label();
            this.contrastLab = new System.Windows.Forms.Label();
            this.resolutionLab = new System.Windows.Forms.Label();
            this.colorCB = new System.Windows.Forms.ComboBox();
            this.colorLab = new System.Windows.Forms.Label();
            this.resolutionCB = new System.Windows.Forms.ComboBox();
            this.brightnessText = new System.Windows.Forms.TextBox();
            this.contrastText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bit)).BeginInit();
            this.SuspendLayout();
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "picture";
            // 
            // searchCB
            // 
            this.searchCB.FormattingEnabled = true;
            this.searchCB.Location = new System.Drawing.Point(32, 128);
            this.searchCB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchCB.Name = "searchCB";
            this.searchCB.Size = new System.Drawing.Size(243, 28);
            this.searchCB.TabIndex = 0;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(301, 128);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(136, 31);
            this.searchBtn.TabIndex = 1;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.findScanners);
            // 
            // scanBtn
            // 
            this.scanBtn.Location = new System.Drawing.Point(39, 493);
            this.scanBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.scanBtn.Name = "scanBtn";
            this.scanBtn.Size = new System.Drawing.Size(165, 54);
            this.scanBtn.TabIndex = 2;
            this.scanBtn.Text = "Scan";
            this.scanBtn.UseVisualStyleBackColor = true;
            this.scanBtn.Click += new System.EventHandler(this.scan);
            // 
            // bit
            // 
            this.bit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bit.Location = new System.Drawing.Point(493, 14);
            this.bit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bit.Name = "bit";
            this.bit.Size = new System.Drawing.Size(690, 676);
            this.bit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bit.TabIndex = 3;
            this.bit.TabStop = false;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(273, 490);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(164, 57);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.save);
            // 
            // brightnessLab
            // 
            this.brightnessLab.AutoSize = true;
            this.brightnessLab.Location = new System.Drawing.Point(73, 244);
            this.brightnessLab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.brightnessLab.Name = "brightnessLab";
            this.brightnessLab.Size = new System.Drawing.Size(85, 20);
            this.brightnessLab.TabIndex = 8;
            this.brightnessLab.Text = "Brightness";
            // 
            // contrastLab
            // 
            this.contrastLab.AutoSize = true;
            this.contrastLab.Location = new System.Drawing.Point(321, 244);
            this.contrastLab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.contrastLab.Name = "contrastLab";
            this.contrastLab.Size = new System.Drawing.Size(70, 20);
            this.contrastLab.TabIndex = 9;
            this.contrastLab.Text = "Contrast";
            // 
            // resolutionLab
            // 
            this.resolutionLab.AutoSize = true;
            this.resolutionLab.Location = new System.Drawing.Point(59, 356);
            this.resolutionLab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resolutionLab.Name = "resolutionLab";
            this.resolutionLab.Size = new System.Drawing.Size(85, 20);
            this.resolutionLab.TabIndex = 10;
            this.resolutionLab.Text = "Resolution";
            // 
            // colorCB
            // 
            this.colorCB.FormattingEnabled = true;
            this.colorCB.Items.AddRange(new object[] {
            "Black and white",
            "Colors"});
            this.colorCB.Location = new System.Drawing.Point(273, 390);
            this.colorCB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.colorCB.Name = "colorCB";
            this.colorCB.Size = new System.Drawing.Size(159, 28);
            this.colorCB.TabIndex = 11;
            this.colorCB.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // colorLab
            // 
            this.colorLab.AutoSize = true;
            this.colorLab.Location = new System.Drawing.Point(321, 356);
            this.colorLab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.colorLab.Name = "colorLab";
            this.colorLab.Size = new System.Drawing.Size(46, 20);
            this.colorLab.TabIndex = 12;
            this.colorLab.Text = "Color";
            // 
            // resolutionCB
            // 
            this.resolutionCB.FormattingEnabled = true;
            this.resolutionCB.Items.AddRange(new object[] {
            "150",
            "300",
            "600"});
            this.resolutionCB.Location = new System.Drawing.Point(32, 390);
            this.resolutionCB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.resolutionCB.Name = "resolutionCB";
            this.resolutionCB.Size = new System.Drawing.Size(159, 28);
            this.resolutionCB.TabIndex = 13;
            this.resolutionCB.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // brightnessText
            // 
            this.brightnessText.Location = new System.Drawing.Point(32, 292);
            this.brightnessText.Name = "brightnessText";
            this.brightnessText.Size = new System.Drawing.Size(159, 26);
            this.brightnessText.TabIndex = 14;
            this.brightnessText.Text = "0";
            // 
            // contrastText
            // 
            this.contrastText.Location = new System.Drawing.Point(273, 292);
            this.contrastText.Name = "contrastText";
            this.contrastText.Size = new System.Drawing.Size(159, 26);
            this.contrastText.TabIndex = 15;
            this.contrastText.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 704);
            this.Controls.Add(this.contrastText);
            this.Controls.Add(this.brightnessText);
            this.Controls.Add(this.resolutionCB);
            this.Controls.Add(this.colorLab);
            this.Controls.Add(this.colorCB);
            this.Controls.Add(this.resolutionLab);
            this.Controls.Add(this.contrastLab);
            this.Controls.Add(this.brightnessLab);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.bit);
            this.Controls.Add(this.scanBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchCB);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox searchCB;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button scanBtn;
        private System.Windows.Forms.PictureBox bit;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label brightnessLab;
        private System.Windows.Forms.Label contrastLab;
        private System.Windows.Forms.Label resolutionLab;
        private System.Windows.Forms.ComboBox colorCB;
        private System.Windows.Forms.Label colorLab;
        private System.Windows.Forms.ComboBox resolutionCB;
        private System.Windows.Forms.TextBox brightnessText;
        private System.Windows.Forms.TextBox contrastText;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

