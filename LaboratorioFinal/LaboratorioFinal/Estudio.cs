using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioFinal
{
    [Serializable]
    class Estudio
    {
        List<Pelicula> peliculasenestudio = new List<Pelicula>();
        String nombreestudio, direccion;
        DateTime fecha_apertura;
        public Estudio(string nombre, string midireccion, DateTime fecha)
        {
            nombreestudio = nombre;
            direccion = midireccion;
            fecha_apertura = fecha;
        }

        public string getNombre()
        {
            return nombreestudio;
        }
        public string getDireccion()
        {
            return direccion;
        }
        public DateTime getfecha()
        {
            return fecha_apertura;
        }

        public List<Pelicula> getlistapeliculas()
        {
            return peliculasenestudio;
        }
    }
}
