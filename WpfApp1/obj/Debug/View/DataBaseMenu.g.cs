﻿#pragma checksum "..\..\..\View\DataBaseMenu.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B2E5965012EF41F998ED8328B21C060F539F49B9"
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
using WpfApp1.View;


namespace WpfApp1.View {
    
    
    /// <summary>
    /// DataBaseMenu
    /// </summary>
    public partial class DataBaseMenu : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\View\DataBaseMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid MainGrid;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\View\DataBaseMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ShowPlayersButton;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\View\DataBaseMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ShowResearchersButton;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\View\DataBaseMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ShowResearchButton;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\View\DataBaseMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackToMenuButton;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\View\DataBaseMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ImportButton;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\View\DataBaseMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EditButton;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp1;component/view/databasemenu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\DataBaseMenu.xaml"
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
            this.MainGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 12 "..\..\..\View\DataBaseMenu.xaml"
            this.MainGrid.AutoGeneratingColumn += new System.EventHandler<System.Windows.Controls.DataGridAutoGeneratingColumnEventArgs>(this.OnAutoGeneratingColumn);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ShowPlayersButton = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\View\DataBaseMenu.xaml"
            this.ShowPlayersButton.Click += new System.Windows.RoutedEventHandler(this.ShowPlayersButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ShowResearchersButton = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\View\DataBaseMenu.xaml"
            this.ShowResearchersButton.Click += new System.Windows.RoutedEventHandler(this.ShowResearchersButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ShowResearchButton = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\View\DataBaseMenu.xaml"
            this.ShowResearchButton.Click += new System.Windows.RoutedEventHandler(this.ShowResearchButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 29 "..\..\..\View\DataBaseMenu.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.BackToMenuButton = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\View\DataBaseMenu.xaml"
            this.BackToMenuButton.Click += new System.Windows.RoutedEventHandler(this.BackToMenuButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ImportButton = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\View\DataBaseMenu.xaml"
            this.ImportButton.Click += new System.Windows.RoutedEventHandler(this.ImportButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.EditButton = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\View\DataBaseMenu.xaml"
            this.EditButton.Click += new System.Windows.RoutedEventHandler(this.EditButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
