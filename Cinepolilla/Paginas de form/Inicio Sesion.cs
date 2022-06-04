using Cinepolilla.Clases;
using Cinepolilla.Modelos;
using Cinepolilla.Paginas_de_form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinepolilla
{
    public partial class Inicio_Sesion : Form
    {
        Usuario usu = new Usuario();
        Consultas consu = new Consultas();
        Cartelera pelis = new Cartelera();
        public Inicio_Sesion()
        {
            InitializeComponent();
        }

        private void DatosCarte()
        {
            Progra1Entities db = new Progra1Entities(); 
            var temp = db.Usuario.SqlQuery($"Select * from Usuario where N_Usuario = '{textBoxN_Usuario.Text}'").ToList();
            pelis.textBoxNusuario.Text = temp.First().N_Usuario.ToString();
                pelis.textBoxCarteUsuario.Text = temp.First().Nombre.ToString();
                pelis.textBoxBilletera.Text = temp.First().Billetera.ToString();
           
        }
        private void buttonIngreso_Click(object sender, EventArgs e)
        {
            if (consu.ConsultaLogin(textBoxN_Usuario.Text, textBoxContraseña.Text) == 1)
            {               
                DatosCarte();
                pelis.Show();
               
            }
            else { MessageBox.Show("El usuario o contraseña son incorrectos", "Error"); }

                        
        }

        private void linkLabelCrearCuenta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Crear_cuenta create = new Crear_cuenta();
            create.Show();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBoxVercontra_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxVercontra.Checked)
            {
                textBoxContraseña.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxContraseña.UseSystemPasswordChar = true;
            }
        }
    }
}
