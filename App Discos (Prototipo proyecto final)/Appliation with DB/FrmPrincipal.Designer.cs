namespace Appliation_with_DB
{
    partial class FrmPrincipal
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
            this.dgvDiscos = new System.Windows.Forms.DataGridView();
            this.pbxDiscos = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminarFisico = new System.Windows.Forms.Button();
            this.btnLogico = new System.Windows.Forms.Button();
            this.tbxFiltroRapido = new System.Windows.Forms.TextBox();
            this.lblFiltroRapido = new System.Windows.Forms.Label();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.lblFiltroTitulo = new System.Windows.Forms.Label();
            this.cbxCampo = new System.Windows.Forms.ComboBox();
            this.lblCampo = new System.Windows.Forms.Label();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.cbxCriterio = new System.Windows.Forms.ComboBox();
            this.lblFiltroAvanzado = new System.Windows.Forms.Label();
            this.tbxFiltroAvanzado = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDiscos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDiscos
            // 
            this.dgvDiscos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiscos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDiscos.Location = new System.Drawing.Point(24, 115);
            this.dgvDiscos.MultiSelect = false;
            this.dgvDiscos.Name = "dgvDiscos";
            this.dgvDiscos.RowHeadersWidth = 51;
            this.dgvDiscos.RowTemplate.Height = 24;
            this.dgvDiscos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiscos.Size = new System.Drawing.Size(705, 241);
            this.dgvDiscos.TabIndex = 0;
            this.dgvDiscos.SelectionChanged += new System.EventHandler(this.dgvDiscos_SelectionChanged);
            // 
            // pbxDiscos
            // 
            this.pbxDiscos.Location = new System.Drawing.Point(762, 115);
            this.pbxDiscos.Name = "pbxDiscos";
            this.pbxDiscos.Size = new System.Drawing.Size(261, 241);
            this.pbxDiscos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxDiscos.TabIndex = 1;
            this.pbxDiscos.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(24, 382);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(156, 34);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(209, 382);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(156, 34);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminarFisico
            // 
            this.btnEliminarFisico.Location = new System.Drawing.Point(386, 382);
            this.btnEliminarFisico.Name = "btnEliminarFisico";
            this.btnEliminarFisico.Size = new System.Drawing.Size(156, 34);
            this.btnEliminarFisico.TabIndex = 4;
            this.btnEliminarFisico.Text = "Eliminar físico";
            this.btnEliminarFisico.UseVisualStyleBackColor = true;
            this.btnEliminarFisico.Click += new System.EventHandler(this.btnEliminarFisico_Click);
            // 
            // btnLogico
            // 
            this.btnLogico.Location = new System.Drawing.Point(573, 382);
            this.btnLogico.Name = "btnLogico";
            this.btnLogico.Size = new System.Drawing.Size(156, 34);
            this.btnLogico.TabIndex = 5;
            this.btnLogico.Text = "Eliminar Lógico";
            this.btnLogico.UseVisualStyleBackColor = true;
            this.btnLogico.Click += new System.EventHandler(this.btnLogico_Click);
            // 
            // tbxFiltroRapido
            // 
            this.tbxFiltroRapido.Location = new System.Drawing.Point(108, 53);
            this.tbxFiltroRapido.Name = "tbxFiltroRapido";
            this.tbxFiltroRapido.Size = new System.Drawing.Size(280, 22);
            this.tbxFiltroRapido.TabIndex = 6;
            this.tbxFiltroRapido.TextChanged += new System.EventHandler(this.tbxFiltro_TextChanged);
            // 
            // lblFiltroRapido
            // 
            this.lblFiltroRapido.AutoSize = true;
            this.lblFiltroRapido.Location = new System.Drawing.Point(21, 53);
            this.lblFiltroRapido.Name = "lblFiltroRapido";
            this.lblFiltroRapido.Size = new System.Drawing.Size(81, 16);
            this.lblFiltroRapido.TabIndex = 7;
            this.lblFiltroRapido.Text = "Filtro rápido:";
            // 
            // btnFiltro
            // 
            this.btnFiltro.Location = new System.Drawing.Point(762, 469);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(156, 34);
            this.btnFiltro.TabIndex = 8;
            this.btnFiltro.Text = "Buscar";
            this.btnFiltro.UseVisualStyleBackColor = true;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // lblFiltroTitulo
            // 
            this.lblFiltroTitulo.AutoSize = true;
            this.lblFiltroTitulo.Location = new System.Drawing.Point(27, 434);
            this.lblFiltroTitulo.Name = "lblFiltroTitulo";
            this.lblFiltroTitulo.Size = new System.Drawing.Size(217, 16);
            this.lblFiltroTitulo.TabIndex = 9;
            this.lblFiltroTitulo.Text = "Filtro avanzado a la base de datos:";
            // 
            // cbxCampo
            // 
            this.cbxCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCampo.FormattingEnabled = true;
            this.cbxCampo.Location = new System.Drawing.Point(92, 475);
            this.cbxCampo.Name = "cbxCampo";
            this.cbxCampo.Size = new System.Drawing.Size(121, 24);
            this.cbxCampo.TabIndex = 10;
            this.cbxCampo.SelectedIndexChanged += new System.EventHandler(this.cbxCampo_SelectedIndexChanged);
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(27, 475);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(51, 16);
            this.lblCampo.TabIndex = 11;
            this.lblCampo.Text = "Campo";
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(249, 475);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(49, 16);
            this.lblCriterio.TabIndex = 12;
            this.lblCriterio.Text = "Criterio";
            // 
            // cbxCriterio
            // 
            this.cbxCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCriterio.FormattingEnabled = true;
            this.cbxCriterio.Location = new System.Drawing.Point(322, 475);
            this.cbxCriterio.Name = "cbxCriterio";
            this.cbxCriterio.Size = new System.Drawing.Size(121, 24);
            this.cbxCriterio.TabIndex = 13;
            // 
            // lblFiltroAvanzado
            // 
            this.lblFiltroAvanzado.AutoSize = true;
            this.lblFiltroAvanzado.Location = new System.Drawing.Point(498, 475);
            this.lblFiltroAvanzado.Name = "lblFiltroAvanzado";
            this.lblFiltroAvanzado.Size = new System.Drawing.Size(39, 16);
            this.lblFiltroAvanzado.TabIndex = 14;
            this.lblFiltroAvanzado.Text = "Filtro:";
            // 
            // tbxFiltroAvanzado
            // 
            this.tbxFiltroAvanzado.Location = new System.Drawing.Point(561, 475);
            this.tbxFiltroAvanzado.Name = "tbxFiltroAvanzado";
            this.tbxFiltroAvanzado.Size = new System.Drawing.Size(121, 22);
            this.tbxFiltroAvanzado.TabIndex = 15;
            this.tbxFiltroAvanzado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxFiltroAvanzado_KeyPress);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(642, 61);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(86, 27);
            this.btnRefresh.TabIndex = 16;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 528);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.tbxFiltroAvanzado);
            this.Controls.Add(this.lblFiltroAvanzado);
            this.Controls.Add(this.cbxCriterio);
            this.Controls.Add(this.lblCriterio);
            this.Controls.Add(this.lblCampo);
            this.Controls.Add(this.cbxCampo);
            this.Controls.Add(this.lblFiltroTitulo);
            this.Controls.Add(this.btnFiltro);
            this.Controls.Add(this.lblFiltroRapido);
            this.Controls.Add(this.tbxFiltroRapido);
            this.Controls.Add(this.btnLogico);
            this.Controls.Add(this.btnEliminarFisico);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pbxDiscos);
            this.Controls.Add(this.dgvDiscos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App DB";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDiscos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDiscos;
        private System.Windows.Forms.PictureBox pbxDiscos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminarFisico;
        private System.Windows.Forms.Button btnLogico;
        private System.Windows.Forms.TextBox tbxFiltroRapido;
        private System.Windows.Forms.Label lblFiltroRapido;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.Label lblFiltroTitulo;
        private System.Windows.Forms.ComboBox cbxCampo;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.ComboBox cbxCriterio;
        private System.Windows.Forms.Label lblFiltroAvanzado;
        private System.Windows.Forms.TextBox tbxFiltroAvanzado;
        private System.Windows.Forms.Button btnRefresh;
    }
}

