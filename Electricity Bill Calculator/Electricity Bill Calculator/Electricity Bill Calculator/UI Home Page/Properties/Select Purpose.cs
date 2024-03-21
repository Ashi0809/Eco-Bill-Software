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
    public partial class Select_Purpose : Form
    {
        public Select_Purpose()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            General_User objGenaralUser = new General_User();
            objGenaralUser.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Industrial_User objIndustrialUser = new Industrial_User();
            objIndustrialUser.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Religious_User objReligiousUSer = new Religious_User();
            objReligiousUSer.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            samplepg objform = new samplepg();
            objform.Show();
            this.Hide();
        }
    }
}
