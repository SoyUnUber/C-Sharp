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
                //podemos tener varios IF dentro de otros IF por ejemplo ->>

                if (var_Usuario == "Eduardo") //este if entrada al if de adentro
                {
                    MessageBox.Show("Nombre Correcto");

                    if (Convert.ToInt32(var_contraseña) < 100) //y este if trabajara con la contrase;a
                    {
                     
                        
                        MessageBox.Show("Contrase;a Correcta!, puedes pasar");
                   
                    }
                    else
                    {
                        MessageBox.Show("!!!Contrase;a incorrecta!!!");
                    }

                }
                else //este else solo funcionara si la variable USUARIO no es igual a EDUARDO 
                {
                    MessageBox.Show("INCORRECTO!!!"); //si la condicion no se cumple nos dara este mensaje "incorrecto"
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
