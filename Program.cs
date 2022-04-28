// Estructura alternativa de control SWITCH (Comportamiento similar a IF);
char Letra;  //Caracter
Console.WriteLine("Digite una letra");
Letra = Convert.ToChar(Console.ReadLine()); //Char solamente nos lee UN caracter, NO PALABRAS, NO MAS DE UN CARACTER, PARA ESO USAMOS STRING
switch(Letra)
{
    case 'a':
        Console.WriteLine("A digitado la letra a");
        break;
    case 'e':
        Console.WriteLine("A digitado la letra E");
        break;
    case 'i':
        Console.WriteLine("A digitado la letra I");
        break;
    case 'o':
        Console.WriteLine("A digitado la letra O");
        break;
    case 'u': 
        Console.WriteLine("A digitado la letra U");
        break;
    default: Console.WriteLine("La letra digitada NO es una vocal");
        break;
}
Console.ReadKey();