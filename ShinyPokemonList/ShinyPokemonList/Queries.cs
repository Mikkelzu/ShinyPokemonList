namespace ShinyPokemonList
{
    public class Queries
    {
        public static string Pokemon
        {
            get
            {
                return "SELECT name,gender,OTID,OTName FROM pokemon";
            }
        }

        public static string AddPokemon(string name, string gender, int OTID, string OTName)
        {
            return $"INSERT INTO pokemon (name, gender, OTID, OTName) VALUES ('{name}', '{gender}', {OTID} ,'{OTName}')";
        }

        public static string DeletePokemon(int otid)
        {
            return $"DELETE FROM pokemon WHERE OTID = '{otid}'";
        }
    }
}
