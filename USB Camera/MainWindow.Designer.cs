namespace USBCam
{
    partial class MainWindow
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
            this.searchButton = new System.Windows.Forms.Button();
            this.camListCmb = new System.Windows.Forms.ComboBox();
            this.view = new System.Windows.Forms.PictureBox();
            this.deviceLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.screenButton = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.recordButton = new System.Windows.Forms.Button();
            this.buttonStopRecordingCamOne = new System.Windows.Forms.Button();
            this.brightnessLabel = new System.Windows.Forms.Label();
            this.saturationLabel = new System.Windows.Forms.Label();
            this.contrastLabel = new System.Windows.Forms.Label();
            this.brightnessTB = new System.Windows.Forms.TextBox();
            this.saturationTB = new System.Windows.Forms.TextBox();
            this.contrastTB = new System.Windows.Forms.TextBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.stopRecordButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.view)).BeginInit();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(217, 14);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(204, 35);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "Search devices";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // camListCmb
            // 
            this.camListCmb.FormattingEnabled = true;
            this.camListCmb.Location = new System.Drawing.Point(22, 87);
            this.camListCmb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.camListCmb.Name = "camListCmb";
            this.camListCmb.Size = new System.Drawing.Size(596, 28);
            this.camListCmb.TabIndex = 1;
            // 
            // view
            // 
            this.view.Location = new System.Drawing.Point(23, 125);
            this.view.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(595, 417);
            this.view.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.view.TabIndex = 3;
            this.view.TabStop = false;
            // 
            // deviceLabel
            // 
            this.deviceLabel.AutoSize = true;
            this.deviceLabel.Location = new System.Drawing.Point(18, 62);
            this.deviceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.deviceLabel.Name = "deviceLabel";
            this.deviceLabel.Size = new System.Drawing.Size(69, 20);
            this.deviceLabel.TabIndex = 4;
            this.deviceLabel.Text = "Camera:";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(23, 552);
            this.startButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(98, 35);
            this.startButton.TabIndex = 7;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.start);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(129, 552);
            this.stopButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(98, 35);
            this.stopButton.TabIndex = 8;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stop);
            // 
            // screenButton
            // 
            this.screenButton.Location = new System.Drawing.Point(236, 552);
            this.screenButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.screenButton.Name = "screenButton";
            this.screenButton.Size = new System.Drawing.Size(98, 35);
            this.screenButton.TabIndex = 11;
            this.screenButton.Text = "Picture";
            this.screenButton.UseVisualStyleBackColor = true;
            this.screenButton.Click += new System.EventHandler(this.screenshot);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "picture";
            // 
            // recordButton
            // 
            this.recordButton.Location = new System.Drawing.Point(343, 552);
            this.recordButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.recordButton.Name = "recordButton";
            this.recordButton.Size = new System.Drawing.Size(134, 35);
            this.recordButton.TabIndex = 13;
            this.recordButton.Text = "Start Recording";
            this.recordButton.UseVisualStyleBackColor = true;
            this.recordButton.Click += new System.EventHandler(this.record);
            // 
            // buttonStopRecordingCamOne
            // 
            this.buttonStopRecordingCamOne.Location = new System.Drawing.Point(0, 0);
            this.buttonStopRecordingCamOne.Name = "buttonStopRecordingCamOne";
            this.buttonStopRecordingCamOne.Size = new System.Drawing.Size(75, 23);
            this.buttonStopRecordingCamOne.TabIndex = 0;
            // 
            // brightnessLabel
            // 
            this.brightnessLabel.AutoSize = true;
            this.brightnessLabel.Location = new System.Drawing.Point(49, 622);
            this.brightnessLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.brightnessLabel.Name = "brightnessLabel";
            this.brightnessLabel.Size = new System.Drawing.Size(85, 20);
            this.brightnessLabel.TabIndex = 15;
            this.brightnessLabel.Text = "Brightness";
            // 
            // saturationLabel
            // 
            this.saturationLabel.AutoSize = true;
            this.saturationLabel.Location = new System.Drawing.Point(49, 699);
            this.saturationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.saturationLabel.Name = "saturationLabel";
            this.saturationLabel.Size = new System.Drawing.Size(83, 20);
            this.saturationLabel.TabIndex = 16;
            this.saturationLabel.Text = "Saturation";
            // 
            // contrastLabel
            // 
            this.contrastLabel.AutoSize = true;
            this.contrastLabel.Location = new System.Drawing.Point(49, 661);
            this.contrastLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.contrastLabel.Name = "contrastLabel";
            this.contrastLabel.Size = new System.Drawing.Size(70, 20);
            this.contrastLabel.TabIndex = 17;
            this.contrastLabel.Text = "Contrast";
            // 
            // brightnessTB
            // 
            this.brightnessTB.Location = new System.Drawing.Point(186, 616);
            this.brightnessTB.Name = "brightnessTB";
            this.brightnessTB.Size = new System.Drawing.Size(149, 26);
            this.brightnessTB.TabIndex = 18;
            this.brightnessTB.Text = "0";
            this.brightnessTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // saturationTB
            // 
            this.saturationTB.Location = new System.Drawing.Point(186, 696);
            this.saturationTB.Name = "saturationTB";
            this.saturationTB.Size = new System.Drawing.Size(149, 26);
            this.saturationTB.TabIndex = 19;
            this.saturationTB.Text = "0";
            this.saturationTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // contrastTB
            // 
            this.contrastTB.Location = new System.Drawing.Point(186, 655);
            this.contrastTB.Name = "contrastTB";
            this.contrastTB.Size = new System.Drawing.Size(149, 26);
            this.contrastTB.TabIndex = 20;
            this.contrastTB.Text = "0";
            this.contrastTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(387, 616);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(199, 106);
            this.confirmButton.TabIndex = 21;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirm);
            // 
            // stopRecordButton
            // 
            this.stopRecordButton.Location = new System.Drawing.Point(484, 552);
            this.stopRecordButton.Name = "stopRecordButton";
            this.stopRecordButton.Size = new System.Drawing.Size(134, 35);
            this.stopRecordButton.TabIndex = 22;
            this.stopRecordButton.Text = "Stop Recording";
            this.stopRecordButton.UseVisualStyleBackColor = true;
            this.stopRecordButton.Click += new System.EventHandler(this.stopRecording);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 781);
            this.Controls.Add(this.stopRecordButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.contrastTB);
            this.Controls.Add(this.saturationTB);
            this.Controls.Add(this.brightnessTB);
            this.Controls.Add(this.contrastLabel);
            this.Controls.Add(this.saturationLabel);
            this.Controls.Add(this.brightnessLabel);
            this.Controls.Add(this.recordButton);
            this.Controls.Add(this.screenButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.deviceLabel);
            this.Controls.Add(this.view);
            this.Controls.Add(this.camListCmb);
            this.Controls.Add(this.searchButton);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainWindow";
            this.Text = "USB Camera";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ComboBox camListCmb;
        private System.Windows.Forms.PictureBox view;
        private System.Windows.Forms.Label deviceLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button screenButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button recordButton;
        private System.Windows.Forms.Button buttonStopRecordingCamOne;
        private System.Windows.Forms.Label brightnessLabel;
        private System.Windows.Forms.Label saturationLabel;
        private System.Windows.Forms.Label contrastLabel;
        private System.Windows.Forms.TextBox brightnessTB;
        private System.Windows.Forms.TextBox saturationTB;
        private System.Windows.Forms.TextBox contrastTB;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button stopRecordButton;
    }
}

