﻿#pragma checksum "..\..\Izvestaj.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "AF3CC2BFDF28675A6399E0C1EB1091C721D31D96265E5E7D9FBD7AFF24BF4813"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Transitions;
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
using WpfApp3;


namespace WpfApp3 {
    
    
    /// <summary>
    /// Izvestaj
    /// </summary>
    public partial class Izvestaj : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 37 "..\..\Izvestaj.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbFontFamily;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\Izvestaj.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbFontSize;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\Izvestaj.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bold;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\Izvestaj.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button italic;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\Izvestaj.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button underline;
        
        #line default
        #line hidden
        
        /// <summary>
        /// editor Name Field
        /// </summary>
        
        #line 93 "..\..\Izvestaj.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        public System.Windows.Controls.RichTextBox editor;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp3;component/izvestaj.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Izvestaj.xaml"
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
            
            #line 19 "..\..\Izvestaj.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.Open_Executed);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 20 "..\..\Izvestaj.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.Save_Executed);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cmbFontFamily = ((System.Windows.Controls.ComboBox)(target));
            
            #line 37 "..\..\Izvestaj.xaml"
            this.cmbFontFamily.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cmbFontFamily_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.cmbFontSize = ((System.Windows.Controls.ComboBox)(target));
            
            #line 39 "..\..\Izvestaj.xaml"
            this.cmbFontSize.AddHandler(System.Windows.Controls.Primitives.TextBoxBase.TextChangedEvent, new System.Windows.Controls.TextChangedEventHandler(this.cmbFontSize_TextChanged));
            
            #line default
            #line hidden
            
            #line 39 "..\..\Izvestaj.xaml"
            this.cmbFontSize.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.cmbFontSize_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 5:
            this.bold = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.italic = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            this.underline = ((System.Windows.Controls.Button)(target));
            return;
            case 8:
            this.editor = ((System.Windows.Controls.RichTextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

