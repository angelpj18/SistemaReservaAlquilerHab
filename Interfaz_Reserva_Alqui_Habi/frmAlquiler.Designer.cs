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
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lstAlquileres = new System.Windows.Forms.ListBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.cboTipoAlquiler = new System.Windows.Forms.ComboBox();
            this.lblTipoReserva = new System.Windows.Forms.Label();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.lblFechaAlquiDesde = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(421, 287);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 61;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(504, 263);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 60;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(342, 263);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 59;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(180, 206);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 58;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(99, 228);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 57;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(18, 206);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 56;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lstAlquileres
            // 
            this.lstAlquileres.FormattingEnabled = true;
            this.lstAlquileres.Location = new System.Drawing.Point(342, 39);
            this.lstAlquileres.Name = "lstAlquileres";
            this.lstAlquileres.Size = new System.Drawing.Size(237, 212);
            this.lstAlquileres.TabIndex = 55;
            this.lstAlquileres.Click += new System.EventHandler(this.lstAlquileres_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(27, 53);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(77, 13);
            this.lblCodigo.TabIndex = 64;
            this.lblCodigo.Text = "Codigo Alquiler";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(131, 46);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(112, 20);
            this.txtCodigo.TabIndex = 65;
            // 
            // cboTipoAlquiler
            // 
            this.cboTipoAlquiler.FormattingEnabled = true;
            this.cboTipoAlquiler.Location = new System.Drawing.Point(131, 81);
            this.cboTipoAlquiler.Name = "cboTipoAlquiler";
            this.cboTipoAlquiler.Size = new System.Drawing.Size(112, 21);
            this.cboTipoAlquiler.TabIndex = 67;
            // 
            // lblTipoReserva
            // 
            this.lblTipoReserva.AutoSize = true;
            this.lblTipoReserva.Location = new System.Drawing.Point(27, 89);
            this.lblTipoReserva.Name = "lblTipoReserva";
            this.lblTipoReserva.Size = new System.Drawing.Size(65, 13);
            this.lblTipoReserva.TabIndex = 66;
            this.lblTipoReserva.Text = "Tipo Alquiler";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(131, 158);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(112, 20);
            this.dtpFechaHasta.TabIndex = 73;
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Location = new System.Drawing.Point(15, 164);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(105, 13);
            this.lblFechaHasta.TabIndex = 72;
            this.lblFechaHasta.Text = "Fecha Alquiler Hasta";
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(131, 120);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(112, 20);
            this.dtpFechaDesde.TabIndex = 71;
            // 
            // lblFechaAlquiDesde
            // 
            this.lblFechaAlquiDesde.AutoSize = true;
            this.lblFechaAlquiDesde.Location = new System.Drawing.Point(15, 126);
            this.lblFechaAlquiDesde.Name = "lblFechaAlquiDesde";
            this.lblFechaAlquiDesde.Size = new System.Drawing.Size(108, 13);
            this.lblFechaAlquiDesde.TabIndex = 70;
            this.lblFechaAlquiDesde.Text = "Fecha Alquiler Desde";
            // 
            // frmAlquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(650, 355);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.lblFechaHasta);
            this.Controls.Add(this.dtpFechaDesde);
            this.Controls.Add(this.lblFechaAlquiDesde);
            this.Controls.Add(this.cboTipoAlquiler);
            this.Controls.Add(this.lblTipoReserva);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lstAlquileres);
            this.Name = "frmAlquiler";
            this.Text = "frmAlquiler";
            this.Load += new System.EventHandler(this.frmAlquiler_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox lstAlquileres;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.ComboBox cboTipoAlquiler;
        private System.Windows.Forms.Label lblTipoReserva;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Label lblFechaAlquiDesde;
    }
}

