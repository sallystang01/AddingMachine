using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddingMachine
{
    public partial class AddingMachine : Form
    {
        double[] numbers = new double[10];
        int i = 0;
        double sum = 0;

        public AddingMachine()
        {
            InitializeComponent();
        }

        private void tbInput_KeyDown(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.Enter)
            {
                lbNumbers.Items.Add(tbInput.Text);
                tbInput.Text = "";
                this.Size = new Size(388, 413);
                numbers[i] = double.Parse(tbInput.Text);
                // insert code here dingdong


                sum = sum + numbers[i];
                //lblCalc.Text = sum.ToString();
                i++;
            }
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {



            lblCalc.Text = numbers.Sum().ToString();
        }

    }
}
