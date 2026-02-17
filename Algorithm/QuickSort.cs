using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class QuickSort<T> : AlgorithmBase<T> where T : IComparable
    {
        public QuickSort() { }
        public QuickSort(IEnumerable<T> items) : base(items) { }
        protected override void MakeSort()
        {
            QSort(0, Items.Count - 1);
        }
        private void QSort(int left, int right)
        {
            if (left >= right)
            {
                return;
            }
            var pivot = Sorting(left, right);
            QSort(left, pivot - 1);
            QSort(pivot + 1, right);

        }
        private int Sorting(int left, int right)
        {
            var pointer = left;
            //Опорный элемент находится в позиции Right
            for (int i = left; i <= right; i++)
            {
                if (Compare(Items[i], Items[right]) == -1)
                {
                    Swop(i, pointer);
                    pointer++;
                }
            }
            Swop(pointer, right);
            return pointer;
        }
    }
}
