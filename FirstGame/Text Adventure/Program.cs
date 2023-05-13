using System.Text;

namespace Text_Adventure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Game game = new Game();
            game.GameStart();
        }
    }
}