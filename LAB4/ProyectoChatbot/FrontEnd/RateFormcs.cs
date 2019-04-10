using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEnd
{

    /// <summary>
    /// Esta clase es la encargada de la interfaz grafica del Rate. Deja ponerle una nota al chatbot.
    /// </summary>
    public partial class RateFormcs : Form
    {
        private String nota="";

        public RateFormcs()
        {
            InitializeComponent();
        }

        /// <summary>
        /// este método de evento del boton rate, es el que asigna el valor de la lista indexada al string nota
        /// </summary>
        private void rateButton2_Click(object sender, EventArgs e)
        {
            nota = listaRate.Text;
            if(nota == "")
            {
                MessageBox.Show("Porfavor seleccione una nota.");
            }
            else
            {
                Close();
            }       
        }

        
        public string getNota()
        {
            return nota;
        }

        private void listaRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// este metodo evita que cierren el cuadro de rate sin evaluar primero
        /// </summary>
        private void rate_Close(object sender, FormClosingEventArgs e)
        {
            if(nota == "")
            {
                MessageBox.Show("Porfavor seleccione una nota.");
                e.Cancel = true;
            }
        }
    }
}
