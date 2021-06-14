
namespace Creditos.Vista
{
    partial class FrmEstadoSolicitud
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label numero_De_Cuenta_FKLabel1;
            System.Windows.Forms.Label cantidadPLabel;
            System.Windows.Forms.Label id_EstadoLabel;
            System.Windows.Forms.Label plasosLabel;
            System.Windows.Forms.Label interesLabel;
            System.Windows.Forms.Label tipo_De_GarantiaLabel;
            this.numero_De_Cuenta_FKLabel2 = new System.Windows.Forms.Label();
            this.cantidadPLabel1 = new System.Windows.Forms.Label();
            this.id_EstadoLabel1 = new System.Windows.Forms.Label();
            this.plasosLabel1 = new System.Windows.Forms.Label();
            this.interesLabel1 = new System.Windows.Forms.Label();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnRechazar = new System.Windows.Forms.Button();
            this.tipo_De_GarantiaLabel1 = new System.Windows.Forms.Label();
            this.solicitudBindingSource = new System.Windows.Forms.BindingSource(this.components);
            numero_De_Cuenta_FKLabel1 = new System.Windows.Forms.Label();
            cantidadPLabel = new System.Windows.Forms.Label();
            id_EstadoLabel = new System.Windows.Forms.Label();
            plasosLabel = new System.Windows.Forms.Label();
            interesLabel = new System.Windows.Forms.Label();
            tipo_De_GarantiaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.solicitudBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // numero_De_Cuenta_FKLabel1
            // 
            numero_De_Cuenta_FKLabel1.AutoSize = true;
            numero_De_Cuenta_FKLabel1.Location = new System.Drawing.Point(44, 38);
            numero_De_Cuenta_FKLabel1.Name = "numero_De_Cuenta_FKLabel1";
            numero_De_Cuenta_FKLabel1.Size = new System.Drawing.Size(117, 13);
            numero_De_Cuenta_FKLabel1.TabIndex = 2;
            numero_De_Cuenta_FKLabel1.Text = "Numero De Cuenta FK:";
            // 
            // numero_De_Cuenta_FKLabel2
            // 
            this.numero_De_Cuenta_FKLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.solicitudBindingSource, "Numero_De_Cuenta_FK", true));
            this.numero_De_Cuenta_FKLabel2.Location = new System.Drawing.Point(167, 38);
            this.numero_De_Cuenta_FKLabel2.Name = "numero_De_Cuenta_FKLabel2";
            this.numero_De_Cuenta_FKLabel2.Size = new System.Drawing.Size(147, 23);
            this.numero_De_Cuenta_FKLabel2.TabIndex = 3;
            this.numero_De_Cuenta_FKLabel2.Text = "label1";
            // 
            // cantidadPLabel
            // 
            cantidadPLabel.AutoSize = true;
            cantidadPLabel.Location = new System.Drawing.Point(99, 94);
            cantidadPLabel.Name = "cantidadPLabel";
            cantidadPLabel.Size = new System.Drawing.Size(62, 13);
            cantidadPLabel.TabIndex = 3;
            cantidadPLabel.Text = "Cantidad P:";
            // 
            // cantidadPLabel1
            // 
            this.cantidadPLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.solicitudBindingSource, "CantidadP", true));
            this.cantidadPLabel1.Location = new System.Drawing.Point(167, 94);
            this.cantidadPLabel1.Name = "cantidadPLabel1";
            this.cantidadPLabel1.Size = new System.Drawing.Size(100, 23);
            this.cantidadPLabel1.TabIndex = 4;
            this.cantidadPLabel1.Text = "label1";
            // 
            // id_EstadoLabel
            // 
            id_EstadoLabel.AutoSize = true;
            id_EstadoLabel.Location = new System.Drawing.Point(106, 295);
            id_EstadoLabel.Name = "id_EstadoLabel";
            id_EstadoLabel.Size = new System.Drawing.Size(55, 13);
            id_EstadoLabel.TabIndex = 4;
            id_EstadoLabel.Text = "Id Estado:";
            // 
            // id_EstadoLabel1
            // 
            this.id_EstadoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.solicitudBindingSource, "Id_Estado", true));
            this.id_EstadoLabel1.Location = new System.Drawing.Point(167, 295);
            this.id_EstadoLabel1.Name = "id_EstadoLabel1";
            this.id_EstadoLabel1.Size = new System.Drawing.Size(100, 23);
            this.id_EstadoLabel1.TabIndex = 5;
            this.id_EstadoLabel1.Text = "label1";
            // 
            // plasosLabel
            // 
            plasosLabel.AutoSize = true;
            plasosLabel.Location = new System.Drawing.Point(120, 148);
            plasosLabel.Name = "plasosLabel";
            plasosLabel.Size = new System.Drawing.Size(41, 13);
            plasosLabel.TabIndex = 6;
            plasosLabel.Text = "Plasos:";
            // 
            // plasosLabel1
            // 
            this.plasosLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.solicitudBindingSource, "Plasos", true));
            this.plasosLabel1.Location = new System.Drawing.Point(167, 148);
            this.plasosLabel1.Name = "plasosLabel1";
            this.plasosLabel1.Size = new System.Drawing.Size(100, 23);
            this.plasosLabel1.TabIndex = 7;
            this.plasosLabel1.Text = "label1";
            // 
            // interesLabel
            // 
            interesLabel.AutoSize = true;
            interesLabel.Location = new System.Drawing.Point(119, 205);
            interesLabel.Name = "interesLabel";
            interesLabel.Size = new System.Drawing.Size(42, 13);
            interesLabel.TabIndex = 8;
            interesLabel.Text = "Interes:";
            // 
            // interesLabel1
            // 
            this.interesLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.solicitudBindingSource, "Interes", true));
            this.interesLabel1.Location = new System.Drawing.Point(167, 205);
            this.interesLabel1.Name = "interesLabel1";
            this.interesLabel1.Size = new System.Drawing.Size(100, 23);
            this.interesLabel1.TabIndex = 9;
            this.interesLabel1.Text = "label1";
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(122, 402);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(75, 23);
            this.BtnAceptar.TabIndex = 12;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // BtnRechazar
            // 
            this.BtnRechazar.Location = new System.Drawing.Point(273, 402);
            this.BtnRechazar.Name = "BtnRechazar";
            this.BtnRechazar.Size = new System.Drawing.Size(75, 23);
            this.BtnRechazar.TabIndex = 13;
            this.BtnRechazar.Text = "Rechazar";
            this.BtnRechazar.UseVisualStyleBackColor = true;
            this.BtnRechazar.Click += new System.EventHandler(this.BtnRechazar_Click);
            // 
            // tipo_De_GarantiaLabel
            // 
            tipo_De_GarantiaLabel.AutoSize = true;
            tipo_De_GarantiaLabel.Location = new System.Drawing.Point(70, 252);
            tipo_De_GarantiaLabel.Name = "tipo_De_GarantiaLabel";
            tipo_De_GarantiaLabel.Size = new System.Drawing.Size(91, 13);
            tipo_De_GarantiaLabel.TabIndex = 10;
            tipo_De_GarantiaLabel.Text = "Tipo De Garantia:";
            // 
            // tipo_De_GarantiaLabel1
            // 
            this.tipo_De_GarantiaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.solicitudBindingSource, "Tipo_De_Garantia", true));
            this.tipo_De_GarantiaLabel1.Location = new System.Drawing.Point(167, 252);
            this.tipo_De_GarantiaLabel1.Name = "tipo_De_GarantiaLabel1";
            this.tipo_De_GarantiaLabel1.Size = new System.Drawing.Size(105, 23);
            this.tipo_De_GarantiaLabel1.TabIndex = 11;
            this.tipo_De_GarantiaLabel1.Text = "label1";
            // 
            // solicitudBindingSource
            // 
            this.solicitudBindingSource.DataSource = typeof(Creditos.Entidades.Solicitud);
            // 
            // FrmEstadoSolicitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 463);
            this.Controls.Add(this.BtnRechazar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(tipo_De_GarantiaLabel);
            this.Controls.Add(this.tipo_De_GarantiaLabel1);
            this.Controls.Add(interesLabel);
            this.Controls.Add(this.interesLabel1);
            this.Controls.Add(plasosLabel);
            this.Controls.Add(this.plasosLabel1);
            this.Controls.Add(id_EstadoLabel);
            this.Controls.Add(this.id_EstadoLabel1);
            this.Controls.Add(cantidadPLabel);
            this.Controls.Add(this.cantidadPLabel1);
            this.Controls.Add(numero_De_Cuenta_FKLabel1);
            this.Controls.Add(this.numero_De_Cuenta_FKLabel2);
            this.Name = "FrmEstadoSolicitud";
            this.Text = "FrmEstadoSolicitud";
            this.Load += new System.EventHandler(this.FrmEstadoSolicitud_Load);
            ((System.ComponentModel.ISupportInitialize)(this.solicitudBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource solicitudBindingSource;
        private System.Windows.Forms.Label numero_De_Cuenta_FKLabel2;
        private System.Windows.Forms.Label cantidadPLabel1;
        private System.Windows.Forms.Label id_EstadoLabel1;
        private System.Windows.Forms.Label plasosLabel1;
        private System.Windows.Forms.Label interesLabel1;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button BtnRechazar;
        private System.Windows.Forms.Label tipo_De_GarantiaLabel1;
    }
}