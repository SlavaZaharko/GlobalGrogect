using NUnit.Framework;
using GlobalProgect_1;
using GlobalProgect_1.LinkedLists;
using GlobalProgect_1.DoubleLinkedLists;

namespace ListTest
{
    [TestFixture(1)]
    [TestFixture(2)]
    [TestFixture(3)]
    public class ListTest
    {
        IList list;
        int q;

        public ListTest(int _q)
        {
            q = _q;
        }

        [SetUp]
        public void ListSelect()
        {
            switch (q)
            {
                case 1:
                    list = new ArrayList();
                    break;
                case 2:
                    list = new LinkedList();
                    break;
                case 3:
                    list = new DoubleLinkedList();
                    break;

            }
        }

        [TestCase(new int[] { 1, 2, 3 }, 4, ExpectedResult = new int[] { 1, 2, 3, 4 })]
        public int[] AddTest(int[] array, int a)
        {
            list.Add(array);
            list.Add(a);
            return list.ReturnArray();
        }

        [TestCase(new int[] { 1, 2, 3 }, new int[] { 5, 6, 7 }, ExpectedResult = new int[] { 1, 2, 3, 5, 6, 7 })]
        public int[] AddTest(int[] array, int[] a)
        {
            list.Add(array);
            list.Add(a);
            return list.ReturnArray();
        }



        [TestCase(new int[] { 1, 2, 3 }, 0, ExpectedResult = new int[] { 0, 1, 2, 3 })]
        public int[] AddFirstTest(int[] array, int a)
        {
            list.Add(array);
            list.AddFirst(a);
            return list.ReturnArray();
        }


