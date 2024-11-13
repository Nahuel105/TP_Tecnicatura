# TP_Tecnicatura
Trabajo final de Programación 1
Gestión de Ocupación y Estadísticas de Vuelos
Este proyecto es una aplicación de consola en C# que permite gestionar la ocupación de vuelos de una aerolínea, así como calcular estadísticas relacionadas. Los datos de la aerolínea, incluidos los vuelos y la información de ocupación, se guardan y cargan desde un archivo XML.

Características
La aplicación ofrece las siguientes funcionalidades:

Agregar un vuelo: Permite al usuario agregar un vuelo especificando el código de vuelo, fecha y hora de salida, fecha y hora de llegada, nombres del piloto y copiloto, y capacidad máxima de pasajeros.

Registrar pasajeros en un vuelo: Permite registrar el número de pasajeros que han abordado un vuelo específico, verificando que no se exceda la capacidad máxima.

Calcular ocupación media de la flota: Calcula el porcentaje promedio de ocupación de todos los vuelos registrados.

Mostrar vuelo con mayor ocupación: Muestra el vuelo con el mayor porcentaje de ocupación registrado.

Buscar vuelo por código: Permite ingresar un código de vuelo específico y muestra sus detalles junto con el porcentaje de ocupación.

Listar vuelos ordenados por ocupación: Muestra todos los vuelos ordenados en función de su porcentaje de ocupación, de mayor a menor.

Guardar y recuperar datos: Guarda los datos de la aerolínea en un archivo XML, lo que permite que los datos persistan entre ejecuciones del programa.

Estructura del Proyecto
Clase Vuelo: Contiene la información de cada vuelo, como el código, fechas, capacidad, y pasajeros actuales. Incluye métodos para calcular el porcentaje de ocupación.
Clase Aerolinea: Almacena la lista de vuelos y la información de contacto de la aerolínea. Incluye métodos para manejar los vuelos y calcular estadísticas.
Clase GestorDeArchivos: Proporciona métodos para guardar y cargar los datos de la aerolínea en un archivo XML.
Program.cs: Contiene el menú principal y llama a las funciones de Aerolinea para ejecutar las opciones seleccionadas.
Requisitos
.NET SDK (version 6.0 o superior)
Un editor de texto o IDE, como Visual Studio o Visual Studio Code
Instalación y Uso
Clona este repositorio:

bash
Copiar código
git clone https://github.com/tu-usuario/gestion-vuelos.git
Navega al directorio del proyecto:

bash
Copiar código
cd gestion-vuelos
Ejecuta el proyecto:

bash
Copiar código
dotnet run
Uso del Menú: La aplicación ofrece un menú para gestionar los vuelos y pasajeros. Ingresa el número de la opción deseada y sigue las instrucciones.

Ejemplo de Uso
Agregar un vuelo
Al seleccionar la opción para agregar un vuelo, se solicitarán los datos del vuelo, como el código, fechas de salida y llegada, nombres de los tripulantes y capacidad máxima. Tras ingresar estos datos, el vuelo se añadirá a la lista.

Registrar pasajeros en un vuelo
Para registrar pasajeros, selecciona la opción correspondiente e ingresa el código del vuelo y el número de pasajeros a registrar. La aplicación verifica que no se exceda la capacidad máxima.

Guardar y recuperar datos
Los datos de la aerolínea se guardan automáticamente al seleccionar la opción de "Guardar y Salir", y se cargan desde el archivo XML al iniciar la aplicación, lo que permite retener la información entre ejecuciones.

Manejo de Archivos
Los datos se guardan y cargan desde un archivo XML (datosAerolinea.xml) en el directorio raíz del proyecto. La clase GestorDeArchivos se encarga de serializar los datos de la clase Aerolinea en formato XML.

Estructura de Ejemplo del XML
El archivo XML generado tendrá un formato similar a este:

xml
Copiar código
<Aerolinea>
  <RazonSocial>Ejemplo Airlines</RazonSocial>
  <Telefono>+123456789</Telefono>
  <Domicilio>123 Calle Falsa, Ciudad</Domicilio>
  <Vuelos>
    <Vuelo>
      <Codigo>FL123</Codigo>
      <FechaSalida>2024-11-12T08:00:00</FechaSalida>
      <FechaLlegada>2024-11-12T12:00:00</FechaLlegada>
      <Piloto>Juan Pérez</Piloto>
      <Copiloto>Maria Lopez</Copiloto>
      <CapacidadMaxima>150</CapacidadMaxima>
      <PasajerosActuales>100</PasajerosActuales>
    </Vuelo>
    <!-- Más vuelos aquí -->
  </Vuelos>
</Aerolinea>
Contribuir
Si quieres contribuir a este proyecto:

Haz un fork del repositorio.
Crea una nueva rama (git checkout -b feature/nueva-funcionalidad).
Haz commit de tus cambios (git commit -am 'Añadir nueva funcionalidad').
Haz push a la rama (git push origin feature/nueva-funcionalidad).
Abre un pull request.
