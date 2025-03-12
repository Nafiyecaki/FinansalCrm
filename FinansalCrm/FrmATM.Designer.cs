namespace FinansalCrm
{
    partial class FrmATM
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
            this.btnKaydet = new System.Windows.Forms.Button();
            this.rBEposta = new System.Windows.Forms.RadioButton();
            this.rBIstiyorum = new System.Windows.Forms.RadioButton();
            this.rBIstemiyorum = new System.Windows.Forms.RadioButton();
            this.rBHerislem = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnKaydet.Location = new System.Drawing.Point(309, 201);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(111, 56);
            this.btnKaydet.TabIndex = 11;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.button1_Click);
            // 
            // rBEposta
            // 
            this.rBEposta.AutoSize = true;
            this.rBEposta.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rBEposta.Location = new System.Drawing.Point(53, 201);
            this.rBEposta.Name = "rBEposta";
            this.rBEposta.Size = new System.Drawing.Size(164, 25);
            this.rBEposta.TabIndex = 9;
            this.rBEposta.TabStop = true;
            this.rBEposta.Text = "E-posta gönderilsin";
            this.rBEposta.UseVisualStyleBackColor = true;
            // 
            // rBIstiyorum
            // 
            this.rBIstiyorum.AutoSize = true;
            this.rBIstiyorum.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rBIstiyorum.Location = new System.Drawing.Point(53, 156);
            this.rBIstiyorum.Name = "rBIstiyorum";
            this.rBIstiyorum.Size = new System.Drawing.Size(157, 25);
            this.rBIstiyorum.TabIndex = 8;
            this.rBIstiyorum.TabStop = true;
            this.rBIstiyorum.Text = "Makbuz istiyorum";
            this.rBIstiyorum.UseVisualStyleBackColor = true;
            // 
            // rBIstemiyorum
            // 
            this.rBIstemiyorum.AutoSize = true;
            this.rBIstemiyorum.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rBIstemiyorum.Location = new System.Drawing.Point(53, 112);
            this.rBIstemiyorum.Name = "rBIstemiyorum";
            this.rBIstemiyorum.Size = new System.Drawing.Size(180, 25);
            this.rBIstemiyorum.TabIndex = 7;
            this.rBIstemiyorum.TabStop = true;
            this.rBIstemiyorum.Text = "Makbuz istemiyorum";
            this.rBIstemiyorum.UseVisualStyleBackColor = true;
            // 
            // rBHerislem
            // 
            this.rBHerislem.AutoSize = true;
            this.rBHerislem.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rBHerislem.Location = new System.Drawing.Point(53, 68);
            this.rBHerislem.Name = "rBHerislem";
            this.rBHerislem.Size = new System.Drawing.Size(196, 25);
            this.rBHerislem.TabIndex = 6;
            this.rBHerislem.TabStop = true;
            this.rBHerislem.Text = "Her işlemimde sorulsun";
            this.rBHerislem.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.rBHerislem);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.rBIstemiyorum);
            this.groupBox1.Controls.Add(this.rBIstiyorum);
            this.groupBox1.Controls.Add(this.rBEposta);
            this.groupBox1.Location = new System.Drawing.Point(63, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 275);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ATM\'lerden hizmet alırken tercih edeceğiniz makbuz ";
            // 
            // FrmATM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 400);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmATM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATM Makbuz Tercihlerim";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.RadioButton rBEposta;
        private System.Windows.Forms.RadioButton rBIstiyorum;
        private System.Windows.Forms.RadioButton rBIstemiyorum;
        private System.Windows.Forms.RadioButton rBHerislem;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}