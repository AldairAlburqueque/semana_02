using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana_02
{
    internal class Edificio
    {
        private int codigoEdificio {  get; set; }
        private int nDepartamentos { get; set; }
        private int cantPisos { get; set; }
        private double precioDepaDolares { get; set; }

        public Edificio(int codigoEdificio, int nDepartamentos, int cantPisos, double precioDepaDolares)
        {
            this.codigoEdificio = codigoEdificio;
            this.nDepartamentos = nDepartamentos;
            this.cantPisos = cantPisos;
            this.precioDepaDolares = precioDepaDolares;
        }

        public int getSetCodigoEdificio
        { 
            get {  return codigoEdificio; }
            set { this.codigoEdificio = value; }
        }

        public int setGetNumDepa
        {
            get { return nDepartamentos; }
            set { nDepartamentos = value; }
        }

        public int getSetCantPisos
        {
            get { return cantPisos; }
            set { cantPisos = value; }
        } 

        public double getSetPrecioDepaDolares
        {
            get { return precioDepaDolares; }
            set { precioDepaDolares = value; }
        }

        public double precioDolaresEdificio()
        {
            return nDepartamentos * getSetPrecioDepaDolares;
        }
    }
}
