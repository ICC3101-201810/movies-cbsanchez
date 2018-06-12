using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioFinal
{
    [Serializable]
    class Pelicula
    {
        String nombre, descripcion;
        DateTime fecha_estreno;
        int presupuesto;
        Director director;
        Estudio estudio;
        List<Critica> criticas = new List<Critica>();
        List<Actor> actores = new List<Actor>();
        List<Productor> productores = new List<Productor>();
        public Pelicula(string minombre, string midescripcion, DateTime mifecha, int mipresup, Director midirector, Estudio miestudio)
        {
            nombre = minombre;
            descripcion = midescripcion;
            fecha_estreno = mifecha;
            presupuesto = mipresup;
            director = midirector;
            estudio = miestudio;
        }

        public string getNombre()
        {
            return nombre;
        }
        public Director getDirector()
        {
            return director;
        }
        public string getDescripcion()
        {
            return descripcion;
        }
        public DateTime getFecha()
        {
            return fecha_estreno;
        }
        public int getPresupuesto()
        {
            return presupuesto;
        }
        public Estudio getestudio()
        {
            return estudio;
        }

        public void AgregarActor(Actor ac)
        {
            actores.Add(ac);
        }
        public void AgregarProductor(Productor produc)
        {
            productores.Add(produc);
        }

        public List<Productor> getproductorespelicula()
        {
            return productores;
        }

        public List<Actor> getactoresopelicula()
        {
            return actores;
        }

        public List<Critica> getlistacriticas()
        {
            return criticas;
        }

    }
}
