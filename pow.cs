/*Ejercicio 1:
 * el usuario tecleara dos numeros (a + b), y el programa mostrara el resultado de la operación (a+b)*(a-b) y el resultado de la operación
 * (a2-b2). (exponente a la dos) */
int a, b, resultado; //declaramos la variable.
Console.WriteLine("Ingrese el valor de A"); // Ingresamos el comentario que aparecera en la consola ""1.
a = Convert.ToInt32(Console.ReadLine()); //Convertimos el valor de A en un numero de 32 Bits que nosotros escribiremos en la consola gracias al comndo (Console.ReadLine) ""2.
Console.WriteLine("Ingrese el valor de B"); // ""2.
b = Convert.ToInt32(Console.ReadLine()); // ""1.
resultado = (a + b) * (a - b); // Declaramos que hara el int Resultado, sera la cuenta.
Console.WriteLine("El resultado sera (a + b) * (a - b) es {0}  ", resultado); //comentario final con el resultado.
Console.ReadKey(); // Nos servira para que la console no se cierre apenas salga el resultado de arriba.

double exponente1, exponente2, result;
Console.WriteLine("Ingrese el valor del exponente 1");
exponente1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese el valor del exponente 2");
exponente2 = Convert.ToInt32(Console.ReadLine());
result = Math.Pow(exponente1, 2) - Math.Pow(exponente2, 2); //Pow devuelve el numero especificado ("exponente1") elevado a la potencia especificada ("2").
                                                            //Para usar pow se necesita una Deficion de Tipo DOUBLE = Decimal ("NO USAR INT = ENTERO")
                                                            // Double es un numero bastante grande, es un numero que abarca mas de un bit que un Entero
Console.WriteLine("El resultado de esta operacion (X2-Y2) es {0}", result);
Console.ReadKey(); 
