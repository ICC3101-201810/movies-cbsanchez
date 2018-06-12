using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioFinal
{
    [Serializable]
    class BaseDeDatos
    {
        List<Actor> actores = new List<Actor>();
        List<Productor> productores = new List<Productor>();
        List<Director> directores = new List<Director>();
        List<Pelicula> peliculas = new List<Pelicula>();
        List<Estudio> estudios = new List<Estudio>();
        public BaseDeDatos()
        {
        }

// guardar en listas
        public void guardarActor(Actor actor)
        {
            actores.Add(actor);
        }
        public void guardarProductor(Productor produc)
        {
            productores.Add(produc);
        }
        public void guardarDirectores(Director dire)
        {
            directores.Add(dire);
        }
        public void guardarPeliculas(Pelicula peli)
        {
            peliculas.Add(peli);
        }
        public void guardarEstudios(Estudio estu)
        {
            estudios.Add(estu);
        }

// get de las listas
        
        public List<Pelicula> GetListaPeliculas()
        {
            return peliculas;
        }
        public List<Actor> GetListaActores()
        {
            return actores;
        }
        public List<Productor> GetListaProductores()
        {
            return productores;
        }
        public List<Director> GetListaDirectores()
        {
            return directores;
        }
        public List<Estudio> GetListaEstudios()
        {
            return estudios;
        }

// lista en la que se encuentra el objeto buscado

        public String listaquepertenece(string nombre)
        {
            foreach(Estudio es in GetListaEstudios())
            {
                if (es.getNombre() == nombre)
                {
                    return "estudio";
                }
                else
                {
                    continue;
                }
            }
            foreach (Pelicula es in GetListaPeliculas())
            {
                if (es.getNombre() == nombre)
                {
                    return "pelicula";
                }
                else
                {
                    continue;
                }
            }
            foreach (Actor es in GetListaActores())
            {
                if (es.getNombre() == nombre)
                {
                    return "actor";
                }
                else
                {
                    continue;
                }
            }
            foreach (Productor es in GetListaProductores())
            {
                if (es.getNombre() == nombre)
                {
                    return "productor";
                }
                else
                {
                    continue;
                }
            }
            foreach (Director es in GetListaDirectores())
            {
                if (es.getNombre() == nombre)
                {
                    return "director";
                }
                else
                {
                    continue;
                }
            }
            return "no";
        }

        public Estudio entregarEstudio(string nombre)
        {
            foreach(Estudio es in GetListaEstudios())
            {
                if (es.getNombre() == nombre)
                {
                    return es;
                }
                else
                {
                    continue;
                }
            }
            return null;
        }
        
        public Pelicula EntregarPelicula(string nombre)
        {
            foreach (Pelicula es in GetListaPeliculas())
            {
                if (es.getNombre() == nombre)
                {
                    return es;
                }
                else
                {
                    continue;
                }
            }
            return null;
        }

        public Actor entregaractor(string nombre)
        {
            foreach (Actor es in GetListaActores())
            {
                if (es.getNombre() == nombre)
                {
                    return es;
                }
                else
                {
                    continue;
                }
            }
            return null;
        }

        public Productor entregarproductor(string nombre)
        {
            foreach (Productor es in GetListaProductores())
            {
                if (es.getNombre() == nombre)
                {
                    return es;
                }
                else
                {
                    continue;
                }
            }
            return null;
        }
         
        public Director entregardirector(string nombre)
        {
            foreach (Director es in GetListaDirectores())
            {
                if (es.getNombre() == nombre)
                {
                    return es;
                }
                else
                {
                    continue;
                }
            }
            return null;
        }
            
            
            
    }
}
