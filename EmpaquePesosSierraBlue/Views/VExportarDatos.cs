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
    public partial class VExportarDatos : Form
    {
        ExportarDatosController controlador;
        public VExportarDatos()
        {
            InitializeComponent();
            controlador=new ExportarDatosController();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Archivos de Excel|*.xlsx";
                saveFileDialog.Title = "Guardar archivo Excel";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Aquí es donde generamos y guardamos el archivo Excel
                    string filePath = saveFileDialog.FileName;

                    // Reemplaza esto con tu lógica para crear y guardar el archivo Excel
                    //ExportarDatosAExcel(filePath);

                    controlador.GuardarExcelEmpaques(filePath, dtpFecha.Value.Date);



                    MessageBox.Show("Archivo Excel exportado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
