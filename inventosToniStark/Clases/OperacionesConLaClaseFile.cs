
public class ManejoArchivosYDirectorios
{
    private static string archivo = "C:/LaboratorioAvengers/inventos.txt";
    private static string directorioBackup = "C:/LaboratorioAvengers/Backup";
    private static string directorioClasificados = "C:/LaboratorioAvengers/ArchivosClasificados";
    private static string directorioProyectos = "C:/LaboratorioAvengers/ProyectosSecretos";

    // Método para copiar el archivo "inventos.txt" a la carpeta "Backup"
    public static void CopiarArchivo()
    {
        try
        {
            if (File.Exists(archivo))
            {
                // Verifica si la carpeta de backup existe, sino la crea
                if (!Directory.Exists(directorioBackup))
                {
                    Directory.CreateDirectory(directorioBackup);
                }

                // Copia el archivo al directorio de backup
                string pathBackup = Path.Combine(directorioBackup, "inventos.txt");
                File.Copy(archivo, pathBackup, true);  // 'true' sobreescribe si el archivo ya existe

                Console.WriteLine("Archivo copiado exitosamente a 'Backup'.");
            }
            else
            {
                Console.WriteLine("Error: El archivo 'inventos.txt' no existe.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al copiar el archivo: {ex.Message}");
        }
    }

    // Método para mover el archivo "inventos.txt" a la carpeta "ArchivosClasificados"
    public static void MoverArchivo()
    {
        try
        {
            if (File.Exists(archivo))
            {
                // Verifica si la carpeta de archivos clasificados existe, sino la crea
                if (!Directory.Exists(directorioClasificados))
                {
                    Directory.CreateDirectory(directorioClasificados);
                }

                // Mueve el archivo a la carpeta de archivos clasificados
                string pathClasificados = Path.Combine(directorioClasificados, "inventos.txt");
                File.Move(archivo, pathClasificados);

                Console.WriteLine("Archivo movido exitosamente a 'ArchivosClasificados'.");
            }
            else
            {
                Console.WriteLine("Error: El archivo 'inventos.txt' no existe.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al mover el archivo: {ex.Message}");
        }
    }

    // Método para crear una nueva carpeta llamada "ProyectosSecretos"
    public static void CrearCarpeta()
    {
        try
        {
            if (!Directory.Exists(directorioProyectos))
            {
                Directory.CreateDirectory(directorioProyectos);
                Console.WriteLine("Carpeta 'ProyectosSecretos' creada exitosamente.");
            }
            else
            {
                Console.WriteLine("La carpeta 'ProyectosSecretos' ya existe.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al crear la carpeta: {ex.Message}");
        }
    }

    // Método para verificar si el archivo "inventos.txt" existe
    public static bool VerificarExistenciaArchivo()
    {
        if (File.Exists(archivo))
        {
            Console.WriteLine("El archivo 'inventos.txt' existe.");
            return true;
        }
        else
        {
            Console.WriteLine("Error: El archivo 'inventos.txt' no existe.");
            return false;
        }
    }

    // Método para eliminar el archivo "inventos.txt" después de hacer una copia de seguridad
    public static void EliminarArchivo()
    {
        try
        {
            if (File.Exists(archivo))
            {
                // Elimina el archivo
                File.Delete(archivo);
                Console.WriteLine("Archivo 'inventos.txt' eliminado exitosamente.");
            }
            else
            {
                Console.WriteLine("Error: El archivo 'inventos.txt' no existe.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al eliminar el archivo: {ex.Message}");
        }
    }

    // Método para listar todos los archivos dentro de la carpeta "LaboratorioAvengers"
    public static void ListarArchivos()
    {
        try
        {
            if (Directory.Exists("C:/LaboratorioAvengers"))
            {
                string[] archivos = Directory.GetFiles("C:/LaboratorioAvengers");

                Console.WriteLine("Archivos en 'LaboratorioAvengers':");
                foreach (string archivo in archivos)
                {
                    Console.WriteLine(Path.GetFileName(archivo));
                }
            }
            else
            {
                Console.WriteLine("La carpeta 'LaboratorioAvengers' no existe.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al listar archivos: {ex.Message}");
        }
    }

    // Método para mostrar el menú de opciones
    public static void MostrarMenu()
    {
        int opcion;

        do
        {
            
            Console.WriteLine("===== Menú de Operaciones de Archivos =====");
            Console.WriteLine("1. Copiar archivo 'inventos.txt' a 'Backup'");
            Console.WriteLine("2. Mover archivo 'inventos.txt' a 'ArchivosClasificados'");
            Console.WriteLine("3. Crear carpeta 'ProyectosSecretos'");
            Console.WriteLine("4. Verificar si existe el archivo 'inventos.txt'");
            Console.WriteLine("5. Eliminar archivo 'inventos.txt' después de hacer una copia de seguridad");
            Console.WriteLine("6. Listar archivos en la carpeta 'LaboratorioAvengers'");
            Console.WriteLine("7. Salir");
            Console.Write("Selecciona una opción: ");
            
            // Lee la opción seleccionada
            bool opcionValida = int.TryParse(Console.ReadLine(), out opcion);

            if (!opcionValida || opcion < 1 || opcion > 7)
            {
                Console.WriteLine("Opción inválida, por favor ingresa un número entre 1 y 7.");
                continue;
            }

            // Ejecuta la opción seleccionada
            switch (opcion)
            {
                case 1:
                    CopiarArchivo();
                    break;
                case 2:
                    MoverArchivo();
                    break;
                case 3:
                    CrearCarpeta();
                    break;
                case 4:
                    VerificarExistenciaArchivo();
                    break;
                case 5:
                    EliminarArchivo();
                    break;
                case 6:
                    ListarArchivos();
                    break;
                case 7:
                    Console.WriteLine("¡Hasta luego!");
                    break;
            }

            Console.WriteLine("\nPresiona cualquier tecla para continuar...");
            

        } while (opcion != 7); // El programa se repetirá hasta que se seleccione la opción 7 (Salir)
    }
}
