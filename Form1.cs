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

namespace ExploradorWeb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Resize += new System.EventHandler(this.Form_Resize);
            webView21.NavigationStarting += EnsureHttps;
            InitializeAsync();
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
            

        }

        private void botonir_Click(object sender, EventArgs e)
        {

            string direccion = comboBox1.Text.Trim();

            if (webView21 != null && webView21.CoreWebView2 != null)
            {
                
                if (!direccion.Contains("."))
                {

                    direccion = "https://www.google.com/search?q=" + Uri.EscapeDataString(direccion);
                    webView21.CoreWebView2.Navigate(direccion);
                }

                webView21.CoreWebView2.Navigate(direccion);
            }
                

               


            
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
    }
}
