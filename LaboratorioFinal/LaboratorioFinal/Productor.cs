using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioFinal
{
    [Serializable]
    class Productor: Persona
    {

        List<Pelicula> peliculasProductor = new List<Pelicula>();
        public Productor(string minombre, string miapellido, string mibiografia, DateTime fecha):base(minombre, miapellido, mibiografia, fecha)
        {
        }

        public void AgregarPeliculaP(Pelicula peli)
        {
            peliculasProductor.Add(peli);
        }
        public List<Pelicula> getlistapeliculas()
        {
            return peliculasProductor;
        }
    }
}
