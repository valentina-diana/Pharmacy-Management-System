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
    public partial class Grafic : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=\\HOME\home\ds220\Documents\Farmaciedb.mdf;Integrated Security=True;Connect Timeout=30");
        public Grafic()
        {
            InitializeComponent();
        }

        private void Grafic_Load(object sender, EventArgs e)
        {
            //fillChart();
        }

        private void fillChart()
        {
            SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=\\HOME\home\ds220\Documents\Farmaciedb.mdf;Integrated Security=True;Connect Timeout=30");
            DataSet ds = new DataSet();
            Con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select Luna, Total from Vanzare", Con);
            adapter.Fill(ds);
            chart1.DataSource = ds;
            chart1.Series["Vanzare"].XValueMember = "Luna";
            chart1.Series["Vanzare"].YValueMembers = "Total";
            chart1.Titles.Add("Vanzari");
            Con.Close();


        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            fillChart();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Vanzare v = new Vanzare();
            v.Show();
            this.Hide();
            
        }
    }

}
