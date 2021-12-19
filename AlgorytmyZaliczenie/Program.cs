namespace AlgorytmyZaliczenie
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1 - verification
            LinkedList list = new LinkedList();
            list.AddFirst(1);    
            list.AddFirst(3);    
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(8);

            //Exercise 2 - verification
            BST bST = new BST();
            bST.Add(4);
            bST.Add(2);
            bST.Add(3);
            bST.Add(1);

            //Exercise 3 - verification
            int[] table = new int[] {8, 2, 7, 4, 9, 6, 3, 1, 5 };
            table = BubbleSort.BubbleSortFunction(table);
            foreach(int i in table)
            {
                Console.WriteLine(i);
            }

            //Exercise 4 - verification
            Validation.BracketValidation("''||''|''|'"); //incorrect validation
        }
    }
}