using Cinepolilla.Clases;
using Cinepolilla.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinepolilla.Paginas_de_form
{
    public partial class Crear_cuenta : Form
    {
        public Crear_cuenta()
        {
            InitializeComponent();
        }

        private void buttonCrearCuenta_Click(object sender, EventArgs e)
        {
            Usuario Cusuario = new Usuario();
            Consultas consu = new Consultas();

            if(consu.existe(textBoxUsuario.Text) == 1)
            {
                MessageBox.Show("Este nombre de usuario ya existe, por favor cree otro", "Error");
            }
            else { 


           if(String.IsNullOrEmpty(textBoxEdad.Text))
            {
                Cusuario.Edad = 0;
            }
            else { Cusuario.Edad = int.Parse(textBoxEdad.Text); }
           
            Cusuario.Nombre = textBoxNombre.Text;
            Cusuario.N_Usuario = textBoxUsuario.Text;
            Cusuario.Contraseña = textBoxContra.Text;          
            Cusuario.Sexo = comboBoxSexo.Text;
            Cusuario.Billetera = 500;
            if(Cusuario.Sexo.Length > 1)
            {
                Cusuario.Sexo = "N";
            }

           if(Cusuario.Nombre.Length != 0)
            {
                if(Cusuario.N_Usuario.Length != 0)
                {
                    if(Cusuario.Contraseña.Length != 0)
                    {
                        if(Cusuario.Edad != 0)
                        {
                            if(Cusuario.Sexo.Length != 0)
                            {
                                consu.crearUsuario(Cusuario);
                                MessageBox.Show("Se ha registrado correctamente", "Usuario Creado");
                                Application.Exit();
                            }
                        }
                    }
                }
            }
             MessageBox.Show("Debe llenar todas las casillas de datos", "Error"); 
            
           
}
        }

        private void textBoxEdad_TextChanged(object sender, EventArgs e)
        {
            if(!System.Text.RegularExpressions.Regex.IsMatch(textBoxEdad.Text,"^[0-9]"))
            {
                textBoxEdad.Text = "";
            }
        }
    }
}
