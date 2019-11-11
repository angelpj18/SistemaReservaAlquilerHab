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
            this.lblEstadoReserva = new System.Windows.Forms.Label();
            this.cboEstadoReserva = new System.Windows.Forms.ComboBox();
            this.nudCosto = new System.Windows.Forms.NumericUpDown();
            this.lblCosto = new System.Windows.Forms.Label();
            this.cboTipoReserva = new System.Windows.Forms.ComboBox();
            this.lblTipoReserva = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblHabitacion = new System.Windows.Forms.Label();
            this.cboHabitacion = new System.Windows.Forms.ComboBox();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudCosto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(342, 321);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 61;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(342, 292);
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
            this.btnEliminar.Location = new System.Drawing.Point(180, 307);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 58;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(99, 307);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 57;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(18, 307);
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
            // lblEstadoReserva
            // 
            this.lblEstadoReserva.AutoSize = true;
            this.lblEstadoReserva.Location = new System.Drawing.Point(27, 263);
            this.lblEstadoReserva.Name = "lblEstadoReserva";
            this.lblEstadoReserva.Size = new System.Drawing.Size(83, 13);
            this.lblEstadoReserva.TabIndex = 54;
            this.lblEstadoReserva.Text = "Estado Reserva";
            // 
            // cboEstadoReserva
            // 
            this.cboEstadoReserva.FormattingEnabled = true;
            this.cboEstadoReserva.Location = new System.Drawing.Point(131, 255);
            this.cboEstadoReserva.Name = "cboEstadoReserva";
            this.cboEstadoReserva.Size = new System.Drawing.Size(108, 21);
            this.cboEstadoReserva.TabIndex = 53;
            // 
            // nudCosto
            // 
            this.nudCosto.Location = new System.Drawing.Point(131, 218);
            this.nudCosto.Name = "nudCosto";
            this.nudCosto.Size = new System.Drawing.Size(108, 20);
            this.nudCosto.TabIndex = 52;
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Location = new System.Drawing.Point(32, 225);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(34, 13);
            this.lblCosto.TabIndex = 51;
            this.lblCosto.Text = "Costo";
            // 
            // cboTipoReserva
            // 
            this.cboTipoReserva.FormattingEnabled = true;
            this.cboTipoReserva.Location = new System.Drawing.Point(131, 174);
            this.cboTipoReserva.Name = "cboTipoReserva";
            this.cboTipoReserva.Size = new System.Drawing.Size(108, 21);
            this.cboTipoReserva.TabIndex = 50;
            // 
            // lblTipoReserva
            // 
            this.lblTipoReserva.AutoSize = true;
            this.lblTipoReserva.Location = new System.Drawing.Point(27, 182);
            this.lblTipoReserva.Name = "lblTipoReserva";
            this.lblTipoReserva.Size = new System.Drawing.Size(71, 13);
            this.lblTipoReserva.TabIndex = 49;
            this.lblTipoReserva.Text = "Tipo Reserva";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(27, 95);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 48;
            this.lblCliente.Text = "Cliente";
            // 
            // lblHabitacion
            // 
            this.lblHabitacion.AutoSize = true;
            this.lblHabitacion.Location = new System.Drawing.Point(27, 134);
            this.lblHabitacion.Name = "lblHabitacion";
            this.lblHabitacion.Size = new System.Drawing.Size(58, 13);
            this.lblHabitacion.TabIndex = 46;
            this.lblHabitacion.Text = "Habitacion";
            // 
            // cboHabitacion
            // 
            this.cboHabitacion.FormattingEnabled = true;
            this.cboHabitacion.Location = new System.Drawing.Point(131, 134);
            this.cboHabitacion.Name = "cboHabitacion";
            this.cboHabitacion.Size = new System.Drawing.Size(108, 21);
            this.cboHabitacion.TabIndex = 62;
            // 
            // cboCliente
            // 
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(131, 92);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(108, 21);
            this.cboCliente.TabIndex = 63;
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
            this.txtCodigo.Location = new System.Drawing.Point(131, 46);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(106, 20);
            this.txtCodigo.TabIndex = 65;
            // 
            // frmAlquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 355);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.cboCliente);
            this.Controls.Add(this.cboHabitacion);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lstAlquileres);
            this.Controls.Add(this.lblEstadoReserva);
            this.Controls.Add(this.cboEstadoReserva);
            this.Controls.Add(this.nudCosto);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.cboTipoReserva);
            this.Controls.Add(this.lblTipoReserva);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblHabitacion);
            this.Name = "frmAlquiler";
            this.Text = "frmAlquiler";
            this.Load += new System.EventHandler(this.frmAlquiler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCosto)).EndInit();
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
        private System.Windows.Forms.Label lblEstadoReserva;
        private System.Windows.Forms.ComboBox cboEstadoReserva;
        private System.Windows.Forms.NumericUpDown nudCosto;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.ComboBox cboTipoReserva;
        private System.Windows.Forms.Label lblTipoReserva;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblHabitacion;
        private System.Windows.Forms.ComboBox cboHabitacion;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
    }
}

