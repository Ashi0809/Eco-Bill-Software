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
    public partial class Industrial_User : Form
    {
        double charge_before_300 = 26.00;
        double charge_after_300 = 26.00;
        double fixed_charge = 1200;
        double before_300;
        double after_300;
        double total_charge;

        public Industrial_User()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string temp = textBox1.Text;
            int value;
            if(int.TryParse(temp,out value))
            {
                int units_consumed = int.Parse(textBox1.Text);
                if (units_consumed < 301 && units_consumed >= 0)
                {
                    before_300 = units_consumed * charge_before_300;
                    label11.Text = before_300.ToString();
                    label12.Text = "0";
                    label13.Text = fixed_charge.ToString();
                    total_charge = before_300 + fixed_charge;
                    label14.Text = total_charge.ToString();
                }
                else if (units_consumed > 301)
                {
                    before_300 = 300 * charge_before_300;
                    after_300 = (units_consumed - 300) * charge_before_300;

                    label11.Text = before_300.ToString();
                    label12.Text = after_300.ToString();
                    label13.Text = fixed_charge.ToString();
                    total_charge = before_300 + after_300 + fixed_charge;
                    label14.Text = total_charge.ToString();
                }
                else
                {
                    MessageBox.Show("Please Enter a Positive Number!", "Negetive Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please Enter a Valid Number!","Invalid Number",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }





            
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Select_Purpose objselectpurpose = new Select_Purpose();
            objselectpurpose.Show();
            this.Hide();
        }
    }
}
