namespace Interfaces
{
    partial class Registro
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.usuario = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.contra = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.concontra = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cedula = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.button2 = new System.Windows.Forms.Button();
            this.tipo = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 458);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Image = global::Interfaces.Properties.Resources.Back_64px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.Location = new System.Drawing.Point(47, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 74);
            this.button1.TabIndex = 1;
            this.button1.Text = "Atrás";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Interfaces.Properties.Resources.Contacts_64px;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 458);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(297, 18);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(126, 20);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Nombre/Usuario";
            // 
            // usuario
            // 
            this.usuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usuario.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.usuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.usuario.HintForeColor = System.Drawing.Color.Empty;
            this.usuario.HintText = "Nombre/Usuario";
            this.usuario.isPassword = false;
            this.usuario.LineFocusedColor = System.Drawing.Color.LightSkyBlue;
            this.usuario.LineIdleColor = System.Drawing.Color.Gray;
            this.usuario.LineMouseHoverColor = System.Drawing.Color.LightSkyBlue;
            this.usuario.LineThickness = 3;
            this.usuario.Location = new System.Drawing.Point(219, 42);
            this.usuario.Margin = new System.Windows.Forms.Padding(4);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(294, 33);
            this.usuario.TabIndex = 2;
            this.usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(315, 109);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(87, 20);
            this.bunifuCustomLabel2.TabIndex = 3;
            this.bunifuCustomLabel2.Text = "Contraseña";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(334, 272);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(56, 20);
            this.bunifuCustomLabel3.TabIndex = 4;
            this.bunifuCustomLabel3.Text = "Cedúla";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(280, 195);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(161, 20);
            this.bunifuCustomLabel4.TabIndex = 5;
            this.bunifuCustomLabel4.Text = "Confirmar Contraseña";
            // 
            // contra
            // 
            this.contra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.contra.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.contra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.contra.HintForeColor = System.Drawing.Color.Empty;
            this.contra.HintText = "";
            this.contra.isPassword = true;
            this.contra.LineFocusedColor = System.Drawing.Color.LightSkyBlue;
            this.contra.LineIdleColor = System.Drawing.Color.Gray;
            this.contra.LineMouseHoverColor = System.Drawing.Color.LightSkyBlue;
            this.contra.LineThickness = 3;
            this.contra.Location = new System.Drawing.Point(219, 133);
            this.contra.Margin = new System.Windows.Forms.Padding(4);
            this.contra.Name = "contra";
            this.contra.Size = new System.Drawing.Size(294, 33);
            this.contra.TabIndex = 6;
            this.contra.Text = "Password";
            this.contra.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.contra.Enter += new System.EventHandler(this.bunifuMaterialTextbox2_Enter);
            // 
            // concontra
            // 
            this.concontra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.concontra.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.concontra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.concontra.HintForeColor = System.Drawing.Color.Empty;
            this.concontra.HintText = "";
            this.concontra.isPassword = true;
            this.concontra.LineFocusedColor = System.Drawing.Color.LightSkyBlue;
            this.concontra.LineIdleColor = System.Drawing.Color.Gray;
            this.concontra.LineMouseHoverColor = System.Drawing.Color.LightSkyBlue;
            this.concontra.LineThickness = 3;
            this.concontra.Location = new System.Drawing.Point(219, 219);
            this.concontra.Margin = new System.Windows.Forms.Padding(4);
            this.concontra.Name = "concontra";
            this.concontra.Size = new System.Drawing.Size(294, 33);
            this.concontra.TabIndex = 7;
            this.concontra.Text = "Password";
            this.concontra.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.concontra.Enter += new System.EventHandler(this.bunifuMaterialTextbox3_Enter);
            // 
            // cedula
            // 
            this.cedula.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cedula.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cedula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cedula.HintForeColor = System.Drawing.Color.Empty;
            this.cedula.HintText = "Cedúla";
            this.cedula.isPassword = false;
            this.cedula.LineFocusedColor = System.Drawing.Color.LightSkyBlue;
            this.cedula.LineIdleColor = System.Drawing.Color.Gray;
            this.cedula.LineMouseHoverColor = System.Drawing.Color.LightSkyBlue;
            this.cedula.LineThickness = 3;
            this.cedula.Location = new System.Drawing.Point(219, 296);
            this.cedula.Margin = new System.Windows.Forms.Padding(4);
            this.cedula.Name = "cedula";
            this.cedula.Size = new System.Drawing.Size(294, 33);
            this.cedula.TabIndex = 8;
            this.cedula.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.Image = global::Interfaces.Properties.Resources.Edit_64px;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(284, 385);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 60);
            this.button2.TabIndex = 9;
            this.button2.Text = "Registrar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tipo
            // 
            this.tipo.AutoSize = true;
            this.tipo.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipo.Location = new System.Drawing.Point(301, 345);
            this.tipo.Name = "tipo";
            this.tipo.Size = new System.Drawing.Size(127, 24);
            this.tipo.TabIndex = 10;
            this.tipo.Text = "Administrador";
            this.tipo.UseVisualStyleBackColor = true;
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 457);
            this.Controls.Add(this.tipo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cedula);
            this.Controls.Add(this.concontra);
            this.Controls.Add(this.contra);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registro_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox usuario;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox contra;
        private Bunifu.Framework.UI.BunifuMaterialTextbox concontra;
        private Bunifu.Framework.UI.BunifuMaterialTextbox cedula;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox tipo;
    }
}