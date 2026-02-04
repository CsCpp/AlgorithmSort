using Algorithm;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace AlgorithmTest
{
    [TestClass]
    public class UnitBubbleSortTest
    {
        [TestMethod]
        public void SortTest()
        {
            //arrange
            var bubble = new BubbleSort<int>();
            var rnd = new Random();
            var items = new List<int>();
            for (int i = 0; i < 1000; i++)
            {
               items.Add(rnd.Next(0, 999));
            }
            bubble.Items.AddRange(items);
            items.Sort();
            //act
            bubble.Sort();
            //assert
            for (int i = 0; i < items.Count; i++)
            {
                Assert.AreEqual(items[i], bubble.Items[i]);

            }

        }
    }
}
