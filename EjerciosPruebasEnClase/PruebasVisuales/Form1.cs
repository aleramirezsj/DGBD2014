using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
            string pregunta="¿Está seguro que desea salir del sistema?";
            string titulo="Gestión Alejandro";
            DialogResult respuesta = MessageBox.Show(pregunta, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if ( respuesta== DialogResult.Yes)
            {
                this.Close();
            }
           

        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string mensaje = "Sistema realizado por Rubén Alejandro Ramirez\n";
                   mensaje += "en la cátedra Diseño y Gestión de Bases de datos\n";
                   mensaje += "año 2014\n";
                   mensaje += "Instituto Superior de Profesorado Nº20";
            string titulo = "Gestión Alejandro";
                   
            MessageBox.Show(mensaje,titulo,MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
