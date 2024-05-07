using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace p1
{
    public partial class Flights : Form
    {
        public Flights()
        {
            InitializeComponent();
        }

        void dgv2(DataGridView dgv2)
        {
            String conString = @"Data Source = HalahMoteia;  Initial Catalog =Airline0b ; Integrated Security = True";
            SqlConnection con = new SqlConnection(conString);
            String sql = "select * from Flight";
            SqlDataAdapter sda = new SqlDataAdapter(sql, con);

            DataSet sd = new DataSet();
            DataTable dt = new DataTable();

            try
            {
                con.Open();
                sda.Fill(sd);
                dgv2.DataSource = sd.Tables[0];

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

        private void Flights_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();

        }

        private void label13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FC.Text = "";
            So1.Text = "";
            So2.Text = "";
            Date.Text = "";
            Nof.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ViewFlights viewFlights = new ViewFlights();
            viewFlights.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FC.Text != "" && So1.Text != "" && So2.Text != "" && Date.Text != "" && Nof.Text != "")
            {
                String conString = @"Data Source = HalahMoteia;  Initial Catalog = Airline0b; Integrated Security = True";
                SqlConnection con = new SqlConnection(conString);
                String sql = "INSERT INTO Flight ([Flight Code],Source,Destination,[Take Of Date],[Num Of Seats]) VALUES (@1,@2,@3,@4,@5)";
                SqlCommand cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@1", Convert.ToInt32(FC.Text));
                cmd.Parameters.AddWithValue("@2", So1.SelectedItem);
                cmd.Parameters.AddWithValue("@3", So2.SelectedItem);
                cmd.Parameters.AddWithValue("@4", Date.Text);
                cmd.Parameters.AddWithValue("@5", Convert.ToInt32(Nof.Text));

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Flight Recorded Successfully", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Enter valid data", "warnning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void FC_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


