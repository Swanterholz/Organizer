﻿#pragma checksum "..\..\..\..\..\..\Windows\Pages\ScheduleTab\EditSchedulePage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73EC0DF7A580FCB7104414187DE0A727DCD73E5D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
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
using Xceed.Wpf.Toolkit;
using Xceed.Wpf.Toolkit.Chromes;
using Xceed.Wpf.Toolkit.Core.Converters;
using Xceed.Wpf.Toolkit.Core.Input;
using Xceed.Wpf.Toolkit.Core.Media;
using Xceed.Wpf.Toolkit.Core.Utilities;
using Xceed.Wpf.Toolkit.Panels;
using Xceed.Wpf.Toolkit.Primitives;
using Xceed.Wpf.Toolkit.PropertyGrid;
using Xceed.Wpf.Toolkit.PropertyGrid.Attributes;
using Xceed.Wpf.Toolkit.PropertyGrid.Commands;
using Xceed.Wpf.Toolkit.PropertyGrid.Converters;
using Xceed.Wpf.Toolkit.PropertyGrid.Editors;
using Xceed.Wpf.Toolkit.Zoombox;


namespace OrganizerCore.Windows.Pages.ScheduleTab {
    
    
    /// <summary>
    /// EditSchedulePage
    /// </summary>
    public partial class EditSchedulePage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\..\..\..\..\Windows\Pages\ScheduleTab\EditSchedulePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton ShowAllRadioButton;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\..\..\Windows\Pages\ScheduleTab\EditSchedulePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton OnlyIndividualRadioButton;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\..\..\Windows\Pages\ScheduleTab\EditSchedulePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton OnlyGroupRadioButton;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\..\..\..\Windows\Pages\ScheduleTab\EditSchedulePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CourseComboBox;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\..\..\..\Windows\Pages\ScheduleTab\EditSchedulePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox LessonComboBox;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\..\..\..\Windows\Pages\ScheduleTab\EditSchedulePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.DateTimePicker DateTimePicker;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\..\..\..\..\Windows\Pages\ScheduleTab\EditSchedulePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NoteTextBox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.16.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/OrganizerCore;component/windows/pages/scheduletab/editschedulepage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\Windows\Pages\ScheduleTab\EditSchedulePage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.16.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 10 "..\..\..\..\..\..\Windows\Pages\ScheduleTab\EditSchedulePage.xaml"
            ((OrganizerCore.Windows.Pages.ScheduleTab.EditSchedulePage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Load);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ShowAllRadioButton = ((System.Windows.Controls.RadioButton)(target));
            
            #line 35 "..\..\..\..\..\..\Windows\Pages\ScheduleTab\EditSchedulePage.xaml"
            this.ShowAllRadioButton.Click += new System.Windows.RoutedEventHandler(this.RadioButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.OnlyIndividualRadioButton = ((System.Windows.Controls.RadioButton)(target));
            
            #line 41 "..\..\..\..\..\..\Windows\Pages\ScheduleTab\EditSchedulePage.xaml"
            this.OnlyIndividualRadioButton.Click += new System.Windows.RoutedEventHandler(this.RadioButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.OnlyGroupRadioButton = ((System.Windows.Controls.RadioButton)(target));
            
            #line 47 "..\..\..\..\..\..\Windows\Pages\ScheduleTab\EditSchedulePage.xaml"
            this.OnlyGroupRadioButton.Click += new System.Windows.RoutedEventHandler(this.RadioButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.CourseComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 63 "..\..\..\..\..\..\Windows\Pages\ScheduleTab\EditSchedulePage.xaml"
            this.CourseComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CourseComboBox_OnSelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.LessonComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.DateTimePicker = ((Xceed.Wpf.Toolkit.DateTimePicker)(target));
            
            #line 91 "..\..\..\..\..\..\Windows\Pages\ScheduleTab\EditSchedulePage.xaml"
            this.DateTimePicker.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<object>(this.DateTimePicker_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.NoteTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            
            #line 113 "..\..\..\..\..\..\Windows\Pages\ScheduleTab\EditSchedulePage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ApplyButton_OnClick);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 117 "..\..\..\..\..\..\Windows\Pages\ScheduleTab\EditSchedulePage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CancelButton_OnClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

