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
    public partial class FrmSolicitud : Form
    {
        public FrmSolicitud()
        {
            InitializeComponent();
        }
        int resuldado()
        {
            CCliente cCliente = new CCliente();
            int resutado = cCliente.Comprobacion(Convert.ToInt32(txtNCuenta.Text),Convert.ToInt32(txtCodigoSeguridad.Text));
            return resutado;
        }
        void crearsolicitud()
        {
            if (resuldado() != 0)
            {
                int cantidad = Convert.ToInt32(cmbCantidad.SelectedItem);
                int plasos = Convert.ToInt32(cmbPlasos.SelectedItem);
                int Cuenta = Convert.ToInt32(txtNCuenta.Text);
                string Garantia = txtGarantia.Text;
                CSolicitud cSolicitud = new CSolicitud();
                cSolicitud.CrearSolicitud(cantidad,plasos,Cuenta,Garantia);
                MessageBox.Show("Solicitud enviada con exito, espera la respuesta");
            }
            else
            {
                MessageBox.Show("El codigo y la cuenta no concuerdan intentar nuevamente");
            }
        }
        void Meses()
        {
            cmbPlasos.Items.Add("1");
            cmbPlasos.Items.Add("2");
            cmbPlasos.Items.Add("3");
            cmbPlasos.Items.Add("4");
            cmbPlasos.Items.Add("5");
            cmbPlasos.Items.Add("6");
            cmbPlasos.Items.Add("7");
            cmbPlasos.Items.Add("8");
            cmbPlasos.Items.Add("9");
            cmbPlasos.Items.Add("10");
            cmbPlasos.Items.Add("11");
            cmbPlasos.Items.Add("12");
            
        }
        void Cantidad()
        {
            cmbCantidad.Items.Add("1000");
            cmbCantidad.Items.Add("2000");
            cmbCantidad.Items.Add("3000");
            cmbCantidad.Items.Add("4000");
            cmbCantidad.Items.Add("5000");
        }
        private void FrmSolicitud_Load(object sender, EventArgs e)
        {
            Meses();
            Cantidad();
        }

        private void btnCrearSolicitud_Click(object sender, EventArgs e)
        {
            crearsolicitud();
        }

        private void txtNCuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                txtCodigoSeguridad.Focus();
            }
        }

        private void txtCodigoSeguridad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                txtGarantia.Focus();
            }
        }

        private void txtGarantia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                cmbPlasos.Focus();
            }
        }

        private void cmbPlasos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                cmbCantidad.Focus();
            }
        }

        private void cmbCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                btnCrearSolicitud.Focus();
            }
        }
    }
}
