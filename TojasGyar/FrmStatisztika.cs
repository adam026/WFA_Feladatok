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
    public partial class frmStatisztika : Form
    {
        public static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TojasGyar_Gyak;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public frmStatisztika()
        {
            InitializeComponent();
        }

        private void frmStatisztika_Load(object sender, EventArgs e)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();

                var reader = new SqlCommand("SELECT Nev FROM Nyul;", conn).ExecuteReader();

                while (reader.Read())
                {
                    cbMunkas.Items.Add(reader[0]);
                }

                cbMunkas.SelectedIndex = 0;
            }
            UpdateDGV();
        }

        private void UpdateDGV()
        {
            dgvStatisztika.Rows.Clear();

            var kivalasztottNyul = cbMunkas.SelectedIndex + 1;
            var kivalasztottHonap = nudHonap.Value;

            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();

                try
                {
                    var reader = new SqlCommand("SELECT Datum, Tojas.Szin, Mennyiseg " +
                    "FROM Termeles " +
                    "INNER JOIN Nyul ON NyulId = Nyul.Id " +
                    "INNER JOIN Tojas ON TipusId = Tojas.Id " +
                    $"WHERE NyulId = {kivalasztottNyul} " +
                    $"AND MONTH(Datum) = {kivalasztottHonap}", conn).ExecuteReader();

                    while (reader.Read())
                    {
                        dgvStatisztika.Rows.Add(reader.GetDateTime(0).ToString("yyyy-MM-dd"), reader[1], reader[2] + " db");
                    }

                    dgvStatisztika.Sort(Datum, ListSortDirection.Ascending);

                    reader.Close();

                    if (dgvStatisztika.Rows.Count != 0)
                    {
                        var reader1 = new SqlCommand("SELECT TOP 1 Szin, SUM(Mennyiseg) " +
                        "FROM Nyul " +
                        "INNER JOIN Termeles ON Nyul.Id = NyulId " +
                        "INNER JOIN Tojas ON TipusId = Tojas.Id " +
                        $"WHERE NyulId = {kivalasztottNyul} " +
                        $"AND MONTH(Datum) = {kivalasztottHonap} " +
                        $"GROUP BY Szin " +
                        $"ORDER BY SUM(Mennyiseg) DESC;", conn).ExecuteReader();

                        while (reader1.Read())
                            tbMaxTojas.Text = $"{reader1[0]} ({reader1[1]} db)";

                        reader1.Close();

                        var reader2 = new SqlCommand(
                        "SELECT SUM(Suly * Mennyiseg) " +
                        "FROM Nyul " +
                        "INNER JOIN Termeles ON Nyul.Id = NyulId " +
                        "INNER JOIN Tojas ON TipusId = Tojas.Id " +
                        $"WHERE NyulId = {kivalasztottNyul} " +
                        $"AND MONTH(Datum) = {kivalasztottHonap};", conn).ExecuteReader();
                        while (reader2.Read())
                            tbMaxSuly.Text = $"{reader2.GetInt32(0) / 1000F} Kg";

                        reader2.Close();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Az adott hónapban a kiválasztott munkás nem készített tojást. Kérlek válassz másik hónapot, vagy másik munkást!");
                    nudHonap.Value = 3;
                    UpdateDGV();
                }
            }
        }

        private void cbMunkas_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDGV();
        }

        private void nudHonap_ValueChanged(object sender, EventArgs e)
        {              
            UpdateDGV();
        }
    }
}
