using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana_02
{
    internal class Empleado
    {
        private int codigoEmpleado {  get; set; }
        private string nombreEmpleado {  get; set; }
        private int celularEmpleado { get; set; }
        private double sueldoSolesEmpleado { get; set; }

        public Empleado(int codigoEmpleado, string nombreEmpleado, int celularEmpleado, double sueldoSolesEmpleado)
        {
            this.codigoEmpleado = codigoEmpleado;
            this.nombreEmpleado = nombreEmpleado;
            this.celularEmpleado = celularEmpleado;
            this.sueldoSolesEmpleado = sueldoSolesEmpleado;
        }

        public int getSetCodigoEmpleado
        {
            get { return codigoEmpleado; }
            set { codigoEmpleado = value; }
        }

        public string getSetNombreEmpleado
        {
            get { return nombreEmpleado; }
            set { nombreEmpleado = value; }
        }

        public int getSetCelularEmpleado
        {
            get { return celularEmpleado; }
            set { celularEmpleado = value; }
        }

        public double getSetSueldoSolesEmpleado
        {
            get { return sueldoSolesEmpleado; }
            set { sueldoSolesEmpleado = value; }
        }

        public string sueldoEmpleadoMayorOMenor()
        {
            if(sueldoSolesEmpleado > 3500)
            {
                return "mayor a 3500";

            }else if(sueldoSolesEmpleado == 3500)
            {
                return "igual a 3500";
            }else
            {
                return "menor a 3500";
            }
        }
    }
}
