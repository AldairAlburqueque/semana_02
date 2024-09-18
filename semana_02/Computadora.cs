using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana_02
{
    internal class Computadora
    {
        private int codigo {  get; set; }
        private string marca { get; set; }
        private string color { get; set; }
        private double precioDolares { get; set; }

        public Computadora(int codigo, string marca, string color, double precioDolares)
        {
            this.codigo = codigo;
            this.marca = marca;
            this.color = color;
            this.precioDolares = precioDolares;
        }

        public int getSetCodigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        //public int getCodi()
        //{
        //    return codigo;
        //}
        //public void setCod(int codigo)
        //{
        //    this.codigo = codigo;
        //}
        public string getSetMarca
        {
            get { return marca; }
            set { marca = value; }
        }

        public string getSetColor
        {
            get { return color; }
            set { color = value; }
        }

        public double getSetPrecioDolar
        {
            get { return precioDolares; }
            set { precioDolares = value; }
        }

        public double precioSoles()
        {
            return precioDolares * 3.35;
        }

        public double precioEuros()
        {
            return precioDolares * 1.20;
        }
    }
}
