// Estructura repetitivas;
// Uso del WHILe; Nos permiten hacer bucle, siclos, con cierta condicion, si esa condicion es falsa el ciclo para.
/* Estructura:
while (condición)
sentencia;
*/
int numero; //Declaramos la variable de tipo ENTERO (Int)
Console.WriteLine("Digite un numero o \"0\" para salir");   
numero = Convert.ToInt32(Console.ReadLine());
while (numero != 0)
{
    if (numero > 0) //Si numero es mayor a 0
    {
        Console.WriteLine("El numero {0} es positivo", numero); //El numero sera positivo
    }
    else //Si el numero no es mayor a 0
    {
        Console.WriteLine("El numero {0} es negativo", numero); //El numero sera negativo
    }
    Console.WriteLine("Digite otro numero, o \"0\" para salir"); 
    numero=Convert.ToInt32(Console.ReadLine());
}
Console.ReadKey();
