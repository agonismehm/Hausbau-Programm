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
using AutomaticBauen.Klassen;

namespace AutomaticBauen
{
    /// <summary>
    /// Interaktionslogik für Mauern_Berechnung.xaml
    /// </summary>
    public partial class Flaechenberechnung : Window
    {
        List<string> combobox_bereiche = new List<string>();
        Projekt projektdata;

        public Flaechenberechnung(Projekt newprojektdata)
        {
            InitializeComponent();

            projektdata = newprojektdata;

            //Laden der Namen von den Bereichen in die ComboBox 
            Combobox_Bereiche.ItemsSource = projektdata.bereiche;


            //Test für ListBox
            //Flaeche testflaeche = new Flaeche("Wand1", Flaechenart.InnereWaendeNetto);
            //testflaeche.Seite1 = 5;
            //testflaeche.Seite2 = 6;
            //projektdata.AddBereich("Kueche");
            //projektdata.bereiche[0].AddNewFlaeche(testflaeche);

            //ListBox_AnzeigeFlaechen.Items.Add(projektdata.bereiche[0].listflaechen[0]);
        }

        private void Button_Click_Berechnungfertigstellen(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_NeuerBereich(object sender, RoutedEventArgs e)
        {
            bool retvalue = false;
            string newbereichsname = Textbox_Bereichsname.Text;

            retvalue = projektdata.AddBereich(newbereichsname);
            
            if(retvalue == true)
            {
                label_fehlermeldung_neuerBereich.Content = "Bereich mit dem Namen " + Textbox_Bereichsname.Text + " konnte erfolgreich hinzugefügt";
                label_fehlermeldung_neuerBereich.Visibility = Visibility.Visible;
            }
            else
            {
                label_fehlermeldung_neuerBereich.Content = "Bereich mit dem Namen " + Textbox_Bereichsname.Text + " existiert bereits! ";
                label_fehlermeldung_neuerBereich.Visibility = Visibility.Visible;
            }
            
        }

        private void comboxselectioneventhandler_bereichauswahl(object sender, SelectionChangedEventArgs e)
        {
            Bereich choosebereich = Combobox_Bereiche.SelectedItem as Bereich;

            ListBox_AnzeigeFlaechen.ItemsSource = choosebereich.listflaechen; 
        }

        private void ListBoxselectioneventhandler_Flaechenauswahl(object sender, SelectionChangedEventArgs e)
        {
           
        }

        private void Button_Click_Flaechehinzufuegen(object sender, RoutedEventArgs e)
        {
            Bereich choosebereich = Combobox_Bereiche.SelectedItem as Bereich;

            if (choosebereich != null)
            {
                //Bearbeitungsfenster für Flaechen öffnen
                window_Neue_Flaeche windowflaechenberechnung = new window_Neue_Flaeche(choosebereich);
                windowflaechenberechnung.ShowDialog();
            }
            else
            {
                //fehler
            }
            
        }
    }

}
