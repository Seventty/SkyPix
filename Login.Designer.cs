namespace SkyPix
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Contraseñabox = new System.Windows.Forms.TextBox();
            this.JoinButton = new System.Windows.Forms.Button();
            this.RegistrarBotton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.RichTextBox();
            this.Panel2 = new System.Windows.Forms.RichTextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SkyPix = new System.Windows.Forms.NotifyIcon(this.components);
            this.UsuarioBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(335, 1);
            // 
            // Contraseñabox
            // 
            this.Contraseñabox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.Contraseñabox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Contraseñabox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contraseñabox.ForeColor = System.Drawing.Color.White;
            this.Contraseñabox.Location = new System.Drawing.Point(120, 325);
            this.Contraseñabox.Name = "Contraseñabox";
            this.Contraseñabox.Size = new System.Drawing.Size(170, 16);
            this.Contraseñabox.TabIndex = 0;
            this.Contraseñabox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Contraseñabox.UseSystemPasswordChar = true;
            this.Contraseñabox.TextChanged += new System.EventHandler(this.Contraseñabox_TextChanged);
            this.Contraseñabox.Enter += new System.EventHandler(this.Contraseñabox_Enter);
            // 
            // JoinButton
            // 
            this.JoinButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.JoinButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.JoinButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.JoinButton.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JoinButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.JoinButton.Location = new System.Drawing.Point(93, 425);
            this.JoinButton.Name = "JoinButton";
            this.JoinButton.Size = new System.Drawing.Size(87, 37);
            this.JoinButton.TabIndex = 18;
            this.JoinButton.Text = "Iniciar";
            this.JoinButton.UseVisualStyleBackColor = false;
            this.JoinButton.Click += new System.EventHandler(this.JoinButton_Click);
            // 
            // RegistrarBotton
            // 
            this.RegistrarBotton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(32)))), ((int)(((byte)(72)))));
            this.RegistrarBotton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RegistrarBotton.Font = new System.Drawing.Font("Trebuchet MS", 9.25F, System.Drawing.FontStyle.Bold);
            this.RegistrarBotton.ForeColor = System.Drawing.Color.Gainsboro;
            this.RegistrarBotton.Location = new System.Drawing.Point(213, 425);
            this.RegistrarBotton.Name = "RegistrarBotton";
            this.RegistrarBotton.Size = new System.Drawing.Size(91, 37);
            this.RegistrarBotton.TabIndex = 19;
            this.RegistrarBotton.Text = "Registrar";
            this.RegistrarBotton.UseVisualStyleBackColor = false;
            this.RegistrarBotton.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(138, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 24);
            this.label2.TabIndex = 23;
            this.label2.Text = " ";
            // 
            // Panel1
            // 
            this.Panel1.Location = new System.Drawing.Point(82, 298);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(222, 2);
            this.Panel1.TabIndex = 24;
            this.Panel1.Text = "";
            // 
            // Panel2
            // 
            this.Panel2.Location = new System.Drawing.Point(82, 348);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(222, 2);
            this.Panel2.TabIndex = 25;
            this.Panel2.Text = "";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::SkyPix.Properties.Resources.icons8_huella_dactilar_32;
            this.pictureBox4.Location = new System.Drawing.Point(82, 314);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SkyPix.Properties.Resources.icons8_ubicación_del_usuario_32;
            this.pictureBox2.Location = new System.Drawing.Point(82, 268);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SkyPix.Properties.Resources.JD_10_512;
            this.pictureBox1.Location = new System.Drawing.Point(106, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // SkyPix
            // 
            this.SkyPix.Icon = ((System.Drawing.Icon)(resources.GetObject("SkyPix.Icon")));
            this.SkyPix.Text = "SkyPix";
            this.SkyPix.Visible = true;
            this.SkyPix.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.SkyPix_MouseDoubleClick);
            // 
            // UsuarioBox
            // 
            this.UsuarioBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.UsuarioBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsuarioBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioBox.ForeColor = System.Drawing.Color.White;
            this.UsuarioBox.Location = new System.Drawing.Point(120, 274);
            this.UsuarioBox.Name = "UsuarioBox";
            this.UsuarioBox.Size = new System.Drawing.Size(170, 16);
            this.UsuarioBox.TabIndex = 0;
            this.UsuarioBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UsuarioBox.TextChanged += new System.EventHandler(this.Contraseñabox_TextChanged);
            this.UsuarioBox.Enter += new System.EventHandler(this.Contraseñabox_Enter);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(46)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(337, -51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 19);
            this.button1.TabIndex = 26;
            this.button1.Text = "X";
            this.button1.UseCompatibleTextRendering = true;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.ExitButton_Click_1);
            // 
            // Login
            // 
            this.AcceptButton = this.JoinButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(383, 529);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RegistrarBotton);
            this.Controls.Add(this.UsuarioBox);
            this.Controls.Add(this.JoinButton);
            this.Controls.Add(this.Contraseñabox);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "SkyPix";
            this.Load += new System.EventHandler(this.Login_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.pictureBox2, 0);
            this.Controls.SetChildIndex(this.pictureBox4, 0);
            this.Controls.SetChildIndex(this.Contraseñabox, 0);
            this.Controls.SetChildIndex(this.JoinButton, 0);
            this.Controls.SetChildIndex(this.UsuarioBox, 0);
            this.Controls.SetChildIndex(this.RegistrarBotton, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.Panel1, 0);
            this.Controls.SetChildIndex(this.Panel2, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.ExitButton, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox Contraseñabox;
        private System.Windows.Forms.Button JoinButton;
        private System.Windows.Forms.Button RegistrarBotton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox Panel1;
        private System.Windows.Forms.RichTextBox Panel2;
        private System.Windows.Forms.NotifyIcon SkyPix;
        private System.Windows.Forms.TextBox UsuarioBox;
        private System.Windows.Forms.Button button1;
    }
}

