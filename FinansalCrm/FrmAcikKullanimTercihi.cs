using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinansalCrm
{
    public partial class FrmAcikKullanimTercihi : Form
    {
        public FrmAcikKullanimTercihi()
        {
            InitializeComponent();
        }

     


        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string secilenTercih = "";

            if (rBNotOnay.Checked)
                secilenTercih = "Onaylamıyorum";
            else
                secilenTercih = "Onaylıyorum";

            if (secilenTercih != "")
            {
                MessageBox.Show("Seçilen Onay Tercihi: " + secilenTercih, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                MessageBox.Show("Lütfen bir seçenek seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            this.Close();
        }

    }
}

   
