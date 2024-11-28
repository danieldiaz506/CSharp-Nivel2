namespace WindowsForms
{
    partial class frmPrincipal
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.tbxApellidos = new System.Windows.Forms.TextBox();
            this.tbxNombres = new System.Windows.Forms.TextBox();
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.tbxEdad = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.tbxDireccion = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.tbxResultado = new System.Windows.Forms.TextBox();
            this.lblMensajeFinal = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAceptar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(148, 432);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(88, 30);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            this.btnAceptar.MouseLeave += new System.EventHandler(this.btnAceptar_MouseLeave);
            this.btnAceptar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnAceptar_MouseMove);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(320, 432);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(105, 30);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            this.btnCancelar.MouseLeave += new System.EventHandler(this.btnCancelar_MouseLeave);
            this.btnCancelar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnCancelar_MouseMove);
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(40, 40);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(95, 22);
            this.lblApellidos.TabIndex = 2;
            this.lblApellidos.Text = "Apellidos:";
            // 
            // tbxApellidos
            // 
            this.tbxApellidos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxApellidos.Location = new System.Drawing.Point(178, 37);
            this.tbxApellidos.MaxLength = 50;
            this.tbxApellidos.Name = "tbxApellidos";
            this.tbxApellidos.Size = new System.Drawing.Size(296, 30);
            this.tbxApellidos.TabIndex = 3;
            // 
            // tbxNombres
            // 
            this.tbxNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxNombres.Location = new System.Drawing.Point(178, 82);
            this.tbxNombres.MaxLength = 50;
            this.tbxNombres.Multiline = true;
            this.tbxNombres.Name = "tbxNombres";
            this.tbxNombres.Size = new System.Drawing.Size(296, 22);
            this.tbxNombres.TabIndex = 4;
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Location = new System.Drawing.Point(47, 82);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(88, 22);
            this.lblNombres.TabIndex = 5;
            this.lblNombres.Text = "Nombres:";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(78, 131);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(57, 22);
            this.lblEdad.TabIndex = 7;
            this.lblEdad.Text = "Edad:";
            // 
            // tbxEdad
            // 
            this.tbxEdad.Location = new System.Drawing.Point(178, 123);
            this.tbxEdad.MaxLength = 3;
            this.tbxEdad.Name = "tbxEdad";
            this.tbxEdad.Size = new System.Drawing.Size(77, 30);
            this.tbxEdad.TabIndex = 8;
            this.tbxEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxEdad_KeyPress);
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(47, 173);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(95, 22);
            this.lblDireccion.TabIndex = 9;
            this.lblDireccion.Text = "Dirección:";
            // 
            // tbxDireccion
            // 
            this.tbxDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxDireccion.Location = new System.Drawing.Point(178, 172);
            this.tbxDireccion.MaxLength = 200;
            this.tbxDireccion.Name = "tbxDireccion";
            this.tbxDireccion.Size = new System.Drawing.Size(296, 30);
            this.tbxDireccion.TabIndex = 10;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(22, 239);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(89, 22);
            this.lblResultado.TabIndex = 11;
            this.lblResultado.Text = "Resultado";
            // 
            // tbxResultado
            // 
            this.tbxResultado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxResultado.Location = new System.Drawing.Point(44, 274);
            this.tbxResultado.Multiline = true;
            this.tbxResultado.Name = "tbxResultado";
            this.tbxResultado.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbxResultado.Size = new System.Drawing.Size(449, 140);
            this.tbxResultado.TabIndex = 12;
            // 
            // lblMensajeFinal
            // 
            this.lblMensajeFinal.AutoSize = true;
            this.lblMensajeFinal.Location = new System.Drawing.Point(190, 477);
            this.lblMensajeFinal.Name = "lblMensajeFinal";
            this.lblMensajeFinal.Size = new System.Drawing.Size(235, 22);
            this.lblMensajeFinal.TabIndex = 13;
            this.lblMensajeFinal.Text = "Complete todo el formulario";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.White;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpiar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(364, 219);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(110, 29);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(577, 518);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblMensajeFinal);
            this.Controls.Add(this.tbxResultado);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.tbxDireccion);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.tbxEdad);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblNombres);
            this.Controls.Add(this.tbxNombres);
            this.Controls.Add(this.tbxApellidos);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos Personales";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.TextBox tbxApellidos;
        private System.Windows.Forms.TextBox tbxNombres;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox tbxEdad;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox tbxDireccion;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox tbxResultado;
        private System.Windows.Forms.Label lblMensajeFinal;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

