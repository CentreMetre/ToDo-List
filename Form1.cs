using System;
using System.Drawing;
using System.IO;
using System.Security;
using System.Windows.Forms;

namespace ToDo_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog(); //Shows the open folder dialog window

        }
    }
}