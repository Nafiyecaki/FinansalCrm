using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinansalCrm;
using FinansalCrm.Models;

namespace FinansalCrm
{
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
        }
        FinansalCrmDbEntities db = new FinansalCrmDbEntities();

        private void btnCategory_Click(object sender, EventArgs e)
        {
            FrmCategory frm = new FrmCategory();
            frm.Show();
            this.Hide();

        }

        private void btnBanks_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.Show();
            this.Hide();
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            FrmInvoice frm = new FrmInvoice();
            frm.Show();
            this.Hide();

        }

        private void btnBilllForm_Click(object sender, EventArgs e)
        {
            FrmBilling frm = new FrmBilling();
            frm.Show();
            this.Hide();

        }

        private void btnBankProcess_Click(object sender, EventArgs e)
        {
            FrmBankProcess frm = new FrmBankProcess();
            frm.Show();
            this.Hide();

        }

        private void btnDashboardForm_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Hide();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            FrmSettings frm = new FrmSettings();
            frm.Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            FrmLogOut frm = new FrmLogOut();
            frm.Show();
            

        }

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            string girisZamani = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");

            lblSonGiris.Text = "Son Giriş: " + girisZamani;
        }

        private void btnİsimDüzenle_Click(object sender, EventArgs e)
        {
            string yeniIsim = Microsoft.VisualBasic.Interaction.InputBox("Yeni isminizi girin:", "İsim Düzenleme", lblName.Text);

            if (!string.IsNullOrWhiteSpace(yeniIsim))
            {
                lblName.Text = yeniIsim;
                MessageBox.Show("İsim başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

     


        private void btnEslesmisCihazlar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Eşleşmiş Cihaz: Nafiye adlı PC", "Bağlı Cihazlar", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnPasswordChanged_Click(object sender, EventArgs e)
        {
            FrmChangePassword frm = new FrmChangePassword();
            frm.ShowDialog(); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmAcikKullanimTercihi frm = new FrmAcikKullanimTercihi();
            frm.Show();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmİletisimEkle frm = new FrmİletisimEkle();
            frm.Show();
        

        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Ahi Evran Üniversitesi Merkez / Kırşehir ", "Kart gönderim Adresi");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmATM frm = new FrmATM();
            frm.Show();
        }

        private void btnBankaİletisim_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TelNo : 444 1 1 333 ", "Banka İletişim Bilgileri");
        }
    }
}
