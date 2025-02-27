
public class LeerArchivoInventos
{
    // Ruta del archivo donde se guardan los inventos
    public static string path = "C:/LaboratorioAvengers/inventos.txt";

    // Método para leer el archivo línea por línea
    public static void 
    LeerLineaPorLinea()
    {
        try
        {
            // Verifica si el archivo existe antes de leerlo
            if (File.Exists(path))
            {
                // Lee todas las líneas del archivo
                string[] lineas = File.ReadAllLines(path);

                // Muestra cada invento línea por línea
                Console.WriteLine("Inventos en el archivo:");
                foreach (string linea in lineas)
                {
                    Console.WriteLine(linea); // Muestra cada invento
                    Console.WriteLine("Presiona Enter para ver el siguiente invento...");
                    Console.ReadLine(); // Espera a que el usuario presione Enter
                }
            }
            else
            {
                Console.WriteLine("Error: El archivo 'inventos.txt' no existe. ¡Ultron debe haberlo borrado!");
            }
        }
        catch (Exception ex)
        {
            // Manejo de excepciones
            Console.WriteLine($"Error al leer el archivo: {ex.Message}");
        }
    }
}
