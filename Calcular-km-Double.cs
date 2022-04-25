/*Ejercicio 2: 
 * El usuario tecleará una distancia en metros y el programa debera mostrar el resultado en kilometros*/
double Metros, Kilometros; //Declaramos variables de tipo DOUBLE ya que manejan decimales y para que nos den un valor un mas exacto. El tipo de DATO INT no maneja Decimales 
Console.WriteLine("Ingrese las cantidad de metros que desee");
Metros = Convert.ToDouble(Console.ReadLine()); //Usamos Convert.ToDouble por que Estamos usando La variable DOUBLE y no se usa el 32 BITS (Creo) 
Kilometros = Metros / 1000; // Matematicamente 1000 M vale 1 Km. Aca lo que haremos sera decir que Kilometros valdra a 1000 metros para que el resultado sea Matematicamente real"?
Console.WriteLine("{0} Metros es igual a {1} Kilometros", Metros, Kilometros);
Console.ReadKey();
