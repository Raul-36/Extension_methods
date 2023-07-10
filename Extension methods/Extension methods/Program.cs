namespace Extension_methods
{
    internal class Program
    {
        static void Main()
        {
            //Sort
            {
                int[] ints = InputNumbers();
                Console.Write($"(1 - {Direction.Descending}/2 - {Direction.Ascending})");
                Direction direction = (int.Parse(Console.ReadLine()) == 1) ? Direction.Descending : Direction.Ascending;
                int[] result = ints.Sort(direction);
                foreach (int i in result)
                {
                    Console.WriteLine(i);
                }
            }
            //Find1
            {
                int[] ints = InputNumbers();
                Console.Write("Enter the number you want to check:");
                int valueToFind = int.Parse(Console.ReadLine());
                Console.WriteLine(ints.Find(valueToFind));
            }
            //Find2
            {
                int[] ints = InputNumbers();
                Console.Write("Enter the numbers you want to check:");
                int[] valuesToFind = InputNumbers();
                Console.WriteLine(ints.Find(valuesToFind));
            }
            //Plus
            {
                int[] ints = InputNumbers();
                int[] ints1 = InputNumbers();
                foreach (int item in ints.Plus(ints1))
                {
                    Console.WriteLine(item);
                }
            }
            //Get
            {
                int[] ints = InputNumbers();
                Console.Write("(1 - odd/2 - even)");
                Predicate<int> predicate = (x) => true;
                int input = int.Parse(Console.ReadLine());
                if (input == 1)
                {
                    predicate = (x) => x % 2 != 0;
                }
                else if (input == 2)
                {
                    predicate = (x) => x % 2 == 0;
                }
                foreach (var item in ints.Get(predicate))
                {
                    Console.WriteLine(item);
                }
            }
        }
        static public int[] InputNumbers()
        {
            Console.Write("enter numbers separated by commas:");
            string[] input = Console.ReadLine().Split(',');
            int[] ints = new int[input.Length];
            for (int i = 0; i < ints.Length; i++)
            {
                ints[i] = int.Parse(input[i]);
            }
            return ints;
        }
    }
}
