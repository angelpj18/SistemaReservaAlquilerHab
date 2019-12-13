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
            this.lblTipoReserva = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.blFechaInicio = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblFechaReserva = new System.Windows.Forms.Label();
            this.dtpFechaReserva = new System.Windows.Forms.DateTimePicker();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.dtgDetalleReserva = new System.Windows.Forms.DataGridView();
            this.lblHabitacion = new System.Windows.Forms.Label();
            this.cboTipoHabitacion = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNroDetalle = new System.Windows.Forms.TextBox();
            this.lblCantHabi = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cboSucursal = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.cboTipoRe = new System.Windows.Forms.ComboBox();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalleReserva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cboCliente
            // 
            this.cboCliente.Font = new System.Drawing.Font("Century", 11.25F);
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(180, 202);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(163, 26);
            this.cboCliente.TabIndex = 74;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Century", 11.25F);
            this.lblCliente.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblCliente.Location = new System.Drawing.Point(80, 205);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(60, 18);
            this.lblCliente.TabIndex = 73;
            this.lblCliente.Text = "Cliente";
            // 
            // lblTipoReserva
            // 
            this.lblTipoReserva.AutoSize = true;
            this.lblTipoReserva.Font = new System.Drawing.Font("Century", 11.25F);
            this.lblTipoReserva.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblTipoReserva.Location = new System.Drawing.Point(69, 162);
            this.lblTipoReserva.Name = "lblTipoReserva";
            this.lblTipoReserva.Size = new System.Drawing.Size(101, 18);
            this.lblTipoReserva.TabIndex = 71;
            this.lblTipoReserva.Text = "Tipo Reserva";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 11.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(80, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 18);
            this.label1.TabIndex = 69;
            this.label1.Text = "Estado";
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Font = new System.Drawing.Font("Century", 11.25F);
            this.lblFechaFin.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblFechaFin.Location = new System.Drawing.Point(64, 345);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(99, 18);
            this.lblFechaFin.TabIndex = 67;
            this.lblFechaFin.Text = "Fecha de Fin";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Font = new System.Drawing.Font("Century", 11.25F);
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(208, 343);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(108, 26);
            this.dtpFechaFin.TabIndex = 66;
            // 
            // blFechaInicio
            // 
            this.blFechaInicio.AutoSize = true;
            this.blFechaInicio.Font = new System.Drawing.Font("Century", 11.25F);
            this.blFechaInicio.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.blFechaInicio.Location = new System.Drawing.Point(64, 313);
            this.blFechaInicio.Name = "blFechaInicio";
            this.blFechaInicio.Size = new System.Drawing.Size(115, 18);
            this.blFechaInicio.TabIndex = 65;
            this.blFechaInicio.Text = "Fecha de Inicio";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Font = new System.Drawing.Font("Century", 11.25F);
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(208, 312);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(108, 26);
            this.dtpFechaInicio.TabIndex = 64;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Century", 11.25F);
            this.lblCategoria.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblCategoria.Location = new System.Drawing.Point(80, 244);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(69, 18);
            this.lblCategoria.TabIndex = 63;
            this.lblCategoria.Text = "Sucursal";
            // 
            // lblFechaReserva
            // 
            this.lblFechaReserva.AutoSize = true;
            this.lblFechaReserva.Font = new System.Drawing.Font("Century", 11.25F);
            this.lblFechaReserva.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblFechaReserva.Location = new System.Drawing.Point(64, 285);
            this.lblFechaReserva.Name = "lblFechaReserva";
            this.lblFechaReserva.Size = new System.Drawing.Size(132, 18);
            this.lblFechaReserva.TabIndex = 62;
            this.lblFechaReserva.Text = "Fecha de Reserva";
            // 
            // dtpFechaReserva
            // 
            this.dtpFechaReserva.Font = new System.Drawing.Font("Century", 11.25F);
            this.dtpFechaReserva.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaReserva.Location = new System.Drawing.Point(207, 283);
            this.dtpFechaReserva.Name = "dtpFechaReserva";
            this.dtpFechaReserva.Size = new System.Drawing.Size(108, 26);
            this.dtpFechaReserva.TabIndex = 61;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Century", 11.25F);
            this.txtDescripcion.Location = new System.Drawing.Point(180, 95);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(163, 26);
            this.txtDescripcion.TabIndex = 59;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpiar.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Image = global::Interfaz_Reserva_Alqui_Habi.Properties.Resources.PicsArt_12_11_12_49_37;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(383, 466);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(141, 54);
            this.btnLimpiar.TabIndex = 58;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Image = global::Interfaz_Reserva_Alqui_Habi.Properties.Resources._5;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(193, 406);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(141, 54);
            this.btnAgregar.TabIndex = 53;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Font = new System.Drawing.Font("Century", 11.25F);
            this.lblDetalle.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblDetalle.Location = new System.Drawing.Point(69, 99);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(96, 18);
            this.lblDetalle.TabIndex = 51;
            this.lblDetalle.Text = "Descripcion:";
            // 
            // dtgDetalleReserva
            // 
            this.dtgDetalleReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDetalleReserva.Location = new System.Drawing.Point(383, 241);
            this.dtgDetalleReserva.Name = "dtgDetalleReserva";
            this.dtgDetalleReserva.Size = new System.Drawing.Size(451, 198);
            this.dtgDetalleReserva.TabIndex = 75;
            // 
            // lblHabitacion
            // 
            this.lblHabitacion.AutoSize = true;
            this.lblHabitacion.Font = new System.Drawing.Font("Century", 11.25F);
            this.lblHabitacion.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblHabitacion.Location = new System.Drawing.Point(380, 127);
            this.lblHabitacion.Name = "lblHabitacion";
            this.lblHabitacion.Size = new System.Drawing.Size(121, 18);
            this.lblHabitacion.TabIndex = 79;
            this.lblHabitacion.Text = "Tipo Habitacion";
            // 
            // cboTipoHabitacion
            // 
            this.cboTipoHabitacion.Font = new System.Drawing.Font("Century", 11.25F);
            this.cboTipoHabitacion.FormattingEnabled = true;
            this.cboTipoHabitacion.Location = new System.Drawing.Point(526, 122);
            this.cboTipoHabitacion.Name = "cboTipoHabitacion";
            this.cboTipoHabitacion.Size = new System.Drawing.Size(121, 26);
            this.cboTipoHabitacion.TabIndex = 76;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 11.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(380, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 18);
            this.label3.TabIndex = 78;
            this.label3.Text = "Nº Detalle";
            // 
            // txtNroDetalle
            // 
            this.txtNroDetalle.Font = new System.Drawing.Font("Century", 11.25F);
            this.txtNroDetalle.Location = new System.Drawing.Point(526, 91);
            this.txtNroDetalle.Name = "txtNroDetalle";
            this.txtNroDetalle.Size = new System.Drawing.Size(64, 26);
            this.txtNroDetalle.TabIndex = 77;
            // 
            // lblCantHabi
            // 
            this.lblCantHabi.AutoSize = true;
            this.lblCantHabi.Font = new System.Drawing.Font("Century", 11.25F);
            this.lblCantHabi.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblCantHabi.Location = new System.Drawing.Point(380, 203);
            this.lblCantHabi.Name = "lblCantHabi";
            this.lblCantHabi.Size = new System.Drawing.Size(121, 18);
            this.lblCantHabi.TabIndex = 83;
            this.lblCantHabi.Text = "Nº Habitaciones";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Century", 11.25F);
            this.txtCantidad.Location = new System.Drawing.Point(526, 199);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(50, 26);
            this.txtCantidad.TabIndex = 82;
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Image = global::Interfaz_Reserva_Alqui_Habi.Properties.Resources._8;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(193, 465);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(141, 54);
            this.btnGuardar.TabIndex = 84;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cboSucursal
            // 
            this.cboSucursal.Font = new System.Drawing.Font("Century", 11.25F);
            this.cboSucursal.FormattingEnabled = true;
            this.cboSucursal.Location = new System.Drawing.Point(180, 241);
            this.cboSucursal.Name = "cboSucursal";
            this.cboSucursal.Size = new System.Drawing.Size(163, 26);
            this.cboSucursal.TabIndex = 85;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 11.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(380, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 87;
            this.label2.Text = "Categoria";
            // 
            // cboCategoria
            // 
            this.cboCategoria.Font = new System.Drawing.Font("Century", 11.25F);
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(526, 157);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(121, 26);
            this.cboCategoria.TabIndex = 86;
            // 
            // cboEstado
            // 
            this.cboEstado.Font = new System.Drawing.Font("Century", 11.25F);
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(180, 130);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(163, 26);
            this.cboEstado.TabIndex = 88;
            // 
            // cboTipoRe
            // 
            this.cboTipoRe.Font = new System.Drawing.Font("Century", 11.25F);
            this.cboTipoRe.FormattingEnabled = true;
            this.cboTipoRe.Location = new System.Drawing.Point(180, 161);
            this.cboTipoRe.Name = "cboTipoRe";
            this.cboTipoRe.Size = new System.Drawing.Size(163, 26);
            this.cboTipoRe.TabIndex = 89;
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(117)))));
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Left;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(20, 556);
            this.BarraTitulo.TabIndex = 90;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Interfaz_Reserva_Alqui_Habi.Properties.Resources._1576267475833;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(818, -10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 47);
            this.pictureBox1.TabIndex = 91;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(339, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 33);
            this.label4.TabIndex = 92;
            this.label4.Text = "RESERVA";
            // 
            // frmReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(36)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(856, 556);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.cboTipoRe);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.cboSucursal);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblCantHabi);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblHabitacion);
            this.Controls.Add(this.cboTipoHabitacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNroDetalle);
            this.Controls.Add(this.dtgDetalleReserva);
            this.Controls.Add(this.cboCliente);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblTipoReserva);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFechaFin);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.blFechaInicio);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblFechaReserva);
            this.Controls.Add(this.dtpFechaReserva);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblDetalle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RESERVA";
            this.Load += new System.EventHandler(this.frmReserva_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalleReserva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblTipoReserva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label blFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblFechaReserva;
        private System.Windows.Forms.DateTimePicker dtpFechaReserva;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.DataGridView dtgDetalleReserva;
        private System.Windows.Forms.Label lblHabitacion;
        private System.Windows.Forms.ComboBox cboTipoHabitacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNroDetalle;
        private System.Windows.Forms.Label lblCantHabi;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cboSucursal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.ComboBox cboTipoRe;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}