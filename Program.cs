// Es vocal o no? El programa pedira una letra y dira si es VOCAL o no
string letra;
Console.WriteLine("Digite una letra");
letra = Console.ReadLine(); 
if (letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u") // Si letra es igual a A, E, I, O, U, La letra sera una vocal 
{
   Console.WriteLine("La letra \"{0}\" es vocal", letra);
}
else
{
    Console.WriteLine("La letra \"{0}\ NO! es una vocal", letra); //Si letra no es igual a A,E,I,O,U; la letra NO sera una vocal
}
Console.ReadKey();  