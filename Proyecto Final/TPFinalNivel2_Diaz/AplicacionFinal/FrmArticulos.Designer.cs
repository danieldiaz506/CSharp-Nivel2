namespace AplicacionFinal
{
    partial class FrmArticulos
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblImagen = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pbxImagen = new System.Windows.Forms.PictureBox();
            this.lblVistaPrevia = new System.Windows.Forms.Label();
            this.tbxCodigo = new System.Windows.Forms.TextBox();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.tbxDescripcion = new System.Windows.Forms.TextBox();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.tbxImagen = new System.Windows.Forms.TextBox();
            this.tbxPrecio = new System.Windows.Forms.TextBox();
            this.lblMaxCodigo = new System.Windows.Forms.Label();
            this.lblMaxNombre = new System.Windows.Forms.Label();
            this.lblMaxDescripcion = new System.Windows.Forms.Label();
            this.lblSoloNumeros = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(42, 21);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(219, 32);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Agregar artículo:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigo.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.Black;
            this.lblCodigo.Location = new System.Drawing.Point(44, 96);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(64, 19);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Código:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Black;
            this.lblNombre.Location = new System.Drawing.Point(44, 169);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(70, 19);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.lblDescripcion.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.Black;
            this.lblDescripcion.Location = new System.Drawing.Point(44, 242);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(98, 19);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.BackColor = System.Drawing.Color.Transparent;
            this.lblMarca.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.ForeColor = System.Drawing.Color.Black;
            this.lblMarca.Location = new System.Drawing.Point(44, 452);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(57, 19);
            this.lblMarca.TabIndex = 4;
            this.lblMarca.Text = "Marca:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.BackColor = System.Drawing.Color.Transparent;
            this.lblCategoria.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.Color.Black;
            this.lblCategoria.Location = new System.Drawing.Point(44, 499);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(80, 19);
            this.lblCategoria.TabIndex = 5;
            this.lblCategoria.Text = "Categoría:";
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.BackColor = System.Drawing.Color.Transparent;
            this.lblImagen.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImagen.ForeColor = System.Drawing.Color.Black;
            this.lblImagen.Location = new System.Drawing.Point(44, 549);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(110, 19);
            this.lblImagen.TabIndex = 6;
            this.lblImagen.Text = "Url de imagen:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecio.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.Color.Black;
            this.lblPrecio.Location = new System.Drawing.Point(44, 615);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(60, 19);
            this.lblPrecio.TabIndex = 7;
            this.lblPrecio.Text = "Precio:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.SystemColors.Menu;
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(259, 679);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(145, 37);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Menu;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(446, 679);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(145, 37);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pbxImagen
            // 
            this.pbxImagen.Location = new System.Drawing.Point(507, 199);
            this.pbxImagen.Name = "pbxImagen";
            this.pbxImagen.Size = new System.Drawing.Size(305, 272);
            this.pbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImagen.TabIndex = 10;
            this.pbxImagen.TabStop = false;
            // 
            // lblVistaPrevia
            // 
            this.lblVistaPrevia.AutoSize = true;
            this.lblVistaPrevia.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVistaPrevia.ForeColor = System.Drawing.Color.Black;
            this.lblVistaPrevia.Location = new System.Drawing.Point(619, 171);
            this.lblVistaPrevia.Name = "lblVistaPrevia";
            this.lblVistaPrevia.Size = new System.Drawing.Size(78, 17);
            this.lblVistaPrevia.TabIndex = 11;
            this.lblVistaPrevia.Text = "Vista previa";
            // 
            // tbxCodigo
            // 
            this.tbxCodigo.BackColor = System.Drawing.Color.White;
            this.tbxCodigo.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCodigo.Location = new System.Drawing.Point(126, 88);
            this.tbxCodigo.MaxLength = 50;
            this.tbxCodigo.Name = "tbxCodigo";
            this.tbxCodigo.Size = new System.Drawing.Size(120, 27);
            this.tbxCodigo.TabIndex = 0;
            // 
            // tbxNombre
            // 
            this.tbxNombre.BackColor = System.Drawing.Color.White;
            this.tbxNombre.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNombre.Location = new System.Drawing.Point(123, 161);
            this.tbxNombre.MaxLength = 50;
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(283, 27);
            this.tbxNombre.TabIndex = 1;
            // 
            // tbxDescripcion
            // 
            this.tbxDescripcion.BackColor = System.Drawing.Color.White;
            this.tbxDescripcion.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDescripcion.Location = new System.Drawing.Point(148, 242);
            this.tbxDescripcion.MaxLength = 150;
            this.tbxDescripcion.Multiline = true;
            this.tbxDescripcion.Name = "tbxDescripcion";
            this.tbxDescripcion.Size = new System.Drawing.Size(303, 154);
            this.tbxDescripcion.TabIndex = 2;
            // 
            // cbxMarca
            // 
            this.cbxMarca.BackColor = System.Drawing.Color.White;
            this.cbxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMarca.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Location = new System.Drawing.Point(132, 444);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(167, 27);
            this.cbxMarca.TabIndex = 3;
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.BackColor = System.Drawing.Color.White;
            this.cbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategoria.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(132, 491);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(167, 27);
            this.cbxCategoria.TabIndex = 4;
            // 
            // tbxImagen
            // 
            this.tbxImagen.BackColor = System.Drawing.Color.White;
            this.tbxImagen.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxImagen.Location = new System.Drawing.Point(160, 541);
            this.tbxImagen.MaxLength = 1000;
            this.tbxImagen.Name = "tbxImagen";
            this.tbxImagen.Size = new System.Drawing.Size(255, 27);
            this.tbxImagen.TabIndex = 5;
            this.tbxImagen.Leave += new System.EventHandler(this.tbxImagen_Leave);
            // 
            // tbxPrecio
            // 
            this.tbxPrecio.BackColor = System.Drawing.Color.White;
            this.tbxPrecio.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPrecio.Location = new System.Drawing.Point(123, 607);
            this.tbxPrecio.Name = "tbxPrecio";
            this.tbxPrecio.Size = new System.Drawing.Size(252, 27);
            this.tbxPrecio.TabIndex = 6;
            this.tbxPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPrecio_KeyPress);
            // 
            // lblMaxCodigo
            // 
            this.lblMaxCodigo.AutoSize = true;
            this.lblMaxCodigo.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxCodigo.ForeColor = System.Drawing.Color.Black;
            this.lblMaxCodigo.Location = new System.Drawing.Point(123, 118);
            this.lblMaxCodigo.Name = "lblMaxCodigo";
            this.lblMaxCodigo.Size = new System.Drawing.Size(129, 17);
            this.lblMaxCodigo.TabIndex = 19;
            this.lblMaxCodigo.Text = "(Máx 50 caracteres)";
            // 
            // lblMaxNombre
            // 
            this.lblMaxNombre.AutoSize = true;
            this.lblMaxNombre.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxNombre.ForeColor = System.Drawing.Color.Black;
            this.lblMaxNombre.Location = new System.Drawing.Point(123, 195);
            this.lblMaxNombre.Name = "lblMaxNombre";
            this.lblMaxNombre.Size = new System.Drawing.Size(129, 17);
            this.lblMaxNombre.TabIndex = 20;
            this.lblMaxNombre.Text = "(Máx 50 caracteres)";
            // 
            // lblMaxDescripcion
            // 
            this.lblMaxDescripcion.AutoSize = true;
            this.lblMaxDescripcion.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxDescripcion.ForeColor = System.Drawing.Color.Black;
            this.lblMaxDescripcion.Location = new System.Drawing.Point(145, 399);
            this.lblMaxDescripcion.Name = "lblMaxDescripcion";
            this.lblMaxDescripcion.Size = new System.Drawing.Size(136, 17);
            this.lblMaxDescripcion.TabIndex = 21;
            this.lblMaxDescripcion.Text = "(Máx 150 caracteres)";
            // 
            // lblSoloNumeros
            // 
            this.lblSoloNumeros.AutoSize = true;
            this.lblSoloNumeros.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoloNumeros.ForeColor = System.Drawing.Color.Black;
            this.lblSoloNumeros.Location = new System.Drawing.Point(123, 641);
            this.lblSoloNumeros.Name = "lblSoloNumeros";
            this.lblSoloNumeros.Size = new System.Drawing.Size(97, 17);
            this.lblSoloNumeros.TabIndex = 22;
            this.lblSoloNumeros.Text = "(Solo números)";
            // 
            // FrmArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(850, 749);
            this.Controls.Add(this.lblSoloNumeros);
            this.Controls.Add(this.lblMaxDescripcion);
            this.Controls.Add(this.lblMaxNombre);
            this.Controls.Add(this.lblMaxCodigo);
            this.Controls.Add(this.tbxPrecio);
            this.Controls.Add(this.tbxImagen);
            this.Controls.Add(this.cbxCategoria);
            this.Controls.Add(this.cbxMarca);
            this.Controls.Add(this.tbxDescripcion);
            this.Controls.Add(this.tbxNombre);
            this.Controls.Add(this.tbxCodigo);
            this.Controls.Add(this.lblVistaPrevia);
            this.Controls.Add(this.pbxImagen);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblImagen);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Añadir nuevo artículo";
            this.Load += new System.EventHandler(this.FrmArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox pbxImagen;
        private System.Windows.Forms.Label lblVistaPrevia;
        private System.Windows.Forms.TextBox tbxCodigo;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.TextBox tbxDescripcion;
        private System.Windows.Forms.ComboBox cbxMarca;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.TextBox tbxImagen;
        private System.Windows.Forms.TextBox tbxPrecio;
        private System.Windows.Forms.Label lblMaxCodigo;
        private System.Windows.Forms.Label lblMaxNombre;
        private System.Windows.Forms.Label lblMaxDescripcion;
        private System.Windows.Forms.Label lblSoloNumeros;
    }
}