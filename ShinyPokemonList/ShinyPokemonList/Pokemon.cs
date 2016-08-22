using System;
using System.Collections.Generic;
using System.IO;

namespace ShinyPokemonList
{
    public class Pokemon
    {
        public static List<Pokemon> pokemonList = new List<Pokemon>();
        private int id_ = 0;
        internal class Initialize
        {
            public static void Init()
            {
                try
                {
                    var path = Directory.GetCurrentDirectory();
                    using (var sr = new StreamReader(path + "/pokemondata.txt"))
                    {
                        var line = "";
                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] spl = line.Split(';');
                            if (spl.Length == 8)
                            {
                                try
                                {
                                    new Pokemon(Convert.ToInt32(spl[0]), spl[1]);
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex.Message);
                                }
                            }
                        }
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

        }

        public Pokemon(int id, string name)
        {

            id_ = id;
            Name = name;
           
            pokemonList.Add(this);
        }

        public string Name { get; } = "";

        public override string ToString()
        {
            return Name;
        }
    }
}