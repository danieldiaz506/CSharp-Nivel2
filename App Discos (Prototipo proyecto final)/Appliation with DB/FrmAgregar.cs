using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Configuration;

namespace Appliation_with_DB
{
    public partial class FrmAgregar : Form
    {
        private Discos Disco = null;

        private OpenFileDialog Archivo = null;
        public FrmAgregar()
        {
            InitializeComponent();
        }
        public FrmAgregar(Discos disco)
        {
            InitializeComponent();
            this.Disco = disco;
            Text = "Modificar Disco";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Discos NuevoDisco = new Discos();
            DiscosNegocio negocio = new DiscosNegocio();
            try
            {
                if (Disco == null)
                {
                    Disco = new Discos();
                }
                Disco.Titulo = tbxTitulo.Text;
                Disco.FechaLanzamiento = DateTime.Parse(dtpFechaLanzamiento.Text);
                Disco.CantidadCanciones = int.Parse(tbxCantidadCanciones.Text);
                Disco.UrlImagenTapa = tbxUrlImagenTapa.Text;
                Disco.TipoEstilo = (Estilo)cbxEstilo.SelectedItem;
                Disco.TipoEdicion = (Edicion)cbxEdicion.SelectedItem;

                if (Disco.Id != 0)
                {
                    negocio.Modificar(Disco);
                    MessageBox.Show("Se ha modificado un disco exitosamente!");
                }
                else
                {
                    negocio.Agregar(Disco);
                    MessageBox.Show("Se ha agregado un disco exitosamente!");
                }
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo realizar la operación");
                this.Close();
            }
            if (Archivo != null && !(tbxUrlImagenTapa.Text.ToUpper().Contains("HTTP")))
            {
                File.Copy(Archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + Archivo.SafeFileName);
            }


        }

        private void FrmAgregar_Load(object sender, EventArgs e)
        {
            EdicionNegocio edicionNegocio = new EdicionNegocio();
            EstiloNegocio estiloNegocio = new EstiloNegocio();

            try
            {
                cbxEstilo.DataSource = estiloNegocio.Listar();
                cbxEstilo.ValueMember = "Id";
                cbxEstilo.DisplayMember = "Descripcion";
                cbxEdicion.DataSource = edicionNegocio.Listar();
                cbxEdicion.ValueMember = "Id";    
                cbxEdicion.DisplayMember = "Descripcion";

                if (Disco != null)
                {
                    tbxTitulo.Text = Disco.Titulo;
                    tbxCantidadCanciones.Text = Disco.CantidadCanciones.ToString(); 
                    tbxUrlImagenTapa.Text = Disco.UrlImagenTapa;
                    CargarImagen(Disco.UrlImagenTapa);
                    cbxEstilo.SelectedValue = Disco.TipoEstilo.Id;
                    cbxEdicion.SelectedValue = Disco.TipoEdicion.Id;
                }
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
                pbxPrecarga.Load(Imagen);
            }
            catch (Exception)
            {

                pbxPrecarga.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }
        }

        private void tbxUrlImagenTapa_Leave(object sender, EventArgs e)
        {
            CargarImagen(tbxUrlImagenTapa.Text);
        }

        private void btnAgregarLocal_Click(object sender, EventArgs e)
        {
            Archivo = new OpenFileDialog();
            Archivo.Title = "Guardar imagen local";
            Archivo.Filter = "jpg|*.jpg|png|*.png";
            if (Archivo.ShowDialog() == DialogResult.OK)
            {
                tbxUrlImagenTapa.Text = Archivo.FileName;
                CargarImagen(Archivo.FileName);
            }
        }
    }
}
