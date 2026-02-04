using Algorithm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BubbleSort
{
    public partial class Form1 : Form
    {
        AlgorithmBase<int> algorithm = new BubbleSort<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int value))
            { 
                algorithm.Items.Add(value);
                label1.Text += value + " ";
                textBox1.Text = "";
            }
                    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            algorithm.Sort();
            label1.Text = "";
            foreach (var item in algorithm.Items)
            {
                label1.Text += item + " ";
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var rnd = new Random();
            var count = rnd.Next(4, 200);
            for (int i = 0; i < count; i++)
            {
                algorithm.Items.Add(rnd.Next(0, 99));
            }
            foreach (var item in algorithm.Items)
            {
                label1.Text += item + " ";
            }
        }
    }
}
