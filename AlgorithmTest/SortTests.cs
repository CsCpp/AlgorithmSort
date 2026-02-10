using Algorithm;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmTest
{
    [TestClass]
    public class SortTests
    {
        Random rnd = new Random();
        List<int> Items = new List<int>();
        List<int> Sorted = new List<int>();
        [TestInitialize]
        public void Init()
        {
            Items.Clear();
            for (int i = 0; i < 10000; i++)
            {
                Items.Add(rnd.Next(0, 999));
            }
            Sorted.Clear();
            Sorted.AddRange(Items.OrderBy(x => x).ToArray());
        }

        [TestMethod]
        public void InsertionSortTest()
        {
            //arrange
            var insert = new InsertionSort<int>();
            insert.Items.AddRange(Items);
          
            //act
            insert.Sort();

            //assert
            for (int i = 0; i < Sorted.Count; i++)
            {
                Assert.AreEqual(Sorted[i], insert.Items[i]);

            }
        }
        [TestMethod]
        public void BubbleSortTest()
        {
            //arrange
            var bubble = new BubbleSort<int>();
            bubble.Items.AddRange(Items);

            //act
            bubble.Sort();

            //assert
            for (int i = 0; i < Sorted.Count; i++)
            {
                Assert.AreEqual(Sorted[i], bubble.Items[i]);

            }
        }
        [TestMethod]
        public void CoctailSortTest()
        {
            //arrange
            var coctail = new CoctailSort<int>();
            coctail.Items.AddRange(Items);

            //act
            coctail.Sort();

            //assert
            for (int i = 0; i < Sorted.Count; i++)
            {
                Assert.AreEqual(Sorted[i], coctail.Items[i]);

            }
        }
        [TestMethod]
        public void ShellSortTest()
        {
            //arrange
            var shell = new ShellSort<int>();
            shell.Items.AddRange(Items);

            //act
            shell.Sort();

            //assert
            for (int i = 0; i < Sorted.Count; i++)
            {
                Assert.AreEqual(Sorted[i], shell.Items[i]);

            }
        }
        [TestMethod]
        public void TreeSortTest()
        {
            //arrange
            var treeTest = new TreeSort<int>();
            treeTest.Items.AddRange(Items);

            //act
            treeTest.Sort();

            //assert
            for (int i = 0; i < Sorted.Count; i++)
            {
                Assert.AreEqual(Sorted[i], treeTest.Items[i]);

            }
        }
        [TestMethod]
        public void HeapSortTest()
        {
            //arrange
            var heapTest = new HeapSort<int>();
            heapTest.Items.AddRange(Items);

            //act
            heapTest.Sort();

            //assert
            for (int i = 0; i < Sorted.Count; i++)
            {
                Assert.AreEqual(Sorted[i], heapTest.Items[i]);

            }
        }
        [TestMethod]
        public void BaseSortTest()
        {
            //arrange
            var baseSort = new AlgorithmBase<int>();
            baseSort.Items.AddRange(Items);

            //act
            baseSort.Sort();

            //assert
            for (int i = 0; i < Sorted.Count; i++)
            {
                Assert.AreEqual(Sorted[i], baseSort.Items[i]);

            }
        }
    }
}
