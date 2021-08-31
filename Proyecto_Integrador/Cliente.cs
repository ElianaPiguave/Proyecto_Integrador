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
    public partial class Cliente : Form
    {
        private CN_Cliente objetoCN = new CN_Cliente();
        private string cl_id = null;
        private bool editar = false;
        public Cliente()
        {
            InitializeComponent();
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            mostrar_cliente();
        }
        private void mostrar_cliente()
        {
            CN_Cliente objeto = new CN_Cliente();
            dgv_cliente.DataSource = objeto.mostrarClientes();
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
                        objetoCN.insertarCliente(txt_nombre.Text, txt_apellido.Text, txt_ced.Text, txt_direccion.Text, txt_telefono.Text, txt_email.Text);
                        MessageBox.Show("El estudiante se regitro correctamente");
                        mostrar_cliente();
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
            cl_id = null;
            editar = false;
            btbn_crear.Enabled = true;

        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_nombre.Text) && string.IsNullOrEmpty(txt_apellido.Text))
            {
                MessageBox.Show("Seleccione una fila para editar");
            }
            else
            {
                if (editar)
                {
                    try
                    {

                        objetoCN.editarCliente(txt_nombre.Text, txt_apellido.Text, txt_ced.Text, txt_direccion.Text, txt_telefono.Text, txt_email.Text, Convert.ToInt32(cl_id));
                        MessageBox.Show("Campos Actualizados");
                        mostrar_cliente();

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error en la Actualizacion");
                    }
                }
            }
        }

    

        private void button4_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void dgv_cliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dgv_cliente_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgv_cliente.SelectedRows.Count > 0)
            {
                editar = true;
                txt_nombre.Text = dgv_cliente.CurrentRow.Cells["cl_nombre"].Value.ToString();
                txt_apellido.Text = dgv_cliente.CurrentRow.Cells["cl_apellido"].Value.ToString();
                txt_ced.Text = dgv_cliente.CurrentRow.Cells["cl_cedula"].Value.ToString();
                txt_direccion.Text = dgv_cliente.CurrentRow.Cells["cl_direccion"].Value.ToString();
                txt_telefono.Text = dgv_cliente.CurrentRow.Cells["cl_telefono"].Value.ToString();
                txt_email.Text = dgv_cliente.CurrentRow.Cells["cl_email"].Value.ToString();
                cl_id = dgv_cliente.CurrentRow.Cells["cl_id"].Value.ToString();
                btbn_crear.Enabled = false;
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
                limpiar();
            }
        }
    }
}
