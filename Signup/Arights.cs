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
    public partial class Arights : Form
    {
        public Arights()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin_addcar f = new admin_addcar();
            f.Show();
            Hide();
        }

        private void Arights_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            admin_removecar a = new admin_removecar();
            a.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ALogin a = new ALogin();
            a.Show();
            Hide();
        }
    }
}
