namespace BubbleSort
{
    partial class SortForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelSwop = new System.Windows.Forms.Label();
            this.labelComparison = new System.Windows.Forms.Label();
            this.buttonCoctailSort = new System.Windows.Forms.Button();
            this.buttonInsertionSort = new System.Windows.Forms.Button();
            this.buttonShellSort = new System.Windows.Forms.Button();
            this.buttonTreeSort = new System.Windows.Forms.Button();
            this.buttonGnomeSort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonAddValueLable_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(86, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "BubbleSort";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 39);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Random";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonRandom_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(8, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 242);
            this.panel1.TabIndex = 8;
            // 
            // labelSwop
            // 
            this.labelSwop.AutoSize = true;
            this.labelSwop.Location = new System.Drawing.Point(501, 78);
            this.labelSwop.Name = "labelSwop";
            this.labelSwop.Size = new System.Drawing.Size(46, 13);
            this.labelSwop.TabIndex = 9;
            this.labelSwop.Text = "Swop: 0";
            // 
            // labelComparison
            // 
            this.labelComparison.AutoSize = true;
            this.labelComparison.Location = new System.Drawing.Point(570, 78);
            this.labelComparison.Name = "labelComparison";
            this.labelComparison.Size = new System.Drawing.Size(74, 13);
            this.labelComparison.TabIndex = 10;
            this.labelComparison.Text = "Comparison: 0";
            // 
            // buttonCoctailSort
            // 
            this.buttonCoctailSort.Location = new System.Drawing.Point(105, 68);
            this.buttonCoctailSort.Name = "buttonCoctailSort";
            this.buttonCoctailSort.Size = new System.Drawing.Size(86, 23);
            this.buttonCoctailSort.TabIndex = 11;
            this.buttonCoctailSort.Text = "CoctailSort";
            this.buttonCoctailSort.UseVisualStyleBackColor = true;
            this.buttonCoctailSort.Click += new System.EventHandler(this.buttonCoctailSort_Click);
            // 
            // buttonInsertionSort
            // 
            this.buttonInsertionSort.Location = new System.Drawing.Point(197, 68);
            this.buttonInsertionSort.Name = "buttonInsertionSort";
            this.buttonInsertionSort.Size = new System.Drawing.Size(86, 23);
            this.buttonInsertionSort.TabIndex = 12;
            this.buttonInsertionSort.Text = "InsertSort";
            this.buttonInsertionSort.UseVisualStyleBackColor = true;
            this.buttonInsertionSort.Click += new System.EventHandler(this.buttonInsertionSort_Click);
            // 
            // buttonShellSort
            // 
            this.buttonShellSort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonShellSort.Location = new System.Drawing.Point(289, 68);
            this.buttonShellSort.Name = "buttonShellSort";
            this.buttonShellSort.Size = new System.Drawing.Size(86, 23);
            this.buttonShellSort.TabIndex = 13;
            this.buttonShellSort.Text = "ShellSort";
            this.buttonShellSort.UseVisualStyleBackColor = true;
            this.buttonShellSort.Click += new System.EventHandler(this.buttonShellSort_Click);
            // 
            // buttonTreeSort
            // 
            this.buttonTreeSort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTreeSort.Location = new System.Drawing.Point(381, 68);
            this.buttonTreeSort.Name = "buttonTreeSort";
            this.buttonTreeSort.Size = new System.Drawing.Size(86, 23);
            this.buttonTreeSort.TabIndex = 14;
            this.buttonTreeSort.Text = "TreeSort";
            this.buttonTreeSort.UseVisualStyleBackColor = true;
            this.buttonTreeSort.Click += new System.EventHandler(this.buttonTreeSort_Click);
            // 
            // buttonGnomeSort
            // 
            this.buttonGnomeSort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGnomeSort.Location = new System.Drawing.Point(381, 39);
            this.buttonGnomeSort.Name = "buttonGnomeSort";
            this.buttonGnomeSort.Size = new System.Drawing.Size(86, 23);
            this.buttonGnomeSort.TabIndex = 15;
            this.buttonGnomeSort.Text = "GnomeSort";
            this.buttonGnomeSort.UseVisualStyleBackColor = true;
            this.buttonGnomeSort.Click += new System.EventHandler(this.buttonGnomeSort_Click);
            // 
            // SortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 343);
            this.Controls.Add(this.buttonGnomeSort);
            this.Controls.Add(this.buttonTreeSort);
            this.Controls.Add(this.buttonShellSort);
            this.Controls.Add(this.buttonInsertionSort);
            this.Controls.Add(this.buttonCoctailSort);
            this.Controls.Add(this.labelComparison);
            this.Controls.Add(this.labelSwop);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "SortForm";
            this.Text = "Sort";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelSwop;
        private System.Windows.Forms.Label labelComparison;
        private System.Windows.Forms.Button buttonCoctailSort;
        private System.Windows.Forms.Button buttonInsertionSort;
        private System.Windows.Forms.Button buttonShellSort;
        private System.Windows.Forms.Button buttonTreeSort;
        private System.Windows.Forms.Button buttonGnomeSort;
    }
}

