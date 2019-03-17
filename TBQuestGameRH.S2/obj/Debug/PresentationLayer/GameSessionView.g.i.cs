﻿#pragma checksum "..\..\..\PresentationLayer\GameSessionView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F45F6829FC8AC283942A163D0B3E0A73105EFD81"
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
using TBQuestGameRH.PresentationLayer;


namespace TBQuestGameRH.PresentationLayer {
    
    
    /// <summary>
    /// GameSessionView
    /// </summary>
    public partial class GameSessionView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 188 "..\..\..\PresentationLayer\GameSessionView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button NorthButton;
        
        #line default
        #line hidden
        
        
        #line 204 "..\..\..\PresentationLayer\GameSessionView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EastButton;
        
        #line default
        #line hidden
        
        
        #line 218 "..\..\..\PresentationLayer\GameSessionView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SouthButton;
        
        #line default
        #line hidden
        
        
        #line 232 "..\..\..\PresentationLayer\GameSessionView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button WestButton;
        
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
            System.Uri resourceLocater = new System.Uri("/TBQuestGameRH;component/presentationlayer/gamesessionview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\PresentationLayer\GameSessionView.xaml"
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
            this.NorthButton = ((System.Windows.Controls.Button)(target));
            
            #line 192 "..\..\..\PresentationLayer\GameSessionView.xaml"
            this.NorthButton.Click += new System.Windows.RoutedEventHandler(this.NorthTravelButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.EastButton = ((System.Windows.Controls.Button)(target));
            
            #line 207 "..\..\..\PresentationLayer\GameSessionView.xaml"
            this.EastButton.Click += new System.Windows.RoutedEventHandler(this.BetaTravelButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.SouthButton = ((System.Windows.Controls.Button)(target));
            
            #line 221 "..\..\..\PresentationLayer\GameSessionView.xaml"
            this.SouthButton.Click += new System.Windows.RoutedEventHandler(this.GammaTravelButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.WestButton = ((System.Windows.Controls.Button)(target));
            
            #line 235 "..\..\..\PresentationLayer\GameSessionView.xaml"
            this.WestButton.Click += new System.Windows.RoutedEventHandler(this.DeltaTravelButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

