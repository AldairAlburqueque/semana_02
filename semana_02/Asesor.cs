using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana_02
{
    internal class Asesor
    {
        private int codigoAsesor {  get; set; }
        private string nombreAsesor { get; set; }
        private int horasTrabajadasAsesor { get; set; }
        private double tarifaXHoraAsesor { get; set; }

        public Asesor(int codigoAsesor, string nombreAsesor, int horasTrabajadasAsesor, double tarifaXHoraAsesor)
        {
            this.codigoAsesor = codigoAsesor;
            this.nombreAsesor = nombreAsesor;
            this.horasTrabajadasAsesor = horasTrabajadasAsesor;
            this.tarifaXHoraAsesor = tarifaXHoraAsesor;
        }

        public int getSetCodigoAsesor
        {
            get { return codigoAsesor; }
            set { codigoAsesor = value; }
        }

        public string getSetNombreAsesor
        {
            get { return nombreAsesor; }
            set { nombreAsesor = value; }
        }

        public int getSetHorasTrabajadasAsesor
        {
            get { return horasTrabajadasAsesor; }
            set { horasTrabajadasAsesor = value; }
        }

        public double getSetTarifasXHoraAsesor
        {
            get { return tarifaXHoraAsesor; }
            set { tarifaXHoraAsesor = value; }
        }

        public double sueldoBrutoAsesor()
        {
            return horasTrabajadasAsesor * tarifaXHoraAsesor;
        }

        public double descuentoAsesor()
        {
            return sueldoBrutoAsesor() * 0.15;
        }

        public double sueldoNetoAsesor()
        {
            return sueldoBrutoAsesor() - descuentoAsesor();
        }
    }
}
