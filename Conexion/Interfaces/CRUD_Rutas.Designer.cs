namespace Interfaces
{
    partial class CRUD_Rutas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUD_Rutas));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.duracionin = new System.Windows.Forms.DomainUpDown();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label5 = new System.Windows.Forms.Label();
            this.pais_destinoin = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pais_origenin = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.id_inruta = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.newduration = new System.Windows.Forms.DomainUpDown();
            this.newdestiny = new System.Windows.Forms.ComboBox();
            this.neworigen = new System.Windows.Forms.ComboBox();
            this.id_modi = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.modify_info = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.mostrar_rutas = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.eliminar_ruta = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modify_info)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mostrar_rutas)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eliminar_ruta)).BeginInit();
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
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.duracionin);
            this.tabPage1.Controls.Add(this.bunifuFlatButton1);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.pais_destinoin);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.pais_origenin);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.id_inruta);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(774, 454);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ingresar Rutas";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Interfaces.Properties.Resources.Sort_Down_50px;
            this.pictureBox2.Location = new System.Drawing.Point(511, 107);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(290, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Hora/Horas";
            // 
            // duracionin
            // 
            this.duracionin.Items.Add("1:00");
            this.duracionin.Items.Add("1:30");
            this.duracionin.Items.Add("2:00");
            this.duracionin.Items.Add("2:30");
            this.duracionin.Items.Add("3:00");
            this.duracionin.Items.Add("3:30");
            this.duracionin.Items.Add("4:00");
            this.duracionin.Items.Add("4:30");
            this.duracionin.Items.Add("5:00");
            this.duracionin.Items.Add("5:30");
            this.duracionin.Items.Add("6:00");
            this.duracionin.Items.Add("6:30");
            this.duracionin.Items.Add("7:00");
            this.duracionin.Items.Add("7:30");
            this.duracionin.Items.Add("8:00");
            this.duracionin.Items.Add("8:30");
            this.duracionin.Items.Add("9:00");
            this.duracionin.Items.Add("9:30");
            this.duracionin.Items.Add("10:00");
            this.duracionin.Items.Add("10:30");
            this.duracionin.Items.Add("11:00");
            this.duracionin.Items.Add("11:30");
            this.duracionin.Items.Add("12:00");
            this.duracionin.Items.Add("24:00");
            this.duracionin.Items.Add("48:00");
            this.duracionin.Location = new System.Drawing.Point(363, 107);
            this.duracionin.Name = "duracionin";
            this.duracionin.Size = new System.Drawing.Size(152, 20);
            this.duracionin.TabIndex = 10;
            this.duracionin.Text = "0:00";
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Registrar";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = false;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = false;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(329, 200);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(260, 54);
            this.bunifuFlatButton1.TabIndex = 8;
            this.bunifuFlatButton1.Text = "Registrar";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(392, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 26);
            this.label5.TabIndex = 7;
            this.label5.Text = "Duración";
            // 
            // pais_destinoin
            // 
            this.pais_destinoin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pais_destinoin.FormattingEnabled = true;
            this.pais_destinoin.Location = new System.Drawing.Point(31, 334);
            this.pais_destinoin.Name = "pais_destinoin";
            this.pais_destinoin.Size = new System.Drawing.Size(191, 21);
            this.pais_destinoin.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "País Destino";
            // 
            // pais_origenin
            // 
            this.pais_origenin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pais_origenin.FormattingEnabled = true;
            this.pais_origenin.Location = new System.Drawing.Point(31, 214);
            this.pais_origenin.Name = "pais_origenin";
            this.pais_origenin.Size = new System.Drawing.Size(191, 21);
            this.pais_origenin.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "País Origen";
            // 
            // id_inruta
            // 
            this.id_inruta.BorderColor = System.Drawing.Color.SeaGreen;
            this.id_inruta.Location = new System.Drawing.Point(31, 97);
            this.id_inruta.Multiline = true;
            this.id_inruta.Name = "id_inruta";
            this.id_inruta.Size = new System.Drawing.Size(191, 30);
            this.id_inruta.TabIndex = 2;
            this.id_inruta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.id_inruta_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Identificador";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese la Información";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Silver;
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.newduration);
            this.tabPage2.Controls.Add(this.newdestiny);
            this.tabPage2.Controls.Add(this.neworigen);
            this.tabPage2.Controls.Add(this.id_modi);
            this.tabPage2.Controls.Add(this.bunifuFlatButton2);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.modify_info);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(774, 454);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modificar Rutas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Interfaces.Properties.Resources.Sort_Down_50px;
            this.pictureBox1.Location = new System.Drawing.Point(209, 353);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(447, 62);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(189, 26);
            this.label14.TabIndex = 11;
            this.label14.Text = "Seleccione una ruta";
            // 
            // newduration
            // 
            this.newduration.Items.Add("1:00");
            this.newduration.Items.Add("1:30");
            this.newduration.Items.Add("2:00");
            this.newduration.Items.Add("2:30");
            this.newduration.Items.Add("3:00");
            this.newduration.Items.Add("3:30");
            this.newduration.Items.Add("4:00");
            this.newduration.Items.Add("4:30");
            this.newduration.Items.Add("5:00");
            this.newduration.Items.Add("5:30");
            this.newduration.Items.Add("6:00");
            this.newduration.Items.Add("6:30");
            this.newduration.Items.Add("7:00");
            this.newduration.Items.Add("7:30");
            this.newduration.Items.Add("8:00");
            this.newduration.Items.Add("8:30");
            this.newduration.Items.Add("9:00");
            this.newduration.Items.Add("9:30");
            this.newduration.Items.Add("10:00");
            this.newduration.Items.Add("10:30");
            this.newduration.Items.Add("11:00");
            this.newduration.Items.Add("11:30");
            this.newduration.Items.Add("12:00");
            this.newduration.Items.Add("24:00");
            this.newduration.Items.Add("48:00");
            this.newduration.Location = new System.Drawing.Point(39, 353);
            this.newduration.Name = "newduration";
            this.newduration.Size = new System.Drawing.Size(174, 20);
            this.newduration.TabIndex = 10;
            this.newduration.Text = "0:00";
            // 
            // newdestiny
            // 
            this.newdestiny.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newdestiny.FormattingEnabled = true;
            this.newdestiny.Location = new System.Drawing.Point(39, 284);
            this.newdestiny.Name = "newdestiny";
            this.newdestiny.Size = new System.Drawing.Size(174, 21);
            this.newdestiny.TabIndex = 9;
            // 
            // neworigen
            // 
            this.neworigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.neworigen.FormattingEnabled = true;
            this.neworigen.Location = new System.Drawing.Point(39, 190);
            this.neworigen.Name = "neworigen";
            this.neworigen.Size = new System.Drawing.Size(174, 21);
            this.neworigen.TabIndex = 8;
            // 
            // id_modi
            // 
            this.id_modi.BorderColor = System.Drawing.Color.SeaGreen;
            this.id_modi.Enabled = false;
            this.id_modi.Location = new System.Drawing.Point(39, 91);
            this.id_modi.Multiline = true;
            this.id_modi.Name = "id_modi";
            this.id_modi.Size = new System.Drawing.Size(174, 29);
            this.id_modi.TabIndex = 7;
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "Modificar Ruta";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = false;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = false;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(426, 301);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.SystemColors.ActiveCaption;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(241, 48);
            this.bunifuFlatButton2.TabIndex = 6;
            this.bunifuFlatButton2.Text = "Modificar Ruta";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(233, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(259, 28);
            this.label13.TabIndex = 5;
            this.label13.Text = "Modifique la información";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(46, 323);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(157, 26);
            this.label12.TabIndex = 4;
            this.label12.Text = "Nueva Duración";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(34, 243);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(187, 26);
            this.label11.TabIndex = 3;
            this.label11.Text = "Nueva ruta Destino";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(34, 152);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(179, 26);
            this.label10.TabIndex = 2;
            this.label10.Text = "Nueva ruta Origen";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(65, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 26);
            this.label9.TabIndex = 1;
            this.label9.Text = "Identificador";
            // 
            // modify_info
            // 
            this.modify_info.AllowUserToAddRows = false;
            this.modify_info.AllowUserToDeleteRows = false;
            this.modify_info.AllowUserToResizeColumns = false;
            this.modify_info.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.modify_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modify_info.Location = new System.Drawing.Point(330, 91);
            this.modify_info.MultiSelect = false;
            this.modify_info.Name = "modify_info";
            this.modify_info.ReadOnly = true;
            this.modify_info.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.modify_info.Size = new System.Drawing.Size(419, 170);
            this.modify_info.TabIndex = 0;
            this.modify_info.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.modify_info_CellClick);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Silver;
            this.tabPage3.Controls.Add(this.mostrar_rutas);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(774, 454);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Mostrar Rutas";
            // 
            // mostrar_rutas
            // 
            this.mostrar_rutas.AllowUserToAddRows = false;
            this.mostrar_rutas.AllowUserToDeleteRows = false;
            this.mostrar_rutas.AllowUserToResizeColumns = false;
            this.mostrar_rutas.AllowUserToResizeRows = false;
            this.mostrar_rutas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mostrar_rutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mostrar_rutas.Location = new System.Drawing.Point(48, 74);
            this.mostrar_rutas.MultiSelect = false;
            this.mostrar_rutas.Name = "mostrar_rutas";
            this.mostrar_rutas.ReadOnly = true;
            this.mostrar_rutas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mostrar_rutas.Size = new System.Drawing.Size(680, 273);
            this.mostrar_rutas.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(238, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(252, 33);
            this.label7.TabIndex = 0;
            this.label7.Text = "Información de Rutas";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Silver;
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.eliminar_ruta);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(774, 454);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Eliminar Rutas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(183, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(385, 33);
            this.label8.TabIndex = 3;
            this.label8.Text = "Seleccione una ruta para Eliminar";
            // 
            // eliminar_ruta
            // 
            this.eliminar_ruta.AllowUserToAddRows = false;
            this.eliminar_ruta.AllowUserToDeleteRows = false;
            this.eliminar_ruta.AllowUserToResizeColumns = false;
            this.eliminar_ruta.AllowUserToResizeRows = false;
            this.eliminar_ruta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.eliminar_ruta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eliminar_ruta.Location = new System.Drawing.Point(38, 76);
            this.eliminar_ruta.MultiSelect = false;
            this.eliminar_ruta.Name = "eliminar_ruta";
            this.eliminar_ruta.ReadOnly = true;
            this.eliminar_ruta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.eliminar_ruta.Size = new System.Drawing.Size(684, 251);
            this.eliminar_ruta.TabIndex = 2;
            this.eliminar_ruta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.eliminar_ruta_CellClick);
            // 
            // CRUD_Rutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.Controls.Add(this.tabControl1);
            this.Name = "CRUD_Rutas";
            this.Size = new System.Drawing.Size(782, 480);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modify_info)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mostrar_rutas)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eliminar_ruta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox id_inruta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DomainUpDown duracionin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView mostrar_rutas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView eliminar_ruta;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DomainUpDown newduration;
        private System.Windows.Forms.ComboBox newdestiny;
        private System.Windows.Forms.ComboBox neworigen;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox id_modi;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView modify_info;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.ComboBox pais_destinoin;
        public System.Windows.Forms.ComboBox pais_origenin;
    }
}
