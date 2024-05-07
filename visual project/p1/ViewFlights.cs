using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p1
{
    public partial class ViewFlights : Form
    {
        public ViewFlights()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //عرض الجدول في الداتا قريد فيو 
        void fill_dgv(DataGridView dgv)
        {
            String conString = @"Data Source = HalahMoteia;  Initial Catalog = Airline0b ; Integrated Security = True";
            SqlConnection con = new SqlConnection(conString);
            String sql = "SELECT * FROM Flight";
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();

            try
            {
                con.Open();
                ad.Fill(ds);
                dgv2.DataSource = ds.Tables[0];

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
        //استدعاء الداله
        private void ViewFlights_Load(object sender, EventArgs e)
        {
            fill_dgv(dgv2);
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            F.Text = "";
            S.Text = "";
            T.Text = "";
            D.Text = "";
            N.Text = "";
        }

        //بوتون التحديث
        private void button4_Click(object sender, EventArgs e)
        {
            {
                if (F.Text != "" && S.Text != "" && D.Text != "" && T.Text != "" && N.Text != "")
                {
                    String conString = @"Data Source = HalahMoteia;  Initial Catalog = Airline0b; Integrated Security = True";
                    SqlConnection con = new SqlConnection(conString);
                    String sql = "UPDATE Flight SET Source = @2,Destination = @3, [Take Of Date] = @4,[Num Of Seats] = @5 WHERE [Flight Code] = @1";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@1", F.Text);
                    cmd.Parameters.AddWithValue("@2", S.Text);
                    cmd.Parameters.AddWithValue("@3", D.Text);
                    cmd.Parameters.AddWithValue("@4", T.Text);
                    cmd.Parameters.AddWithValue("@5", N.Text);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Flight Data Has Been Updated", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        con.Close();
                        fill_dgv(dgv2);
                    }
                }


                else
                {
                    MessageBox.Show("Enter valid data", "warnning", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
                
            
        }
        //عرض المحتويات داخل الخلايا
        private void dgv1_Click(object sender, DataGridViewCellEventArgs e)
        {
         
        
        }
        
        //بوتون الرجوع
        private void button1_Click(object sender, EventArgs e)
        {
           Flights  flights  = new Flights ();
            flights .Show();
            this.Hide();

        }

        private void T_ValueChanged(object sender, EventArgs e)
        {

        }

        //بوتون الحذف
        private void button3_Click(object sender, EventArgs e)
        {
            String conString = @"Data Source = HalahMoteia;  Initial Catalog = Airline0b ; Integrated Security = True";
            SqlConnection con = new SqlConnection(conString);
            String sql = "DELETE FROM Flight WHERE [Flight Code] = @1 ";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@1",F.Text);


            try
            {

                con.Open();
                cmd.ExecuteNonQuery();
                fill_dgv(dgv2);
                MessageBox.Show("The Flight Has Been Deleted", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void dgv2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
           /* if(e.RowIndex %2 ==0)
            {
                e.CellStyle.BackColor = Color.Blue;
            }*/
        }

        private void dgv2_Click(object sender, EventArgs e)
        {
            F.Text = dgv2.CurrentRow.Cells[0].Value.ToString();
            S.Text = dgv2.CurrentRow.Cells[1].Value.ToString();
            D.Text = dgv2.CurrentRow.Cells[2].Value.ToString();
            T.Text = dgv2.CurrentRow.Cells[3].Value.ToString();
            N.Text = dgv2.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
