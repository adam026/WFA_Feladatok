using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TojasGyar.Properties;

namespace TojasGyar
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnKilepes_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            pbKep.Image = Resources.nyul;
        }

        private void btnTermeles_Click(object sender, EventArgs e)
        {
            var frm = new FrmTermeles();
            frm.ShowDialog();
        }

        private void btnStatisztika_Click(object sender, EventArgs e)
        {
            var frm = new frmStatisztika();
            frm.ShowDialog();
        }
    }
}
