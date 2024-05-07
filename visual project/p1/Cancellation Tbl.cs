using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p1
{
    public partial class Cancellation_Tbl : Form
    {
        public Cancellation_Tbl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();

        }

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Can.Text = "";
            Tic.Text = "";
            FC.Text = "";
            Date.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void Cancellation_Tbl_Load(object sender, EventArgs e)
        {

        }
    }
}
