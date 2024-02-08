using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExploradorWeb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            webBrowser1.GoHome();

        }

        private void botonir_Click(object sender, EventArgs e)
        {

            string direccion = comboBox1.Text.Trim();
            if (!direccion.StartsWith("http://") && !direccion.StartsWith("https://"))
            {
                
                if (!direccion.Contains("."))
                {
                   
                    direccion = "https://www.google.com/search?q=" + Uri.EscapeDataString(direccion);
                }
                else
                {
                    
                    direccion = "https://" + direccion;
                }
            }
            webBrowser1.Navigate(new Uri(direccion));
        }

        private void nAVEGARToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void iNICIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();

        }

        private void hACIAATRÁSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();

        }

        private void hACIAADELANTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
