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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace p1
{
    public partial class ViewPassenger : Form
    {



        public ViewPassenger()
        {
            InitializeComponent();
        }








        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }
        //عشان تنعرض لي البيانات في اماكنها فوق 

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            Pid.Text = dgv1.CurrentRow.Cells[0].Value.ToString();
            Na.Text = dgv1.CurrentRow.Cells[1].Value.ToString();
            Pass.Text = dgv1.CurrentRow.Cells[2].Value.ToString();
            Add.Text = dgv1.CurrentRow.Cells[3].Value.ToString();
            Nat.SelectedItem = dgv1.CurrentRow.Cells[4].Value.ToString();
            Gen.SelectedItem = dgv1.CurrentRow.Cells[5].Value.ToString();
            Ph.Text = dgv1.CurrentRow.Cells[6].Value.ToString();

            

        }
    
        //عشان تنعرض البيانات في الداتا قريد فيو
        void fill_dgv(DataGridView dgv)
        {
            String conString = @"Data Source = HalahMoteia;  Initial Catalog = Airline0b; Integrated Security = True";
            SqlConnection con = new SqlConnection(conString);
            String sql = "SELECT * FROM Airline";
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();

            try
            {
                con.Open();
                ad.Fill(ds);
                dgv1.DataSource = ds.Tables[0];

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
        private void ViewPassenger_Load(object sender, EventArgs e)
        {

            fill_dgv(dgv1);
        }


        //تحديث البيانات
        private void button4_Click(object sender, EventArgs e)
        {
           
            if (Pid.Text != "" && Na.Text != "" && Pass.Text != "" && Add.Text != "" && Nat .Text != "" && Gen.Text !="" && Ph.Text !="")
            { 
                String conString = @"Data Source = HalahMoteia;  Initial Catalog = Airline0b; Integrated Security = True";
            SqlConnection con = new SqlConnection(conString);
            String sql = "UPDATE Airline SET PassName = @2,Passport = @3, PassAd = @4, PassNet = @5,PassGend = @6, PassPhone = @7  WHERE PassId = @1";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@1", Convert.ToInt32(Pid.Text));
            cmd.Parameters.AddWithValue("@2", Na.Text);
            cmd.Parameters.AddWithValue("@3", Convert.ToInt32(Pass.Text));
            cmd.Parameters.AddWithValue("@4", Add.Text);
            cmd.Parameters.AddWithValue("@5", Nat.SelectedItem);
            cmd.Parameters.AddWithValue("@6", Gen.SelectedItem);
            cmd.Parameters.AddWithValue("@7", Convert.ToInt32(Ph.Text));
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Passenger Information Has Been Updated", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                fill_dgv(dgv1);
            }
        }

            
               else
            {
                MessageBox.Show("Enter valid data", "warnning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        

        
        }
    

        private void label11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pid.Text = "";
            Na.Text = "";
            Pass.Text = "";
            Add.Text = "";
            Nat.Text = "";
            Gen.Text = "";
            Ph.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddPassenger addPassenger = new AddPassenger();
            addPassenger.Show();
            this.Hide();

        }

        private void Na_TextChanged(object sender, EventArgs e)
        {

        }

        //حذف البيانات
        private void button3_Click(object sender, EventArgs e)
        {
            String conString = @"Data Source = HalahMoteia;  Initial Catalog = Airline0b; Integrated Security = True";
            SqlConnection con = new SqlConnection(conString);
            String sql = "DELETE FROM Airline WHERE PassId = @1 ";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@1", Convert.ToInt64(Pid.Text));


            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                fill_dgv(dgv1);
                MessageBox.Show("The Passenger Has Been Deleted", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}


