using Computadora.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computadora.Negocio
{
    class NClsComputadora
    {
        public String Encender(ClsComputadora computadora)
        {

            return " La computadora con memoria Ram de " + computadora.Ram + " Con procesador " + computadora.Procesador + " Está encendida";

        }

        public String Apagar(ClsComputadora computadora)
        {
            return "La computadora con memoria Ram de " + computadora.Ram + " Con procesador" + computadora.Procesador + " Apagando computadora";

        }
        public String Reiniciar(ClsComputadora computadora)
        {
            return "La computadora con memoria Ram de " + computadora.Ram + " Con procesador" + computadora.Procesador + " Reiniciando computadora";


        }
        public String Suspender(ClsComputadora computadora)
        {
            return "La computadora con memoria Ram de " + computadora.Ram + " Con procesador" + computadora.Procesador + " Suspendiendo computadora";
        }
    }
} 
