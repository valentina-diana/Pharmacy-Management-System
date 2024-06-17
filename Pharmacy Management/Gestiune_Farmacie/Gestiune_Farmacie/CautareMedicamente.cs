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
    public partial class CautareMedicamente : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=\\HOME\home\ds220\Documents\Farmaciedb.mdf;Integrated Security=True;Connect Timeout=30");
        public CautareMedicamente()
        {
            InitializeComponent();
        }

        void populate()
        {
            Con.Open();
            string query = "select * from Medicament where Denumire  = '" + CautaTb.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            CautareMedicamentGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            Con.Open();
            if (CautaTb.Text != "")
            {
                string query = "select * from Medicament where Denumire = '" + CautaTb.Text + "'";

                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                // MessageBox.Show("Medicamentul a fost gasit cu succes");
                Con.Close();
                populate();

            }
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

        private void CautareMedicamentGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CautaTb.Text = CautareMedicamentGV.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void CautareMedicamente_Load(object sender, EventArgs e)
        {
            populate();
        }
    }
}
