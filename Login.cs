using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using SkyPixCH;
using System.IO;

namespace SkyPix
{
    public partial class Login : MotherScreen
    {
        public Login()
        {
            InitializeComponent();
            
        }
        public string usuario;
        public string contraseña;
        public static string codigo = "";
        public void notificacion()
        {
            SkyPix.Text = "Admin accoun: Active";
            SkyPix.Visible = true;
            SkyPix.BalloonTipTitle = "Bienvenido, Administrador.";
            SkyPix.BalloonTipText = "Esperamos que su estadía en SkyPix sea grata.";
            SkyPix.ShowBalloonTip(100);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();
            registro.ShowDialog();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UsuarioBox_TextChanged(object sender, EventArgs e)
        {
            UsuarioBox.Clear();
        }

        private void JoinButton_Click(object sender, EventArgs e)
        {
            ADM ADMventana = new ADM();
            usuario usuario = new usuario();

            if (string.IsNullOrWhiteSpace(UsuarioBox.Text))
            {
                MessageBox.Show("Introduzca un usuario o correo.");

            }
            else if (string.IsNullOrWhiteSpace(Contraseñabox.Text))
            {
                MessageBox.Show("Introduzca una contraseña");
            }
            else
            {
                try
                {
                    string cmd = string.Format("select * from Usuarios where usuario='{0}' and contraseña='{1}'", UsuarioBox.Text.Trim(), Contraseñabox.Text.Trim());
                    DataSet DB = SkyDataControl.Run(cmd);
                    string cuenta = DB.Tables[0].Rows[0]["usuario"].ToString().Trim();
                    string contraseña = DB.Tables[0].Rows[0]["contraseña"].ToString().Trim();
                    codigo = DB.Tables[0].Rows[0]["id_usuario"].ToString().Trim();
                    if (UsuarioBox.Text.Trim() == cuenta && Contraseñabox.Text.Trim() == contraseña)
                    {
                        if (Convert.ToBoolean(DB.Tables[0].Rows[0]["ADM"]) == true)
                        {                      
                            notificacion();
                            this.Hide();
                            ADMventana.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Bienvenido a SkyPix. Pásala bien.", "Bienvenido");
                            this.Hide();
                            usuario.ShowDialog();
                            this.Close();
                        } 
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show("Usuario o contraseña invalidos", "Login error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(error.Message);
                }
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void UsuarioBox_Enter(object sender, EventArgs e)
        {
            if (UsuarioBox.Text == "Usuario o Correo")
            {
                UsuarioBox.Text = null;
            }
        }

        private void Contraseñabox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Contraseñabox_Enter(object sender, EventArgs e)
        {
            if (Contraseñabox.Text == "Contraseña")
            {
                Contraseñabox.Text = null;
            }
        }

        private void SkyPix_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void EnviadosButton_Click(object sender, EventArgs e)
        {

        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            movedor();
        }
    }
}
