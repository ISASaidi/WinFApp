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

        private void button2_Click(object sender, EventArgs e)
        {
            // dit is om weg te schrijven, maar waar en hoe moet dit?

            /*var outputstream = new FileStream("result.xml", FileMode.CreateNew, FileAccess.Write);
            serializer.Serialize(outputstream, purchaseorder);
            */
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            PurchaseOrder po = new PurchaseOrder();
            po.Items
        }


        // ik moet ook linq gebruiken, maar dat hebben we gezien met sql en niet xml toch? via de .CreateCommand().
        // via xml weet ik niet hoe het moet.
    }
}
