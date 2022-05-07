// Strings - Cadena de caracteres // Es un conjunto de caracteres que pueden ser numeros, letras, simbolos, todo lo que acepte el compilador. 
string ejemplo = "hola bienvenidos a programando en C#"; // Vamos a remplazar esta cadena por otra, o a remover o reinsertar.
int tam = ejemplo.Length; //vamos a guardarla en una variable de tipo Entero y la vamos a llamar Tam (Tamano). y tam va ser igual a la cadena (Ejemplo)/ Length me devuelve la cantidad de Caracteres.
string subcad = "venidos"; // Venidos se encuentra en la parte de Bien'venidos'. por medio de un condicional de un IF vamos a decir si Venidos se encuentra en Ejemplo*
if(ejemplo.Contains(subcad))
    Console.WriteLine("{0} se encuentra en la frase: {1}",subcad,ejemplo);
Console.WriteLine("bien se encuentra en la posicion {0}",ejemplo.IndexOf("bien")); //IndexOf: yo le agrego una palabra y en el Ejemplo el busca la palabra "BIEN" y me retorna la primera posicion donde encontro esa palabra. 
Console.WriteLine("do se encuentra por ultima vez en la posicion {0}",ejemplo.LastIndexOf("do"));
Console.WriteLine("Mayuscula: {0}",ejemplo.ToUpper()); //Convertirmos la frase "hola, bienvenidos a programando en c#" en Mayuscula de la siguiente manera
Console.WriteLine("Minuscula: {0}",ejemplo.ToLower());//Para que me muestre una cadena en minuscula lo que hace
Console.WriteLine("Hemos insertado amigo a la frase: {0}",ejemplo.Insert(5,"amigo "));//haremos que la consola inserte un nombre X //lo que hace Insert es, dependiendo de la posicion donde yo le diga que inserte, el me inserta la palabra "amigo"   
Console.WriteLine("Hemos removido la palabra amigo de la frase: {0}",ejemplo.Remove(0,5));//ahora removemos la palabra de la POSICION 0 hasta la 5.
Console.WriteLine("Hemos reemplazado \"hola\" por \"que tal\": {0}", ejemplo.Replace("hola", "Que tal")); // Los \"hola\" backslash sirven para mostrar ENTRECOMILLAS la frase. // Se reemplazara HOLA por QUE TAL.
Console.ReadKey();
/* int tam = ejemplo.Lenght; Me dice la cantidad de caracteres que tiene la cadena. 
 * ejemplo.Contains(subcad)) Me indica si hay una subcadena en esta cadena (Cadena llamada Ejemplo)\
 *ejemplo.IndexOf("bien")); Me muestra la posicion de la primera vez que el encuentra esta palabra ("bien") dentro de esta cadena  (string ejemplo = "hola bienvenidos a programando en C#";)
 *ejemplo.LastIndexOf("do")); Me muestra la posicion de la ultima vez que el encuentra esta palabra ("do") dentro de esta cadena  (string ejemplo = "hola bienvenidos a programando en C#";)
 * ejemplo.ToUpper Modifico la Cadena en Mayuscula. 
 * ejemplo.ToLower Modifico la Cadena en Minuscula.
 * ejemplo.Insert Insertamos una frase en la cadena.
 * ejemplo.Remove Removemos una frase en la cadena.
 * ejemplo.Remplace Remplazamos una frase en la cadena.
 */