using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Appliation_with_DB
{
    public partial class FrmPrincipal : Form
    {
        private List<Discos> ListaDiscos;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            CargarTabla();
            cbxCampo.Items.Add("Id");
            cbxCampo.Items.Add("Título");
            cbxCampo.Items.Add("Tipo de estilo");
        }

        private void CargarTabla()
        {
            DiscosNegocio negocio = new DiscosNegocio();
            try
            {
                ListaDiscos = negocio.Listar();
                dgvDiscos.DataSource = ListaDiscos;
                OcultarColumnas();
                CargarImagen(ListaDiscos[0].UrlImagenTapa);
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
                pbxDiscos.Load(Imagen);
            }
            catch (Exception)
            {

                pbxDiscos.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }
        }

        private void dgvDiscos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDiscos.CurrentRow != null)
            {
                Discos Seleccionado = (Discos)dgvDiscos.CurrentRow.DataBoundItem;
                CargarImagen(Seleccionado.UrlImagenTapa);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregar Nuevo = new FrmAgregar();
            Nuevo.ShowDialog();
            CargarTabla();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Discos Seleccionado;
            Seleccionado = (Discos)dgvDiscos.CurrentRow.DataBoundItem;

            FrmAgregar Modificar = new FrmAgregar(Seleccionado);
            Modificar.ShowDialog();
            CargarTabla();
        }

        private void btnEliminarFisico_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void btnLogico_Click(object sender, EventArgs e)
        {
            Eliminar(true);
        }

        private void Eliminar(bool Logico = false)
        {
            DiscosNegocio negocio = new DiscosNegocio();
            Discos Seleccionado;
            try
            {
                DialogResult Respuesta = MessageBox.Show("¿Esta seguro que desea eliminar de forma permanente el disco seleccionado?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Respuesta == DialogResult.Yes)
                {
                    Seleccionado = (Discos)dgvDiscos.CurrentRow.DataBoundItem;
                    if (Logico)
                    {
                        negocio.EliminarLogico(Seleccionado.Id);
                    }
                    else
                    {
                        negocio.EliminarFisico(Seleccionado.Id);
                    }

                    CargarTabla();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            DiscosNegocio Negocio = new DiscosNegocio();            
            if (cbxCampo.SelectedItem != null && cbxCriterio.SelectedItem != null && tbxFiltroAvanzado.Text != "")
            {
                string Campo = cbxCampo.SelectedItem.ToString();
                string Criterio = cbxCriterio.SelectedItem.ToString();
                string Filtro = tbxFiltroAvanzado.Text;
                dgvDiscos.DataSource = Negocio.Filtrar(Campo, Criterio, Filtro);
            }else if (cbxCampo.SelectedItem != null && cbxCriterio.SelectedItem != null)
            {
                if (cbxCampo.SelectedItem.ToString() == "Tipo de estilo")
                {
                    string Campo = cbxCampo.SelectedItem.ToString();
                    string Criterio = cbxCriterio.SelectedItem.ToString();
                    string Filtro = tbxFiltroAvanzado.Text;
                    dgvDiscos.DataSource = Negocio.Filtrar(Campo, Criterio, Filtro);
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

        private void OcultarColumnas()
        {
            dgvDiscos.Columns["UrlImagenTapa"].Visible = false;
            dgvDiscos.Columns["Id"].Visible = false;
        }

        private void tbxFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Discos> ListaFiltrada;
            string filtro = tbxFiltroRapido.Text;
            if (filtro.Length >= 2)
            {
                ListaFiltrada = ListaDiscos.FindAll(x => x.Titulo.ToUpper().Contains(filtro.ToUpper()) || x.TipoEstilo.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                ListaFiltrada = ListaDiscos;
            }
            dgvDiscos.DataSource = null;
            dgvDiscos.DataSource = ListaFiltrada;
            OcultarColumnas();
        }

        private void cbxCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Opcion = cbxCampo.SelectedItem.ToString();
            if (Opcion == "Id")
            {
                tbxFiltroAvanzado.Enabled = true;
                cbxCriterio.Items.Clear();
                cbxCriterio.Items.Add("Mayor que");
                cbxCriterio.Items.Add("Menor que");
                cbxCriterio.Items.Add("Igual a");
            } else if (Opcion == "Título")
            {
                tbxFiltroAvanzado.Enabled = true;
                cbxCriterio.Items.Clear();
                cbxCriterio.Items.Add("Empieza por");
                cbxCriterio.Items.Add("Termina por");
                cbxCriterio.Items.Add("Contiene a");
            }
            else
            {
                tbxFiltroAvanzado.Enabled = false;
                cbxCriterio.Items.Clear();
                cbxCriterio.Items.Add("Pop");
                cbxCriterio.Items.Add("Rock");
                cbxCriterio.Items.Add("Trap");
                cbxCriterio.Items.Add("Salsa");
                cbxCriterio.Items.Add("Grunge");
                cbxCriterio.Items.Add("Pop punk");
                cbxCriterio.Items.Add("Reggaeton");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            CargarTabla();
        }

        private void tbxFiltroAvanzado_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
