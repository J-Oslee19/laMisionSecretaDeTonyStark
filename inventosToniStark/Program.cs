using System;
using System.IO;

class Program
{

    // Ruta base para los archivos y directorios
    static string directorioBase = "C:/LaboratorioAvengers/";

    static void Main()
    {

        // Crear el directorio base si no existe
        CrearCarpeta(directorioBase);

        // Menú interactivo
        bool continuar = true;
        while (continuar)
        {
            Console.WriteLine("Menú de operaciones de 'LaboratorioAvengers'");
            Console.WriteLine("1. Crear archivo de inventos");
            Console.WriteLine("2. Agregar invento");
            Console.WriteLine("3. Leer archivo (todo el contenido)");
            Console.WriteLine("4. Leer archivo línea por línea");
            Console.WriteLine("5. Mostrar menú de operaciones de archivos");
            Console.WriteLine("6. Salir");
            Console.Write("Elige una opción: ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    CrearArchivo.crearArchivo();// Llamar función de crear archivo
                    break;
                case "2":
                    ArchivoInventos.AgregarLinea();// Llamar función para agregar invento
                    break;
                case "3":
                    LeerTodoElTextoArchivoInventos.LeerTodoElTexto();// Llamar función para leer todo el archivo
                    break;
                case "4":
                LeerArchivoInventos.LeerLineaPorLinea();// Llamar función para leer línea por línea
                    break;
                case "5":
                     ManejoArchivosYDirectorios.MostrarMenu();
                    // Llamar función para copiar archivo
                    break;
                case "6":
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intenta de nuevo.");
                    break;
            }

            
        }
    }
  
    // Función para crear una carpeta si no existe
    static void CrearCarpeta(string path)
    {
        try
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
                Console.WriteLine("Directorio creado.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
