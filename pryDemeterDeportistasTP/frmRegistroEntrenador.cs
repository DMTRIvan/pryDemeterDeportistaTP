using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryDemeterDeportistasTP
{
    public partial class frmRegistroEntrenador : Form
    {
        public frmRegistroEntrenador()
        {
            InitializeComponent();
        }

        private void cmdCargar_Click(object sender, EventArgs e)
        {
            clsEntrenador Registro = new clsEntrenador();
            Registro.CEntrenador = txtCodigo.Text;
            Registro.Nombre = txtNombre.Text;
            Registro.Apellido = txtApellido.Text;
            Registro.Direccion = txtDireccion.Text;
            Registro.Prov = txtProvincia.Text;
            Registro.Deportes = Convert.ToString(lstDeporte.SelectedItem);
            Registro.Agregar();
            Limpiar();

            txtCodigo.Focus();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Limpiar()
        {
            //Limpia el todos los controladores
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
            txtProvincia.Text = "";
            lstDeporte.SelectedIndex = -1;
        }

        //Con el procedimiento check controlo si los campos fueron rellenados antes de activar el boton
        private void Comprobar()
        {
            if (txtCodigo.Text != "" & txtNombre.Text != "" & txtApellido.Text != "" & txtDireccion.Text != "" & txtDireccion.Text != "" & txtProvincia.Text != "" & lstDeporte.SelectedIndex > -1)
            {
                cmdCargar.Enabled = true;
            }
            else
            {
                cmdCargar.Enabled = false;
            }
        }


        

        //Una vez se llenen los campos el boton de guardar se activa
        //en caso contrario, no se habilita
        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            Comprobar();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            Comprobar();
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            Comprobar();
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            Comprobar();
        }

        private void txtProvincia_TextChanged(object sender, EventArgs e)
        {
            Comprobar();
        }

        private void lstDeporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            Comprobar();
        }

        private void txtCodigo_TextChanged_1(object sender, EventArgs e)
        {
            Comprobar();
        }

        private void txtNombre_TextChanged_1(object sender, EventArgs e)
        {
            Comprobar();
        }

        private void txtApellido_TextChanged_1(object sender, EventArgs e)
        {
            Comprobar();
        }

        private void txtDireccion_TextChanged_1(object sender, EventArgs e)
        {
            Comprobar();
        }

        private void txtProvincia_TextChanged_1(object sender, EventArgs e)
        {
            Comprobar();
        }

        private void lstDeporte_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Comprobar();
        }
    }
}
