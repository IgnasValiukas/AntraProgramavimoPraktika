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

namespace KolegijosVertinimoSistema_admin_
{
    public partial class Fakultetas : Form
    {
        public Fakultetas()
        {
            InitializeComponent();
            ShowFak();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ignas\OneDrive\Dokumentai\KolegijosDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void ShowFak()
        {
            Con.Open();
            string Query = "select * from FakultetoLentele";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builer = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            FakDVG.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Reset()
        {
            FakPav.Text = "";
            FakuID.Text = "";
        }
        private void PridetiM1_Click(object sender, EventArgs e)
        {
            if (FakPav.Text == "")
            {
                MessageBox.Show("Iveskite Fakulteto pavadinimą!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into FakultetoLentele(FakPavadinimas)values(@FP)", Con);
                    cmd.Parameters.AddWithValue("@FP",FakPav.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Fakultetas pridėtas!");
                    Con.Close();
                    ShowFak();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        //int Key = 0;
        private void FakDVG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //FakPav.Text = FakDVG.SelectedRows[0].Cells[1].Value.ToString();
            
        }

        private void IstrintiM1_Click(object sender, EventArgs e)
        {
                try
                {
                    Con.Open();
                    SqlCommand comm = new SqlCommand("Delete FakultetoLentele where FakID=@FakID", Con);
                    comm.Parameters.AddWithValue("@FakID", int.Parse(FakuID.Text));
                    comm.ExecuteNonQuery();
                    Con.Close();
                MessageBox.Show("Sėkmingai ištrinta!");
                    ShowFak();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
        }

        private void Redaguoti_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand comm = new SqlCommand("Update FakultetoLentele set FakPavadinimas=@FakPavadinimas where FakID=@FakID", Con);
                comm.Parameters.AddWithValue("@FakID", int.Parse(FakuID.Text));
                comm.Parameters.AddWithValue("@FakPavadinimas", FakPav.Text);
                comm.ExecuteNonQuery();
                Con.Close();
                MessageBox.Show("Sėkmingai redaguota!");
                ShowFak();
                Reset();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pagrindinis Obj = new Pagrindinis();
            Obj.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Destytojai Obj = new Destytojai();
            Obj.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Studentai Obj = new Studentai();
            Obj.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Kursai Obj = new Kursai();
            Obj.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Prisijungimas Obj = new Prisijungimas();
            Obj.Show();
            this.Hide();
        }
    }
}
