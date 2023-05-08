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
    public partial class frmDeposit : Form
    {
        public frmDeposit()
        {
            InitializeComponent();
        }
        private static string enteredAccNr;
        private static int depositAmt;
        public static int availBalance;
        public static int totalRecords;
        public static int[] balances;
        public static string reference;
        private void btnAccept_Click(object sender, EventArgs e)
        {
            enteredAccNr = txtAccNr.Text;
            depositAmt = int.Parse(txtDepAmt.Text);
            reference = txtReference.Text;
            GetAvailBalance();
        }
        public static void GetAvailBalance()
        {
            UserData data = new UserData();
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
            int workingIndex = 0;
            while (read.EndOfStream == false)
            {
                field = read.ReadLine().Split('\t');
                if (enteredAccNr == field[3])
                    break;
                workingIndex++;
            }
            
            StreamReader reading = new StreamReader(frmBank.accBalanceFileName);
            int j = 0;
            while (reading.EndOfStream == false)
            {
                balances[j] = int.Parse(reading.ReadLine());
                j++;
            }
            reading.Close();

            //display balance at index 'i'/'workingRecordIndex' to the user on a new form

            availBalance = balances[workingIndex] + depositAmt;
            balances[workingIndex] = availBalance;

            StreamWriter write = new StreamWriter(frmBank.accBalanceFileName);
            for (int i = 0; i < balances.Length; i++)
                write.WriteLine(balances[i]);
            write.Close();

            MessageBox.Show($"{depositAmt:c} deposited successfully to account holder:\nName:\t\t{data.names[workingIndex]}\nSurname:\t{data.surnames[workingIndex]}\nReference:\t{reference}\nDeposit Amount:\t{depositAmt:c}");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Show();
            Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtAccNr.Clear();
            txtReference.Clear();
            txtDepAmt.Clear();
        }

        private void frmDeposit_Load(object sender, EventArgs e)
        {
            txtReference.Enabled = false;
            txtDepAmt.Enabled = false;
            btnAccept.Enabled = false;
        }

        private void txtAccNr_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("Enter only numbers!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txtDepAmt_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("Enter only numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txtReference_TextChanged(object sender, EventArgs e)
        {
            txtDepAmt.Enabled = true;
        }

        private void txtAccNr_TextChanged(object sender, EventArgs e)
        {
            txtReference.Enabled = true;
        }

        private void txtDepAmt_TextChanged(object sender, EventArgs e)
        {
            btnAccept.Enabled = true;
        }
    }
}
