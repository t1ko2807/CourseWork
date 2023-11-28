﻿#pragma checksum "..\..\..\VectorsWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A1711ABD8FA70C904D6C7D9157AE5C3ECA162EBE"
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


namespace TMath {
    
    
    /// <summary>
    /// VectorsWindow
    /// </summary>
    public partial class VectorsWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\..\VectorsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Point1X;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\VectorsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Point1Y;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\VectorsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Point1Z;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\VectorsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Point2X;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\VectorsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Point2Y;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\VectorsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Point2Z;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\VectorsWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox OutputTextBox;
        
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
            System.Uri resourceLocater = new System.Uri("/TMath;V1.0.0.0;component/vectorswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\VectorsWindow.xaml"
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
            
            #line 16 "..\..\..\VectorsWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MagnitudeMenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 17 "..\..\..\VectorsWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.AngleBetweenMenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 18 "..\..\..\VectorsWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.ProjectionMenuItem_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Point1X = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.Point1Y = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.Point1Z = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.Point2X = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.Point2Y = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.Point2Z = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            
            #line 43 "..\..\..\VectorsWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CalculateButton_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.OutputTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
