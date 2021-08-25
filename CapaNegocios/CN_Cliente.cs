﻿using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public class CN_Cliente
    {
        private CD_Cliente objetoCD = new CD_Cliente();
        public DataTable mostrarClientes()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.mostrar();
            return tabla;
        }
        public void insertarCliente(string nombre, string apellido, string feha_na, string cedula, string direccion, string telefono, string email)
        {
            objetoCD.insertar(nombre, apellido,Convert.ToDateTime(feha_na), Convert.ToInt32(cedula), direccion, Convert.ToInt32(telefono), email);
        }

    }
}