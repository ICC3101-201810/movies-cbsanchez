using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioFinal
{
    class Critica
    {
        String texto, nombre_emisor;
        public Critica(String mitexto, string nombre)
        {
            texto = mitexto;
            nombre_emisor = nombre;
        }

        public string getNombre()
        {
            return nombre_emisor;
        }
        public string gettexto()
        {
            return texto;
        }
    }
}
