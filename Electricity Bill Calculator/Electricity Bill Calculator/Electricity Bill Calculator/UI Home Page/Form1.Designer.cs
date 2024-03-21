namespace UI_Home_Page
{
    partial class samplepg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(samplepg));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.samplepg_username = new System.Windows.Forms.TextBox();
            this.samplepg_passw = new System.Windows.Forms.TextBox();
            this.samplepg_loginbtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.samplepg_signupbtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.samplepg_officebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(729, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(643, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(645, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // samplepg_username
            // 
            this.samplepg_username.BackColor = System.Drawing.Color.White;
            this.samplepg_username.ForeColor = System.Drawing.Color.Black;
            this.samplepg_username.Location = new System.Drawing.Point(647, 209);
            this.samplepg_username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.samplepg_username.Name = "samplepg_username";
            this.samplepg_username.Size = new System.Drawing.Size(245, 22);
            this.samplepg_username.TabIndex = 3;
            this.samplepg_username.TextChanged += new System.EventHandler(this.samplepg_username_TextChanged);
            // 
            // samplepg_passw
            // 
            this.samplepg_passw.BackColor = System.Drawing.Color.White;
            this.samplepg_passw.ForeColor = System.Drawing.Color.Black;
            this.samplepg_passw.Location = new System.Drawing.Point(649, 281);
            this.samplepg_passw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.samplepg_passw.Name = "samplepg_passw";
            this.samplepg_passw.PasswordChar = '*';
            this.samplepg_passw.Size = new System.Drawing.Size(243, 22);
            this.samplepg_passw.TabIndex = 4;
            this.samplepg_passw.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // samplepg_loginbtn
            // 
            this.samplepg_loginbtn.BackColor = System.Drawing.Color.LightGray;
            this.samplepg_loginbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.samplepg_loginbtn.ForeColor = System.Drawing.Color.Black;
            this.samplepg_loginbtn.Location = new System.Drawing.Point(708, 334);
            this.samplepg_loginbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.samplepg_loginbtn.Name = "samplepg_loginbtn";
            this.samplepg_loginbtn.Size = new System.Drawing.Size(136, 32);
            this.samplepg_loginbtn.TabIndex = 7;
            this.samplepg_loginbtn.Text = "Login";
            this.samplepg_loginbtn.UseVisualStyleBackColor = false;
            this.samplepg_loginbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(765, 386);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Or";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(701, 420);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Don\'t Have An Account?";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // samplepg_signupbtn
            // 
            this.samplepg_signupbtn.BackColor = System.Drawing.Color.Gainsboro;
            this.samplepg_signupbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.samplepg_signupbtn.Location = new System.Drawing.Point(711, 447);
            this.samplepg_signupbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.samplepg_signupbtn.Name = "samplepg_signupbtn";
            this.samplepg_signupbtn.Size = new System.Drawing.Size(136, 32);
            this.samplepg_signupbtn.TabIndex = 10;
            this.samplepg_signupbtn.Text = "Signup";
            this.samplepg_signupbtn.UseVisualStyleBackColor = false;
            this.samplepg_signupbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(761, 482);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Here";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-7, -46);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(628, 581);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(731, 12);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(97, 96);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // samplepg_officebtn
            // 
            this.samplepg_officebtn.BackColor = System.Drawing.Color.LightGray;
            this.samplepg_officebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.samplepg_officebtn.ForeColor = System.Drawing.Color.Black;
            this.samplepg_officebtn.Location = new System.Drawing.Point(15, 480);
            this.samplepg_officebtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.samplepg_officebtn.Name = "samplepg_officebtn";
            this.samplepg_officebtn.Size = new System.Drawing.Size(183, 36);
            this.samplepg_officebtn.TabIndex = 15;
            this.samplepg_officebtn.Text = "Office Use Only";
            this.samplepg_officebtn.UseVisualStyleBackColor = false;
            this.samplepg_officebtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // samplepg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(920, 528);
            this.Controls.Add(this.samplepg_officebtn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.samplepg_signupbtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.samplepg_loginbtn);
            this.Controls.Add(this.samplepg_passw);
            this.Controls.Add(this.samplepg_username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "samplepg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox samplepg_username;
        private System.Windows.Forms.TextBox samplepg_passw;
        private System.Windows.Forms.Button samplepg_loginbtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button samplepg_signupbtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button samplepg_officebtn;
    }
}

