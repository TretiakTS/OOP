using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Window1 : Form
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string answer=textBox1.Text;
            if (answer =="" )
            {
                MessageBox.Show("You have not entered anything");
                return;
            }
            if (int.TryParse(answer, out int n))
            {
                MessageBox.Show("You have entered "+answer);
                return;
            }
            else
            {
                MessageBox.Show("Wrong value");
                return;
            }
        }
    }
}
