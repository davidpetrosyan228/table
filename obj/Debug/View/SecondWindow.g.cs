#pragma checksum "..\..\..\View\SecondWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5E0796A6D01FE341E3926432331293FF781488CD4A7731EF00A8EBA9F65E15A4"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using Table.View;


namespace Table.View {
    
    
    /// <summary>
    /// SecondWindow
    /// </summary>
    public partial class SecondWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\View\SecondWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame MainFrame;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\View\SecondWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock NameUser;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\View\SecondWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ExitProgram;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\View\SecondWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Minimized;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\View\SecondWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Table;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\View\SecondWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Teacher;
        
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
            System.Uri resourceLocater = new System.Uri("/Table;component/view/secondwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\SecondWindow.xaml"
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
            this.MainFrame = ((System.Windows.Controls.Frame)(target));
            return;
            case 2:
            this.NameUser = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.ExitProgram = ((System.Windows.Controls.TextBlock)(target));
            
            #line 16 "..\..\..\View\SecondWindow.xaml"
            this.ExitProgram.MouseEnter += new System.Windows.Input.MouseEventHandler(this.ExitProgram_MouseEnter);
            
            #line default
            #line hidden
            
            #line 16 "..\..\..\View\SecondWindow.xaml"
            this.ExitProgram.MouseLeave += new System.Windows.Input.MouseEventHandler(this.ExitProgram_MouseLeave);
            
            #line default
            #line hidden
            
            #line 16 "..\..\..\View\SecondWindow.xaml"
            this.ExitProgram.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.ExitProgram_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Minimized = ((System.Windows.Controls.TextBlock)(target));
            
            #line 26 "..\..\..\View\SecondWindow.xaml"
            this.Minimized.MouseEnter += new System.Windows.Input.MouseEventHandler(this.Minimized_MouseEnter);
            
            #line default
            #line hidden
            
            #line 26 "..\..\..\View\SecondWindow.xaml"
            this.Minimized.MouseLeave += new System.Windows.Input.MouseEventHandler(this.Minimized_MouseLeave);
            
            #line default
            #line hidden
            
            #line 26 "..\..\..\View\SecondWindow.xaml"
            this.Minimized.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Minimized_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Table = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\View\SecondWindow.xaml"
            this.Table.Click += new System.Windows.RoutedEventHandler(this.Table_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Teacher = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\..\View\SecondWindow.xaml"
            this.Teacher.Click += new System.Windows.RoutedEventHandler(this.Teacher_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

