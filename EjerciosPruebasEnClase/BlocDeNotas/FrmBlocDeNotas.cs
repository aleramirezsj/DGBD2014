using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace BlocDeNotas
{
    public partial class FrmBlocDeNotas : Form
    {
        public FrmBlocDeNotas()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmBlocDeNotas_FormClosing(object sender, FormClosingEventArgs e)
        {
            string pregunta = "¿Está seguro que desea salir?";
            string titulo = "Bloc de notas";
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

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ofdAbrirArchivo.ShowDialog() == DialogResult.OK)
            {
                StreamReader textoArchivo = new StreamReader(ofdAbrirArchivo.FileName);
                rtbTextoDocumento.Text = textoArchivo.ReadToEnd();
            }
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
