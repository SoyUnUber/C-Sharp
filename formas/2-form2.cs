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
                byte textoDelTexbox = Convert.ToByte(txt_nombre.Text);

                lbl_texto.Text = textoDelTexbox.ToString();
            }
            catch (OverflowException x) //ademas del exception, existe el overflowexception. nos va a mostrar el error del tama;o 
            {

                MessageBox.Show("Error en el tama;o del numero: " + x); //si hay algun error, que se muestre en un mensaje.
            }
            //se puede tener mas de un catch
            catch (FormatException xx) //el formatexepcion seria cuando yo escribo con letras en vez de numero, un error de formato. el error caera en este catch y no el de arriba

            {
                MessageBox.Show("Error en el formato, no es un numero: " + xx);
            }
        }


        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
