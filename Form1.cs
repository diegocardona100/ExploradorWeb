using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;
using System.IO;


namespace ExploradorWeb
{
    public partial class Form1 : Form
    {

        private List<URL> historial = new List<URL>();
        public Form1()
        {
            InitializeComponent();
            this.Resize += new System.EventHandler(this.Form_Resize);
            webView21.NavigationStarting += EnsureHttps;
            InitializeAsync();
        }

        private void Guardar(string fileName, string texto)
        {
            //Abrir el archivo: Write sobreescribe el archivo, Append agrega los datos al final del archivo
            FileStream stream = new FileStream(fileName, FileMode.Append, FileAccess.Write);
            //Crear un objeto para escribir el archivo
            StreamWriter writer = new StreamWriter(stream);
            //Usar el objeto para escribir al archivo, WriteLine, escribe linea por linea
            //Write escribe todo en la misma linea. En este ejemplo se hará un dato por cada línea
            writer.WriteLine(texto);
            //Cerrar el archivo
            writer.Close();
        }

        async void InitializeAsync()
        {
            await webView21.EnsureCoreWebView2Async(null);
        }

        void EnsureHttps(object sender, CoreWebView2NavigationStartingEventArgs args)
        {
            String uri = args.Uri;
            if (!uri.StartsWith("https://"))
            {
                webView21.CoreWebView2.ExecuteScriptAsync($"alert('{uri} is not safe, try an https link')");
                args.Cancel = true;
            }
        }

        private void Form_Resize(object sender, EventArgs e)
        {
            webView21.Size = this.ClientSize - new System.Drawing.Size(webView21.Location);
            botonir.Left = this.ClientSize.Width - botonir.Width;
            comboBox1.Width = botonir.Left - comboBox1.Left;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            read();



        }

        

        private void AgregarURL(string direccion)
        {
            // Busca si la URL ya existe en el historial
            URL urlExistente = historial.FirstOrDefault(u => u.Pagina == direccion);

            if (urlExistente != null)
            {
                // Si existe, actualiza su contador y fecha de acceso
                urlExistente.Veces++;
                urlExistente.Fecha= DateTime.Now;
            }
            else
            {
                // Si no existe, la agrega al historial
                historial.Add(new URL
                {
                    Pagina = direccion,
                    Veces = 1,
                    Fecha = DateTime.Now
                });
            }
        }


        private void GuardarHistorial()
        {
            // Ordena el historial por fecha de último acceso (más reciente primero)
            historial = historial.OrderByDescending(u => u.Fecha).ToList();

            // Escribe el historial en el archivo de texto
            using (StreamWriter writer = new StreamWriter(@"C:\Users\Diego Cardona\source\repos\ExploradorWeb\H\historial.txt"))
            {
                foreach (URL url in historial)
                {
                    writer.WriteLine($"{url.Pagina},{url.Veces},{url.Fecha}");
                }
            }
        }

       

        private void CargarHistorial()
        {
            historial.Clear();


            // Lee el historial
            using (StreamReader reader = new StreamReader(@"C:\Users\Diego Cardona\source\repos\ExploradorWeb\H\historial.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('\t');
                    historial.Add(new URL
                    {
                        Pagina = parts[0],
                        Veces = int.Parse(parts[1]),
                        Fecha = DateTime.Parse(parts[2])
                    });
                }
            }

        }
        /*
            private void OrdenarPorVecesAccedida()
        {
            historial = historial.OrderByDescending(u => u.Veces).ToList();
            // Guardar historial después de ordenarlo
            GuardarHistorial();
        }
        */

        /*
        private void OrdenarPorFechaAcceso()
        {
            historial = historial.OrderByDescending(u => u.Fecha).ToList();
            // Guardar historial después de ordenarlo
            GuardarHistorial();
        }
        */
        private void botonir_Click(object sender, EventArgs e)
        {
            string direccion = comboBox1.Text.Trim();

            if (webView21 != null && webView21.CoreWebView2 != null)
            {
                if (!direccion.Contains("."))
                {
                    direccion = "https://www.google.com/search?q=" + Uri.EscapeDataString(direccion);
                }

                webView21.CoreWebView2.Navigate(direccion);
                AgregarURL(direccion); // Agrega la URL al historial
                GuardarHistorial(); // Guarda el historial actualizado en el archivo de texto
            }
        }

        private void read()
        {
            FileStream stream = new FileStream(@"C:\Users\Diego Cardona\source\repos\ExploradorWeb\H\historial.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            //Un ciclo para leer el archivo hasta el final del archivo
            //Lo leído se va guardando en un control richTextBox
            while (reader.Peek() > 1)
            //Esta linea envía el texto leído a un control richTextBox, se puede cambiar para que
            //lo muestre en otro control por ejemplo un combobox
            {
                comboBox1.Items.Add(reader.ReadLine());


            }
            //Cerrar el archivo, esta linea es importante porque sino despues de correr varias veces el programa daría error de que el archivo quedó abierto muchas veces. Entonces es necesario cerrarlo despues de terminar de leerlo.
            reader.Close();

        }




        private void nAVEGARToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void iNICIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //webBrowser1.GoHome();

        }

        private void hACIAATRÁSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //webBrowser1.GoBack();

        }

        private void hACIAADELANTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //webBrowser1.GoForward();

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void webView21_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                historial = historial.OrderByDescending(u => u.Veces).ToList();
                // Guardar historial después de ordenarlo
                GuardarHistorial();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
                historial = historial.OrderByDescending(u => u.Fecha).ToList();
                GuardarHistorial();
            

        }
    }


}
