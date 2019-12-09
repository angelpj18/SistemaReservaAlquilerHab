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
            this.BarraTitulo = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalleReserva)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Century", 11.25F);
            this.lblCodigo.ForeColor = System.Drawing.Color.White;
            this.lblCodigo.Location = new System.Drawing.Point(50, 20);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(119, 18);
            this.lblCodigo.TabIndex = 64;
            this.lblCodigo.Text = "Codigo Alquiler";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(221, 22);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(130, 21);
            this.txtCodigo.TabIndex = 65;
            // 
            // cboTipoAlquiler
            // 
            this.cboTipoAlquiler.FormattingEnabled = true;
            this.cboTipoAlquiler.Location = new System.Drawing.Point(221, 75);
            this.cboTipoAlquiler.Name = "cboTipoAlquiler";
            this.cboTipoAlquiler.Size = new System.Drawing.Size(130, 23);
            this.cboTipoAlquiler.TabIndex = 67;
            // 
            // lblTipoReserva
            // 
            this.lblTipoReserva.AutoSize = true;
            this.lblTipoReserva.Font = new System.Drawing.Font("Century", 11.25F);
            this.lblTipoReserva.ForeColor = System.Drawing.Color.White;
            this.lblTipoReserva.Location = new System.Drawing.Point(50, 72);
            this.lblTipoReserva.Name = "lblTipoReserva";
            this.lblTipoReserva.Size = new System.Drawing.Size(102, 18);
            this.lblTipoReserva.TabIndex = 66;
            this.lblTipoReserva.Text = "Tipo Alquiler";
            this.lblTipoReserva.Click += new System.EventHandler(this.lblTipoReserva_Click);
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(221, 176);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(130, 21);
            this.dtpFechaHasta.TabIndex = 73;
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Font = new System.Drawing.Font("Century", 11.25F);
            this.lblFechaHasta.ForeColor = System.Drawing.Color.White;
            this.lblFechaHasta.Location = new System.Drawing.Point(38, 176);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(158, 18);
            this.lblFechaHasta.TabIndex = 72;
            this.lblFechaHasta.Text = "Fecha Alquiler Hasta";
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(221, 123);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(130, 21);
            this.dtpFechaDesde.TabIndex = 71;
            // 
            // lblFechaAlquiDesde
            // 
            this.lblFechaAlquiDesde.AutoSize = true;
            this.lblFechaAlquiDesde.Font = new System.Drawing.Font("Century", 11.25F);
            this.lblFechaAlquiDesde.ForeColor = System.Drawing.Color.White;
            this.lblFechaAlquiDesde.Location = new System.Drawing.Point(38, 126);
            this.lblFechaAlquiDesde.Name = "lblFechaAlquiDesde";
            this.lblFechaAlquiDesde.Size = new System.Drawing.Size(160, 18);
            this.lblFechaAlquiDesde.TabIndex = 70;
            this.lblFechaAlquiDesde.Text = "Fecha Alquiler Desde";
            // 
            // dtgDetalleReserva
            // 
            this.dtgDetalleReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDetalleReserva.Location = new System.Drawing.Point(414, 172);
            this.dtgDetalleReserva.Name = "dtgDetalleReserva";
            this.dtgDetalleReserva.Size = new System.Drawing.Size(527, 228);
            this.dtgDetalleReserva.TabIndex = 76;
            // 
            // lblHabitacion
            // 
            this.lblHabitacion.AutoSize = true;
            this.lblHabitacion.BackColor = System.Drawing.Color.Transparent;
            this.lblHabitacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblHabitacion.Font = new System.Drawing.Font("Century", 11.25F);
            this.lblHabitacion.ForeColor = System.Drawing.Color.White;
            this.lblHabitacion.Location = new System.Drawing.Point(507, 33);
            this.lblHabitacion.Name = "lblHabitacion";
            this.lblHabitacion.Size = new System.Drawing.Size(85, 18);
            this.lblHabitacion.TabIndex = 81;
            this.lblHabitacion.Text = "Habitacion";
            // 
            // cmbHabitacion
            // 
            this.cmbHabitacion.FormattingEnabled = true;
            this.cmbHabitacion.Location = new System.Drawing.Point(657, 33);
            this.cmbHabitacion.Name = "cmbHabitacion";
            this.cmbHabitacion.Size = new System.Drawing.Size(140, 23);
            this.cmbHabitacion.TabIndex = 80;
            // 
            // lblPrecio1
            // 
            this.lblPrecio1.AutoSize = true;
            this.lblPrecio1.Font = new System.Drawing.Font("Century", 11.25F);
            this.lblPrecio1.ForeColor = System.Drawing.Color.White;
            this.lblPrecio1.Location = new System.Drawing.Point(491, 78);
            this.lblPrecio1.Name = "lblPrecio1";
            this.lblPrecio1.Size = new System.Drawing.Size(126, 18);
            this.lblPrecio1.TabIndex = 83;
            this.lblPrecio1.Text = "Precio Categoria";
            // 
            // txtPrecioCat
            // 
            this.txtPrecioCat.Location = new System.Drawing.Point(657, 75);
            this.txtPrecioCat.Name = "txtPrecioCat";
            this.txtPrecioCat.Size = new System.Drawing.Size(146, 21);
            this.txtPrecioCat.TabIndex = 82;
            this.txtPrecioCat.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 11.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(485, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 18);
            this.label1.TabIndex = 85;
            this.label1.Text = "Precio Tipo de Hab.";
            // 
            // txtPrecioTipo
            // 
            this.txtPrecioTipo.Location = new System.Drawing.Point(657, 123);
            this.txtPrecioTipo.Name = "txtPrecioTipo";
            this.txtPrecioTipo.Size = new System.Drawing.Size(146, 21);
            this.txtPrecioTipo.TabIndex = 84;
            this.txtPrecioTipo.Text = " ";
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Image = global::Interfaz_Reserva_Alqui_Habi.Properties.Resources._8;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(130, 323);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(141, 58);
            this.btnGuardar.TabIndex = 87;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Image = global::Interfaz_Reserva_Alqui_Habi.Properties.Resources._5;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(131, 248);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(141, 58);
            this.btnAgregar.TabIndex = 86;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(117)))));
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Left;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(20, 425);
            this.BarraTitulo.TabIndex = 88;
            // 
            // frmAlquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(951, 425);
            this.Controls.Add(this.BarraTitulo);
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
            this.Font = new System.Drawing.Font("Century", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.Panel BarraTitulo;
    }
}

