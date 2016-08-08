using System.Data.SQLite;

namespace ShinyPokemonList
{
    public class AddPoke
    {
        public static async void AddPokemon(string name, string gender, int otid, string otname)
        {
            SQLiteConnection cnc = new SQLiteConnection(Connection.ConnectString());

            await cnc.OpenAsync();

            SQLiteCommand cmd = new SQLiteCommand(Queries.AddPokemon(name, gender, otid, otname), cnc);

            await cmd.ExecuteNonQueryAsync();

            cnc.Close();
        }
    }
}