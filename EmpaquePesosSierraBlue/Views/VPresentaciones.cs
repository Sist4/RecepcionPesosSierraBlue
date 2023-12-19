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
    public partial class VPresentaciones : Form
    {
        PresentacionController controlador;
        public VPresentaciones()
        {
            InitializeComponent();
            controlador = new PresentacionController(dtgPresentaciones);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                controlador.AgregarPresentacion(txtNombre.Text);
                LimpiarComponentes();
            }catch(Exception ex)
            {
                MessageBox.Show("Se produjo el siguiente error: " + ex.Message);
            }
            
        }

        private void VPresentaciones_Load(object sender, EventArgs e)
        {
            try
            {
                controlador.InicializarPresentaciones();
                controlador.MostrarPresentaciones();
            }catch(Exception ex)
            {
                MessageBox.Show("Se produjo el siguiente error: " + ex.Message);
            }
            
        }
        public void LimpiarComponentes()
        {
            txtNombre.Text = string.Empty;
        }

        private void dtgPresentaciones_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgPresentaciones.SelectedRows.Count > 0)
            {
                // Obtener el valor de la primera celda de la fila seleccionada
                DataGridViewRow selectedRow = dtgPresentaciones.SelectedRows[0];
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

        private void mnuCambioEstado_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgPresentaciones.SelectedRows.Count > 0)
                {
                    // Obtener el valor de la primera celda de la fila seleccionada
                    DataGridViewRow selectedRow = dtgPresentaciones.SelectedRows[0];
                    string id = selectedRow.Cells[0].Value.ToString();
                    var variedad = controlador.GetPresentacion(int.Parse(id));

                    controlador.CambiarEstado(variedad);
                    controlador.MostrarPresentaciones();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo el siguiente error: " + ex.Message);
            }
        }

        private void mnuEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgPresentaciones.SelectedRows.Count > 0)
                {
                    // Obtener el valor de la primera celda de la fila seleccionada
                    DataGridViewRow selectedRow = dtgPresentaciones.SelectedRows[0];
                    string id = selectedRow.Cells[0].Value.ToString();
                    var variedad = controlador.GetPresentacion(int.Parse(id));

                    controlador.EliminarPresentacion(variedad);
                    controlador.MostrarPresentaciones();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo el siguiente error: " + ex.Message);
            }
        }
    }
}
