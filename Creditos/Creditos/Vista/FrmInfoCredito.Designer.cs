
namespace Creditos.Vista
{
    partial class FrmInfoCredito
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.pagoCreditoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pagoCreditoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pagoCreditoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagoCreditoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Informacion de pagos";
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(12, 21);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 2;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            // 
            // pagoCreditoBindingSource
            // 
            this.pagoCreditoBindingSource.DataSource = typeof(Creditos.Entidades.PagoCredito);
            // 
            // pagoCreditoDataGridView
            // 
            this.pagoCreditoDataGridView.AllowUserToAddRows = false;
            this.pagoCreditoDataGridView.AllowUserToDeleteRows = false;
            this.pagoCreditoDataGridView.AutoGenerateColumns = false;
            this.pagoCreditoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.pagoCreditoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pagoCreditoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.pagoCreditoDataGridView.DataSource = this.pagoCreditoBindingSource;
            this.pagoCreditoDataGridView.Location = new System.Drawing.Point(12, 92);
            this.pagoCreditoDataGridView.Name = "pagoCreditoDataGridView";
            this.pagoCreditoDataGridView.ReadOnly = true;
            this.pagoCreditoDataGridView.Size = new System.Drawing.Size(526, 288);
            this.pagoCreditoDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Pago";
            this.dataGridViewTextBoxColumn2.HeaderText = "Pago";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Fecha";
            this.dataGridViewTextBoxColumn3.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Numero_De_Cuenta_Fk";
            this.dataGridViewTextBoxColumn4.HeaderText = "Numero_De_Cuenta_Fk";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // FrmInfoCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 400);
            this.Controls.Add(this.pagoCreditoDataGridView);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.label1);
            this.Name = "FrmInfoCredito";
            this.Text = "FrmInfoCredito";
            this.Load += new System.EventHandler(this.FrmInfoCredito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pagoCreditoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagoCreditoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.BindingSource pagoCreditoBindingSource;
        private System.Windows.Forms.DataGridView pagoCreditoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}