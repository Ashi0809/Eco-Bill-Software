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
    public partial class Office_Login : Form
    {
        public Office_Login()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=ASUS-VIVOBOOK\SQLEXPRESS;Initial Catalog=office_users_database;Integrated Security=True");
        private void Office_Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void officelog_loginbtn_Click(object sender, EventArgs e)
        {
            String Office_username, Office_password;

            Office_username = officelog_username.Text;
            Office_password = officelog_passw.Text;

            try
            {
                String querry = "SELECT * FROM office_login WHERE Ofdb_username = '" + officelog_username.Text+"' AND Ofdb_password = '"+officelog_passw.Text+"'";
            }
            catch 
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();

                Office_User objoffice_user = new Office_User();
                objoffice_user.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            samplepg objform = new samplepg();
            objform.Show();
            this.Hide();
        }
    }
}
