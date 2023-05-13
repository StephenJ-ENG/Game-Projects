using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Text_Adventure;

namespace Text_Adventure
{
    public class Narrator
    {
        public string Name { get; }

        public Narrator()
        {
            Name = "Yori";
        }

        public void Speak(string message, Action<string> printCentered)
        {
            Console.WriteLine($"{Name}: {message}");
        }

        public void IntroductionMessage()
        {
            UI.PrintCentered("Greetings Traveler from...wherever you came from!");
            Console.ReadKey();
            Console.Clear();

            UI.PrintCentered("You must be shaking in your boots wondering how the heck you got here huh?");
            Console.ReadKey();
            Console.Clear();

            UI.PrintCentered("Don't worry it's not like I'm gonna eat you or anything...");
            Console.ReadKey();
            Console.Clear();

            UI.PrintCentered($"Anyways, you may call me {Name}, which means reliable and trustworthy where I come from. Nice isn't it?");
            Console.ReadKey();
            Console.Clear();


        }
    }
}
