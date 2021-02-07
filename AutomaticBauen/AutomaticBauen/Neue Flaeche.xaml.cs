using AutomaticBauen.Klassen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AutomaticBauen
{
    /// <summary>
    /// Interaktionslogik für Neue_Flaeche.xaml
    /// </summary>
    public partial class window_Neue_Flaeche : Window
    {
        private Bereich tempbereich;

        public window_Neue_Flaeche(Bereich bereich)
        {
            InitializeComponent();
            Combobox_Flaechenarten.ItemsSource = Enum.GetValues(typeof(Flaechenart));
            tempbereich = bereich;
        }

        private void Button_Click_Erstellen(object sender, RoutedEventArgs e)
        {
            string eingegebenerName = Textbox_Name.Text;
            //Überprüfen ob die Flaeche mit den Name schon existiert
            var item = tempbereich.listflaechen.FirstOrDefault(x => x.Name == eingegebenerName);

            Label_Fehlermeldungname.Visibility = Visibility.Hidden;
            Label_Fehlermeldung.Visibility = Visibility.Hidden;
            Label_Meldung.Visibility = Visibility.Hidden;

            if (item == null)
            {
                Flaeche newFlaeche;

                if (Combobox_Flaechenarten.SelectedIndex != -1)
                {
                    newFlaeche = new Flaeche(eingegebenerName, (Flaechenart)Combobox_Flaechenarten.SelectedIndex);
                    newFlaeche.Seite1 = Convert.ToInt32(Textbox_Seite1.Text);
                    newFlaeche.Seite2 = Convert.ToInt32(Textbox_Seite2.Text);
                    tempbereich.AddNewFlaeche(newFlaeche);
                    Label_Meldung.Visibility = Visibility.Visible;
                }
                else
                {
                    Label_Fehlermeldung.Visibility = Visibility.Visible;
                }
                
            }
            else
            {
                Label_Fehlermeldungname.Visibility = Visibility.Visible;
            }

        }

        private void Textbox_Seite_Eingabevalidierung(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Button_Click_Abbrechen(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
