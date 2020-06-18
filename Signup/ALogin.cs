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
    public partial class ALogin : Form
    {
        public ALogin()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
        string constr = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Ruchika\Documents\Carrental.mdf;Integrated Security=True;Connect Timeout=30";


        private void button1_Click(object sender, EventArgs e)
        {
            string Aname = textBox_Aname.Text;
            string id = textBox_id.Text;
            string pwd = textBox_Apwd.Text;

            SqlConnection con = new SqlConnection(constr);
            string query = "select * from Admin11";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            con.Close();
            int f = 0;
            foreach (DataRow d in dt.Rows)
            {
                string aname_db = d["Name"].ToString();
                string pwd_db = d["Password"].ToString();
                string id_db = d["Id"].ToString();

                if (aname_db == Aname && pwd == pwd_db &&  id==id_db)
                {
                    f = 1;
                    break;
                }

            }

            if (f == 0)
            {
                MessageBox.Show("Login failed");
                textBox_Aname.Text = "";
                textBox_Apwd.Text = "";
                textBox_id.Text = "";
            }
            else
            {
                MessageBox.Show("success");
                Arights a = new Arights();
                a.Show();
                Hide();

            }
            



        }

        private void button2_Click(object sender, EventArgs e)
        {
            role r = new role();
            r.Show();
            Hide();
            
        }
    }
}
