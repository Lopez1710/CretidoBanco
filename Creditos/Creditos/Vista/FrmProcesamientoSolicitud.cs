using Creditos.Controlador;
using Creditos.Entidades;
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
    public partial class FrmProcesamientoSolicitud : Form
    {
        CSolicitud cSolicitud = new CSolicitud();
        public FrmProcesamientoSolicitud()
        {
            InitializeComponent();
        }

        private void FrmProcesamientoSolicitud_Load(object sender, EventArgs e)
        {
            solicitudBindingSource.DataSource = cSolicitud.solisitudes();
        }

        private void BtnProcesar_Click(object sender, EventArgs e)
        {
            Solicitud solicitud = new Solicitud();
            solicitud = (Solicitud)solicitudBindingSource.Current;

            FrmEstadoSolicitud frm = new FrmEstadoSolicitud(solicitud.iDSolicitud);
            frm.Show();
        }
    }
}
