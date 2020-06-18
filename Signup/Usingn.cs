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
    public partial class Usingn : Form
    {
        public Usingn()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        string constr = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Ruchika\Documents\Carrental.mdf;Integrated Security=True;Connect Timeout=30";


        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox_name.Text;
                string pwd = textBox_pwd.Text;
                    string bdate = textBox_bd.Text;
                        string phone = textBox_pn.Text;
                        string email = textBox_em.Text;
                        SqlConnection con = new SqlConnection(constr);
                        string query = "insert into UserData values('" + name + "','" + pwd + "','" + bdate + "','" + phone + "','" + email + "');";
                        SqlCommand cmd = new SqlCommand(query, con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Sucessfully Added the User");
                        textBox_name.Text = "";
                        textBox_pwd.Text = "";
                        textBox_bd.Text = "";
                        textBox_pn.Text = "";
                        textBox_em.Text = "";
                        Ulogin u = new Ulogin();
                        u.Show();
                        Hide();
                        

            

            
            
            
            

        }
    }
      

    }

