﻿#pragma checksum "..\..\ContAcqDigStartRetrig.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "34C9E7C60D9DF0F65F5DA77E4D05D419911F9B1CF3DC6B9E372592F930458E55"
//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 도구를 사용하여 생성되었습니다.
//     런타임 버전:4.0.30319.42000
//
//     파일 내용을 변경하면 잘못된 동작이 발생할 수 있으며, 코드를 다시 생성하면
//     이러한 변경 내용이 손실됩니다.
// </auto-generated>
//------------------------------------------------------------------------------

using NI_DAQ;
using SciChartWrapper.Views;
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


namespace NI_DAQ {
    
    
    /// <summary>
    /// ContAcqDigStartRetrig
    /// </summary>
    public partial class ContAcqDigStartRetrig : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 44 "..\..\ContAcqDigStartRetrig.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox edchannel;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\ContAcqDigStartRetrig.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox edRate;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\ContAcqDigStartRetrig.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal SciChartWrapper.Views.SciChartProfile2DView profileChart;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\ContAcqDigStartRetrig.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox edminimum;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\ContAcqDigStartRetrig.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox edmaximum;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\ContAcqDigStartRetrig.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox physicalChannelComboBox;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\ContAcqDigStartRetrig.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnStart;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\ContAcqDigStartRetrig.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnStop;
        
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
            System.Uri resourceLocater = new System.Uri("/NI_DAQ;component/contacqdigstartretrig.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ContAcqDigStartRetrig.xaml"
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
            this.edchannel = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.edRate = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.profileChart = ((SciChartWrapper.Views.SciChartProfile2DView)(target));
            return;
            case 4:
            this.edminimum = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.edmaximum = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.physicalChannelComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.btnStart = ((System.Windows.Controls.Button)(target));
            
            #line 81 "..\..\ContAcqDigStartRetrig.xaml"
            this.btnStart.Click += new System.Windows.RoutedEventHandler(this.btnStart_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnStop = ((System.Windows.Controls.Button)(target));
            
            #line 82 "..\..\ContAcqDigStartRetrig.xaml"
            this.btnStop.Click += new System.Windows.RoutedEventHandler(this.btnStop_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 83 "..\..\ContAcqDigStartRetrig.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

