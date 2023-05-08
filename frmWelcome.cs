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
    public partial class frmWelcome : Form
    {
        public frmWelcome()
        {
            InitializeComponent();
        }
        //
        //custom fields/variables
        //
        public static int availBalance;
        static int workingRecordIndex;
        public static int totalRecords;
        public static int[] balances;
        public bool isEnough;
        
        //
        //custom methods
        //
        public void Withdraw(int amount)
        {
            GetAvailBalance();
            frmBalance balance = new frmBalance();

           isEnough = balance.avail >= amount ? true : false;

            if (isEnough)
            {
                balance.avail = balance.avail - amount;
                availBalance -= amount;
                balance.Show();
                Hide();

                MessageBox.Show($"{amount:c} withdrawn successfully");
                UpdateAvailBalance();
            }
            else
            {
                MessageBox.Show("Requested amount cannot be dispensed due to available balance");
            }
        }
        public static void GetAvailBalance()
        {

            //getting total number of records stored in file
            StreamReader numRecords = new StreamReader(frmBank.fileName);
            int totalRows = 0;
            while (numRecords.EndOfStream == false)
            {
                numRecords.ReadLine();
                totalRows++;
            }

            //declaring array which will store the available balances
            totalRecords = totalRows;
            balances = new int[totalRecords];
            string[] field;

            //reading and comparing  the PINS to the enteredPIN,
            //logic behind is trying to get the record number of the logged-on user
            StreamReader read = new StreamReader(frmBank.fileName);
            int i = 0;
            while (read.EndOfStream == false)
            {
                field = read.ReadLine().Split('\t');
                if (int.Parse(field[4]) == frmPIN.enteredPin)
                    break;
                i++;
            }
            read.Close();
            workingRecordIndex = i;

            StreamReader reading = new StreamReader(frmBank.accBalanceFileName);
            int j = 0;
            while (reading.EndOfStream == false)
            {
                balances[j] = int.Parse(reading.ReadLine());
                j++;
            }
            reading.Close();

            //display balance at index 'i'/'workingRecordIndex' to the user on a new form

            availBalance = balances[workingRecordIndex];
        }
        public void UpdateAvailBalance()
        {
            int[] updateBalances = new int[balances.Length];

            Array.Copy(balances, updateBalances, balances.Length);

            //change the balance of the user we working on
            updateBalances[workingRecordIndex] = availBalance;

            //writing the new balances to the file
            //overwriting the previous values
            StreamWriter write = new StreamWriter(frmBank.accBalanceFileName);
            for (int i = 0; i < updateBalances.Length; i++)
                write.WriteLine(updateBalances[i]);
            write.Close();
        }
        //
        //event handling methods
        //
        private void btnOwnAmt_Click(object sender, EventArgs e)
        {
            var frmEnterAmt = new frmEnterAmt();
            frmEnterAmt.Show();
            this.Hide();
        }
        private void btnBalance_Click(object sender, EventArgs e)
        {
            GetAvailBalance();

            frmBalance frmBalance = new frmBalance();
            frmBalance.Show();
            this.Hide();
        }
        private void btnHundred_Click(object sender, EventArgs e)
        {
            Withdraw(100);
        }
        private void btnTwoHundred_Click(object sender, EventArgs e)
        {
            Withdraw(200);
        }

        private void btnFiveHundred_Click(object sender, EventArgs e)
        {
            Withdraw(500);
        }

        private void btnTwoFifty_Click(object sender, EventArgs e)
        {
            Withdraw(250);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Show();
            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {

        }
    }
}
