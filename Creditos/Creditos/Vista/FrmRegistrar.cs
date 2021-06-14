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

namespace Creditos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            CCliente cCliente = new CCliente();
            cCliente.Insertar(txtNombre.Text,txtApellido.Text,Convert.ToInt32(txtDUI.Text),txtDireccion.Text,Convert.ToInt32(txtCodigo.Text));
            MessageBox.Show("Se a registrado a "+txtNombre.Text+" con exito");
            this.Close();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                txtApellido.Focus();
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                txtDUI.Focus();
            }
        }

        private void txtDUI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                txtDireccion.Focus();
            }
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                txtCodigo.Focus();
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                BtnInsertar.Focus();
            }
        }
    }
}
