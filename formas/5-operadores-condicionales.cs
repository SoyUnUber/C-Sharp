namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string var_Usuario = textBox1.Text;
            string var_contraseña = textBox2.Text;


            try
            {


                if (var_Usuario != "Eduardo" & Convert.ToInt32(var_contraseña) < 100) // != este operado dira que el variable usuario sera diferente a EDUARDO.
                { //si es diferente a eduardo la condicion se cumplira. y para la variable contraseña haremos que solo acepte numeros con CONVERT INT 32 
                    // con "< 100" decimos que la contrase;a tiene que ser menor a 100
                 //resume: el usuario para ingresar debe escribir un nombre que no sea EDUARDO (because i used !=). y debe ingresar una contrase;a menor a 100 (because i used <100)  

                    MessageBox.Show("Correcto!, puedes pasar");

                    //como hago para que me conteste si no es correcto el usuario y contrase;a? si no se cumple ninguna de las condiciones.  
                }
                else //eso se cumple con la palabra ELSE, que seguira siendo parte del IF. el codigo dentro de sus llaves va ser parte de lo que pasa cuando llega al ELSE osea que no cumplio alguna de las condiciones.
                {
                    MessageBox.Show("INCORRECTO!!!"); //si la condicion no se cumple nos dara este mensaje, contrase;a y usuario incorrecto.
                }



            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
