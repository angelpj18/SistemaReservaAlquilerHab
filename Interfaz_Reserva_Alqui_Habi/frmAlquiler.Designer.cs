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
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblHabitacion = new System.Windows.Forms.Label();
            this.txtHabitacion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudCosto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(517, 235);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 61;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(436, 235);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 60;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(355, 235);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 59;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(180, 245);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 58;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(99, 245);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 57;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(18, 245);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 56;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lstAlquileres
            // 
            this.lstAlquileres.FormattingEnabled = true;
            this.lstAlquileres.Location = new System.Drawing.Point(354, 30);
            this.lstAlquileres.Name = "lstAlquileres";
            this.lstAlquileres.Size = new System.Drawing.Size(237, 199);
            this.lstAlquileres.TabIndex = 55;
            // 
            // lblEstadoReserva
            // 
            this.lblEstadoReserva.AutoSize = true;
            this.lblEstadoReserva.Location = new System.Drawing.Point(27, 201);
            this.lblEstadoReserva.Name = "lblEstadoReserva";
            this.lblEstadoReserva.Size = new System.Drawing.Size(83, 13);
            this.lblEstadoReserva.TabIndex = 54;
            this.lblEstadoReserva.Text = "Estado Reserva";
            // 
            // cboEstadoReserva
            // 
            this.cboEstadoReserva.FormattingEnabled = true;
            this.cboEstadoReserva.Location = new System.Drawing.Point(131, 193);
            this.cboEstadoReserva.Name = "cboEstadoReserva";
            this.cboEstadoReserva.Size = new System.Drawing.Size(108, 21);
            this.cboEstadoReserva.TabIndex = 53;
            // 
            // nudCosto
            // 
            this.nudCosto.Location = new System.Drawing.Point(131, 156);
            this.nudCosto.Name = "nudCosto";
            this.nudCosto.Size = new System.Drawing.Size(108, 20);
            this.nudCosto.TabIndex = 52;
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Location = new System.Drawing.Point(32, 163);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(34, 13);
            this.lblCosto.TabIndex = 51;
            this.lblCosto.Text = "Costo";
            // 
            // cboTipoReserva
            // 
            this.cboTipoReserva.FormattingEnabled = true;
            this.cboTipoReserva.Location = new System.Drawing.Point(131, 112);
            this.cboTipoReserva.Name = "cboTipoReserva";
            this.cboTipoReserva.Size = new System.Drawing.Size(108, 21);
            this.cboTipoReserva.TabIndex = 50;
            // 
            // lblTipoReserva
            // 
            this.lblTipoReserva.AutoSize = true;
            this.lblTipoReserva.Location = new System.Drawing.Point(27, 120);
            this.lblTipoReserva.Name = "lblTipoReserva";
            this.lblTipoReserva.Size = new System.Drawing.Size(71, 13);
            this.lblTipoReserva.TabIndex = 49;
            this.lblTipoReserva.Text = "Tipo Reserva";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(27, 78);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 48;
            this.lblCliente.Text = "Cliente";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(131, 71);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(108, 20);
            this.txtCliente.TabIndex = 47;
            // 
            // lblHabitacion
            // 
            this.lblHabitacion.AutoSize = true;
            this.lblHabitacion.Location = new System.Drawing.Point(27, 36);
            this.lblHabitacion.Name = "lblHabitacion";
            this.lblHabitacion.Size = new System.Drawing.Size(58, 13);
            this.lblHabitacion.TabIndex = 46;
            this.lblHabitacion.Text = "Habitacion";
            // 
            // txtHabitacion
            // 
            this.txtHabitacion.Location = new System.Drawing.Point(131, 30);
            this.txtHabitacion.Name = "txtHabitacion";
            this.txtHabitacion.Size = new System.Drawing.Size(108, 20);
            this.txtHabitacion.TabIndex = 45;
            // 
            // frmAlquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 297);
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
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.lblHabitacion);
            this.Controls.Add(this.txtHabitacion);
            this.Name = "frmAlquiler";
            this.Text = "frmAlquiler";
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
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblHabitacion;
        private System.Windows.Forms.TextBox txtHabitacion;
    }
}

