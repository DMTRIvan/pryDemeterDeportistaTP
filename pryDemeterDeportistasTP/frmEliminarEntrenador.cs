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
    public partial class frmEliminarEntrenador : Form
    {
        public frmEliminarEntrenador()
        {
            InitializeComponent();
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            string Codigo = txtCodigo.Text;
            clsEntrenador Buscar = new clsEntrenador();
            Buscar.Buscar(Codigo);

            if (Buscar.CEntrenador != Codigo)
            {
                MessageBox.Show("El entrenador no se encuentra en la base de datos");
            }
            else
            {
                lblNombreEE.Text = Buscar.Nombre;
                lblApellidoEE.Text = Buscar.Apellido;
                lblDireccionEE.Text = Buscar.Direccion;
                lblProvinciaEE.Text = Buscar.Prov;
                lblDeporteEE.Text = Convert.ToString(Buscar.Deportes);
            }
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            string CodigoEntrenadores = txtCodigo.Text;
            clsEntrenador Eliminar = new clsEntrenador();
            Eliminar.Eliminar(CodigoEntrenadores);

            Limpiar();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Limpiar()
        {
            //Limpia el todos los controladores
            txtCodigo.Text = "";
            lblNombreEE.Text = "";
            lblApellidoEE.Text = "";
            lblDireccionEE.Text = "";
            lblProvinciaEE.Text = "";
            lblDeporteEE.Text = "";
        }

        private void Check()
        {
            if (lblNombreEE.Text != "" & lblApellidoEE.Text != "" & lblDireccionEE.Text != "" & lblProvinciaEE.Text != "" & lblDeporteEE.Text != "")
            {
                cmdEliminar.Enabled = true;
            }
            else
            {
                cmdEliminar.Enabled = false;
            }
        }

        private void lblCodigoEntrenadorEE_Click(object sender, EventArgs e)
        {
            Check();
        }

        private void lblNombreEE_Click(object sender, EventArgs e)
        {
            Check();
        }

        private void lblApellidoEE_Click(object sender, EventArgs e)
        {
            Check();
        }

        private void lblDireccionEE_Click(object sender, EventArgs e)
        {
            Check();
        }

        private void lblProvinciaEE_Click(object sender, EventArgs e)
        {
            Check();
        }

        private void lblDeporteEE_Click(object sender, EventArgs e)
        {
            Check();
        }
    }
}
