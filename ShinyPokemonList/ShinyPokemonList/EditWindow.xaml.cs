using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MahApps.Metro.Controls;

namespace ShinyPokemonList
{
    /// <summary>
    /// Interaction logic for EditWindow.xaml
    /// </summary>
    public partial class EditWindow : MetroWindow
    {
        public EditWindow(string pokemon, string gender, string otid, string otname, MainWindow main)
        {
            InitializeComponent();
            Pokemon.Initialize.Init();
            FillPokemonList();

            string[] genders = new string[] { Globals.male, Globals.female, Globals.none };

            comboBox.ItemsSource = genders;

            comboBoxPokemon.Text = pokemon;
            comboBox.Text = gender;
            txtOTID.Text = otid;
            txtOTName.Text = otname;
        }

        private void btnDone_Click(object sender, RoutedEventArgs e)
        {
            string name = comboBoxPokemon.SelectedItem.ToString();
            string gender = comboBox.SelectedItem.ToString();
            int otid = Convert.ToInt32(txtOTID.Text);
            string otname = txtOTName.Text;

            try
            {
                EditPokemon.Edit(name, gender, otid, otname);
                MessageBox.Show("ok");
            }
            catch 
            {
                Console.Write("no");
            }
        }

        private void comboBoxPokemon_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            image.Source = GetSprite.GetShinySprite(comboBoxPokemon.SelectedItem.ToString());
        }

        public void FillPokemonList()
        {
            foreach (var pok in Pokemon.pokemonList)
            {
                comboBoxPokemon.Items.Add(pok);
            }
        }
    }
}
