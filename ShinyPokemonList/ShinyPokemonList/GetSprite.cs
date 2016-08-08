using System;
using System.Windows.Media.Imaging;
using System.IO;

namespace ShinyPokemonList
{
    public class GetSprite
    {
        public static string Path = Directory.GetCurrentDirectory();
        
        public static BitmapImage GetShinySprite(object currentPokemonIndex)
        {
            try
            {
                var bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(Path + @"\Sprites Shiny\" + currentPokemonIndex + ".png");
                bitmap.EndInit();
                return bitmap;
            }
            catch
            {
                var bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(Path + @"\Sprites Shiny\0.png");
                bitmap.EndInit();
                return null;
            }
        }

        public static string ShinySpritePath(string currentPokemonIndex)
        {
            return Path + @"\Sprites Shiny\" + currentPokemonIndex + ".png";
        }
        public static BitmapImage NoImageFound()
        {
            var bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(Path + @"\Sprites\0.png");
            bitmap.EndInit();
            return bitmap;
        }
    }
}