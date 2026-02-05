using System;
using System.Collections.Generic;

namespace Algorithm
{
    public class AlgorithmBase<T> where T: System.IComparable
    {
        public int SwopCount { get; protected set; } = 0;
        public int ComparisonCount { get; protected set; } = 0;

        public List<T> Items { get; set; } = new List<T>();
        protected void Swop(int positionA, int positionB)
        {
            if (positionA < Items.Count && positionB < Items.Count)
            {
                var temp = Items[positionA];
                Items[positionA] = Items[positionB];
                Items[positionB] = temp;
                SwopCount++;
            }
        }
   
        public virtual void Sort()
        {
            SwopCount = 0;
            Items.Sort();
        }
    }
}