        [TestCase(new int[] { 1, 2, 3 }, new int[] { -3, -2, -1, 0 }, ExpectedResult = new int[] { -3, -2, -1, 0, 1, 2, 3 })]
        public int[] AddFirstTest(int[] array, int[] a)
        {
            list.Add(array);
            list.AddFirst(a);
            return list.ReturnArray();
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, 2, 5, ExpectedResult = new int[] { 1, 2, 5, 3, 4 })]
        public int[] AddIndexTest(int[] array, int a, int b)
        {
            list.Add(array);
            list.AddIndex(a, b);
            return list.ReturnArray();
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, 2, new int[] { 5, 6 }, ExpectedResult = new int[] { 1, 2, 5, 6, 3, 4 })]
        public int[] AddIndexTest(int[] array, int a, int[] b)
        {
            list.Add(array);
            list.AddIndex(a, b);
            return list.ReturnArray();
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, ExpectedResult = new int[] { 1, 2, 3 })]
        public int[] DelFromEndTest(int[] array)
        {
            list.Add(array);
            list.DelFromEnd();
            return list.ReturnArray();
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, ExpectedResult = new int[] { 2, 3, 4 })]
        public int[] DelFromBegindTest(int[] array)
        {
            list.Add(array);
            list.DelFromBegin();
            return list.ReturnArray();
        }

        [TestCase(new int[] { 1, 2, 3, 4,5, 6, 7 }, 2, ExpectedResult = new int[] { 1, 2, 4, 5, 6, 7 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 5, ExpectedResult = new int[] { 1, 2, 3, 4, 5, 7 })]
        public int[] DelByIndexTest(int[] array, int a)
        {
            list.Add(array);
            list.DelByIndex(a);
            return list.ReturnArray();
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, 2, ExpectedResult = 3)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 7, 1 }, 2, ExpectedResult = 3)]
        public int AccessIndexTest(int[] array, int a)
        {
            list.Add(array);
            return list.AccessIndex(a);
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, 1, ExpectedResult = 0)]
        [TestCase(new int[] { 1, 2, 3, 4 }, 2, ExpectedResult = 1)]
        [TestCase(new int[] { 1, 2, 3, 4 }, 5, ExpectedResult = -1)]
        public int AccessByValueTest(int[] array, int a)
        {
            list.Add(array);
            return list.AccessByValue(a);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 2, 8, ExpectedResult = new int[] { 1, 2, 8, 4, 5 })]
        public int[] ChangesByIndexTest(int[] array, int a, int b)
        {
            list.Add(array);
            list.ChangesByIndex(a, b);
            return list.ReturnArray();
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, ExpectedResult = 4)]
        public int SearchMaxElemTest(int[] array)
        {
            list.Add(array);
            return list.SearchMaxElem();
        }

        [TestCase(new int[] { 51, 20, 33, 14 }, ExpectedResult = 14)]
        public int SearchMinElemTest(int[] array)
        {
            list.Add(array);
            return list.SearchMinElem();
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, ExpectedResult = 3)]
        public int SearchIndexMaxElemTest(int[] array)
        {
            list.Add(array);
            return list.SearchIndexMaxElem();
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, ExpectedResult = 0)]
        public int SearchIndexMinElemTest(int[] array)
        {
            list.Add(array);
            return list.SearchIndexMinElem();
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 }, ExpectedResult = new int[] { 5, 4, 3, 2, 1 })]
        [TestCase(new int[] { 1, 2, 3, 4 }, ExpectedResult = new int[] { 4, 3, 2, 1 })]
        public int[] RevMassiveTest(int[] array)
        {
            list.Add(array);
            list.RevMassive();
            return list.ReturnArray();
        }

        [TestCase(new int[] { 12, 9, -3, 14, -15 }, ExpectedResult = new int[] { -15, -3, 9, 12, 14 })]
        public int[] SortAscendElemTest(int[] array)
        {
            list.Add(array);
            list.SortAscendElem();
            return list.ReturnArray();
        }

        [TestCase(new int[] { 10, 8, -4, -1, 5 }, ExpectedResult = 5)]
        [TestCase(new int[] { 10 }, ExpectedResult = 1)]
        [TestCase(new int[] { }, ExpectedResult = 0)]
        public int ReturnLengthMassivaTest(int[] array)
        {
            list.Add(array);
            return list.ReturnLengthMassiva();
        }

        [TestCase(new int[] { 10, 12, 15, 18, 13 }, 2, ExpectedResult = new int[] { 10, 12, 15 })]

        public int[] DelFromEndNElemTest(int[] array, int n)
        {
            list.Add(array);
            list.DelFromEndNElem(n);
            return list.ReturnArray();
        }

        [TestCase(new int[] { 10, 12, 15, 18, 13 }, 2, ExpectedResult = new int[] { 15, 18, 13 })]
        public int[] DelFromBeginNElemTest(int[] array, int n)
        {
            list.Add(array);
            list.DelFromBeginNElem(n);
            return list.ReturnArray();
        }

        [TestCase(new int[] { 2, 3, 12, 3, -1, 0 }, 3, ExpectedResult = new int[] { 2, 12, -1, 0 })]
        public int[] DeleteByValueTest(int[] array, int a)
        {
            list.Add(array);
            list.DeleteByValue(a);
            return list.ReturnArray();
        }

        [TestCase(new int[] { 10, 12, 15, 18, 13, 12 }, 2, 2, ExpectedResult = new int[] { 10, 12, 13, 12 })]
        [TestCase(new int[] { 2, 4, 8, 5, -1, 0 }, 3, 1, ExpectedResult = new int[] { 2, 4, 8, -1, 0 })]
        public int[] DelByIndexNElemTest(int[] array, int a, int n)
        {
            ArrayList actual = new ArrayList(array);
            actual.DelByIndexNElem(a, n);
            return actual.ReturnArray();
        }

        [TestCase(new int[] { 2, 4, 12, 9, -1, 0 }, ExpectedResult = new int[] { 12, 9, 4, 2, 0, -1 })]
        public int[] AscendingDescendingTest(int[] array)
        {
            ArrayList actual = new ArrayList(array);
            actual.AscendingDescending();
            return actual.ReturnArray();
        }
    }
}