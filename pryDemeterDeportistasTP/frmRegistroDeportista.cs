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
    public partial class frmRegistroDeportista : Form
    {
        public frmRegistroDeportista()
        {
            InitializeComponent();
        }

        private void cmdCargar_Click(object sender, EventArgs e)
        {
            //Llamo a la clase y al procedimiento AGREGAR
            //y la informacion con la que se llenen los campos
            //los datos cargados se almacenaran en la variable local
            //de la clase y posteriormente lo almacenara.
            clsDeportista Registro = new clsDeportista();
            Registro.CDeportista = txtCodigo.Text;
            Registro.Nombre = txtNombre.Text;
            Registro.Apellido = txtApellido.Text;
            Registro.Direccion = txtDireccion.Text;
            Registro.Telefono = Convert.ToInt32(mskTelefono.Text);
            Registro.Edad = Convert.ToInt32(mskEdad.Text);
            Registro.Deportes = Convert.ToString(lstDeporte.SelectedItem);
            Registro.Agregar();

            Limpiar();

            txtCodigo.Focus();
        }

        private void Limpiar()
        {
            //Limpia el todos los controladores
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
            mskTelefono.Text = "";
            mskEdad.Text = "";
            lstDeporte.SelectedIndex = -1;
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Con el procedimiento check controlo si los campos fueron rellenados antes de activar el boton
        private void Comprobar()
        {
            if (txtCodigo.Text != "" && txtNombre.Text != "" && txtApellido.Text != "" && txtDireccion.Text != "" && txtDireccion.Text != "" && mskTelefono.Text != "" && mskEdad.Text != "" && lstDeporte.SelectedIndex > -1)
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

        private void mskTelefono_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            Comprobar();
        }

        private void mskEdad_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            Comprobar();
        }

        private void lstDeporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            Comprobar();
        }

        private void frmRegistroDeportista_Load(object sender, EventArgs e)
        {
            cmdCargar.Enabled = false;
        }

        private void txtApellido_TextChanged_1(object sender, EventArgs e)
        {
            Comprobar();
          //hola commo andas
        }

        private void txtDireccion_TextChanged_1(object sender, EventArgs e)
        {
            Comprobar();
        }

        private void mskTelefono_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {
            Comprobar();
        }

        private void mskEdad_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {
            Comprobar();
        }

        private void txtNombre_TextChanged_1(object sender, EventArgs e)
        {
            Comprobar();
        }

        private void lstDeporte_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Comprobar();
        }
    }
}
