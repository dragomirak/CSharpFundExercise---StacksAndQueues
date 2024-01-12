namespace P01.BasicStackOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] data = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            Stack<int> numbersStack = new Stack<int>(numbers);

            for (int i = 0; i < data[1]; i++)
            {
                numbersStack.Pop();
            }
                
            if (numbersStack.Count == 0) 
            {
                Console.WriteLine(0);
            }
            else if (numbersStack.Contains(data[2]))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(numbersStack.Min());
            }

        }
    }
}