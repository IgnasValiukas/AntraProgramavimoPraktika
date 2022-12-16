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
    public partial class Vertinimas : Form
    {
        public string name { get; set; }
        public string lastName { get; set; }
        public Vertinimas()
        {
            InitializeComponent();
            ShowVert();
            GetStuID();
            GetDalID();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ignas\OneDrive\Dokumentai\KolegijosDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void GetStuID()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select StuID from StudentoLentele", Con);
            SqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("StuID", typeof(int));
            dt.Load(Rdr);
            StuIDCB.ValueMember = "StuID";
            StuIDCB.DataSource = dt;
            Con.Close();
        }
        private void GetStuDuom()
        {
            Con.Open();
            string Query = "Select * from StudentoLentele where StuID=" + StuIDCB.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Vardas.Text = dr["StuVardas"].ToString();
                Pavarde.Text = dr["StuPavarde"].ToString();
            }
            Con.Close();
        }
        private void GetDalID()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select KursoID from KursoLnt", Con);
            SqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("KursoID", typeof(int));
            dt.Load(Rdr);
            DaICB.ValueMember = "KursoID";
            DaICB.DataSource = dt;
            Con.Close();
        }
        private void GetDalDuom()
        {
            Con.Open();
            string Query = "Select * from KursoLnt where KursoID=" + DaICB.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                DalPavadinimas.Text = dr["KursoPav"].ToString();
            }
            Con.Close();
        }
        private void ShowVert()
        {
            Con.Open();
            string Query = "select * from VertinimoLnt";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builer = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            VertDVG.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Reset()
        {
            Pavarde.Text = "";
            Vardas.Text = "";
            DalPavadinimas.Text = "";
            VertID.Text = "";
            StuIDCB.SelectedIndex = -1;
            DaICB.SelectedIndex = -1;
            EgzoCB.SelectedIndex = -1;
            KontroCB.SelectedIndex = -1;
            TestoCB.SelectedIndex = -1;
        }
        private void StuIDCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetStuDuom();
        }

        private void DaICB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetDalDuom();
        }
        private void Prideti_Click(object sender, EventArgs e)
        {
            if (Vardas.Text == "" || Pavarde.Text == "" || StuIDCB.SelectedIndex == -1 || DalPavadinimas.Text == "" || DaICB.SelectedIndex == -1 || KontroCB.SelectedIndex == -1 || EgzoCB.SelectedIndex == -1 || TestoCB.SelectedIndex == -1)
            {
                MessageBox.Show("Užpidykite visus įvesties langelius!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into VertinimoLnt(StudentoID,StudentoVardas,StudentoPavarde,DalykoID,DalykoPavadinimas,EgzaminoIvertinimas,KontrolinioIvertinimas,TestoIvertinimas)values(@SI,@SV,@SP,@DI,@DP,@EI,@KI,@TI)", Con);
                    cmd.Parameters.AddWithValue("@SI", StuIDCB.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@SV", Vardas.Text);
                    cmd.Parameters.AddWithValue("@SP", Pavarde.Text);
                    cmd.Parameters.AddWithValue("@DI", DaICB.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@DP", DalPavadinimas.Text);
                    cmd.Parameters.AddWithValue("@EI", EgzoCB.SelectedIndex.ToString());
                    cmd.Parameters.AddWithValue("@KI", KontroCB.SelectedIndex.ToString());
                    cmd.Parameters.AddWithValue("@TI", TestoCB.SelectedIndex.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ivertinimas pridėtas!");
                    Con.Close();
                    ShowVert();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void Istrinti_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand comm = new SqlCommand("Delete VertinimoLnt where VertinimoID=@VertID", Con);
                comm.Parameters.AddWithValue("@VertID", int.Parse(VertID.Text));
                comm.ExecuteNonQuery();
                Con.Close();
                MessageBox.Show("Sėkmingai ištrinta!");
                ShowVert();
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
                SqlCommand comm = new SqlCommand("Update VertinimoLnt set StudentoID=@SI,StudentoVardas=@SV,StudentoPavarde=@SP,DalykoID=@DI,DalykoPavadinimas=@DP,EgzaminoIvertinimas=@EI,KontrolinioIvertinimas=@KI,TestoIvertinimas=@TI where VertinimoID=@VertID", Con);
                comm.Parameters.AddWithValue("@VertID", int.Parse(VertID.Text));
                comm.Parameters.AddWithValue("@SI", StuIDCB.SelectedValue.ToString());
                comm.Parameters.AddWithValue("@SV", Vardas.Text);
                comm.Parameters.AddWithValue("@SP", Pavarde.Text);
                comm.Parameters.AddWithValue("@DI", DaICB.SelectedValue.ToString());
                comm.Parameters.AddWithValue("@DP", DalPavadinimas.Text);
                comm.Parameters.AddWithValue("@EI", EgzoCB.SelectedIndex.ToString());
                comm.Parameters.AddWithValue("@KI", KontroCB.SelectedIndex.ToString());
                comm.Parameters.AddWithValue("@TI", TestoCB.SelectedIndex.ToString());
                comm.ExecuteNonQuery();
                Con.Close();
                MessageBox.Show("Sėkmingai redaguota!");
                ShowVert();
                Reset();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Vertinimas_Load(object sender, EventArgs e)
        {
            PrVardas.Text = name;
            PrPavarde.Text = lastName;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Prisijungimas Obj = new Prisijungimas();
            Obj.Show();
            this.Hide();
        }

        /*private void BVskaiciavimas_Click(object sender, EventArgs e)
        {
            /*double[] V = new double[14];
            V[0] = Convert.ToDouble(EgzoCB.SelectedIndex);
            V[1] = Convert.ToDouble(KontroCB.SelectedIndex);
            V[2] = Convert.ToDouble(TestoCB.SelectedIndex);
            V[3] = (V[0]*0.5) + (V[1]*0.3) + (V[2]*0.2) + 1;
            string vidurkis = Convert.ToString(V[3]);
            BendrasIvertinimas1.Text = vidurkis;
        }*/
    }
}
