using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Creditos.Vista
{
    public partial class FrmInicial : Form
    {
        public FrmInicial()
        {
            InitializeComponent();
        }

        private void cuuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLog frm = new FrmLog();
            frm.Show();
        }

        private void reguistroDeClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProcesamientoSolicitud frm = new FrmProcesamientoSolicitud();
            frm.Show();
        }
    }
}
