﻿using System;
using System.Linq;
using System.Linq.Expressions;
using System.Windows;
using System.Windows.Controls;
using OrganizerCore.DbWorking;
using OrganizerCore.Model;
using OrganizerCore.Tools;

namespace OrganizerCore.Windows.Pages.ScheduleTab;

public partial class EditSchedulePage
{
	private readonly Schedule _schedule;

	public EditSchedulePage(Schedule schedule)
	{
		_schedule = schedule;
		InitializeComponent();
	}

	private static ApplicationContext Context => DataBaseConnection.Instance.CurrentContext;

	private CourseTypeShow CourseTypeShow
	{
		get => ShowAllRadioButton.IsChecked ?? false       ? CourseTypeShow.All
			: OnlyIndividualRadioButton.IsChecked ?? false ? CourseTypeShow.Individual
			: OnlyGroupRadioButton.IsChecked ?? false      ? CourseTypeShow.Group : throw new ArgumentException();
		set
		{
			if (value is CourseTypeShow.All)
			{
				ShowAllRadioButton.IsChecked = true;
			}
			else if (value is CourseTypeShow.Individual)
			{
				OnlyIndividualRadioButton.IsChecked = true;
			}
			else if (value is CourseTypeShow.Group)
			{
				OnlyGroupRadioButton.IsChecked = true;
			}
		}
	}

	private void Page_Load(object sender, RoutedEventArgs e)
	{
		Load();
		SetupCoursesComboBox();
	}

	private void SetupCoursesComboBox()
	{
		CourseComboBox.ItemsSource = Context.Courses.Observe();
	}

	private void RadioButton_Click(object sender, RoutedEventArgs e) => UpdateLessorComboBox();

	private void CourseComboBox_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
		=> UpdateLessorComboBox();

	private void UpdateLessorComboBox()
	{
		if (CourseComboBox.SelectedItem is Course selectedCourse)
		{
			var groups = Context.Groups.Observe().Where((g) => g.Course == selectedCourse);
			var individualCourses = Context.IndividualCourses.Observe().Where((ic) => ic.Course == selectedCourse);

			LessonComboBox.ItemsSource
				= CourseTypeShow switch
				{
					CourseTypeShow.All        => individualCourses.Concat(groups.Cast<object>()),
					CourseTypeShow.Group      => groups,
					CourseTypeShow.Individual => individualCourses,
					_                         => throw new Exception()
				};
			LessonComboBox.IsEnabled = true;
		}
		else
		{
			LessonComboBox.ItemsSource = null;
			LessonComboBox.IsEnabled = false;
		}
	}

#region Save-Load

	private void Load()
	{
		CourseTypeShow = CourseTypeShow.All;
		CourseComboBox.SelectedItem = _schedule.View.Course;
		LessonComboBox.SelectedItem = _schedule.Lessor;
		DateTimePicker.Value = _schedule.ScheduledTime;
		NoteTextBox.Text = _schedule.Note;
	}

	private void Save()
	{
		_schedule.View.Course = (Course)CourseComboBox.SelectedItem;
		_schedule.Lessor = LessonComboBox.SelectedItem;
		_schedule.ScheduledTime = DateTimePicker.Value ?? DateTime.MinValue;
		_schedule.Note = NoteTextBox.Text;
	}

#endregion

#region Apply/Cancel

	private void ApplyButton_OnClick(object sender, RoutedEventArgs e)
	{
		try
		{
			Save();
			Context.SaveChanges();
			NavigationService!.GoBack();
		}
		catch (NullReferenceException)
		{
			MessageBoxUtils.ShowError("Не все поля установлены");
		}
	}

	private void CancelButton_OnClick(object sender, RoutedEventArgs e)
	{
		DataBaseConnection.Instance.ResetAll();
		NavigationService!.GoBack();
	}

#endregion

	private void DateTimePicker_ValueChanged(object sender, RoutedPropertyChangedEventArgs<object> e) { }
}

public enum CourseTypeShow
{
	All,
	Individual,
	Group,
}