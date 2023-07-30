using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppWindows2
{
    public partial class formDatos : Form
    {
        public formDatos()
        {
            InitializeComponent();
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtApellido.Text == "") {
                txtApellido.BackColor = Color.Red;
                txtApellido.Text = "RELLENAR CAMPO";
            }
            else
            {
                txtApellido.BackColor = System.Drawing.SystemColors.Control;
            }
            if (txtNombre.Text == "")
            {
                txtNombre.BackColor = Color.Red;
                txtNombre.Text = "RELLENAR CAMPO";
            }
            else
            {
                txtNombre.BackColor = System.Drawing.SystemColors.Control;
            }
            if (txtEdad.Text == "")
            {
                txtEdad.BackColor = Color.Red;
                txtEdad.Text = "000";
            }
            else
            {
                txtEdad.BackColor = System.Drawing.SystemColors.Control;
            }
            if (txtDireccion.Text == "")
            {
                txtDireccion.BackColor = Color.Red;
                txtDireccion.Text = "RELLENAR CAMPO";
            }
            else
            {
                txtDireccion.BackColor = System.Drawing.SystemColors.Control;
            }
            txtResultado.Text = "Apellido y Nombre: " + txtApellido.Text + " " + txtNombre.Text + "\r\n" + "Edad: " + txtEdad.Text + "\r\n" + "Dirección: " + txtDireccion.Text ;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
