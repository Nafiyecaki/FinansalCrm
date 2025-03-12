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
    public partial class FrmChangePassword : Form
    {
        public FrmChangePassword()
        {
            InitializeComponent();
        }
        FinansalCrmDbEntities db = new FinansalCrmDbEntities();

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string eskiSifre = txtEskiSifre.Text.Trim();
            string yeniSifre = txtYeniSifre.Text.Trim();
            string yeniSifreTekrar = txtYeniSifreTekrar.Text.Trim();

            if (string.IsNullOrWhiteSpace(eskiSifre) || string.IsNullOrWhiteSpace(yeniSifre) || string.IsNullOrWhiteSpace(yeniSifreTekrar))
            {
                MessageBox.Show("Tüm alanları doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (yeniSifre != yeniSifreTekrar)
            {
                MessageBox.Show("Yeni şifreler eşleşmiyor!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            var kullanici = db.Users1.FirstOrDefault(u => u.userPassword == eskiSifre);

            if (kullanici == null)
            {
                MessageBox.Show("Eski şifre hatalı veya kullanıcı bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            kullanici.userPassword = yeniSifre;
            db.SaveChanges();

            MessageBox.Show("Şifre başarıyla değiştirildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

         this.Close();
        }

      
    }
}