using RecepciónPesosSierraBlue.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecepciónPesosSierraBlue
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

        private void btnLotesCutivo_Click(object sender, EventArgs e)
        {
            AbrirForm(new VLotesCultivo());
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            AbrirForm(new VCategorias());
        }

        private void btnRecepciones_Click(object sender, EventArgs e)
        {
            AbrirForm(new VRecepciones());
        }

        private void btnExportarDatos_Click(object sender, EventArgs e)
        {
            AbrirForm(new VExportarDatos());
        }
    }
}
