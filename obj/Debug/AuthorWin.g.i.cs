﻿#pragma checksum "..\..\AuthorWin.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F8D9AF1B34DD3CE22D74FACEBB4B82014772FEEF1FC9FF4274C139610389D4AF"
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
    /// AuthorWin
    /// </summary>
    public partial class AuthorWin : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\AuthorWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid AuthotDgr;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\AuthorWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button back;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\AuthorWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FNTbx;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\AuthorWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LNTxt;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\AuthorWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker BirthTxt;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\AuthorWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CountryTxt;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\AuthorWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Dele;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\AuthorWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Add;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\AuthorWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Update;
        
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
            System.Uri resourceLocater = new System.Uri("/BookShop;component/authorwin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AuthorWin.xaml"
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
            this.AuthotDgr = ((System.Windows.Controls.DataGrid)(target));
            
            #line 25 "..\..\AuthorWin.xaml"
            this.AuthotDgr.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.AuthotDgr_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.back = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\AuthorWin.xaml"
            this.back.Click += new System.Windows.RoutedEventHandler(this.back_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.FNTbx = ((System.Windows.Controls.TextBox)(target));
            
            #line 30 "..\..\AuthorWin.xaml"
            this.FNTbx.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.FNTbx_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 4:
            this.LNTxt = ((System.Windows.Controls.TextBox)(target));
            
            #line 31 "..\..\AuthorWin.xaml"
            this.LNTxt.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.LNTxt_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BirthTxt = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 6:
            this.CountryTxt = ((System.Windows.Controls.TextBox)(target));
            
            #line 33 "..\..\AuthorWin.xaml"
            this.CountryTxt.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.CountryTxt_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Dele = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\AuthorWin.xaml"
            this.Dele.Click += new System.Windows.RoutedEventHandler(this.Dele_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Add = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\AuthorWin.xaml"
            this.Add.Click += new System.Windows.RoutedEventHandler(this.Add_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Update = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\AuthorWin.xaml"
            this.Update.Click += new System.Windows.RoutedEventHandler(this.Update_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

