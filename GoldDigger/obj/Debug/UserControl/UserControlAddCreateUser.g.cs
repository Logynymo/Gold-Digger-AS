﻿#pragma checksum "..\..\..\UserControl\UserControlAddCreateUser.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "829A281D9A3A07EA75B180832F77E5BEB91D88EE99E21676E3920B557AD008BA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using GoldDigger;
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


namespace GoldDigger {
    
    
    /// <summary>
    /// UserControlAddCreateUser
    /// </summary>
    public partial class UserControlAddCreateUser : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\UserControl\UserControlAddCreateUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridUserMain;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\UserControl\UserControlAddCreateUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonUCCUANewCustomer;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\UserControl\UserControlAddCreateUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonUCCAUCancelNewCustomer;
        
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
            System.Uri resourceLocater = new System.Uri("/GoldDigger;component/usercontrol/usercontroladdcreateuser.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UserControl\UserControlAddCreateUser.xaml"
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
            this.GridUserMain = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.buttonUCCUANewCustomer = ((System.Windows.Controls.Button)(target));
            
            #line 73 "..\..\..\UserControl\UserControlAddCreateUser.xaml"
            this.buttonUCCUANewCustomer.Click += new System.Windows.RoutedEventHandler(this.buttonUCCUANewCustomer_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.buttonUCCAUCancelNewCustomer = ((System.Windows.Controls.Button)(target));
            
            #line 84 "..\..\..\UserControl\UserControlAddCreateUser.xaml"
            this.buttonUCCAUCancelNewCustomer.Click += new System.Windows.RoutedEventHandler(this.buttonUCCAUCancelNewCustomer_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

