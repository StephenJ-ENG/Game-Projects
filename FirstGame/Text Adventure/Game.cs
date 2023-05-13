using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Text_Adventure;

namespace Text_Adventure
{
    public class Game
    {
        private Player _player;
        private Narrator _narrator;
        public Game()
        {
            _player = new Player();
            _narrator = new Narrator();
        }
        public void GameStart()
        {
            _narrator.IntroductionMessage();

            _narrator.Speak("Please enter a name I should call you by: ", UI.PrintCentered);
            string playerName = Console.ReadLine();

            _player.SetName(playerName);
        }
    }
}
