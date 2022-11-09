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
    public partial class frmEliminarDeportista : Form
    {
        public frmEliminarDeportista()
        {
            InitializeComponent();
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            string Codigo = txtCodigoDeportista.Text;
            clsDeportista Buscar = new clsDeportista();
            Buscar.Buscar(Codigo);

            if (Buscar.CDeportista != Codigo)
            {
                MessageBox.Show("El deportista no se encuentra en la base de datos");
            }
            else
            {
                lblCodigoDeportistaED.Text = Buscar.CDeportista;
                lblNombreED.Text = Buscar.Nombre;
                lblApellidoED.Text = Buscar.Apellido;
                lblDireccionED.Text = Buscar.Direccion;
                lblTelefonoED.Text = Convert.ToString(Buscar.Telefono);
                lblEdadED.Text = Convert.ToString(Buscar.Edad);
                lblDeporteED.Text = Convert.ToString(Buscar.Deportes);
            }
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            string CodigoDeportista = txtCodigoDeportista.Text;
            clsDeportista EliminarED = new clsDeportista();
            EliminarED.Eliminar(CodigoDeportista);

            Limpiar();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Limpiar()
        {
            //Limpia el todos los controladores
            lblCodigoDeportistaED.Text = "";
            lblNombreED.Text = "";
            lblApellidoED.Text = "";
            lblDireccionED.Text = "";
            lblTelefonoED.Text = "";
            lblEdadED.Text = "";
            lblDeporteED.Text = "";
        }

        private void Check()
        {
            if (lblCodigoDeportistaED.Text != "" & lblNombreED.Text != "" & lblApellidoED.Text != "" & lblDireccionED.Text != "" & lblTelefonoED.Text != "" & lblEdadED.Text != "" & lblDeporteED.Text != "")
            {
                cmdEliminar.Enabled = true;
            }
            else
            {
                cmdEliminar.Enabled = false;
            }
        }

        private void lblCodigoDeportistaED_Click(object sender, EventArgs e)
        {
            Check();
        }

        private void lblNombreED_Click(object sender, EventArgs e)
        {
            Check();
        }

        private void lblApellidoED_Click(object sender, EventArgs e)
        {
            Check();
        }

        private void lblDireccionED_Click(object sender, EventArgs e)
        {
            Check();
        }

        private void lblTelefonoED_Click(object sender, EventArgs e)
        {
            Check();
        }

        private void lblEdadED_Click(object sender, EventArgs e)
        {
            Check();
        }

        private void lblDeporteED_Click(object sender, EventArgs e)
        {
            Check();
        }
    }
}
