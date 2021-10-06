using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computadora.Entidades
{
    class ClsComputadora
    {
        
        private String motherboard;
        private int ram;
        private String discoduro;
        private String  procesador;
        private String tarjetadevideo;
        private String teclado;
        private String mouse;
        private String marca;
        private String color;
        private String modelo;


        public string Motherboard { get => motherboard; set => motherboard = value; }
        public int Ram { get => ram; set => ram = value; }
        public string Discoduro { get => discoduro; set => discoduro = value; }
        public string Tarjetadevideo { get => tarjetadevideo; set => tarjetadevideo = value; }
        public string Teclado { get => teclado; set => teclado = value; }
        public string Mouse { get => mouse; set => mouse = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Color { get => color; set => color = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Procesador { get => procesador; set => procesador = value; }
    }
}
