using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P3_2_1204025
{
    public partial class Child_Form : Form
    {
        private string outputText = DateTime.Now.ToString("d");

        public string OutputText { get; private set; }

        public Child_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OutputLabel.Text = outputText;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            outputText = DateTime.Now.ToString("d");
        }

        private void OutputLabel_Click(object sender, EventArgs e)
        {

        }

        private void Child_Form_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            OutputText = DateTime.Now.ToString("t");
        }


    }
}
