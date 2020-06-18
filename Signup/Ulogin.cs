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

namespace Signup
{
    public partial class Ulogin : Form
    {
        public Ulogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
        string constr=@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Ruchika\Documents\Carrental.mdf;Integrated Security=True;Connect Timeout=30";

        private void button1_Click(object sender, EventArgs e)
        {

            string uname = textbox_username.Text;
            string pwd = textbox_password.Text;
            SqlConnection con=new SqlConnection(constr);
            string query="select * from UserData";
            SqlCommand cmd=new SqlCommand(query,con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            con.Close();
            int f = 0;
            foreach(DataRow d in dt.Rows)
            {
                string uname_db=d["uname"].ToString();
                string pwd_db=d[1].ToString();

                if(uname_db==uname && pwd==pwd_db)
                {
                    f = 1;
                    break;
                }
                
            }

            if (f == 0)
                MessageBox.Show("Login failed");
            else
            {
                MessageBox.Show("Login Successfull");
                Car_select c = new Car_select();
                c.Show();
                Hide();
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Usingn f = new Usingn();
            f.Show();
            Hide();
        }

        private void textbox_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Ulogin_Load(object sender, EventArgs e)
        {

        }

        private void textbox_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

  
    }
}
