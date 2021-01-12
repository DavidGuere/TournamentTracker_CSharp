﻿#pragma checksum "..\..\CreateTeam.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "619AC036907893DEE282612B2A916B2D7E764EFC913D1216F3A7D3E7BBBE8147"
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
using TournamentTrackerUI;


namespace TournamentTrackerUI {
    
    
    /// <summary>
    /// CreateTeam
    /// </summary>
    public partial class CreateTeam : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\CreateTeam.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBox_team_name;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\CreateTeam.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboBox_team_member_selector;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\CreateTeam.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox firstName;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\CreateTeam.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox lastName;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\CreateTeam.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox email;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\CreateTeam.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox telephone;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\CreateTeam.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_addMember;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\CreateTeam.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_createMember;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\CreateTeam.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_deleteSelected;
        
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
            System.Uri resourceLocater = new System.Uri("/TournamentTrackerUI;component/createteam.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\CreateTeam.xaml"
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
            this.textBox_team_name = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.comboBox_team_member_selector = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.firstName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.lastName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.email = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.telephone = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.button_addMember = ((System.Windows.Controls.Button)(target));
            return;
            case 8:
            this.button_createMember = ((System.Windows.Controls.Button)(target));
            return;
            case 9:
            this.button_deleteSelected = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

