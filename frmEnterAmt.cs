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
    public partial class frmEnterAmt : Form
    {
        public frmEnterAmt()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            
            string[] field = txtReqAmt.Text.Split('-');
            string s = field[0], validatedAmt = "";

            //Removing preceding underscores '_'
            int i = 0;
            while (i < s.Length)
            {
                if (s[i] != '_')
                    validatedAmt += s[i];
                i++;
            }

            int requestedAmt = int.Parse(validatedAmt);

            if (requestedAmt >= 20)
            {
                frmWelcome welcome = new frmWelcome();
                welcome.Withdraw(requestedAmt);
                if(welcome.isEnough)
                    Close();
            }
            else
            {
                MessageBox.Show($"Cannot dispense amounts less than {20:c}");
            }
           
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Show();
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtReqAmt.Clear();
        }
    }
}
