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

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        string constr, r, sql;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //conn.Close();
            constr = "Data Source=DESKTOP-6H5PSI2\\SQLEXPRESS05;" +
               "Initial Catalog=Test;Integrated Security=True;";
            if (conn.State == ConnectionState.Closed)
            {
                conn.ConnectionString = constr;
                conn.Open();
            }
            sql = "select *from login where TenDN=N'" + txtAcc.Text + "' and MatKhau='"
                + txtPass.Text + "' and Quyen='" + r + "'";
            da = new SqlDataAdapter(sql, conn); // câu lệnh giúp dataAdapter truy vấn dữ liệu
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                if (r == "admin")
                {
                    Form1 f = new Form1();
                    f.Show();
                }
                if (r == "user")
                {
                    Form2 f2 = new Form2();
                    f2.Show();
                }
            }
            else
            {
                MessageBox.Show("Đăng nhập sai, vui lòng thử lại", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAcc.Clear();
                txtPass.Clear();
            }
        }   
            

            private void radioButton2_CheckedChanged(object sender, EventArgs e)
            {
                
                RadioButton ckd = sender as RadioButton;
                if (ckd.Checked)
                    r = ckd.Text.ToString();
               
                
            }
        }
    }
