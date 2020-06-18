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
    public partial class payment : Form
    {
        public payment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your payment of the selected car  for rent is successfully done ");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your qyuery regarding any disturbance is proceeded,please have some patience till then!");
            Hide();
        }
    }
}
