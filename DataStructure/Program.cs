namespace DataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            LinkedListStack stack = new LinkedListStack();
            LinkedListQueue queue = new LinkedListQueue();
            Console.WriteLine("Welcome to the Linked List Operations");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nSelect the operation to perform \n1.Create Linked List \n2.Display \n3.Add In Reverse Order " +
                    "\n4.Add At Particular Position \n5.Remove First Node \n6.Remove Last Node \n7.Search \n8.Size of Linked List" +
                    "\n11.Create Stack \n12.Display Stack \n13.Peek \n14.Pop \n15.Create Queue \n16.Display Queue \n17.Dequeue \n18.Exit");
                int options = Convert.ToInt32(Console.ReadLine());
                switch (options)
                {
                    case 1:
                        list.Add(56);
                        list.Add(30);
                        list.Add(70);
                        break;
                    case 2:
                        list.Display();
                        break;
                    case 3:
                        list.AddInReverseOrder(70);
                        list.AddInReverseOrder(30);
                        list.AddInReverseOrder(56);
                        Console.WriteLine("Added in Reverse Order");
                        break;
                    case 4:
                        list.Add(56);
                        list.Add(70);
                        list.Display();
                        list.InsertAtParticularPosition(1, 30);
                        break;
                    case 5:
                        list.RemoveFirstNode();
                        break;
                    case 6:
                        list.RemoveLastNode();
                        break;
                    case 7:
                        Console.WriteLine("Enter the Value present in List to find Position");
                        int option = Convert.ToInt32(Console.ReadLine());
                        int find = list.Search(option);
                        Console.WriteLine("The Position of Node in LinkedList is " + find);
                        break;
                    case 8:
                        list.Size();
                        break;
                    case 11:
                        stack.Push(70);
                        stack.Push(30);
                        stack.Push(56);
                        break;
                    case 12:
                        stack.Display();
                        break;
                    case 13:
                        stack.Peek();
                        break;
                    case 14:
                        stack.Pop();
                        break;
                    case 15:
                        queue.Enqueue(56);
                        queue.Enqueue(30);
                        queue.Enqueue(70);
                        break;
                    case 16:
                        queue.Display();
                        break;
                    case 17:
                        queue.Dequeue();
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}