// Manejo del DO-WHILE 
// Hace el ciclo Hasta que la condicion sea FALSA

/* Estructura del DO
 * {
 *     Sentencia;
 * } While(Condicion);
 * 
 */

int clave, valida;
clave = 123;
do
{
    Console.WriteLine("Digite la clave: ");
    valida = Convert.ToInt32(Console.ReadLine());
    if (valida != clave)
    {
        
        Console.WriteLine("CLAVE INVALIDA");
    }
} while (clave != valida);
    Console.WriteLine("CLAVE VALIDA....!!!");
    Console.ReadKey();