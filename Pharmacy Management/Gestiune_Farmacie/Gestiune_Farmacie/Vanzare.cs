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
using System.Windows.Forms.DataVisualization.Charting;

namespace Gestiune_Farmacie
{
    public partial class Vanzare : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=\\HOME\home\ds220\Documents\Farmaciedb.mdf;Integrated Security=True;Connect Timeout=30");
        public Vanzare()
        {
            InitializeComponent();
        }

        void populate()
        {
            Con.Open();
            string query = "select * from Vanzare";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            VanzareGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void Vanzare_Load(object sender, EventArgs e)
        {
         //   fillChart();
        }

        private void VanzareGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IdVanzareTb.Text = VanzareGV.SelectedRows[0].Cells[0].Value.ToString();
            IdMedicamentVanTb.Text = VanzareGV.SelectedRows[0].Cells[1].Value.ToString();
            CodcVTb.Text = VanzareGV.SelectedRows[0].Cells[2].Value.ToString();
            LunaVTb.Text=VanzareGV.SelectedRows[0].Cells[3].Value.ToString();
            TotalVTb.Text= VanzareGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            IdVanzareTb.Text = "";
            IdMedicamentVanTb.Text = "";
            CodcVTb.Text = "";
            LunaVTb.Text = "";
            TotalVTb.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                if (IdVanzareTb.Text == "" || IdMedicamentVanTb.Text == "" || CodcVTb.Text == "" || LunaVTb.Text == "" || TotalVTb.Text == "")
                    MessageBox.Show("Nu se accepta randuri goale");
                else
                {
                    Con.Open();
                    string query = "insert into Vanzare values(" + IdVanzareTb.Text + "," + IdMedicamentVanTb.Text + "," + CodcVTb.Text + ", '" +LunaVTb.Text +"', " + TotalVTb.Text + " )";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Vanzarea a fost efectuata cu succes");
                    Con.Close();
                    populate();
                }


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "update Vanzare set IdVanzare = " + IdVanzareTb.Text + ",IdMedicament = " + IdMedicamentVanTb.Text + ",Codc = " + CodcVTb.Text + ", Luna = '" + LunaVTb.Text + "', Total = " + TotalVTb.Text + " where IdVanzare = " + IdVanzareTb.Text + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Vanzarea a fost modificata cu succes");
            Con.Close();
            populate();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (IdVanzareTb.Text == "")
                MessageBox.Show("Introduceti id-ul vanzarii");
            else
            {
                Con.Open();
                string query = "delete from Vanzare where IdVanzare=" + IdVanzareTb.Text + "";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Vanzarea a fost stearsa cu succes");
                Con.Close();
                populate();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Acasa A = new Acasa();
            A.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }


        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click_2(object sender, EventArgs e)
        {
            Grafic g = new Grafic();
            g.Show();
            this.Hide();
        }
    }
}
