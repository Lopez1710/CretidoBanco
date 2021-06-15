
namespace Creditos.Vista
{
    partial class FrmSolicitud
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNCuenta = new System.Windows.Forms.TextBox();
            this.cmbPlasos = new System.Windows.Forms.ComboBox();
            this.cmbCantidad = new System.Windows.Forms.ComboBox();
            this.btnCrearSolicitud = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigoSeguridad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGarantia = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNCuenta
            // 
            this.txtNCuenta.Enabled = false;
            this.txtNCuenta.Location = new System.Drawing.Point(43, 32);
            this.txtNCuenta.Name = "txtNCuenta";
            this.txtNCuenta.Size = new System.Drawing.Size(209, 20);
            this.txtNCuenta.TabIndex = 1;
            this.txtNCuenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNCuenta_KeyPress);
            // 
            // cmbPlasos
            // 
            this.cmbPlasos.FormattingEnabled = true;
            this.cmbPlasos.Location = new System.Drawing.Point(43, 219);
            this.cmbPlasos.Name = "cmbPlasos";
            this.cmbPlasos.Size = new System.Drawing.Size(209, 21);
            this.cmbPlasos.TabIndex = 4;
            this.cmbPlasos.Tag = "";
            this.cmbPlasos.Text = "Plasos";
            this.cmbPlasos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbPlasos_KeyPress);
            // 
            // cmbCantidad
            // 
            this.cmbCantidad.FormattingEnabled = true;
            this.cmbCantidad.Location = new System.Drawing.Point(43, 280);
            this.cmbCantidad.Name = "cmbCantidad";
            this.cmbCantidad.Size = new System.Drawing.Size(209, 21);
            this.cmbCantidad.TabIndex = 5;
            this.cmbCantidad.Text = "Cantidad";
            this.cmbCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbCantidad_KeyPress);
            // 
            // btnCrearSolicitud
            // 
            this.btnCrearSolicitud.Location = new System.Drawing.Point(97, 340);
            this.btnCrearSolicitud.Name = "btnCrearSolicitud";
            this.btnCrearSolicitud.Size = new System.Drawing.Size(117, 23);
            this.btnCrearSolicitud.TabIndex = 6;
            this.btnCrearSolicitud.Text = "Enviar Solicitud ";
            this.btnCrearSolicitud.UseVisualStyleBackColor = true;
            this.btnCrearSolicitud.Click += new System.EventHandler(this.btnCrearSolicitud_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Numero de Cuenta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Codigo de seguridad";
            // 
            // txtCodigoSeguridad
            // 
            this.txtCodigoSeguridad.Location = new System.Drawing.Point(43, 96);
            this.txtCodigoSeguridad.Name = "txtCodigoSeguridad";
            this.txtCodigoSeguridad.Size = new System.Drawing.Size(209, 20);
            this.txtCodigoSeguridad.TabIndex = 2;
            this.txtCodigoSeguridad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoSeguridad_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Garantia";
            // 
            // txtGarantia
            // 
            this.txtGarantia.Location = new System.Drawing.Point(43, 162);
            this.txtGarantia.Name = "txtGarantia";
            this.txtGarantia.Size = new System.Drawing.Size(209, 20);
            this.txtGarantia.TabIndex = 3;
            this.txtGarantia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGarantia_KeyPress);
            // 
            // FrmSolicitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 393);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtGarantia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCodigoSeguridad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCrearSolicitud);
            this.Controls.Add(this.cmbCantidad);
            this.Controls.Add(this.cmbPlasos);
            this.Controls.Add(this.txtNCuenta);
            this.Name = "FrmSolicitud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solicitud ";
            this.Load += new System.EventHandler(this.FrmSolicitud_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbPlasos;
        private System.Windows.Forms.ComboBox cmbCantidad;
        private System.Windows.Forms.Button btnCrearSolicitud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigoSeguridad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGarantia;
        public System.Windows.Forms.TextBox txtNCuenta;
    }
}