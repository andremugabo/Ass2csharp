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

namespace ASS2S_TUDENT
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-IFGGQ0S\SQLEXPRESS01;Initial Catalog=studentRequestDB;Integrated Security=True");
        
        public void FetchDptData()
        {
            String query = "SELECT * FROM department";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            sda.Fill(ds, "department");
            cBox_department.DataSource = ds.Tables["department"];
            cBox_department.DisplayMember = "d_name";
            cBox_department.ValueMember = "d_id";
        }
        
        public void FetchPgrData()
        {
            String query = "SELECT * FROM programs";
            SqlDataAdapter sda = new SqlDataAdapter(query,con);
            DataSet ds = new DataSet();
            sda.Fill(ds, "programs");
            cBox_program.DataSource = ds.Tables["programs"];
            cBox_program.DisplayMember = "p_name";
            cBox_program.ValueMember = "p_id";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void lkl_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void txtBox_names_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            FetchDptData();
            FetchPgrData();
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            
            String names = txtBox_names.Text;
            String email = txtBox_email.Text;
            String password = txtBox_cpassword.Text;
            int d_id =Convert.ToInt32(cBox_department.SelectedValue);
            int p_id = Convert.ToInt32(cBox_program.SelectedValue);
            String cpassword = txtBox_cpassword.Text;

            //check if password match and not empty
            if((password != "" && cpassword != "") && (password.Equals(cpassword))){
                //check the remain textfield not empty
                if(names!= "" && email != "")
                {
                    String countQuery = "SELECT count(*) FROM students";
                    SqlCommand cmd = new SqlCommand(countQuery, con);
                    con.Open();
                    var countStudent = cmd.ExecuteScalar();
                    int Id =Convert.ToInt32(countStudent) + 1;
                    String insertQuery = "INSERT INTO students VALUES("+Id+",'"+names+"','"+email+"','"+password+"',"+d_id+","+p_id+")";
                    SqlDataAdapter sda = new SqlDataAdapter(insertQuery, con);
                    
                    sda.SelectCommand.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show(names + " Account Created successfully !! You can login now");
                    Login lg = new Login();
                    lg.Show();
                    this.Hide();


                }
                else
                {
                    MessageBox.Show("Some fieldtext are empty");
                }
            }
            else
            {
                MessageBox.Show("Check your Password");
            }
        }
    }
}
