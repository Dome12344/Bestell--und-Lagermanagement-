﻿#pragma checksum "..\..\..\Lieferanten_hinzufügen.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "BB8553CDBB18B93C66B7F71A61F2739D6B2DB1E0"
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
    /// Lieferanten_hinzufügen
    /// </summary>
    public partial class Lieferanten_hinzufügen : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 33 "..\..\..\Lieferanten_hinzufügen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox lieferantennummer;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Lieferanten_hinzufügen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox firmen_name;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Lieferanten_hinzufügen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox firmen_sitz;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Lieferanten_hinzufügen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Preis;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\Lieferanten_hinzufügen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox lieferzeit;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Lieferanten_hinzufügen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox welche_waren_sind_verfügbar;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\Lieferanten_hinzufügen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button hinzufügen;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\Lieferanten_hinzufügen.xaml"
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
            System.Uri resourceLocater = new System.Uri("/Bestell- und Lagermanagement;V1.0.0.0;component/lieferanten_hinzuf%c3%bcgen.xaml" +
                    "", System.UriKind.Relative);
            
            #line 1 "..\..\..\Lieferanten_hinzufügen.xaml"
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
            this.lieferantennummer = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.firmen_name = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.firmen_sitz = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.Preis = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.lieferzeit = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.welche_waren_sind_verfügbar = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.hinzufügen = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\..\Lieferanten_hinzufügen.xaml"
            this.hinzufügen.Click += new System.Windows.RoutedEventHandler(this.hinzufügen_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.zurück = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\..\Lieferanten_hinzufügen.xaml"
            this.zurück.Click += new System.Windows.RoutedEventHandler(this.zurück_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

