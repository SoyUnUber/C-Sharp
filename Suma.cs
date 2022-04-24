// suma con dos numeros teclados por el usuario
int Primernumero;
int Segundonumero;
int suma;

Console.WriteLine("Introduce el primer numero");
Primernumero = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Introduce el segundo numero");
Segundonumero = Convert.ToInt32(Console.ReadLine());
suma = Primernumero + Segundonumero ;
Console.WriteLine("El resultado de la suma es {0}",suma);
