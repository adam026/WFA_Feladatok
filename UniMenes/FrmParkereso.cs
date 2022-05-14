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
    public partial class FrmParkereso : Form
    {
        string connString;
        string FajtaNeve;
        string Varos;
        string Suly;
        int Nem;
        public FrmParkereso(string connectionString, string f, string v, string s, int n)
        {
            connString = connectionString;
            FajtaNeve = f;
            Varos = v;
            Suly = s;
            Nem = n;

            InitializeComponent();
        }

        private void FrmParkereso_Load(object sender, EventArgs e)
        {
            BackColor = Nem == 1 ? Color.LightBlue : Color.LightPink;
            tbVaros.Text = Varos;
            tbFajta.Text = FajtaNeve;
            tbSuly.Text = Suly;

            using (var conn = new SqlConnection(connString))
            {
                conn.Open();

                var reader = new SqlCommand("SELECT Unikornis.Id, Fajta.Nev, Tenyeszto.Nev, Suly " +
                    "FROM Unikornis " +
                    "INNER JOIN Fajta ON Fajta.Id = FajtaId " +
                    "INNER JOIN Tenyeszto ON Tenyeszto.Id = TulajdonosId " +
                    $"WHERE Varos LIKE '{Varos}' " +
                    $"AND Nem != {Nem};", conn).ExecuteReader();

                while (reader.Read())
                {
                    dgvPar.Rows.Add(reader[0], reader[1], reader[2], reader[3] + " Kg");
                }


            }
        }
    }
}
