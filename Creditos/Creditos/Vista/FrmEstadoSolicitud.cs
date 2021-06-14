using Creditos.Controlador;
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
    public partial class FrmEstadoSolicitud : Form
    {
        int id;
        CSolicitud cSolicitud = new CSolicitud();
        public FrmEstadoSolicitud(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        void datos()
        {
            solicitudBindingSource.DataSource = cSolicitud.datosdesolicitud(id);
            if (id_EstadoLabel1.Text == "1")
            {
                id_EstadoLabel1.Text = "En Espera";
            }
            else if (id_EstadoLabel1.Text == "2")
            {
                id_EstadoLabel1.Text = "Aceptado";
            }
            else if (id_EstadoLabel1.Text == "3")
            {
                id_EstadoLabel1.Text = "Rechazado";
            }
        }
        private void FrmEstadoSolicitud_Load(object sender, EventArgs e)
        {
            datos();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            cSolicitud.cambiarestado(id,2);
            datos();
        }

        private void BtnRechazar_Click(object sender, EventArgs e)
        {
            cSolicitud.cambiarestado(id, 3);
            datos();
        }
    }
}
