using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace LaboratorioFinal
{
    public partial class Form1 : Form
    {
        BaseDeDatos BDD;
        public Form1()
        {
            InitializeComponent();
            if (File.Exists("../../Serialize.txt"))
            {
                BinaryFormatter bin = new BinaryFormatter();
                Stream stream = new FileStream("../../Serialize.txt", FileMode.Open, FileAccess.Read);
                BDD = new BaseDeDatos();
                BDD = (BaseDeDatos)bin.Deserialize(stream);
                stream.Close(); 
            }
            else
            {
                BDD = new BaseDeDatos();
            }
            listBox1.Visible = false;
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.BringToFront();
        }
        
// mostrar informacion de los botones en el listbox
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Visible = true;
            foreach (Pelicula peli in BDD.GetListaPeliculas())
            {
                if (listBox1.Items.Contains(peli))
                {
                    continue;
                }
                else
                {
                    listBox1.Items.Add(peli.getNombre());
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Visible = true;
            foreach (Actor a in BDD.GetListaActores())
            {
                if (listBox1.Items.Contains(a))
                {
                    continue;
                }
                else
                {
                    listBox1.Items.Add(a.getNombre());
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Visible = true;
            foreach (Director d in BDD.GetListaDirectores())
            {
                if (listBox1.Items.Contains(d))
                {
                    continue;
                }
                else
                {
                    listBox1.Items.Add(d.getNombre());
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Visible = true;
            foreach (Productor p in BDD.GetListaProductores())
            {
                if (listBox1.Items.Contains(p))
                {
                    continue;
                }
                else
                {
                    listBox1.Items.Add(p.getNombre());
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Visible = true;
            foreach (Estudio es in BDD.GetListaEstudios())
            {
                if (listBox1.Items.Contains(es))
                {
                    continue;
                }
                else
                {
                    listBox1.Items.Add(es.getNombre());
                }
            }
        }


 // mostrar perfil de elemento seleccionado en el listbox

        private void listbox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            listBox2.Items.Clear();
            panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            panel2.BringToFront();
            string nombre = listBox1.SelectedItem.ToString();
            if (BDD.listaquepertenece(nombre) == "pelicula")
            {
                Pelicula peli = BDD.EntregarPelicula(nombre);
                listBox2.Items.Add("Nombre: " + peli.getNombre());
                listBox2.Items.Add("Nombre Director: " + peli.getDirector().getNombre());
                listBox2.Items.Add("Fecha de estreno: " + peli.getFecha());
                listBox2.Items.Add("Descripcion: " + peli.getDescripcion());
                listBox2.Items.Add("Presupuesto: " + peli.getPresupuesto());
                listBox2.Items.Add("Nombre Estudio: " + peli.getestudio().getNombre());
                listBox2.Items.Add("Nombre Actores: " );
                foreach (Actor a in peli.getactoresopelicula())
                {
                    listBox2.Items.Add(a.getNombre());
                }
                listBox2.Items.Add("Nombre productores: ");
                foreach (Productor p in peli.getproductorespelicula())
                {
                    listBox2.Items.Add(p.getNombre());
                }
                listBox2.Items.Add("Criticas: ");
                foreach (Critica  c in peli.getlistacriticas())
                {
                    listBox2.Items.Add("Nombre: " + c.getNombre());
                    listBox2.Items.Add( c.gettexto());
                    listBox2.Items.Add("----------------------------------------------------");
                }
            }
            if (BDD.listaquepertenece(nombre) == "actor")
            {
                Actor actor = BDD.entregaractor(nombre);
                listBox2.Items.Add("Nombre: " + actor.getNombre());
                listBox2.Items.Add("Apellido: " + actor.getApellido());
                listBox2.Items.Add("Fecha de nacimiento: " + actor.getfecha());
                listBox2.Items.Add("Biografia: " + actor.getBiografia());
                listBox2.Items.Add("Nombre Peliculas: ");
                foreach (Pelicula a in actor.getlistapeliculas())
                {
                    listBox2.Items.Add(a.getNombre());
                }
                
            }
            if (BDD.listaquepertenece(nombre) == "director")
            {
                Director dire = BDD.entregardirector(nombre);
                listBox2.Items.Add("Nombre: " + dire.getNombre());
                listBox2.Items.Add("Apellido: " + dire.getApellido());
                listBox2.Items.Add("Fecha de nacimiento: " + dire.getfecha());
                listBox2.Items.Add("Biografia: " + dire.getBiografia());
                listBox2.Items.Add("Nombre Peliculas: ");
                foreach (Pelicula a in dire.getlistapeliculas())
                {
                    listBox2.Items.Add(a.getNombre());
                }

            }
            if (BDD.listaquepertenece(nombre) == "productor")
            {
                Productor prod = BDD.entregarproductor(nombre);
                listBox2.Items.Add("Nombre: " + prod.getNombre());
                listBox2.Items.Add("Apellido: " + prod.getApellido());
                listBox2.Items.Add("Fecha de nacimiento: " + prod.getfecha());
                listBox2.Items.Add("Biografia: " + prod.getBiografia());
                listBox2.Items.Add("Nombre Peliculas: ");
                foreach (Pelicula a in prod.getlistapeliculas())
                {
                    listBox2.Items.Add(a.getNombre());
                }

            }
            if (BDD.listaquepertenece(nombre) == "estudio")
            {
                Estudio est = BDD.entregarEstudio(nombre);
                listBox2.Items.Add("Nombre: " + est.getNombre());
                listBox2.Items.Add("Direccion: " + est.getDireccion());
                listBox2.Items.Add("Fecha de apertura: " + est.getfecha());
                listBox2.Items.Add("Nombre Peliculas: ");
                foreach (Pelicula a in est.getlistapeliculas())
                {
                    listBox2.Items.Add(a.getNombre());
                }

            }

        }

        private void 




        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Visible = false;
            listBox2.Items.Clear();
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (File.Exists("../../Serialize.txt"))
            {
                BinaryFormatter bin = new BinaryFormatter();
                Stream stream = new FileStream("../../Serialize.txt", FileMode.Open, FileAccess.Write);
                bin.Serialize(stream, BDD);
                stream.Close();
            }
            else
            {
                BinaryFormatter bin = new BinaryFormatter();
                Stream stream = new FileStream("../../Serialize.txt", FileMode.Create, FileAccess.Write);
                bin.Serialize(stream, BDD);
                stream.Close();
            }
            Application.Exit(); 
        }
    }
}
