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

namespace RecepciónPesosSierraBlue.Views
{
    public partial class VLotesCultivo : Form
    {
        LoteCultivoController controlador;

        public VLotesCultivo()
        {
            InitializeComponent();
            controlador = new LoteCultivoController(cmbProductores,dtgLotesCultivos);
        }

        private void VLotesCultivo_Load(object sender, EventArgs e)
        {
            try
            {
                controlador.InicializarLotesCultivo();
                controlador.MostrarLotesCultivo();
            }catch(Exception ex)
            {
                MessageBox.Show("Se produjo el siguiente error: "+ex.Message);
            }
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                controlador.AgregarLoteCultivo(txtNombre.Text, cmbProductores.Text);
                LimpiarComponentes();
            }catch(Exception ex)
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
            txtNombre.Text = string.Empty;
            cmbProductores.Text = string.Empty;
            cmbProductores.Items.Clear();
        }

        private void mnuCambioEstado_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgLotesCultivos.SelectedRows.Count > 0)
                {
                    // Obtener el valor de la primera celda de la fila seleccionada
                    DataGridViewRow selectedRow = dtgLotesCultivos.SelectedRows[0];
                    string id = selectedRow.Cells[0].Value.ToString();
                    var variedad = controlador.GetLoteCultivo(int.Parse(id));

                    controlador.CambiarEstado(variedad);
                    controlador.MostrarLotesCultivo();
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Se produjo el siguiente error: " + ex.Message);
            }
            
        }

        private void dtgLotesCultivos_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgLotesCultivos.SelectedRows.Count > 0)
            {
                // Obtener el valor de la primera celda de la fila seleccionada
                DataGridViewRow selectedRow = dtgLotesCultivos.SelectedRows[0];
                string estado = selectedRow.Cells[3].Value.ToString();
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

        private void cmbProductores_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void mnuEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgLotesCultivos.SelectedRows.Count > 0)
                {
                    // Obtener el valor de la primera celda de la fila seleccionada
                    DataGridViewRow selectedRow = dtgLotesCultivos.SelectedRows[0];
                    string id = selectedRow.Cells[0].Value.ToString();
                    var variedad = controlador.GetLoteCultivo(int.Parse(id));

                    controlador.EliminarLoteCultivo(variedad);
                    controlador.MostrarLotesCultivo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo el siguiente error: " + ex.Message);
            }
        }
    }
}
