// Updated by XamlIntelliSenseFileGenerator 15.05.2023 23:01:09
#pragma checksum "..\..\..\..\Forms\RequestEditForm.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "FCE60068E1DBA7295CB323BFFF7C345708B0BCBD"
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


namespace AptechkaWPF
{


    /// <summary>
    /// RequestEditForm
    /// </summary>
    public partial class RequestEditForm : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector
    {

#line default
#line hidden


#line 10 "..\..\..\..\Forms\RequestEditForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid fmGrid;

#line default
#line hidden


#line 20 "..\..\..\..\Forms\RequestEditForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label fmLabel;

#line default
#line hidden


#line 40 "..\..\..\..\Forms\RequestEditForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox fmDrugstore;

#line default
#line hidden


#line 46 "..\..\..\..\Forms\RequestEditForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox fmStatus;

#line default
#line hidden


#line 48 "..\..\..\..\Forms\RequestEditForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid fDataGrid;

#line default
#line hidden


#line 54 "..\..\..\..\Forms\RequestEditForm.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridComboBoxColumn fDataGridDrug;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.4.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Aptechka;component/forms/requesteditform.xaml", System.UriKind.Relative);

#line 1 "..\..\..\..\Forms\RequestEditForm.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.fmRequestEdit = ((AptechkaWPF.RequestEditForm)(target));

#line 8 "..\..\..\..\Forms\RequestEditForm.xaml"
                    this.fmRequestEdit.Loaded += new System.Windows.RoutedEventHandler(this.fmRequest_Loaded);

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

#line 22 "..\..\..\..\Forms\RequestEditForm.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.btSave_Click);

#line default
#line hidden
                    return;
                case 5:
                    this.fmDrugstore = ((System.Windows.Controls.ComboBox)(target));
                    return;
                case 6:
                    this.fmStatus = ((System.Windows.Controls.ComboBox)(target));
                    return;
                case 7:
                    this.fDataGrid = ((System.Windows.Controls.DataGrid)(target));

#line 50 "..\..\..\..\Forms\RequestEditForm.xaml"
                    this.fDataGrid.BeginningEdit += new System.EventHandler<System.Windows.Controls.DataGridBeginningEditEventArgs>(this.fDataGrid_BeginningEdit);

#line default
#line hidden

#line 50 "..\..\..\..\Forms\RequestEditForm.xaml"
                    this.fDataGrid.CellEditEnding += new System.EventHandler<System.Windows.Controls.DataGridCellEditEndingEventArgs>(this.fDataGrid_CellEditEnding);

#line default
#line hidden
                    return;
                case 8:
                    this.fDataGridDrug = ((System.Windows.Controls.DataGridComboBoxColumn)(target));
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.Page fmRequestEdit;
    }
}

