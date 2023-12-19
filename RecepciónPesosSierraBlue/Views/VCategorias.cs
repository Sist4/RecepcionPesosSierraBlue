using RecepciónPesosSierraBlue.Controllers;
using RecepciónPesosSierraBlue.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecepciónPesosSierraBlue.Views
{
    public partial class VCategorias : Form
    {
        CategoriaController controlador;
        public VCategorias()
        {
            InitializeComponent();
            controlador = new CategoriaController(dtgCategorias);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                controlador.AgregarCategoria(txtNombre.Text);
                LimpiarComponentes();
            }catch(Exception ex)
            {
                MessageBox.Show("Se produjo el siguiente error: " + ex.Message);
            }
            
        }

        private void VCategorias_Load(object sender, EventArgs e)
        {
            try
            {
                controlador.InicializarCategorias();
                controlador.MostrarCategorias();
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
                if (dtgCategorias.SelectedRows.Count > 0)
                {
                    // Obtener el valor de la primera celda de la fila seleccionada
                    DataGridViewRow selectedRow = dtgCategorias.SelectedRows[0];
                    string id = selectedRow.Cells[0].Value.ToString();
                    var variedad = controlador.GetCategoria(int.Parse(id));

                    controlador.CambiarEstado(variedad);
                    controlador.MostrarCategorias();
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Se produjo el siguiente error: " + ex.Message);
            }
            
        }

        private void dtgCategorias_SelectionChanged(object sender, EventArgs e)
        {

            if (dtgCategorias.SelectedRows.Count > 0)
            {
                // Obtener el valor de la primera celda de la fila seleccionada
                DataGridViewRow selectedRow = dtgCategorias.SelectedRows[0];
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
                if (dtgCategorias.SelectedRows.Count > 0)
                {
                    // Obtener el valor de la primera celda de la fila seleccionada
                    DataGridViewRow selectedRow = dtgCategorias.SelectedRows[0];
                    string id = selectedRow.Cells[0].Value.ToString();
                    var variedad = controlador.GetCategoria(int.Parse(id));

                    controlador.EliminarCategoria(variedad);
                    controlador.MostrarCategorias();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo el siguiente error: " + ex.Message);
            }
        }
        public void EliminarCategoria(Categoria categoria)
        {
            try
            {
                using (SierraBlueDB db = new SierraBlueDB())
                {
                    db.Entry(categoria).State = EntityState.Deleted;
                    db.SaveChanges();
                }
            }
            catch (Exception) { throw; }
        }
    }
}
