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
    public partial class Medicamente : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=\\HOME\home\ds220\Documents\Farmaciedb.mdf;Integrated Security=True;Connect Timeout=30");
        public Medicamente()
        {
            InitializeComponent();
        }

        void populate()
        {
            Con.Open();
            string query = "select * from Medicament";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            MedicamenteGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IdMedicamentTb.Text = "";
            DenumireTb.Text = "";
            PretTb.Text = "";
            StocTb.Text = "";
            ProducatorTb.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (IdMedicamentTb.Text == "" || DenumireTb.Text == "" || PretTb.Text == "" || StocTb.Text == "" || ProducatorTb.Text == "")
                MessageBox.Show("Nu se accepta randuri goale. Completati toate randurile");
            else
            {
                Con.Open();
                string query = "insert into Medicament values(" + IdMedicamentTb.Text + ",'" + DenumireTb.Text + "'," + PretTb.Text + "," + StocTb.Text + ",'" + ProducatorTb.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Medicamentul a fost adaugat cu succes");
                Con.Close();
                populate();
            }
        }

        private void MedicamenteGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IdMedicament.Text = MedicamenteGV.SelectedRows[0].Cells[0].Value.ToString();
            Denumire.Text = MedicamenteGV.SelectedRows[0].Cells[1].Value.ToString();
            Pret.Text = MedicamenteGV.SelectedRows[0].Cells[2].Value.ToString();
            Stoc.Text = MedicamenteGV.SelectedRows[0].Cells[3].Value.ToString();
            Producator.Text = MedicamenteGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "update Medicament set IdMedicament = " + IdMedicamentTb.Text + ",Denumire = '" + DenumireTb.Text + "'," +
                           "Pret = '" + PretTb.Text + "',Stoc= '" + StocTb.Text + "', Producator= '" + ProducatorTb.Text + "' where IdMedicament = " + IdMedicamentTb.Text + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Medicamentul a fost modificat cu succes");
            Con.Close();
            populate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (IdMedicamentTb.Text == "")
                MessageBox.Show("Introduceti Id.ul Medicamentului");
            else
            {
                Con.Open();
                string query = "delete from Medicament where IdMedicament=" + IdMedicamentTb.Text + "";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Medicamentul a fost sters cu succes");
                Con.Close();
                populate();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(label6.Text, new Font("Comic Sans MS", 25, FontStyle.Bold), Brushes.Black, new Point(250));
            //  e.Graphics.DrawString(IdMedicamentLb.Text + "\n" + label4.Text + "\n" + label3.Text + "\n" + label5.Text, new Font("Comic Sans MS", 12, FontStyle.Regular), Brushes.Black, new Point(130, 150));
            // e.Graphics.DrawString(label6.Text + "\n\t" + label7.Text, new Font("Comic Sans MS", 20, FontStyle.Regular), Brushes.Red, new Point(230, 380));

            e.Graphics.DrawString(label6.Text, new Font("Comic Sans MS", 25, FontStyle.Regular), Brushes.Green, new Point(180, 50));
            e.Graphics.DrawString(IdMedicamentTb.Text + "\n" + DenumireTb.Text + "\n" + PretTb.Text + "\n" + StocTb.Text + "\n" + ProducatorTb.Text, new Font("Comic Sans MS", 17, FontStyle.Regular),
                                                    Brushes.Black, new Point(100, 170));

            e.Graphics.DrawString(label2.Text, new Font("Comic Sans MS", 25, FontStyle.Regular), Brushes.Black, new Point(100, 90));
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
