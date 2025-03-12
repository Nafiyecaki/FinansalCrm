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
    public partial class FrmLogOut : Form
    {
        public FrmLogOut()
        {
            InitializeComponent();
        }
        FinansalCrmDbEntities db = new FinansalCrmDbEntities();


        private void txtYes_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void txtNo_Click(object sender, EventArgs e)
        {

            this.Close(); 

        }
    }
}
