﻿#pragma checksum "..\..\..\View\TeacherStatisticView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "CB8F6332CB6700E0DDE1D7366CAF9B8BBC182C2EA2BD5CE41931CCF53E8D5205"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Group01_QuanLyLuanVan.ViewModel;
using LiveCharts.Wpf;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using Microsoft.Xaml.Behaviors;
using Microsoft.Xaml.Behaviors.Core;
using Microsoft.Xaml.Behaviors.Input;
using Microsoft.Xaml.Behaviors.Layout;
using Microsoft.Xaml.Behaviors.Media;
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


namespace Group01_QuanLyLuanVan.View {
    
    
    /// <summary>
    /// TeacherStatisticView
    /// </summary>
    public partial class TeacherStatisticView : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\View\TeacherStatisticView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Group01_QuanLyLuanVan.View.TeacherStatisticView TeacherStatisticWd;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\View\TeacherStatisticView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal LiveCharts.Wpf.PieChart PieChart_KetQua;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\..\View\TeacherStatisticView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock SoLuongSVGioi;
        
        #line default
        #line hidden
        
        
        #line 115 "..\..\..\View\TeacherStatisticView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock SoLuongSVKha;
        
        #line default
        #line hidden
        
        
        #line 141 "..\..\..\View\TeacherStatisticView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock SoLuongSVTrungBinh;
        
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
            System.Uri resourceLocater = new System.Uri("/Group01_QuanLyLuanVan;component/view/teacherstatisticview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\TeacherStatisticView.xaml"
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
            this.TeacherStatisticWd = ((Group01_QuanLyLuanVan.View.TeacherStatisticView)(target));
            return;
            case 2:
            this.PieChart_KetQua = ((LiveCharts.Wpf.PieChart)(target));
            
            #line 52 "..\..\..\View\TeacherStatisticView.xaml"
            this.PieChart_KetQua.DataClick += new LiveCharts.Events.DataClickHandler(this.PieChart_DataClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.SoLuongSVGioi = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.SoLuongSVKha = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.SoLuongSVTrungBinh = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

