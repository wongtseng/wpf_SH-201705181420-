﻿#pragma checksum "..\..\..\physicscheck\Page_physicsCheckMaster - 复制.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E0FF768C5792F852A6A6A2777DB6591A"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using Mitov.PlotLab;
using MyPlot;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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
using wpf_SH.physicscheck;


namespace wpf_SH.physicscheck {
    
    
    /// <summary>
    /// Page_physicsCheckMaster
    /// </summary>
    public partial class Page_physicsCheckMaster : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\..\physicscheck\Page_physicsCheckMaster - 复制.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border MyBorderR;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\physicscheck\Page_physicsCheckMaster - 复制.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border title;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\physicscheck\Page_physicsCheckMaster - 复制.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox picmessage;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\physicscheck\Page_physicsCheckMaster - 复制.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContentControl CCLeft;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\physicscheck\Page_physicsCheckMaster - 复制.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal wpf_SH.UcMyRbtn MyRadiobtn1;
        
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
            System.Uri resourceLocater = new System.Uri("/wpf_SH;component/physicscheck/page_physicscheckmaster%20-%20%e5%a4%8d%e5%88%b6.x" +
                    "aml", System.UriKind.Relative);
            
            #line 1 "..\..\..\physicscheck\Page_physicsCheckMaster - 复制.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this.MyBorderR = ((System.Windows.Controls.Border)(target));
            return;
            case 2:
            this.title = ((System.Windows.Controls.Border)(target));
            return;
            case 3:
            this.picmessage = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.CCLeft = ((System.Windows.Controls.ContentControl)(target));
            
            #line 79 "..\..\..\physicscheck\Page_physicsCheckMaster - 复制.xaml"
            this.CCLeft.Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 5:
            this.MyRadiobtn1 = ((wpf_SH.UcMyRbtn)(target));
            
            #line 83 "..\..\..\physicscheck\Page_physicsCheckMaster - 复制.xaml"
            this.MyRadiobtn1.AddHandler(System.Windows.Input.Mouse.PreviewMouseDownEvent, new System.Windows.Input.MouseButtonEventHandler(this.MyRadiobtn_PreviewMouseDown));
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

