namespace RecepciónPesosSierraBlue.Views
{
    partial class VRecepciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Recepciones = new System.Windows.Forms.TabPage();
            this.dtgRecepciones = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtNumeración = new System.Windows.Forms.TextBox();
            this.cmbCategorias = new System.Windows.Forms.ComboBox();
            this.cmbPuertos = new System.Windows.Forms.ComboBox();
            this.cmbLotesCultivo = new System.Windows.Forms.ComboBox();
            this.cmbVariedad = new System.Windows.Forms.ComboBox();
            this.cmbProductor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Pesajes = new System.Windows.Forms.TabPage();
            this.dtgPesos = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.swtchCapturar = new MaterialSkin.Controls.MaterialSwitch();
            this.notifyRecepcion = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabControl1.SuspendLayout();
            this.Recepciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRecepciones)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.Pesajes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPesos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Recepciones);
            this.tabControl1.Controls.Add(this.Pesajes);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1015, 532);
            this.tabControl1.TabIndex = 0;
            // 
            // Recepciones
            // 
            this.Recepciones.Controls.Add(this.dtgRecepciones);
            this.Recepciones.Controls.Add(this.groupBox1);
            this.Recepciones.Location = new System.Drawing.Point(4, 32);
            this.Recepciones.Name = "Recepciones";
            this.Recepciones.Padding = new System.Windows.Forms.Padding(3);
            this.Recepciones.Size = new System.Drawing.Size(1007, 496);
            this.Recepciones.TabIndex = 0;
            this.Recepciones.Text = "Recepciones";
            this.Recepciones.UseVisualStyleBackColor = true;
            // 
            // dtgRecepciones
            // 
            this.dtgRecepciones.AllowUserToAddRows = false;
            this.dtgRecepciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgRecepciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgRecepciones.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgRecepciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgRecepciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgRecepciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgRecepciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgRecepciones.ColumnHeadersHeight = 35;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgRecepciones.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgRecepciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgRecepciones.EnableHeadersVisualStyles = false;
            this.dtgRecepciones.Location = new System.Drawing.Point(3, 295);
            this.dtgRecepciones.MultiSelect = false;
            this.dtgRecepciones.Name = "dtgRecepciones";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgRecepciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgRecepciones.RowHeadersVisible = false;
            this.dtgRecepciones.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgRecepciones.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgRecepciones.RowTemplate.Height = 24;
            this.dtgRecepciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgRecepciones.Size = new System.Drawing.Size(1001, 198);
            this.dtgRecepciones.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.txtNumeración);
            this.groupBox1.Controls.Add(this.cmbCategorias);
            this.groupBox1.Controls.Add(this.cmbPuertos);
            this.groupBox1.Controls.Add(this.cmbLotesCultivo);
            this.groupBox1.Controls.Add(this.cmbVariedad);
            this.groupBox1.Controls.Add(this.cmbProductor);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1001, 292);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nueva recepción";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(432, 220);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(183, 38);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.Text = "Vaciar Recepciones";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(149, 220);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(183, 38);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtNumeración
            // 
            this.txtNumeración.Location = new System.Drawing.Point(613, 142);
            this.txtNumeración.Name = "txtNumeración";
            this.txtNumeración.Size = new System.Drawing.Size(61, 30);
            this.txtNumeración.TabIndex = 11;
            this.txtNumeración.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeración_KeyPress);
            // 
            // cmbCategorias
            // 
            this.cmbCategorias.FormattingEnabled = true;
            this.cmbCategorias.Location = new System.Drawing.Point(613, 90);
            this.cmbCategorias.Name = "cmbCategorias";
            this.cmbCategorias.Size = new System.Drawing.Size(252, 31);
            this.cmbCategorias.TabIndex = 10;
            this.cmbCategorias.Click += new System.EventHandler(this.cmbCategorias_Click);
            this.cmbCategorias.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCategorias_KeyDown);
            // 
            // cmbPuertos
            // 
            this.cmbPuertos.FormattingEnabled = true;
            this.cmbPuertos.Location = new System.Drawing.Point(176, 142);
            this.cmbPuertos.Name = "cmbPuertos";
            this.cmbPuertos.Size = new System.Drawing.Size(183, 31);
            this.cmbPuertos.TabIndex = 9;
            this.cmbPuertos.Click += new System.EventHandler(this.cmbPuertos_Click);
            this.cmbPuertos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbPuertos_KeyDown);
            // 
            // cmbLotesCultivo
            // 
            this.cmbLotesCultivo.FormattingEnabled = true;
            this.cmbLotesCultivo.Location = new System.Drawing.Point(176, 91);
            this.cmbLotesCultivo.Name = "cmbLotesCultivo";
            this.cmbLotesCultivo.Size = new System.Drawing.Size(252, 31);
            this.cmbLotesCultivo.TabIndex = 8;
            this.cmbLotesCultivo.Click += new System.EventHandler(this.cmbLotesCultivo_Click);
            this.cmbLotesCultivo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbLotesCultivo_KeyDown);
            // 
            // cmbVariedad
            // 
            this.cmbVariedad.FormattingEnabled = true;
            this.cmbVariedad.Location = new System.Drawing.Point(613, 43);
            this.cmbVariedad.Name = "cmbVariedad";
            this.cmbVariedad.Size = new System.Drawing.Size(252, 31);
            this.cmbVariedad.TabIndex = 7;
            this.cmbVariedad.Click += new System.EventHandler(this.cmbVariedad_Click);
            this.cmbVariedad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbVariedad_KeyDown);
            // 
            // cmbProductor
            // 
            this.cmbProductor.BackColor = System.Drawing.SystemColors.Window;
            this.cmbProductor.FormattingEnabled = true;
            this.cmbProductor.Location = new System.Drawing.Point(176, 43);
            this.cmbProductor.Name = "cmbProductor";
            this.cmbProductor.Size = new System.Drawing.Size(252, 31);
            this.cmbProductor.TabIndex = 6;
            this.cmbProductor.SelectedIndexChanged += new System.EventHandler(this.cmbProductor_SelectedIndexChanged);
            this.cmbProductor.Click += new System.EventHandler(this.cmbProductor_Click);
            this.cmbProductor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbProductor_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(498, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Numeración:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(498, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Categoría;";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(498, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Variedad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Puerto COM:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lote de cultivo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Productor:";
            // 
            // Pesajes
            // 
            this.Pesajes.Controls.Add(this.dtgPesos);
            this.Pesajes.Controls.Add(this.groupBox2);
            this.Pesajes.Location = new System.Drawing.Point(4, 32);
            this.Pesajes.Name = "Pesajes";
            this.Pesajes.Padding = new System.Windows.Forms.Padding(3);
            this.Pesajes.Size = new System.Drawing.Size(1007, 496);
            this.Pesajes.TabIndex = 1;
            this.Pesajes.Text = "Pesajes";
            this.Pesajes.UseVisualStyleBackColor = true;
            // 
            // dtgPesos
            // 
            this.dtgPesos.AllowUserToAddRows = false;
            this.dtgPesos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgPesos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgPesos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgPesos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgPesos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgPesos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgPesos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgPesos.ColumnHeadersHeight = 35;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgPesos.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtgPesos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgPesos.EnableHeadersVisualStyles = false;
            this.dtgPesos.Location = new System.Drawing.Point(3, 103);
            this.dtgPesos.MultiSelect = false;
            this.dtgPesos.Name = "dtgPesos";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgPesos.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgPesos.RowHeadersVisible = false;
            this.dtgPesos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dtgPesos.RowTemplate.Height = 24;
            this.dtgPesos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPesos.Size = new System.Drawing.Size(1001, 390);
            this.dtgPesos.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Controls.Add(this.swtchCapturar);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1001, 100);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // swtchCapturar
            // 
            this.swtchCapturar.AutoSize = true;
            this.swtchCapturar.BackColor = System.Drawing.SystemColors.Control;
            this.swtchCapturar.Depth = 0;
            this.swtchCapturar.Location = new System.Drawing.Point(52, 39);
            this.swtchCapturar.Margin = new System.Windows.Forms.Padding(0);
            this.swtchCapturar.MouseLocation = new System.Drawing.Point(-1, -1);
            this.swtchCapturar.MouseState = MaterialSkin.MouseState.HOVER;
            this.swtchCapturar.Name = "swtchCapturar";
            this.swtchCapturar.Ripple = true;
            this.swtchCapturar.Size = new System.Drawing.Size(165, 37);
            this.swtchCapturar.TabIndex = 0;
            this.swtchCapturar.Text = "Capturar pesos";
            this.swtchCapturar.UseVisualStyleBackColor = false;
            this.swtchCapturar.CheckedChanged += new System.EventHandler(this.swtchCapturar_CheckedChanged);
            // 
            // notifyRecepcion
            // 
            this.notifyRecepcion.Text = "notifyIcon1";
            this.notifyRecepcion.Visible = true;
            // 
            // VRecepciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1015, 532);
            this.Controls.Add(this.tabControl1);
            this.Name = "VRecepciones";
            this.Text = "VRecepciones";
            this.Load += new System.EventHandler(this.VRecepciones_Load);
            this.tabControl1.ResumeLayout(false);
            this.Recepciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgRecepciones)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Pesajes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPesos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Recepciones;
        private System.Windows.Forms.TabPage Pesajes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNumeración;
        private System.Windows.Forms.ComboBox cmbCategorias;
        private System.Windows.Forms.ComboBox cmbPuertos;
        private System.Windows.Forms.ComboBox cmbLotesCultivo;
        private System.Windows.Forms.ComboBox cmbVariedad;
        private System.Windows.Forms.ComboBox cmbProductor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgRecepciones;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgPesos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnLimpiar;
        private MaterialSkin.Controls.MaterialSwitch swtchCapturar;
        private System.Windows.Forms.NotifyIcon notifyRecepcion;
    }
}