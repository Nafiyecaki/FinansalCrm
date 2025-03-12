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
    public partial class FrmInvoice : Form
    {
        public FrmInvoice()
        {
            InitializeComponent();
        }
        FinansalCrmDbEntities db = new FinansalCrmDbEntities();

        private void FrmInvoice_Load(object sender, EventArgs e)
        {
            
            var values = db.Invoice.ToList();
            dataGridView1.DataSource = values;
        }

    

        private void cBelektrik_CheckedChanged(object sender, EventArgs e)
        {
            if (cBelektrik.Checked == true)
            {
                lblElektrik.Text = "Elektrik Faturası Ödendi";
            }
            else
            {
                lblElektrik.Text = "Elektrik Faturası Ödenmedi";
            }
           
        }

        private void cBdogalgaz_CheckedChanged(object sender, EventArgs e)
        {
            if (cBdogalgaz.Checked == true)
            {
                lblDogalgaz.Text = "Doğalgaz Faturası Ödendi";
            }
            else
            {
                lblDogalgaz.Text = "Doğalgaz Faturası Ödenmedi";
            }
        }

        private void cBsu_CheckedChanged(object sender, EventArgs e)
        {
            if (cBsu.Checked == true)
            {
                lblSu.Text = "Su Faturası Ödendi";
            }
            else
            {
                lblSu.Text = "Su Faturası Ödenmedi";
            }
        }

        private void cbinternet_CheckedChanged(object sender, EventArgs e)
        {
            if(cbinternet.Checked == true)
            {
                lblInternet.Text = "İnternet Faturası Ödendi";
            }
            else
            {
                lblInternet.Text = "İnternet Faturası Ödenmedi";
            }
        }

        private void cBtelefon_CheckedChanged(object sender, EventArgs e)
        {
            if(cBtelefon.Checked == true)
            {
                lblTelefon.Text = "Telefon Faturası Ödendi";
            }
            else
            {
                lblTelefon.Text = "Telefon Faturası Ödenmedi";
            }
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            FrmCategory frmCategory = new FrmCategory();
            frmCategory.Show();
            this.Hide();

        }

        private void btnBanksForm_Click(object sender, EventArgs e)
        {
            FrmBanks frmBanks = new FrmBanks();
            frmBanks.Show();
            this.Hide();
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            FrmInvoice frmInvoice = new FrmInvoice();
            frmInvoice.Show();
            this.Hide();
        }

        private void btnBillForm_Click(object sender, EventArgs e)
        {
            FrmBilling frmBilling = new FrmBilling();
            frmBilling.Show();
            this.Hide();
        }

        private void btnBankProcess_Click(object sender, EventArgs e)
        {
            FrmBankProcess frmBankProcess = new FrmBankProcess();
            frmBankProcess.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard frmDashboard = new FrmDashboard();
            frmDashboard.Show();
            this.Hide();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            FrmSettings frmSettings = new FrmSettings();
            frmSettings.Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            FrmLogOut frmLogOut = new FrmLogOut();
            frmLogOut.Show();

        }

     
    }
}
