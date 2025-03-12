using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinansalCrm.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;


namespace FinansalCrm
{
    public partial class FrmBankProcess : Form
    {
        private Timer timer;
        private int index = 0;

        public FrmBankProcess()
        {
            InitializeComponent();

            timer = new Timer { Interval = 3000 };
            timer.Tick += timer1_Tick;
            timer.Start();

        }
    

        FinansalCrmDbEntities db = new FinansalCrmDbEntities();

      
        private void FrmBankProcess_Load(object sender, EventArgs e)
        {
            var values = db.BankProcesses.ToList();
            dataGridView1.DataSource = values;


            // chart  kodları
            var bankProcessData = db.BankProcesses.Select(x => new
            {
                x.BankProcessId,
                x.Amount
            }).ToList();
            chart1.Series.Clear();
            var series = chart1.Series.Add("Series1");
            foreach (var item in bankProcessData)
            {
                series.Points.AddXY(item.BankProcessId, item.Amount);
            }
        


    }



private void timer1_Tick(object sender, EventArgs e)
        {
            var bankProcesses = db.BankProcesses.Select(x => new { x.ProcessType, x.Description }).ToList();
            if (bankProcesses.Count == 0) return;

            var currentProcess = bankProcesses[index];
            lblProcessType.Text = currentProcess.ProcessType;
            lblDescription.Text = currentProcess.Description;
            index = (index + 1) % bankProcesses.Count;

        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            FrmCategory frm = new FrmCategory();    
            frm.Show();
            this.Hide();
                
        }

        private void btnBanksForm_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.Show();
            this.Hide();
        }

        private void btnBillForm_Click(object sender, EventArgs e)
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

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
              frm.Show();
            this.Hide();
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            FrmInvoice frm = new FrmInvoice();
            frm.Show();
            this.Hide();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            FrmSettings frm = new FrmSettings();
            frm.Show();
            this.Hide();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {

            FrmLogOut frm = new FrmLogOut();
            frm.Show();
         

        }


    }
}
