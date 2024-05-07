using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;


namespace p1
{
    public partial class AddPassenger : Form
    {
        public AddPassenger()
        {
            InitializeComponent();


        }
    
        //عرض المحتويات داخل الداتا قريد فيو 
        void dgv(DataGridView dgv)
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
                dgv.DataSource = sd.Tables[0];

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

        

    

    private void AddPassenger_Load(object sender, EventArgs e)
        {

         
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        //اضافه بيانات الراكب
        private void button1_Click(object sender, EventArgs e)
        {
            if (PassId.Text != "" && PassName.Text != "" && Passport.Text != "" && PassAd.Text != "" && PhoneTd.Text != "")
            {
                String conString = @"Data Source = HalahMoteia;  Initial Catalog = Airline0b; Integrated Security = True";
                SqlConnection con = new SqlConnection(conString);
                String sql = "INSERT INTO Airline (PassId,PassName,Passport,PassAd,PassNet,PassGend,PassPhone) VALUES (@1,@2,@3,@4,@5,@6,@7)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@1", Convert.ToInt32(PassId.Text));
                cmd.Parameters.AddWithValue("@2", PassName.Text);
                cmd.Parameters.AddWithValue("@3", Convert.ToInt32(Passport.Text));
                cmd.Parameters.AddWithValue("@4", PassAd.Text);
                cmd.Parameters.AddWithValue("@5", NationalityCb.SelectedItem);
                cmd.Parameters.AddWithValue("@6", GenderCb.SelectedItem);
                cmd.Parameters.AddWithValue("@7", Convert.ToInt64(PhoneTd.Text));
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Passenger Recorded Successfully", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PassId.Text = "";
            PassName.Text = "";
            Passport.Text = "";
            PassAd.Text = "";
            NationalityCb.Text = "";
            GenderCb.Text = "";
            PhoneTd.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ViewPassenger viewPassenger  = new ViewPassenger ();
            viewPassenger.Show();
            this.Hide();
        }
    }
}