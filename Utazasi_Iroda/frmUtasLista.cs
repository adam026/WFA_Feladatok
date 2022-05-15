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

namespace Utazasi_Iroda
{
    public partial class frmUtasLista : Form
    {
        public static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Utazasi_Iroda_GYAK;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        static string UtasNeve = "%";
        static string UtvonalCelja = "%";
        public frmUtasLista()
        {
            InitializeComponent();
        }

        private void frmUtasLista_Load(object sender, EventArgs e) => UpdateDGV();


        private void UpdateDGV()
        {
            dgvLista.Rows.Clear();

            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();

                var reader = new SqlCommand("SELECT T_KOD, Utas.NEV, Utas.CIM, Utvonal.UT_KOD, KEZDET, Utvonal.HOVA " +
                    "FROM Tura " +
                    "INNER JOIN Utas ON Utas.JELENTKEZIK = T_KOD " +
                    "INNER JOIN Utvonal ON Utvonal.UT_KOD = UTVONAL " +
                    $"WHERE Utas.NEV LIKE '{UtasNeve}' AND Utvonal.HOVA LIKE '{UtvonalCelja}';", conn).ExecuteReader();

                while (reader.Read())
                {
                    dgvLista.Rows.Add(
                        reader[0],
                        reader[1],
                        reader[2],
                        reader[3],
                        reader.GetDateTime(4).ToString("yyyy.MM.dd"),
                        reader[5]);
                }

            }
        }

        private void tbUtasNeve_TextChanged(object sender, EventArgs e)
        {
            UtasNeve = tbUtasNeve.Text + "%";
            UpdateDGV();
        }

        private void tbUtvonal_TextChanged(object sender, EventArgs e)
        {
            UtvonalCelja = tbUtvonal.Text + "%";
            UpdateDGV();
        }
    }
}
