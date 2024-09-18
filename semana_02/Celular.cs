using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace semana_02
{
    internal class Celular
    {
        private int numero {  get; set; }
        private string usuario { get; set; }
        private int segundosConsumidos { get; set; }
        private double precioXSegundo { get; set; }

        public Celular(int numero, string usuario, int segundosConsumidos, double precioXSegundo )
        {
            this.numero = numero;
            this.usuario = usuario;
            this.segundosConsumidos = segundosConsumidos;
            this.precioXSegundo = precioXSegundo;
        }


        public int getSetNumero
        {
            get { return numero; }
            set { numero = value; }
        }

        public string getSetUsuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public int getSetSegundosConsumidos
        {
            get { return segundosConsumidos; }
            set { segundosConsumidos = value; }
        }

        public double getSetPrecioXSegundo
        {
            get { return precioXSegundo; }
            set { precioXSegundo = value; }
        }


        public double costoXConsumo()
        {
            return segundosConsumidos * precioXSegundo;
        }

        public double IGV()
        {
            return costoXConsumo() * 0.18;
        }

        public double totalAPagar()
        {
            return costoXConsumo() + IGV();
        }
    }
}
