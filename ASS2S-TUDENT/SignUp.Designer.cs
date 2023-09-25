namespace ASS2S_TUDENT
{
    partial class SignUp
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.gBox_signup = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_names = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBox_email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBox_password = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBox_cpassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cBox_department = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cBox_program = new System.Windows.Forms.ComboBox();
            this.btn_signup = new System.Windows.Forms.Button();
            this.lkl_login = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.gBox_signup.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(968, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(453, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign Up";
            // 
            // gBox_signup
            // 
            this.gBox_signup.Controls.Add(this.lkl_login);
            this.gBox_signup.Controls.Add(this.btn_signup);
            this.gBox_signup.Controls.Add(this.cBox_program);
            this.gBox_signup.Controls.Add(this.label7);
            this.gBox_signup.Controls.Add(this.cBox_department);
            this.gBox_signup.Controls.Add(this.label6);
            this.gBox_signup.Controls.Add(this.txtBox_email);
            this.gBox_signup.Controls.Add(this.label3);
            this.gBox_signup.Controls.Add(this.txtBox_cpassword);
            this.gBox_signup.Controls.Add(this.label5);
            this.gBox_signup.Controls.Add(this.txtBox_password);
            this.gBox_signup.Controls.Add(this.label4);
            this.gBox_signup.Controls.Add(this.txtBox_names);
            this.gBox_signup.Controls.Add(this.label2);
            this.gBox_signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBox_signup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gBox_signup.Location = new System.Drawing.Point(12, 137);
            this.gBox_signup.Name = "gBox_signup";
            this.gBox_signup.Size = new System.Drawing.Size(968, 500);
            this.gBox_signup.TabIndex = 1;
            this.gBox_signup.TabStop = false;
            this.gBox_signup.Text = "Sign Up";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Names";
            // 
            // txtBox_names
            // 
            this.txtBox_names.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_names.Location = new System.Drawing.Point(26, 96);
            this.txtBox_names.Name = "txtBox_names";
            this.txtBox_names.Size = new System.Drawing.Size(381, 35);
            this.txtBox_names.TabIndex = 1;
            this.txtBox_names.TextChanged += new System.EventHandler(this.txtBox_names_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Email";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtBox_email
            // 
            this.txtBox_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_email.Location = new System.Drawing.Point(26, 201);
            this.txtBox_email.Name = "txtBox_email";
            this.txtBox_email.Size = new System.Drawing.Size(381, 35);
            this.txtBox_email.TabIndex = 1;
            this.txtBox_email.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(543, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Password";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtBox_password
            // 
            this.txtBox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_password.Location = new System.Drawing.Point(547, 96);
            this.txtBox_password.Name = "txtBox_password";
            this.txtBox_password.Size = new System.Drawing.Size(381, 35);
            this.txtBox_password.TabIndex = 1;
            this.txtBox_password.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(543, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Confirm Password";
            this.label5.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtBox_cpassword
            // 
            this.txtBox_cpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_cpassword.Location = new System.Drawing.Point(547, 201);
            this.txtBox_cpassword.Name = "txtBox_cpassword";
            this.txtBox_cpassword.Size = new System.Drawing.Size(381, 35);
            this.txtBox_cpassword.TabIndex = 1;
            this.txtBox_cpassword.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Department";
            this.label6.Click += new System.EventHandler(this.label3_Click);
            // 
            // cBox_department
            // 
            this.cBox_department.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBox_department.FormattingEnabled = true;
            this.cBox_department.Location = new System.Drawing.Point(26, 302);
            this.cBox_department.Name = "cBox_department";
            this.cBox_department.Size = new System.Drawing.Size(381, 37);
            this.cBox_department.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(543, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Program";
            this.label7.Click += new System.EventHandler(this.label3_Click);
            // 
            // cBox_program
            // 
            this.cBox_program.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBox_program.FormattingEnabled = true;
            this.cBox_program.Location = new System.Drawing.Point(547, 302);
            this.cBox_program.Name = "cBox_program";
            this.cBox_program.Size = new System.Drawing.Size(381, 37);
            this.cBox_program.TabIndex = 2;
            // 
            // btn_signup
            // 
            this.btn_signup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_signup.ForeColor = System.Drawing.Color.White;
            this.btn_signup.Location = new System.Drawing.Point(369, 372);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.Size = new System.Drawing.Size(250, 50);
            this.btn_signup.TabIndex = 3;
            this.btn_signup.Text = "SignUp";
            this.btn_signup.UseVisualStyleBackColor = false;
            this.btn_signup.Click += new System.EventHandler(this.btn_signup_Click);
            // 
            // lkl_login
            // 
            this.lkl_login.AutoSize = true;
            this.lkl_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkl_login.Location = new System.Drawing.Point(379, 450);
            this.lkl_login.Name = "lkl_login";
            this.lkl_login.Size = new System.Drawing.Size(220, 20);
            this.lkl_login.TabIndex = 4;
            this.lkl_login.TabStop = true;
            this.lkl_login.Text = "Do you an Account? Login";
            this.lkl_login.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkl_login_LinkClicked);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 649);
            this.Controls.Add(this.gBox_signup);
            this.Controls.Add(this.panel1);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gBox_signup.ResumeLayout(false);
            this.gBox_signup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gBox_signup;
        private System.Windows.Forms.TextBox txtBox_email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBox_names;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBox_password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBox_cpassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_signup;
        private System.Windows.Forms.ComboBox cBox_program;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cBox_department;
        private System.Windows.Forms.LinkLabel lkl_login;
    }
}