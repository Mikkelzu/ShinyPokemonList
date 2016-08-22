using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShinyPokemonList
{
    public class Genders
    {
        public static string[] GenderList = new string[3];
        public string Male { get; set; }
        public string Female { get; set; }
        public string None { get; set; }

        public Genders()
        {
            Male = Globals.male;
            Female = Globals.female;
            None = Globals.none;

           // GenderList[] = { Male, Female, None };
        }
    }
}
