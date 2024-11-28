namespace AplicacionFinal
{
    partial class FrmDetalle
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
            this.lblArticulo = new System.Windows.Forms.Label();
            this.pbxImagen = new System.Windows.Forms.PictureBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblImagen = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.tbxCodigo = new System.Windows.Forms.TextBox();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.tbxDescripcion = new System.Windows.Forms.TextBox();
            this.tbxMarca = new System.Windows.Forms.TextBox();
            this.tbxCategoria = new System.Windows.Forms.TextBox();
            this.tbxImagen = new System.Windows.Forms.TextBox();
            this.tbxPrecio = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblArticulo
            // 
            this.lblArticulo.AutoEllipsis = true;
            this.lblArticulo.AutoSize = true;
            this.lblArticulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblArticulo.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArticulo.Location = new System.Drawing.Point(0, 0);
            this.lblArticulo.Name = "lblArticulo";
            this.lblArticulo.Size = new System.Drawing.Size(229, 34);
            this.lblArticulo.TabIndex = 0;
            this.lblArticulo.Text = "Título de artículo";
            this.lblArticulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbxImagen
            // 
            this.pbxImagen.Location = new System.Drawing.Point(497, 183);
            this.pbxImagen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbxImagen.Name = "pbxImagen";
            this.pbxImagen.Size = new System.Drawing.Size(281, 277);
            this.pbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImagen.TabIndex = 1;
            this.pbxImagen.TabStop = false;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(23, 110);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(64, 19);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(23, 183);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(70, 19);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(23, 247);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(98, 19);
            this.lblDescripcion.TabIndex = 4;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(23, 375);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(57, 19);
            this.lblMarca.TabIndex = 5;
            this.lblMarca.Text = "Marca:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(23, 431);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(80, 19);
            this.lblCategoria.TabIndex = 7;
            this.lblCategoria.Text = "Categoría:";
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.Location = new System.Drawing.Point(23, 488);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(110, 19);
            this.lblImagen.TabIndex = 9;
            this.lblImagen.Text = "Url de imagen:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(23, 592);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(60, 19);
            this.lblPrecio.TabIndex = 11;
            this.lblPrecio.Text = "Precio:";
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.SystemColors.Menu;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Location = new System.Drawing.Point(345, 657);
            this.btnOk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(126, 45);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // tbxCodigo
            // 
            this.tbxCodigo.Enabled = false;
            this.tbxCodigo.Location = new System.Drawing.Point(139, 102);
            this.tbxCodigo.Name = "tbxCodigo";
            this.tbxCodigo.Size = new System.Drawing.Size(100, 27);
            this.tbxCodigo.TabIndex = 1;
            // 
            // tbxNombre
            // 
            this.tbxNombre.Enabled = false;
            this.tbxNombre.Location = new System.Drawing.Point(139, 175);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.ReadOnly = true;
            this.tbxNombre.Size = new System.Drawing.Size(313, 27);
            this.tbxNombre.TabIndex = 2;
            // 
            // tbxDescripcion
            // 
            this.tbxDescripcion.Enabled = false;
            this.tbxDescripcion.Location = new System.Drawing.Point(139, 247);
            this.tbxDescripcion.Multiline = true;
            this.tbxDescripcion.Name = "tbxDescripcion";
            this.tbxDescripcion.ReadOnly = true;
            this.tbxDescripcion.Size = new System.Drawing.Size(313, 92);
            this.tbxDescripcion.TabIndex = 3;
            // 
            // tbxMarca
            // 
            this.tbxMarca.Enabled = false;
            this.tbxMarca.Location = new System.Drawing.Point(139, 367);
            this.tbxMarca.Name = "tbxMarca";
            this.tbxMarca.ReadOnly = true;
            this.tbxMarca.Size = new System.Drawing.Size(165, 27);
            this.tbxMarca.TabIndex = 4;
            // 
            // tbxCategoria
            // 
            this.tbxCategoria.Enabled = false;
            this.tbxCategoria.Location = new System.Drawing.Point(139, 423);
            this.tbxCategoria.Name = "tbxCategoria";
            this.tbxCategoria.ReadOnly = true;
            this.tbxCategoria.Size = new System.Drawing.Size(165, 27);
            this.tbxCategoria.TabIndex = 5;
            // 
            // tbxImagen
            // 
            this.tbxImagen.Enabled = false;
            this.tbxImagen.Location = new System.Drawing.Point(139, 488);
            this.tbxImagen.Multiline = true;
            this.tbxImagen.Name = "tbxImagen";
            this.tbxImagen.ReadOnly = true;
            this.tbxImagen.Size = new System.Drawing.Size(332, 73);
            this.tbxImagen.TabIndex = 6;
            // 
            // tbxPrecio
            // 
            this.tbxPrecio.Enabled = false;
            this.tbxPrecio.Location = new System.Drawing.Point(139, 584);
            this.tbxPrecio.Name = "tbxPrecio";
            this.tbxPrecio.ReadOnly = true;
            this.tbxPrecio.Size = new System.Drawing.Size(332, 27);
            this.tbxPrecio.TabIndex = 7;
            // 
            // FrmDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(811, 731);
            this.Controls.Add(this.tbxPrecio);
            this.Controls.Add(this.tbxImagen);
            this.Controls.Add(this.tbxCategoria);
            this.Controls.Add(this.tbxMarca);
            this.Controls.Add(this.tbxDescripcion);
            this.Controls.Add(this.tbxNombre);
            this.Controls.Add(this.tbxCodigo);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblImagen);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.pbxImagen);
            this.Controls.Add(this.lblArticulo);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmDetalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.FrmDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArticulo;
        private System.Windows.Forms.PictureBox pbxImagen;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox tbxCodigo;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.TextBox tbxDescripcion;
        private System.Windows.Forms.TextBox tbxMarca;
        private System.Windows.Forms.TextBox tbxCategoria;
        private System.Windows.Forms.TextBox tbxImagen;
        private System.Windows.Forms.TextBox tbxPrecio;
    }
}