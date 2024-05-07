using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p1
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        // بوتون حذف المحتويات
        private void button1_Click(object sender, EventArgs e)
        {
            unmtb.Text = "";
            pass.Text = "";

        }


        private void login_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //قفل البرنامج
        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //في حال لم يدخل اسم مستخدم ولا كلمة مرور
            if (unmtb.Text == "" || pass.Text == "")
            {
                MessageBox.Show("Enter The User name Or Password");

            }
            //في حال ادخل اسم المستخدم ورمز الدخول 
            else if(unmtb.Text == "Admin" && pass.Text == "12345")
            {

                MessageBox.Show("Wellcome To Airline Application");

                Form2 form2 = new Form2(); //الانتقال الى الصفحه التاليه
                form2.Show();
                this.Hide(); 

               
            }
            //في حال ادخل اسم مستخدم ورمز دخول خاطئ
            else
            {
                MessageBox.Show("Wrong User Name Or Password");
            }
        }

        private void pass_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void unmtb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)Keys.Enter)
                {
                pass.Focus();
            }
        }
    }
}

