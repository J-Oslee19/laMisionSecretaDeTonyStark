
public class LeerTodoElTextoArchivoInventos
{
    // Ruta del archivo donde se guardan los inventos
    private static string path = "C:/LaboratorioAvengers/inventos.txt";

    // Método para leer todo el contenido del archivo
    public static void LeerTodoElTexto()
    {
        try
        {
            // Verifica si el archivo existe antes de leerlo
            if (File.Exists(path))
            {
                // Lee todo el contenido del archivo en una sola cadena
                string contenido = File.ReadAllText(path);

                // Muestra el contenido del archivo
                Console.WriteLine("Contenido del archivo:");
                Console.WriteLine(contenido);
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
