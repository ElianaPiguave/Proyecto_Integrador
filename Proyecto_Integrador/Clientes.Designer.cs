
namespace Proyecto_Integrador
{
    partial class Clientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgv_cliente = new System.Windows.Forms.DataGridView();
            this.btbn_crear = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.txt_ced = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 615);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.txt_direccion);
            this.panel2.Controls.Add(this.txt_email);
            this.panel2.Controls.Add(this.txt_apellido);
            this.panel2.Controls.Add(this.txt_telefono);
            this.panel2.Controls.Add(this.txt_ced);
            this.panel2.Controls.Add(this.txt_nombre);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.panel2.Location = new System.Drawing.Point(5, 155);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(916, 449);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgv_cliente);
            this.panel3.Controls.Add(this.btbn_crear);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Location = new System.Drawing.Point(17, 217);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(891, 225);
            this.panel3.TabIndex = 23;
            // 
            // dgv_cliente
            // 
            this.dgv_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cliente.Location = new System.Drawing.Point(4, 20);
            this.dgv_cliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_cliente.Name = "dgv_cliente";
            this.dgv_cliente.RowHeadersWidth = 51;
            this.dgv_cliente.Size = new System.Drawing.Size(713, 185);
            this.dgv_cliente.TabIndex = 0;
            // 
            // btbn_crear
            // 
            this.btbn_crear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btbn_crear.Image = global::Proyecto_Integrador.Properties.Resources.disquete;
            this.btbn_crear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btbn_crear.Location = new System.Drawing.Point(743, 20);
            this.btbn_crear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btbn_crear.Name = "btbn_crear";
            this.btbn_crear.Size = new System.Drawing.Size(132, 38);
            this.btbn_crear.TabIndex = 19;
            this.btbn_crear.Text = "Guardar";
            this.btbn_crear.UseVisualStyleBackColor = true;
            this.btbn_crear.Click += new System.EventHandler(this.btbn_crear_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.button4.Image = global::Proyecto_Integrador.Properties.Resources.error;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(743, 166);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(132, 38);
            this.button4.TabIndex = 21;
            this.button4.Text = "    Cancelar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.button3.Image = global::Proyecto_Integrador.Properties.Resources.editar;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(743, 96);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 38);
            this.button3.TabIndex = 20;
            this.button3.Text = "Editar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(188, 111);
            this.txt_direccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(251, 24);
            this.txt_direccion.TabIndex = 22;
            // 
            // txt_email
            // 
            this.txt_email.BackColor = System.Drawing.Color.NavajoWhite;
            this.txt_email.Location = new System.Drawing.Point(635, 62);
            this.txt_email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(240, 24);
            this.txt_email.TabIndex = 16;
            // 
            // txt_apellido
            // 
            this.txt_apellido.BackColor = System.Drawing.Color.NavajoWhite;
            this.txt_apellido.Location = new System.Drawing.Point(635, 18);
            this.txt_apellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(240, 24);
            this.txt_apellido.TabIndex = 15;
            // 
            // txt_telefono
            // 
            this.txt_telefono.BackColor = System.Drawing.Color.NavajoWhite;
            this.txt_telefono.Location = new System.Drawing.Point(635, 111);
            this.txt_telefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(251, 24);
            this.txt_telefono.TabIndex = 14;
            // 
            // txt_ced
            // 
            this.txt_ced.BackColor = System.Drawing.Color.NavajoWhite;
            this.txt_ced.Location = new System.Drawing.Point(188, 69);
            this.txt_ced.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ced.Name = "txt_ced";
            this.txt_ced.Size = new System.Drawing.Size(251, 24);
            this.txt_ced.TabIndex = 12;
            // 
            // txt_nombre
            // 
            this.txt_nombre.BackColor = System.Drawing.Color.NavajoWhite;
            this.txt_nombre.Location = new System.Drawing.Point(188, 22);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(251, 24);
            this.txt_nombre.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label10.Location = new System.Drawing.Point(528, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 18);
            this.label10.TabIndex = 8;
            this.label10.Text = "Email:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label9.Location = new System.Drawing.Point(528, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 18);
            this.label9.TabIndex = 7;
            this.label9.Text = "Teléfono:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label8.Location = new System.Drawing.Point(49, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 18);
            this.label8.TabIndex = 6;
            this.label8.Text = "Dirección:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label7.Location = new System.Drawing.Point(49, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 18);
            this.label7.TabIndex = 5;
            this.label7.Text = "Nro. Cédula:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(528, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Apellidos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(49, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 13.8F);
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(11, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clientes";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_Integrador.Properties.Resources.consumidor__1_;
            this.pictureBox1.Location = new System.Drawing.Point(152, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 614);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btbn_crear;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.TextBox txt_ced;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgv_cliente;
    }
}