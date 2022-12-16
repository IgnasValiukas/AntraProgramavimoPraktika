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
    public partial class StudentoIvertinimai : Form
    {
        public string Studentname { get; set; }
        public string StudentlastName { get; set; }
        public StudentoIvertinimai()
        {
            InitializeComponent();
            ShowVert();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ignas\OneDrive\Dokumentai\KolegijosDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void ShowVert()
        {
            string Query = "select * from [VertinimoLnt]";
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            sda.Fill(dt);
            StuVertDVG.AutoGenerateColumns = false;
            StuVertDVG.ColumnCount = 4;
            StuVertDVG.Columns[0].HeaderText = "Dalyko Pavadinimas";
            StuVertDVG.Columns[0].DataPropertyName = "DalykoPavadinimas";
            StuVertDVG.Columns[1].HeaderText = "Egzamino";
            StuVertDVG.Columns[1].DataPropertyName = "EgzaminoIvertinimas";
            StuVertDVG.Columns[2].HeaderText = "Kontrolinio";
            StuVertDVG.Columns[2].DataPropertyName = "KontrolinioIvertinimas";
            StuVertDVG.Columns[3].HeaderText = "Testo";
            StuVertDVG.Columns[3].DataPropertyName = "TestoIvertinimas";
            StuVertDVG.DataSource = dt;
            Con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Prisijungimas Obj = new Prisijungimas();
            Obj.Show();
            this.Hide();
        }

        private void StudentoIvertinimai_Load(object sender, EventArgs e)
        {
           StudentoVardas.Text = Studentname;
           StudentoPavarde.Text = StudentlastName;
        }
    }
}
