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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        //الانتقال الى صفحه الرحلات
        private void button1_Click(object sender, EventArgs e)
        {
            Flights  flights  = new Flights ();
            flights .Show();
            this.Hide();

        }

        //الانتقال الى صفحه الركاب

        private void button2_Click(object sender, EventArgs e)
        {
            AddPassenger  addPassenger  = new AddPassenger ();
            addPassenger .Show();
            this.Hide();

        }

        //الانتقال الى صفحه التذاكر

        private void button3_Click(object sender, EventArgs e)
        {
            Ticket  ticket  = new Ticket ();
            ticket .Show();
            this.Hide();

        }

        

        private void label13_Click(object sender, EventArgs e)
        {
          
        }

        //تقفيل البرنامج 
        private void button4_Click_1(object sender, EventArgs e)
        {

            Application.Exit();
        }
    }
}
