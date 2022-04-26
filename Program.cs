// Estructura de control IF 2
/* Con operadores logicos 
   Operador    Significado
     &&            Y
     ||            O
     !             No
Encontrar un multiplo de 2 y 3 */
int x;
Console.WriteLine("Ingrese el valor de la variable X");
x = Convert.ToInt32(Console.ReadLine());
if ((x % 2 == 0) & (x % 3 == 0))  //para averiguar el Resto utilizamos el signo "%" //si X% es igual a 0 y(&&) X% 3 es igual a 0, que por favor haga lo siguiente
{
    Console.WriteLine("El digito {0} es multiplo de 2 y 3... ", x); //Que me indique en pantalla que este numero donde el %2 y %3=0 es multiplo de 10  
}
else
{
    Console.WriteLine("El digito {0} NO es multiplo de 2 y 3... ", x); // Se busca un multiplo que sean de 2 y de 3
}
Console.ReadKey(); //Ejemplo: 6: 2+2+2 = 6. 3+3 =6 Son multiplos