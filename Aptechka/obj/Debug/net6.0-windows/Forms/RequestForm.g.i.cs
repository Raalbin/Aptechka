﻿#pragma checksum "..\..\..\..\Forms\RequestForm.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8206FF11F6F62742309356941103CF897613B402"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using AptechkaWPF;
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


namespace AptechkaWPF {
    
    
    /// <summary>
    /// RequestForm
    /// </summary>
    public partial class RequestForm : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\..\..\Forms\RequestForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal AptechkaWPF.RequestForm fmRequest;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\Forms\RequestForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label fmLabel;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\Forms\RequestForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid fDataGrid;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Aptechka;component/forms/requestform.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Forms\RequestForm.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.fmRequest = ((AptechkaWPF.RequestForm)(target));
            
            #line 8 "..\..\..\..\Forms\RequestForm.xaml"
            this.fmRequest.Loaded += new System.Windows.RoutedEventHandler(this.fmRequest_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.fmLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            
            #line 21 "..\..\..\..\Forms\RequestForm.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btClick_Add);
            
            #line default
            #line hidden
            return;
            case 4:
            this.fDataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 23 "..\..\..\..\Forms\RequestForm.xaml"
            this.fDataGrid.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.fDataGrid_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

