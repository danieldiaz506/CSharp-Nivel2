namespace Appliation_with_DB
{
    partial class FrmAgregar
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCantidadCanciones = new System.Windows.Forms.Label();
            this.lblUrlImagenTapa = new System.Windows.Forms.Label();
            this.tbxTitulo = new System.Windows.Forms.TextBox();
            this.tbxCantidadCanciones = new System.Windows.Forms.TextBox();
            this.tbxUrlImagenTapa = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dtpFechaLanzamiento = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxEstilo = new System.Windows.Forms.ComboBox();
            this.cbxEdicion = new System.Windows.Forms.ComboBox();
            this.lblEstilo = new System.Windows.Forms.Label();
            this.lblEdicion = new System.Windows.Forms.Label();
            this.pbxPrecarga = new System.Windows.Forms.PictureBox();
            this.btnAgregarLocal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPrecarga)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(52, 44);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(108, 16);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Nombre de titulo:";
            // 
            // lblCantidadCanciones
            // 
            this.lblCantidadCanciones.AutoSize = true;
            this.lblCantidadCanciones.Location = new System.Drawing.Point(14, 146);
            this.lblCantidadCanciones.Name = "lblCantidadCanciones";
            this.lblCantidadCanciones.Size = new System.Drawing.Size(148, 16);
            this.lblCantidadCanciones.TabIndex = 1;
            this.lblCantidadCanciones.Text = "Cantidad de canciones:";
            // 
            // lblUrlImagenTapa
            // 
            this.lblUrlImagenTapa.AutoSize = true;
            this.lblUrlImagenTapa.Location = new System.Drawing.Point(66, 198);
            this.lblUrlImagenTapa.Name = "lblUrlImagenTapa";
            this.lblUrlImagenTapa.Size = new System.Drawing.Size(94, 16);
            this.lblUrlImagenTapa.TabIndex = 2;
            this.lblUrlImagenTapa.Text = "Url de imagen:";
            // 
            // tbxTitulo
            // 
            this.tbxTitulo.Location = new System.Drawing.Point(180, 38);
            this.tbxTitulo.Name = "tbxTitulo";
            this.tbxTitulo.Size = new System.Drawing.Size(200, 22);
            this.tbxTitulo.TabIndex = 0;
            // 
            // tbxCantidadCanciones
            // 
            this.tbxCantidadCanciones.Location = new System.Drawing.Point(180, 146);
            this.tbxCantidadCanciones.Name = "tbxCantidadCanciones";
            this.tbxCantidadCanciones.Size = new System.Drawing.Size(200, 22);
            this.tbxCantidadCanciones.TabIndex = 2;
            // 
            // tbxUrlImagenTapa
            // 
            this.tbxUrlImagenTapa.Location = new System.Drawing.Point(180, 198);
            this.tbxUrlImagenTapa.Name = "tbxUrlImagenTapa";
            this.tbxUrlImagenTapa.Size = new System.Drawing.Size(200, 22);
            this.tbxUrlImagenTapa.TabIndex = 3;
            this.tbxUrlImagenTapa.Leave += new System.EventHandler(this.tbxUrlImagenTapa_Leave);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(55, 359);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(118, 28);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(219, 359);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(118, 28);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dtpFechaLanzamiento
            // 
            this.dtpFechaLanzamiento.Location = new System.Drawing.Point(180, 84);
            this.dtpFechaLanzamiento.Name = "dtpFechaLanzamiento";
            this.dtpFechaLanzamiento.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaLanzamiento.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Fecha de Lanzamiento:";
            // 
            // cbxEstilo
            // 
            this.cbxEstilo.FormattingEnabled = true;
            this.cbxEstilo.Location = new System.Drawing.Point(180, 252);
            this.cbxEstilo.Name = "cbxEstilo";
            this.cbxEstilo.Size = new System.Drawing.Size(121, 24);
            this.cbxEstilo.TabIndex = 4;
            // 
            // cbxEdicion
            // 
            this.cbxEdicion.FormattingEnabled = true;
            this.cbxEdicion.Location = new System.Drawing.Point(180, 305);
            this.cbxEdicion.Name = "cbxEdicion";
            this.cbxEdicion.Size = new System.Drawing.Size(121, 24);
            this.cbxEdicion.TabIndex = 5;
            // 
            // lblEstilo
            // 
            this.lblEstilo.AutoSize = true;
            this.lblEstilo.Location = new System.Drawing.Point(117, 260);
            this.lblEstilo.Name = "lblEstilo";
            this.lblEstilo.Size = new System.Drawing.Size(43, 16);
            this.lblEstilo.TabIndex = 12;
            this.lblEstilo.Text = "Estilo:";
            // 
            // lblEdicion
            // 
            this.lblEdicion.AutoSize = true;
            this.lblEdicion.Location = new System.Drawing.Point(58, 313);
            this.lblEdicion.Name = "lblEdicion";
            this.lblEdicion.Size = new System.Drawing.Size(104, 16);
            this.lblEdicion.TabIndex = 13;
            this.lblEdicion.Text = "Tipo de edición:";
            // 
            // pbxPrecarga
            // 
            this.pbxPrecarga.Location = new System.Drawing.Point(446, 84);
            this.pbxPrecarga.Name = "pbxPrecarga";
            this.pbxPrecarga.Size = new System.Drawing.Size(278, 239);
            this.pbxPrecarga.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPrecarga.TabIndex = 14;
            this.pbxPrecarga.TabStop = false;
            // 
            // btnAgregarLocal
            // 
            this.btnAgregarLocal.Location = new System.Drawing.Point(386, 198);
            this.btnAgregarLocal.Name = "btnAgregarLocal";
            this.btnAgregarLocal.Size = new System.Drawing.Size(32, 23);
            this.btnAgregarLocal.TabIndex = 15;
            this.btnAgregarLocal.Text = "...";
            this.btnAgregarLocal.UseVisualStyleBackColor = true;
            this.btnAgregarLocal.Click += new System.EventHandler(this.btnAgregarLocal_Click);
            // 
            // FrmAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 419);
            this.Controls.Add(this.btnAgregarLocal);
            this.Controls.Add(this.pbxPrecarga);
            this.Controls.Add(this.lblEdicion);
            this.Controls.Add(this.lblEstilo);
            this.Controls.Add(this.cbxEdicion);
            this.Controls.Add(this.cbxEstilo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFechaLanzamiento);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.tbxUrlImagenTapa);
            this.Controls.Add(this.tbxCantidadCanciones);
            this.Controls.Add(this.tbxTitulo);
            this.Controls.Add(this.lblUrlImagenTapa);
            this.Controls.Add(this.lblCantidadCanciones);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmAgregar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Disco";
            this.Load += new System.EventHandler(this.FrmAgregar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPrecarga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCantidadCanciones;
        private System.Windows.Forms.Label lblUrlImagenTapa;
        private System.Windows.Forms.TextBox tbxTitulo;
        private System.Windows.Forms.TextBox tbxCantidadCanciones;
        private System.Windows.Forms.TextBox tbxUrlImagenTapa;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DateTimePicker dtpFechaLanzamiento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxEstilo;
        private System.Windows.Forms.ComboBox cbxEdicion;
        private System.Windows.Forms.Label lblEstilo;
        private System.Windows.Forms.Label lblEdicion;
        private System.Windows.Forms.PictureBox pbxPrecarga;
        private System.Windows.Forms.Button btnAgregarLocal;
    }
}