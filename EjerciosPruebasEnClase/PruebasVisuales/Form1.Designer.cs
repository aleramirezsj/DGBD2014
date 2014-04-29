namespace PruebasVisuales
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.principalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargaDeAlumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargaDeMateriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargaDeCarrerasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiaDeSeguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parámetrosDelSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.impresiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeAlumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeMateriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeCarrerasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirDelSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTest = new System.Windows.Forms.Button();
            this.abrirArchivoDeTextoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rtbTextoDocumento = new System.Windows.Forms.RichTextBox();
            this.ofdAbrirArchivo = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.principalToolStripMenuItem,
            this.mantenimientoToolStripMenuItem,
            this.impresiónToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(437, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // principalToolStripMenuItem
            // 
            this.principalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargaDeAlumnosToolStripMenuItem,
            this.cargaDeMateriasToolStripMenuItem,
            this.cargaDeCarrerasToolStripMenuItem,
            this.abrirArchivoDeTextoToolStripMenuItem});
            this.principalToolStripMenuItem.Name = "principalToolStripMenuItem";
            this.principalToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.principalToolStripMenuItem.Text = "Principal";
            // 
            // cargaDeAlumnosToolStripMenuItem
            // 
            this.cargaDeAlumnosToolStripMenuItem.Name = "cargaDeAlumnosToolStripMenuItem";
            this.cargaDeAlumnosToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.cargaDeAlumnosToolStripMenuItem.Text = "Carga de alumnos";
            // 
            // cargaDeMateriasToolStripMenuItem
            // 
            this.cargaDeMateriasToolStripMenuItem.Name = "cargaDeMateriasToolStripMenuItem";
            this.cargaDeMateriasToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.cargaDeMateriasToolStripMenuItem.Text = "Carga de materias";
            // 
            // cargaDeCarrerasToolStripMenuItem
            // 
            this.cargaDeCarrerasToolStripMenuItem.Name = "cargaDeCarrerasToolStripMenuItem";
            this.cargaDeCarrerasToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.cargaDeCarrerasToolStripMenuItem.Text = "Carga de carreras";
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copiaDeSeguridadToolStripMenuItem,
            this.parámetrosDelSistemaToolStripMenuItem});
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // copiaDeSeguridadToolStripMenuItem
            // 
            this.copiaDeSeguridadToolStripMenuItem.Name = "copiaDeSeguridadToolStripMenuItem";
            this.copiaDeSeguridadToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.copiaDeSeguridadToolStripMenuItem.Text = "Copia de seguridad";
            // 
            // parámetrosDelSistemaToolStripMenuItem
            // 
            this.parámetrosDelSistemaToolStripMenuItem.Name = "parámetrosDelSistemaToolStripMenuItem";
            this.parámetrosDelSistemaToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.parámetrosDelSistemaToolStripMenuItem.Text = "Parámetros del sistema";
            // 
            // impresiónToolStripMenuItem
            // 
            this.impresiónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDeAlumnosToolStripMenuItem,
            this.listadoDeMateriasToolStripMenuItem,
            this.listadoDeCarrerasToolStripMenuItem});
            this.impresiónToolStripMenuItem.Name = "impresiónToolStripMenuItem";
            this.impresiónToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.impresiónToolStripMenuItem.Text = "Impresión";
            // 
            // listadoDeAlumnosToolStripMenuItem
            // 
            this.listadoDeAlumnosToolStripMenuItem.Name = "listadoDeAlumnosToolStripMenuItem";
            this.listadoDeAlumnosToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.listadoDeAlumnosToolStripMenuItem.Text = "Listado de alumnos";
            // 
            // listadoDeMateriasToolStripMenuItem
            // 
            this.listadoDeMateriasToolStripMenuItem.Name = "listadoDeMateriasToolStripMenuItem";
            this.listadoDeMateriasToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.listadoDeMateriasToolStripMenuItem.Text = "Listado de materias";
            // 
            // listadoDeCarrerasToolStripMenuItem
            // 
            this.listadoDeCarrerasToolStripMenuItem.Name = "listadoDeCarrerasToolStripMenuItem";
            this.listadoDeCarrerasToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.listadoDeCarrerasToolStripMenuItem.Text = "Listado de carreras";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirDelSistemaToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // salirDelSistemaToolStripMenuItem
            // 
            this.salirDelSistemaToolStripMenuItem.Name = "salirDelSistemaToolStripMenuItem";
            this.salirDelSistemaToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.salirDelSistemaToolStripMenuItem.Text = "Salir del sistema";
            this.salirDelSistemaToolStripMenuItem.Click += new System.EventHandler(this.salirDelSistemaToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(290, 0);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(127, 24);
            this.btnTest.TabIndex = 1;
            this.btnTest.Text = "Test de alcoholemia";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            this.btnTest.MouseEnter += new System.EventHandler(this.btnTest_MouseEnter);
            // 
            // abrirArchivoDeTextoToolStripMenuItem
            // 
            this.abrirArchivoDeTextoToolStripMenuItem.Name = "abrirArchivoDeTextoToolStripMenuItem";
            this.abrirArchivoDeTextoToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.abrirArchivoDeTextoToolStripMenuItem.Text = "Abrir archivo de texto";
            this.abrirArchivoDeTextoToolStripMenuItem.Click += new System.EventHandler(this.abrirArchivoDeTextoToolStripMenuItem_Click);
            // 
            // rtbTextoDocumento
            // 
            this.rtbTextoDocumento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbTextoDocumento.Location = new System.Drawing.Point(0, 24);
            this.rtbTextoDocumento.Name = "rtbTextoDocumento";
            this.rtbTextoDocumento.Size = new System.Drawing.Size(437, 249);
            this.rtbTextoDocumento.TabIndex = 2;
            this.rtbTextoDocumento.Text = "";
            // 
            // ofdAbrirArchivo
            // 
            this.ofdAbrirArchivo.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(437, 273);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.rtbTextoDocumento);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Sistema de Alumnos ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem principalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargaDeAlumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargaDeMateriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargaDeCarrerasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiaDeSeguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parámetrosDelSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem impresiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeAlumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeMateriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeCarrerasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirDelSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.ToolStripMenuItem abrirArchivoDeTextoToolStripMenuItem;
        private System.Windows.Forms.RichTextBox rtbTextoDocumento;
        private System.Windows.Forms.OpenFileDialog ofdAbrirArchivo;
    }
}

