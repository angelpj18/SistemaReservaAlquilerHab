﻿namespace InterfazResAlqHabit
{
    partial class frmHabitacion
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
            this.rdbNo = new System.Windows.Forms.RadioButton();
            this.rdbSi = new System.Windows.Forms.RadioButton();
            this.lblHabilitado = new System.Windows.Forms.Label();
            this.cmbPiso = new System.Windows.Forms.ComboBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.lstHabitacion = new System.Windows.Forms.ListBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPiso = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rdbNo
            // 
            this.rdbNo.AutoSize = true;
            this.rdbNo.Location = new System.Drawing.Point(165, 180);
            this.rdbNo.Name = "rdbNo";
            this.rdbNo.Size = new System.Drawing.Size(39, 17);
            this.rdbNo.TabIndex = 49;
            this.rdbNo.TabStop = true;
            this.rdbNo.Text = "No";
            this.rdbNo.UseVisualStyleBackColor = true;
            // 
            // rdbSi
            // 
            this.rdbSi.AutoSize = true;
            this.rdbSi.Checked = true;
            this.rdbSi.Location = new System.Drawing.Point(115, 179);
            this.rdbSi.Name = "rdbSi";
            this.rdbSi.Size = new System.Drawing.Size(34, 17);
            this.rdbSi.TabIndex = 48;
            this.rdbSi.TabStop = true;
            this.rdbSi.Text = "Si";
            this.rdbSi.UseVisualStyleBackColor = true;
            // 
            // lblHabilitado
            // 
            this.lblHabilitado.AutoSize = true;
            this.lblHabilitado.Location = new System.Drawing.Point(30, 179);
            this.lblHabilitado.Name = "lblHabilitado";
            this.lblHabilitado.Size = new System.Drawing.Size(54, 13);
            this.lblHabilitado.TabIndex = 47;
            this.lblHabilitado.Text = "Habilitado";
            // 
            // cmbPiso
            // 
            this.cmbPiso.FormattingEnabled = true;
            this.cmbPiso.Location = new System.Drawing.Point(115, 108);
            this.cmbPiso.Name = "cmbPiso";
            this.cmbPiso.Size = new System.Drawing.Size(121, 21);
            this.cmbPiso.TabIndex = 46;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(115, 76);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(121, 21);
            this.cmbCategoria.TabIndex = 45;
            // 
            // lstHabitacion
            // 
            this.lstHabitacion.FormattingEnabled = true;
            this.lstHabitacion.Location = new System.Drawing.Point(256, 32);
            this.lstHabitacion.Name = "lstHabitacion";
            this.lstHabitacion.Size = new System.Drawing.Size(177, 173);
            this.lstHabitacion.TabIndex = 44;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(358, 238);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 34);
            this.btnLimpiar.TabIndex = 43;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click_1);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(255, 238);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 34);
            this.btnEditar.TabIndex = 42;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(154, 238);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 34);
            this.btnEliminar.TabIndex = 41;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(57, 238);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 34);
            this.btnAgregar.TabIndex = 40;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(115, 141);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(121, 20);
            this.txtDescripcion.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Descripción";
            // 
            // lblPiso
            // 
            this.lblPiso.AutoSize = true;
            this.lblPiso.Location = new System.Drawing.Point(30, 111);
            this.lblPiso.Name = "lblPiso";
            this.lblPiso.Size = new System.Drawing.Size(27, 13);
            this.lblPiso.TabIndex = 37;
            this.lblPiso.Text = "Piso";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(30, 79);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(54, 13);
            this.lblCategoria.TabIndex = 36;
            this.lblCategoria.Text = "Categoría";
            // 
            // txtDetalle
            // 
            this.txtDetalle.Location = new System.Drawing.Point(115, 47);
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(82, 20);
            this.txtDetalle.TabIndex = 35;
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Location = new System.Drawing.Point(30, 47);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(40, 13);
            this.lblDetalle.TabIndex = 34;
            this.lblDetalle.Text = "Detalle";
            // 
            // frmHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 304);
            this.Controls.Add(this.rdbNo);
            this.Controls.Add(this.rdbSi);
            this.Controls.Add(this.lblHabilitado);
            this.Controls.Add(this.cmbPiso);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.lstHabitacion);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPiso);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.txtDetalle);
            this.Controls.Add(this.lblDetalle);
            this.Name = "frmHabitacion";
            this.Text = "frmHabitacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbNo;
        private System.Windows.Forms.RadioButton rdbSi;
        private System.Windows.Forms.Label lblHabilitado;
        private System.Windows.Forms.ComboBox cmbPiso;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.ListBox lstHabitacion;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPiso;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.Label lblDetalle;
    }
}