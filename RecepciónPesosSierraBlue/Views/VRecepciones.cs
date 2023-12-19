using MaterialSkin;
using MaterialSkin.Properties;
using RecepciónPesosSierraBlue.Controllers;
using RecepciónPesosSierraBlue.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecepciónPesosSierraBlue.Views
{
    public partial class VRecepciones : Form
    {
        RecepcionController controlador;
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public VRecepciones()
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

            controlador =new RecepcionController(dtgRecepciones,dtgPesos,cmbProductor,cmbVariedad,
                cmbLotesCultivo,cmbCategorias,cmbPuertos);

        }

        private void cmbProductor_Click(object sender, EventArgs e)
        {
            try
            {
                controlador.MostrarProductoresHabilitados();
            }catch(Exception ex)
            {
                MessageBox.Show("Se prudujo el siguiente error: " + ex.Message);
            }
            
        }

        private void cmbLotesCultivo_Click(object sender, EventArgs e)
        {
            controlador.MostrarLotesCultivoHabilitados(cmbProductor.Text);
        }

        private void cmbPuertos_Click(object sender, EventArgs e)
        {
            try
            {
                controlador.MostrarPuertosHabilitados();
            }catch(Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            
        }

        private void cmbVariedad_Click(object sender, EventArgs e)
        {
            try
            {
                controlador.MostrarVariedadesHabilitadas(cmbProductor.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se prudujo el siguiente error: " + ex.Message);
            }

        }

        private void cmbCategorias_Click(object sender, EventArgs e)
        {
            try
            {
                controlador.MostrarCategoriasHabilitadas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se prudujo el siguiente error: " + ex.Message);
            }
            
        }

        private void VRecepciones_Load(object sender, EventArgs e)
        {
            try
            {
                controlador.InicializarRecepciones();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se prudujo el siguiente error: " + ex.Message);
            }
            
        }

        private void cmbProductor_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbVariedad.Text = string.Empty;
            cmbLotesCultivo.Text = string.Empty;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var recep = new Recepcion
            {
                Puerto = cmbPuertos.Text,
                Productor = cmbProductor.Text,
                Variedad = cmbVariedad.Text,
                LoteCultivo = cmbLotesCultivo.Text,
                Categoria = cmbCategorias.Text,
                InicialesVariedad = controlador.DevolverInicialesVariedad(cmbVariedad.Text),
                IncialesProductor=controlador.DevolverInicialesProductor(cmbProductor.Text)
            };
            controlador.AgregarRecepcion(recep,txtNumeración.Text);
            LimpiarComponentes();
        }
        public void LimpiarComponentes()
        {
            cmbProductor.Text= string.Empty;
            cmbVariedad.Text= string.Empty;
            cmbLotesCultivo.Text=string.Empty;
            cmbCategorias.Text=string.Empty;
            cmbPuertos.Text=string.Empty;
            txtNumeración.Text= string.Empty;

            cmbProductor.Items.Clear();
            cmbVariedad.Items.Clear();
            cmbLotesCultivo.Items.Clear();
            cmbCategorias.Items.Clear();
            cmbPuertos.Items.Clear();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dtgRecepciones.Rows.Clear();
        }

        private void swtchCapturar_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (swtchCapturar.Checked)
                {
                    notifyRecepcion.Icon = Properties.Resources.preci_software2;
                    notifyRecepcion.BalloonTipText = "Se inició la captura de pesos";
                    notifyRecepcion.ShowBalloonTip(1000);
                    controlador.IniciarCapturaPesos();
                }
                else
                {
                    notifyRecepcion.Icon = SystemIcons.Application;
                    notifyRecepcion.BalloonTipText = "Finalizó la captura de pesos";
                    notifyRecepcion.ShowBalloonTip(1000);
                    controlador.DetenerCapturaPesos();
                }
            }catch(Exception ex)
            {
                MessageBox.Show("El puerto seleccionado ya se encuentra ocupado");
                swtchCapturar.Checked = false;
                controlador.DetenerCapturaPesos();
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

        private void cmbLotesCultivo_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void cmbCategorias_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void cmbPuertos_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void txtNumeración_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Si no es un número ni una tecla de control, suprimir la entrada
                e.Handled = true;
            }
        }
    }
}
