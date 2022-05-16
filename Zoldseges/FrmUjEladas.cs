using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zoldseges
{
    public partial class FrmUjEladas : Form
    {
        public static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Zoldseges_Gyak;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public FrmUjEladas()
        {
            InitializeComponent();
        }

        private void FrmUjEladas_Load(object sender, EventArgs e)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();

                var reader = new SqlCommand("SELECT Nev FROM Zoldseg;", conn).ExecuteReader();

                while (reader.Read())
                    cbTermekek.Items.Add(reader[0]);

            }
        }

        private void cbTermekek_SelectedIndexChanged(object sender, EventArgs e)
        {
            var termek = cbTermekek.Text;

            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();

                var reader = new SqlCommand($"SELECT EgysegAr FROM Zoldseg WHERE Nev = '{termek}';", conn).ExecuteReader();
                reader.Read();

                tbTermekAr.Text = reader[0].ToString();
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            var termek = cbTermekek.Text;
            var termekId = 0;
            var datum = DateTime.Today.ToString("yyyy-MM-dd");
            var mennyiseg = nudMennyiseg.Value;

            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();

                var reader = new SqlCommand($"SELECT Id FROM Zoldseg WHERE Nev = '{termek}';", conn).ExecuteReader();
                reader.Read();
                termekId = reader.GetInt32(0);

                reader.Close();

                var adapter = new SqlDataAdapter()
                {
                    InsertCommand = new SqlCommand($"INSERT INTO Eladas VALUES ('{datum}',{termekId},{mennyiseg});", conn),
                };

                adapter.InsertCommand.ExecuteNonQuery();
            }
            MessageBox.Show("A rekord sikeresen rögzítve!");
        }

        private void btnKilep_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nudMennyiseg_ValueChanged(object sender, EventArgs e)
        {
            tbFizetendo.Text = (int.Parse(tbTermekAr.Text) * nudMennyiseg.Value).ToString();
        }
    }
}
