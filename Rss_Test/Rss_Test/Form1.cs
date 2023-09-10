using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Rss_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void adresler(string a)
        {
            listBox1.Items.Clear();
            XmlTextReader xmloku = new XmlTextReader(a);
            while (xmloku.Read())
            {
                if (xmloku.Name == "title")
                {
                    listBox1.Items.Add(xmloku.ReadString());
                }
            }
        }

        private void BtnHurriyet_Click(object sender, EventArgs e)
        {
            string adres = "http://www.hurriyet.com.tr/rss/anasayfa";
            adresler(adres);
        }

        private void BtnMilliyet_Click(object sender, EventArgs e)
        {
            string adres = "http://www.milliyet.com.tr/rss/rssNew/gundemRss.xml";
            adresler(adres);
        }

        private void BtnSabah_Click(object sender, EventArgs e)
        {
            string adres = "https://www.sabah.com.tr/rss/ekonomi.xml";
            adresler(adres);
        }
    }
}
