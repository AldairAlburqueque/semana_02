using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Celular celular = new Celular(987654321, "Maria", 50, 0.50);
            listadoCelular(celular);
            celular.getSetSegundosConsumidos += 20;
            celular.getSetPrecioXSegundo = celular.getSetPrecioXSegundo - (celular.getSetPrecioXSegundo * 0.05);
            listadoCelular(celular);

            Computadora computadora = new Computadora(100, "Lenovo", "Gris", 700);
            listadoComputadora(computadora);
            computadora.getSetPrecioDolar = computadora.getSetPrecioDolar - (computadora.getSetPrecioDolar * 0.1);
            listadoComputadora(computadora);

            Edificio edificio = new Edificio(1000, 20, 10, 120000);
            listadoEdificio(edificio);
            edificio.getSetPrecioDepaDolares = edificio.getSetPrecioDepaDolares + (edificio.getSetPrecioDepaDolares * 0.2);
            listadoEdificio(edificio);

            Obrero obrero = new Obrero(2000, "Juaan", 8, 10);
            listadoObrero(obrero);
            obrero.getSetHorasTrabajadas += 8;
            obrero.getSetTarifasXHora = obrero.getSetTarifasXHora - (obrero.getSetTarifasXHora * 0.015);
            listadoObrero(obrero);

            Video video = new Video(3000, "Spiderman", 70, 10, 3.73);
            listadoVideo(video);
            video.getSetPrecioSoles += 5.50;
            listadoVideo(video);

            Paciente paciente = new Paciente("Marcos", "Rivas", 15, 1.73, 70);
            listadoPaciente(paciente);
            paciente.getSetEdadPaciente = 29;
            listadoPaciente(paciente);

            Empleado empleado = new Empleado(3000, "Ana", 912345678, 3500);
            listadoEmpleado(empleado);
            empleado.getSetCelularEmpleado = 999888777;
            empleado.getSetSueldoSolesEmpleado += 200;
            listadoEmpleado(empleado);

            Asesor asesor = new Asesor(4000, "Andres", 8, 5);
            listadoAsesor(asesor);
            asesor.getSetHorasTrabajadasAsesor += 10;
            asesor.getSetTarifasXHoraAsesor = asesor.getSetTarifasXHoraAsesor - (asesor.getSetTarifasXHoraAsesor * 0.15);
            listadoAsesor(asesor);

            Pelota pelota = new Pelota("Walon", 900, 2, 25, 80);
            listadoPelota(pelota);
            pelota.getSetPrecioPelota = pelota.getSetPrecioPelota - (pelota.getSetPrecioPelota * 0.25);
            pelota.getSetDiametroEnCMPelota += 1;
            listadoPelota(pelota);


            Console.ReadKey();
        }

        public static void listadoCelular(Celular celular)
        {
            Console.WriteLine("Número de celular : " + celular.getSetNumero);
            Console.WriteLine("Nombre de usuario : " + celular.getSetUsuario);
            Console.WriteLine("Segundos consumidos : " + celular.getSetSegundosConsumidos);
            Console.WriteLine("Precio por segundo : " + celular.getSetPrecioXSegundo);
            Console.WriteLine("Costo por consumo : " + celular.costoXConsumo());
            Console.WriteLine("IGV : " + celular.IGV());
            Console.WriteLine("Total a pagar : " + celular.totalAPagar());
            Console.WriteLine("---------------------------------------------");
        }

        public static void listadoComputadora(Computadora computadora)
        {
            Console.WriteLine("Código de computadora : " + computadora.getSetCodigo);
            Console.WriteLine("Marca de computadora : " + computadora.getSetMarca);
            Console.WriteLine("Color de computadora : " + computadora.getSetColor);
            Console.WriteLine("Precio en dólar : " + computadora.getSetPrecioDolar);
            Console.WriteLine("Precio en soles : " + computadora.precioSoles());
            Console.WriteLine("Precio en euros : " + computadora.precioEuros());
            Console.WriteLine("---------------------------------------------");
        }

        public static void listadoEdificio(Edificio edificio)
        {
            Console.WriteLine("Código de edificio : " + edificio.getSetCodigoEdificio);
            Console.WriteLine("Número de departamentos : " + edificio.setGetNumDepa);
            Console.WriteLine("Cantidad de pisos del edificio : " + edificio.getSetCantPisos);
            Console.WriteLine("Precio departamento en dolares : " + edificio.getSetPrecioDepaDolares);
            Console.WriteLine("Precio del edificio en dolares : " + edificio.precioDolaresEdificio());
            Console.WriteLine("---------------------------------------------");
        }

        public static void listadoObrero(Obrero obrero)
        {
            Console.WriteLine("Código de obrero : " + obrero.getSetCodigoObrero);
            Console.WriteLine("Nombre obrero    : " + obrero.getSetNombreObrero);
            Console.WriteLine("Horas trabajadas : " + obrero.getSetHorasTrabajadas);
            Console.WriteLine("Tarifa por hora  : " + obrero.getSetTarifasXHora);
            Console.WriteLine("Sueldo bruto     : " + obrero.sueldoBruto());
            Console.WriteLine("Descuento por AFP : " + obrero.descuentoAFP());
            Console.WriteLine("Descuento por EPS : " + obrero.descuentoEPS());
            Console.WriteLine("Sueldo neto      : " + obrero.sueldoNeto());
            Console.WriteLine("---------------------------------------------");
        }

        public static void listadoVideo(Video video)
        {
            Console.WriteLine("Código de video : " + video.getSetCodigoVideo);
            Console.WriteLine("Nombre video : " + video.getSetNombreVideo);
            Console.WriteLine("Duración del video : " + video.getSetDuracion);
            Console.WriteLine("Precio en soles : " + video.getSetPrecioSoles);
            Console.WriteLine("Tipo de cambio : " + video.getSetTipoCambio);
            Console.WriteLine("Precio en dolares : " + video.precioVideoDolares());
            Console.WriteLine("---------------------------------------------");
        }

        public static void listadoPaciente(Paciente paciente)
        {
            Console.WriteLine("Nombre paciente        : " + paciente.getSetNombrePaciente);
            Console.WriteLine("Apellido paciente      : " + paciente.getSetApellidoPaciente);
            Console.WriteLine("Edad paciente          : " + paciente.getSetEdadPaciente);
            Console.WriteLine("Talla paciente         : " + paciente.getSetTallaPaciente);
            Console.WriteLine("Peso paciente          : " + paciente.getSetPesoPaciente);
            Console.WriteLine("¿Mayor o Menor de edad?: " + paciente.menorOMayorEdadPaciente());
            Console.WriteLine("---------------------------------------------");
        }

        public static void listadoEmpleado(Empleado empleado)
        {
            Console.WriteLine("Código de empleado        : " + empleado.getSetCodigoEmpleado);
            Console.WriteLine("Nombre empleado           : " + empleado.getSetNombreEmpleado);
            Console.WriteLine("Número celular empleado   : " + empleado.getSetCelularEmpleado);
            Console.WriteLine("Sueldo en soles empleado  : " + empleado.getSetSueldoSolesEmpleado);
            Console.WriteLine("El sueldo del empleado es : " + empleado.sueldoEmpleadoMayorOMenor());
            Console.WriteLine("---------------------------------------------");
        }

        public static void listadoAsesor(Asesor asesor)
        {
            Console.WriteLine("Código de asesor          : " + asesor.getSetCodigoAsesor);
            Console.WriteLine("Nombre de asesor          : " + asesor.getSetNombreAsesor);
            Console.WriteLine("Hoaras trabajadas         : " + asesor.getSetHorasTrabajadasAsesor);
            Console.WriteLine("Tarifa por hora           : " + asesor.getSetTarifasXHoraAsesor );
            Console.WriteLine("Sueldo bruto              : " + asesor.sueldoBrutoAsesor() );
            Console.WriteLine("Descuento                 : " + asesor.descuentoAsesor());
            Console.WriteLine("Sueldo Neto               : " + asesor.sueldoNetoAsesor());
            Console.WriteLine("---------------------------------------------");
        }

        public static void listadoPelota(Pelota pelota)
        {
            Console.WriteLine("Marca de pelota           : " + pelota.getSetMarcaPelota);
            Console.WriteLine("Peso en gramos pelota     : " + pelota.getSetPesoEnGramosPelota);
            Console.WriteLine("Presión en libras pelota  : " + pelota.getSetPresionEnLibrasPelota);
            Console.WriteLine("Diámetros en CM pelota    : " + pelota.getSetDiametroEnCMPelota);
            Console.WriteLine("Precio pelota             : " + pelota.getSetPrecioPelota);
            Console.WriteLine("Radio pelota              : " + pelota.radioPelota());
            Console.WriteLine("Volumen pelota            : " + pelota.volumenPelota() + " CM^3");
            Console.WriteLine("Descuento pelota          : " + pelota.descuentoPelota());
            Console.WriteLine("Total a pagar             : " + pelota.importeAPagarPelota());
            Console.WriteLine("---------------------------------------------");
        }

    }
}
