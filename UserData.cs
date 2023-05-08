using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ATM
{
    public class UserData
    {
        public int[] passwords = GetPasswords();
        public string[] names = GetNames();
        public string[] surnames = GetSurnames();
        
        private static int[] GetPasswords()
        {
            
            StreamReader read = new StreamReader(frmBank.fileName);

            //get total number of records from file
            int numRecords = 0;
            while(read.EndOfStream == false)
            {
                read.ReadLine();
                numRecords++;
            }
            read.Close();

            //set size of array to number of records stored on file
            int[] password = new int[numRecords];
            string[] field;

            StreamReader reading = new StreamReader(frmBank.fileName);
            int i = 0;
            while(reading.EndOfStream == false)
            {
                field = reading.ReadLine().Split('\t');
                password[i] = int.Parse(field[4]);
                i++;
            }
            reading.Close();

            return password;
        }
        private static string[] GetNames()
        {
            StreamReader read = new StreamReader(frmBank.fileName);

            //get total number of records from file
            int numRecords = 0;
            while (read.EndOfStream == false)
            {
                read.ReadLine();
                numRecords++;
            }
            read.Close();

            //set size of array to number of records stored on file
            string[] name = new string[numRecords];
            string[] field;

            StreamReader reading = new StreamReader(frmBank.fileName);
            int i = 0;
            while (reading.EndOfStream == false)
            {
                field = reading.ReadLine().Split('\t');
                name[i] = field[0];
                i++;
            }
            reading.Close();

            return name;
        }
        private static string[] GetSurnames()
        {
            StreamReader read = new StreamReader(frmBank.fileName);

            //get total number of records from file
            int numRecords = 0;
            while (read.EndOfStream == false)
            {
                read.ReadLine();
                numRecords++;
            }
            read.Close();

            //set size of array to number of records stored on file
            string[] surname = new string[numRecords];
            string[] field;

            StreamReader reading = new StreamReader(frmBank.fileName);
            int i = 0;
            while (reading.EndOfStream == false)
            {
                field = reading.ReadLine().Split('\t');
                surname[i] = field[1];
                i++;
            }
            reading.Close();

            return surname;
        }
    }
}
