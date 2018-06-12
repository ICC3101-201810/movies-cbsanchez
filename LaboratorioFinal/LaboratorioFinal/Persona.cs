using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioFinal
{
    [Serializable]
    public abstract class Persona
    {
        String nombre, apellido, biografia;
        DateTime fecha_de_nacimiento;
        public Persona(string minombre, string miapellido, string mibiografia, DateTime fecha)
        {
            nombre = minombre;
            apellido = miapellido;
            biografia = mibiografia;
            fecha_de_nacimiento = fecha;
        }

        public string getNombre()
        {
            return nombre;
        }
        public string getApellido()
        {
            return apellido;
        }
        public string getBiografia()
        {
            return biografia;
        }
        public DateTime getfecha()
        {
            return fecha_de_nacimiento;
        }
    }


}
