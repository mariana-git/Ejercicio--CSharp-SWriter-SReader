using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace sRsW_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnEscribir.Visible = false;
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            StreamReader sr = new StreamReader(".\\chistes.txt");
            string linea = sr.ReadToEnd();
            richTextBox1.AppendText(linea);
            sr.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            btnEscribir.Visible = true;
            btnAgregar.Visible = false;
            btnLeer.Visible = false;
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(".\\chistes.txt", true);
            sw.WriteLine(richTextBox1.Text);
            sw.Close();

            richTextBox1.Clear();
            btnEscribir.Visible = false;
            btnAgregar.Visible = true;
            btnLeer.Visible = true;

            MessageBox.Show("El chiste fue agregado a la colección!", "GRACIAS");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
    }
}
