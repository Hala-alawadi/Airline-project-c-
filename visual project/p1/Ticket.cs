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
using System.Security.Cryptography;


namespace p1
{
    public partial class Ticket : Form
    {
        public Ticket()
        {
            InitializeComponent();
        }

        //عرض الجدول في الداتا قريد فيو 
        void dgv(DataGridView dataGridView1)
        {
            String conString = @"Data Source = HalahMoteia;  Initial Catalog =Airline0b ; Integrated Security = True";
            SqlConnection con = new SqlConnection(conString);
            String sql = "select * from Airline";
            SqlDataAdapter sda = new SqlDataAdapter(sql, con);
            DataSet sd = new DataSet();
            DataTable dt = new DataTable();

            try
            {
                con.Open();
                sda.Fill(sd);
                dataGridView1.DataSource = sd.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }



        //عرض البيانات المخزنة في جدول الرحلات بداخل الكومبو 
        void fill_com()
        {
            String conString = @"Data Source = HalahMoteia;  Initial Catalog =Airline0b ; Integrated Security = True";
            SqlConnection con = new SqlConnection(conString);
            String sql = "select * from Flight";
            SqlDataAdapter sda = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
           


            try
            {
                con.Open();
                sda.Fill(dt);

                comboBox2.DataSource = dt;
                comboBox2.ValueMember = "Flight Code";
                comboBox2.DisplayMember = "Flight Code";



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        //عرض البيانات المخزنة في جدول الطيران بداخل الكومبو 

        void fill_con()
        {
            String conString = @"Data Source = HalahMoteia;  Initial Catalog =Airline0b ; Integrated Security = True";
            SqlConnection con = new SqlConnection(conString);
            String sql = "select * from Airline";
            SqlDataAdapter sda = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
         
            try
            {
                con.Open();
                sda.Fill(dt);

                comboBox1.DataSource = dt;
                comboBox1.ValueMember = "PassId";
                comboBox1.DisplayMember = "PassId";



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        //استدعاء الدوال 
        private void Ticket_Load(object sender, EventArgs e)
        {
            dgv(dataGridView1);
            fill_com();
            fill_con();

        }

        private void label12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();

        }

        private void label13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //بوتون حذف المحتويات Reset
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            comboBox2.Text = "";
            comboBox1.Text = "";
            textBox4.Text = "";
            textBox3.Text = "";
            textBox2.Text = "";
            textBox5.Text = "";



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //تعبئة الحقول تلقائيا عند الاختيار من الكومبو 
            if(label6.Text == "PassId")
            {
                String conString = @"Data Source = HalahMoteia;  Initial Catalog = Airline0b; Integrated Security = True";
                SqlConnection con = new SqlConnection(conString);
                DataTable dt2 = new DataTable();
                SqlDataAdapter sd = new SqlDataAdapter("select * from Airline where PassId = '"+Convert.ToInt32 ( comboBox1.Text)+"'", con);
                

                try
                {
                    con.Open();
                    sd.Fill(dt2);
                    textBox2.Text = dt2.Rows[0]["PassName"].ToString();
                    textBox4.Text = dt2.Rows[0]["Passport"].ToString();
                    textBox3.Text = dt2.Rows[0]["PassNet"].ToString();


                }

                catch
                {
                    return;
                }
                finally
                {
                    con.Close();
                }
            }
    
        }
    
        
      
        private void button3_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text != "" && comboBox2.Text  != "" && comboBox1.Text  != "" && textBox2.Text != "" && textBox4.Text != "" && textBox3.Text != "" && textBox5.Text != "")
            {
                String conString = @"Data Source = HalahMoteia;  Initial Catalog = Airline0b; Integrated Security = True";
                SqlConnection con = new SqlConnection(conString);
                String sql = "INSERT INTO Book (TicketId,Name,FlightCode,PassengerId,Passport,Nationality,Amount) VALUES (@1,@2,@3,@4,@5,@6,@7)";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@1", Convert.ToInt32(textBox1.Text));
                cmd.Parameters.AddWithValue("@2",comboBox2.SelectedItem);
                cmd.Parameters.AddWithValue("@3", comboBox1.SelectedItem);
                cmd.Parameters.AddWithValue("@4", textBox2.Text);
                cmd.Parameters.AddWithValue("@5", Convert.ToInt32 ( textBox4.Text));
                cmd.Parameters.AddWithValue("@6", textBox3.Text);
                cmd.Parameters.AddWithValue("@7", Convert.ToInt32(textBox5.Text));

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Your Have Been Booked Successfully", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();

                }
            }
            else
            {
                MessageBox.Show("Enter Your Data To Complete Your Booking ", "warnning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

