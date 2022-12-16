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
    public partial class Pagrindinis : Form
    {
        public Pagrindinis()
        {
            InitializeComponent();
            StuKiekis();
            DesKiekis();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ignas\OneDrive\Dokumentai\KolegijosDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void StuKiekis()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from StudentoLentele", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            StudKiekis.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void DesKiekis()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from DestytojoLnt", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DestKiekis.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Destytojai frm = new Destytojai();
            Pagrindinis frm1 = new Pagrindinis();
            frm.Visible = true;
            frm1.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Prisijungimas prisi = new Prisijungimas();
            Pagrindinis frm1 = new Pagrindinis();
            prisi.Visible = true;
            frm1.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
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

        private void button6_Click(object sender, EventArgs e)
        {
            Fakultetas Obj = new Fakultetas();
            Obj.Show();
            this.Hide();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Prisijungimas Obj = new Prisijungimas();
            Obj.Show();
            this.Hide();
        }
    }
}
