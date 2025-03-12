namespace FinansalCrm
{
    partial class FrmAcikKullanimTercihi
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
            this.rBOnay = new System.Windows.Forms.RadioButton();
            this.rBNotOnay = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rBOnay
            // 
            this.rBOnay.AutoSize = true;
            this.rBOnay.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rBOnay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rBOnay.Location = new System.Drawing.Point(26, 68);
            this.rBOnay.Name = "rBOnay";
            this.rBOnay.Size = new System.Drawing.Size(429, 25);
            this.rBOnay.TabIndex = 7;
            this.rBOnay.TabStop = true;
            this.rBOnay.Text = "Banka hesaplarımı diğer kurumlarla paylşamak istiyorum.";
            this.rBOnay.UseVisualStyleBackColor = true;
            // 
            // rBNotOnay
            // 
            this.rBNotOnay.AutoSize = true;
            this.rBNotOnay.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rBNotOnay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rBNotOnay.Location = new System.Drawing.Point(26, 113);
            this.rBNotOnay.Name = "rBNotOnay";
            this.rBNotOnay.Size = new System.Drawing.Size(429, 25);
            this.rBNotOnay.TabIndex = 8;
            this.rBNotOnay.TabStop = true;
            this.rBNotOnay.Text = "Banka hesaplarımı diğer kurumlarla paylşamak istiyorum.";
            this.rBNotOnay.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.rBNotOnay);
            this.groupBox1.Controls.Add(this.rBOnay);
            this.groupBox1.Location = new System.Drawing.Point(32, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(539, 251);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Paylaşmak istemiyorum tercihiniz ise bankamız hesaplarınızın diğer kurumlarla";
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnKaydet.Location = new System.Drawing.Point(368, 168);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(133, 58);
            this.btnKaydet.TabIndex = 9;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // FrmAcikKullanimTercihi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 331);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmAcikKullanimTercihi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAcikKullanimTercihi";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton rBOnay;
        private System.Windows.Forms.RadioButton rBNotOnay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnKaydet;
    }
}