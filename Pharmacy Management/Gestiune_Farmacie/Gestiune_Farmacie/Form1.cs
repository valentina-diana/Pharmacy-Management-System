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
    public partial class Form1 : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=\\HOME\home\ds220\Documents\Farmaciedb.mdf;Integrated Security=True;Connect Timeout=30");
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Con;
            cmd.CommandText = "select * from Autentificare where Email = '" + textBox1.Text + "' and Parola = '" + textBox2.Text + "' ";
            cmd.ExecuteNonQuery();

            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            int count = 0;
            while (sqlDataReader.Read())
            {
                count = count + 1;
            }
            if (count == 1)
            {
                Acasa A = new Acasa();
                A.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nume sau parola incorecte");
            }

            Con.Close();

            /* Acasa A = new Acasa();
             A.Show();
             this.Hide();  */
        }

        private void label4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
