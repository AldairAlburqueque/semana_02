using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana_02
{
    internal class Obrero
    {
        private int codigoObrero {  get; set; }
        private string nombreObrero { get; set; }
        private int horasTrabajadas { get; set; }
        private double tarifaXHora { get; set; }

        public Obrero(int codigoObrero, string nombreObrero, int horasTrabajadas, double tarifaXHora)
        {
            this.codigoObrero = codigoObrero;
            this.nombreObrero = nombreObrero;
            this.horasTrabajadas = horasTrabajadas;
            this.tarifaXHora = tarifaXHora;
        }

        public int getSetCodigoObrero
        {
            get { return codigoObrero; }
            set { codigoObrero = value; }
        }

        public string getSetNombreObrero
        {
            get { return nombreObrero; }
            set { nombreObrero = value; }
        }

        public int getSetHorasTrabajadas
        {
            get { return horasTrabajadas; }
            set { horasTrabajadas = value; }
        }

        public double getSetTarifasXHora
        {
            get { return tarifaXHora; }
            set { tarifaXHora = value; }
        }

        public double sueldoBruto()
        {
            return horasTrabajadas * tarifaXHora;
        }

        public double descuentoAFP()
        {
            return sueldoBruto() * 0.1;
        }

        public double descuentoEPS()
        {
            return sueldoBruto() * 0.05;
        }

        public double sueldoNeto()
        {
            return sueldoBruto() - descuentoAFP() - descuentoEPS();
        }

    }
}
