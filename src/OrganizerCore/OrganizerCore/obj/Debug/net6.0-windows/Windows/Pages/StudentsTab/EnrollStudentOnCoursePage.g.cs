﻿#pragma checksum "..\..\..\..\..\..\Windows\Pages\StudentsTab\EnrollStudentOnCoursePage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20F2FD1390B8B95EE46C24ED4EB6D36613910260"
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


namespace OrganizerCore.Windows.Pages.StudentsTab {
    
    
    /// <summary>
    /// EnrollStudentOnCoursePage
    /// </summary>
    public partial class EnrollStudentOnCoursePage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\..\..\..\Windows\Pages\StudentsTab\EnrollStudentOnCoursePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock StudentViewTextBlock;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\..\..\Windows\Pages\StudentsTab\EnrollStudentOnCoursePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CourseTitleSearchTextBox;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\..\..\..\Windows\Pages\StudentsTab\EnrollStudentOnCoursePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox GroupTitleSearchTextBox;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\..\..\..\Windows\Pages\StudentsTab\EnrollStudentOnCoursePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid IndividualCoursesDataGrid;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\..\..\..\Windows\Pages\StudentsTab\EnrollStudentOnCoursePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid GroupCoursesDataGrid;
        
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
            System.Uri resourceLocater = new System.Uri("/OrganizerCore;component/windows/pages/studentstab/enrollstudentoncoursepage.xaml" +
                    "", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\..\Windows\Pages\StudentsTab\EnrollStudentOnCoursePage.xaml"
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
            
            #line 8 "..\..\..\..\..\..\Windows\Pages\StudentsTab\EnrollStudentOnCoursePage.xaml"
            ((OrganizerCore.Windows.Pages.StudentsTab.EnrollStudentOnCoursePage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.OnPageLoad);
            
            #line default
            #line hidden
            return;
            case 2:
            this.StudentViewTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.CourseTitleSearchTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 48 "..\..\..\..\..\..\Windows\Pages\StudentsTab\EnrollStudentOnCoursePage.xaml"
            this.CourseTitleSearchTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.OnFiltersTextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.GroupTitleSearchTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 58 "..\..\..\..\..\..\Windows\Pages\StudentsTab\EnrollStudentOnCoursePage.xaml"
            this.GroupTitleSearchTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.OnFiltersTextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.IndividualCoursesDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 6:
            this.GroupCoursesDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 7:
            
            #line 82 "..\..\..\..\..\..\Windows\Pages\StudentsTab\EnrollStudentOnCoursePage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddIndividualButton_OnClick);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 86 "..\..\..\..\..\..\Windows\Pages\StudentsTab\EnrollStudentOnCoursePage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.RemoveIndividualButton_OnClick);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 94 "..\..\..\..\..\..\Windows\Pages\StudentsTab\EnrollStudentOnCoursePage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddGroupButton_OnClick);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 98 "..\..\..\..\..\..\Windows\Pages\StudentsTab\EnrollStudentOnCoursePage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.RemoveGroupButton_OnClick);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 110 "..\..\..\..\..\..\Windows\Pages\StudentsTab\EnrollStudentOnCoursePage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ApplyButton_OnClick);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 116 "..\..\..\..\..\..\Windows\Pages\StudentsTab\EnrollStudentOnCoursePage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CancelButton_OnClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

