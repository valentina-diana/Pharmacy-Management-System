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
    public partial class CautareClient : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=\\HOME\home\ds220\Documents\Farmaciedb.mdf;Integrated Security=True;Connect Timeout=30");
        public CautareClient()
        {
            InitializeComponent();
        }

        private void CautareClientGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           CautaClientTb.Text = CautareClientGV.SelectedRows[0].Cells[0].Value.ToString();

        }



        void populate()
        {
            Con.Open();
            string query = "select * from Client where Nume = '" + CautaClientTb.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            CautareClientGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Con.Open();
            if (CautaClientTb.Text != "")
            {
                string query = "select * from Client where Nume = '" + CautaClientTb.Text + "'";

                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Clientul a fost gasit cu succes");
                Con.Close();
                populate();

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Acasa A = new Acasa();
            A.Show();
            this.Hide();
        }
    }
}
