﻿#pragma checksum "..\..\NewSale.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BF3ACD9C44AD5B3C5508E5EB31D68EB7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using StyloShoes;
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


namespace StyloShoes {
    
    
    /// <summary>
    /// NewSale
    /// </summary>
    public partial class NewSale : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\NewSale.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox uid;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\NewSale.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox uprice;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\NewSale.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ucatagory;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\NewSale.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox usize;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\NewSale.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ucolor;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\NewSale.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ubrand;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\NewSale.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker udpDate;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\NewSale.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock reciept;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\NewSale.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label uStatus;
        
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
            System.Uri resourceLocater = new System.Uri("/StyloShoes;component/newsale.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\NewSale.xaml"
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
            this.uid = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            
            #line 32 "..\..\NewSale.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Search_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.uprice = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.ucatagory = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.usize = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.ucolor = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.ubrand = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.udpDate = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 9:
            this.reciept = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            
            #line 44 "..\..\NewSale.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ShowSales_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 45 "..\..\NewSale.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.NewSale_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 46 "..\..\NewSale.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Purchase_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 47 "..\..\NewSale.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Save_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 48 "..\..\NewSale.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Back_Click);
            
            #line default
            #line hidden
            return;
            case 15:
            this.uStatus = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

