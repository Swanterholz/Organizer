﻿#pragma checksum "..\..\..\..\..\..\Windows\Pages\ScheduleTab\FullSchedulePage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "DBD330D4A0A2EFCC485E88C5314830F0E7D8C38B"
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


namespace OrganizerCore.Windows.Pages.ScheduleTab {
    
    
    /// <summary>
    /// FullSchedulePage
    /// </summary>
    public partial class FullSchedulePage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 33 "..\..\..\..\..\..\Windows\Pages\ScheduleTab\FullSchedulePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchStudentTextBox;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\..\..\Windows\Pages\ScheduleTab\FullSchedulePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker SearchFromDateTPicker;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\..\..\..\Windows\Pages\ScheduleTab\FullSchedulePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton ShowAllRadioButton;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\..\..\..\Windows\Pages\ScheduleTab\FullSchedulePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton OnlyHeldRadioButton;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\..\..\..\Windows\Pages\ScheduleTab\FullSchedulePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton OnlyNotHeldRadioButton;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\..\..\..\..\Windows\Pages\ScheduleTab\FullSchedulePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker SearchToDatePicker;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\..\..\..\..\Windows\Pages\ScheduleTab\FullSchedulePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox IsTodayCheckBox;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\..\..\..\..\Windows\Pages\ScheduleTab\FullSchedulePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox ApplyDatesFilterCheckBox;
        
        #line default
        #line hidden
        
        
        #line 124 "..\..\..\..\..\..\Windows\Pages\ScheduleTab\FullSchedulePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid ScheduleViewDataGrid;
        
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
            System.Uri resourceLocater = new System.Uri("/OrganizerCore;component/windows/pages/scheduletab/fullschedulepage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\Windows\Pages\ScheduleTab\FullSchedulePage.xaml"
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
            
            #line 9 "..\..\..\..\..\..\Windows\Pages\ScheduleTab\FullSchedulePage.xaml"
            ((OrganizerCore.Windows.Pages.ScheduleTab.FullSchedulePage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.FullSchedulePage_OnLoaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.SearchStudentTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 38 "..\..\..\..\..\..\Windows\Pages\ScheduleTab\FullSchedulePage.xaml"
            this.SearchStudentTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.UpdateFrom_TextBox);
            
            #line default
            #line hidden
            return;
            case 3:
            this.SearchFromDateTPicker = ((System.Windows.Controls.DatePicker)(target));
            
            #line 52 "..\..\..\..\..\..\Windows\Pages\ScheduleTab\FullSchedulePage.xaml"
            this.SearchFromDateTPicker.SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.UpdateFrom_DatePicker);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ShowAllRadioButton = ((System.Windows.Controls.RadioButton)(target));
            
            #line 67 "..\..\..\..\..\..\Windows\Pages\ScheduleTab\FullSchedulePage.xaml"
            this.ShowAllRadioButton.Click += new System.Windows.RoutedEventHandler(this.RadioButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.OnlyHeldRadioButton = ((System.Windows.Controls.RadioButton)(target));
            
            #line 73 "..\..\..\..\..\..\Windows\Pages\ScheduleTab\FullSchedulePage.xaml"
            this.OnlyHeldRadioButton.Click += new System.Windows.RoutedEventHandler(this.RadioButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.OnlyNotHeldRadioButton = ((System.Windows.Controls.RadioButton)(target));
            
            #line 79 "..\..\..\..\..\..\Windows\Pages\ScheduleTab\FullSchedulePage.xaml"
            this.OnlyNotHeldRadioButton.Click += new System.Windows.RoutedEventHandler(this.RadioButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.SearchToDatePicker = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 8:
            this.IsTodayCheckBox = ((System.Windows.Controls.CheckBox)(target));
            
            #line 105 "..\..\..\..\..\..\Windows\Pages\ScheduleTab\FullSchedulePage.xaml"
            this.IsTodayCheckBox.Click += new System.Windows.RoutedEventHandler(this.UpdateFrom_CheckBox);
            
            #line default
            #line hidden
            return;
            case 9:
            this.ApplyDatesFilterCheckBox = ((System.Windows.Controls.CheckBox)(target));
            
            #line 111 "..\..\..\..\..\..\Windows\Pages\ScheduleTab\FullSchedulePage.xaml"
            this.ApplyDatesFilterCheckBox.Click += new System.Windows.RoutedEventHandler(this.UpdateFrom_CheckBox);
            
            #line default
            #line hidden
            return;
            case 10:
            this.ScheduleViewDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 11:
            
            #line 133 "..\..\..\..\..\..\Windows\Pages\ScheduleTab\FullSchedulePage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.UploadButton_OnClick);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 147 "..\..\..\..\..\..\Windows\Pages\ScheduleTab\FullSchedulePage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.HeldButton_OnClick);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 152 "..\..\..\..\..\..\Windows\Pages\ScheduleTab\FullSchedulePage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddButton_OnClick);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 157 "..\..\..\..\..\..\Windows\Pages\ScheduleTab\FullSchedulePage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.EditButton_OnClick);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 162 "..\..\..\..\..\..\Windows\Pages\ScheduleTab\FullSchedulePage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.RemoveButton_OnClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

