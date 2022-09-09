using System.Reflection;

static void Main()
{
    // for (int i = 0; i < length; i++)
    // Bucles: BUCLE FOR es una estructura que va a repetir cierto codigo, ciertas cantidad de veces hasta que se cumpla una condicion.
    for (int i = 0; i < 10; i++) // estan divididos por punto y coma; por que son 3 elementos que necesitamos para que se cumpla o trabaje bien un FOR.
                                 // el primero seria el declarar una VARIABLE, donde va indicar un valor que va ser el valor inicial donde va a empezar a trabajar el FOR. En este caso es una variable que se llama INT y va empezar desde 0
                                 // en segundo lugar tenemos la CONDICION, " i < legnth " que nos dice que I va ser largo hasta cierto numero se va repetir el for. el numero lo debemos poner nosotros.
        /* y la tercera parte "I++" es muy importante por que nos va a decir como va avanzar este bucle. I++ le estamos diciendo que va aumentando de uno en uno.
        entonces cuando se repita el FOR, I va a valer 0 de modo inicial, luego va a valer 1, luego 2, 3, 4 y hasta llegar en este caso al 9 por que la condicion nos dice que sea menor que 10 y en este caso seria el 9 el tope */


        /* algo muy importante tambien de tomar en cuenta en la hora de hacer un FOR, seria, el poner una atencion a nuestra condicion "1 < LENGHT" y al interador "i++".
        esto por que ponemos tanto mal el interador como la condicion, podriamos crear por accidente un BUCLE infinito el cual no nos va a dejar nunca seguir con el programa
        con el resto de codigo que tengamos o incluso va afectar el nivel de recursos del sistema y va a poder hacer que se caiga todo el programa.
         */
        // POR EJEMPLO
        for (int i = 0; i < 10; i--)
            /* Si en vez de usar i++, le pusiera i-- indicando que en lugar AUMENTAR UN NUMERO va a REDUCIRSE UN NUMERO. Entonces i, por ejemplo, va empezar en 0 va ir hacia atras
             va ir a menos uno, menos dos, menos tres, infinitamente. y nunca se va a cumplir la condicion de que i sea mayor que 10 por lo que este FOR se volveria INFINITO.
            */
    
    {

	}




}
