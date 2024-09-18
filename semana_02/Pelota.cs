using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana_02
{
    internal class Pelota
    {
        private string marcaPelota {  get; set; }
        private double pesoEnGramosPelota { get; set; } 
        private double presionEnLibrasPelota { get; set; }
        private double diametroEnCMPelota { get; set; }
        private double precioPelota { get; set; }

        public Pelota(string marcaPelota, double pesoEnGramosPelota, double presionEnLibrasPelota, double diametroEnCMPelota, double precioPelota)
        { 
            this.marcaPelota = marcaPelota;
            this.pesoEnGramosPelota = pesoEnGramosPelota;
            this.presionEnLibrasPelota = presionEnLibrasPelota;
            this.diametroEnCMPelota = diametroEnCMPelota;
            this.precioPelota = precioPelota;
        }

        public string getSetMarcaPelota
        {
            get { return marcaPelota; }
            set { marcaPelota = value; }
        }

        public double getSetPesoEnGramosPelota
        {
            get { return pesoEnGramosPelota; }
            set { pesoEnGramosPelota = value; }
        }

        public double getSetPresionEnLibrasPelota
        {
            get { return presionEnLibrasPelota; }
            set { presionEnLibrasPelota = value; }
        }

        public double getSetDiametroEnCMPelota
        {
            get { return diametroEnCMPelota; }
            set { diametroEnCMPelota = value; }
        }

        public double getSetPrecioPelota
        {
            get { return precioPelota; }
            set { precioPelota = value; }
        }

        public double radioPelota()
        {
            return diametroEnCMPelota / 2;
        }

        public double volumenPelota()
        {
            return 4 * 3.1416 * radioPelota() * radioPelota() * radioPelota() / 3;
        }

        public double descuentoPelota()
        {
            return precioPelota * 0.1;
        }

        public double importeAPagarPelota()
        {
            return precioPelota - descuentoPelota();
        }
    }
}
