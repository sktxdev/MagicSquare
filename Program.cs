
namespace MagicSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            var ms = new MagicSquare(21,1);
            ms.InitializeGrid();
            ms.Generate();
            ms.PrintGrid();
            Console.WriteLine("\nDone\n");
        }
    }
}
