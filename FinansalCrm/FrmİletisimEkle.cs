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
using Microsoft.VisualBasic.Devices;

namespace FinansalCrm
{
    public partial class FrmİletisimEkle : Form
    {
        public FrmİletisimEkle()
        {
            InitializeComponent();
        }
        FinansalCrmDbEntities db = new FinansalCrmDbEntities();

        private void FrmİletisimEkle_Load(object sender, EventArgs e)
        {
            var values = db.Communication.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string ePosta = txtEposta.Text;
           

            Communication communication = new Communication();
            communication.E_posta = ePosta;
           
            db.Communication.Add(communication);
            db.SaveChanges();
            MessageBox.Show("E-posta Başarılı Şekilde Sisteme Eklendi", "E-POSTA ",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = db.Communication.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtEpostaId.Text);
            var removeValue = db.Communication.Find(id);
            db.Communication.Remove(removeValue);

            db.SaveChanges();
            MessageBox.Show("E-posta Başarılı Bir Şekilde Sistemden Silindi", "Ödeme & Faturalar",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = db.Communication.ToList();
            dataGridView1.DataSource = values;
        }
    }
}
