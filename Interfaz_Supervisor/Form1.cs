using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cargar_nueva_ot;
using generar_links;
using planificar_semana;
using revisar_estado_ot;
using validar_datos_ingresados;
namespace Interfaz_Supervisor
{
    public partial class Interfaz_Supervisor : Form
    {
        public Interfaz_Supervisor()
        {
            InitializeComponent();
        }

        private void cargarNuevaOTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cargar_nueva_ot.Form1 frm = new cargar_nueva_ot.Form1();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void planificarSemanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            planificar_semana.Form1 frm = new planificar_semana.Form1();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void generarLinksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            generar_links.Form1 frm = new generar_links.Form1();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void revisarEstadoDeOTsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            revisar_estado_ot.Form1 frm = new revisar_estado_ot.Form1();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void validarDatosIngresadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            validar_datos_ingresados.Form1 frm = new validar_datos_ingresados.Form1();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void Interfaz_Supervisor_Load(object sender, EventArgs e)
        {

        }
    }
}
