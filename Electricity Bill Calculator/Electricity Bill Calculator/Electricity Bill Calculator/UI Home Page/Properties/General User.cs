using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Home_Page.Properties
{
    public partial class General_User : Form
    {

        double charge_before_180 = 40.00;
        double charge_after_180 = 47.85;
        double fixed_charge = 1600.00;
        double before_180;
        double after_180;
        double total_charge;
        public General_User()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string temp = textBox1.Text;
            int value;
            if (int.TryParse(temp, out value))
            {
                int units_consumed = int.Parse(textBox1.Text);
                if (units_consumed < 301 && units_consumed >= 0)
                {
                    before_180 = units_consumed * charge_before_180;
                    label11.Text = before_180.ToString();
                    label12.Text = "0";
                    label13.Text = fixed_charge.ToString();
                    total_charge = before_180 + fixed_charge;
                    label14.Text = total_charge.ToString();
                }
                else if (units_consumed > 180)
                {
                    before_180 = 300 * charge_before_180;
                    after_180 = (units_consumed - 300) * charge_before_180;

                    label11.Text = before_180.ToString();
                    label12.Text = after_180.ToString();
                    label13.Text = fixed_charge.ToString();
                    total_charge = before_180 + after_180 + fixed_charge;
                    label14.Text = total_charge.ToString();
                }
                else
                {
                    MessageBox.Show("Please Enter a Positive Number!", "Negetive Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please Enter a Valid Number!", "Invalid Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void General_User_Load(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Select_Purpose objselectpurpose = new Select_Purpose();
            objselectpurpose.Show();
            this.Hide();
        }
    }
}
