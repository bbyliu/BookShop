﻿#pragma checksum "..\..\Admin.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6C4F0A8985FFAD54B46554D20699F237C71BCCF4FF7C667EFE04AA4742A6EF44"
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
    /// Admin
    /// </summary>
    public partial class Admin : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 32 "..\..\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid BookDgr;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameTbx;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox AutTxt;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox PubTxt;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox yearTxt;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox GenTxt;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PagesTxt;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PriceTxt;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\Admin.xaml"
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
            System.Uri resourceLocater = new System.Uri("/BookShop;component/admin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Admin.xaml"
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
            
            #line 25 "..\..\Admin.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MuneItem_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 26 "..\..\Admin.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MuneItem_Click2);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 27 "..\..\Admin.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MuneItem_Click3);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BookDgr = ((System.Windows.Controls.DataGrid)(target));
            
            #line 32 "..\..\Admin.xaml"
            this.BookDgr.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.BookDgr_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 36 "..\..\Admin.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MuneItem_Click4);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 37 "..\..\Admin.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MuneItem_Click5);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 38 "..\..\Admin.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MuneItem_Click6);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 39 "..\..\Admin.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MuneItem_Click7);
            
            #line default
            #line hidden
            return;
            case 9:
            this.NameTbx = ((System.Windows.Controls.TextBox)(target));
            
            #line 41 "..\..\Admin.xaml"
            this.NameTbx.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.NameTbx_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 10:
            this.AutTxt = ((System.Windows.Controls.ComboBox)(target));
            
            #line 42 "..\..\Admin.xaml"
            this.AutTxt.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.AutTxt_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 11:
            this.PubTxt = ((System.Windows.Controls.ComboBox)(target));
            
            #line 43 "..\..\Admin.xaml"
            this.PubTxt.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.PubTxt_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 12:
            this.yearTxt = ((System.Windows.Controls.TextBox)(target));
            
            #line 44 "..\..\Admin.xaml"
            this.yearTxt.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.yearTxt_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 13:
            this.GenTxt = ((System.Windows.Controls.ComboBox)(target));
            
            #line 45 "..\..\Admin.xaml"
            this.GenTxt.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.GenTxt_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 14:
            this.PagesTxt = ((System.Windows.Controls.TextBox)(target));
            
            #line 46 "..\..\Admin.xaml"
            this.PagesTxt.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.PagesTxt_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 15:
            this.PriceTxt = ((System.Windows.Controls.TextBox)(target));
            
            #line 47 "..\..\Admin.xaml"
            this.PriceTxt.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.PriceTxt_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 16:
            this.PromTxt = ((System.Windows.Controls.ComboBox)(target));
            
            #line 48 "..\..\Admin.xaml"
            this.PromTxt.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.PromTxt_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 17:
            
            #line 49 "..\..\Admin.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_2);
            
            #line default
            #line hidden
            return;
            case 18:
            
            #line 50 "..\..\Admin.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 19:
            
            #line 51 "..\..\Admin.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

