using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Home_Page.Properties
{
    public partial class Religious_User : Form
    {
        double charge_0_30_if_above_60KWh = 30.00;
        double charge_31_90_if_above_60KWh = 37.00;
        double charge_91_120_if_above_60KWh = 42.00;
        double charge_121_180_if_above_60KWh = 45.00;
        double charge_180_infinity_if_above_60KWh = 50.00;

        double fixed_charge_0_30_if_above_60KWh = 400.00;
        double fixed_charge_31_90_if_above_60KWh = 550.00;
        double fixed_charge_91_120_if_above_60KWh = 650.00;
        double fixed_charge_121_180_if_above_60KWh = 1500.00;
        double fixed_charge_180_infinity_if_above_60KWh = 2000.00;

        double charge_0_30;
        double charge_31_90;
        double charge_91_120;
        double charge_121_180;
        double charge_above_180;
        double total_charge;
        public Religious_User()
        {
            InitializeComponent();
        }
        private void myMethod1(double fixedcharge)
        {
            label11.Text = charge_0_30.ToString();
            label17.Text = charge_31_90.ToString();
            label20.Text = charge_91_120.ToString();
            label22.Text = charge_121_180.ToString();
            label12.Text = charge_above_180.ToString();
            label24.Text = fixedcharge.ToString();
            label14.Text = total_charge.ToString();

        }


        private void Religious_User_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string temp = textBox1.Text;
            int value;
            if (int.TryParse(temp, out value))
            {
                int units_consumed = int.Parse(textBox1.Text);
                if (units_consumed >= 0)
                {
                    if (units_consumed <= 30)
                    {
                        charge_0_30 = units_consumed * charge_0_30_if_above_60KWh;
                        total_charge = charge_0_30 + fixed_charge_0_30_if_above_60KWh;
                        myMethod1(fixed_charge_0_30_if_above_60KWh);


                        textBox1.Text = "";
                    }
                    else if (units_consumed <= 90)
                    {
                        charge_0_30 = 30 * charge_0_30_if_above_60KWh;
                        charge_31_90 = (units_consumed - 30) * charge_31_90_if_above_60KWh;
                        total_charge = charge_0_30 + charge_31_90 + fixed_charge_0_30_if_above_60KWh;
                        myMethod1(fixed_charge_31_90_if_above_60KWh);


                        textBox1.Text = "";
                    }
                    else if (units_consumed <= 120)
                    {
                        charge_0_30 = 30 * charge_0_30_if_above_60KWh;
                        charge_31_90 = 60 * charge_31_90_if_above_60KWh;
                        charge_91_120 = (units_consumed - 90) * charge_91_120_if_above_60KWh;
                        total_charge = charge_0_30 + charge_31_90 + charge_91_120 + fixed_charge_91_120_if_above_60KWh;
                        myMethod1(fixed_charge_91_120_if_above_60KWh);


                        textBox1.Text = "";
                    }
                    else if (units_consumed <= 180)
                    {
                        charge_0_30 = 30 * charge_0_30_if_above_60KWh;
                        charge_31_90 = 30 * charge_31_90_if_above_60KWh;
                        charge_91_120 = 30 * charge_91_120_if_above_60KWh;
                        charge_121_180 = (units_consumed - 120) * charge_121_180_if_above_60KWh;
                        total_charge = charge_0_30 + charge_31_90 + charge_91_120 + charge_121_180 + fixed_charge_121_180_if_above_60KWh;
                        myMethod1(fixed_charge_121_180_if_above_60KWh);


                        textBox1.Text = "";

                    }
                    else if (units_consumed > 180)
                    {
                        charge_0_30 = 30 * charge_0_30_if_above_60KWh;
                        charge_31_90 = 30 * charge_31_90_if_above_60KWh;
                        charge_91_120 = 30 * charge_91_120_if_above_60KWh;
                        charge_121_180 = 60 * charge_121_180_if_above_60KWh;
                        charge_above_180 = (units_consumed - 180) * charge_180_infinity_if_above_60KWh;
                        total_charge = charge_0_30 + charge_31_90 + charge_91_120 + charge_121_180 + charge_above_180 + fixed_charge_180_infinity_if_above_60KWh;
                        myMethod1(fixed_charge_180_infinity_if_above_60KWh);


                        textBox1.Text = "";

                    }
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

        private void button2_Click(object sender, EventArgs e)
        {
            Select_Purpose objselectpurpose = new Select_Purpose();
            objselectpurpose.Show();
            this.Hide();
        }
    }
}
            
