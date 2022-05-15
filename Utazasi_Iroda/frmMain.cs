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

    public partial class frmMain : Form
    {
        public static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Utazasi_Iroda_GYAK;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public frmMain()
        {
            InitializeComponent();
        }

        private void szerkesztésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmUtas();
            frm.ShowDialog();
        }

        private void keresésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmUtasLista();
            frm.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblDatum.Text = DateTime.Today.ToString("yyyy.MM.dd");

            UpdateDGV();
        }

        private void UpdateDGV()
        {
            dgvMain.Rows.Clear();

            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();

                var reader = new SqlCommand("SELECT T_KOD, Utvonal.HOVA, KEZDET, VEGE, Idegenvezeto.NEV, szallas.NEV, AR " +
                    "FROM Tura " +
                    "INNER JOIN Utvonal ON Utvonal.UT_KOD = UTVONAL " +
                    "INNER JOIN Idegenvezeto ON Idegenvezeto.I_KOD = VEZETO " +
                    "INNER JOIN Szallas ON Szallas.SZ_KOD = SZALLAS " +
                    $"WHERE MONTH(KEZDET) >= '{DateTime.Today.Month}';", conn).ExecuteReader();

                while (reader.Read())
                {
                    dgvMain.Rows.Add(
                        reader[0], 
                        reader[1], 
                        reader.GetDateTime(2).ToString("yyyy.MM.dd"), 
                        reader.GetDateTime(3).ToString("yyyy.MM.dd"),
                        reader[4],
                        reader[5],
                        reader[6]);
                }

                reader.Close();
            }

        }
    }
}
