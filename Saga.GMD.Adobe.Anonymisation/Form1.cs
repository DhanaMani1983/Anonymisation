using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Saga.GMD.Adobe.Anonymisation.BLL;
using Saga.GMD.Adobe.Anonymisation.Data;

namespace Saga.GMD.Adobe.Anonymisation.Utility
{
    public partial class Form1 : Form
    {
        AdobeAnonymisation _AdobeAnonymisation = new AdobeAnonymisation();
        PersIDData _PersIDData = new PersIDData();
        bool submitRequest = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (submitRequest)
            {
                richTextBox1.Text = _PersIDData.GetObfuscatedDetails(textBox1.Text);
                richTextBox2.Text = _PersIDData.GetDeAnonymisedData(textBox1.Text);
            }
            else
            {
                richTextBox1.Text = richTextBox2.Text = "Unable to submit request - no valid Pers ID has been supplied";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!_AdobeAnonymisation.CheckPersID(textBox1.Text))
            {
                richTextBox1.Text = richTextBox2.Text = "Not a valid Adobe Pers ID";
                submitRequest = false;
            }
            else
            {
                submitRequest = true;
            }

        }
    }
}
