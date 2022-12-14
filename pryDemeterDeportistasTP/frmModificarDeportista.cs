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
    public partial class frmModificarDeportista : Form
    {
        public frmModificarDeportista()
        {
            InitializeComponent();
        }

        private void frmModificarDeportista_Load(object sender, EventArgs e)
        {

        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            string Codigo = txtCodigo.Text;
            clsDeportista Buscar = new clsDeportista();
            Buscar.Buscar(Codigo);

            if (Buscar.CDeportista != Codigo)
            {
                MessageBox.Show("El deportista no se encuentra en la base de datos");
            }
            else
            {
                txtNombre.Text = Buscar.Nombre;
                txtApellido.Text = Buscar.Apellido;
                txtDireccion.Text = Buscar.Direccion;
                mskTelefono.Text = Convert.ToString(Buscar.Telefono);
                mskEdad.Text = Convert.ToString(Buscar.Edad);
                lstDeporte.Text = Convert.ToString(Buscar.Deportes);
            }
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            string CDeportista = txtCodigo.Text;
            clsDeportista Modificar = new clsDeportista();
            Modificar.Nombre = txtNombre.Text;
            Modificar.Apellido = txtApellido.Text;
            Modificar.Direccion = Convert.ToString(txtDireccion.Text);
            Modificar.Telefono = Convert.ToInt32(mskTelefono.Text);
            Modificar.Edad = Convert.ToInt32(mskEdad.Text);
            Modificar.Deportes = Convert.ToString(lstDeporte.SelectedItem);
            Modificar.Modificar(CDeportista);

            Limpiar();
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

        private void Check()
        {
            if (txtCodigo.Text != "" & txtNombre.Text != "" & txtApellido.Text != "" & txtDireccion.Text != "" & txtDireccion.Text != "" & mskTelefono.Text != "" & mskEdad.Text != "" & lstDeporte.SelectedIndex > -1)
            {
                cmdGuardar.Enabled = true;
            }
            else
            {
                cmdGuardar.Enabled = false;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void mskTelefono_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            Check();
        }

        private void mskEdad_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            Check();
        }

        private void lstDeporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            Check();
        }
    }
}
