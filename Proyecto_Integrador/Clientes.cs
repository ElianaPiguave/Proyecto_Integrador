﻿using CapaNegocios;
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
    //private CN_Cliente objetoCN = new CN_Cliente();
    //private string id = null;
    //private bool editar = false;
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {

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
               // if (editar == false)
                {
                    try
                    {
                 //       objetoCN.  
                        MessageBox.Show("El estudinte se regitro correctaamente");
                        //mostrar_estudiante();
                        limpiar();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("El estudinte  no se regitro correctaamente");

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
            //id = null;
           // editar = false;
            btbn_crear.Enabled = true;
            dtp_fecha.Value = DateTime.Now;
        }
    }
}
 