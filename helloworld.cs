namespace helloworld
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello! what is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name} I am World!");
            Console.ReadKey();
        }
    }
}