﻿#pragma checksum "..\..\ContGenVoltageWfm_Int.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "CAC59D967F2BB5DF30C2373F95C14AD2AE9C73959A8C2DD3D3CB6A9F899E9B55"
//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 도구를 사용하여 생성되었습니다.
//     런타임 버전:4.0.30319.42000
//
//     파일 내용을 변경하면 잘못된 동작이 발생할 수 있으며, 코드를 다시 생성하면
//     이러한 변경 내용이 손실됩니다.
// </auto-generated>
//------------------------------------------------------------------------------

using DAQ;
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


namespace DAQ {
    
    
    /// <summary>
    /// Page1
    /// </summary>
    public partial class Page1 : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\ContGenVoltageWfm_Int.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnStart;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\ContGenVoltageWfm_Int.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnStop;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\ContGenVoltageWfm_Int.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox minimumTextBox;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\ContGenVoltageWfm_Int.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox maximumTextBox;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\ContGenVoltageWfm_Int.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox physicalChannelComboBox;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\ContGenVoltageWfm_Int.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox edfrequency;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\ContGenVoltageWfm_Int.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox signalTypeComboBox;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\ContGenVoltageWfm_Int.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox edcyclesPerBuffer;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\ContGenVoltageWfm_Int.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox edsamplesPerBuffer;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\ContGenVoltageWfm_Int.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox edamplitude;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\ContGenVoltageWfm_Int.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal SciChartWrapper.Views.SciChartProfile2DView profilechart;
        
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
            System.Uri resourceLocater = new System.Uri("/DAQ;component/contgenvoltagewfm_int.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ContGenVoltageWfm_Int.xaml"
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
            this.btnStart = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\ContGenVoltageWfm_Int.xaml"
            this.btnStart.Click += new System.Windows.RoutedEventHandler(this.btnStart_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnStop = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\ContGenVoltageWfm_Int.xaml"
            this.btnStop.Click += new System.Windows.RoutedEventHandler(this.btnStop_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.minimumTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.maximumTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.physicalChannelComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.edfrequency = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.signalTypeComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.edcyclesPerBuffer = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.edsamplesPerBuffer = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.edamplitude = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.profilechart = ((SciChartWrapper.Views.SciChartProfile2DView)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
