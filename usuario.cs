using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using SkyPixCH;

namespace SkyPix
{
    public partial class usuario : FatherScreen
    {
        public usuario()
        {
            InitializeComponent();
        }

        private void AdmUsuarios_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En desarrollo...");
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Login newloging = new Login();
            this.Hide();
            newloging.ShowDialog();
            this.Close();
        }

        private void ContactosButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En desarrollo...");
        }

        private void EnviadosButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En desarrollo...");
        }

        private void RecibidoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En desarrollo...");
        }

        private void RedactarButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En desarrollo...");
        }

        private void usuario_Load(object sender, EventArgs e)
        {
            string cmd = "select * from Usuarios where id_usuario = " + Login.codigo;
            DataSet DS = SkyDataControl.Run(cmd);
            DS.Tables[0].Rows[0]["usuario"].ToString();
            UsuarioLabel.Text = DS.Tables[0].Rows[0]["usuario"].ToString();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void usuario_MouseDown(object sender, MouseEventArgs e)
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

        private void RedactarButton_Click_1(object sender, EventArgs e)
        {

        }

        private void RecibidoButton_Click_1(object sender, EventArgs e)
        {

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
                Correo algo= new Correo();
                try
                {
                    algo.mensaje(paraBox.Text, MensajeBox.Text, AsuntoBox.Text);
                    MessageBox.Show("mensaje enviado.");
                }
                catch (SmtpFailedRecipientsException excepcion)
                {
                    MessageBox.Show("No se pudo enviar el mensaje correctamente. Revise si hay conexion a internet o si el usuario existe."+excepcion);
                }
            }
        }

        private void UsuarioLabel_Click(object sender, EventArgs e)
        {

        }

        private void paraBox_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
