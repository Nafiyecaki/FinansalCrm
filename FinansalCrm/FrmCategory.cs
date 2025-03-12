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
    public partial class FrmCategory : Form
    {
        public FrmCategory()
        {
            InitializeComponent();
        }
        FinansalCrmDbEntities db = new FinansalCrmDbEntities();
        private void FrmCategory_Load(object sender, EventArgs e)
        {
            var values = db.Categories.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnCategoriList_Click(object sender, EventArgs e)
        {
            var values = db.Categories.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnUpdateCategori_Click(object sender, EventArgs e)
        {
            string name = txtCategoryName.Text;
            int id = int.Parse(txtCategoryId.Text);

            var values = db.Categories.Find(id);


            values.CategoryName = name;
            db.SaveChanges();
            MessageBox.Show("Kategori Başarılı Bir Şekilde Güncellendi ", "Kategori",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values2 = db.Categories.ToList();
            dataGridView1.DataSource = values2;


        }

        private void btnRemoveCategori_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCategoryId.Text);
            var removeValue = db.Categories.Find(id);
            db.Categories.Remove(removeValue);

            db.SaveChanges();
            MessageBox.Show("Kategori Başarılı Bir Şekilde Sistemden Silindi", "Kategori",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = db.Categories.ToList();
            dataGridView1.DataSource = values;

        }

        private void btnCreateCategori_Click(object sender, EventArgs e)
        {
            string name = txtCategoryName.Text;

            Categories categories = new Categories();

            categories.CategoryName = name;

            db.Categories.Add(categories);
            db.SaveChanges();
            MessageBox.Show("Kategori İsmi  Başarılı Bir Şekilde Sisteme Eklendi", "Kategori",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = db.Categories.ToList();
            dataGridView1.DataSource = values;
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

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Hide();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            FrmCategory frm = new FrmCategory();    
            frm.Show();
            this.Hide();
        }

        private void btnBankProcess_Click(object sender, EventArgs e)
        {
            FrmBankProcess frm = new FrmBankProcess();
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

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            FrmLogOut frm = new FrmLogOut();
            frm.Show();
           
        }
    }
}
