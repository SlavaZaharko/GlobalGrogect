using NUnit.Framework;
using GlobalProgect_1;
namespace ArrayListTest
{
    public class Tests
    {

        [TestCase(new int[] {1,2,3,4}, 0, ExpectedResult = new int[] {1,2,3,4,0})]
        public int [] AddTest(int [] array, int a)
        {
            ArrayList actual = new ArrayList(array);
            actual.Add(a);
            return actual.ReturnArray();
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] {5, 6, 7}, ExpectedResult = new int[] { 1, 2, 3, 4, 5, 6, 7 })]
        public int[] AddTest(int[] array, int [] a)
        {
            ArrayList actual = new ArrayList(array);
            actual.Add(a);
            return actual.ReturnArray();
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, 0, ExpectedResult = new int[] {0, 1, 2, 3, 4})]
        public int[] AddFirstTest(int[] array, int a)
        {
            ArrayList actual = new ArrayList(array);
            actual.AddFirst(a);
            return actual.ReturnArray();
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 5, 6, 7 }, ExpectedResult = new int[] { 5, 6, 7, 1, 2, 3, 4})]
        public int[] AddFirstTest(int[] array, int[] a)
        {
            ArrayList actual = new ArrayList(array);
            actual.AddFirst(a);
            return actual.ReturnArray();
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, 2, 5, ExpectedResult = new int[] {1, 2, 5, 3, 4 })]
        public int[] AddIndexTest(int[] array, int a, int b)
        {
            ArrayList actual = new ArrayList(array);
            actual.AddIndex(a, b);
            return actual.ReturnArray();
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, 2, new int[] {5,6}, ExpectedResult = new int[] { 1, 2, 5, 6, 3, 4 })]
        public int[] AddIndexTest(int[] array, int a, int [] b)
        {
            ArrayList actual = new ArrayList(array);
            actual.AddIndex(a, b);
            return actual.ReturnArray();
        }


        [TestCase(new int[] { 1, 2, 3, 4 },  ExpectedResult = new int[] { 1, 2, 3 })]
        public int[] DelFromEndTest(int[] array)
        {
            ArrayList actual = new ArrayList(array);
            actual.DelFromEnd();
            return actual.ReturnArray();
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, ExpectedResult = new int[] { 2, 3, 4 })]
        public int[] DelFromBegindTest(int[] array)
        {
            ArrayList actual = new ArrayList(array);
            actual.DelFromBegin();
            return actual.ReturnArray();
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, 2, ExpectedResult = new int[] { 1, 2, 4 })]
        public int[] DelByIndexTest(int[] array, int a)
        {
            ArrayList actual = new ArrayList(array);
            actual.DelByIndex(a);
            return actual.ReturnArray();
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, 2, ExpectedResult = 3)]
        public int AccessIndexTest(int[] array, int a)
        {
            ArrayList actual = new ArrayList(array);
            return actual.AccessIndex(a);
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, 2, ExpectedResult = 1)]
        public int AccessByValueTest(int[] array, int a)
        {
            ArrayList actual = new ArrayList(array);
            return actual.AccessByValue(a);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 2,8, ExpectedResult = new int[] { 1, 2, 8, 4, 5 })]
        public int[] ChangesByIndexTest(int[] array, int a, int b)
        {
            ArrayList actual = new ArrayList(array);
            actual.ChangesByIndex(a, b);
            return actual.ReturnArray();
        }


        [TestCase(new int[] { 1, 2, 3, 4, 5 }, ExpectedResult = new int[] { 5, 4, 3, 2, 1 })]
        [TestCase(new int[] { 1, 2, 3, 4 }, ExpectedResult = new int[] { 4, 3, 2, 1 })]
        public int[] RevMassiveTest(int[] array)
        {
            ArrayList actual = new ArrayList(array);
            actual.RevMassive();
            return actual.ReturnArray();
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, ExpectedResult = 4)]
        public int SearchMaxElemTest(int[] array)
        {
            ArrayList actual = new ArrayList(array);
            return actual.SearchMaxElem();
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, ExpectedResult = 1)]
        public int SearchMinElemTest(int[] array)
        {
            ArrayList actual = new ArrayList(array);
            return actual.SearchMinElem();
        }

        [TestCase(new int[] { 1, 2, 3, 4 }, ExpectedResult = 3)]
        public int SearchIndexMaxElemTest(int[] array)
        {
            ArrayList actual = new ArrayList(array);
            return actual.SearchIndexMaxElem();
        }

        [TestCase(new int[] { 10, 8, -4, -1,5 }, ExpectedResult = 2)]
        public int SearchIndexMinElemTest(int[] array)
        {
            ArrayList actual = new ArrayList(array);
            return actual.SearchIndexMinElem();
        }

        [TestCase(new int[] { 12, 9, -3, 14, -15 }, ExpectedResult = new int[] { -15, -3, 9, 12, 14 })]
        public int[] SortAscendElemTest(int[] array)
        {
            ArrayList actual = new ArrayList(array);
            actual.SortAscendElem();
            return actual.ReturnArray();
        }


        [TestCase(new int[] { 10, 8, -4, -1, 5 }, ExpectedResult = 5)]
        public int ReturnLengthMassivaTest(int[] array)
        {
            ArrayList actual = new ArrayList(array);
            return actual.ReturnLengthMassiva();
        }

        [TestCase(new int[] { 10, 12, 15, 18, 13 }, 2, ExpectedResult = new int[] { 10, 12, 15 })]

        public int[] DelFromEndNElemTest(int[] array, int n) 
        {
            ArrayList actual = new ArrayList(array);
            actual.DelFromEndNElem(n);
            return actual.ReturnArray();
        }

        [TestCase(new int[] { 10, 12, 15, 18, 13 }, 2, ExpectedResult = new int[] { 15, 18, 13 })]
        public int[] DelFromBeginNElemTest(int[] array, int n)
        {
            ArrayList actual = new ArrayList(array);
            actual.DelFromBeginNElem(n);
            return actual.ReturnArray();
        }

        [TestCase(new int[] { 10, 12, 15, 18, 13 }, 2, 2, ExpectedResult = new int[] { 10, 12, 13 })]
        [TestCase(new int[] { 2, 4, 8, 5, -1, 0 }, 3, 1, ExpectedResult = new int[] { 2, 4, 8,-1,0 })]
        public int[] DelByIndexNElemTest(int[] array, int a, int n)
        {
            ArrayList actual = new ArrayList(array);
            actual.DelByIndexNElem(a ,n);
            return actual.ReturnArray();
        }

        [TestCase(new int[] { 2, 4, 12, 9, -1, 0 }, ExpectedResult = new int[] { 12, 9, 4, 2, 0, -1 })]
        public int[] AscendingDescendingTest(int[] array)
        {
            ArrayList actual = new ArrayList(array);
            actual.AscendingDescending();
            return actual.ReturnArray();
        }

        [TestCase(new int[] { 2, 4, 12, 9, -1, 0 }, ExpectedResult = new int[] { 2, 4, 12, 9, -1, 0 })]
        public int[] ReturnMassiveTest(int[] array)
        {
            ArrayList actual = new ArrayList(array);
            actual.ReturnMassive();
            return actual.ReturnArray();
        }

        [TestCase(new int[] { 2, 3, 12, 3, -1, 0 },3, ExpectedResult = new int[] { 2, 12,-1, 0 })]
        public int[] DeleteByValueTest(int[] array, int a)
        {
            ArrayList actual = new ArrayList(array);
            actual.DeleteByValue(a);
            return actual.ReturnArray();
        }
    }
}