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

                if (var_Usuario == "Eduardo") 
                {
                    MessageBox.Show("Nombre Correcto");

                    if (Convert.ToInt32(var_contraseña) < 99)
                    {


                        MessageBox.Show("Contrase;a Correcta!, su numero es menor que 100");

                    }

                    // ELSE IF
                    //Esto dira que si no se CUMPLE la primera condicion de IF "<100", que pregunte en el else o en la segunda parte del if, que pregunte otra condicion.
                    //y de no cumplirse entonces se mostrara el "Else 2. Contrase;a incorrecta!, prueba de nuevo."

                    else if (Convert.ToInt32(var_contraseña) > 101) //preguntara si el numero de la contrase;a sera mayor que 101
                    {
                        MessageBox.Show("!!!Contrase;a correcta, su numero es mayor que 100");
                    }
                    else
                    {
                        MessageBox.Show("Else 2. Contrase;a incorrecta!, prueba de nuevo.");
                    }
                    //100 no se podra usar por que la contrase;a tiene que ser mayor a 101 y menor a 99 
                }
                else 
                {
                    MessageBox.Show("INCORRECTO!!!"); 
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
