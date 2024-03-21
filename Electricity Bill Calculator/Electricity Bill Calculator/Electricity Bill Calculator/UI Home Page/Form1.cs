using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_Home_Page.Properties;
using System.Data.SqlClient;

namespace UI_Home_Page
{
    public partial class samplepg : Form
    {
        public samplepg()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=ASUS-VIVOBOOK\SQLEXPRESS;Initial Catalog=sample_log_user;Integrated Security=True");
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username, password;
            
            username = samplepg_username.Text;
            password = samplepg_passw.Text; 
            try
            {
                String querry = "SELECT * FROM sample_log_DB WHERE username = '" + samplepg_username.Text + "'AND password = '" + samplepg_passw.Text + "'";

            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }

            Select_Purpose objselectpurpose = new Select_Purpose();
            objselectpurpose.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           Registration objregistration = new Registration();
            objregistration.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Office_Login objOfficeLogging = new Office_Login();
            objOfficeLogging.Show();
            this.Hide();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
              
        }

        private void samplepg_username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
