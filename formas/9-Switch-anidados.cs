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
                {   //SWITCH ANIDADOS. TENER UN SWITCH DENTRO DE OTRO
                    case "Eduardo": 
                        MessageBox.Show("Escribiste Eduardo, puedes pasar");

                        switch (var_contraseña)
                        {
                            case "1234":
                                MessageBox.Show("Correcto");
                                break;

                            default:

                                MessageBox.Show("!!!Contrase;a incorrecta!!!");

                                break;
                        }

                        break;

                    case "David":
                        MessageBox.Show("Correcto puedes ingresar");
                        break;



                    default:
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
