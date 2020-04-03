using NUnit.Framework;
using GlobalProgect_1;
using GlobalProgect_1.LinkedLists;
using GlobalProgect_1.DoubleLinkedList;

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

        [TestCase (new int[] {1,2,3 }, 4, ExpectedResult =new int[] { 1,2,3,4})]
        public int[] AddTest(int[] array, int a)
        {
            list.Add(array);
            list.Add(a);
            return list.ReturnArray();
        }
    }
}