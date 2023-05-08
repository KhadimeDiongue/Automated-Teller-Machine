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
    public partial class frmBalance : Form
    {
        public frmBalance()
        {
            InitializeComponent();
        }
        private static readonly int CHARGES = 6; //per hundred rand
        public  int avail = BankCharges(frmWelcome.availBalance, CHARGES);
        private void frmBalance_Load(object sender, EventArgs e)
        {
            lblTotalBalance.Text = $"{frmWelcome.availBalance:c}";
            lblAvailBalance.Text = $"{avail:c}";
        }
        static int BankCharges(int amount, int charges)
        {
            return amount = amount - ((amount / 100) * charges); 
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Show();
            this.Close();
        }
    }
}
