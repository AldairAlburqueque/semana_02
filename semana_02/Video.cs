using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana_02
{
    internal class Video
    {
        private int codigoVideo {  get; set; }
        private string nombreVideo {  get; set; }
        private double duracion {  get; set; }
        private double precioSolesVideo { get; set; }
        private double tipoCambio { get; set; }

        public Video(int codigoVideo, string nombreVideo, double duracion, double precioSolesVideo, double tipoCambio)
        {
            this.codigoVideo = codigoVideo;
            this.nombreVideo = nombreVideo;
            this.duracion = duracion;
            this.precioSolesVideo = precioSolesVideo;
            this.tipoCambio = tipoCambio;
        }

        public int getSetCodigoVideo
        {
            get {  return codigoVideo; }
            set { codigoVideo = value;}
        }
        
        public string getSetNombreVideo
        {
            get { return nombreVideo; }
            set {  nombreVideo = value;}
        }

        public double getSetDuracion
        {
            get { return duracion; }
            set { duracion = value; }
        }

        public double getSetPrecioSoles
        {
            get { return precioSolesVideo; }
            set { precioSolesVideo = value; }
        }

        public double getSetTipoCambio
        { 
            get { return tipoCambio; }
            set { tipoCambio = value; }
        }

        public double precioVideoDolares()
        {
            return precioSolesVideo * tipoCambio;
        }
    }
}
