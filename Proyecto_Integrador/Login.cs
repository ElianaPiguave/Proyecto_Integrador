﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Integrador
{
    public partial class Login : Form
    {
        //cadena de conexion
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-RMT1SOPH;Initial Catalog=Proyecto_Integrador;Integrated Security=True");
        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {

        }
        int x = 0;
        int y = 0;
        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button != MouseButtons.Left)
            {
                x = e.X;
                y = e.Y;
            }
            else
            {
                Left = Left + (e.X - x);
                Top = Top + (e.Y - y);
            }
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void lkl_registro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new Registro().ShowDialog();
            this.Close();
        }
        private void logear(string nombre, string passw)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from tbl_empleado where em_nombre = @nombre", con);
                cmd.Parameters.AddWithValue("nombre", nombre);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Close();




                if (dt.Rows.Count == 1)
                {
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand("select em_nombre, em_id from tbl_empleado where em_nombre = @nombre and password= @pass", con);
                    cmd1.Parameters.AddWithValue("nombre", nombre);
                    cmd1.Parameters.AddWithValue("pass", passw);
                    SqlDataAdapter sda1 = new SqlDataAdapter(cmd1);
                    DataTable dt1 = new DataTable();
                    sda1.Fill(dt1);
                    con.Close();



                }
                else
                {




                    txt_usuario.Text = "";
                    txt_pass.Text = "";
                    MessageBox.Show("Usuario/contraseña incorrectos ");




                    this.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {



            }
        }



        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            logear(txt_usuario.Text, txt_pass.Text);



        }
    }
}
    

