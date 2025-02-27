class CrearArchivo
{
    public static void crearArchivo()
    {
        string directorio = "C:/LaboratorioAvengers";
        string archivo = "inventos.txt";
        string path = Path.Combine(directorio, archivo);

        try
        {
            // Verificamos si el directorio existe, si no lo creamos
            if (!Directory.Exists(directorio))
            {
                Directory.CreateDirectory(directorio);
                Console.WriteLine("Directorio creado: " + directorio);
            }

            // Creamos el archivo si no existe
            if (!File.Exists(path))
            {
                File.WriteAllText(path, "");
                Console.WriteLine("Archivo 'inventos.txt' .");
            }
            else
            {
                Console.WriteLine("El archivo 'inventos.txt' ya existe.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
