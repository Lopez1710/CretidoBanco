
namespace Creditos.Vista
{
    partial class FrmInformacionDeDeuda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInformacionDeDeuda));
            System.Windows.Forms.Label apellidoLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label dUILabel;
            System.Windows.Forms.Label numero_De_CuentaLabel;
            System.Windows.Forms.Label codigo_De_SeguridadLabel;
            System.Windows.Forms.Label deudaLabel;
            System.Windows.Forms.Label cuotaLabel;
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPago = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.txtRegresar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.apellidoLabel1 = new System.Windows.Forms.Label();
            this.nombreLabel1 = new System.Windows.Forms.Label();
            this.dUILabel1 = new System.Windows.Forms.Label();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numero_De_CuentaTextBox = new System.Windows.Forms.TextBox();
            this.codigo_De_SeguridadTextBox = new System.Windows.Forms.TextBox();
            this.deudaTextBox = new System.Windows.Forms.TextBox();
            this.cuotaTextBox = new System.Windows.Forms.TextBox();
            apellidoLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            dUILabel = new System.Windows.Forms.Label();
            numero_De_CuentaLabel = new System.Windows.Forms.Label();
            codigo_De_SeguridadLabel = new System.Windows.Forms.Label();
            deudaLabel = new System.Windows.Forms.Label();
            cuotaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 262);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnPago
            // 
            this.btnPago.Location = new System.Drawing.Point(418, 366);
            this.btnPago.Name = "btnPago";
            this.btnPago.Size = new System.Drawing.Size(112, 23);
            this.btnPago.TabIndex = 14;
            this.btnPago.Text = "Realizar Un pago";
            this.btnPago.UseVisualStyleBackColor = true;
            this.btnPago.Click += new System.EventHandler(this.btnPago_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(278, 366);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(100, 23);
            this.btnCrear.TabIndex = 15;
            this.btnCrear.Text = "Crear Solicitud";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // txtRegresar
            // 
            this.txtRegresar.Location = new System.Drawing.Point(418, 415);
            this.txtRegresar.Name = "txtRegresar";
            this.txtRegresar.Size = new System.Drawing.Size(124, 23);
            this.txtRegresar.TabIndex = 16;
            this.txtRegresar.Text = "Regresar";
            this.txtRegresar.UseVisualStyleBackColor = true;
            this.txtRegresar.Click += new System.EventHandler(this.txtRegresar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(565, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Informacion pago";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.Location = new System.Drawing.Point(148, 342);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new System.Drawing.Size(47, 13);
            apellidoLabel.TabIndex = 18;
            apellidoLabel.Text = "Apellido:";
            // 
            // apellidoLabel1
            // 
            this.apellidoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Apellido", true));
            this.apellidoLabel1.Location = new System.Drawing.Point(201, 342);
            this.apellidoLabel1.Name = "apellidoLabel1";
            this.apellidoLabel1.Size = new System.Drawing.Size(78, 23);
            this.apellidoLabel1.TabIndex = 19;
            this.apellidoLabel1.Text = "label1";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(23, 342);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 19;
            nombreLabel.Text = "Nombre:";
            // 
            // nombreLabel1
            // 
            this.nombreLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Nombre", true));
            this.nombreLabel1.Location = new System.Drawing.Point(76, 342);
            this.nombreLabel1.Name = "nombreLabel1";
            this.nombreLabel1.Size = new System.Drawing.Size(73, 23);
            this.nombreLabel1.TabIndex = 20;
            this.nombreLabel1.Text = "label1";
            // 
            // dUILabel
            // 
            dUILabel.AutoSize = true;
            dUILabel.Location = new System.Drawing.Point(76, 396);
            dUILabel.Name = "dUILabel";
            dUILabel.Size = new System.Drawing.Size(29, 13);
            dUILabel.TabIndex = 20;
            dUILabel.Text = "DUI:";
            // 
            // dUILabel1
            // 
            this.dUILabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "DUI", true));
            this.dUILabel1.Location = new System.Drawing.Point(111, 396);
            this.dUILabel1.Name = "dUILabel1";
            this.dUILabel1.Size = new System.Drawing.Size(100, 23);
            this.dUILabel1.TabIndex = 21;
            this.dUILabel1.Text = "label1";
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(Creditos.Entidades.Cliente);
            // 
            // numero_De_CuentaLabel
            // 
            numero_De_CuentaLabel.AutoSize = true;
            numero_De_CuentaLabel.Location = new System.Drawing.Point(364, 59);
            numero_De_CuentaLabel.Name = "numero_De_CuentaLabel";
            numero_De_CuentaLabel.Size = new System.Drawing.Size(101, 13);
            numero_De_CuentaLabel.TabIndex = 21;
            numero_De_CuentaLabel.Text = "Numero De Cuenta:";
            // 
            // numero_De_CuentaTextBox
            // 
            this.numero_De_CuentaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Numero_De_Cuenta", true));
            this.numero_De_CuentaTextBox.Enabled = false;
            this.numero_De_CuentaTextBox.Location = new System.Drawing.Point(471, 56);
            this.numero_De_CuentaTextBox.Name = "numero_De_CuentaTextBox";
            this.numero_De_CuentaTextBox.Size = new System.Drawing.Size(149, 20);
            this.numero_De_CuentaTextBox.TabIndex = 22;
            this.numero_De_CuentaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // codigo_De_SeguridadLabel
            // 
            codigo_De_SeguridadLabel.AutoSize = true;
            codigo_De_SeguridadLabel.Location = new System.Drawing.Point(354, 134);
            codigo_De_SeguridadLabel.Name = "codigo_De_SeguridadLabel";
            codigo_De_SeguridadLabel.Size = new System.Drawing.Size(111, 13);
            codigo_De_SeguridadLabel.TabIndex = 22;
            codigo_De_SeguridadLabel.Text = "Codigo De Seguridad:";
            // 
            // codigo_De_SeguridadTextBox
            // 
            this.codigo_De_SeguridadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Codigo_De_Seguridad", true));
            this.codigo_De_SeguridadTextBox.Enabled = false;
            this.codigo_De_SeguridadTextBox.Location = new System.Drawing.Point(471, 131);
            this.codigo_De_SeguridadTextBox.Name = "codigo_De_SeguridadTextBox";
            this.codigo_De_SeguridadTextBox.Size = new System.Drawing.Size(149, 20);
            this.codigo_De_SeguridadTextBox.TabIndex = 23;
            this.codigo_De_SeguridadTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // deudaLabel
            // 
            deudaLabel.AutoSize = true;
            deudaLabel.Location = new System.Drawing.Point(423, 204);
            deudaLabel.Name = "deudaLabel";
            deudaLabel.Size = new System.Drawing.Size(42, 13);
            deudaLabel.TabIndex = 23;
            deudaLabel.Text = "Deuda:";
            // 
            // deudaTextBox
            // 
            this.deudaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Deuda", true));
            this.deudaTextBox.Enabled = false;
            this.deudaTextBox.Location = new System.Drawing.Point(471, 201);
            this.deudaTextBox.Name = "deudaTextBox";
            this.deudaTextBox.Size = new System.Drawing.Size(149, 20);
            this.deudaTextBox.TabIndex = 24;
            this.deudaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cuotaLabel
            // 
            cuotaLabel.AutoSize = true;
            cuotaLabel.Location = new System.Drawing.Point(427, 275);
            cuotaLabel.Name = "cuotaLabel";
            cuotaLabel.Size = new System.Drawing.Size(38, 13);
            cuotaLabel.TabIndex = 24;
            cuotaLabel.Text = "Cuota:";
            // 
            // cuotaTextBox
            // 
            this.cuotaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Cuota", true));
            this.cuotaTextBox.Enabled = false;
            this.cuotaTextBox.Location = new System.Drawing.Point(471, 272);
            this.cuotaTextBox.Name = "cuotaTextBox";
            this.cuotaTextBox.Size = new System.Drawing.Size(149, 20);
            this.cuotaTextBox.TabIndex = 25;
            this.cuotaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmInformacionDeDeuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 458);
            this.Controls.Add(cuotaLabel);
            this.Controls.Add(this.cuotaTextBox);
            this.Controls.Add(deudaLabel);
            this.Controls.Add(this.deudaTextBox);
            this.Controls.Add(codigo_De_SeguridadLabel);
            this.Controls.Add(this.codigo_De_SeguridadTextBox);
            this.Controls.Add(numero_De_CuentaLabel);
            this.Controls.Add(this.numero_De_CuentaTextBox);
            this.Controls.Add(dUILabel);
            this.Controls.Add(this.dUILabel1);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreLabel1);
            this.Controls.Add(apellidoLabel);
            this.Controls.Add(this.apellidoLabel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtRegresar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.btnPago);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmInformacionDeDeuda";
            this.Text = "FrmInformacionDeDeuda";
            this.Load += new System.EventHandler(this.FrmInformacionDeDeuda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPago;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button txtRegresar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.Label apellidoLabel1;
        private System.Windows.Forms.Label nombreLabel1;
        private System.Windows.Forms.Label dUILabel1;
        private System.Windows.Forms.TextBox numero_De_CuentaTextBox;
        private System.Windows.Forms.TextBox codigo_De_SeguridadTextBox;
        private System.Windows.Forms.TextBox deudaTextBox;
        private System.Windows.Forms.TextBox cuotaTextBox;
    }
}