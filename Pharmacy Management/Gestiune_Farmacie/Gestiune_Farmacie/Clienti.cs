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
    public partial class Clienti : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=\\HOME\home\ds220\Documents\Farmaciedb.mdf;Integrated Security=True;Connect Timeout=30");
        public Clienti()
        {
            InitializeComponent();
        }

        void populate()
        {
            Con.Open();
            string query = "select * from Client";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            ClientiGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CodcTb.Text = "";
            NumeTb.Text = "";
            PrenumeTb.Text = "";
            VarstaTb.Text = "";
            SexCb.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CodcTb.Text == "" || NumeTb.Text == "" || PrenumeTb.Text == "" || VarstaTb.Text == "")
                MessageBox.Show("Nu se accepta randuri goale! Completeaza toate campurile!");
            else
            {
                Con.Open();
                string query = "insert into Client values(" + CodcTb.Text + ",'" + NumeTb.Text + "','" + PrenumeTb.Text + "'," + VarstaTb.Text + ",'" + SexCb.SelectedItem.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Medicamentul a fost adaugat cu succes");
                Con.Close();
                populate();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "update Client set Codc = " + CodcTb.Text + ",Nume = '" + NumeTb.Text + "',Prenume = '" + PrenumeTb.Text + "',Varsta= '" + VarstaTb.Text + "', Sex= '" + SexCb.SelectedItem.ToString() + "' where Codc = " + CodcTb.Text + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Clientii au fost modificati cu succes");
            Con.Close();
            populate();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (CodcTb.Text == "")
                MessageBox.Show("Introduceti cod-ul clientului");
            else
            {
                Con.Open();
                string query = "delete from Client where Codc=" + CodcTb.Text + "";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Clientul a fost sters cu succes");
                Con.Close();
                populate();
            }
        }

        private void ClientiGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Codc.Text = ClientiGV.SelectedRows[0].Cells[0].Value.ToString();
            Nume.Text = ClientiGV.SelectedRows[0].Cells[1].Value.ToString();
            Prenume.Text = ClientiGV.SelectedRows[0].Cells[2].Value.ToString();
            Varsta.Text = ClientiGV.SelectedRows[0].Cells[3].Value.ToString();
        }
        private void Clienti_Load(object sender, EventArgs e)
        {
            populate();
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
