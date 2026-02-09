using System;
using System.Collections.Generic;

namespace Algorithm
{
    public class BubbleSort<T>:AlgorithmBase<T> where T: IComparable
    {
        public BubbleSort(IEnumerable<T> items) : base(items) { }
        public BubbleSort() { }
        protected override void MakeSort()
        {
            var count = Items.Count;
            for (int j = 0; j < count;)
            {
                for (int i = 0; i < count - 1; i++)
                {
                    var a = Items[i];
                    var b = Items[i + 1];
                    if (a.CompareTo(b)==1)
                    {
                        Swop(i, i + 1);
                    }
                    ComparisonCount++;
                }
                count--;
            }
        }
    }
}
