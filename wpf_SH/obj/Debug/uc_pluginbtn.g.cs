﻿#pragma checksum "..\..\uc_pluginbtn.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "DEED4C9800AB26A99EA7E3FAD0EB24B5"
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


namespace wpf_SH {
    
    
    /// <summary>
    /// uc_pluginbtn
    /// </summary>
    public partial class uc_pluginbtn : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\uc_pluginbtn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border Myborder;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\uc_pluginbtn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Myimage;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\uc_pluginbtn.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Mylb;
        
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
            System.Uri resourceLocater = new System.Uri("/wpf_SH;component/uc_pluginbtn.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\uc_pluginbtn.xaml"
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
            this.Myborder = ((System.Windows.Controls.Border)(target));
            
            #line 12 "..\..\uc_pluginbtn.xaml"
            this.Myborder.AddHandler(System.Windows.Input.Mouse.MouseEnterEvent, new System.Windows.Input.MouseEventHandler(this.Myborder_MouseEnter));
            
            #line default
            #line hidden
            
            #line 12 "..\..\uc_pluginbtn.xaml"
            this.Myborder.AddHandler(System.Windows.Input.Mouse.MouseLeaveEvent, new System.Windows.Input.MouseEventHandler(this.Myborder_MouseLeave));
            
            #line default
            #line hidden
            
            #line 12 "..\..\uc_pluginbtn.xaml"
            this.Myborder.AddHandler(System.Windows.Input.Mouse.PreviewMouseDownEvent, new System.Windows.Input.MouseButtonEventHandler(this.Myborder_PreviewMouseDown));
            
            #line default
            #line hidden
            return;
            case 2:
            this.Myimage = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.Mylb = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

