namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {

            

            try 
            {
                //uniremos el texto que se recibira en el TEXTBOX del programa con "HOLA" que esta fijado en el codigo.

                string bienvenida = " bienvenido al programa de c#";

                string texto = "hola " + txt_nombre.Text + bienvenida; //cuando yo pongo + quiere decir que yo voy a unir otra cadena de texto o una variable.
                
                //Aqui tenemos 3 cosas en una variable. tenemos la cadena de texto que es "Hola" que se guarda en un string, tambien el contenido el texbox que viene desde el form que se va a convertir en un sring, y tambien el contenido de la variable bienvenida. 

                lbl_texto.Text = texto;
            }
            catch (OverflowException x)
            {

                MessageBox.Show("Error en el tama;o del numero: " + x);
            }
        }


        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
