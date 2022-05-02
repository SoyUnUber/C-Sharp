Console.Title = "Arrays";
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WindowHeight = 30;
// Arrays - Arreglos 
// Son conjuntos de datos, Estos datos pueden ser de tipo INT, CHAR, STRING. Este conjunto pertenece a un solo tipo de dato 
/* Estructura basica de un arreglo:
 * tipo_dato [] nombre_var=new tipo_dato [tam] <-- Tamaño-Cantidad de datos que quiero en el conjunto (tam).
 */
    int [] numeros = new int [5]; //Indicamos el tipo de dato (INT), [] , nuestra variable se llamara NUMEROS, = , Se creara una nueva instancia de este tipo de dato -> new int, Despues indicamos la cantidad que queremos de datos [tam]
/* Para un conjunto de 5 datos de tipo int 
 * numeros[0] = valor del dato 1 
 * numeros[1] = valor del dato 2 
 * numeros[2] = valor del dato 3
 * numeros[3] = valor del dato 4
 * numeros[4] = valor del dato 5
 * 
 * Lo que esta adentro de [] es la posicion del dato en el conjunto de numeros*/
numeros[0] = 16;
numeros[1] = 20;
numeros[2] = 320; /*CONJUNTOS DE DATOS*/
numeros[3] = 30;
numeros[4] = 40;
int suma = numeros[2] + numeros[3];//Voy a decir que Entero "suma" sera igual a "numeros" que esta en la posicion [2] (320) y me lo Sume con el dato que esta en la posicion [3] (30)
//En resumen me va a mostrar 320 + 30;
Console.WriteLine("la suma de {0} + {1} es : {2}",numeros[2],numeros[3],suma);
Console.ReadKey();
/*Esto es basicamente un conjunto de datos del mismo tipo (En este caso entero INT) en los cuales podemos hacer operaciones, podemos editar, podemos insertar, podemos borrar.
 * Se pueden hacer operaciones con los arreglos*/
