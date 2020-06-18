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
    public partial class admin_addcar : Form
    {
        public admin_addcar()
        {
            InitializeComponent();
        }

        private void admin_addcar_Load(object sender, EventArgs e)
        {

        }

        string constr = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Ruchika\Documents\Carrental.mdf;Integrated Security=True;Connect Timeout=30";


        private void button_addcar_Click(object sender, EventArgs e)
        {
            string name = textBox_cname.Text;
                string color = textBox_ccolor.Text;
                    string seat = comboBox_seats.Text;
                        string number = textBox_Number.Text;
                        string mil = textBox_mileage.Text;
                        string cost = textBox_cost.Text;
                        SqlConnection con = new SqlConnection(constr);
                        string query = "insert into Car values('" + name + "','" + number + "'.0,'" + color + "','" + seat + "','" + mil + "','"+cost + "');";
                        SqlCommand cmd = new SqlCommand(query, con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Sucessfully Added the car");
                        textBox_cname.Text = "";
                        textBox_ccolor.Text = "";
                        textBox_mileage.Text = "";
                        textBox_Number.Text = "";
                        comboBox_seats.Text = "";
                        textBox_cost.Text = "";
                        
            



        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Arights a = new Arights();
            a.Show();
            Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
