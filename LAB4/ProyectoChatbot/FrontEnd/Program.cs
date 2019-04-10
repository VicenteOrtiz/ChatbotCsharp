using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


/**
 * 
 * La clase Programa es la que une todas las partes de esta solucion, tanto el FrontEnd como el BackEnd
 * 
 * @Author Vicente I. Ortiz Arancibia
 * @version 1.0
 * @since 1.0
 * 
 * */


namespace FrontEnd
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainForm Programa = new MainForm();

            MessageBox.Show("¡Bienvenido al asistente virtual de Vo'Confia! \n " +
                "- Aqui podrás conversar con uno de nuestros ejecutivos para tener información respecto a los preservativos que vendemos \n" +
                "- Esperamos tengas una buena experiencia, ¡que tengas un buen día!\n");

            Application.Run(Programa);
            




        }
    }
}
