using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prakt0506
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void random(int[,] massiv)
        {
            Random rand = new Random();
            for(int i = 0; i <= massiv.GetUpperBound(0); i++)
            {
                for(int j = 0; j <= massiv.GetUpperBound(1); j++)
                {
                    massiv[i, j] = rand.Next(-30, 30);
                }    
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            zvBox.Clear();
            kekBox.Clear();
            int n = Convert.ToInt32(perviy.Text);
            int m = Convert.ToInt32(vtoroy.Text);
            int k = Convert.ToInt32(tretiy.Text);
            int[,] massiv = new int[n, m];
            random(massiv);
            for(int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    kekBox.Text += massiv[i, j] + " ";
                    if (i == k)
                    {
                        zvBox.Text += massiv[k, j] + " ";
                    }
                }
                kekBox.Text += "\n";
            }
        }

        private void perviy_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
