using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana_02
{
    internal class Paciente
    {
        private string nombrePaciente {  get; set; }
        private string apellidoPaciente { get; set; }
        private int edadPaciente { get; set; }
        private double tallaPaciente { get; set; }
        private double pesoPaciente { get; set; }

        public Paciente(string nombrePaciente, string apellidoPaciente, int edadPaciente, double tallaPaciente, double pesoPaciente)
        {
            this.nombrePaciente = nombrePaciente;
            this.apellidoPaciente = apellidoPaciente;
            this.edadPaciente = edadPaciente;
            this.tallaPaciente = tallaPaciente;
            this.pesoPaciente = pesoPaciente;
        }

        public string getSetNombrePaciente
        {
            get { return nombrePaciente; }
            set { nombrePaciente = value; }
        }

        public string getSetApellidoPaciente
        {
            get { return apellidoPaciente; }
            set { apellidoPaciente = value; }
        }

        public int getSetEdadPaciente
        {
            get { return edadPaciente; }
            set { edadPaciente = value; }
        }

        public double getSetTallaPaciente
        {
            get { return tallaPaciente; }
            set { tallaPaciente = value; }
        }

        public double getSetPesoPaciente
        {
            get { return pesoPaciente; } 
            set { pesoPaciente = value; } 
        }

        public string menorOMayorEdadPaciente()
        {
            if(edadPaciente >= 18)
            {
                return "Mayor de edad";
            }

            return "Menor de edad";
        }
    }
}
