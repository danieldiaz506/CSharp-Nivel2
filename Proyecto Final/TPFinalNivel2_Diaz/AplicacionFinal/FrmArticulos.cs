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
    public partial class FrmArticulos : Form
    {
        private Articulo articulo = null;
        public FrmArticulos()
        {
            InitializeComponent();
            lblVistaPrevia.Text = "";
        }
        public FrmArticulos(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar";
            lblTitulo.Text = "Modificar artículo:";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CargarImagen(string Imagen)
        {
            try
            {
                pbxImagen.Load(Imagen);
                lblVistaPrevia.Text = "Vista previa";
            }
            catch (Exception)
            {
                pbxImagen.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
                lblVistaPrevia.Text = "";
            }
        }

        private void FrmArticulos_Load(object sender, EventArgs e)
        {
            MarcaNegocio NegocioMarca = new MarcaNegocio();  
            CategoriaNegocio NegocioCategoria = new CategoriaNegocio();
            try
            {
                cbxMarca.Items.Clear(); 
                cbxMarca.DataSource = NegocioMarca.ListaMarcas();
                cbxMarca.ValueMember = "Id";
                cbxMarca.DisplayMember = "Descripcion";
                cbxCategoria.Items.Clear();
                cbxCategoria.DataSource = NegocioCategoria.ListaCategorias();
                cbxCategoria.ValueMember = "Id";
                cbxCategoria.DisplayMember = "Descripcion";
                if (articulo != null)
                {
                    tbxCodigo.Text = articulo.Codigo;
                    tbxNombre.Text = articulo.Nombre;   
                    tbxDescripcion.Text = articulo.Descripcion; 
                    cbxMarca.SelectedValue = articulo.Marca.Id;
                    cbxCategoria.SelectedValue = articulo.Categoria.Id;
                    tbxImagen.Text = articulo.Imagen;
                    CargarImagen(articulo.Imagen);
                    tbxPrecio.Text = articulo.Precio.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tbxImagen_Leave(object sender, EventArgs e)
        {
            CargarImagen(tbxImagen.Text);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio Negocio = new ArticuloNegocio();    
            try
            {
                if (ValidarDatos())
                {
                    if (articulo == null)
                        articulo = new Articulo();

                    articulo.Codigo = tbxCodigo.Text;
                    articulo.Nombre = tbxNombre.Text;
                    articulo.Descripcion = tbxDescripcion.Text;
                    articulo.Marca = (Marca)cbxMarca.SelectedItem;
                    articulo.Categoria = (Categoria)cbxCategoria.SelectedItem;
                    articulo.Imagen = tbxImagen.Text;
                    articulo.Precio = decimal.Parse(tbxPrecio.Text);

                    if (articulo.Id != 0)
                    {
                        Negocio.Modificar(articulo);
                        MessageBox.Show("¡Se ha modificado el artículo exitosamente!");
                    }
                    else
                    {
                        Negocio.Agregar(articulo);
                        MessageBox.Show("¡Se ha agregado un artículo exitosamente!");
                    }
                    Close();
                }            
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo completar la acción.");
                this.Close();
            }
        }

        private void tbxPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                    e.Handled = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private bool ValidarDatos()
        {
            if (string.IsNullOrEmpty(tbxCodigo.Text) || string.IsNullOrEmpty(tbxNombre.Text) || string.IsNullOrEmpty(tbxDescripcion.Text) || string.IsNullOrEmpty(tbxImagen.Text) || string.IsNullOrEmpty(tbxPrecio.Text))
            {
                if (string.IsNullOrEmpty(tbxCodigo.Text))
                {
                    lblCodigo.ForeColor = Color.Red;    
                }
                else
                {
                    lblCodigo.ForeColor = Color.Black;
                }
                if (string.IsNullOrEmpty(tbxNombre.Text))
                {
                    lblNombre.ForeColor = Color.Red;
                }
                else
                {
                    lblNombre.ForeColor = Color.Black;
                }
                if (string.IsNullOrEmpty(tbxDescripcion.Text))
                {
                    lblDescripcion.ForeColor = Color.Red;
                }
                else
                {
                    lblDescripcion.ForeColor = Color.Black;
                }
                if (string.IsNullOrEmpty(tbxImagen.Text))
                {
                    lblImagen.ForeColor = Color.Red;
                }
                else
                {
                    lblImagen.ForeColor = Color.Black;
                }
                if (string.IsNullOrEmpty(tbxPrecio.Text))
                {
                    lblPrecio.ForeColor = Color.Red;
                }
                else
                {
                    lblPrecio.ForeColor = Color.Black;
                }
                MessageBox.Show("Por favor complete todos los campos (Señalados en color rojo).");
                return false;
            }
            return true;
        }
    }
}
