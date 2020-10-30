using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea5_LeonardoMolina.Clases
{
    class Promedio
    {
        public int promedio(int nota1, int nota2, int nota3)
        {
            int promedio;
            promedio = nota1 + nota2 + nota3;
            return promedio;
        }
        public int Faltante(int promedio)
        {
            int faltante;
            faltante = 65 - promedio;
            return faltante;
        }
        
    }
}
