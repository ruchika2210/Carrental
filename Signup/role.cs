using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Signup
{
    public partial class role : Form
    {
        public role()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
           
        }
       
        

       

     


private void button1_Click_1(object sender, EventArgs e)
{
     if (radiobutton_user.Checked==true)
            {
                Ulogin u = new Ulogin();
                u.Show();
                

            }
            else if (radioButton2.Checked==true)
            {
                ALogin a = new ALogin();
                a.Show();
               
            }
            else
                MessageBox.Show("Error");

     Hide();
        }
}
    }

