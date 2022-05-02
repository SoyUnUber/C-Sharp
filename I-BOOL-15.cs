/*  Datos BOOLEANOS  */
//El programa le pedira al usuario una Letra y el nos indicara si pertenece a los Numeros, a las vocales o una Consonante o un Simbolo.
char letra; //El CHAR solo acepta solo UNA LETRA O UN SIMBOLO, SOLO UN CARACTER!!!!!!!!!!
bool esnum, esvocal;
Console.Write("Digite una letra: ");
letra = Convert.ToChar(Console.ReadLine()); //Letra sera igual a = El usuario tecleara un caracter tipo CHAR
esnum = (letra >= '0') && (letra <= '9'); //porq no 10, 11, o Un numero MAYOR? PORQ CHAR acepta UN caracter, Si yo digito 10 son 2 Caracteres! No nos sirve
// Letra es tipo CHAR 0 tendra que estar en comillas simples '' 
esvocal = (letra == 'a') || (letra == 'e' || (letra == 'i') || (letra == 'o') || (letra == 'u'); //Es vocal sera TRUE cuando Letra tome el valor de una VOCAL
if (esnum)  //Aca entran las condiciones.
    Console.WriteLine("Ha digitado el numero {0}", letra); //Que por favor muestre en pantalla "Ha digitado..."
else if (esvocal)  //Si no es eso por favor entra al else
    Console.WriteLine("Ha digitado la vocal {0}", letra);
else
    Console.WriteLine("Ha digitado una consonante o un simbolo");
Console.ReadKey();
