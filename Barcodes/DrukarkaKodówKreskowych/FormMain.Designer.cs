namespace DrukarkaKodówKreskowych
{
    partial class FormMain
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
            this.button_generate = new System.Windows.Forms.Button();
            this.text_box_bar_codedigits = new System.Windows.Forms.TextBox();
            this.label_barcode = new System.Windows.Forms.Label();
            this.picture_box_bar_code = new System.Windows.Forms.PictureBox();
            this.button_print_barcode = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picture_box_bar_code)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGenerate
            // 
            this.button_generate.Location = new System.Drawing.Point(19, 364);
            this.button_generate.Name = "buttonGenerate";
            this.button_generate.Size = new System.Drawing.Size(160, 46);
            this.button_generate.TabIndex = 0;
            this.button_generate.Text = "Generuj obraz";
            this.button_generate.UseVisualStyleBackColor = true;
            this.button_generate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // textBoxBarCodeDigits
            // 
            this.text_box_bar_codedigits.Location = new System.Drawing.Point(132, 37);
            this.text_box_bar_codedigits.Name = "textBoxBarCodeDigits";
            this.text_box_bar_codedigits.Size = new System.Drawing.Size(242, 26);
            this.text_box_bar_codedigits.TabIndex = 1;
            // 
            // labelBarCode
            // 
            this.label_barcode.AutoSize = true;
            this.label_barcode.Location = new System.Drawing.Point(15, 37);
            this.label_barcode.Name = "labelBarCode";
            this.label_barcode.Size = new System.Drawing.Size(107, 20);
            this.label_barcode.TabIndex = 2;
            this.label_barcode.Text = "Wpisz 12 cyfr:";
            // 
            // picture_box_bar_code
            // 
            this.picture_box_bar_code.Location = new System.Drawing.Point(33, 86);
            this.picture_box_bar_code.Name = "picture_box_bar_code";
            this.picture_box_bar_code.Size = new System.Drawing.Size(355, 239);
            this.picture_box_bar_code.TabIndex = 3;
            this.picture_box_bar_code.TabStop = false;
            // 
            // buttonPrintBarCode
            // 
            this.button_print_barcode.Location = new System.Drawing.Point(214, 364);
            this.button_print_barcode.Name = "buttonPrintBarCode";
            this.button_print_barcode.Size = new System.Drawing.Size(160, 46);
            this.button_print_barcode.TabIndex = 4;
            this.button_print_barcode.Text = "Drukuj";
            this.button_print_barcode.UseVisualStyleBackColor = true;
            this.button_print_barcode.Click += new System.EventHandler(this.buttonPrintBarCode_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 462);
            this.Controls.Add(this.button_print_barcode);
            this.Controls.Add(this.picture_box_bar_code);
            this.Controls.Add(this.label_barcode);
            this.Controls.Add(this.text_box_bar_codedigits);
            this.Controls.Add(this.button_generate);
            this.Name = "FormMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picture_box_bar_code)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_generate;
        private System.Windows.Forms.TextBox text_box_bar_codedigits;
        private System.Windows.Forms.Label label_barcode;
        private System.Windows.Forms.PictureBox picture_box_bar_code;
        private System.Windows.Forms.Button button_print_barcode;
    }
}

