using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BackEnd;





namespace FrontEnd
{
    /// <summary>
    /// Esta clase es la clase que guarda todos los eventos que ocurren dentro del FrontEnd del programa, 
    /// es donde se activan los eventos, y se conectan con el backend
    /// </summary>
    /// 
    public partial class MainForm : Form
    {

        private int estado = 0;
        Chatbot chatbot1 = new Chatbot();
        Usuario usuario1 = new Usuario();
        Mensaje mensaje1 = new Mensaje();
        Random rnd = new Random();
        String[] oracionL;
        String comparar;
        

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// metodo del evento del boton beginDialog
        /// </summary>
        private void beginDialogButton_Click(object sender, EventArgs e)
        {
            if (estado == 0)
            {

                estado = 1;

                usuario1.set_ID(DateTime.Now.ToString("ddMMyyyyhhmmss"));

                chatbot1.setPersonalidad(rnd.Next(0, 3));

                chatBox.Text += "[ID: " + usuario1.get_ID() + "]\n";
                chatBox.Text += "[PERSONALIDAD: " + chatbot1.getPersonalidad() + "]\n";
            
                chatbot1.beginDialog();

                chatBox.Text += chatbot1.dime_respuesta() + "\n";

                chatBox.SelectionStart = chatBox.TextLength;
                chatBox.ScrollToCaret();
            }
            else
            {
                chatBox.Text += "[ERROR: Ya hay una conversación en curso, porfavor finalizar antes de comenzar una nueva.]\n";
            }
            
        }
        /// <summary>
        /// metodo del evento del boton endDialog
        /// </summary>
        private void endDialogButton_Click(object sender, EventArgs e)
        {
            if(estado == 1)
            {
                chatbot1.endDialog();

                chatBox.Text += chatbot1.dime_respuesta() + "\n";

                chatBox.Text += "[CHAT FINALIZADO] \n";

                chatBox.SelectionStart = chatBox.TextLength;
                chatBox.ScrollToCaret();

                MessageBox.Show("Porfavor ayudenos a mejorar el servicio calificando al chatbot con nota del 1 al 5. \n ¡Gracias por Confiar!");
                rateFunc();
                
                estado = 0;
            }
            else
            {
                chatBox.Text += "[ERROR: No se ha iniciado ninguna conversación, porfavor iniciar una antes de utilizar esta opción.]\n";
            }
        }
        /// <summary>
        /// metodo del evento del boton saveLog
        /// </summary>
        private void saveLogButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                mensaje1.log = "[logChatbot] \n" +chatBox.Text;
                File.WriteAllText(saveFileDialog1.FileName, mensaje1.log);

            }
        }
        /// <summary>
        /// metodo del evento del boton loadLog
        /// </summary>
        private async void loadLogButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*", Multiselect = false, ValidateNames = true })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        using (StreamReader sr = new StreamReader(ofd.FileName))
                        {
                            comparar = sr.ReadLine();
                            if (String.Equals("[logChatbot] ", comparar))
                            {
                                chatBox.Text += "[Se encontro log valido]\n";
                                chatBox.Text += await sr.ReadToEndAsync();
                            }
                            else
                            {
                                chatBox.Text += "\n[No se reconocio log valido.]\n";
                            }
                            
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// metodo del evento del boton sendButton
        /// </summary>
        private void sendButton_Click(object sender, EventArgs e)
        {
            if (estado == 1)
            {
                DateTime date = DateTime.Now;

                String entrada = date.ToString("[dd/MM/yyyy hh:mm:ss] ") + "Usuario> " + userInput.Text + "\n";

                chatBox.Text += entrada;

                Char delimitador = ' ';

                oracionL = userInput.Text.Split(delimitador);

                chatbot1.respuesta(oracionL);

                chatBox.Text += chatbot1.dime_respuesta() + "\n";

                userInput.Text = "";

                chatBox.SelectionStart = chatBox.TextLength;
                chatBox.ScrollToCaret();
            }
            else
            {
                MessageBox.Show("No ha iniciado una conversación. Porfavor inicie una para interactuar con el chatbot.");
            }

            
        }
        /// <summary>
        /// metodo del evento del boton rateFunc
        /// </summary>
        private void rateFunc()
        {
            RateFormcs rate = new RateFormcs();
     
            rate.ShowDialog();
;
            chatBox.Text += "Nota entregada por el usuario: " + rate.getNota() + "\n";
            mensaje1.notasChatbot.Add(Int32.Parse(rate.getNota()));
        }
        /// <summary>
        /// metodo del evento del boton statistics
        /// </summary>
        private void statistics_Click(object sender, EventArgs e)
        {
            if(mensaje1.notasChatbot.Count != 0)
            {
                double promedio;
                double desviacion;
                promedio = mensaje1.promedio(mensaje1.notasChatbot);
                desviacion = mensaje1.promedio(mensaje1.notasChatbot);

                chatBox.Text += "\n[Estadisticas del ChatBot]\n";
                chatBox.Text += "Numero de calificaciones: " + mensaje1.notasChatbot.Count + "\n";
                chatBox.Text += "Promedio: " + promedio + "\n";
                chatBox.Text += "Desviacion Estandar: " + desviacion + "\n";
                chatBox.Text += "Nota Maxima: " + mensaje1.notasChatbot.Max() + "\n";
                chatBox.Text += "Nota Minima: " + mensaje1.notasChatbot.Min() + "\n";

                chatBox.SelectionStart = chatBox.TextLength;
                chatBox.ScrollToCaret();
            }
            else
            {
                chatBox.Text += "[No hay notas aun]\n";
            }
            


        }
    }
}
