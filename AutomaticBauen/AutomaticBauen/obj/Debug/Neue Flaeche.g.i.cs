﻿#pragma checksum "..\..\Neue Flaeche.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7818FF1939A448F470E884F46978C6858EA75207202BE2893B979A1D05985851"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using AutomaticBauen;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace AutomaticBauen {
    
    
    /// <summary>
    /// window_Neue_Flaeche
    /// </summary>
    public partial class window_Neue_Flaeche : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\Neue Flaeche.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Textbox_Name;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\Neue Flaeche.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Textbox_Seite1;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\Neue Flaeche.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Textbox_Seite2;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\Neue Flaeche.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Combobox_Flaechenarten;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\Neue Flaeche.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Label_Fehlermeldungname;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\Neue Flaeche.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Label_Meldung;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\Neue Flaeche.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Label_Fehlermeldung;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/AutomaticBauen;component/neue%20flaeche.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Neue Flaeche.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Textbox_Name = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.Textbox_Seite1 = ((System.Windows.Controls.TextBox)(target));
            
            #line 11 "..\..\Neue Flaeche.xaml"
            this.Textbox_Seite1.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.Textbox_Seite_Eingabevalidierung);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Textbox_Seite2 = ((System.Windows.Controls.TextBox)(target));
            
            #line 12 "..\..\Neue Flaeche.xaml"
            this.Textbox_Seite2.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.Textbox_Seite_Eingabevalidierung);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Combobox_Flaechenarten = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            
            #line 18 "..\..\Neue Flaeche.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_Abbrechen);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 19 "..\..\Neue Flaeche.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_Erstellen);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Label_Fehlermeldungname = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.Label_Meldung = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.Label_Fehlermeldung = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

