﻿
namespace ExploradorWeb
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nAVEGARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iNICIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hACIAATRÁSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hACIAADELANTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.botonir = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nAVEGARToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1295, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nAVEGARToolStripMenuItem
            // 
            this.nAVEGARToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iNICIOToolStripMenuItem,
            this.hACIAATRÁSToolStripMenuItem,
            this.hACIAADELANTEToolStripMenuItem});
            this.nAVEGARToolStripMenuItem.Name = "nAVEGARToolStripMenuItem";
            this.nAVEGARToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.nAVEGARToolStripMenuItem.Text = "Navegar";
            this.nAVEGARToolStripMenuItem.Click += new System.EventHandler(this.nAVEGARToolStripMenuItem_Click);
            // 
            // iNICIOToolStripMenuItem
            // 
            this.iNICIOToolStripMenuItem.Name = "iNICIOToolStripMenuItem";
            this.iNICIOToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.iNICIOToolStripMenuItem.Text = "INICIO";
            this.iNICIOToolStripMenuItem.Click += new System.EventHandler(this.iNICIOToolStripMenuItem_Click);
            // 
            // hACIAATRÁSToolStripMenuItem
            // 
            this.hACIAATRÁSToolStripMenuItem.Name = "hACIAATRÁSToolStripMenuItem";
            this.hACIAATRÁSToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.hACIAATRÁSToolStripMenuItem.Text = "HACIA ATRÁS";
            this.hACIAATRÁSToolStripMenuItem.Click += new System.EventHandler(this.hACIAATRÁSToolStripMenuItem_Click);
            // 
            // hACIAADELANTEToolStripMenuItem
            // 
            this.hACIAADELANTEToolStripMenuItem.Name = "hACIAADELANTEToolStripMenuItem";
            this.hACIAADELANTEToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.hACIAADELANTEToolStripMenuItem.Text = "HACIA ADELANTE";
            this.hACIAADELANTEToolStripMenuItem.Click += new System.EventHandler(this.hACIAADELANTEToolStripMenuItem_Click);
            // 
            // botonir
            // 
            this.botonir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonir.Location = new System.Drawing.Point(650, 50);
            this.botonir.Name = "botonir";
            this.botonir.Size = new System.Drawing.Size(75, 23);
            this.botonir.TabIndex = 1;
            this.botonir.Text = "Ir";
            this.botonir.UseVisualStyleBackColor = true;
            this.botonir.Click += new System.EventHandler(this.botonir_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "http://google.com",
            "http//yahoo.com",
            "http://gmail.com"});
            this.comboBox1.Location = new System.Drawing.Point(12, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(610, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 89);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1115, 561);
            this.webBrowser1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 662);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.botonir);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Explorador";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nAVEGARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iNICIOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hACIAATRÁSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hACIAADELANTEToolStripMenuItem;
        private System.Windows.Forms.Button botonir;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

