using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace WinFApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)// vanwaar komt dit? 
        {

        }

        private void button1_Click(object sender, EventArgs e)

           
        {
            var serializer = new XmlSerializer(typeof(PurchaseOrder));
            var stream = new FileStream("purchase.xml", FileMode.Open, FileAccess.Read);//

      
        }
    }
}
