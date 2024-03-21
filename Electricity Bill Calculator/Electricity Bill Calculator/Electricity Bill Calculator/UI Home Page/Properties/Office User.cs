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
    public partial class Office_User : Form
    {
        private SqlConnection conn;

        public Office_User()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string connection = @"Data Source=ASUS-VIVOBOOK\SQLEXPRESS;Initial Catalog=new_user_db;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();

                SqlCommand sqlCommand = new SqlCommand("select * from [db-reguser] where [Acc Number]=@acc", conn);
                
                sqlCommand.Parameters.Add("@acc", SqlDbType.VarChar, 100);
                sqlCommand.Prepare();
                sqlCommand.Parameters[0].Value = office_accserch.Text;

                DataSet dataTable = new DataSet();
                using (SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand))
                {
                    adapter.Fill(dataTable);
                    dataGridView1.ReadOnly = true;
                    dataGridView1.DataSource = dataTable.Tables[0];
                }
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
