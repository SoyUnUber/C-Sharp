//objetivo como ingresar a cada caracter de una frase de una cadena que tengamos, y como podemos modificarla. no es sencillo, no se puede moficar como un vector. 
using System.Text;

Console.Title = "Strings-Cadena de caracteres";
string ejemplo = "Caballo"; //una variable String llamada Ejemplo que va a contener el mensaje "caballo"
Console.WriteLine(ejemplo[2]); //se muestra el caracter de la posicion 2 de la palabra CABALLO.
Console.WriteLine(ejemplo[6]);
//que pasa si yo quiero editar cada letra? se crea un constructor de STRING, que representa una cadena de CARACTERES MODIFICABLES.
StringBuilder Nombre_ejemplo = new StringBuilder(ejemplo); //stringbuilder se va a llamar Nombre_ejemplo que contiene un nuevo constructor de String que va a modificar la cadena llamada 'EJEMPLO' la cual contiene la palabra caballo
Nombre_ejemplo[0] = 'x'; //El constructor de string va ser igual a X quien reemplazara el caracter de la posicion 0. 
Console.WriteLine("La nueva cadena modificable es: {0}", Nombre_ejemplo);
Console.ReadKey();