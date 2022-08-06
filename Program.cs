
namespace MagicSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("\n\n");
            var ms = new MagicSquare(7);
            ms.InitializeGrid();
            ms.Generate();
            ms.PrintGrid();
            Console.WriteLine("\n\n");
        }
    }
}
