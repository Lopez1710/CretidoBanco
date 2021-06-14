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
    public partial class FrmInfoCredito : Form
    {   CPagoCredito cPagoCredito = new CPagoCredito();
        public FrmInfoCredito()
        {
            InitializeComponent();
        }

        void cargardatos()
        {
            pagoCreditoBindingSource.DataSource = cPagoCredito.datos(NumeroDeCuenta.Cuenta);  
        }

        private void FrmInfoCredito_Load(object sender, EventArgs e)
        {
            cargardatos();
        }
    }
}
