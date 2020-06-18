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
    public partial class Car_select : Form
    {
        string constr = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Ruchika\Documents\Carrental.mdf;Integrated Security=True;Connect Timeout=30";
        string aacar;
        public Car_select()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection(constr);
            string query = "select * from Car";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            con.Close();

            foreach (DataRow d in dt.Rows)
            {
                string cname = d["cname"].ToString();
                comboBox_car.Items.Add(cname);
            }
        }

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
                
            

        }

        private void button_select_Click(object sender, EventArgs e)
        {
            dataGrid_car.Rows.Clear();
            aacar = comboBox_car.Text;
            SqlConnection con = new SqlConnection(constr);
            string query = "select * from Car";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            con.Close();

            foreach (DataRow d in dt.Rows)
            {
                
                string cname = d["cname"].ToString();
                if (cname == aacar)
                {
                    dataGrid_car.ColumnCount = 2;
                    string[] row = new string[] { "Car name", aacar };
                    dataGrid_car.Rows.Add(row);
                    string[] rowss = new string[] { "Car Number", d["nplate"].ToString() };
                    dataGrid_car.Rows.Add(rowss);
                    string[] rowsss = new string[] { "Car Color", d["ccolor"].ToString() };
                    dataGrid_car.Rows.Add(rowsss);
                    string[] rowssw = new string[] { "Car Seats", d["cseater"].ToString() };
                    dataGrid_car.Rows.Add(rowssw);
                    string[] rowssq = new string[] { "Car Mileage", d["cmileage"].ToString() };
                    dataGrid_car.Rows.Add(rowssq);
                    string[] rowssqs = new string[] { "Per Day Cost", d["ccost"].ToString() };
                    dataGrid_car.Rows.Add(rowssqs);

                    break;
                }
            }
        }

        private void dataGrid_car_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Car_select_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            payment p = new payment();
            p.Show();
            Hide();
        }
    }
}
