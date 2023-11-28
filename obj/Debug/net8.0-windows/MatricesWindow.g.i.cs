﻿#pragma checksum "..\..\..\MatricesWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "C6AD60CA6B973EA93F9251666F8F652424C3F325"
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
using System.Windows.Controls.Ribbon;
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


namespace MatrixSolverApp {
    
    
    /// <summary>
    /// MatricesWindow
    /// </summary>
    public partial class MatricesWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\MatricesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MatrixInputTextBox;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\MatricesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cofactorCheckbox;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\MatricesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeterminantButton;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\MatricesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button InverseButton;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\MatricesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button TransposeButton;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\MatricesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ScalarMultiplyButton;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\MatricesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PowerButton;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\MatricesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ResultTextBox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/TMath;V1.0.0.0;component/matriceswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MatricesWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.MatrixInputTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.cofactorCheckbox = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 3:
            this.DeterminantButton = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\MatricesWindow.xaml"
            this.DeterminantButton.Click += new System.Windows.RoutedEventHandler(this.DeterminantButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.InverseButton = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\MatricesWindow.xaml"
            this.InverseButton.Click += new System.Windows.RoutedEventHandler(this.InverseButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.TransposeButton = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\MatricesWindow.xaml"
            this.TransposeButton.Click += new System.Windows.RoutedEventHandler(this.TransposeButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ScalarMultiplyButton = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\MatricesWindow.xaml"
            this.ScalarMultiplyButton.Click += new System.Windows.RoutedEventHandler(this.ScalarMultiplyButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.PowerButton = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\MatricesWindow.xaml"
            this.PowerButton.Click += new System.Windows.RoutedEventHandler(this.PowerButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ResultTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

