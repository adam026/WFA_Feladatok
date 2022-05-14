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
using UniMenes.Properties;

namespace UniMenes
{
    public partial class FrmAdatlap : Form
    {
        string connString;
        public FrmAdatlap(string connectionString)
        {
            connString = connectionString;
            InitializeComponent();
        }

        private void FrmAdatlap_Load(object sender, EventArgs e)
        {
            using (var conn = new SqlConnection(connString))
            {
                conn.Open();

                var reader = new SqlCommand("SELECT Nev FROM Fajta", conn).ExecuteReader();
                while (reader.Read())
                {
                    cbFajta.Items.Add(reader[0]);
                }

                reader.Close();

                var reader1 = new SqlCommand("SELECT Nev FROM Tenyeszto", conn).ExecuteReader();
                while (reader1.Read())
                {
                    cbTulajdonos.Items.Add(reader1[0]);
                }

                reader1.Close();
            }

            cbFajta.SelectedIndex = 0;
            cbTulajdonos.SelectedIndex = 0;
            
        }

        private void cbFajta_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cbFajta.Text)
            {
                case "dapper":
                    pbKep.Image = Resources.dapper;
                    return;
                case "hipster":
                    pbKep.Image = Resources.hipster;
                    return;
                case "ninja":
                    pbKep.Image = Resources.ninja;
                    return;
                case "nyan":
                    pbKep.Image = Resources.nyan;
                    return;
                case "robot":
                    pbKep.Image = Resources.robot;
                    return;
                case "zombie":
                    pbKep.Image = Resources.zombie;
                    return;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var conn = new SqlConnection(connString))
            {
                conn.Open();
                var adapter = new SqlDataAdapter()
                {
                    InsertCommand = new SqlCommand("INSERT INTO Unikornis VALUES " +
                    $"({cbTulajdonos.SelectedIndex + 1}, {cbFajta.SelectedIndex + 1}, {nudSuly.Value}, {(rbKanca.Checked ? 0 : 1)});", conn),
                };

                adapter.InsertCommand.ExecuteNonQuery();
            }

            this.Dispose();
        }
    }
}
