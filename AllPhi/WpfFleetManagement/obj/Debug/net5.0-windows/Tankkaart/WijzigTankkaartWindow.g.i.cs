﻿#pragma checksum "..\..\..\..\Tankkaart\WijzigTankkaartWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4143C229EABC4890EEE7ACCD603C1D3BF9646683"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
using WpfFleetManagement.Tankkaart;


namespace WpfFleetManagement.Tankkaart {
    
    
    /// <summary>
    /// WijzigTankkaartWindow
    /// </summary>
    public partial class WijzigTankkaartWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\..\Tankkaart\WijzigTankkaartWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxKaartnummer;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\Tankkaart\WijzigTankkaartWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DatePickerGeldigheidsDatum;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\Tankkaart\WijzigTankkaartWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxPincode;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\Tankkaart\WijzigTankkaartWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox CheckBoxGeblokkeerd;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\Tankkaart\WijzigTankkaartWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBoxBrandstof;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\Tankkaart\WijzigTankkaartWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxBestuurder;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\Tankkaart\WijzigTankkaartWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BestuurderButton;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\Tankkaart\WijzigTankkaartWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button WijzigButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.13.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WpfFleetManagement;V1.0.0.0;component/tankkaart/wijzigtankkaartwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Tankkaart\WijzigTankkaartWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.13.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.TextBoxKaartnummer = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.DatePickerGeldigheidsDatum = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 3:
            this.TextBoxPincode = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.CheckBoxGeblokkeerd = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 5:
            this.ComboBoxBrandstof = ((System.Windows.Controls.ComboBox)(target));
            
            #line 36 "..\..\..\..\Tankkaart\WijzigTankkaartWindow.xaml"
            this.ComboBoxBrandstof.Loaded += new System.Windows.RoutedEventHandler(this.ComboBoxBrandstof_Loaded);
            
            #line default
            #line hidden
            return;
            case 6:
            this.TextBoxBestuurder = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.BestuurderButton = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\..\Tankkaart\WijzigTankkaartWindow.xaml"
            this.BestuurderButton.Click += new System.Windows.RoutedEventHandler(this.BestuurderButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.WijzigButton = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\..\Tankkaart\WijzigTankkaartWindow.xaml"
            this.WijzigButton.Click += new System.Windows.RoutedEventHandler(this.WijzigButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

