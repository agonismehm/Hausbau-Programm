﻿using AutomaticBauen.Klassen;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Runtime.CompilerServices;

namespace AutomaticBauen
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<string> comboboxinhalt = new List<string>();
        const string projektspeicher = @"C:\Users\agoni\Documents\Firma Alush\BedarfsRechner";
        public Projekt projektdata = new Projekt("Unbenannt");

        public MainWindow()
        {
            InitializeComponent();
            Projektordner.Items.Add("neues Projekt");

            foreach(var i in Directory.EnumerateDirectories(projektspeicher))
            {
                Projektordner.Items.Add(i.Substring(projektspeicher.Length + 1));
            }

           
        }

        private void Button_Flaechenberechnung(object sender, RoutedEventArgs e)
        {

            if(Projektordner.SelectedIndex != 0)
            {
                //Erstellen bzw. Laden des Projektes
                Flaechenberechnung windowflaechenberechnung = new Flaechenberechnung(projektdata);
                windowflaechenberechnung.ShowDialog();
            }
            else
            {
                //Fehlermeldung das kein Projekt ausgewählt wurde.

            }
        }

        private void comboxselectioneventhandler(object sender, RoutedEventArgs e)
        {
            if(Projektordner.SelectedIndex == 0)
            {
                ErstellenButton.IsEnabled = true;
                TextboxProjektName.IsEnabled = true;
                //neuen Ordner erstellen
                Label_Projektauswahl.Content = "Bitte Textbox ausfüllen und anschliessend Erstellen drücken";
            }
            else
            {
                bool existOrdner = true;   //schauen ob der Ordner im Explorer zu finden ist                 

                if(!existOrdner) //Error der Ordner existiert nicht
                {
                    // Fehlermeldung
                    // und Projektordner aus der Combobox entfernen
                
                }
                else if(false) // Schaun ob in dem Ordner eine Datei mit dem Namen Flaechenberechnung.xml existiert
                {
                    //Freigeben des Flächenberechnung-Buttons
                    ButtonFlaechenberechnung.IsEnabled = true;
                    
                    //Das Projekt leer ausgeben
                    //Projekt laden indem die Klassen aus den XML files geladen werden

                }
                else // Ansonsten neue Instanz erstellen
                {
                    //Freigeben des Flächenberechnung-Buutons
                    ButtonFlaechenberechnung.IsEnabled = true;

                    //Den Name des neu angelegten Ordner an den Konstruktur der Klasse Projekt übergeben
                    var name = Projektordner.SelectedItem.ToString();
                    projektdata = new Projekt(name);
                }

            }

        }

        private void ErstellenButton_Click(object sender, RoutedEventArgs e)
        {
            string full_path = projektspeicher + "\\" + "Bauvorhaben_" + TextboxProjektName.Text;
            if (Directory.Exists(full_path) == true)
            {
                //Überprüfen ob so ein Name schon vergeben ist
                Label_Projektauswahl.Content = "Name schon vergeben!";

            }
            else
            {
                comboboxinhalt.Add(TextboxProjektName.Text);
                Projektordner.Items.Add(TextboxProjektName.Text);
                Directory.CreateDirectory(full_path);

            }



            //Ordner erstellen und die dazu gehörigen Klassen ertstellen
            //alle Klassen mit den richtigen Speicher Laden
        }
    }
}
