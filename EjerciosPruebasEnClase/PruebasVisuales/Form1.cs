using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace PruebasVisuales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string mensaje = "Sistema realizado por Rubén Alejandro Ramirez\n";
                   mensaje += "en la cátedra Diseño y Gestión de Bases de datos\n";
                   mensaje += "año 2014\n";
                   mensaje += "Instituto Superior de Profesorado Nº20 \"Sdor Nestor J. Zamaro\" ";
            string titulo = "Gestión Alejandro";
                   
            MessageBox.Show(mensaje,titulo,MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnTest_MouseEnter(object sender, EventArgs e)
        {
            //MessageBox.Show("Cuidado con lo que estás por pulsar");
            //Hacemos que el botón se desplace hacia abajo
            // y hacia la derecha
            //btnTest.Top = btnTest.Top + 20;
            //btnTest.Left = btnTest.Left + 20;
            Random nroaleatorio = new Random();
            
            btnTest.Top = nroaleatorio.Next(this.Height-btnTest.Height);
            btnTest.Left = nroaleatorio.Next(this.Width-btnTest.Width);
        }

        private void btnTest_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string pregunta = "¿Está seguro que desea salir del sistema?";
            string titulo = "Gestión Alejandro";
            DialogResult respuesta = MessageBox.Show(pregunta, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                //si responde que si cierra el formulario
                e.Cancel = false;
            }
            else
            {
                //si responde que no, no cierra el formulario
                e.Cancel = true;
            }
        }

        private void abrirArchivoDeTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofdAbrirArchivo.ShowDialog();
            StreamReader textoarchivo = new StreamReader(ofdAbrirArchivo.FileName);
            rtbTextoDocumento.Text = textoarchivo.ReadToEnd();
        }
    }
}
