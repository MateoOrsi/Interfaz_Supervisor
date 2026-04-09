using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace cargar_nueva_ot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string conexion;

        private void btnSeleccionarBD_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Base de datos Access (*.accdb)|*.accdb";
            ofd.Title = "Seleccionar base de datos";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string ruta = ofd.FileName;

                conexion = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={ruta};";

                MessageBox.Show("Base de datos cargada correctamente");
            }
            CargarClientes();
            CargarUsuarios();
        }
        private void CargarClientes()
        {
            using (OleDbConnection conn = new OleDbConnection(conexion))
            {
                string query = "SELECT Cliente FROM Clientes";

                OleDbDataAdapter da = new OleDbDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbCliente.DataSource = dt;
                cmbCliente.DisplayMember = "Cliente";
                cmbCliente.ValueMember = "Cliente"; // mismo campo
            }
        }
        private void CargarUsuarios()
        {
            using (OleDbConnection conn = new OleDbConnection(conexion))
            {
                string query = "SELECT Usuario FROM Usuarios";

                OleDbDataAdapter da = new OleDbDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbUsuario.DataSource = dt;
                cmbUsuario.DisplayMember = "Usuario";
                cmbUsuario.ValueMember = "Usuario";
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbEstado.Items.Add("Pendiente");
            cmbEstado.Items.Add("En proceso");
            cmbEstado.Items.Add("Finalizado");

        
        }
        
        private void btnCargar_Click(object sender, EventArgs e)
        {
            // 🔸 Validación básica
            if (txtDescripcion.Text == "" || cmbCliente.SelectedIndex == -1 || cmbUsuario.SelectedIndex == -1)
            {
                MessageBox.Show("Complete los campos obligatorios");
                return;
            }
            if (string.IsNullOrEmpty(conexion))
            {
                MessageBox.Show("Primero seleccioná una base de datos");
                return;
            }
            string query = @"INSERT INTO [Gestion de OT] 
([Descripción de tarea], [Cliente], [Usuario], [Fecha de OT], [Estado]) 
VALUES (?, ?, ?, ?, ?)";

            using (OleDbConnection conn = new OleDbConnection(conexion))
            {
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Descripción de tarea", txtDescripcion.Text);
                    cmd.Parameters.AddWithValue("", cmbCliente.SelectedValue);
                    cmd.Parameters.AddWithValue("", cmbUsuario.SelectedValue);
                    cmd.Parameters.Add("@Fecha de OT", OleDbType.Date).Value = dtpFechaInicio.Value;
                    cmd.Parameters.AddWithValue("@Estado", cmbEstado.Text);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();

                        // 🔥 Obtener ID generado
                        cmd.CommandText = "SELECT @@IDENTITY";
                        int idOT = Convert.ToInt32(cmd.ExecuteScalar());

                        MessageBox.Show("OT creada correctamente. ID: " + idOT);

                        LimpiarFormulario();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al guardar: " + ex.Message);
                    }
                }
            }
        }

        void LimpiarFormulario()
        {
            txtDescripcion.Clear();
            cmbCliente.SelectedIndex = -1;
            cmbUsuario.SelectedIndex = -1;
            cmbEstado.SelectedIndex = -1;
        }
    }
}
