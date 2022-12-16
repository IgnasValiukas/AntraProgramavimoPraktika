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
    public partial class Studentai : Form
    {
        public Studentai()
        {
            InitializeComponent();
            ShowStu();
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
            string Query = "Select * from FakultetoLentele where FakID="+FakIDcb.SelectedValue.ToString()+"";
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                Faku.Text = dr["FakPavadinimas"].ToString();
            }
            Con.Close();
        }
        private void ShowStu()
        {
            Con.Open();
            string Query = "select * from StudentoLentele";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builer = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            StuDVG.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Reset()
        {
            Pavarde.Text = "";
            Vardas.Text = "";
            TelNr.Text = "";
            FakIDcb.SelectedIndex = -1;
            Faku.Text = "";
            SemeCB.SelectedIndex = -1;
        }
        private void SGrupe_Click(object sender, EventArgs e)
        {
           
        }
        private void button12_Click(object sender, EventArgs e)
        {
            if (Vardas.Text == "" || Pavarde.Text == "" || TelNr.Text == "" || FakIDcb.SelectedIndex == -1 || Faku.Text == "" || SemeCB.SelectedIndex == -1)
            {
                MessageBox.Show("Užpidykite visus įvesties langelius!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into StudentoLentele(StuVardas,StuPavarde,StuFakID,StuFakPavadinimas,StuTelNumeris,StuSemestras)values(@SV,@SP,@SFI,@SFP,@STN,@SS)", Con);
                    cmd.Parameters.AddWithValue("@SV", Vardas.Text);
                    cmd.Parameters.AddWithValue("@SP", Pavarde.Text);
                    cmd.Parameters.AddWithValue("@SFI", FakIDcb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@SFP", Faku.Text);
                    cmd.Parameters.AddWithValue("@STN", TelNr.Text);
                    cmd.Parameters.AddWithValue("@SS", SemeCB.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                    SqlCommand cmdP = new SqlCommand("insert into PrisijungimoStuLnt(PrisijungimoStuVardas,PrisijungimoStuPavarde)values(@PSV,@PSP)", Con);
                    cmdP.Parameters.AddWithValue("@PSV", Vardas.Text);
                    cmdP.Parameters.AddWithValue("@PSP", Pavarde.Text);
                    cmdP.ExecuteNonQuery();
                    MessageBox.Show("Studentas pridėtas!");
                    Con.Close();
                    ShowStu();
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

        private void Istrinti_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand comm = new SqlCommand("Delete StudentoLentele where StuID=@StuID", Con);
                comm.Parameters.AddWithValue("@StuID", int.Parse(StuID.Text));
                comm.ExecuteNonQuery();
                Con.Close();
                MessageBox.Show("Sėkmingai ištrinta!");
                ShowStu();
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
                SqlCommand comm = new SqlCommand("Update StudentoLentele set StuVardas=@SV,StuPavarde=@SP,StuFakID=@SFI,StuFakPavadinimas=@SFP,StuTelNumeris=@STN,StuSemestras=@SS where StuID=@StuID", Con);
                comm.Parameters.AddWithValue("@StuID", int.Parse(StuID.Text));
                comm.Parameters.AddWithValue("@SV", Vardas.Text);
                comm.Parameters.AddWithValue("@SP", Pavarde.Text);
                comm.Parameters.AddWithValue("@SFI", FakIDcb.SelectedValue.ToString());
                comm.Parameters.AddWithValue("@SFP", Faku.Text);
                comm.Parameters.AddWithValue("@STN", TelNr.Text);
                comm.Parameters.AddWithValue("@SS", SemeCB.SelectedItem.ToString());
                comm.ExecuteNonQuery();
                Con.Close();
                MessageBox.Show("Sėkmingai redaguota!");
                ShowStu();
                Reset();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void StuDVG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
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

        private void button4_Click(object sender, EventArgs e)
        {
            Kursai Obj = new Kursai();
            Obj.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Fakultetas Obj = new Fakultetas();
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
