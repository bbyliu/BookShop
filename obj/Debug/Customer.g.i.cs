﻿#pragma checksum "..\..\Customer.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "18412EE0B9BA17B2A7367EF27F6979A96D0B1F01798E1667529AC25AEB8AEE35"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using BookShop;
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


namespace BookShop {
    
    
    /// <summary>
    /// Customer
    /// </summary>
    public partial class Customer : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\Customer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button back;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\Customer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid Byu;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\Customer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameTbx;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\Customer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox AutTxt;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\Customer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox PubTxt;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\Customer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox yearTxt;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\Customer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox GenTxt;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\Customer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PagesTxt;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\Customer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PriceTxt;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\Customer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox PromTxt;
        
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
            System.Uri resourceLocater = new System.Uri("/BookShop;component/customer.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Customer.xaml"
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
            this.back = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\Customer.xaml"
            this.back.Click += new System.Windows.RoutedEventHandler(this.back_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Byu = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.NameTbx = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.AutTxt = ((System.Windows.Controls.ComboBox)(target));
            
            #line 31 "..\..\Customer.xaml"
            this.AutTxt.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.AutTxt_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.PubTxt = ((System.Windows.Controls.ComboBox)(target));
            
            #line 32 "..\..\Customer.xaml"
            this.PubTxt.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.PubTxt_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.yearTxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.GenTxt = ((System.Windows.Controls.ComboBox)(target));
            
            #line 34 "..\..\Customer.xaml"
            this.GenTxt.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.GenTxt_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.PagesTxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.PriceTxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.PromTxt = ((System.Windows.Controls.ComboBox)(target));
            
            #line 37 "..\..\Customer.xaml"
            this.PromTxt.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.PromTxt_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 39 "..\..\Customer.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

