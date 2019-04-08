using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DarrenLee.Translator;
using System.Net;

namespace TranslateApi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public bool ConnectionTest()
        {
            string adres = "http://www.google.com";
            try
            {
                WebRequest istek = WebRequest.Create(adres);
                WebResponse yanit = istek.GetResponse();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (ConnectionTest())
            {
                this.Text = "Bağlantı başarılı";
            }
            else
            {
                this.Text = "Bağlantı kurulamadı";
            }
        }

        bool trTOeng = true;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Türkçe";
            label3.Text = "İngilizce";
            trTOeng = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "İngilizce";
            label3.Text = "Türkçe";
            trTOeng = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (trTOeng)
            {
                richTextBox2.Text = Translator.Translate(richTextBox1.Text, "tr", "en");
            }
            else
            {
                richTextBox2.Text = Translator.Translate(richTextBox1.Text, "en", "tr");
            }

        }
        
    }
}
