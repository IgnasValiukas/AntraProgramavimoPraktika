using MySql.Data.MySqlClient;
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
    public partial class Destytojai : Form
    {
        public Destytojai()
        {
            InitializeComponent();
            ShowDes();
            GetFakID();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ignas\OneDrive\Dokumentai\KolegijosDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void GetFakID()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select FakID from FakultetoLentele", Con);
            SqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("FakID", typeof(int));
            dt.Load(Rdr);
            FakIDcb.ValueMember = "FakID";
            FakIDcb.DataSource = dt;
            Con.Close();
        }
        private void GetFakPav()
        {
            Con.Open();
            string Query = "Select * from FakultetoLentele where FakID=" + FakIDcb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Faku.Text = dr["FakPavadinimas"].ToString();
            }
            Con.Close();
        }
        private void ShowDes()
        {
            Con.Open();
            string Query = "select * from DestytojoLnt";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builer = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            DesDVG.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Reset()
        {
            Pavarde.Text = "";
            Vardas.Text = "";
            TelNr.Text = "";
            FakIDcb.SelectedIndex = -1;
            Faku.Text = "";
            DalIDcb.SelectedIndex = -1;
            DestDal.Text = "";
            DestID.Text = "";
        }

        private void Destytojai_Load(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (Vardas.Text == "" || Pavarde.Text == "" || TelNr.Text == "" || FakIDcb.SelectedIndex == -1 || Faku.Text == "")
            {
                MessageBox.Show("Užpidykite visus įvesties langelius!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into DestytojoLnt(DestVardas,DestPavarde,DestTelNumeris,DestFakID,DestFakPav,DestPaskID,DestPaskPav)values(@DV,@DP,@DTN,@DFI,@DFP,@DPI,@DPP)", Con);
                    cmd.Parameters.AddWithValue("@DV", Vardas.Text);
                    cmd.Parameters.AddWithValue("@DP", Pavarde.Text);
                    cmd.Parameters.AddWithValue("@DTN", TelNr.Text); 
                    cmd.Parameters.AddWithValue("@DFI", FakIDcb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@DFP", Faku.Text);
                    cmd.Parameters.AddWithValue("@DPI", DalIDcb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@DPP", DestDal.Text);
                    cmd.ExecuteNonQuery();
                    SqlCommand cmdP = new SqlCommand("insert into PrisijungimoLnt(PVardas,PSlaptazodis)values(@PV,@PS)", Con);
                    cmdP.Parameters.AddWithValue("@PV", Vardas.Text);
                    cmdP.Parameters.AddWithValue("@PS", Pavarde.Text);
                    cmdP.ExecuteNonQuery();
                    MessageBox.Show("Dėstytojas pridėtas!");
                    Con.Close();
                    ShowDes();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void FakIDcb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetFakPav();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Fakultetas Obj = new Fakultetas();
            Obj.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Studentai Obj = new Studentai();
            Obj.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Pagrindinis Obj = new Pagrindinis();
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

        private void Istrinti_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand comm = new SqlCommand("Delete DestytojoLnt where DestID=@DestID", Con);
                comm.Parameters.AddWithValue("@DestID", int.Parse(DestID.Text));
                comm.ExecuteNonQuery();
                Con.Close();
                MessageBox.Show("Sėkmingai ištrinta!");
                ShowDes();
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
                SqlCommand comm = new SqlCommand("Update DestytojoLnt set DestVardas=@DV,DestPavarde=@DP,DestTelNumeris=@DTN,DestFakID=@DFI,DestFakPav=@DFP,DestPaskID=@DPI,DestPaskPav=@DPP where DestID=@DestID", Con);
                comm.Parameters.AddWithValue("@DestID", int.Parse(DestID.Text));
                comm.Parameters.AddWithValue("@DV", Vardas.Text);
                comm.Parameters.AddWithValue("@DP", Pavarde.Text);
                comm.Parameters.AddWithValue("@DTN", TelNr.Text);
                comm.Parameters.AddWithValue("@DFI", FakIDcb.SelectedValue.ToString());
                comm.Parameters.AddWithValue("@DFP", Faku.Text);
                comm.Parameters.AddWithValue("@DPI", DalIDcb.SelectedItem.ToString());
                comm.Parameters.AddWithValue("@DPP", DestDal.Text);
                comm.ExecuteNonQuery();
                Con.Close();
                MessageBox.Show("Sėkmingai redaguota!");
                ShowDes();
                Reset();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
}
