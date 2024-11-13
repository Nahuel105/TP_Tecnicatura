using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace Trabajo_Practico_Tecnicatura
{
    public static class GestorArchivos
    {
        private static string rutaArchivo = "datosAerolinea.xml";

        public static void GuardarDatos(Aerolinea aerolinea)
        {
            XmlSerializer serializador = new XmlSerializer(typeof(Aerolinea));
            using (FileStream archivo = new FileStream(rutaArchivo, FileMode.Create))
            {
                serializador.Serialize(archivo, aerolinea);
            }
        }

        public static Aerolinea CargarDatos()
        {
            if (File.Exists(rutaArchivo))
            {
                XmlSerializer serializador = new XmlSerializer (typeof(Aerolinea));
                using (FileStream archivo = new FileStream (rutaArchivo, FileMode.Open))
                {
                    return (Aerolinea)serializador.Deserialize(archivo);
                }
            }

            return new Aerolinea();
        }
    }
}
