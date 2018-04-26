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
        // Declares variables that will be used through program
        double[] numbers = new double[10];
        int i = 0;
        double sum = 0;
      
        

        public AddingMachine()
        {
            InitializeComponent();
        }
        private void AddingMachine_Load(object sender, EventArgs e)
        {
            tbInput.Focus();
        }
        private void tbInput_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                // When enter key is struck, add number from text box into the array and add the number
                // to the list box.
                if (e.KeyCode == Keys.Enter)
                { // If number in text box is greater than 0, proceed.
                    if (Convert.ToDouble(tbInput.Text) > 0)
                    {
                        // Adds the number to the listbox
                        lbNumbers.Items.Add(tbInput.Text);

                        // Resizes form
                        this.Size = new Size(388, 470);

                        // Adds the number to the array
                        numbers[i] = double.Parse(tbInput.Text);

                        // Clears the text box and prepares it for a new number
                        tbInput.Text = "";
                       

                        // Sum variable = sum + new number in array
                        sum = sum + numbers[i];
                       
                        // Increment i to the next place in the array
                        i++;
                        // Changes location of exit button
                        btnExit.Location = new Point(188, 382);

                        label1.Text = "Continue adding numbers...";
                    }

                    else
                    {
                        // Error handeling
                        MessageBox.Show("Please enter a value greater than 0!");
                    }
                }

                // Clears array before it becomes full.
                if (i > (numbers.Length - 1))
                {
                    sum = numbers.Sum();
                    Array.Clear(numbers, 0, numbers.Length);
                    i = 0;
                }
            }

            catch (Exception)
            {
                // Error handeling
                MessageBox.Show("Please enter numeric values only!");
            }

        }






        private void btnTotal_Click(object sender, EventArgs e)
        {

            // Displays the sum to the label

            lblCalc.Text = sum.ToString();
            // Puts the focus back to the text box
            tbInput.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Confirm that user really intends on exiting the application.
            DialogResult dr = MessageBox.Show("Are you sure you want to exit?", "Exiting...", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clears everything and prepares the form for a new set of data
            Array.Clear(numbers, 0, numbers.Length);
            lbNumbers.Items.Clear();
            tbInput.Focus();
            lblCalc.Text = "";
            i = 0;
            sum = 0;
            this.Size = new Size(388, 153);
            btnExit.Location = new Point(128, 74);
            label1.Text = "Type a number then hit Enter to get started:";
        }

        
    }

   
        
       
}
