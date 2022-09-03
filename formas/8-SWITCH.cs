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
                switch (var_Usuario)
                {   //cuando cada caso que se cumpla se va a realizar cierta accion
                    case "Eduardo": //cuando el usuario escriba el nombre Eduardo se va a realizar el mbox
                        MessageBox.Show("Escribiste Eduardo, puedes pasar");

     //para indicar que el SWITCH pueda terminar se utiliza el BREAK, indica que el caso se termino y el switch no necesita andar buscando Casos por que su funcion se cumplio
                        break;

                    case "David":
                        MessageBox.Show("Correcto puedes ingresar");
                        break;



                    default: //esto indica que si no se cumple ninguno de los casos que nosotros proponemos arriba entonces va a tener un DEFAULT que seria como el ELSE del IF.
                        MessageBox.Show("Esa opcion no es validad");
                        break;
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
