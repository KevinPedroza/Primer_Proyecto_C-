namespace Interfaces
{
    partial class A_Hotel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(A_Hotel));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.verificar = new System.Windows.Forms.PictureBox();
            this.buscardestino = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.niños = new System.Windows.Forms.NumericUpDown();
            this.adultos = new System.Windows.Forms.NumericUpDown();
            this.habi = new System.Windows.Forms.NumericUpDown();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ffin = new Bunifu.Framework.UI.BunifuDatepicker();
            this.fini = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hoteles = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.habitaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lugar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cali = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.bunifuThinButton23 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.continuar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.verificar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.niños)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adultos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.habi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoteles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(275, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Busca tu Alojamiento";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.verificar);
            this.panel1.Controls.Add(this.buscardestino);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.niños);
            this.panel1.Controls.Add(this.adultos);
            this.panel1.Controls.Add(this.habi);
            this.panel1.Controls.Add(this.bunifuThinButton21);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.ffin);
            this.panel1.Controls.Add(this.fini);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(95, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 204);
            this.panel1.TabIndex = 1;
            // 
            // verificar
            // 
            this.verificar.Image = global::Interfaces.Properties.Resources.Ok_48px;
            this.verificar.Location = new System.Drawing.Point(446, 162);
            this.verificar.Margin = new System.Windows.Forms.Padding(0);
            this.verificar.Name = "verificar";
            this.verificar.Size = new System.Drawing.Size(50, 35);
            this.verificar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.verificar.TabIndex = 15;
            this.verificar.TabStop = false;
            this.verificar.Visible = false;
            // 
            // buscardestino
            // 
            this.buscardestino.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.buscardestino.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.buscardestino.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buscardestino.HintForeColor = System.Drawing.Color.Empty;
            this.buscardestino.HintText = "Ingrese un País, Lugar o Hotel";
            this.buscardestino.isPassword = false;
            this.buscardestino.LineFocusedColor = System.Drawing.Color.Blue;
            this.buscardestino.LineIdleColor = System.Drawing.Color.Gray;
            this.buscardestino.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.buscardestino.LineThickness = 3;
            this.buscardestino.Location = new System.Drawing.Point(38, 32);
            this.buscardestino.Margin = new System.Windows.Forms.Padding(4);
            this.buscardestino.Name = "buscardestino";
            this.buscardestino.Size = new System.Drawing.Size(370, 44);
            this.buscardestino.TabIndex = 14;
            this.buscardestino.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buscardestino.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.buscardestino_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Interfaces.Properties.Resources.Hotel_50px;
            this.pictureBox1.Location = new System.Drawing.Point(432, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // niños
            // 
            this.niños.Location = new System.Drawing.Point(447, 139);
            this.niños.Name = "niños";
            this.niños.Size = new System.Drawing.Size(96, 20);
            this.niños.TabIndex = 12;
            // 
            // adultos
            // 
            this.adultos.Location = new System.Drawing.Point(447, 116);
            this.adultos.Name = "adultos";
            this.adultos.Size = new System.Drawing.Size(96, 20);
            this.adultos.TabIndex = 11;
            // 
            // habi
            // 
            this.habi.Location = new System.Drawing.Point(447, 92);
            this.habi.Name = "habi";
            this.habi.Size = new System.Drawing.Size(96, 20);
            this.habi.TabIndex = 10;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.DarkSalmon;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.Turquoise;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.Silver;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Verificar Información";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.SystemColors.Highlight;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.White;
            this.bunifuThinButton21.Location = new System.Drawing.Point(38, 160);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(403, 41);
            this.bunifuThinButton21.TabIndex = 9;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(404, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Niños";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(394, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Adultos";
            // 
            // ffin
            // 
            this.ffin.BackColor = System.Drawing.Color.White;
            this.ffin.BorderRadius = 0;
            this.ffin.ForeColor = System.Drawing.Color.Black;
            this.ffin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ffin.FormatCustom = null;
            this.ffin.Location = new System.Drawing.Point(193, 110);
            this.ffin.Margin = new System.Windows.Forms.Padding(0);
            this.ffin.Name = "ffin";
            this.ffin.Size = new System.Drawing.Size(168, 37);
            this.ffin.TabIndex = 6;
            this.ffin.Value = new System.DateTime(2018, 3, 3, 0, 0, 0, 0);
            // 
            // fini
            // 
            this.fini.BackColor = System.Drawing.Color.White;
            this.fini.BorderRadius = 0;
            this.fini.ForeColor = System.Drawing.Color.Black;
            this.fini.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fini.FormatCustom = null;
            this.fini.Location = new System.Drawing.Point(14, 110);
            this.fini.Margin = new System.Windows.Forms.Padding(0);
            this.fini.Name = "fini";
            this.fini.Size = new System.Drawing.Size(169, 37);
            this.fini.TabIndex = 5;
            this.fini.Value = new System.DateTime(2018, 2, 28, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(367, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Habitaciones";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(242, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha Salida";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(62, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha Inicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(35, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Destino";
            // 
            // hoteles
            // 
            this.hoteles.AllowUserToAddRows = false;
            this.hoteles.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.hoteles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.hoteles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.hoteles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.hoteles.BackgroundColor = System.Drawing.Color.LightGray;
            this.hoteles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hoteles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.hoteles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.hoteles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hoteles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nombre,
            this.habitaciones,
            this.pais,
            this.lugar,
            this.cali,
            this.precio});
            this.hoteles.DoubleBuffered = true;
            this.hoteles.EnableHeadersVisualStyles = false;
            this.hoteles.HeaderBgColor = System.Drawing.Color.ForestGreen;
            this.hoteles.HeaderForeColor = System.Drawing.Color.Black;
            this.hoteles.Location = new System.Drawing.Point(12, 268);
            this.hoteles.MultiSelect = false;
            this.hoteles.Name = "hoteles";
            this.hoteles.ReadOnly = true;
            this.hoteles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.hoteles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.hoteles.Size = new System.Drawing.Size(654, 234);
            this.hoteles.TabIndex = 2;
            this.hoteles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.hoteles_CellClick);
            this.hoteles.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.hoteles_CellFormatting);
            // 
            // id
            // 
            this.id.HeaderText = "Código Hotel";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // habitaciones
            // 
            this.habitaciones.HeaderText = "Habitaciones";
            this.habitaciones.Name = "habitaciones";
            this.habitaciones.ReadOnly = true;
            // 
            // pais
            // 
            this.pais.HeaderText = "País";
            this.pais.Name = "pais";
            this.pais.ReadOnly = true;
            // 
            // lugar
            // 
            this.lugar.HeaderText = "Lugar";
            this.lugar.Name = "lugar";
            this.lugar.ReadOnly = true;
            // 
            // cali
            // 
            this.cali.HeaderText = "Calificación";
            this.cali.Name = "cali";
            this.cali.ReadOnly = true;
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(313, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 18);
            this.label8.TabIndex = 16;
            this.label8.Text = "Selecciona un Hotel";
            // 
            // bunifuThinButton23
            // 
            this.bunifuThinButton23.ActiveBorderThickness = 1;
            this.bunifuThinButton23.ActiveCornerRadius = 20;
            this.bunifuThinButton23.ActiveFillColor = System.Drawing.Color.DarkSalmon;
            this.bunifuThinButton23.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton23.ActiveLineColor = System.Drawing.Color.Turquoise;
            this.bunifuThinButton23.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bunifuThinButton23.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton23.BackgroundImage")));
            this.bunifuThinButton23.ButtonText = "Cancelar";
            this.bunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton23.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton23.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.IdleBorderThickness = 1;
            this.bunifuThinButton23.IdleCornerRadius = 20;
            this.bunifuThinButton23.IdleFillColor = System.Drawing.Color.Brown;
            this.bunifuThinButton23.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton23.IdleLineColor = System.Drawing.Color.White;
            this.bunifuThinButton23.Location = new System.Drawing.Point(461, 503);
            this.bunifuThinButton23.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton23.Name = "bunifuThinButton23";
            this.bunifuThinButton23.Size = new System.Drawing.Size(205, 45);
            this.bunifuThinButton23.TabIndex = 15;
            this.bunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton23.Click += new System.EventHandler(this.bunifuThinButton23_Click);
            // 
            // continuar
            // 
            this.continuar.ActiveBorderThickness = 1;
            this.continuar.ActiveCornerRadius = 20;
            this.continuar.ActiveFillColor = System.Drawing.Color.DarkSalmon;
            this.continuar.ActiveForecolor = System.Drawing.Color.White;
            this.continuar.ActiveLineColor = System.Drawing.Color.Turquoise;
            this.continuar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.continuar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("continuar.BackgroundImage")));
            this.continuar.ButtonText = "Continuar";
            this.continuar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.continuar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continuar.ForeColor = System.Drawing.Color.SeaGreen;
            this.continuar.IdleBorderThickness = 1;
            this.continuar.IdleCornerRadius = 20;
            this.continuar.IdleFillColor = System.Drawing.Color.Brown;
            this.continuar.IdleForecolor = System.Drawing.Color.White;
            this.continuar.IdleLineColor = System.Drawing.Color.White;
            this.continuar.Location = new System.Drawing.Point(95, 503);
            this.continuar.Margin = new System.Windows.Forms.Padding(5);
            this.continuar.Name = "continuar";
            this.continuar.Size = new System.Drawing.Size(197, 45);
            this.continuar.TabIndex = 14;
            this.continuar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.continuar.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(673, 268);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(174, 234);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(739, 247);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 18);
            this.label9.TabIndex = 18;
            this.label9.Text = "Foto";
            // 
            // A_Hotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(859, 562);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bunifuThinButton23);
            this.Controls.Add(this.continuar);
            this.Controls.Add(this.hoteles);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "A_Hotel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "A_Hotel";
            this.Load += new System.EventHandler(this.A_Hotel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.verificar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.niños)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adultos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.habi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoteles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown adultos;
        private System.Windows.Forms.NumericUpDown habi;
        private System.Windows.Forms.NumericUpDown niños;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton23;
        private Bunifu.Framework.UI.BunifuThinButton2 continuar;
        private Bunifu.Framework.UI.BunifuCustomDataGrid hoteles;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuMaterialTextbox buscardestino;
        private System.Windows.Forms.PictureBox verificar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn habitaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn pais;
        private System.Windows.Forms.DataGridViewTextBoxColumn lugar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cali;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        public Bunifu.Framework.UI.BunifuDatepicker ffin;
        public Bunifu.Framework.UI.BunifuDatepicker fini;
    }
}