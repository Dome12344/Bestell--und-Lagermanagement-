﻿#pragma checksum "..\..\..\Mitarbeiter_Ansicht.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7094FA3AE9D3AB08227663DB4112966D5CC54C16"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using Bestell__und_Lagermanagement;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace Bestell__und_Lagermanagement {
    
    
    /// <summary>
    /// Mitarbeiter_Ansicht
    /// </summary>
    public partial class Mitarbeiter_Ansicht : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\..\Mitarbeiter_Ansicht.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid mitarbeiterGrid;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\Mitarbeiter_Ansicht.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox altes_passwort;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\Mitarbeiter_Ansicht.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox neues_passwort;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\Mitarbeiter_Ansicht.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button neues_passwort_generieren;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\Mitarbeiter_Ansicht.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button passwort_speichern;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\Mitarbeiter_Ansicht.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button zurück;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "9.0.3.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Bestell- und Lagermanagement;V1.0.0.0;component/mitarbeiter_ansicht.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Mitarbeiter_Ansicht.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "9.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.mitarbeiterGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.altes_passwort = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.neues_passwort = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.neues_passwort_generieren = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\..\Mitarbeiter_Ansicht.xaml"
            this.neues_passwort_generieren.Click += new System.Windows.RoutedEventHandler(this.neues_passwort_generieren_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.passwort_speichern = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\..\Mitarbeiter_Ansicht.xaml"
            this.passwort_speichern.Click += new System.Windows.RoutedEventHandler(this.passwort_speichern_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.zurück = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\..\Mitarbeiter_Ansicht.xaml"
            this.zurück.Click += new System.Windows.RoutedEventHandler(this.zurück_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

