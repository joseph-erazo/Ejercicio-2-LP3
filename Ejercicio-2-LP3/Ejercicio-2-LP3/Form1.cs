using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_2_LP3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {

            string[] nombre = new string[1];
            string[] edad = new string[1];
            string[] nombre_edad = new string[1];

            for (int i = 0; i < 1; i++)
            {
                nombre[i] = NombreTextBox.Text;
                edad[i] = EdadTextBox.Text;
                nombre_edad[i] = $"{nombre[i]}, {edad[i]} años de edad.";
            }

            for (int i = 0; i < 1; i++)
            {
                comboBox1.Items.Add(nombre_edad[i]);
            }

            NombreTextBox.Clear();
            EdadTextBox.Clear();
        }

        private void TerminarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
