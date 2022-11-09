namespace pryDemeterDeportistasTP
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.MSPantallaDeInicio = new System.Windows.Forms.MenuStrip();
            this.TSMRegistro = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMRegistroDeportista = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMRegistroEntrenador = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMConsulta = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMConsultaDeportista = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMConsultaEntrenador = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMModificarDeportista = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMModificarEntrenadores = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMEliminarDeportista = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMEliminarEntrenadores = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.MSPantallaDeInicio.SuspendLayout();
            this.SuspendLayout();
            // 
            // MSPantallaDeInicio
            // 
            this.MSPantallaDeInicio.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMRegistro,
            this.TSMConsulta,
            this.TSMModificar,
            this.TSMEliminar,
            this.TSMSalir});
            this.MSPantallaDeInicio.Location = new System.Drawing.Point(0, 0);
            this.MSPantallaDeInicio.Name = "MSPantallaDeInicio";
            this.MSPantallaDeInicio.Size = new System.Drawing.Size(380, 24);
            this.MSPantallaDeInicio.TabIndex = 8;
            this.MSPantallaDeInicio.Text = "menuStrip1";
            // 
            // TSMRegistro
            // 
            this.TSMRegistro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMRegistroDeportista,
            this.TSMRegistroEntrenador});
            this.TSMRegistro.Name = "TSMRegistro";
            this.TSMRegistro.Size = new System.Drawing.Size(62, 20);
            this.TSMRegistro.Text = "Registro";
            // 
            // TSMRegistroDeportista
            // 
            this.TSMRegistroDeportista.Name = "TSMRegistroDeportista";
            this.TSMRegistroDeportista.Size = new System.Drawing.Size(180, 22);
            this.TSMRegistroDeportista.Text = "Deportista";
            this.TSMRegistroDeportista.Click += new System.EventHandler(this.TSMRegistroDeportista_Click);
            // 
            // TSMRegistroEntrenador
            // 
            this.TSMRegistroEntrenador.Name = "TSMRegistroEntrenador";
            this.TSMRegistroEntrenador.Size = new System.Drawing.Size(180, 22);
            this.TSMRegistroEntrenador.Text = "Entrenador";
            this.TSMRegistroEntrenador.Click += new System.EventHandler(this.TSMRegistroEntrenador_Click);
            // 
            // TSMConsulta
            // 
            this.TSMConsulta.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMConsultaDeportista,
            this.TSMConsultaEntrenador});
            this.TSMConsulta.Name = "TSMConsulta";
            this.TSMConsulta.Size = new System.Drawing.Size(66, 20);
            this.TSMConsulta.Text = "Consulta";
            // 
            // TSMConsultaDeportista
            // 
            this.TSMConsultaDeportista.Name = "TSMConsultaDeportista";
            this.TSMConsultaDeportista.Size = new System.Drawing.Size(180, 22);
            this.TSMConsultaDeportista.Text = "Deportista";
            this.TSMConsultaDeportista.Click += new System.EventHandler(this.TSMConsultaDeportista_Click);
            // 
            // TSMConsultaEntrenador
            // 
            this.TSMConsultaEntrenador.Name = "TSMConsultaEntrenador";
            this.TSMConsultaEntrenador.Size = new System.Drawing.Size(180, 22);
            this.TSMConsultaEntrenador.Text = "Entrenador";
            this.TSMConsultaEntrenador.Click += new System.EventHandler(this.TSMConsultaEntrenador_Click);
            // 
            // TSMModificar
            // 
            this.TSMModificar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMModificarDeportista,
            this.TSMModificarEntrenadores});
            this.TSMModificar.Name = "TSMModificar";
            this.TSMModificar.Size = new System.Drawing.Size(70, 20);
            this.TSMModificar.Text = "Modificar";
            // 
            // TSMModificarDeportista
            // 
            this.TSMModificarDeportista.Name = "TSMModificarDeportista";
            this.TSMModificarDeportista.Size = new System.Drawing.Size(180, 22);
            this.TSMModificarDeportista.Text = "Deportista";
            this.TSMModificarDeportista.Click += new System.EventHandler(this.TSMModificarDeportista_Click);
            // 
            // TSMModificarEntrenadores
            // 
            this.TSMModificarEntrenadores.Name = "TSMModificarEntrenadores";
            this.TSMModificarEntrenadores.Size = new System.Drawing.Size(180, 22);
            this.TSMModificarEntrenadores.Text = "Entrenadores";
            this.TSMModificarEntrenadores.Click += new System.EventHandler(this.TSMModificarEntrenadores_Click);
            // 
            // TSMEliminar
            // 
            this.TSMEliminar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMEliminarDeportista,
            this.TSMEliminarEntrenadores});
            this.TSMEliminar.Name = "TSMEliminar";
            this.TSMEliminar.Size = new System.Drawing.Size(62, 20);
            this.TSMEliminar.Text = "Eliminar";
            // 
            // TSMEliminarDeportista
            // 
            this.TSMEliminarDeportista.Name = "TSMEliminarDeportista";
            this.TSMEliminarDeportista.Size = new System.Drawing.Size(180, 22);
            this.TSMEliminarDeportista.Text = "Deportista";
            this.TSMEliminarDeportista.Click += new System.EventHandler(this.TSMEliminarDeportista_Click);
            // 
            // TSMEliminarEntrenadores
            // 
            this.TSMEliminarEntrenadores.Name = "TSMEliminarEntrenadores";
            this.TSMEliminarEntrenadores.Size = new System.Drawing.Size(180, 22);
            this.TSMEliminarEntrenadores.Text = "Entrenadores";
            this.TSMEliminarEntrenadores.Click += new System.EventHandler(this.TSMEliminarEntrenadores_Click);
            // 
            // TSMSalir
            // 
            this.TSMSalir.Name = "TSMSalir";
            this.TSMSalir.Size = new System.Drawing.Size(41, 20);
            this.TSMSalir.Text = "Salir";
            this.TSMSalir.Click += new System.EventHandler(this.TSMSalir_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 241);
            this.Controls.Add(this.MSPantallaDeInicio);
            this.Name = "frmPrincipal";
            this.Text = "Bienvenidos al Club";
            this.MSPantallaDeInicio.ResumeLayout(false);
            this.MSPantallaDeInicio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MSPantallaDeInicio;
        private System.Windows.Forms.ToolStripMenuItem TSMRegistro;
        private System.Windows.Forms.ToolStripMenuItem TSMRegistroDeportista;
        private System.Windows.Forms.ToolStripMenuItem TSMRegistroEntrenador;
        private System.Windows.Forms.ToolStripMenuItem TSMConsulta;
        private System.Windows.Forms.ToolStripMenuItem TSMConsultaDeportista;
        private System.Windows.Forms.ToolStripMenuItem TSMConsultaEntrenador;
        private System.Windows.Forms.ToolStripMenuItem TSMModificar;
        private System.Windows.Forms.ToolStripMenuItem TSMModificarDeportista;
        private System.Windows.Forms.ToolStripMenuItem TSMModificarEntrenadores;
        private System.Windows.Forms.ToolStripMenuItem TSMEliminar;
        private System.Windows.Forms.ToolStripMenuItem TSMEliminarDeportista;
        private System.Windows.Forms.ToolStripMenuItem TSMEliminarEntrenadores;
        private System.Windows.Forms.ToolStripMenuItem TSMSalir;
    }
}

