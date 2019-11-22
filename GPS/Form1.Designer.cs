using System;
using System.Globalization;

namespace WindowsFormsApp1
{
    partial class GPS
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
            this.components = new System.ComponentModel.Container();
            this.button_send = new System.Windows.Forms.Button();
            this.label_longitude_text = new System.Windows.Forms.Label();
            this.label_latitude = new System.Windows.Forms.Label();
            this.label_latitude_text = new System.Windows.Forms.Label();
            this.label_longitude = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button_map = new System.Windows.Forms.Button();
            this.label_time = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_send
            // 
            this.button_send.Location = new System.Drawing.Point(81, 201);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(145, 42);
            this.button_send.TabIndex = 0;
            this.button_send.Text = "Wyślij pozycje";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_longitude_text
            // 
            this.label_longitude_text.AutoSize = true;
            this.label_longitude_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_longitude_text.Location = new System.Drawing.Point(38, 92);
            this.label_longitude_text.Name = "label_longitude_text";
            this.label_longitude_text.Size = new System.Drawing.Size(98, 20);
            this.label_longitude_text.TabIndex = 1;
            this.label_longitude_text.Text = "Szerokość:";
            this.label_longitude_text.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_latitude
            // 
            this.label_latitude.AutoSize = true;
            this.label_latitude.Location = new System.Drawing.Point(248, 53);
            this.label_latitude.Name = "label_latitude";
            this.label_latitude.Size = new System.Drawing.Size(0, 20);
            this.label_latitude.TabIndex = 2;
            // 
            // label_latitude_text
            // 
            this.label_latitude_text.AutoSize = true;
            this.label_latitude_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_latitude_text.Location = new System.Drawing.Point(38, 53);
            this.label_latitude_text.Name = "label_latitude_text";
            this.label_latitude_text.Size = new System.Drawing.Size(80, 20);
            this.label_latitude_text.TabIndex = 3;
            this.label_latitude_text.Text = "Długość:";
            // 
            // label_longitude
            // 
            this.label_longitude.AutoSize = true;
            this.label_longitude.Location = new System.Drawing.Point(248, 92);
            this.label_longitude.Name = "label_longitude";
            this.label_longitude.Size = new System.Drawing.Size(0, 20);
            this.label_longitude.TabIndex = 4;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button_map
            // 
            this.button_map.Location = new System.Drawing.Point(252, 201);
            this.button_map.Name = "button_map";
            this.button_map.Size = new System.Drawing.Size(172, 42);
            this.button_map.TabIndex = 8;
            this.button_map.Text = "Pokaż na mapie";
            this.button_map.UseVisualStyleBackColor = true;
            this.button_map.Click += new System.EventHandler(this.button3_Click);
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_time.Location = new System.Drawing.Point(38, 144);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(81, 20);
            this.label_time.TabIndex = 6;
            this.label_time.Text = "Godzina:";
            this.label_time.Click += new System.EventHandler(this.label2_Click);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Location = new System.Drawing.Point(248, 144);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(0, 20);
            this.time.TabIndex = 7;
            this.time.Click += new System.EventHandler(this.time_Click);
            // 
            // GPS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 325);
            this.Controls.Add(this.button_map);
            this.Controls.Add(this.time);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.label_longitude);
            this.Controls.Add(this.label_latitude_text);
            this.Controls.Add(this.label_latitude);
            this.Controls.Add(this.label_longitude_text);
            this.Controls.Add(this.button_send);
            this.Name = "GPS";
            this.Text = "GPS";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_longitude_text;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Label label_latitude_text;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label label_latitude;
        private System.Windows.Forms.Label label_longitude;

        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.Button button_map;

        private System.Windows.Forms.ErrorProvider errorProvider1;

    }
}

