using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionFinal
{
    public partial class FrmDetalle : Form
    {
        private Articulo Detalle = null;
        public FrmDetalle(Articulo Detalle)
        {
            InitializeComponent();
            this.Detalle = Detalle;
            Text = "Detalles de artículo";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmDetalle_Load(object sender, EventArgs e)
        {
            try
            {
                lblArticulo.Text = Detalle.Nombre;
                tbxCodigo.Text = Detalle.Codigo;
                tbxNombre.Text = Detalle.Nombre;
                tbxDescripcion.Text = Detalle.Descripcion;
                tbxMarca.Text = Detalle.Marca.Descripcion;
                tbxCategoria.Text = Detalle.Categoria.Descripcion;
                CargarImagen(Detalle.Imagen);
                tbxImagen.Text = Detalle.Imagen;
                tbxPrecio.Text = Detalle.Precio.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Ups! Ocurrió un error inesperado :(");
            }
        }

        private void CargarImagen(string Imagen)
        {
            try
            {
                pbxImagen.Load(Imagen);
            }
            catch (Exception)
            {
                pbxImagen.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }
        }
    }
}
