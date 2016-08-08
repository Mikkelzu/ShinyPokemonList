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
using MahApps.Metro.Controls.Dialogs;

namespace ShinyPokemonList
{
    /// <summary>
    /// Interaction logic for AddWindow.xaml
    /// </summary>
    public partial class AddWindow : MetroWindow
    {
        public AddWindow()
        {
            InitializeComponent();
        }

        private async void btnDone_Click(object sender, RoutedEventArgs e)
        {
            string name = txtName.Text;
            string gender = txtGender.Text;
            int otid = Convert.ToInt32(txtOTID.Text);
            string otname = txtOTName.Text;

            AddPoke.AddPokemon(name, gender, otid, otname);

            await this.ShowMessageAsync("Completed", $"Succesfully added your {txtName.Text}");

            Close();
        }
    }
}
