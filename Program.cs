// Condicional IF Else
/* Esto de abajo es La 
 * Estructura De If Else
 * 
 * IF (condición) //Si se cumple esta condicion va entrar a la siguiente parte
 * {
 *    sentencia  // La sentencia son acciones que realiza el programa 
 * }              
 * ELSE         // Si la Condicion es FALSA el va entrar a la otra sentencia es ELSE
 * {
 *    sentencia
 * }
 */
int x;

Console.WriteLine("Ingrese el valor de X");
x = Convert.ToInt32(Console.ReadLine());
if (x > 0)
{
    Console.WriteLine("El valor {0} es mayor a cero", x);
}
else
{
    Console.WriteLine("El valor {0} es menor o igual a cero", x);
}
Console.ReadKey();

/*|Operador|  |Operacion|
 *    >       Menor que
 *    <       Mayor que
 *   <=    Menor o igual que 
 *   >=    Mayor o igual que
 *   ==        Igual a
 *   !=   No igual a (distinto de)