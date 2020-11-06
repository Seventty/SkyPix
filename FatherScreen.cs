using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using SkyPixCH;


namespace SkyPix
{
    public partial class FatherScreen : Form
    {

        public FatherScreen()
        {
            InitializeComponent();
        }
        // So you can keep... me

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public void movedor()
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void FatherScreen_Load(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            
            Login newloging = new Login();
            this.Hide();
            newloging.ShowDialog();
            this.Close();
        }

        private void RedactarButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void ContactosButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void EnviadosButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void AdmUsuarios_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
        }

        private void FatherScreen_MouseDown(object sender, MouseEventArgs e)
        {
            movedor();
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void PanelMensajeria_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BotonEnviar_Click(object sender, EventArgs e)
        {

        }
    }
}
