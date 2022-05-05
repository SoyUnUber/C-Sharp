/* Estructuras Anidadas*/ 
class program
{
    struct programa
    {
        public string Facultad;
        public string Universidad;
        public string Carrera;
    }

    struct estudiante
    {
        public string nombre;
        public int edad;
        public string asignatura;
        public int telefono;
        public programa estudios; //Donde programa tiene 3 Atributos (Facultad, Universidad, Carrera). 
    }
    static void Main(string[] args)
    {
        /*Personalizando mi Consola*/
        Console.Title = "Estructuras anidades";
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WindowHeight = 40;

        //Estructuras o Registros 
        //Estructuras anidades
        estudiante primiparo = new estudiante();
        primiparo.nombre = "Jimena";
        primiparo.edad = 25;
        primiparo.telefono = 44491 - 2301;
        primiparo.estudios.Carrera = "Industrial";
        primiparo.estudios.Universidad = "UTP";
        primiparo.estudios.Facultad = "el del frente";
        Console.WriteLine("{0} estudia ingeneria {1} en la universidad {2}", primiparo.nombre, primiparo.estudios.Carrera, primiparo.estudios.Universidad);
        Console.ReadKey();
    }
} // Asi funciona un Vector de tipo de dato Estructura, Similar a un Vector de Enteros, Caracteres o Cadenas. Es practicamente el mismo funcionamiento. Esto fue un ejemplo de Estructuras Anidades.
