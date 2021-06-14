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
    public partial class FrmLog : Form
    {
        CCliente cCliente = new CCliente();
        public FrmLog()
        {
            InitializeComponent();
        }
        void log()
        {
            if (cCliente.log(txtNombre.Text, txtApellido.Text, Convert.ToInt32(txtCodigo.Text)) == 1)
            {
                MessageBox.Show("Bienvenid@ a (banco) "+txtNombre.Text);
                FrmInformacionDeDeuda frm = new FrmInformacionDeDeuda();
                this.Close();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Los datos ingresados no coinsiden con ninguna cuenta verifica los datos");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            log();
        }
    }
}
