namespace Interfaz_Reserva_Alqui_Habi
{
    partial class frmReserva
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
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtTipoReserva = new System.Windows.Forms.TextBox();
            this.lblTipoReserva = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSuc = new System.Windows.Forms.TextBox();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.blFechaInicio = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblFechaReserva = new System.Windows.Forms.Label();
            this.dtpFechaReserva = new System.Windows.Forms.DateTimePicker();
            this.nudReserva = new System.Windows.Forms.NumericUpDown();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.dtgDetalleReserva = new System.Windows.Forms.DataGridView();
            this.lblHabitacion = new System.Windows.Forms.Label();
            this.cmbHabitacion = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCantPersonas = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblCantHabi = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudReserva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalleReserva)).BeginInit();
            this.SuspendLayout();
            // 
            // cboCliente
            // 
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(358, 31);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(108, 21);
            this.cboCliente.TabIndex = 74;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(310, 39);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(42, 13);
            this.lblCliente.TabIndex = 73;
            this.lblCliente.Text = "Cliente:";
            // 
            // txtTipoReserva
            // 
            this.txtTipoReserva.Location = new System.Drawing.Point(162, 141);
            this.txtTipoReserva.Name = "txtTipoReserva";
            this.txtTipoReserva.Size = new System.Drawing.Size(106, 20);
            this.txtTipoReserva.TabIndex = 72;
            // 
            // lblTipoReserva
            // 
            this.lblTipoReserva.AutoSize = true;
            this.lblTipoReserva.Location = new System.Drawing.Point(43, 141);
            this.lblTipoReserva.Name = "lblTipoReserva";
            this.lblTipoReserva.Size = new System.Drawing.Size(74, 13);
            this.lblTipoReserva.TabIndex = 71;
            this.lblTipoReserva.Text = "Tipo Reserva:";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(162, 109);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(106, 20);
            this.txtEstado.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 69;
            this.label1.Text = "Estado:";
            // 
            // txtSuc
            // 
            this.txtSuc.Location = new System.Drawing.Point(358, 71);
            this.txtSuc.Name = "txtSuc";
            this.txtSuc.Size = new System.Drawing.Size(108, 20);
            this.txtSuc.TabIndex = 68;
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Location = new System.Drawing.Point(43, 259);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(69, 13);
            this.lblFechaFin.TabIndex = 67;
            this.lblFechaFin.Text = "Fecha de Fin";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(156, 252);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(108, 20);
            this.dtpFechaFin.TabIndex = 66;
            // 
            // blFechaInicio
            // 
            this.blFechaInicio.AutoSize = true;
            this.blFechaInicio.Location = new System.Drawing.Point(43, 227);
            this.blFechaInicio.Name = "blFechaInicio";
            this.blFechaInicio.Size = new System.Drawing.Size(80, 13);
            this.blFechaInicio.TabIndex = 65;
            this.blFechaInicio.Text = "Fecha de Inicio";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(156, 221);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(108, 20);
            this.dtpFechaInicio.TabIndex = 64;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(310, 78);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(48, 13);
            this.lblCategoria.TabIndex = 63;
            this.lblCategoria.Text = "Sucursal";
            // 
            // lblFechaReserva
            // 
            this.lblFechaReserva.AutoSize = true;
            this.lblFechaReserva.Location = new System.Drawing.Point(43, 199);
            this.lblFechaReserva.Name = "lblFechaReserva";
            this.lblFechaReserva.Size = new System.Drawing.Size(95, 13);
            this.lblFechaReserva.TabIndex = 62;
            this.lblFechaReserva.Text = "Fecha de Reserva";
            // 
            // dtpFechaReserva
            // 
            this.dtpFechaReserva.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaReserva.Location = new System.Drawing.Point(155, 192);
            this.dtpFechaReserva.Name = "dtpFechaReserva";
            this.dtpFechaReserva.Size = new System.Drawing.Size(108, 20);
            this.dtpFechaReserva.TabIndex = 61;
            // 
            // nudReserva
            // 
            this.nudReserva.DecimalPlaces = 2;
            this.nudReserva.Location = new System.Drawing.Point(164, 37);
            this.nudReserva.Name = "nudReserva";
            this.nudReserva.Size = new System.Drawing.Size(100, 20);
            this.nudReserva.TabIndex = 60;
            // 
            // txtDetalle
            // 
            this.txtDetalle.Location = new System.Drawing.Point(164, 75);
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(106, 20);
            this.txtDetalle.TabIndex = 59;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(651, 29);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 58;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(112, 327);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(85, 28);
            this.btnAgregar.TabIndex = 53;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Location = new System.Drawing.Point(43, 78);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(66, 13);
            this.lblDetalle.TabIndex = 51;
            this.lblDetalle.Text = "Descripcion:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(43, 44);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(83, 13);
            this.lblCodigo.TabIndex = 50;
            this.lblCodigo.Text = "Codigo Reserva";
            // 
            // dtgDetalleReserva
            // 
            this.dtgDetalleReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDetalleReserva.Location = new System.Drawing.Point(313, 221);
            this.dtgDetalleReserva.Name = "dtgDetalleReserva";
            this.dtgDetalleReserva.Size = new System.Drawing.Size(451, 198);
            this.dtgDetalleReserva.TabIndex = 75;
            // 
            // lblHabitacion
            // 
            this.lblHabitacion.AutoSize = true;
            this.lblHabitacion.Location = new System.Drawing.Point(310, 159);
            this.lblHabitacion.Name = "lblHabitacion";
            this.lblHabitacion.Size = new System.Drawing.Size(58, 13);
            this.lblHabitacion.TabIndex = 79;
            this.lblHabitacion.Text = "Habitacion";
            // 
            // cmbHabitacion
            // 
            this.cmbHabitacion.FormattingEnabled = true;
            this.cmbHabitacion.Location = new System.Drawing.Point(374, 156);
            this.cmbHabitacion.Name = "cmbHabitacion";
            this.cmbHabitacion.Size = new System.Drawing.Size(121, 21);
            this.cmbHabitacion.TabIndex = 76;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(541, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 78;
            this.label3.Text = "Cantidad Personas";
            // 
            // txtCantPersonas
            // 
            this.txtCantPersonas.Location = new System.Drawing.Point(643, 156);
            this.txtCantPersonas.Name = "txtCantPersonas";
            this.txtCantPersonas.Size = new System.Drawing.Size(83, 20);
            this.txtCantPersonas.TabIndex = 77;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(550, 192);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 81;
            this.lblPrecio.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(643, 189);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(82, 20);
            this.txtPrecio.TabIndex = 80;
            this.txtPrecio.Text = " ";
            // 
            // lblCantHabi
            // 
            this.lblCantHabi.AutoSize = true;
            this.lblCantHabi.Location = new System.Drawing.Point(310, 192);
            this.lblCantHabi.Name = "lblCantHabi";
            this.lblCantHabi.Size = new System.Drawing.Size(129, 13);
            this.lblCantHabi.TabIndex = 83;
            this.lblCantHabi.Text = "Cantidad de Habitaciones";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(445, 189);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(50, 20);
            this.txtCantidad.TabIndex = 82;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(111, 392);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(86, 27);
            this.btnGuardar.TabIndex = 84;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 445);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblCantHabi);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblHabitacion);
            this.Controls.Add(this.cmbHabitacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCantPersonas);
            this.Controls.Add(this.dtgDetalleReserva);
            this.Controls.Add(this.cboCliente);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.txtTipoReserva);
            this.Controls.Add(this.lblTipoReserva);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSuc);
            this.Controls.Add(this.lblFechaFin);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.blFechaInicio);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblFechaReserva);
            this.Controls.Add(this.dtpFechaReserva);
            this.Controls.Add(this.nudReserva);
            this.Controls.Add(this.txtDetalle);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblDetalle);
            this.Controls.Add(this.lblCodigo);
            this.Name = "frmReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RESERVA";
            this.Load += new System.EventHandler(this.frmReserva_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.nudReserva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalleReserva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtTipoReserva;
        private System.Windows.Forms.Label lblTipoReserva;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSuc;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label blFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblFechaReserva;
        private System.Windows.Forms.DateTimePicker dtpFechaReserva;
        private System.Windows.Forms.NumericUpDown nudReserva;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.DataGridView dtgDetalleReserva;
        private System.Windows.Forms.Label lblHabitacion;
        private System.Windows.Forms.ComboBox cmbHabitacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCantPersonas;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblCantHabi;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnGuardar;
    }
}