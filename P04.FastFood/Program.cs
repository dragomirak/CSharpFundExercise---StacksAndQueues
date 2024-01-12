namespace P04.FastFood
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            Queue<int> ordersQueue = new Queue<int>(orders);

            Console.WriteLine($"{ordersQueue.Max()}");

            while (ordersQueue.Count > 0 )
            {
                int currentOrder = ordersQueue.Peek();
                if (currentOrder <= foodQuantity) 
                {
                    ordersQueue.Dequeue();
                    foodQuantity -= currentOrder;
                }
                else
                {
                    Console.Write($"Orders left: ");
                    Console.WriteLine(string.Join(" ", ordersQueue));
                    return;
                }
            }

            Console.WriteLine("Orders complete");

        }
    }
}