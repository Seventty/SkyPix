using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SkyPixCH;

namespace SkyPix
{
    public partial class ADM : FatherScreen
    {
        public ADM()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ADM_Load(object sender, EventArgs e)
        {
            string cmd = "select * from Usuarios where id_usuario = "+Login.codigo;
            DataSet DS = SkyDataControl.Run(cmd);
            DS.Tables[0].Rows[0]["usuario"].ToString();
            UsuarioLabel.Text = DS.Tables[0].Rows[0]["nombre"].ToString();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Login newlogin = new Login();
            this.Hide();
            newlogin.ShowDialog();
            this.Close();
        }

        private void RedactarButton_Click(object sender, EventArgs e)
        {
           
        }

        private void RecibidoButton_Click(object sender, EventArgs e)
        {
            
        }

        private void EnviadosButton_Click(object sender, EventArgs e)
        {
           
        }

        private void ContactosButton_Click(object sender, EventArgs e)
        {
           
        }

        private void AdministrarButton_Click(object sender, EventArgs e)
        {
            
        }

        private void AdministrarUButton_Click(object sender, EventArgs e)
        {
            administracion newadministracion = new administracion();
            newadministracion.ShowDialog();
        }

        private void ADM_MouseDown(object sender, MouseEventArgs e)
        {
            movedor();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            movedor();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            movedor();
        }


        private void BotonEnviar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(paraBox.Text))
            {
                MessageBox.Show("No puedo hacer un envio sin receptor...");
            }
            else if (string.IsNullOrWhiteSpace(MensajeBox.Text))
            {
                MessageBox.Show("No puedo enviar un mensaje vacío.");
            }
            else if (string.IsNullOrWhiteSpace(AsuntoBox.Text))
            {
                MessageBox.Show("No puedo hacer un envio sin subject");
            }
            else
            {
                Correo correo = new Correo();
                try
                {
                    correo.mensaje(paraBox.Text, AsuntoBox.Text, MensajeBox.Text);
                    BotonEnviar.Iconimage_right = SkyPix.Properties.Resources.icons8_enviado_64__2_;
                    MessageBox.Show("Mensaje enviado correctamente.");
                }
                catch (Exception)
                {
                    MessageBox.Show("No se pudo enviar el mensaje correctamente. Revise si hay conexion a internet o si el usuario existe.");
                }
            }
        }

        private void RedactarButton_Click_1(object sender, EventArgs e)
        {

        }

        private void UsuarioLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
