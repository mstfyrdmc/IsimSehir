namespace WFAIsımSehir
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
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSehir = new System.Windows.Forms.Label();
            this.btnAd = new System.Windows.Forms.Button();
            this.btnSehir = new System.Windows.Forms.Button();
            this.btnEsle = new System.Windows.Forms.Button();
            this.txtSehir = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(49, 53);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(190, 35);
            this.txtAd.TabIndex = 0;
            // 
            // lblAd
            // 
            this.lblAd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAd.Location = new System.Drawing.Point(49, 145);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(190, 206);
            this.lblAd.TabIndex = 1;
            // 
            // lblSehir
            // 
            this.lblSehir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSehir.Location = new System.Drawing.Point(298, 145);
            this.lblSehir.Name = "lblSehir";
            this.lblSehir.Size = new System.Drawing.Size(205, 206);
            this.lblSehir.TabIndex = 1;
            // 
            // btnAd
            // 
            this.btnAd.Location = new System.Drawing.Point(49, 106);
            this.btnAd.Name = "btnAd";
            this.btnAd.Size = new System.Drawing.Size(75, 23);
            this.btnAd.TabIndex = 2;
            this.btnAd.Text = "İsim Ekle";
            this.btnAd.UseVisualStyleBackColor = true;
            this.btnAd.Click += new System.EventHandler(this.btnAd_Click);
            // 
            // btnSehir
            // 
            this.btnSehir.Location = new System.Drawing.Point(298, 106);
            this.btnSehir.Name = "btnSehir";
            this.btnSehir.Size = new System.Drawing.Size(75, 23);
            this.btnSehir.TabIndex = 2;
            this.btnSehir.Text = "Şehir Ekle";
            this.btnSehir.UseVisualStyleBackColor = true;
            this.btnSehir.Click += new System.EventHandler(this.btnSehir_Click);
            // 
            // btnEsle
            // 
            this.btnEsle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEsle.Location = new System.Drawing.Point(382, 373);
            this.btnEsle.Name = "btnEsle";
            this.btnEsle.Size = new System.Drawing.Size(118, 44);
            this.btnEsle.TabIndex = 2;
            this.btnEsle.Text = "Eşleştir";
            this.btnEsle.UseVisualStyleBackColor = true;
            this.btnEsle.Click += new System.EventHandler(this.btnEsle_Click);
            // 
            // txtSehir
            // 
            this.txtSehir.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSehir.Location = new System.Drawing.Point(298, 53);
            this.txtSehir.Name = "txtSehir";
            this.txtSehir.Size = new System.Drawing.Size(202, 35);
            this.txtSehir.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 461);
            this.Controls.Add(this.btnEsle);
            this.Controls.Add(this.btnSehir);
            this.Controls.Add(this.btnAd);
            this.Controls.Add(this.lblSehir);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.txtSehir);
            this.Controls.Add(this.txtAd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSehir;
        private System.Windows.Forms.Button btnAd;
        private System.Windows.Forms.Button btnSehir;
        private System.Windows.Forms.Button btnEsle;
        private System.Windows.Forms.TextBox txtSehir;
    }
}

