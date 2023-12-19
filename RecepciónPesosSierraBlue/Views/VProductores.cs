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
    public partial class VProductores : Form
    {
        ProductorController controlador;
        public VProductores()
        {
            InitializeComponent();
            controlador = new ProductorController(dtgProductores);
        }

        private void VProductores_Load(object sender, EventArgs e)
        {
            try
            {
                controlador.InicializarProductores();
                controlador.MostrarProductores();
            }catch(Exception ex)
            {
                MessageBox.Show("Se produjo el siguiente error: " + ex.Message);
            }
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                controlador.AgregarNuevoProductor(txtNombre.Text, txtIniciales.Text);
                limpiarComponentes();
                
            }catch(Exception ex)
            {
                MessageBox.Show("Se produjo el siguiente error: " + ex.Message);
            }     
        }
        public void limpiarComponentes()
        {
            txtIniciales.Text = string.Empty;
            txtNombre.Text = string.Empty;
        }

        private void dtgProductores_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgProductores.SelectedRows.Count > 0)
            {
                // Obtener el valor de la primera celda de la fila seleccionada
                DataGridViewRow selectedRow = dtgProductores.SelectedRows[0];
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

        private void mnuCambioEstado_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgProductores.SelectedRows.Count > 0)
                {
                    // Obtener el valor de la primera celda de la fila seleccionada
                    DataGridViewRow selectedRow = dtgProductores.SelectedRows[0];
                    string id = selectedRow.Cells[0].Value.ToString();
                    var productor = controlador.GetProductor(int.Parse(id));

                    controlador.CambiarEstado(productor);
                    controlador.MostrarProductores();
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Se produjo el siguiente error: " + ex.Message);
            }
            
        }

        private void mnuEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgProductores.SelectedRows.Count > 0)
                {
                    // Obtener el valor de la primera celda de la fila seleccionada
                    DataGridViewRow selectedRow = dtgProductores.SelectedRows[0];
                    string id = selectedRow.Cells[0].Value.ToString();
                    var productor = controlador.GetProductor(int.Parse(id));

                    controlador.EliminarProductor(productor);
                    controlador.MostrarProductores();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo el siguiente error: " + ex.Message);
            }
        }
    }
}
