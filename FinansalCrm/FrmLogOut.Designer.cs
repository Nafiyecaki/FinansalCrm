namespace FinansalCrm
{
    partial class FrmLogOut
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
            this.txtYes = new System.Windows.Forms.Button();
            this.txtNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(108, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Çıkış Yapmak istiyor musunuz ?";
            // 
            // txtYes
            // 
            this.txtYes.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtYes.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtYes.Location = new System.Drawing.Point(134, 114);
            this.txtYes.Name = "txtYes";
            this.txtYes.Size = new System.Drawing.Size(96, 44);
            this.txtYes.TabIndex = 1;
            this.txtYes.Text = "Evet";
            this.txtYes.UseVisualStyleBackColor = false;
            this.txtYes.Click += new System.EventHandler(this.txtYes_Click);
            // 
            // txtNo
            // 
            this.txtNo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtNo.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtNo.Location = new System.Drawing.Point(254, 114);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(96, 44);
            this.txtNo.TabIndex = 2;
            this.txtNo.Text = "Hayır";
            this.txtNo.UseVisualStyleBackColor = false;
            this.txtNo.Click += new System.EventHandler(this.txtNo_Click);
            // 
            // FrmLogOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(468, 239);
            this.Controls.Add(this.txtNo);
            this.Controls.Add(this.txtYes);
            this.Controls.Add(this.label1);
            this.Name = "FrmLogOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Çıkış Yapma Formu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button txtYes;
        private System.Windows.Forms.Button txtNo;
    }
}