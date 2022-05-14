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

namespace TojasGyar
{
    public partial class FrmTermeles : Form
    {
        public static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TojasGyar_Gyak;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public FrmTermeles()
        {
            InitializeComponent();
        }

        private void FrmTermeles_Load(object sender, EventArgs e) => UpdateDGV();

        private void UpdateDGV()
        {
            dgvMain.Rows.Clear();

            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();

                var reader = new SqlCommand("SELECT Datum, Tojas.Szin, Mennyiseg, Nyul.Nev " +
                    "FROM Termeles " +
                    "INNER JOIN Nyul ON NyulId = Nyul.Id " +
                    "INNER JOIN Tojas ON TipusId = Tojas.Id;", conn).ExecuteReader();

                while (reader.Read())
                {
                    dgvMain.Rows.Add(reader.GetDateTime(0).ToString("yyyy-MM-dd"), reader[1], reader[2] + " db", reader[3]);
                }

                dgvMain.Sort(Datum, ListSortDirection.Ascending);

                reader.Close();

                var reader1 = new SqlCommand("SELECT Szin FROM Tojas;", conn).ExecuteReader();

                while (reader1.Read())
                    cbTojas.Items.Add(reader1[0]);

                reader1.Close();

                var reader2 = new SqlCommand("SELECT Nev FROM Nyul", conn).ExecuteReader();

                while (reader2.Read())
                    cbMunkas.Items.Add(reader2[0]);

                reader2.Close();
            }

            cbTojas.SelectedIndex = 0;
            cbMunkas.SelectedIndex = 0;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            var datum = dtpDatum.Value.ToString("yyyy-MM-dd");
            var szin = cbTojas.SelectedIndex + 1;
            var mennyiseg = nudMennyiseg.Value;
            var munkas = cbMunkas.SelectedIndex + 1;

            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();

                var writer = new SqlDataAdapter()
                {
                    InsertCommand = new SqlCommand("INSERT INTO Termeles VALUES " +
                    $"('{datum}', {szin}, {munkas}, {mennyiseg});", conn),
                };

                writer.InsertCommand.ExecuteNonQuery();
            }

            UpdateDGV();
        }
    }
}
