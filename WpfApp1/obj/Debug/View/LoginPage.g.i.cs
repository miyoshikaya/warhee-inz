#pragma checksum "..\..\..\View\LoginPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2B25F87C923505F4247FD1E6BD878374322DE807"
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


namespace WpfApp1.View
{


    /// <summary>
    /// LoginPage
    /// </summary>
    public partial class LoginPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector
    {


#line 22 "..\..\..\View\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Login;

#line default
#line hidden


#line 23 "..\..\..\View\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox loginBox;

#line default
#line hidden


#line 24 "..\..\..\View\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ageBox;

#line default
#line hidden


#line 25 "..\..\..\View\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox SexSelector;

#line default
#line hidden


#line 32 "..\..\..\View\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ToGameButton;

#line default
#line hidden


#line 33 "..\..\..\View\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RepeatLoginBox;

#line default
#line hidden


#line 34 "..\..\..\View\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label RepeatLoginLabel;

#line default
#line hidden


#line 35 "..\..\..\View\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel LeftPanelLogin;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WpfApp1;component/view/loginpage.xaml", System.UriKind.Relative);

#line 1 "..\..\..\View\LoginPage.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.Login = ((System.Windows.Controls.Label)(target));
                    return;
                case 2:
                    this.loginBox = ((System.Windows.Controls.TextBox)(target));

#line 23 "..\..\..\View\LoginPage.xaml"
                    this.loginBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.loginBox_TextChanged);

#line default
#line hidden
                    return;
                case 3:
                    this.ageBox = ((System.Windows.Controls.TextBox)(target));

#line 24 "..\..\..\View\LoginPage.xaml"
                    this.ageBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.ageBox_TextChanged);

#line default
#line hidden

#line 24 "..\..\..\View\LoginPage.xaml"
                    this.ageBox.LostFocus += new System.Windows.RoutedEventHandler(this.ageBox_LostFocus);

#line default
#line hidden
                    return;
                case 4:
                    this.SexSelector = ((System.Windows.Controls.ComboBox)(target));
                    return;
                case 5:
                    this.ToGameButton = ((System.Windows.Controls.Button)(target));

#line 32 "..\..\..\View\LoginPage.xaml"
                    this.ToGameButton.MouseEnter += new System.Windows.Input.MouseEventHandler(this.ToGameButton_MouseEnter);

#line default
#line hidden

#line 32 "..\..\..\View\LoginPage.xaml"
                    this.ToGameButton.Click += new System.Windows.RoutedEventHandler(this.ToGameButton_Click);

#line default
#line hidden
                    return;
                case 6:
                    this.RepeatLoginBox = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 7:
                    this.RepeatLoginLabel = ((System.Windows.Controls.Label)(target));
                    return;
                case 8:
                    this.LeftPanelLogin = ((System.Windows.Controls.DockPanel)(target));
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.Image scissors;
    }
}

