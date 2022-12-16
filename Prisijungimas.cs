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
    public partial class Prisijungimas : Form
    {
        public Prisijungimas()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ignas\OneDrive\Dokumentai\KolegijosDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }
        private void label11_Click(object sender, EventArgs e)
        {
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (AdminSlaptazodis.Text == "" || AdminVardas.Text == "")
            {
                MessageBox.Show("Įveskite visus duomenis!");
            } else if (AdminSlaptazodis.Text == "admin" && AdminVardas.Text == "admin")
            {
                Pagrindinis Obj = new Pagrindinis();
                Obj.Show();
                this.Hide();
            } else
            {
                MessageBox.Show("Neteisingi duomenys!");
                AdminSlaptazodis.Text = "";
                AdminVardas.Text = "";
            }
        }
        private void isjungti_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DesPrisijungti_Click(object sender, EventArgs e)
        {
            string prisijungimoVardas, slaptazodis;
            prisijungimoVardas = DestytojoVardas.Text;
            slaptazodis = DestytojoSlaptazodis.Text;

            try
            {
                String quarry = "SELECT * FROM PrisijungimoLnt WHERE PVardas = '" + DestytojoVardas.Text + "' AND PSlaptazodis = '" + DestytojoSlaptazodis.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(quarry, Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    prisijungimoVardas = DestytojoVardas.Text;
                    slaptazodis = DestytojoSlaptazodis.Text;

                    Vertinimas Obj = new Vertinimas();
                    Obj.name = DestytojoVardas.Text;
                    Obj.lastName = DestytojoSlaptazodis.Text;
                    Obj.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Neteisingi duomenys!");
                    DestytojoVardas.Text = "";
                    DestytojoSlaptazodis.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Neteisingi duomenys!");
            }
            finally
            {
                Con.Close();
            }
        }

        private void StuPrisijunti_Click(object sender, EventArgs e)
        {
            string prisijungimoVardas, slaptazodis;
            prisijungimoVardas = StudentoVardas.Text;
            slaptazodis = StudentoSlaptazodis.Text;

            try
            {
                String quarry = "SELECT * FROM PrisijungimoStuLnt WHERE PrisijungimoStuVardas = '" + StudentoVardas.Text + "' AND PrisijungimoStuPavarde = '" + StudentoSlaptazodis.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(quarry, Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    StudentoIvertinimai Obj = new StudentoIvertinimai();
                    Obj.Studentname = StudentoVardas.Text;
                    Obj.StudentlastName = StudentoSlaptazodis.Text;
                    Obj.Show();
                    this.Hide();
                Con.Close();
                }
                else
                {
                    MessageBox.Show("Neteisingi duomenys!");
                    StudentoVardas.Text = "";
                    StudentoSlaptazodis.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Error!");
            }
            finally
            {
                Con.Close();
            }
            }
        private void Prisijungimas_Load(object sender, EventArgs e)
        {
        }
    }
}
