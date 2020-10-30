using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea5_LeonardoMolina.Clases
{
    class Ganancia
    {
        public double Ganancia1(double costo, double venta)
        {
            double Ganancia;
            Ganancia = (venta - costo);
            return Ganancia;
        }
        public double volumen(double radio, double altura, double diametro, double potencia)
        {
            double res;
            res = 3.14 * Math.Pow(radio,potencia) * altura;
            return res;
        }
        public double litros(double volumen, double litros)
        {
            double litros1;
            litros1 = volumen * 1000;
            return litros1;
        }
        public double radio(double diametro)
        {
            double radio;
            radio = diametro / 2;
            return radio;
        }
    }
}
