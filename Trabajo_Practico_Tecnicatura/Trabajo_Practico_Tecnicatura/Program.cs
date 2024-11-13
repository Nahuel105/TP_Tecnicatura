using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico_Tecnicatura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aerolinea aerolinea = GestorArchivos.CargarDatos();
            int opcion;

            do
            {
                Console.Clear();
                Console.WriteLine("Sistema de Gestión de Vuelos");
                Console.WriteLine("1. Agregar Vuelo");
                Console.WriteLine("2. Registrar Pasajeros");
                Console.WriteLine("3. Calcular Ocupación Media");
                Console.WriteLine("4. Vuelo con Mayor Ocupación");
                Console.WriteLine("5. Buscar Vuelo por Código");
                Console.WriteLine("6. Listar Vuelos Ordenados por Ocupación");
                Console.WriteLine("7. Guardar y Salir");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        AgregarVuelo(aerolinea);
                        break;
                    case 2:
                        RegistrarPasajeros(aerolinea);
                        break;
                    case 3:
                        CalcularOcupacionMedia(aerolinea);
                        break;
                    case 4:
                        MostrarVueloConMayorOcupacion(aerolinea);
                        break;
                    case 5:
                        BuscarVueloPorCodigo(aerolinea);
                        break;
                    case 6:
                        ListarVuelosOrdenadosPorOcupacion(aerolinea);
                        break;
                    case 7:
                        GestorArchivos.GuardarDatos(aerolinea);
                        Console.WriteLine("Datos guardados. Saliendo...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey();
            } while (opcion != 7);
        }

        static void AgregarVuelo(Aerolinea aerolinea)
        {
            Console.Write("Código de Vuelo: ");
            string codigo = Console.ReadLine();
            Console.Write("Fecha y Hora de Salida (yyyy-MM-dd HH:mm): ");
            DateTime fechaSalida = DateTime.Parse(Console.ReadLine());
            Console.Write("Fecha y Hora de Llegada (yyyy-MM-dd HH:mm): ");
            DateTime fechaLlegada = DateTime.Parse(Console.ReadLine());
            Console.Write("Nombre del Piloto: ");
            string piloto = Console.ReadLine();
            Console.Write("Nombre del Copiloto: ");
            string copiloto = Console.ReadLine();
            Console.Write("Capacidad Máxima: ");
            int capacidadMaxima = int.Parse(Console.ReadLine());

            Vuelo vuelo = new Vuelo
            {
                Codigo = codigo,
                FechaSalida = fechaSalida,
                FechaLlegada = fechaLlegada,
                Piloto = piloto,
                Copiloto = copiloto,
                CapacidadMaxima = capacidadMaxima,
                PasajerosActuales = 0
            };

            aerolinea.Vuelos.Add(vuelo);
            Console.WriteLine("Vuelo agregado exitosamente.");
        }

        static void RegistrarPasajeros(Aerolinea aerolinea)
        {
            Console.Write("Código de Vuelo: ");
            string codigo = Console.ReadLine();
            Vuelo vuelo = aerolinea.Vuelos.FirstOrDefault(v => v.Codigo == codigo);

            if (vuelo != null)
            {
                Console.Write("Cantidad de Pasajeros a Registrar: ");
                int pasajeros = int.Parse(Console.ReadLine());

                if (vuelo.PasajerosActuales + pasajeros <= vuelo.CapacidadMaxima)
                {
                    vuelo.PasajerosActuales += pasajeros;
                    Console.WriteLine("Pasajeros registrados exitosamente.");
                }
                else
                {
                    Console.WriteLine("Error: Supera la capacidad máxima del vuelo.");
                }
            }
            else
            {
                Console.WriteLine("Vuelo no encontrado.");
            }
        }

        static void CalcularOcupacionMedia(Aerolinea aerolinea)
        {
            if (aerolinea.Vuelos.Any())
            {
                double ocupacionMedia = aerolinea.Vuelos.Average(v => v.PorcentajeOcupacion());
                Console.WriteLine($"Ocupación media de la flota: {ocupacionMedia:F2}%");
            }
            else
            {
                Console.WriteLine("No hay vuelos registrados.");
            }
        }

        static void MostrarVueloConMayorOcupacion(Aerolinea aerolinea)
        {
            if (aerolinea.Vuelos.Any())
            {
                Vuelo vueloMayorOcupacion = aerolinea.Vuelos.OrderByDescending(v => v.PorcentajeOcupacion()).First();
                Console.WriteLine($"Vuelo con mayor ocupación: {vueloMayorOcupacion.Codigo}, {vueloMayorOcupacion.PorcentajeOcupacion():F2}%");
            }
            else
            {
                Console.WriteLine("No hay vuelos registrados.");
            }
        }
        static void BuscarVueloPorCodigo(Aerolinea aerolinea)
        {
            Console.Write("Código de Vuelo: ");
            string codigo = Console.ReadLine();
            Vuelo vuelo = aerolinea.Vuelos.FirstOrDefault(v => v.Codigo == codigo);

            if (vuelo != null)
            {
                Console.WriteLine($"Vuelo {vuelo.Codigo} - Ocupación: {vuelo.PorcentajeOcupacion():F2}%");
            }
            else
            {
                Console.WriteLine("Vuelo no encontrado.");
            }
        }
        static void ListarVuelosOrdenadosPorOcupacion(Aerolinea aerolinea)
        {
            var vuelosOrdenados = aerolinea.Vuelos.OrderByDescending(v => v.PorcentajeOcupacion());
            foreach (var vuelo in vuelosOrdenados)
            {
                Console.WriteLine($"Vuelo {vuelo.Codigo} - Ocupación: {vuelo.PorcentajeOcupacion():F2}%");
            }
        }
    }
}
