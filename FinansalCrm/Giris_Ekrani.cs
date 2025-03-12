using FinansalCrm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace FinansalCrm
{
    public partial class Giris_Ekrani : Form
    { 
        private FinansalCrmDbEntities db = new FinansalCrmDbEntities();
        public Giris_Ekrani()
        {
            InitializeComponent();

       

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtUsername.Text.Trim();
            string sifre = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(kullaniciAdi) || string.IsNullOrWhiteSpace(sifre))
            {
                MessageBox.Show("Lütfen kullanıcı adı ve şifre giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            var kullanici = db.Users1.FirstOrDefault(u => u.userName == kullaniciAdi && u.userPassword == sifre);

            if (kullanici != null)
            {
                FrmCategory frm = new FrmCategory();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}