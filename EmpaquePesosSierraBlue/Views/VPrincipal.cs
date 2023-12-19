using EmpaquePesosSierraBlue.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpaquePesosSierraBlue
{
    public partial class VPrincipal : Form
    {
        public VPrincipal()
        {
            InitializeComponent();
        }
        public void AbrirForm(Form form)
        {
            while (pnlPrincipal.Controls.Count > 0)
            {
                pnlPrincipal.Controls.RemoveAt(index: 0);
            }

            Form formHijo = form;
            form.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            pnlPrincipal.Controls.Add(formHijo);
            formHijo.Show();

        }

        private void btnProductores_Click(object sender, EventArgs e)
        {
            AbrirForm(new VProductores());
        }

        private void btnVariedades_Click(object sender, EventArgs e)
        {
            AbrirForm(new VVariedades());
        }

        private void btnPresentaciones_Click(object sender, EventArgs e)
        {
            AbrirForm(new VPresentaciones());
        }

        private void btnCalibres_Click(object sender, EventArgs e)
        {
            AbrirForm(new VCalibres());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirForm(new VClientes());
        }

        private void btnEmpaques_Click(object sender, EventArgs e)
        {
            AbrirForm(new VEmpaques()); 
        }

        private void btnExportarDatos_Click(object sender, EventArgs e)
        {
            AbrirForm(new VExportarDatos());    
        }

        private void VPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
