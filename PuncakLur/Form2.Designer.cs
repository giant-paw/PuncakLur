namespace PuncakLur
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnBooking = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnPendaki = new System.Windows.Forms.Button();
            this.btnBarang = new System.Windows.Forms.Button();
            this.btnBawaan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(347, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu Utama";
            // 
            // btnBooking
            // 
            this.btnBooking.Location = new System.Drawing.Point(135, 141);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(92, 33);
            this.btnBooking.TabIndex = 1;
            this.btnBooking.Text = "BOOKING";
            this.btnBooking.UseVisualStyleBackColor = true;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(135, 209);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 26);
            this.button2.TabIndex = 2;
            this.button2.Text = "ROMBONGAN";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPendaki
            // 
            this.btnPendaki.Location = new System.Drawing.Point(389, 187);
            this.btnPendaki.Name = "btnPendaki";
            this.btnPendaki.Size = new System.Drawing.Size(84, 23);
            this.btnPendaki.TabIndex = 3;
            this.btnPendaki.Text = "PENDAKI";
            this.btnPendaki.UseVisualStyleBackColor = true;
            // 
            // btnBarang
            // 
            this.btnBarang.Location = new System.Drawing.Point(135, 267);
            this.btnBarang.Name = "btnBarang";
            this.btnBarang.Size = new System.Drawing.Size(136, 28);
            this.btnBarang.TabIndex = 4;
            this.btnBarang.Text = "BARANG";
            this.btnBarang.UseVisualStyleBackColor = true;
            // 
            // btnBawaan
            // 
            this.btnBawaan.Location = new System.Drawing.Point(389, 252);
            this.btnBawaan.Name = "btnBawaan";
            this.btnBawaan.Size = new System.Drawing.Size(90, 30);
            this.btnBawaan.TabIndex = 5;
            this.btnBawaan.Text = "BARANG BAWAAN";
            this.btnBawaan.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBawaan);
            this.Controls.Add(this.btnBarang);
            this.Controls.Add(this.btnPendaki);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnBooking);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnPendaki;
        private System.Windows.Forms.Button btnBarang;
        private System.Windows.Forms.Button btnBawaan;
    }
}