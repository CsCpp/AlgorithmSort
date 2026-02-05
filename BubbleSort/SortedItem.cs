using System;
using System.Windows.Forms;

namespace BubbleSort
{
    public class SortedItem 
    {
       public VerticalProgressBar VerticalProgressBar { get; private set; }
        public Label Label { get; private set; }
        public int Value { get; set; }

        public SortedItem(int value, int x, int y = 0)
        {
            Value = value;
            VerticalProgressBar = new VerticalProgressBar();
            Label = new Label();


            // 
            // verticalProgressBar1
            // 
            VerticalProgressBar.Location = new System.Drawing.Point(7 + x, 6 + y);
            VerticalProgressBar.Name = "verticalProgressBar" + Value;
            VerticalProgressBar.Size = new System.Drawing.Size(15, 88);
            VerticalProgressBar.Step = 1;
            VerticalProgressBar.TabIndex = 5;
            VerticalProgressBar.Value = Value;
            // 
            // label2
            // 
            Label.AutoSize = true;
            Label.Location = new System.Drawing.Point(3 + x, 98 + y);
            Label.Name = "";
            Label.Size = new System.Drawing.Size(25, 13);
            Label.TabIndex = 6;
            Label.Text = Value.ToString();

           
        }
            
        }
}
