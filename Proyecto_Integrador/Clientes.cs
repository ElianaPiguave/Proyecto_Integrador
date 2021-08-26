using CapaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Integrador
{
    
    public partial class Clientes : Form
    {
        private CN_Cliente objetoCN = new CN_Cliente();
        private string id = null;
        private bool editar = false;
        public Clientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            mostrar_cliente();

        }

        private void mostrar_cliente()
        {
            CN_Cliente objeto = new CN_Cliente();
            dgv_cliente.DataSource = objeto.mostrarClientes();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btbn_crear_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_nombre.Text) && string.IsNullOrEmpty(txt_apellido.Text))
            {
                MessageBox.Show("Por favor ingrese todos los datos");
            }
            else
            {
               if (editar == false)
                {
                    try
                    {
                        objetoCN.insertarCliente(txt_nombre.Text,txt_apellido.Text,txt_ced.Text,txt_direccion.Text,txt_telefono.Text,txt_email.Text);
                        MessageBox.Show("El estudiante se regitro correctamente");
                        //mostrar_estudiante();
                        limpiar();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("El estudiante  no se registro correctamente");

                        throw;
                    }
                }
            }
            }

        private void limpiar()
        {
            txt_nombre.Clear();
            txt_apellido.Clear();
            txt_ced.Clear();
            txt_direccion.Clear();
            txt_email.Clear();
            txt_telefono.Clear();
            id = null;
            editar = false;
            btbn_crear.Enabled = true;
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
 