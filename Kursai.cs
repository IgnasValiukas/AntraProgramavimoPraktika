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
    public partial class Kursai : Form
    {
        public Kursai()
        {
            InitializeComponent();
            ShowKur();
            GetFakID();
            GetDesID();
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
            FakCB.ValueMember = "FakID";
            FakCB.DataSource = dt;
            Con.Close();
        }
        private void GetFakPav()
        {
            Con.Open();
            string Query = "Select * from FakultetoLentele where FakID=" + FakCB.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Fak.Text = dr["FakPavadinimas"].ToString();
            }
            Con.Close();
        }
        private void GetDesID()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select DestID from DestytojoLnt", Con);
            SqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("DestID", typeof(int));
            dt.Load(Rdr);
            DesCB.ValueMember = "DestID";
            DesCB.DataSource = dt;
            Con.Close();
        }
        private void GetDesPav()
        {
            Con.Open();
            string Query = "Select * from DestytojoLnt where DestID=" + DesCB.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Vardas.Text = dr["DestVardas"].ToString();
                Pavarde.Text = dr["DestPavarde"].ToString();
            }
            Con.Close();
        }
        private void ShowKur()
        {
            Con.Open();
            string Query = "select * from KursoLnt";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builer = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            KurDVG.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Reset()
        {
            Pavarde.Text = "";
            Vardas.Text = "";
            Tru.Text = "";
            KurID.Text = "";
            Pav.Text = "";
            FakCB.SelectedIndex = -1;
            Fak.Text = "";
            DesCB.SelectedIndex = -1;
        }
        private void Prideti_Click(object sender, EventArgs e)
        {
            if (Vardas.Text == "" || Pavarde.Text == "" || Pav.Text == "" || Tru.Text == "" || FakCB.SelectedIndex == -1 || Fak.Text == "" || DesCB.SelectedIndex == -1)
            {
                MessageBox.Show("Užpidykite visus įvesties langelius!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into KursoLnt(KursoPav,KursoTrukme,KursoFakID,KursoFakPav,KursoDestID,KursoDestVar,KursoDestPav)values(@KP,@KT,@KFI,@KFP,@KDI,@KDV,@KDP)", Con);
                    cmd.Parameters.AddWithValue("@KP", Pav1.Text);
                    cmd.Parameters.AddWithValue("@KT", Tru1.Text);
                    cmd.Parameters.AddWithValue("@KFI", FakCB.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@KFP", Fak.Text);
                    cmd.Parameters.AddWithValue("@KDI", DesCB.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@KDV", Vardas.Text);
                    cmd.Parameters.AddWithValue("@KDP", Pavarde.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Dalykas pridėtas!");
                    Con.Close();
                    ShowKur();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void Fak_TextChanged(object sender, EventArgs e)
        {
        }

        private void FakCB_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void FakCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetFakPav();
        }

        private void DesCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetDesPav();
        }

        private void Redaguoti_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand comm = new SqlCommand("Update KursoLnt set KursoPav=@KP,KursoTrukme=@KT,KursoFakID=@KFI,KursoFakPav=@KFP,KursoDestID=@KDI,KursoDestVar=@KDV,KursoDestPav=@KDP where KursoID=@KurID", Con);                                                               
                comm.Parameters.AddWithValue("@KurID", int.Parse(KurID.Text));
                comm.Parameters.AddWithValue("@KP", Pav1.Text);
                comm.Parameters.AddWithValue("@KT", Tru1.Text);
                comm.Parameters.AddWithValue("@KFI", FakCB.SelectedValue.ToString());
                comm.Parameters.AddWithValue("@KFP", Fak.Text);
                comm.Parameters.AddWithValue("@KDI", DesCB.SelectedValue.ToString());
                comm.Parameters.AddWithValue("@KDV", Vardas.Text);
                comm.Parameters.AddWithValue("@KDP", Pavarde.Text);
                comm.ExecuteNonQuery();
                Con.Close();
                MessageBox.Show("Sėkmingai redaguota!");
                ShowKur();
                Reset();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Istrinti_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand comm = new SqlCommand("Delete KursoLnt where KursoID=@KurID", Con);
                comm.Parameters.AddWithValue("@KurID", int.Parse(KurID.Text));
                comm.ExecuteNonQuery();
                Con.Close();
                MessageBox.Show("Sėkmingai ištrinta!");
                ShowKur();
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
