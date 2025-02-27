using System;
using System.IO;

public class ArchivoInventos
{
    // Ruta del archivo donde se guardarán los inventos
    private static string path = "C:/LaboratorioAvengers/inventos.txt";

    // Método para agregar una línea al archivo
    public static void AgregarLinea()
    {
        try
        {
            // Verifica si el archivo existe antes de agregar la línea
            if (File.Exists(path))
            {
                // Solicita al usuario ingresar el nombre de un invento
                Console.Write("Ingresa el nombre del invento: ");
                string invento = Console.ReadLine(); // Lee la entrada del usuario

                // Agrega la línea al final del archivo
                File.AppendAllLines(path, new string[] { invento });
                Console.WriteLine($"Invento '{invento}' agregado con éxito.");
            }
            else
            {
                Console.WriteLine("Error: El archivo 'inventos.txt' no existe. ¡Ultron debe haberlo borrado!");
            }
        }
        catch (Exception ex)
        {
            // Manejo de excepciones
            Console.WriteLine($"Error al agregar línea: {ex.Message}");
        }
    }
}
