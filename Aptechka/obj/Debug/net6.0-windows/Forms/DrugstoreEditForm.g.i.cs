﻿#pragma checksum "..\..\..\..\Forms\DrugstoreEditForm.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "777682635BAFB950BBDF060A2883F47336DB274D"
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
    /// DrugstoreEditForm
    /// </summary>
    public partial class DrugstoreEditForm : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\..\..\Forms\DrugstoreEditForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal AptechkaWPF.DrugstoreEditForm fmDrugstoreEdit;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\..\..\Forms\DrugstoreEditForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid fmGrid;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\Forms\DrugstoreEditForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label fmLabel;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\Forms\DrugstoreEditForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox fmName;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\Forms\DrugstoreEditForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox fmPhone;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\Forms\DrugstoreEditForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox fmINN;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\Forms\DrugstoreEditForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox fmAddr;
        
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
            System.Uri resourceLocater = new System.Uri("/Aptechka;component/forms/drugstoreeditform.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Forms\DrugstoreEditForm.xaml"
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
            this.fmDrugstoreEdit = ((AptechkaWPF.DrugstoreEditForm)(target));
            
            #line 8 "..\..\..\..\Forms\DrugstoreEditForm.xaml"
            this.fmDrugstoreEdit.Loaded += new System.Windows.RoutedEventHandler(this.fmDrugstoreEdit_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.fmGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.fmLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            
            #line 17 "..\..\..\..\Forms\DrugstoreEditForm.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btSave_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.fmName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.fmPhone = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.fmINN = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.fmAddr = ((System.Windows.Controls.TextBox)(target));
            
            #line 46 "..\..\..\..\Forms\DrugstoreEditForm.xaml"
            this.fmAddr.MouseEnter += new System.Windows.Input.MouseEventHandler(this.fmAddr_MouseEnter);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

