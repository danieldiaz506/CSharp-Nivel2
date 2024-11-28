using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Bienvenidos a C#."); 
            lblMensajeFinal.Text = "";
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            //MessageBox.Show("Chau Chau...");
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //this.BackColor = Color.Violet;
            //MouseEventArgs click = (MouseEventArgs)e;
            //if (click.Button == MouseButtons.Left)
            //    MessageBox.Show("Se presionó el botón izquierdo, ATENCIÓN!");
            //else if (click.Button == MouseButtons.Right)
            //    MessageBox.Show("Se presionó el botón derecho, ATENCIÓN!");
            //if (click.Button == MouseButtons.Middle)
            //    MessageBox.Show("Se presionó el botón del medio, ATENCIÓN!");
            tbxResultado.Text = "";
            if (tbxApellidos.Text == "")
            {
                tbxApellidos.BackColor = Color.IndianRed;
                lblMensajeFinal.Text = "Complete todo el formulario";
            }
            else
            {
                tbxApellidos.BackColor = System.Drawing.SystemColors.Control;
                lblMensajeFinal.Text = "";
            }
            if (tbxNombres.Text == "")
            {
                tbxNombres.BackColor = Color.IndianRed;
                lblMensajeFinal.Text = "Complete todo el formulario";
            }
            else
            {
                tbxNombres.BackColor = System.Drawing.SystemColors.Control;
                lblMensajeFinal.Text = "";
            }
            if (tbxEdad.Text == "")
            {
                tbxEdad.BackColor = Color.IndianRed;
                lblMensajeFinal.Text = "Complete todo el formulario";
            }
            else
            {
                tbxEdad.BackColor = System.Drawing.SystemColors.Control;
                lblMensajeFinal.Text = "";
            }
            if (tbxDireccion.Text == "")
            {
                tbxDireccion.BackColor = Color.IndianRed;
                lblMensajeFinal.Text = "Complete todo el formulario";
            }
            else
            {
                tbxDireccion.BackColor = System.Drawing.SystemColors.Control;
                lblMensajeFinal.Text = "";
            }
            if (tbxApellidos.Text == "" || tbxNombres.Text == "" || tbxEdad.Text == "" || tbxDireccion.Text == "")
            {
                lblMensajeFinal.Text = "Complete todo el formulario";
            }
            else
            {
                string NombreApellido = "Nombres y Apellidos: " + tbxNombres.Text + " " + tbxApellidos.Text;
                string Edad = ".Edad: " + tbxEdad.Text + ".";
                string Edad2 = Edad.Replace("." , "." + Environment.NewLine);
                string Direccion = "Dirección: " + tbxDireccion.Text + ".";
                string Direccion2 = Direccion.Replace("." , "." + Environment.NewLine);
                tbxResultado.Text = NombreApellido + Edad2 + Direccion2;
            }

                
            
        }
        //

        //private void lblApellidos_MouseLeave(object sender, EventArgs e)
        //{
        //    lblApellidos.BackColor = Color.LightBlue;
        //    lblApellidos.Cursor= Cursors.Arrow;
        //}

        //private void tbxApellidos_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    //if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
        //    //{
        //    //    e.Handled = true;
        //    //}

        //}

        //private void tbxNombres_Leave(object sender, EventArgs e)
        //{
        //    MessageBox.Show("Tiene " + tbxNombres.Text.Length + " caracteres.");
        //}

        private void tbxEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_MouseMove(object sender, MouseEventArgs e)
        {
            btnAceptar.BackColor = Color.LightBlue;
            btnAceptar.Cursor = Cursors.Hand;
        }

        private void btnCancelar_MouseMove(object sender, MouseEventArgs e)
        {
            btnCancelar.BackColor = Color.LightBlue;
            btnCancelar.Cursor = Cursors.Hand;
        }

        private void btnAceptar_MouseLeave(object sender, EventArgs e)
        {
            btnAceptar.BackColor = System.Drawing.SystemColors.Control;
            btnAceptar.Cursor = Cursors.Arrow;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbxApellidos.Text = "";
            tbxNombres.Text = "";
            tbxEdad.Text = "";
            tbxDireccion.Text = "";
            tbxResultado.Text = "";
            tbxApellidos.BackColor = System.Drawing.SystemColors.Control;
            tbxNombres.BackColor = System.Drawing.SystemColors.Control;
            tbxEdad.BackColor = System.Drawing.SystemColors.Control;
            tbxDireccion.BackColor = System.Drawing.SystemColors.Control;
        }

        private void btnCancelar_MouseLeave(object sender, EventArgs e)
        {
            btnCancelar.BackColor = System.Drawing.SystemColors.Control;
            btnCancelar.Cursor = Cursors.Arrow;
        }
    }
}
