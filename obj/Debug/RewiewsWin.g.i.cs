﻿#pragma checksum "..\..\RewiewsWin.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0BD758CA48AF2836B89B2B3E689D6AB562DA88060711B35AAB7F2E16798FE2E5"
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
    /// RewiewsWin
    /// </summary>
    public partial class RewiewsWin : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\RewiewsWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid RewDgr;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\RewiewsWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button back;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\RewiewsWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox BkidTbx;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\RewiewsWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox UsidTxt;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\RewiewsWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ratTxt;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\RewiewsWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ComTxt;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\RewiewsWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dateTxt;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\RewiewsWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Dele;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\RewiewsWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Add;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\RewiewsWin.xaml"
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
            System.Uri resourceLocater = new System.Uri("/BookShop;component/rewiewswin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\RewiewsWin.xaml"
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
            this.RewDgr = ((System.Windows.Controls.DataGrid)(target));
            
            #line 25 "..\..\RewiewsWin.xaml"
            this.RewDgr.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.RewDgr_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.back = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\RewiewsWin.xaml"
            this.back.Click += new System.Windows.RoutedEventHandler(this.back_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BkidTbx = ((System.Windows.Controls.ComboBox)(target));
            
            #line 30 "..\..\RewiewsWin.xaml"
            this.BkidTbx.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.BkidTbx_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.UsidTxt = ((System.Windows.Controls.ComboBox)(target));
            
            #line 31 "..\..\RewiewsWin.xaml"
            this.UsidTxt.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.UsidTxt_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ratTxt = ((System.Windows.Controls.TextBox)(target));
            
            #line 32 "..\..\RewiewsWin.xaml"
            this.ratTxt.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.ratTxt_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ComTxt = ((System.Windows.Controls.TextBox)(target));
            
            #line 33 "..\..\RewiewsWin.xaml"
            this.ComTxt.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.ComTxt_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 7:
            this.dateTxt = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 8:
            this.Dele = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\RewiewsWin.xaml"
            this.Dele.Click += new System.Windows.RoutedEventHandler(this.Dele_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Add = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\RewiewsWin.xaml"
            this.Add.Click += new System.Windows.RoutedEventHandler(this.Add_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.Update = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\RewiewsWin.xaml"
            this.Update.Click += new System.Windows.RoutedEventHandler(this.Update_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

