using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Text_Adventure;

namespace Text_Adventure
{
    public class Player
    {
        public string? Name { get; set; }

        public void SetName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                Name = "Elon Musk";
                Narrator narrator = new Narrator();
                narrator.Speak("Y-Your pretty b-bold to be using HIS name.", UI.PrintCentered);
            }
            else
            {
                Name = name;
                Narrator narrator1 = new Narrator();
                narrator1.Speak($"{name}, huh? Your parents must've ran out out of ideas quickly to give you such a name.", UI.PrintCentered);
            }
        }

    }

}
