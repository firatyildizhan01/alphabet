using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        enum harfler { a, b, c, d, e, f, g, h }
        private void button1_Click(object sender, EventArgs e)
        {
            harfler p;
            int k = Convert.ToInt32(textBox1.Text);
            p = (harfler)k;
            label1.Text = p.ToString();

        }
    }
}
