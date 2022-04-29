// do-while basico por que no se estoooo1!!!!!!
int clave, valida;
clave = 123;
/* While cicla CICLA (CICLA)!!! mientras la condicion se cumpla
 * Do hace el ciclo hasta que la condicion se cumpla, una vez que la condicion se cumpla o sea Falsa esta sale del Do */
do
{
    Console.WriteLine("digite la clave: ");
    valida = Convert.ToInt32(Console.ReadLine());
    // SI/IF "valida" no es igual ("!=") a "clave" La respuesta sera clave invalida y empezara un bucle hasta digitar la clave valida
    if (valida != clave)
    {
        Console.WriteLine("CLAVE INVALIDA");
    } 
}while (clave != valida);
Console.WriteLine("clave valida :)");
Console.ReadKey();
/*     para saber: Operadores Relacionales 
 * operador  =  descripcion  =    ejemplo
 *   >=    |Mayor o igual que|     7>=4 Verdadero
 *   <=    |Menor o igual que|     7<=4 Falso
 *   ==        |Igual a|           7==4 Falso
 *   !=       |No igual a|         7!=4 Verdadero
 */


