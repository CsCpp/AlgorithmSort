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
    public partial class BubbleSortForm : Form
    {
        AlgorithmBase<int> algorithm = new BubbleSort<int>();
        List<SortedItem> SortedItems = new List<SortedItem>();

        public BubbleSortForm()
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
                var item = new SortedItem(value, algorithm.Items.Count * 20);
                SortedItems.Add(item);
                panel1.Controls.Add(item.Label);
                panel1.Controls.Add(item.VerticalProgressBar);
            }
                    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            algorithm.Sort();
            label1.Text = "";
            int i = 0;
            foreach (var item in algorithm.Items)
            {
               
                label1.Text += item + " ";
              
                var item2 = new SortedItem(item, i * 20, 110);
                SortedItems.Add(item2);
                panel1.Controls.Add(item2.Label);
                panel1.Controls.Add(item2.VerticalProgressBar);
                i++;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var rnd = new Random();
            var count = rnd.Next(4, 200);
            for (int i = 0; i < count; i++)
            {
                var value = rnd.Next(0, 99);
                algorithm.Items.Add(value);
                var item = new SortedItem(value, i * 20);
                SortedItems.Add(item);
                panel1.Controls.Add(item.Label);
                panel1.Controls.Add(item.VerticalProgressBar);
                label1.Text += value + " ";
            }
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
