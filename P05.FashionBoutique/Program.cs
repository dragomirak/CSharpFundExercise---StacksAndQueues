namespace P05.FashionBoutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int rackCapacity = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>(clothes);

            int numberOfRacks = 1;
            int currentRackCapacity = rackCapacity;

            while (stack.Count > 0)
            {
                int currentCloth = stack.Peek();
                if (currentCloth <= currentRackCapacity)
                {
                    stack.Pop();
                    currentRackCapacity -= currentCloth;
                }
                else
                {
                    numberOfRacks++;
                    currentRackCapacity = rackCapacity;
                }
            }

            Console.WriteLine(numberOfRacks);

        }
    }
}