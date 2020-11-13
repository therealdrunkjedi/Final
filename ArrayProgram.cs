using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module8ArrayProject
{
    public partial class frmOfBucketofWater : Form
    {
        public frmOfBucketofWater()
        {
            InitializeComponent();
        }
        
        int[] numbers = new int[10];
        int x = 0;

        private int arrayMeth(int numberCovert)
        {
            if (x < 10)
            {

                numbers[x] = numberCovert;
                //numbers.Append(numberCovert);

                x++;
                return x;
            }
            return numberCovert;
        }
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string userNumber = txtbxNumbers.Text;            
            int numberCovert = int.Parse(userNumber);
            int numOut;
            //numbers.Append(numberCovert);            
            numOut = arrayMeth(numberCovert);
            txtbxNumbers.Text = "";
            this.txtbxNumbers.Focus();

            try(FormatException) //This causes this error The modifier 'private' is not valid for this item
         
        }

        private void btnStat_Click(object sender, EventArgs e)
        {
            var test = numbers.GetLowerBound(0);
            var tst = numbers.GetUpperBound(0);
            lblContents.Text = string.Join("\n", numbers);
            lblStitics.Text = numbers[test].ToString() + "\n" + numbers[tst].ToString();

        }
    }
}
