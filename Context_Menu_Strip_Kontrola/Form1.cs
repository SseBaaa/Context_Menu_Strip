using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Context_Menu_Strip_Kontrola
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

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void lijevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBoxdesni.Text == string.Empty)
            {
                MessageBox.Show("Ništa nije upisano", "error 404", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            textBoxlijevi.Text = textBoxdesni.Text;
            textBoxdesni.Clear();
        }

        private void desnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(textBoxlijevi.Text == string.Empty)
            {
                MessageBox.Show("Ništa nije upisano", "error 404", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            textBoxdesni.Text = textBoxlijevi.Text;
            textBoxlijevi.Clear();
        }
    }
}
