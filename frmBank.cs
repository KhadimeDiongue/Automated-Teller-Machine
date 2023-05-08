using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ATM
{
    public partial class frmBank : Form
    {
        public frmBank()
        {
            InitializeComponent();
        }
        public static readonly string fileName = "UserAccounts.txt";
        public static readonly string accBalanceFileName = "AvailableBalance.txt";
        public static int mininumDep = 40;
        private static bool noInformation;
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            noInformation = txtName.Text == "" || txtSurname.Text == "" || txtIDNumber.Text == "" || txtDepostAmt.Text == "" || txtPin.Text == "";

            if (noInformation)
                MessageBox.Show("Please fill in all REQUIRED information to create an account","Error", MessageBoxButtons.RetryCancel ,MessageBoxIcon.Error);
            else
            {
                if (int.Parse(txtDepostAmt.Text) >= mininumDep)
                {
                    StreamWriter write = new StreamWriter(fileName, true);
                    string record = $"{txtName.Text}\t{txtSurname.Text}\t{txtIDNumber.Text}\t{txtAccountNr.Text}\t{txtPin.Text}";
                    write.WriteLine(record);
                    write.Close();
                    StreamWriter balance = new StreamWriter(accBalanceFileName, true);
                    balance.WriteLine(txtDepostAmt.Text);
                    balance.Close();

                    MessageBox.Show("Account created succesfully!,\ncheck your balance on the ATM", "Banking", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //resetting texts and changing the account number
                    txtName.Clear();
                    txtIDNumber.Clear();
                    txtSurname.Clear();
                    txtAccountNr.Text = GenerateAccountNr();
                    txtDepostAmt.Clear();
                    txtPin.Clear();
                }
                else
                {
                    MessageBox.Show($"First Deposit cannot be less than {mininumDep:c}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private static string GenerateAccountNr()
        {
            string accountNumber = "";

            Random random = new Random();

            int i = 0;
            while(i < 12)
            {
                accountNumber += random.Next(0, 10);
                i++;
            }

            return accountNumber;
        }

        private void frmBank_Load(object sender, EventArgs e)
        {
            txtAccountNr.Text = GenerateAccountNr();
            txtAccountNr.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmGoTo outside = new frmGoTo();
            outside.Show();
            Close();
        }
    }
}
