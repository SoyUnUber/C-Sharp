//Sentencia Break y Continue en un bucle FOR;
// Break es terminar un ciclo independiente si llego al limite de la condicion o no, lo que hace es terminar
// Continue lo que hace es saltar dependiendo de cierta condicion que le demos 

int i;
for (i=1; i<=10; i++) // I va ser igual a 1, I va ser menor que 10, I va a subar 1 
{
    if (i == 5) //si I llega a 5
        break; // se va a terminar el ciclo 
    Console.WriteLine(i); // Me va a mostrar el valor de I en pantalla
}

Console.WriteLine();
for (i = 1; i <= 10; i++)
{
    if (i == 5)
        continue; //Nos va a mostrar los numeros 1,2,3,4 cuando llegue a 5 el compara, 5=5? Si, como la condicion es verdadera el Continua, pasa de aca a FOR
    Console.WriteLine(i);
}
Console.ReadKey();

/* Estructura basica de If
 *  if (Condición)
 *  {
 *      sentencia
 *  }
 *  else
 *  {
 *       sentencia
 *  }
 */
