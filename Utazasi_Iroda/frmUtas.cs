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
using Utazasi_Iroda.Properties;

namespace Utazasi_Iroda
{
    public partial class frmUtas : Form
    {
        public static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Utazasi_Iroda_GYAK;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public frmUtas()
        {
            InitializeComponent();
        }

        private void frmUtas_Load(object sender, EventArgs e)
        {
            pbKereses.Image = Resources.keres;
            pbMentes.Image = Resources.ment;
            pbTorles.Image = Resources.delete;
            pbUres.Image = Resources.ures;

            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();

                var reader = new SqlCommand($"SELECT T_KOD FROM Tura WHERE MONTH(KEZDET) BETWEEN {DateTime.Today.Month} AND {DateTime.Today.Month + 1};", conn).ExecuteReader();
                while (reader.Read())
                    cbJelentkezes.Items.Add(reader[0]);

                reader.Close();

            }
        }

        private void pbKereses_Click(object sender, EventArgs e)
        {
            var frm = new frmUtasLista();
            frm.ShowDialog();
        }

        private void pbMentes_Click(object sender, EventArgs e)
        {

            var nev = tbNev.Text;
            var cim = rtbCim.Text;
            var jelentkezes = int.Parse(cbJelentkezes.SelectedItem.ToString());

            if (tbNev.Text == "" || rtbCim.Text == "")
            {
                MessageBox.Show("A név és cím mező kitöltése kötelező!");

            }
            else
            {
                
                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    var maxUtasKod = 0;
                    var reader = new SqlCommand("SELECT MAX(U_KOD) FROM Utas;", conn).ExecuteReader();

                    while (reader.Read())
                        maxUtasKod = reader.GetInt32(0);

                    reader.Close();

                    var adapter = new SqlDataAdapter()
                    {
                        InsertCommand = new SqlCommand($"INSERT INTO Utas VALUES ({maxUtasKod + 1},'{nev}', '{cim}', {jelentkezes});", conn),
                    };
                    adapter.InsertCommand.ExecuteNonQuery();

                }

                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    var reader1 = new SqlCommand("SELECT U_KOD, NEV, CIM, JELENTKEZIK " +
                        "FROM Utas " +
                        $"WHERE NEV LIKE '{nev}' AND CIM LIKE '{cim}';", conn).ExecuteReader();

                    while (reader1.Read())
                    {
                        tbUtasKod.Text = reader1[0].ToString();
                        tbNev.Text = reader1[1].ToString();
                        rtbCim.Text = reader1[2].ToString();
                        cbJelentkezes.Text = reader1[3].ToString();
                    }
                }
                pbTorles.Enabled = true;

            }  
        }

        private void pbTorles_Click(object sender, EventArgs e)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();

                var id = int.Parse(tbUtasKod.Text);

                DialogResult dialogResult = MessageBox.Show("Valóban törölni szeretnéd a kiválasztott rekordot az adatbázisból?", "Figyelem!", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    var command = new SqlCommand($"DELETE FROM Utas WHERE U_KOD={id};", conn).ExecuteNonQuery();
                    tbUtasKod.Text = "";
                    tbNev.Text = "";
                    rtbCim.Text = "";
                }
                else if (dialogResult == DialogResult.No)
                {
                    this.Refresh();
                }
            }

        }

        private void pbUres_Click(object sender, EventArgs e)
        {
            tbUtasKod.Text = "";
            tbNev.Text = "";
            rtbCim.Text = "";
        }
    }
}
