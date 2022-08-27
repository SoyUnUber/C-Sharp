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

            

            try //estamos diciendo que intente realizar/ejecutar las dos lineas de codigo de abajo
            {
                byte textoDelTexbox = Convert.ToByte(txt_nombre.Text); //Indica que nos traiga lo que esta escrito en el textbox y lo lea en una variable y lo muestra en el LABEL

                lbl_texto.Text = textoDelTexbox.ToString(); //El label mostrara lo que dice en el string TEXTODELTEXBOOX = TXT NOMBRE.
            }
            catch (Exception) //si hay algun problema, el catch atrapa el error y lo va intentar controlar. exception atrapa cualquier problema si es que se llega a dar uno
            {

                MessageBox.Show("Error"); //si hay algun error, que se muestre en un mensaje.
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
