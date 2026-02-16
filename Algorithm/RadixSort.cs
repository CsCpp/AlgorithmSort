using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    // только целые числа :(
    public class RadixSort<T> : AlgorithmBase<T> where T : IComparable
    {
        public RadixSort() { }  
        public RadixSort(IEnumerable<T> items) : base(items) { }
        protected override void MakeSort()
        {
            var groups = new List<List<T>>();
            for (int i = 0; i < 10; i++)
            {
                groups.Add(new List<T>());
            }
            var length = GetMaxLength();
           // var items = Items.Select(i => i.Value);
            for (int step = 0; step < length; step ++)
            {
                // Распределение элементов по корзинам
                foreach (var item in Items)
                {
                    var i = item.GetHashCode();
                    var value = i % (int)Math.Pow(10, step + 1) / (int)Math.Pow(10, step);
                    groups[value].Add(item);
                }
                Items.Clear();
                //Сборка элементов
                foreach (var group in groups)
                {
                    foreach (var item in group)
                    {
                        Items.Add(item);
                    }
                }
                //Очистка корзин
                foreach (var group in groups)
                {
                    group.Clear();
                }

            }
        }

        private int GetMaxLength()
        {
            var length = 0;
            foreach (var item in Items)
            {
                if (item.GetHashCode() < 0)
                {
                    throw new ArgumentException("Поразрядная сортировка поддерживает только целые числа", nameof(Items));
                }
                // var l = Convert.ToInt32(Math.Log10(item.GetHashCode()) + 1); // не работает со значением item = 0; //  - inf.
                var l = item.GetHashCode().ToString().Length; // быдлокод
                if (l > length)
                {
                    length = l;
                }
            }
            return length;
        }
    }
}
