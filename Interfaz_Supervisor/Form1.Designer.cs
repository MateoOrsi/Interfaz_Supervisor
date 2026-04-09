namespace Interfaz_Supervisor
{
    partial class Interfaz_Supervisor
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cargarNuevaOTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planificarSemanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarLinksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revisarEstadoDeOTsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validarDatosIngresadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarNuevaOTToolStripMenuItem,
            this.planificarSemanaToolStripMenuItem,
            this.generarLinksToolStripMenuItem,
            this.revisarEstadoDeOTsToolStripMenuItem,
            this.validarDatosIngresadosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1191, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cargarNuevaOTToolStripMenuItem
            // 
            this.cargarNuevaOTToolStripMenuItem.Name = "cargarNuevaOTToolStripMenuItem";
            this.cargarNuevaOTToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.cargarNuevaOTToolStripMenuItem.Text = "Cargar nueva OT";
            this.cargarNuevaOTToolStripMenuItem.Click += new System.EventHandler(this.cargarNuevaOTToolStripMenuItem_Click);
            // 
            // planificarSemanaToolStripMenuItem
            // 
            this.planificarSemanaToolStripMenuItem.Name = "planificarSemanaToolStripMenuItem";
            this.planificarSemanaToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.planificarSemanaToolStripMenuItem.Text = "Planificar Semana";
            this.planificarSemanaToolStripMenuItem.Click += new System.EventHandler(this.planificarSemanaToolStripMenuItem_Click);
            // 
            // generarLinksToolStripMenuItem
            // 
            this.generarLinksToolStripMenuItem.Name = "generarLinksToolStripMenuItem";
            this.generarLinksToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.generarLinksToolStripMenuItem.Text = "Generar Links";
            this.generarLinksToolStripMenuItem.Click += new System.EventHandler(this.generarLinksToolStripMenuItem_Click);
            // 
            // revisarEstadoDeOTsToolStripMenuItem
            // 
            this.revisarEstadoDeOTsToolStripMenuItem.Name = "revisarEstadoDeOTsToolStripMenuItem";
            this.revisarEstadoDeOTsToolStripMenuItem.Size = new System.Drawing.Size(135, 20);
            this.revisarEstadoDeOTsToolStripMenuItem.Text = "Revisar Estado de OT\'s";
            this.revisarEstadoDeOTsToolStripMenuItem.Click += new System.EventHandler(this.revisarEstadoDeOTsToolStripMenuItem_Click);
            // 
            // validarDatosIngresadosToolStripMenuItem
            // 
            this.validarDatosIngresadosToolStripMenuItem.Name = "validarDatosIngresadosToolStripMenuItem";
            this.validarDatosIngresadosToolStripMenuItem.Size = new System.Drawing.Size(147, 20);
            this.validarDatosIngresadosToolStripMenuItem.Text = "Validar Datos Ingresados";
            this.validarDatosIngresadosToolStripMenuItem.Click += new System.EventHandler(this.validarDatosIngresadosToolStripMenuItem_Click);
            // 
            // Interfaz_Supervisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 683);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Interfaz_Supervisor";
            this.Text = "Interfaz Supervisor";
            this.Load += new System.EventHandler(this.Interfaz_Supervisor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cargarNuevaOTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planificarSemanaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarLinksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem revisarEstadoDeOTsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem validarDatosIngresadosToolStripMenuItem;
    }
}

