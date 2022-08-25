namespace WinFormsApp1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string Nombre = "Maleta"; //tipo de texto

            int num1 = 450; //entero
            uint num2 = 500; //entero solo
            float num3 = 35.5f; //flotante
            double num4 = 45.50; //decimales
            decimal num5 = 502005.5888234m; //numero mucho mas grande
            byte num6 = 255; //solo llega a 255

            MessageBox.Show(num1.ToString()); //muesta NUM1 convertido a string


            /* ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            */
        }
    }
}
