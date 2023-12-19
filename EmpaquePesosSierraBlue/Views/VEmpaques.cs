using EmpaquePesosSierraBlue.Controllers;
using EmpaquePesosSierraBlue.Model;
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
    public partial class VEmpaques : Form
    {
        EmpaqueController controlador;
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public VEmpaques()
        {
            InitializeComponent();

            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(
                MaterialSkin.Primary.Indigo700,
                MaterialSkin.Primary.Indigo900,
                MaterialSkin.Primary.Indigo100,
                MaterialSkin.Accent.Blue700,
                MaterialSkin.TextShade.WHITE
                );

            controlador = new EmpaqueController(dtgEmpaque, dtgPesos, cmbProductor, cmbVariedad,
                cmbPresentacion, cmbCalibre, cmbCliente,cmbPuerto);
        }

        private void txtNumeración_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Si no es un número ni una tecla de control, suprimir la entrada
                e.Handled = true;
            }
        }

        private void cmbProductor_Click(object sender, EventArgs e)
        {
            try {
                controlador.MostrarProductoresHabilitados();
            }catch(Exception ex)
            {
                MessageBox.Show("Se prudujo el siguiente error: " + ex.Message);
            }
            
        }

        private void cmbVariedad_Click(object sender, EventArgs e)
        {
            try
            {
                controlador.MostrarVariedadesHabilitadas(cmbProductor.Text);
            }catch(Exception ex)
            {
                MessageBox.Show("Se prudujo el siguiente error: " + ex.Message);
            }
            
        }

        private void cmbPresentacion_Click(object sender, EventArgs e)
        {
            try
            {
                controlador.MostrarPresentacionesHabilitadas();
            }catch(Exception ex)
            {
                MessageBox.Show("Se prpdujo el siguiente error: " + ex.Message);
            }
            
        }

        private void cmbCalibre_Click(object sender, EventArgs e)
        {
            try
            {
                controlador.MostrarCalibresHabilitados();
            }catch(Exception ex)
            {
                MessageBox.Show("Se prpdujo el siguiente error: " + ex.Message);
            }
            
        }

        private void cmbCliente_Click(object sender, EventArgs e)
        {
            try
            {
                controlador.MostrarClientessHabilitados();
            }catch(Exception ex)
            {
                MessageBox.Show("Se prpdujo el siguiente error: " + ex.Message);
            }
            
        }

        private void cmbPuerto_Click(object sender, EventArgs e)
        {
            try
            {
                controlador.MostrarPuertosHabilitados();
            }catch(Exception ex)
            {
                MessageBox.Show("Se prpdujo el siguiente error: " + ex.Message);
            }
            
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            dtgEmpaque.Rows.Clear();
            try
            {
                var emp = new Empaque
                {
                    Puerto = cmbPuerto.Text,
                    Productor = cmbProductor.Text,
                    Variedad = cmbVariedad.Text,
                    Presentacion = cmbPresentacion.Text,
                    Calibre = cmbCalibre.Text,
                    Cliente = cmbCliente.Text,
                    InicialesProductor = controlador.DevolverInicialesProductor(cmbProductor.Text),
                    InicialesVariedad = controlador.DevolverInicialesVariedad(cmbVariedad.Text)
                };
                controlador.AgregarEmpaque(emp, txtNumeración.Text);
            }catch(Exception ex ) 
            {
                MessageBox.Show("Se prpdujo el siguiente error: " + ex.Message);
            }
            
            LimpiarComponentes();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dtgPesos.Rows.Clear();
        }
        public void LimpiarComponentes()
        {
            cmbProductor.Text = string.Empty;
            cmbVariedad.Text = string.Empty;
            cmbPresentacion.Text = string.Empty;
            cmbCalibre.Text = string.Empty;
            cmbPuerto.Text = string.Empty;
            cmbCliente.Text = string.Empty;
            txtNumeración.Text = string.Empty;

            cmbProductor.Items.Clear();
            cmbVariedad.Items.Clear();
            cmbPresentacion.Items.Clear();
            cmbCalibre.Items.Clear();
            cmbPuerto.Items.Clear();
            cmbCliente.Items.Clear();
        }

        private void dtgEmpaque_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (dtgEmpaque.Rows.Count > 1)
            {
                for (int i = 1; i < dtgEmpaque.Rows.Count; i++)
                {
                    dtgEmpaque.Rows.RemoveAt(i);
                }
            }
        }

        private void VEmpaques_Load(object sender, EventArgs e)
        {
            try
            {
                controlador.InicializarEmpaques();
            }catch(Exception ex)
            {
                MessageBox.Show("Se prpdujo el siguiente error: " + ex.Message);
            }
            
        }

        private void cmbProductor_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void cmbVariedad_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void cmbPresentacion_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void cmbCalibre_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void cmbCliente_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void cmbPuerto_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void swtchCapturar_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (swtchCapturar.Checked)
                {
                    notifyEmpaques.Icon = SystemIcons.Application;
                    notifyEmpaques.BalloonTipText = "Se inició la captura de pesos";
                    notifyEmpaques.ShowBalloonTip(1000);
                    controlador.IniciarCapturaPesos();
                }
                else
                {
                    notifyEmpaques.Icon = SystemIcons.Application;
                    notifyEmpaques.BalloonTipText = "Finalizó la captura de pesos";
                    notifyEmpaques.ShowBalloonTip(1000);
                    controlador.DetenerCapturaPesos();
                }
            }catch(Exception ex)
            {
                MessageBox.Show("El puerto seleccionado ya se encuentra ocupado");
                swtchCapturar.Checked = false;
                controlador.DetenerCapturaPesos();
            }
            
        }

        private void cmbProductor_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbVariedad.Text = string.Empty;
        }
    }
}
