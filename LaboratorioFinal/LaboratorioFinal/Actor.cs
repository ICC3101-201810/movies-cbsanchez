using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioFinal
{
    [Serializable]
    class Actor : Persona
    {
        String actor;
        List<Pelicula> peliculasActor = new List<Pelicula>();
        public Actor(string minombre, string miapellido, string mibiografia, DateTime fecha, string miactor):base(minombre, miapellido, mibiografia, fecha)
        {
            actor = miactor;
        }

        public void AgregarPeliculaA(Pelicula peli)
        {
            peliculasActor.Add(peli);
        }
        public List<Pelicula> getlistapeliculas()
        {
            return peliculasActor;
        }

    }
}
