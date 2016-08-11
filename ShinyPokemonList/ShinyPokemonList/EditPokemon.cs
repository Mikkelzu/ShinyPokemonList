using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace ShinyPokemonList
{
    public class EditPokemon
    {
        public static void Edit(string name, string gender, int OTID, string OTName)
        {
            SQLiteConnection cnc = new SQLiteConnection(Connection.ConnectString());
            cnc.Open();
            SQLiteCommand cmd = new SQLiteCommand(Queries.EditPokemon(name, gender, OTID, OTName), cnc);

            cmd.ExecuteNonQuery();

            cnc.Close();
        }
    }
}
