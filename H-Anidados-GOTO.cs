Console.Title = "Trabajo";
Console.ForegroundColor = ConsoleColor.Green;
Console.WindowHeight = 40;

//Ciclos anidados, etiquetas y salto incondicional 
//Un ciclo anidado es tener un FOR dentro de un FOR, O varios FOR dentro de un mismo FOR.
//Etiquetas se refiere al nombre, casi similar a un metodo. El nombre que le damos a dar a algo
//Salto incondicional (GO TO) Que vaya a esta direccion, En este caso seria la Etiqueta Y usamos una etiqueta, quiere decir que vaya a esa etiqueta

/* Objetivo:
 * I vale 0 y J vale 0
 * I vale 0 y J vale 1
 * I vale 0 y J vale 2
 * I vale 0 y J vale 3 
 * I vale 0 y J vale 4 
 * I vale 0 y J vale 5 
 * I vale 1 y J vale 0
 * I vale 1 y J vale 1
 * I vale 1 y J vale 2
 */
int I, J;
for (I = 0; I <= 5; I++) // I es igual a 0? Si. I es menor a 5? Si. Luego de eso entrara al segundo FOR 
/*{*/ // Cuando yo uso LLAVES{} Me hara todo el codigo que esta en dentro de la llave, aunque hayan saltos de linea. Pero si yo no uso las LLAVES{} Me hara la sentencia siguiente una vez terminada con el FOR.
    for (J = 0; J <= 5; J++) // J es igual a 0? Si. J es menor a 5? Si. Entonces lo que hara sera lo siguiente...
    {

    Console.WriteLine("I vale {0} y J vale {1}", I, J); // I llega hasta 1 y J llega hasta a 2
        if (I == 1 && J == 2) 
            goto salida; //Si se usa BREAK este terminara el FOR.
  //GOTO dice que vaya a SALIDA, Salida sera el Mensaje "HEMOS TERMINADO..."
    }
salida: Console.WriteLine("Hemos terminado...");
//El GOTO nos sirve cuando Tenemos muchos FOR anidados y queremos salir en cierto Determinado momento 
