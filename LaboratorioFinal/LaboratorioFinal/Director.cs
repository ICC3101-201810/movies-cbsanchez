using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioFinal
{
    [Serializable]
    class Director: Persona
    {

        List<Pelicula> peliculasDirector = new List<Pelicula>();
        public Director(string minombre, string miapellido, string mibiografia, DateTime fecha):base(minombre, miapellido, mibiografia, fecha)
        {
        }
        public List<Pelicula> getlistapeliculas()
        {
            return peliculasDirector;
        }
    }
}
