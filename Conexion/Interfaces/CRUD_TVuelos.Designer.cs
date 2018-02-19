namespace Interfaces
{
    partial class CRUD_TVuelos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUD_TVuelos));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.rutas = new System.Windows.Forms.DataGridView();
            this.precio = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.id = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.modificarinfo = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.newruta = new System.Windows.Forms.DataGridView();
            this.newprecio = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.newid = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.mostrarinfo = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.eliminarinfo = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rutas)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modificarinfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newruta)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarinfo)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eliminarinfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(782, 477);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Silver;
            this.tabPage1.Controls.Add(this.bunifuThinButton21);
            this.tabPage1.Controls.Add(this.rutas);
            this.tabPage1.Controls.Add(this.precio);
            this.tabPage1.Controls.Add(this.id);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(774, 451);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ingresar Tarifa de Vuelos";
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.Silver;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Registrar Tarifa ";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.Gold;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.Tan;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.Green;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.Green;
            this.bunifuThinButton21.Location = new System.Drawing.Point(245, 304);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(288, 52);
            this.bunifuThinButton21.TabIndex = 7;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // rutas
            // 
            this.rutas.AllowUserToAddRows = false;
            this.rutas.AllowUserToDeleteRows = false;
            this.rutas.AllowUserToResizeColumns = false;
            this.rutas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.rutas.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.rutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rutas.Location = new System.Drawing.Point(245, 130);
            this.rutas.MultiSelect = false;
            this.rutas.Name = "rutas";
            this.rutas.ReadOnly = true;
            this.rutas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rutas.Size = new System.Drawing.Size(291, 93);
            this.rutas.TabIndex = 6;
            // 
            // precio
            // 
            this.precio.BorderColor = System.Drawing.Color.SeaGreen;
            this.precio.Location = new System.Drawing.Point(579, 130);
            this.precio.Multiline = true;
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(167, 29);
            this.precio.TabIndex = 5;
            this.precio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bunifuCustomTextbox2_KeyPress);
            // 
            // id
            // 
            this.id.BorderColor = System.Drawing.Color.SeaGreen;
            this.id.Location = new System.Drawing.Point(25, 130);
            this.id.Multiline = true;
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(167, 29);
            this.id.TabIndex = 4;
            this.id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bunifuCustomTextbox1_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Identificador";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(292, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Seleccione la Ruta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(624, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese la Tarifa";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Silver;
            this.tabPage2.Controls.Add(this.bunifuThinButton22);
            this.tabPage2.Controls.Add(this.modificarinfo);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.newruta);
            this.tabPage2.Controls.Add(this.newprecio);
            this.tabPage2.Controls.Add(this.newid);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(774, 451);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modificar Tarifa de Vuelos";
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.Snow;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.BackColor = System.Drawing.Color.Silver;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "Modificar Tarifa";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.Khaki;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.LightSeaGreen;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.Location = new System.Drawing.Point(382, 350);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(312, 51);
            this.bunifuThinButton22.TabIndex = 10;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // modificarinfo
            // 
            this.modificarinfo.AllowUserToAddRows = false;
            this.modificarinfo.AllowUserToDeleteRows = false;
            this.modificarinfo.AllowUserToResizeColumns = false;
            this.modificarinfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.modificarinfo.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.modificarinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modificarinfo.Location = new System.Drawing.Point(338, 123);
            this.modificarinfo.Name = "modificarinfo";
            this.modificarinfo.ReadOnly = true;
            this.modificarinfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.modificarinfo.Size = new System.Drawing.Size(417, 173);
            this.modificarinfo.TabIndex = 9;
            this.modificarinfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.modificarinfo_CellClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(438, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(221, 28);
            this.label11.TabIndex = 8;
            this.label11.Text = "Seleccione una Tarifa";
            // 
            // newruta
            // 
            this.newruta.AllowUserToAddRows = false;
            this.newruta.AllowUserToDeleteRows = false;
            this.newruta.AllowUserToResizeColumns = false;
            this.newruta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.newruta.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.newruta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.newruta.Location = new System.Drawing.Point(15, 299);
            this.newruta.Name = "newruta";
            this.newruta.ReadOnly = true;
            this.newruta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.newruta.Size = new System.Drawing.Size(241, 93);
            this.newruta.TabIndex = 7;
            // 
            // newprecio
            // 
            this.newprecio.BorderColor = System.Drawing.Color.SeaGreen;
            this.newprecio.Location = new System.Drawing.Point(45, 209);
            this.newprecio.Multiline = true;
            this.newprecio.Name = "newprecio";
            this.newprecio.Size = new System.Drawing.Size(168, 29);
            this.newprecio.TabIndex = 5;
            this.newprecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.newprecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.newprecio_KeyPress);
            // 
            // newid
            // 
            this.newid.BorderColor = System.Drawing.Color.SeaGreen;
            this.newid.Enabled = false;
            this.newid.Location = new System.Drawing.Point(45, 111);
            this.newid.Multiline = true;
            this.newid.Name = "newid";
            this.newid.Size = new System.Drawing.Size(168, 29);
            this.newid.TabIndex = 4;
            this.newid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(103, 268);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 28);
            this.label10.TabIndex = 3;
            this.label10.Text = "Ruta";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(91, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 28);
            this.label9.TabIndex = 2;
            this.label9.Text = "Precio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(65, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 28);
            this.label8.TabIndex = 1;
            this.label8.Text = "Identificador";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(217, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(300, 33);
            this.label7.TabIndex = 0;
            this.label7.Text = "Modifique la información ";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Silver;
            this.tabPage3.Controls.Add(this.mostrarinfo);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(774, 451);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Mostrar Tarifas de Vuelos";
            // 
            // mostrarinfo
            // 
            this.mostrarinfo.AllowUserToAddRows = false;
            this.mostrarinfo.AllowUserToDeleteRows = false;
            this.mostrarinfo.AllowUserToResizeColumns = false;
            this.mostrarinfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mostrarinfo.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.mostrarinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mostrarinfo.Location = new System.Drawing.Point(59, 56);
            this.mostrarinfo.Name = "mostrarinfo";
            this.mostrarinfo.ReadOnly = true;
            this.mostrarinfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mostrarinfo.Size = new System.Drawing.Size(653, 320);
            this.mostrarinfo.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(212, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(300, 33);
            this.label5.TabIndex = 0;
            this.label5.Text = "Información de las Tarifas";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Silver;
            this.tabPage4.Controls.Add(this.eliminarinfo);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(774, 451);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Eliminar Tarifa de Vuelos";
            // 
            // eliminarinfo
            // 
            this.eliminarinfo.AllowUserToAddRows = false;
            this.eliminarinfo.AllowUserToDeleteRows = false;
            this.eliminarinfo.AllowUserToResizeColumns = false;
            this.eliminarinfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.eliminarinfo.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.eliminarinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eliminarinfo.Location = new System.Drawing.Point(48, 59);
            this.eliminarinfo.MultiSelect = false;
            this.eliminarinfo.Name = "eliminarinfo";
            this.eliminarinfo.ReadOnly = true;
            this.eliminarinfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.eliminarinfo.Size = new System.Drawing.Size(670, 291);
            this.eliminarinfo.TabIndex = 1;
            this.eliminarinfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.eliminarinfo_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Open Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(167, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(402, 33);
            this.label6.TabIndex = 0;
            this.label6.Text = "Seleccione una Tarifa para Eliminar";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // CRUD_TVuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "CRUD_TVuelos";
            this.Size = new System.Drawing.Size(782, 477);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rutas)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modificarinfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newruta)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarinfo)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eliminarinfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox precio;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox id;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        public System.Windows.Forms.DataGridView rutas;
        private System.Windows.Forms.DataGridView mostrarinfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView eliminarinfo;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private System.Windows.Forms.DataGridView modificarinfo;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.DataGridView newruta;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox newprecio;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox newid;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
