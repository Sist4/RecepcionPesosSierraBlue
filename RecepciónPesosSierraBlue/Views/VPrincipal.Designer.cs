namespace RecepciónPesosSierraBlue
{
    partial class VPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlLateral = new System.Windows.Forms.Panel();
            this.btnExportarDatos = new System.Windows.Forms.Button();
            this.btnRecepciones = new System.Windows.Forms.Button();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.btnLotesCutivo = new System.Windows.Forms.Button();
            this.btnVariedades = new System.Windows.Forms.Button();
            this.btnProductores = new System.Windows.Forms.Button();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlLateral.SuspendLayout();
            this.pnlPrincipal.SuspendLayout();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLateral
            // 
            this.pnlLateral.Controls.Add(this.btnExportarDatos);
            this.pnlLateral.Controls.Add(this.btnRecepciones);
            this.pnlLateral.Controls.Add(this.btnCategorias);
            this.pnlLateral.Controls.Add(this.btnLotesCutivo);
            this.pnlLateral.Controls.Add(this.btnVariedades);
            this.pnlLateral.Controls.Add(this.btnProductores);
            this.pnlLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLateral.Location = new System.Drawing.Point(0, 0);
            this.pnlLateral.Name = "pnlLateral";
            this.pnlLateral.Size = new System.Drawing.Size(247, 624);
            this.pnlLateral.TabIndex = 0;
            // 
            // btnExportarDatos
            // 
            this.btnExportarDatos.FlatAppearance.BorderSize = 0;
            this.btnExportarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportarDatos.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportarDatos.Image = global::RecepciónPesosSierraBlue.Properties.Resources.exportar_archivo;
            this.btnExportarDatos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportarDatos.Location = new System.Drawing.Point(2, 434);
            this.btnExportarDatos.Name = "btnExportarDatos";
            this.btnExportarDatos.Size = new System.Drawing.Size(244, 68);
            this.btnExportarDatos.TabIndex = 5;
            this.btnExportarDatos.Text = "               EXPORTAR DATOS";
            this.btnExportarDatos.UseVisualStyleBackColor = true;
            this.btnExportarDatos.Click += new System.EventHandler(this.btnExportarDatos_Click);
            // 
            // btnRecepciones
            // 
            this.btnRecepciones.FlatAppearance.BorderSize = 0;
            this.btnRecepciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecepciones.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecepciones.Image = global::RecepciónPesosSierraBlue.Properties.Resources.recepcion;
            this.btnRecepciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecepciones.Location = new System.Drawing.Point(1, 352);
            this.btnRecepciones.Name = "btnRecepciones";
            this.btnRecepciones.Size = new System.Drawing.Size(244, 68);
            this.btnRecepciones.TabIndex = 4;
            this.btnRecepciones.Text = "               RECEPCIONES";
            this.btnRecepciones.UseVisualStyleBackColor = true;
            this.btnRecepciones.Click += new System.EventHandler(this.btnRecepciones_Click);
            // 
            // btnCategorias
            // 
            this.btnCategorias.FlatAppearance.BorderSize = 0;
            this.btnCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategorias.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategorias.Image = global::RecepciónPesosSierraBlue.Properties.Resources.categorias;
            this.btnCategorias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategorias.Location = new System.Drawing.Point(2, 274);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(244, 68);
            this.btnCategorias.TabIndex = 3;
            this.btnCategorias.Text = "               CATEGORIAS";
            this.btnCategorias.UseVisualStyleBackColor = true;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // btnLotesCutivo
            // 
            this.btnLotesCutivo.FlatAppearance.BorderSize = 0;
            this.btnLotesCutivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLotesCutivo.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLotesCutivo.Image = global::RecepciónPesosSierraBlue.Properties.Resources.fertilizante3;
            this.btnLotesCutivo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLotesCutivo.Location = new System.Drawing.Point(2, 187);
            this.btnLotesCutivo.Name = "btnLotesCutivo";
            this.btnLotesCutivo.Size = new System.Drawing.Size(244, 68);
            this.btnLotesCutivo.TabIndex = 2;
            this.btnLotesCutivo.Text = "               LOTES DE CULTIVO";
            this.btnLotesCutivo.UseVisualStyleBackColor = true;
            this.btnLotesCutivo.Click += new System.EventHandler(this.btnLotesCutivo_Click);
            // 
            // btnVariedades
            // 
            this.btnVariedades.FlatAppearance.BorderSize = 0;
            this.btnVariedades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVariedades.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVariedades.Image = global::RecepciónPesosSierraBlue.Properties.Resources.cosecha;
            this.btnVariedades.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVariedades.Location = new System.Drawing.Point(2, 104);
            this.btnVariedades.Name = "btnVariedades";
            this.btnVariedades.Size = new System.Drawing.Size(244, 68);
            this.btnVariedades.TabIndex = 1;
            this.btnVariedades.Text = "               VARIEDADES";
            this.btnVariedades.UseVisualStyleBackColor = true;
            this.btnVariedades.Click += new System.EventHandler(this.btnVariedades_Click);
            // 
            // btnProductores
            // 
            this.btnProductores.FlatAppearance.BorderSize = 0;
            this.btnProductores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductores.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductores.Image = global::RecepciónPesosSierraBlue.Properties.Resources.agricultor1;
            this.btnProductores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductores.Location = new System.Drawing.Point(0, 28);
            this.btnProductores.Name = "btnProductores";
            this.btnProductores.Size = new System.Drawing.Size(244, 68);
            this.btnProductores.TabIndex = 0;
            this.btnProductores.Text = "               PRODUCTORES";
            this.btnProductores.UseVisualStyleBackColor = true;
            this.btnProductores.Click += new System.EventHandler(this.btnProductores_Click);
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlPrincipal.Controls.Add(this.materialCard1);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(247, 0);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(1158, 624);
            this.pnlPrincipal.TabIndex = 1;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.pictureBox2);
            this.materialCard1.Controls.Add(this.pictureBox1);
            this.materialCard1.Controls.Add(this.label1);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(359, 104);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(548, 226);
            this.materialCard1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::RecepciónPesosSierraBlue.Properties.Resources.ESPA_446;
            this.pictureBox2.Location = new System.Drawing.Point(270, 144);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(232, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RecepciónPesosSierraBlue.Properties.Resources.PRECI_446;
            this.pictureBox1.Location = new System.Drawing.Point(17, 144);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recepción de Pesos Sierra Blue\r\nDepartamento de TI de Precitrol\r\nCompilación: 07-" +
    "11-2023\r\nVer 1.1.0\r\n";
            // 
            // VPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 624);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.pnlLateral);
            this.MaximizeBox = false;
            this.Name = "VPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recepción de pesos";
            this.pnlLateral.ResumeLayout(false);
            this.pnlPrincipal.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLateral;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Button btnProductores;
        private System.Windows.Forms.Button btnVariedades;
        private System.Windows.Forms.Button btnLotesCutivo;
        private System.Windows.Forms.Button btnCategorias;
        private System.Windows.Forms.Button btnRecepciones;
        private System.Windows.Forms.Button btnExportarDatos;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

