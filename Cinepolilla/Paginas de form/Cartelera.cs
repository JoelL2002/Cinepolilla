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
    public partial class Cartelera : Form
    {
        Progra1Entities db = new Progra1Entities();
        public Cartelera()
        {
            InitializeComponent();
        }

        private void Cartelera_Load(object sender, EventArgs e)
        {
            carga();

        }

        public void carga()
        {
            Inicio_Sesion ini = new Inicio_Sesion();    
   
            Consultas consu = new Consultas();
            dataGridViewPeli.DataSource = db.Pelicula.ToList();
            
        }

        private void Cartelera_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridViewPeli_Click(object sender, EventArgs e)
        {
            labelSipHide.Text = "Sinopsis:";
            textBoxPrecio.Text = dataGridViewPeli.SelectedRows[0].Cells[6].Value.ToString();
            Sipnosislabel.Text = dataGridViewPeli.SelectedRows[0].Cells[2].Value.ToString();

            if (dataGridViewPeli.SelectedRows[0].Cells[0].Value.ToString() == "1005")
            {
                pictureBoxAmogu.Visible = true;
                pictureBoxPortada.Visible = false;
                pictureBoxJurasic.Visible = false;
                pictureBoxRed.Visible = false;
                pictureBoxSonic.Visible = false;
                pictureBoxVenom.Visible = false;
            }
            if (dataGridViewPeli.SelectedRows[0].Cells[0].Value.ToString() == "1006")
            {
                pictureBoxAmogu.Visible = false;
                pictureBoxPortada.Visible = false;
                pictureBoxJurasic.Visible = true;
                pictureBoxRed.Visible = false;
                pictureBoxSonic.Visible = false;
                pictureBoxVenom.Visible = false;
            }
            if (dataGridViewPeli.SelectedRows[0].Cells[0].Value.ToString() == "1007")
            {
                pictureBoxAmogu.Visible = false;
                pictureBoxPortada.Visible = false;
                pictureBoxJurasic.Visible = false;
                pictureBoxRed.Visible = false;
                pictureBoxSonic.Visible = true;
                pictureBoxVenom.Visible = false;
            }
            if (dataGridViewPeli.SelectedRows[0].Cells[0].Value.ToString() == "1008")
            {
                pictureBoxAmogu.Visible = false;
                pictureBoxPortada.Visible = false;
                pictureBoxJurasic.Visible = false;
                pictureBoxRed.Visible = false;
                pictureBoxSonic.Visible = false;
                pictureBoxVenom.Visible = true;
            }
            if (dataGridViewPeli.SelectedRows[0].Cells[0].Value.ToString() == "1009")
            {
                pictureBoxAmogu.Visible = false;
                pictureBoxPortada.Visible = false;
                pictureBoxJurasic.Visible = false;
                pictureBoxRed.Visible = true;
                pictureBoxSonic.Visible = false;
                pictureBoxVenom.Visible = false;
            }
        }

        private void buttonFecha_Click(object sender, EventArgs e)
        {
            string mes,año;
            string fecha;
   
            mes = comboBoxMes.Text;
            año = comboBoxAño.Text;

            fecha = $"{año}-{mes}-01";

            dataGridViewPeli.DataSource = db.Pelicula.SqlQuery($"select * from Pelicula where Fecha_estreno <= '{fecha}' and Fecha_limite >= '{fecha}'").ToList();


        }

        private void buttonRellenar_Click(object sender, EventArgs e)
        {
            carga();
        }

        private void buttonComprar_Click(object sender, EventArgs e)
        {

            textBoxBilletera.Text = Convert.ToString(decimal.Parse(textBoxBilletera.Text) - decimal.Parse(textBoxPrecio.Text));
            var temp = db.Usuario.SqlQuery($"Select * from Usuario where N_Usuario = '{textBoxNusuario.Text}'").ToList();

            temp.First().Billetera = decimal.Parse(textBoxBilletera.Text);
            db.Entry(temp.ToList().First()).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        private void labelUsuario_Click(object sender, EventArgs e)
        {

        }
    }
     
}
