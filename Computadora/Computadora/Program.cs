using Computadora.Entidades;
using Computadora.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computadora
{
    class Program
    {
        static void Main(string[] args)
        {
            ClsComputadora clscomputadora = new ClsComputadora();
            NClsComputadora nclcomputadora = new NClsComputadora();

            clscomputadora.Ram = 8;
            clscomputadora.Procesador = "Intel core i5 dual core de 2,0 GHz";


            Console.WriteLine(nclcomputadora.Encender(clscomputadora));

            Console.ReadLine();

        }
    }
}
