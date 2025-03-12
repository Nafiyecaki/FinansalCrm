using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinansalCrm.Models;

namespace FinansalCrm
{
    public partial class FrmATM : Form
    {
        public FrmATM()
        {
            InitializeComponent();
        }
        FinansalCrmDbEntities db = new FinansalCrmDbEntities();

        private void button1_Click(object sender, EventArgs e)
        {
            string secilenTercih = "";

            if (rBHerislem.Checked)
                secilenTercih = "Her işlemimde sorulsun";
            else if (rBIstemiyorum.Checked)
                secilenTercih = "Makbuz istemiyorum";
            else if (rBIstiyorum.Checked)
                secilenTercih = "Makbuz istiyorum";
            else if (rBEposta.Checked)
                secilenTercih = "E-posta gönderilsin";

            if (secilenTercih != "")
            {
                MessageBox.Show("Seçilen Makbuz Tercihi: " + secilenTercih, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
             
            }
            else
            {
                MessageBox.Show("Lütfen bir seçenek seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            this.Close();
        }
   
    }
}
