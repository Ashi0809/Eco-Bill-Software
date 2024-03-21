namespace UI_Home_Page.Properties
{
    partial class Registration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.label1 = new System.Windows.Forms.Label();
            this.reg_acc = new System.Windows.Forms.TextBox();
            this.reg_username = new System.Windows.Forms.TextBox();
            this.reg_nic = new System.Windows.Forms.TextBox();
            this.reg_fulname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.reg_passw = new System.Windows.Forms.TextBox();
            this.reg_signupbtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.reg_confpassw = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.reg_purpose = new System.Windows.Forms.ComboBox();
            this.reg_tele = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.reg_amt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // reg_acc
            // 
            resources.ApplyResources(this.reg_acc, "reg_acc");
            this.reg_acc.Name = "reg_acc";
            // 
            // reg_username
            // 
            resources.ApplyResources(this.reg_username, "reg_username");
            this.reg_username.Name = "reg_username";
            // 
            // reg_nic
            // 
            resources.ApplyResources(this.reg_nic, "reg_nic");
            this.reg_nic.Name = "reg_nic";
            this.reg_nic.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // reg_fulname
            // 
            resources.ApplyResources(this.reg_fulname, "reg_fulname");
            this.reg_fulname.Name = "reg_fulname";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Name = "label3";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Name = "label6";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // reg_passw
            // 
            resources.ApplyResources(this.reg_passw, "reg_passw");
            this.reg_passw.Name = "reg_passw";
            this.reg_passw.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // reg_signupbtn
            // 
            this.reg_signupbtn.BackColor = System.Drawing.Color.LightGray;
            resources.ApplyResources(this.reg_signupbtn, "reg_signupbtn");
            this.reg_signupbtn.ForeColor = System.Drawing.Color.Black;
            this.reg_signupbtn.Name = "reg_signupbtn";
            this.reg_signupbtn.UseVisualStyleBackColor = false;
            this.reg_signupbtn.Click += new System.EventHandler(this.reg_signupbtn_Click);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Name = "label7";
            // 
            // reg_confpassw
            // 
            resources.ApplyResources(this.reg_confpassw, "reg_confpassw");
            this.reg_confpassw.Name = "reg_confpassw";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Name = "label8";
            // 
            // reg_purpose
            // 
            resources.ApplyResources(this.reg_purpose, "reg_purpose");
            this.reg_purpose.BackColor = System.Drawing.Color.LightGray;
            this.reg_purpose.FormattingEnabled = true;
            this.reg_purpose.Items.AddRange(new object[] {
            resources.GetString("reg_purpose.Items"),
            resources.GetString("reg_purpose.Items1"),
            resources.GetString("reg_purpose.Items2")});
            this.reg_purpose.Name = "reg_purpose";
            // 
            // reg_tele
            // 
            resources.ApplyResources(this.reg_tele, "reg_tele");
            this.reg_tele.Name = "reg_tele";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Name = "label4";
            // 
            // reg_amt
            // 
            resources.ApplyResources(this.reg_amt, "reg_amt");
            this.reg_amt.Name = "reg_amt";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Name = "label9";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.CornflowerBlue;
            resources.ApplyResources(this.button4, "button4");
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Registration
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button4);
            this.Controls.Add(this.reg_amt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.reg_tele);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.reg_purpose);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.reg_confpassw);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.reg_signupbtn);
            this.Controls.Add(this.reg_passw);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reg_fulname);
            this.Controls.Add(this.reg_nic);
            this.Controls.Add(this.reg_username);
            this.Controls.Add(this.reg_acc);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox reg_acc;
        private System.Windows.Forms.TextBox reg_username;
        private System.Windows.Forms.TextBox reg_nic;
        private System.Windows.Forms.TextBox reg_fulname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox reg_passw;
        private System.Windows.Forms.Button reg_signupbtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox reg_confpassw;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox reg_purpose;
        private System.Windows.Forms.TextBox reg_tele;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox reg_amt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button4;
    }
}