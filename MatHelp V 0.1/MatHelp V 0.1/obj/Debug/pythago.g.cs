#pragma checksum "..\..\pythago.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "63FED4B7F8BC6C3669E161CB9828080C67F541FD86101A898AF92169F69642F9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MatHelp_V_0._1;
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


namespace MatHelp_V_0._1 {
    
    
    /// <summary>
    /// pythago
    /// </summary>
    public partial class pythago : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\pythago.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image triangle;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\pythago.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox A_Input;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\pythago.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox B_Input;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\pythago.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox C_Input;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\pythago.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label answer;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\pythago.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button calculate_Button;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\pythago.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label formel;
        
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
            System.Uri resourceLocater = new System.Uri("/MatHelp V 0.1;component/pythago.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\pythago.xaml"
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
            
            #line 8 "..\..\pythago.xaml"
            ((MatHelp_V_0._1.pythago)(target)).Closed += new System.EventHandler(this.Window_Closed);
            
            #line default
            #line hidden
            return;
            case 2:
            this.triangle = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.A_Input = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.B_Input = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.C_Input = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.answer = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.calculate_Button = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\pythago.xaml"
            this.calculate_Button.Click += new System.Windows.RoutedEventHandler(this.calculate_Button_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.formel = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            
            #line 24 "..\..\pythago.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

