using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void PbInsetCard_Click(object sender, EventArgs e)
        {
            var frmLanguage = new frmATM();
            frmLanguage.Show();
            this.Hide();
        }
       
        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            frmDeposit deposit = new frmDeposit();
            deposit.Show();
            Close();
        }
    }
}
