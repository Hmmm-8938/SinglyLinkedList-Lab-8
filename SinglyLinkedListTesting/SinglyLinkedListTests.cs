using System.Collections.Generic;
using SinglyLinkedList;
namespace SinglyLinkedListTesting
{
    [TestClass]
    public class SinglyLinkedListTests
    {
        public SinglyLinkedList list = new SinglyLinkedList();

        [TestMethod]
        public void addNodesToBeginningOfList()
        {

            list.AddFirst("Jane Doe");
            list.AddFirst("John Smith");
            list.AddFirst("Joe Schmoe");
            list.AddFirst("Joe Blow");
        }

        [TestMethod]
        public void addNodesToEndOfList()
        {
            list.AddLast("Bob Bobberson");
            list.AddLast("Sam Sammerson");
            list.AddLast("Dave Daverson");
        }

        [TestMethod]
        public void removeFirstNodeFromList()
        {
            list.RemoveFirst();
        }

        [TestMethod]
        public void removeLastNodeFromList()
        {
            list.RemoveLast();
        }

        [TestMethod]
        public void getValueatGivenIndex()
        {
            // Should be getting Jane Doe
            list.GetValue(2);
        }

        [TestMethod]
        public void determineSizeOfList()
        {
            // Should end at 5.
            list.GetCount();
        }

    }
}