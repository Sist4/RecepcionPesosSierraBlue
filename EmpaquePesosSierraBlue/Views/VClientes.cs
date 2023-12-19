using EmpaquePesosSierraBlue.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpaquePesosSierraBlue.Views
{
    public partial class VClientes : Form
    {
        ClienteController controlador;
        public VClientes()
        {
            InitializeComponent();
            controlador = new ClienteController(dtgClientes);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                controlador.AgregarCliente(txtNombre.Text);
                LimpiarComponentes();
            }
            catch (Exception ex)
            {
                
            }
        }

        private void VClientes_Load(object sender, EventArgs e)
        {
            try
            {
                controlador.InicializarClientes();
                controlador.MostrarClientes();
            }catch(Exception ex)
            {
                MessageBox.Show("Se produjo el siguiente error: " + ex.Message);
            }
            
        }
        public void LimpiarComponentes()
        {
            txtNombre.Text = string.Empty;
        }

        private void mnuCambioEstado_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgClientes.SelectedRows.Count > 0)
                {
                    // Obtener el valor de la primera celda de la fila seleccionada
                    DataGridViewRow selectedRow = dtgClientes.SelectedRows[0];
                    string id = selectedRow.Cells[0].Value.ToString();
                    var variedad = controlador.GetCliente(int.Parse(id));

                    controlador.CambiarEstado(variedad);
                    controlador.MostrarClientes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo el siguiente error: " + ex.Message);
            }
        }

        private void dtgClientes_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgClientes.SelectedRows.Count > 0)
            {
                // Obtener el valor de la primera celda de la fila seleccionada
                DataGridViewRow selectedRow = dtgClientes.SelectedRows[0];
                string estado = selectedRow.Cells[2].Value.ToString();
                if (estado.Equals("Habilitado"))
                {
                    mnuCambioEstado.Text = "Deshabilitar";
                }
                else
                {
                    mnuCambioEstado.Text = "Habilitar";
                }
            }
        }

        private void mnuEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgClientes.SelectedRows.Count > 0)
                {
                    // Obtener el valor de la primera celda de la fila seleccionada
                    DataGridViewRow selectedRow = dtgClientes.SelectedRows[0];
                    string id = selectedRow.Cells[0].Value.ToString();
                    var variedad = controlador.GetCliente(int.Parse(id));

                    controlador.EliminarCliente(variedad);
                    controlador.MostrarClientes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo el siguiente error: " + ex.Message);
            }
        }
    }
}
