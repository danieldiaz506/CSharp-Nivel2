using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace AplicacionFinal
{
    public partial class FrmPrincipal : Form
    {
        private List<Articulo> ListaArticulos;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            cbxCampo.Items.Clear();
            cbxCampo.Items.Add("Id");
            cbxCampo.Items.Add("Código");
            cbxCampo.Items.Add("Nombre");
            cbxCampo.Items.Add("Marca");
            cbxCampo.Items.Add("Categoría");
            CargarTabla();
        }

        private void CargarTabla()
        {
            ArticuloNegocio Negocio = new ArticuloNegocio();
            try
            {
                ListaArticulos = Negocio.Listar();
                dgvArticulos.DataSource = ListaArticulos;
                CargarImagen(ListaArticulos[0].Imagen);
                TableDesign();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void TableDesign()
        {
            try
            {
                dgvArticulos.Columns["Imagen"].Visible = false;
                dgvArticulos.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvArticulos.Columns["Codigo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvArticulos.Columns["Nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvArticulos.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvArticulos.Columns["Marca"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvArticulos.Columns["Categoria"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvArticulos.Columns["Precio"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void CargarImagen(string Imagen)
        {
            try
            {
                pbxPrincipal.Load(Imagen);
            }
            catch (Exception)
            {
                pbxPrincipal.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                Articulo Seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                CargarImagen(Seleccionado.Imagen);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmArticulos FrmAgregar = new FrmArticulos();
                FrmAgregar.ShowDialog();
                CargarTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Articulo Seleccionado;
                Seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                FrmArticulos FrmModificar = new FrmArticulos(Seleccionado);
                FrmModificar.ShowDialog();
                CargarTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void Eliminar()
        {
            Articulo Seleccionado;
            ArticuloNegocio Negocio = new ArticuloNegocio();
            try
            {
                DialogResult Resultado = MessageBox.Show("¿Desea eliminar este artículo de forma permanente?(No se podrá recuperar)", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Resultado == DialogResult.Yes)
                {
                    Seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    Negocio.Eliminar(Seleccionado.Id);
                    CargarTabla();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {    
            try
            {
                Articulo Seleccionado;
                Seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                FrmDetalle Detalle = new FrmDetalle(Seleccionado);
                Detalle.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarTabla();
        }

        private void tbxFiltroRapido_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> ListaFiltrada;
            string Filtro = tbxFiltroRapido.Text;
            try
            {
                if (Filtro.Length >=2)
                {
                    ListaFiltrada = ListaArticulos.FindAll(x => x.Codigo.ToUpper().Contains(Filtro.ToUpper()) || x.Nombre.ToUpper().Contains(Filtro.ToUpper()));                   
                }
                else
                {
                    ListaFiltrada = ListaArticulos;
                }
                dgvArticulos.DataSource = null;
                dgvArticulos.DataSource = ListaFiltrada;
                TableDesign();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cbxCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string Opcion = cbxCampo.SelectedItem.ToString();
                if (Opcion == "Id")
                {
                    tbxFiltroAvanzado.Enabled = true;
                    tbxFiltroAvanzado.Text = "";
                    cbxCriterio.Enabled = true;
                    cbxCriterio.Items.Clear();
                    cbxCriterio.Items.Add("Mayor a");
                    cbxCriterio.Items.Add("Menor a");
                    cbxCriterio.Items.Add("Igual a");
                }else if (Opcion == "Código")
                {
                    tbxFiltroAvanzado.Enabled = true;
                    tbxFiltroAvanzado.Text = "";
                    cbxCriterio.Items.Clear();
                    cbxCriterio.Enabled = false;
                }else if (Opcion == "Nombre")
                {
                    tbxFiltroAvanzado.Enabled = true;
                    tbxFiltroAvanzado.Text = "";
                    cbxCriterio.Enabled = true;
                    cbxCriterio.Items.Clear();
                    cbxCriterio.Items.Add("Empieza con");
                    cbxCriterio.Items.Add("Termina con");
                    cbxCriterio.Items.Add("Contiene a");
                }else if (Opcion == "Marca")
                { 
                    tbxFiltroAvanzado.Enabled = false;
                    tbxFiltroAvanzado.Text = "";
                    cbxCriterio.Enabled = true;
                    cbxCriterio.Items.Clear();
                    cbxCriterio.Items.Add("Samsung");
                    cbxCriterio.Items.Add("Apple");
                    cbxCriterio.Items.Add("Sony");
                    cbxCriterio.Items.Add("Huawei");
                    cbxCriterio.Items.Add("Motorola");
                }
                else
                {
                    tbxFiltroAvanzado.Enabled = false;
                    tbxFiltroAvanzado.Text = "";
                    cbxCriterio.Enabled = true;
                    cbxCriterio.Items.Clear();
                    cbxCriterio.Items.Add("Celulares");
                    cbxCriterio.Items.Add("Televisores");
                    cbxCriterio.Items.Add("Media");
                    cbxCriterio.Items.Add("Audio");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio Negocio = new ArticuloNegocio();
            try
            {
                if (cbxCampo.SelectedItem != null)
                {
                    if (cbxCampo.SelectedItem.ToString() == "Código" && tbxFiltroAvanzado.Text != "")
                    {
                        string Campo = cbxCampo.SelectedItem.ToString();
                        string Criterio = "";
                        string Filtro = tbxFiltroAvanzado.Text;
                        dgvArticulos.DataSource = Negocio.FiltroAvanzado(Campo, Criterio, Filtro);
                    }
                    else if (cbxCampo.SelectedItem != null && cbxCriterio.SelectedItem != null && tbxFiltroAvanzado.Text != "")
                    {
                        string Campo = cbxCampo.SelectedItem.ToString();
                        string Criterio = cbxCriterio.SelectedItem.ToString();
                        string Filtro = tbxFiltroAvanzado.Text;
                        dgvArticulos.DataSource = Negocio.FiltroAvanzado(Campo, Criterio, Filtro);
                    }
                    else if (cbxCampo.SelectedItem != null && cbxCriterio.SelectedItem != null)
                    {
                        if (cbxCampo.SelectedItem.ToString() == "Marca" || cbxCampo.SelectedItem.ToString() == "Categoría")
                        {
                            string Campo = cbxCampo.SelectedItem.ToString();
                            string Criterio = cbxCriterio.SelectedItem.ToString();
                            string Filtro = tbxFiltroAvanzado.Text;
                            dgvArticulos.DataSource = Negocio.FiltroAvanzado(Campo, Criterio, Filtro);
                        }
                        else
                        {
                            MessageBox.Show("¡Por favor complete todos los campos!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        MessageBox.Show("¡Por favor complete todos los campos!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("¡Por favor complete todos los campos!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tbxFiltroAvanzado_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (cbxCampo.SelectedItem != null)
                {
                    if (cbxCampo.SelectedItem.ToString() == "Id")
                    {
                        if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                            e.Handled = true;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void TimerFechayHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }
    }
}
