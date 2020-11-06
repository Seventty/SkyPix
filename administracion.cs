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
    public partial class administracion : Form
    {
        public administracion()
        {
            InitializeComponent();
        }

        public void autocompletar(TextBox hostbox)
        {
            
        }

        public DataSet llenarDatos(string tabla)
        {
            string cmd = string.Format("select id_usuario, nombre, apellido, fecha_creacion from "+tabla);
            DataSet BD = SkyDataControl.Run(cmd);
            return BD;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void AdministrarUButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            string host;
            int adm;
            if (ADMCheck.Checked == true)
            {
                adm = 1;
            }
            else
            {
                adm = 0;
            }
            try
            {
                string id = string.Format("select count(id_usuario) from Usuarios");
                string cmd = string.Format("EXEC AgregarUsuario '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}'",2, nombreBox.Text, apellidoBox.Text, Convert.ToString(FechaRegistro), correoBox.Text, usuarioBox.Text, contraseñaBox.Text, adm, hostBox.Text);
                SkyDataControl.Run(cmd);
                Correo correo = new Correo();
                string administrador;
                if (adm == 1)
                {
                    administrador = "Enhorabuena, eres administrador de SkyPix";
                }
                else
                {
                    administrador = "Eres un usuario Común";
                }
                correo.mensaje(correoBox.Text, "Bienvenido.", "Su registro en SkyPix fue completado. señor/a: " + nombreBox.Text + "<br><br>Nombre: " + nombreBox.Text + "<br>Apellido: " + apellidoBox.Text + "<br>Usuario: " + usuarioBox.Text + "<br>Contraseña: " + contraseñaBox.Text + "<br>"+"Tipo: "+administrador+ "<br>Gracias por usar SkyPix. Esperamos que su estadía sea grata.");
                MessageBox.Show("Enhorabuena, un nuevo usuario ha sido creado. & ha sido enviado un correo con su información a su correo de gmail.");
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error..." + error.Message);
            }     
        }
 

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                if (string.IsNullOrWhiteSpace(usuarioBorrarBox.Text))
                {
                    MessageBox.Show("Introduce un id de usuario.");
                }
                else
                {
                    string cmd = string.Format("EXEC EliminarUsuarios '{0}'", usuarioBorrarBox.Text.Trim());
                    SkyDataControl.Run(cmd);
                    MessageBox.Show("Usuario eliminado de manera satisfactoria.");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Ese id de usuario no existe.");
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void administracion_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = llenarDatos("Usuarios").Tables[0];
            dataGridView2.DataSource = llenarDatos("Usuarios").Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(buscador.text.Trim()) == false)
            {
                try
                {
                    string cmd = "select id_usuario, nombre, apellido, fecha_creacion from Usuarios where nombre like ('%" + buscador.text.Trim() + "%')";
                    DataSet BD = SkyDataControl.Run(cmd);
                    dataGridView1.DataSource = BD.Tables[0];
                }
                catch (Exception error)
                {
                    MessageBox.Show("Ha ocurrido un error por acá." + error.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;

            }
        }

        private void buscador_OnTextChange(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }
    }
}
