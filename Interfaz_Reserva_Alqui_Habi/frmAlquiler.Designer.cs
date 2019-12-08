namespace Interfaz_Reserva_Alqui_Habi
{
    partial class frmAlquiler
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.cboTipoAlquiler = new System.Windows.Forms.ComboBox();
            this.lblTipoReserva = new System.Windows.Forms.Label();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.lblFechaAlquiDesde = new System.Windows.Forms.Label();
            this.dtgDetalleReserva = new System.Windows.Forms.DataGridView();
            this.lblHabitacion = new System.Windows.Forms.Label();
            this.cmbHabitacion = new System.Windows.Forms.ComboBox();
            this.lblPrecio1 = new System.Windows.Forms.Label();
            this.txtPrecioCat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrecioTipo = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalleReserva)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(12, 23);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(77, 13);
            this.lblCodigo.TabIndex = 64;
            this.lblCodigo.Text = "Codigo Alquiler";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(111, 20);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(112, 20);
            this.txtCodigo.TabIndex = 65;
            // 
            // cboTipoAlquiler
            // 
            this.cboTipoAlquiler.FormattingEnabled = true;
            this.cboTipoAlquiler.Location = new System.Drawing.Point(111, 66);
            this.cboTipoAlquiler.Name = "cboTipoAlquiler";
            this.cboTipoAlquiler.Size = new System.Drawing.Size(112, 21);
            this.cboTipoAlquiler.TabIndex = 67;
            // 
            // lblTipoReserva
            // 
            this.lblTipoReserva.AutoSize = true;
            this.lblTipoReserva.Location = new System.Drawing.Point(12, 69);
            this.lblTipoReserva.Name = "lblTipoReserva";
            this.lblTipoReserva.Size = new System.Drawing.Size(65, 13);
            this.lblTipoReserva.TabIndex = 66;
            this.lblTipoReserva.Text = "Tipo Alquiler";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(126, 149);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(112, 20);
            this.dtpFechaHasta.TabIndex = 73;
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Location = new System.Drawing.Point(12, 155);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(105, 13);
            this.lblFechaHasta.TabIndex = 72;
            this.lblFechaHasta.Text = "Fecha Alquiler Hasta";
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(126, 106);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(112, 20);
            this.dtpFechaDesde.TabIndex = 71;
            // 
            // lblFechaAlquiDesde
            // 
            this.lblFechaAlquiDesde.AutoSize = true;
            this.lblFechaAlquiDesde.Location = new System.Drawing.Point(12, 112);
            this.lblFechaAlquiDesde.Name = "lblFechaAlquiDesde";
            this.lblFechaAlquiDesde.Size = new System.Drawing.Size(108, 13);
            this.lblFechaAlquiDesde.TabIndex = 70;
            this.lblFechaAlquiDesde.Text = "Fecha Alquiler Desde";
            // 
            // dtgDetalleReserva
            // 
            this.dtgDetalleReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDetalleReserva.Location = new System.Drawing.Point(276, 145);
            this.dtgDetalleReserva.Name = "dtgDetalleReserva";
            this.dtgDetalleReserva.Size = new System.Drawing.Size(452, 198);
            this.dtgDetalleReserva.TabIndex = 76;
            // 
            // lblHabitacion
            // 
            this.lblHabitacion.AutoSize = true;
            this.lblHabitacion.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHabitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHabitacion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHabitacion.Location = new System.Drawing.Point(303, 24);
            this.lblHabitacion.Name = "lblHabitacion";
            this.lblHabitacion.Size = new System.Drawing.Size(83, 16);
            this.lblHabitacion.TabIndex = 81;
            this.lblHabitacion.Text = "Habitacion";
            // 
            // cmbHabitacion
            // 
            this.cmbHabitacion.FormattingEnabled = true;
            this.cmbHabitacion.Location = new System.Drawing.Point(392, 23);
            this.cmbHabitacion.Name = "cmbHabitacion";
            this.cmbHabitacion.Size = new System.Drawing.Size(121, 21);
            this.cmbHabitacion.TabIndex = 80;
            // 
            // lblPrecio1
            // 
            this.lblPrecio1.AutoSize = true;
            this.lblPrecio1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPrecio1.Location = new System.Drawing.Point(303, 67);
            this.lblPrecio1.Name = "lblPrecio1";
            this.lblPrecio1.Size = new System.Drawing.Size(125, 16);
            this.lblPrecio1.TabIndex = 83;
            this.lblPrecio1.Text = "Precio Categoria";
            // 
            // txtPrecioCat
            // 
            this.txtPrecioCat.Location = new System.Drawing.Point(443, 62);
            this.txtPrecioCat.Name = "txtPrecioCat";
            this.txtPrecioCat.Size = new System.Drawing.Size(126, 20);
            this.txtPrecioCat.TabIndex = 82;
            this.txtPrecioCat.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(303, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 16);
            this.label1.TabIndex = 85;
            this.label1.Text = "Precio Tipo de Hab.";
            // 
            // txtPrecioTipo
            // 
            this.txtPrecioTipo.Location = new System.Drawing.Point(468, 102);
            this.txtPrecioTipo.Name = "txtPrecioTipo";
            this.txtPrecioTipo.Size = new System.Drawing.Size(126, 20);
            this.txtPrecioTipo.TabIndex = 84;
            this.txtPrecioTipo.Text = " ";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(79, 295);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(86, 27);
            this.btnGuardar.TabIndex = 87;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(80, 230);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(85, 28);
            this.btnAgregar.TabIndex = 86;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // frmAlquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(743, 355);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrecioTipo);
            this.Controls.Add(this.lblPrecio1);
            this.Controls.Add(this.txtPrecioCat);
            this.Controls.Add(this.lblHabitacion);
            this.Controls.Add(this.cmbHabitacion);
            this.Controls.Add(this.dtgDetalleReserva);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.lblFechaHasta);
            this.Controls.Add(this.dtpFechaDesde);
            this.Controls.Add(this.lblFechaAlquiDesde);
            this.Controls.Add(this.cboTipoAlquiler);
            this.Controls.Add(this.lblTipoReserva);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Name = "frmAlquiler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAlquiler";
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalleReserva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.ComboBox cboTipoAlquiler;
        private System.Windows.Forms.Label lblTipoReserva;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Label lblFechaAlquiDesde;
        private System.Windows.Forms.DataGridView dtgDetalleReserva;
        private System.Windows.Forms.Label lblHabitacion;
        private System.Windows.Forms.ComboBox cmbHabitacion;
        private System.Windows.Forms.Label lblPrecio1;
        private System.Windows.Forms.TextBox txtPrecioCat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrecioTipo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnAgregar;
    }
}

