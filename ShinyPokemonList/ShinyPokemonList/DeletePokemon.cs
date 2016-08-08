using System.Data.SQLite;

namespace ShinyPokemonList
{
    public class DeletePoke
    {
        public static async void DeleteRow(int otid)
        {
            SQLiteConnection cnc = new SQLiteConnection(Connection.ConnectString());

            cnc.Open();

            SQLiteCommand cmd = new SQLiteCommand(Queries.DeletePokemon(otid), cnc);

            await cmd.ExecuteNonQueryAsync();

            cnc.Close();
        }
    }
}
