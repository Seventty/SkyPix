namespace SkyPix
{
    partial class ADM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADM));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.BuscarUsuarioBox = new Bunifu.Framework.UI.BunifuTextbox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.UsuarioLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AdministrarUButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.ExitButton.Location = new System.Drawing.Point(55, 437);
            // 
            // AdmUsuarios
            // 
            this.AdmUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.AdmUsuarios.Location = new System.Drawing.Point(55, 204);
            // 
            // ContactosButton
            // 
            this.ContactosButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.ContactosButton.Location = new System.Drawing.Point(55, 147);
            // 
            // RedactarButton
            // 
            this.RedactarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.RedactarButton.Location = new System.Drawing.Point(55, 97);
            this.RedactarButton.Click += new System.EventHandler(this.RedactarButton_Click_1);
            // 
            // tabControl1
            // 
            this.tabControl1.Location = new System.Drawing.Point(196, 31);
            this.tabControl1.Size = new System.Drawing.Size(729, 485);
            // 
            // EnviarLabel
            // 
            this.EnviarLabel.Location = new System.Drawing.Point(-2, 2);
            // 
            // MensajeBox
            // 
            this.MensajeBox.Location = new System.Drawing.Point(5, 261);
            this.MensajeBox.Size = new System.Drawing.Size(710, 184);
            this.MensajeBox.TabIndex = 10;
            // 
            // CClabel
            // 
            this.CClabel.Location = new System.Drawing.Point(15, 153);
            // 
            // SubjectLabel
            // 
            this.SubjectLabel.Location = new System.Drawing.Point(0, 101);
            // 
            // ParaLabel
            // 
            this.ParaLabel.Location = new System.Drawing.Point(15, 61);
            // 
            // ccBox
            // 
            this.ccBox.Location = new System.Drawing.Point(69, 140);
            this.ccBox.TabIndex = 8;
            // 
            // AsuntoBox
            // 
            this.AsuntoBox.Location = new System.Drawing.Point(69, 88);
            this.AsuntoBox.TabIndex = 7;
            // 
            // paraBox
            // 
            this.paraBox.Location = new System.Drawing.Point(69, 48);
            this.paraBox.TabIndex = 6;
            // 
            // BotonEnviar
            // 
            this.BotonEnviar.ButtonText = "    Enviar";
            this.BotonEnviar.Iconimage_right = global::SkyPix.Properties.Resources.icons8_enviado_100;
            this.BotonEnviar.IconRightVisible = true;
            this.BotonEnviar.IconVisible = true;
            this.BotonEnviar.TabIndex = 0;
            this.BotonEnviar.Text = "    Enviar";
            this.BotonEnviar.Click += new System.EventHandler(this.BotonEnviar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.BuscarUsuarioBox);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.UsuarioLabel);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(929, 57);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(697, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Bienvenido:";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::SkyPix.Properties.Resources.icons8_corona_64;
            this.pictureBox7.Location = new System.Drawing.Point(652, 11);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(37, 38);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 6;
            this.pictureBox7.TabStop = false;
            // 
            // BuscarUsuarioBox
            // 
            this.BuscarUsuarioBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.BuscarUsuarioBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BuscarUsuarioBox.BackgroundImage")));
            this.BuscarUsuarioBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BuscarUsuarioBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(32)))), ((int)(((byte)(60)))));
            this.BuscarUsuarioBox.Icon = ((System.Drawing.Image)(resources.GetObject("BuscarUsuarioBox.Icon")));
            this.BuscarUsuarioBox.Location = new System.Drawing.Point(333, 9);
            this.BuscarUsuarioBox.Name = "BuscarUsuarioBox";
            this.BuscarUsuarioBox.Size = new System.Drawing.Size(250, 42);
            this.BuscarUsuarioBox.TabIndex = 1;
            this.BuscarUsuarioBox.text = "Buscar Usuario";
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(105, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 54);
            this.panel4.TabIndex = 3;
            // 
            // UsuarioLabel
            // 
            this.UsuarioLabel.AutoSize = true;
            this.UsuarioLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.UsuarioLabel.Location = new System.Drawing.Point(766, 24);
            this.UsuarioLabel.Name = "UsuarioLabel";
            this.UsuarioLabel.Size = new System.Drawing.Size(107, 16);
            this.UsuarioLabel.TabIndex = 2;
            this.UsuarioLabel.Text = "NombreUsuario";
            this.UsuarioLabel.Click += new System.EventHandler(this.UsuarioLabel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SkyPix.Properties.Resources.Paper_Plane_PNG_Image_Background;
            this.pictureBox1.Location = new System.Drawing.Point(22, -13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(50)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.AdministrarUButton);
            this.panel2.Controls.Add(this.pictureBox6);
            this.panel2.Controls.Add(this.pictureBox9);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 463);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // AdministrarUButton
            // 
            this.AdministrarUButton.ActiveBorderThickness = 1;
            this.AdministrarUButton.ActiveCornerRadius = 20;
            this.AdministrarUButton.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(32)))), ((int)(((byte)(60)))));
            this.AdministrarUButton.ActiveForecolor = System.Drawing.Color.White;
            this.AdministrarUButton.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(32)))), ((int)(((byte)(60)))));
            this.AdministrarUButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(50)))));
            this.AdministrarUButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AdministrarUButton.BackgroundImage")));
            this.AdministrarUButton.ButtonText = "Administrar";
            this.AdministrarUButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AdministrarUButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdministrarUButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.AdministrarUButton.IdleBorderThickness = 1;
            this.AdministrarUButton.IdleCornerRadius = 20;
            this.AdministrarUButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(50)))));
            this.AdministrarUButton.IdleForecolor = System.Drawing.Color.Gainsboro;
            this.AdministrarUButton.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(32)))), ((int)(((byte)(60)))));
            this.AdministrarUButton.Location = new System.Drawing.Point(55, 204);
            this.AdministrarUButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AdministrarUButton.Name = "AdministrarUButton";
            this.AdministrarUButton.Size = new System.Drawing.Size(139, 33);
            this.AdministrarUButton.TabIndex = 12;
            this.AdministrarUButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AdministrarUButton.Click += new System.EventHandler(this.AdministrarUButton_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::SkyPix.Properties.Resources.icons8_editar_usuario_masculino_64;
            this.pictureBox6.Location = new System.Drawing.Point(9, 141);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(39, 38);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 1;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::SkyPix.Properties.Resources.icons8_salida_80;
            this.pictureBox9.Location = new System.Drawing.Point(9, 379);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(39, 38);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 0;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::SkyPix.Properties.Resources.icons8_escudo_de_usuario_64;
            this.pictureBox5.Location = new System.Drawing.Point(9, 199);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(39, 38);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::SkyPix.Properties.Resources.icons8_grupo_de_usuarios_hombre_y_mujer_64;
            this.pictureBox4.Location = new System.Drawing.Point(9, 79);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(39, 38);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SkyPix.Properties.Resources.icons8_aplicación_telegrama_80;
            this.pictureBox2.Location = new System.Drawing.Point(11, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // ADM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(929, 520);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ADM";
            this.Text = "";
            this.Load += new System.EventHandler(this.ADM_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ADM_MouseDown);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.ExitButton, 0);
            this.Controls.SetChildIndex(this.RedactarButton, 0);
            this.Controls.SetChildIndex(this.ContactosButton, 0);
            this.Controls.SetChildIndex(this.AdmUsuarios, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        //private System.Windows.Forms.Label label1;
        //private System.Windows.Forms.Label label3;
        //private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuTextbox BuscarUsuarioBox;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label UsuarioLabel;
        private System.Windows.Forms.PictureBox pictureBox9;
        private Bunifu.Framework.UI.BunifuThinButton2 AdministrarUButton;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label7;
    }
}