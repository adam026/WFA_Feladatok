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
    public partial class FrmMain : Form
    {
        
        public static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Zoldseges_Gyak;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public static string kivalasztottTermek = "%";
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e) => UpdateDGV();

        private void UpdateDGV()
        {
            dgvMain.Rows.Clear();

            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();

                var reader = new SqlCommand("SELECT Datum, Zoldseg.Nev, Mennyiseg * Zoldseg.EgysegAr " +
                    "FROM Eladas " +
                    "INNER JOIN Zoldseg ON Zoldseg = Zoldseg.Id " +
                    $"WHERE Zoldseg.Nev LIKE '{kivalasztottTermek}';", conn).ExecuteReader();

                while (reader.Read())
                {
                    dgvMain.Rows.Add(reader.GetDateTime(0).ToString("yyyy-MM-dd"), reader[1], reader[2]);
                }
            }
        }

        private void tbTermek_TextChanged(object sender, EventArgs e)
        {
            kivalasztottTermek = tbTermek.Text + "%";
            UpdateDGV();
        }

        private void btnUjTermek_Click(object sender, EventArgs e)
        {
            var frm = new FrmUjTermek();
            frm.ShowDialog();
            UpdateDGV();
        }

        private void btnUjEladas_Click(object sender, EventArgs e)
        {
            var frm = new FrmUjEladas();
            frm.ShowDialog();
            UpdateDGV();
        }
    }
}
