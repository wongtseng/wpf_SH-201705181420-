﻿#pragma checksum "..\..\UC_choose.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "8A13791CB9CBACB8AF5A2FB510B54A99"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

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
using wpf_SH;


namespace wpf_SH {
    
    
    /// <summary>
    /// UC_choose
    /// </summary>
    public partial class UC_choose : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\UC_choose.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_add;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\UC_choose.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_del;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\UC_choose.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_Up;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\UC_choose.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_Down;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\UC_choose.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ListR;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\UC_choose.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ListL;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\UC_choose.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label TitleL;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\UC_choose.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label TitleR;
        
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
            System.Uri resourceLocater = new System.Uri("/wpf_SH;component/uc_choose.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\UC_choose.xaml"
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
            this.Btn_add = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\UC_choose.xaml"
            this.Btn_add.Click += new System.Windows.RoutedEventHandler(this.Btn_add_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Btn_del = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\UC_choose.xaml"
            this.Btn_del.Click += new System.Windows.RoutedEventHandler(this.Btn_remove_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Btn_Up = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\UC_choose.xaml"
            this.Btn_Up.Click += new System.Windows.RoutedEventHandler(this.Btn_up_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Btn_Down = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\UC_choose.xaml"
            this.Btn_Down.Click += new System.Windows.RoutedEventHandler(this.Btn_down_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ListR = ((System.Windows.Controls.ListBox)(target));
            return;
            case 6:
            this.ListL = ((System.Windows.Controls.ListBox)(target));
            return;
            case 7:
            this.TitleL = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.TitleR = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
