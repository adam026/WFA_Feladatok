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
    public partial class FrmUjTermek : Form
    {
        public static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Zoldseges_Gyak;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public FrmUjTermek()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            var nev = tbNev.Text;
            var egysegar = tbEgysegar.Text;
            var success = false;

            try
            {
                string errorMessage = "";

                if (String.IsNullOrWhiteSpace(nev)) errorMessage += "A név mező nem lehet üres!\n";
                if (String.IsNullOrWhiteSpace(egysegar)) errorMessage += "Az egységár mező nem lehet üres!\n";
                if (!int.TryParse(tbEgysegar.Text, out _)) errorMessage += "Az egyégár mezőbe csak szám értékek kerülhetnek!\n";

                if (!String.IsNullOrEmpty(errorMessage))
                {
                    throw new Exception(errorMessage);
                }

                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    var adapter = new SqlDataAdapter()
                    {
                        InsertCommand = new SqlCommand("INSERT INTO Zoldseg VALUES " +
                        $"('{nev}', {egysegar});", conn),
                    };

                    adapter.InsertCommand.ExecuteNonQuery();
                    success = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if(success)
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    var reader = new SqlCommand($"SELECT Id, Nev, EgysegAr FROM Zoldseg WHERE Nev LIKE '{nev}%';", conn).ExecuteReader();

                    reader.Read();
                    tbId.Text = reader[0].ToString();
                    tbNev.Text = reader[1].ToString();
                    tbEgysegar.Text = reader[2].ToString();
                }
            }


        }
    }
}
