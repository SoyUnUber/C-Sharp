/* Estructura y Resgistros */
/* Una estructura es un conjunto de datos donde esos datos son conocidos como Campos, esos esos campos pueden ser de diferentes tipos:
String, INT, Cadena, Manejar Tipo fecha, o cualquier otro dato que querramos en esta estructura*/
//Sencillo: es un conjunto de datos que define una estructura o unos atributos que tiene cierto registro
//Objetivo: Se creara un Estructura llamada estudiantes y tendra ciertos atributos, ciertos campos.
class Program
{
struct estudiante  //Estas estructuras se crean fuera del MAIN
{
    public string nombre; //Estos estos atributos deben ser publicos o privado. Publicos: Puedo acceder a ellos gracias a otros metodos/funcion. Privados: Son uso exclusivos para la estructura Estudiantes. 
    public int edad;
    public string asignatura;
    public int telefono;
}
static void Main(string[] args)
{
    //Estructura o registros
    estudiante nuevo = new estudiante(); //La estructura esta FUERA del Main es decir, no esta declarada dentro del main y no se reconocera. Es necesario declarar una variable de tipo "Estudiante". Estudiante tendra un comportamiento muy parecido a una variable.
    nuevo.nombre = "Dross Rotzank";
    nuevo.edad = 60;
    nuevo.asignatura = "Matematicas";
    nuevo.telefono = 777;
    Console.WriteLine("{0} Tiene {1} años...", nuevo.nombre, nuevo.edad);
    Console.ReadKey();
}
}
