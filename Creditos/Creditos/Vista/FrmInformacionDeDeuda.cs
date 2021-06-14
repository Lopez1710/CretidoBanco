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
    public partial class FrmInformacionDeDeuda : Form
    {
        CCliente cCliente = new CCliente();
        CPagoCredito cPago = new CPagoCredito();
        public FrmInformacionDeDeuda()
        {
            InitializeComponent();
        }
        void datos(int Cuenta)
        {

            clienteBindingSource.DataSource = cCliente.datos(Cuenta);
            if (deudaTextBox.Text == "" && cuotaTextBox.Text == "")
            {
                deudaTextBox.Text = "0.00";
                cuotaTextBox.Text = "0.00";
            }
           
        }

        private void FrmInformacionDeDeuda_Load(object sender, EventArgs e)
        {
            datos(NumeroDeCuenta.Cuenta);
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            FrmSolicitud frm = new FrmSolicitud();
            frm.txtNCuenta.Text = numero_De_CuentaTextBox.Text;
            frm.Show();
        }

        private void btnPago_Click(object sender, EventArgs e)
        {
            if (cuotaTextBox.Text == "0.00")
            {
                MessageBox.Show("Usten no cuenta con ninguna deuda");
            }
            else
            {
                cPago.Realizarpago(Convert.ToInt32(numero_De_CuentaTextBox.Text));
                MessageBox.Show("Pago realizado con exito");
                datos(NumeroDeCuenta.Cuenta);
            }
        }

        private void txtRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void comprobacion()
        {
            if (cPago.comprobacion(NumeroDeCuenta.Cuenta) != 0)
            {
                FrmInfoCredito frm = new FrmInfoCredito();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Usted no cuenta con registros de pago");
            }
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            comprobacion();
        }
    }
}
