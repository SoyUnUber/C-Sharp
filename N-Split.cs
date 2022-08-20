Console.Title = "String (Cadenas) split"; //Titulo de la consola
Console.ForegroundColor = ConsoleColor.Yellow; //Color de la consola

//objetivo: descomponemos 'hola bienvenidos a programando en C#' en una cadena, ejemplo. "hola" una cadena, "bienvenidos" una cadena.  
// usaremos SPLIT.
string ejemplo = "Hola bienvenidos, a programando en C#";
//creamos el delimitador (nos separa la cadena como tal), variable char.
char[] delimitador = { ',' , ' ' };
//creamos un vector de cadena donde este mismo vector contendra todas las subcadenas o todos los trozos que esten delimitados por , O por ESPACIO.
string[] trozos = ejemplo.Split(delimitador);
int i;
for (i = 0; i < trozos.Length; i++)
{
    Console.WriteLine("Fragmento {0} = {1}", (i + 1), trozos[i]);
}
Console.ReadKey();

//resumen: el split descompone una cadena en varias sub cadenas.