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
    public partial class frmPIN : Form
    {
        public frmPIN()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var frmMenu = new frmMenu();
            frmMenu.Show();
            this.Close();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtPIN.Text = "";
            lblError.Text = "";
        }
        private int count = 0;
        public int passwordIndex;
        public static int enteredPin; 
        private void btnAccept_Click(object sender, EventArgs e)
        {
            var frmWelcome = new frmWelcome();
            var search = new Search();
            var userData = new UserData();

            if (count >= 3)
            {
                lblError.Text = "Card Blocked!";
                txtPIN.Enabled = false;
                MessageBox.Show("Your card has been blocked,\nplease consult with our branches for assistance", "Blocked", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                passwordIndex = search.LinearSearch(userData.passwords, int.Parse(txtPIN.Text));
                if (passwordIndex == -1)
                {
                    lblError.Text = "Incorrect PIN!";
                    count += 1;
                }
                else
                {
                    enteredPin = int.Parse(txtPIN.Text);
                    frmWelcome.Show();
                    this.Hide();
                    
                }
            }
            catch
            {
                lblError.Text = "Incomplete PIN!";
            }
            
            
        }
        
    }
}
