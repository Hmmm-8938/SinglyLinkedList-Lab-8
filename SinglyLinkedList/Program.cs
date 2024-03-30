namespace SinglyLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedList list = new SinglyLinkedList();
            list.AddFirst("Hello World First");
            list.AddFirst("Hello World First Real");
            list.AddLast("The actual end!");
            list.DisplayList();
            Console.WriteLine("");
            list.RemoveFirst();
            list.RemoveLast();
            list.DisplayList();
            list.GetValue(1);
        }
    }
}
