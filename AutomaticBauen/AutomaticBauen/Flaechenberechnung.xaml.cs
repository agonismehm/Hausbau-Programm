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

namespace AutomaticBauen
{
    /// <summary>
    /// Interaktionslogik für Mauern_Berechnung.xaml
    /// </summary>
    public partial class Flaechenberechnung : Window
    {
        List<string> comboboxinhalt = new List<string>();

        public Flaechenberechnung()
        {
            InitializeComponent();
            //Was neues
            comboboxinhalt.Add("25cm Mauern");
            comboboxinhalt.Add("12cm Mauern");
            Mauernarten.SelectedIndex = 0;

            Mauernarten.ItemsSource = comboboxinhalt;
        }

        private void Button_Click_Berechnungfertigstellen(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_NeuerBereich(object sender, RoutedEventArgs e)
        {

        }
    }

}
