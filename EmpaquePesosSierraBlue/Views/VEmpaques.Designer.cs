namespace EmpaquePesosSierraBlue.Views
{
    partial class VEmpaques
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Empaque = new System.Windows.Forms.TabPage();
            this.dtgEmpaque = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.txtNumeración = new System.Windows.Forms.TextBox();
            this.cmbCalibre = new System.Windows.Forms.ComboBox();
            this.cmbPuerto = new System.Windows.Forms.ComboBox();
            this.cmbPresentacion = new System.Windows.Forms.ComboBox();
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
            this.notifyEmpaques = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabControl1.SuspendLayout();
            this.Empaque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmpaque)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.Pesajes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPesos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Empaque);
            this.tabControl1.Controls.Add(this.Pesajes);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1015, 532);
            this.tabControl1.TabIndex = 0;
            // 
            // Empaque
            // 
            this.Empaque.Controls.Add(this.dtgEmpaque);
            this.Empaque.Controls.Add(this.groupBox1);
            this.Empaque.Location = new System.Drawing.Point(4, 32);
            this.Empaque.Name = "Empaque";
            this.Empaque.Padding = new System.Windows.Forms.Padding(3);
            this.Empaque.Size = new System.Drawing.Size(1007, 496);
            this.Empaque.TabIndex = 0;
            this.Empaque.Text = "Empaque";
            this.Empaque.UseVisualStyleBackColor = true;
            // 
            // dtgEmpaque
            // 
            this.dtgEmpaque.AllowUserToAddRows = false;
            this.dtgEmpaque.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgEmpaque.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgEmpaque.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgEmpaque.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgEmpaque.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgEmpaque.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgEmpaque.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dtgEmpaque.ColumnHeadersHeight = 35;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgEmpaque.DefaultCellStyle = dataGridViewCellStyle9;
            this.dtgEmpaque.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgEmpaque.EnableHeadersVisualStyles = false;
            this.dtgEmpaque.Location = new System.Drawing.Point(3, 370);
            this.dtgEmpaque.MultiSelect = false;
            this.dtgEmpaque.Name = "dtgEmpaque";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgEmpaque.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dtgEmpaque.RowHeadersVisible = false;
            this.dtgEmpaque.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgEmpaque.RowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dtgEmpaque.RowTemplate.Height = 24;
            this.dtgEmpaque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgEmpaque.Size = new System.Drawing.Size(1001, 123);
            this.dtgEmpaque.TabIndex = 5;
            this.dtgEmpaque.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dtgEmpaque_RowsAdded);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbCliente);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.btnCrear);
            this.groupBox1.Controls.Add(this.txtNumeración);
            this.groupBox1.Controls.Add(this.cmbCalibre);
            this.groupBox1.Controls.Add(this.cmbPuerto);
            this.groupBox1.Controls.Add(this.cmbPresentacion);
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
            this.groupBox1.Size = new System.Drawing.Size(1001, 367);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Empaque";
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(176, 141);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(252, 31);
            this.cmbCliente.TabIndex = 15;
            this.cmbCliente.Click += new System.EventHandler(this.cmbCliente_Click);
            this.cmbCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCliente_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "Cliente:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(432, 297);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(183, 38);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.Text = "Vaciar Empaque";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.Location = new System.Drawing.Point(149, 296);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(183, 38);
            this.btnCrear.TabIndex = 12;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // txtNumeración
            // 
            this.txtNumeración.Location = new System.Drawing.Point(613, 142);
            this.txtNumeración.Name = "txtNumeración";
            this.txtNumeración.Size = new System.Drawing.Size(61, 30);
            this.txtNumeración.TabIndex = 11;
            this.txtNumeración.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeración_KeyPress);
            // 
            // cmbCalibre
            // 
            this.cmbCalibre.FormattingEnabled = true;
            this.cmbCalibre.Location = new System.Drawing.Point(613, 90);
            this.cmbCalibre.Name = "cmbCalibre";
            this.cmbCalibre.Size = new System.Drawing.Size(252, 31);
            this.cmbCalibre.TabIndex = 10;
            this.cmbCalibre.Click += new System.EventHandler(this.cmbCalibre_Click);
            this.cmbCalibre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCalibre_KeyDown);
            // 
            // cmbPuerto
            // 
            this.cmbPuerto.FormattingEnabled = true;
            this.cmbPuerto.Location = new System.Drawing.Point(176, 193);
            this.cmbPuerto.Name = "cmbPuerto";
            this.cmbPuerto.Size = new System.Drawing.Size(183, 31);
            this.cmbPuerto.TabIndex = 9;
            this.cmbPuerto.Click += new System.EventHandler(this.cmbPuerto_Click);
            this.cmbPuerto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbPuerto_KeyDown);
            // 
            // cmbPresentacion
            // 
            this.cmbPresentacion.FormattingEnabled = true;
            this.cmbPresentacion.Location = new System.Drawing.Point(176, 91);
            this.cmbPresentacion.Name = "cmbPresentacion";
            this.cmbPresentacion.Size = new System.Drawing.Size(252, 31);
            this.cmbPresentacion.TabIndex = 8;
            this.cmbPresentacion.Click += new System.EventHandler(this.cmbPresentacion_Click);
            this.cmbPresentacion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbPresentacion_KeyDown);
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
            this.cmbProductor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
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
            this.label5.Size = new System.Drawing.Size(67, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Calibre:";
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
            this.label3.Location = new System.Drawing.Point(31, 200);
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
            this.label2.Size = new System.Drawing.Size(112, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Presentación:";
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
            this.Pesajes.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Pesajes.Controls.Add(this.dtgPesos);
            this.Pesajes.Controls.Add(this.groupBox2);
            this.Pesajes.Location = new System.Drawing.Point(4, 32);
            this.Pesajes.Name = "Pesajes";
            this.Pesajes.Padding = new System.Windows.Forms.Padding(3);
            this.Pesajes.Size = new System.Drawing.Size(1007, 496);
            this.Pesajes.TabIndex = 1;
            this.Pesajes.Text = "Pesajes";
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
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgPesos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dtgPesos.ColumnHeadersHeight = 35;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgPesos.DefaultCellStyle = dataGridViewCellStyle13;
            this.dtgPesos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgPesos.EnableHeadersVisualStyles = false;
            this.dtgPesos.Location = new System.Drawing.Point(3, 103);
            this.dtgPesos.MultiSelect = false;
            this.dtgPesos.Name = "dtgPesos";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgPesos.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dtgPesos.RowHeadersVisible = false;
            this.dtgPesos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dtgPesos.RowTemplate.Height = 24;
            this.dtgPesos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPesos.Size = new System.Drawing.Size(1001, 390);
            this.dtgPesos.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Controls.Add(this.swtchCapturar);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1001, 100);
            this.groupBox2.TabIndex = 6;
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
            // notifyEmpaques
            // 
            this.notifyEmpaques.Text = "notifyIcon1";
            this.notifyEmpaques.Visible = true;
            // 
            // VEmpaques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1015, 532);
            this.Controls.Add(this.tabControl1);
            this.Name = "VEmpaques";
            this.Text = "VEmpaques";
            this.Load += new System.EventHandler(this.VEmpaques_Load);
            this.tabControl1.ResumeLayout(false);
            this.Empaque.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmpaque)).EndInit();
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
        private System.Windows.Forms.TabPage Empaque;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.TextBox txtNumeración;
        private System.Windows.Forms.ComboBox cmbCalibre;
        private System.Windows.Forms.ComboBox cmbPuerto;
        private System.Windows.Forms.ComboBox cmbPresentacion;
        private System.Windows.Forms.ComboBox cmbVariedad;
        private System.Windows.Forms.ComboBox cmbProductor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage Pesajes;
        private System.Windows.Forms.DataGridView dtgEmpaque;
        private System.Windows.Forms.DataGridView dtgPesos;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialSwitch swtchCapturar;
        private System.Windows.Forms.NotifyIcon notifyEmpaques;
    }
}