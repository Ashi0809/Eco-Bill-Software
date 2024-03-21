using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UI_Home_Page.Properties
{
    public partial class Registration : Form
    {
        private object con;

        public Registration()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
                    }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private object GetCon()
        {
            return con;
        }

        private void reg_signupbtn_Click(object sender, EventArgs e)
        {
            string connection = @"Data Source=ASUS-VIVOBOOK\SQLEXPRESS;Initial Catalog=new_user_db;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();

                string query = "Insert Into [db-reguser] ( Purpose,[Acc Number],[Full Name],[User Name],NIC,Password,Telephone,[Last Bill Amount]) values (@purpose, @acc, @full_name, @username, @nic, @password, @tele, @amt);";
                
                SqlCommand sqlCommand = new SqlCommand(query, conn);
                sqlCommand.Prepare();

                sqlCommand.Parameters.Add("@purpose", SqlDbType.VarChar).Value = reg_purpose.SelectedItem.ToString();
                sqlCommand.Parameters.Add("@acc", SqlDbType.VarChar).Value = reg_acc.Text;
                sqlCommand.Parameters.Add("@full_name", SqlDbType.VarChar).Value = reg_fulname.Text;
                sqlCommand.Parameters.Add("@username", SqlDbType.VarChar).Value = reg_username.Text;
                sqlCommand.Parameters.Add("@nic", SqlDbType.VarChar).Value = reg_nic.Text;
                sqlCommand.Parameters.Add("@password", SqlDbType.VarChar).Value = reg_passw.Text;
                sqlCommand.Parameters.Add("@tele", SqlDbType.Int).Value = Int32.Parse(reg_tele.Text);
                sqlCommand.Parameters.Add("@amt", SqlDbType.Decimal).Value = Double.Parse(reg_amt.Text);

                
                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Registration Successfully");
            }

        }

            private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            samplepg objform = new samplepg();
            objform.Show();
            this.Hide();
        }
    }
}
