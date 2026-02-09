using Algorithm;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BubbleSort
{
    public partial class SortForm : Form
    {
        AlgorithmBase<int> algorithm;
        List<SortedItem> SortedItems = new List<SortedItem>();
        List<int> SortList = new List<int>();

        public SortForm()
        {
            InitializeComponent();
           
        }

        

        private void MySort()
        {
            algorithm.Items.AddRange(SortList);

            algorithm.CompareEvent += Algorithm_CompareEvent;
            algorithm.SwopEvent += Algorithm_SwopEvent;

            algorithm.Sort();

            //  label1.Text = "";
            int i = 0;
            foreach (var item in algorithm.Items)
            {

                // label1.Text += item + " ";

                var item2 = new SortedItem(item, i * 20, 110);
                SortedItems.Add(item2);
                // SortList.Add(item);
                panel1.Controls.Add(item2.Label);
                panel1.Controls.Add(item2.VerticalProgressBar);
                i++;
            }
            labelSwop.Text = "Swop: " + algorithm.SwopCount.ToString();
            labelComparison.Text = "Comparison: " + algorithm.ComparisonCount.ToString();
            algorithm.Clear();
        }

        private void  Algorithm_CompareEvent(object sender, Tuple<SortedItem, SortedItem> e)
        {
            var temp = e.Item1.Value;
            e.Item1.Value = e.Item2.Value;
            e.Item2.Value = temp;
        }

        private void Algorithm_SwopEvent(object sender, Tuple<int, int> e)
        {
            throw new NotImplementedException();
        }

       

        private void Swop(SortedItem a, SortedItem b)
        {
            a.SetColor(Color.Red);
            b.SetColor(Color.Green);
        }

        #region ButtonClick
        private void buttonCoctailSort_Click(object sender, EventArgs e)
        {
            algorithm = new CoctailSort<int>();
           
            MySort();
        }

        private void buttonInsertionSort_Click(object sender, EventArgs e)
        {
            algorithm = new InsertionSort<int>();
           
            MySort();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //  var bbule = new BubbleSort<SortedItem>(SortedItems);

            algorithm = new BubbleSort<int>();

            MySort();
        }
          private void buttonShellSort_Click(object sender, EventArgs e)
        {
            algorithm = new ShellSort<int>();

            MySort();
        }
        private void buttonRandom_Click(object sender, EventArgs e)
        {
            var rnd = new Random();
            var count = 20; // rnd.Next(4, 30);
            for (int i = 0; i < count; i++)
            {
                var value = rnd.Next(0, 99);
                // algorithm.Items.Add(value);
                SortList.Add(value);
                var item = new SortedItem(value, i * 20);
                SortedItems.Add(item);
                panel1.Controls.Add(item.Label);
                panel1.Controls.Add(item.VerticalProgressBar);
                label1.Text += value + " ";
            }

        }
        private void buttonAddValueLable_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int value))
            {
                // algorithm.Items.Add(value);
                label1.Text += value + " ";
                textBox1.Text = "";
                var item = new SortedItem(value, algorithm.Items.Count * 20);
                SortedItems.Add(item);
                SortList.Add(value);
                panel1.Controls.Add(item.Label);
                panel1.Controls.Add(item.VerticalProgressBar);
            }
        }
        #endregion
    }
}
