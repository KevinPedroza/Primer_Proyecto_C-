namespace Interfaces
{
    partial class CRUD_hoteles
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUD_hoteles));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.habitaciones = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.lugar = new System.Windows.Forms.ComboBox();
            this.pais = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nombre = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.id = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.mostrarinfo = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.identificador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fot = new System.Windows.Forms.DataGridViewImageColumn();
            this.Habi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.País = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lugar2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.eliminarinfo = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.newid = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label13 = new System.Windows.Forms.Label();
            this.newnombre = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label14 = new System.Windows.Forms.Label();
            this.newhabitaciones = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.newpais = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.newlugar = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.newimage = new System.Windows.Forms.PictureBox();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.modificarinfo = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.habitaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarinfo)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eliminarinfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newhabitaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newimage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modificarinfo)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(782, 480);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Silver;
            this.tabPage1.Controls.Add(this.bunifuThinButton21);
            this.tabPage1.Controls.Add(this.habitaciones);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.lugar);
            this.tabPage1.Controls.Add(this.pais);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.nombre);
            this.tabPage1.Controls.Add(this.id);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(774, 454);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Insertar Hotel";
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.Silver;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Registrar Hotel";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.SandyBrown;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.Green;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Location = new System.Drawing.Point(479, 168);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(270, 62);
            this.bunifuThinButton21.TabIndex = 13;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // habitaciones
            // 
            this.habitaciones.Location = new System.Drawing.Point(289, 301);
            this.habitaciones.Name = "habitaciones";
            this.habitaciones.Size = new System.Drawing.Size(155, 20);
            this.habitaciones.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(304, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 26);
            this.label7.TabIndex = 11;
            this.label7.Text = "Habitaciones";
            // 
            // lugar
            // 
            this.lugar.FormattingEnabled = true;
            this.lugar.Location = new System.Drawing.Point(289, 209);
            this.lugar.Name = "lugar";
            this.lugar.Size = new System.Drawing.Size(155, 21);
            this.lugar.TabIndex = 10;
            // 
            // pais
            // 
            this.pais.FormattingEnabled = true;
            this.pais.Location = new System.Drawing.Point(289, 110);
            this.pais.Name = "pais";
            this.pais.Size = new System.Drawing.Size(155, 21);
            this.pais.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(330, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 26);
            this.label6.TabIndex = 8;
            this.label6.Text = "Lugar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(335, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 26);
            this.label5.TabIndex = 7;
            this.label5.Text = "País";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(36, 291);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // nombre
            // 
            this.nombre.BorderColor = System.Drawing.Color.SeaGreen;
            this.nombre.Enabled = false;
            this.nombre.Location = new System.Drawing.Point(36, 209);
            this.nombre.Multiline = true;
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(171, 28);
            this.nombre.TabIndex = 5;
            this.nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombre_KeyPress);
            // 
            // id
            // 
            this.id.BorderColor = System.Drawing.Color.SeaGreen;
            this.id.Location = new System.Drawing.Point(36, 110);
            this.id.Multiline = true;
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(171, 28);
            this.id.TabIndex = 4;
            this.id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.id_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Seleccione una Foto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Identificador";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese un Hotel";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Silver;
            this.tabPage2.Controls.Add(this.modificarinfo);
            this.tabPage2.Controls.Add(this.bunifuThinButton22);
            this.tabPage2.Controls.Add(this.newimage);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.newlugar);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.newpais);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.newhabitaciones);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.newnombre);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.newid);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(774, 454);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modificar Hoteles";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Silver;
            this.tabPage3.Controls.Add(this.mostrarinfo);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(774, 454);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Mostrar Hoteles";
            // 
            // mostrarinfo
            // 
            this.mostrarinfo.AllowUserToAddRows = false;
            this.mostrarinfo.AllowUserToDeleteRows = false;
            this.mostrarinfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mostrarinfo.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.mostrarinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mostrarinfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.identificador,
            this.nombre2,
            this.fot,
            this.Habi,
            this.País,
            this.Lugar2});
            this.mostrarinfo.Location = new System.Drawing.Point(32, 59);
            this.mostrarinfo.Name = "mostrarinfo";
            this.mostrarinfo.ReadOnly = true;
            this.mostrarinfo.RowTemplate.Height = 120;
            this.mostrarinfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mostrarinfo.Size = new System.Drawing.Size(709, 324);
            this.mostrarinfo.TabIndex = 1;
            this.mostrarinfo.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.mostrarinfo_CellFormatting);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(235, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(273, 33);
            this.label8.TabIndex = 0;
            this.label8.Text = "Información de Hoteles";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Silver;
            this.tabPage4.Controls.Add(this.eliminarinfo);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(774, 454);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Eliminar Hoteles";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // identificador
            // 
            this.identificador.FillWeight = 94.29031F;
            this.identificador.HeaderText = "Identificador";
            this.identificador.Name = "identificador";
            this.identificador.ReadOnly = true;
            // 
            // nombre2
            // 
            this.nombre2.FillWeight = 82.99335F;
            this.nombre2.HeaderText = "Nombre";
            this.nombre2.Name = "nombre2";
            this.nombre2.ReadOnly = true;
            // 
            // fot
            // 
            this.fot.FillWeight = 166.4382F;
            this.fot.HeaderText = "Foto";
            this.fot.Name = "fot";
            this.fot.ReadOnly = true;
            // 
            // Habi
            // 
            this.Habi.FillWeight = 81.45032F;
            this.Habi.HeaderText = "Habitaciones";
            this.Habi.Name = "Habi";
            this.Habi.ReadOnly = true;
            // 
            // País
            // 
            this.País.FillWeight = 85.27917F;
            this.País.HeaderText = "País";
            this.País.Name = "País";
            this.País.ReadOnly = true;
            // 
            // Lugar2
            // 
            this.Lugar2.FillWeight = 89.54858F;
            this.Lugar2.HeaderText = "Lugar";
            this.Lugar2.Name = "Lugar2";
            this.Lugar2.ReadOnly = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(259, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(195, 33);
            this.label9.TabIndex = 0;
            this.label9.Text = "Eliminar Hoteles";
            // 
            // eliminarinfo
            // 
            this.eliminarinfo.AllowUserToAddRows = false;
            this.eliminarinfo.AllowUserToDeleteRows = false;
            this.eliminarinfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.eliminarinfo.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.eliminarinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eliminarinfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.eliminarinfo.Location = new System.Drawing.Point(33, 65);
            this.eliminarinfo.Name = "eliminarinfo";
            this.eliminarinfo.ReadOnly = true;
            this.eliminarinfo.RowTemplate.Height = 120;
            this.eliminarinfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.eliminarinfo.Size = new System.Drawing.Size(709, 324);
            this.eliminarinfo.TabIndex = 2;
            this.eliminarinfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.eliminarinfo_CellClick);
            this.eliminarinfo.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.eliminarinfo_CellFormatting);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 94.29031F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Identificador";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 82.99335F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 166.4382F;
            this.dataGridViewImageColumn1.HeaderText = "Foto";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.FillWeight = 81.45032F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Habitaciones";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.FillWeight = 85.27917F;
            this.dataGridViewTextBoxColumn4.HeaderText = "País";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.FillWeight = 89.54858F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Lugar";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(274, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(209, 33);
            this.label10.TabIndex = 0;
            this.label10.Text = "Modificar Hoteles";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(42, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 26);
            this.label11.TabIndex = 2;
            this.label11.Text = "Identificador";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(418, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(188, 26);
            this.label12.TabIndex = 3;
            this.label12.Text = "Seleccione un Hotel";
            // 
            // newid
            // 
            this.newid.BorderColor = System.Drawing.Color.SeaGreen;
            this.newid.Enabled = false;
            this.newid.Location = new System.Drawing.Point(21, 68);
            this.newid.Multiline = true;
            this.newid.Name = "newid";
            this.newid.Size = new System.Drawing.Size(166, 30);
            this.newid.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(56, 114);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 26);
            this.label13.TabIndex = 5;
            this.label13.Text = "Nombre";
            // 
            // newnombre
            // 
            this.newnombre.BorderColor = System.Drawing.Color.SeaGreen;
            this.newnombre.Enabled = false;
            this.newnombre.Location = new System.Drawing.Point(21, 143);
            this.newnombre.Multiline = true;
            this.newnombre.Name = "newnombre";
            this.newnombre.Size = new System.Drawing.Size(166, 30);
            this.newnombre.TabIndex = 6;
            this.newnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.newnombre_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(42, 188);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(129, 26);
            this.label14.TabIndex = 7;
            this.label14.Text = "Habitaciones";
            // 
            // newhabitaciones
            // 
            this.newhabitaciones.Location = new System.Drawing.Point(21, 217);
            this.newhabitaciones.Name = "newhabitaciones";
            this.newhabitaciones.Size = new System.Drawing.Size(166, 20);
            this.newhabitaciones.TabIndex = 8;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(77, 262);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 26);
            this.label15.TabIndex = 9;
            this.label15.Text = "País";
            // 
            // newpais
            // 
            this.newpais.FormattingEnabled = true;
            this.newpais.Location = new System.Drawing.Point(21, 291);
            this.newpais.Name = "newpais";
            this.newpais.Size = new System.Drawing.Size(166, 21);
            this.newpais.TabIndex = 10;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(77, 326);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 26);
            this.label16.TabIndex = 11;
            this.label16.Text = "Lugar";
            // 
            // newlugar
            // 
            this.newlugar.FormattingEnabled = true;
            this.newlugar.Location = new System.Drawing.Point(21, 355);
            this.newlugar.Name = "newlugar";
            this.newlugar.Size = new System.Drawing.Size(166, 21);
            this.newlugar.TabIndex = 12;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(301, 262);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(114, 26);
            this.label17.TabIndex = 13;
            this.label17.Text = "Foto Nueva";
            // 
            // newimage
            // 
            this.newimage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newimage.Location = new System.Drawing.Point(260, 291);
            this.newimage.Name = "newimage";
            this.newimage.Size = new System.Drawing.Size(187, 148);
            this.newimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.newimage.TabIndex = 14;
            this.newimage.TabStop = false;
            this.newimage.Click += new System.EventHandler(this.newimage_Click);
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.BackColor = System.Drawing.Color.Silver;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "Modificar Hotel";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.Peru;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.Location = new System.Drawing.Point(489, 311);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(251, 54);
            this.bunifuThinButton22.TabIndex = 15;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // modificarinfo
            // 
            this.modificarinfo.AllowUserToAddRows = false;
            this.modificarinfo.AllowUserToDeleteRows = false;
            this.modificarinfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.modificarinfo.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.modificarinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modificarinfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewImageColumn2,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.modificarinfo.Location = new System.Drawing.Point(236, 62);
            this.modificarinfo.Name = "modificarinfo";
            this.modificarinfo.ReadOnly = true;
            this.modificarinfo.RowTemplate.Height = 120;
            this.modificarinfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.modificarinfo.Size = new System.Drawing.Size(532, 197);
            this.modificarinfo.TabIndex = 16;
            this.modificarinfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.modificarinfo_CellClick);
            this.modificarinfo.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.modificarinfo_CellFormatting);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.FillWeight = 94.29031F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Identificador";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.FillWeight = 82.99335F;
            this.dataGridViewTextBoxColumn7.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.FillWeight = 166.4382F;
            this.dataGridViewImageColumn2.HeaderText = "Foto";
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.FillWeight = 81.45032F;
            this.dataGridViewTextBoxColumn8.HeaderText = "Habitaciones";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.FillWeight = 85.27917F;
            this.dataGridViewTextBoxColumn9.HeaderText = "País";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.FillWeight = 89.54858F;
            this.dataGridViewTextBoxColumn10.HeaderText = "Lugar";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // CRUD_hoteles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "CRUD_hoteles";
            this.Size = new System.Drawing.Size(782, 480);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.habitaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarinfo)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eliminarinfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newhabitaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newimage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modificarinfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private System.Windows.Forms.NumericUpDown habitaciones;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox nombre;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public System.Windows.Forms.ComboBox lugar;
        public System.Windows.Forms.ComboBox pais;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView mostrarinfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn identificador;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre2;
        private System.Windows.Forms.DataGridViewImageColumn fot;
        private System.Windows.Forms.DataGridViewTextBoxColumn Habi;
        private System.Windows.Forms.DataGridViewTextBoxColumn País;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lugar2;
        private System.Windows.Forms.DataGridView eliminarinfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private System.Windows.Forms.PictureBox newimage;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox newlugar;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox newpais;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown newhabitaciones;
        private System.Windows.Forms.Label label14;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox newnombre;
        private System.Windows.Forms.Label label13;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox newid;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView modificarinfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    }
}
