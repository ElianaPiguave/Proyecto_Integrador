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



namespace Proyecto_Integrador
{
    public partial class Contenido1 : Form
    {
        public Contenido1()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

       
        private void AbrirFormHija(object formhija)
        {
            if (this.panelContenido.Controls.Count > 0)
                this.panelContenido.Controls.RemoveAt(0);

            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenido.Controls.Add(fh);
            this.panelContenido.Tag = fh;
            fh.Show();
        }

        private void btn_Productos_Click_1(object sender, EventArgs e)
        {
            AbrirFormHija(new Proveedor());
        }

        private void btn_ventas_Click_1(object sender, EventArgs e)
        {
            AbrirFormHija(new Ventas());
        }

        private void btn_compras_Click_1(object sender, EventArgs e)
        {
            AbrirFormHija(new Compras());
        }

        private void btn_clientes_Click_1(object sender, EventArgs e)
        {
            AbrirFormHija(new Clientes());
        }

        private void dtpFechaIngreso_Tick(object sender, EventArgs e)
        {
            lbl_horayfecha.Text = DateTime.Now.ToLongTimeString();
            lbl_hora.Text = DateTime.Now.ToLongDateString();
        }

        private void btn_minimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_cerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_restaurar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btn_restaurar.Visible = false;
            btn_maximizar.Visible = false;
        }

        private void btn_maximizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btn_maximizar.Visible = false;
            btn_restaurar.Visible = true;
        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {

        }

        

       

        private void barra_superior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}