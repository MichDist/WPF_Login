﻿#pragma checksum "..\..\..\Pages\PageUserConfig.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D811A76A72C86B757C6D5E6E714AA1925F79EA7A0FD2FC7FAB6DB169E1B83013"
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
using WPF_Login.Pages;


namespace WPF_Login.Pages {
    
    
    /// <summary>
    /// PageUserConfig
    /// </summary>
    public partial class PageUserConfig : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\..\Pages\PageUserConfig.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tboxNewUserName;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Pages\PageUserConfig.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnNewUserName;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Pages\PageUserConfig.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tboxNewPassword;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Pages\PageUserConfig.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnNewPassword;
        
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
            System.Uri resourceLocater = new System.Uri("/WPF_Login;component/pages/pageuserconfig.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\PageUserConfig.xaml"
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
            this.tboxNewUserName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.btnNewUserName = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\Pages\PageUserConfig.xaml"
            this.btnNewUserName.Click += new System.Windows.RoutedEventHandler(this.btnNewUserName_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.tboxNewPassword = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.btnNewPassword = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\Pages\PageUserConfig.xaml"
            this.btnNewPassword.Click += new System.Windows.RoutedEventHandler(this.btnNewPassword_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

