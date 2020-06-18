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
    public partial class admin_removecar : Form
    {
        public admin_removecar()
        {
            InitializeComponent();
        }

        string constr = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Ruchika\Documents\Carrental.mdf;Integrated Security=True;Connect Timeout=30";

        private void button_delete_Click(object sender, EventArgs e)
        {
            String name = textBox_number.Text;
            SqlConnection con = new SqlConnection(constr);
            string query ="DELETE from  Car where nplate = '"+name+"'";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Sucessfully Removed ");

        }

        private void admin_removecar_Load(object sender, EventArgs e)
        {

        }
        

        private void button1_Click(object sender, EventArgs e)
        {

            Arights a = new Arights();
            a.Show();
            Hide();
        }

    }
}
