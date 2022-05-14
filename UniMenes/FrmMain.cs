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

namespace UniMenes
{
    public partial class FrmMain : Form
    {
        public static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=UniMenes_Gyak;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
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

                var r = new SqlCommand("SELECT Unikornis.Id, Fajta.Nev, Tenyeszto.Nev, Varos, Suly, Nem " +
                    "FROM Unikornis " +
                    "INNER JOIN Fajta ON Fajta.Id = FajtaId " +
                    "INNER JOIN Tenyeszto ON Tenyeszto.Id = TulajdonosId;", conn)
                    .ExecuteReader();

                while (r.Read())
                {
                    dgvMain.Rows.Add(
                        r[0],
                        r[1],
                        r[2],
                        r[3],
                        r[4] + " kg",
                        r.GetBoolean(5) ? "Csődör" : "Kanca"
                        );
                }
            }
        }

        private void tsmBejelentesek_Click(object sender, EventArgs e)
        {
            var frm = new FrmAdatlap(connectionString);
            frm.ShowDialog();
            UpdateDGV();
        }

        private void dgvMain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string f = dgvMain[1, e.RowIndex].Value + "";
            string v = dgvMain[3, e.RowIndex].Value + "";
            string s = dgvMain[4, e.RowIndex].Value + "";
            int n = dgvMain[5, e.RowIndex].Value + "" == "kanca" ? 0 : 1;

            var frm = new FrmParkereso(connectionString,f,v,s,n);
            frm.ShowDialog();
        }
    }
}
