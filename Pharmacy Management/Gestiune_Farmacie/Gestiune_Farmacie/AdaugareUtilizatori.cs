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

namespace Gestiune_Farmacie
{
    public partial class AdaugareUtilizatori : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=\\HOME\home\ds220\Documents\Farmaciedb.mdf;Integrated Security=True;Connect Timeout=30");
        public AdaugareUtilizatori()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
                MessageBox.Show("Nu se accepta randuri goale. Completati toate randurile");
            else
            {
                Con.Open();
                string query = "insert into Autentificare values('" + textBox1.Text + "','" + textBox2.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Utilizatorul a fost adaugat cu succes");
                Con.Close();

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Acasa A = new Acasa();
            A.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Acasa A = new Acasa();
            A.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
