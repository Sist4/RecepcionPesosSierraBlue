using RecepciónPesosSierraBlue.Controllers;
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
    public partial class VVariedades : Form
    {
        VariedadController controlador;
        public VVariedades()
        {
            InitializeComponent();
            controlador = new VariedadController(cmbProductores, dtgVariedades);
        }

        private void VVariedades_Load(object sender, EventArgs e)
        {
            try
            {
                controlador.InicializarVariedades();
                controlador.MostrarVariedades();
            }catch(Exception ex)
            {
                MessageBox.Show("Se produjo el siguiente error: " + ex.Message);
            }
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                controlador.AgregarVariedad(txtNombre.Text, txtIniciales.Text, cmbProductores.Text);
                LimpiarComponentes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo el siguiente error: " + ex.Message);
            }
        }

        private void cmbProductores_Click(object sender, EventArgs e)
        {
            try
            {
                controlador.MostrarProductoresHabilitados();
            }catch(Exception ex)
            {
                MessageBox.Show("Se produjo el siguiente error: " + ex.Message);
            }
            
        }
        public void LimpiarComponentes()
        {
            txtIniciales.Text = string.Empty;
            txtNombre.Text = string.Empty;
            cmbProductores.Text = string.Empty;
            cmbProductores.Items.Clear();
        }

        private void cmbProductores_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void mnuCambioEstado_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgVariedades.SelectedRows.Count > 0)
                {
                    // Obtener el valor de la primera celda de la fila seleccionada
                    DataGridViewRow selectedRow = dtgVariedades.SelectedRows[0];
                    string id = selectedRow.Cells[0].Value.ToString();
                    var variedad = controlador.GetVariedad(int.Parse(id));

                    controlador.CambiarEstado(variedad);
                    controlador.MostrarVariedades();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo el siguiente error: " + ex.Message);
            }
        }

        private void dtgVariedades_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgVariedades.SelectedRows.Count > 0)
            {
                // Obtener el valor de la primera celda de la fila seleccionada
                DataGridViewRow selectedRow = dtgVariedades.SelectedRows[0];
                string estado = selectedRow.Cells[4].Value.ToString();
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
                if (dtgVariedades.SelectedRows.Count > 0)
                {
                    // Obtener el valor de la primera celda de la fila seleccionada
                    DataGridViewRow selectedRow = dtgVariedades.SelectedRows[0];
                    string id = selectedRow.Cells[0].Value.ToString();
                    var variedad = controlador.GetVariedad(int.Parse(id));

                    controlador.EliminarVariedad(variedad);
                    controlador.MostrarVariedades();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo el siguiente error: " + ex.Message);
            }
        }
    }
}
