﻿using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using OrganizerCore.DbWorking;
using OrganizerCore.Model;
using OrganizerCore.Model.Views;
using OrganizerCore.Tools.Extensions;

namespace OrganizerCore.Windows.Pages.ScheduleTab;

public partial class FullSchedulePage
{
	private bool _showHeld;
	private bool _showNotHeld;

	public FullSchedulePage() => InitializeComponent();

	private void FullSchedulePage_OnLoaded(object sender, RoutedEventArgs e) => UpdateViewTable();

#region Table

	private void UpdateViewTable()
	{
		SetupTable();
		SetupColumns();
	}

	private void SetupTable()
	{
		var scheduleViewSource = new CollectionViewSource
		{
			Source = DataBaseConnection.Instance.Observe<Schedule>(),
		};

		scheduleViewSource.Filter += FilterTable;
		ScheduleViewDataGrid.ItemsSource = scheduleViewSource.View;
	}

	private void FilterTable(object sender, FilterEventArgs e)
	{
		var schedule = (Schedule)e.Item;
		var from = SearchFromDateTPicker?.SelectedDate;
		var to = SearchToDatePicker?.SelectedDate;
		var applyDatesFilter = ApplyDatesFilterCheckBox?.IsChecked ?? false;
		var showOnlyForToday = IsTodayCheckBox?.IsChecked ?? false;

		var fitsByLessonType = schedule.View.LessonType.Contains(SearchStudentTextBox.Text);
		var fitsByDates = applyDatesFilter == false
		                  || (showOnlyForToday && schedule.ScheduledTime.IsToday())
		                  || schedule.ScheduledTime.IsBetween(from, to);
		var fitsByHeld = (_showHeld && schedule.IsHeld) || (_showNotHeld && !schedule.IsHeld);

		e.Accepted = fitsByLessonType && fitsByDates && fitsByHeld;
	}

	private void SetupColumns()
	{
		ScheduleViewDataGrid.Columns.Clear();

		const string view = $"{nameof(Schedule.View)}.";

		// | Дата-Время | Курс | Занятие | Примечание | Проведено |
		ScheduleViewDataGrid.AddTextColumn("ID", nameof(Schedule.Id), Visibility.Collapsed);
		ScheduleViewDataGrid.AddTextColumn("Дата-Время", view + nameof(ScheduleView.ScheduledTime));
		ScheduleViewDataGrid.AddTextColumn("Курс", view + nameof(ScheduleView.CourseTitle));
		ScheduleViewDataGrid.AddTextColumn("Занятие", view + nameof(ScheduleView.LessonType));
		ScheduleViewDataGrid.AddTextColumn("Примечание", view + nameof(ScheduleView.Note));
		ScheduleViewDataGrid.AddTextColumn("Проведено", view + nameof(ScheduleView.IsHeld));
	}

#endregion

	private void UploadButton_OnClick(object sender, RoutedEventArgs e) { }

	private void HeldButton_OnClick(object sender, RoutedEventArgs e) { }

	private void ScheduleLessonButton_OnClick(object sender, RoutedEventArgs e) { }

#region Update filters

	private void RadioButton_Click(object sender, RoutedEventArgs e)
	{
		var all = ShowAllRadioButton?.IsChecked ?? false;
		var onlyHeld = OnlyHeldRadioButton?.IsChecked ?? false;
		var onlyNotHeld = OnlyNotHeldRadioButton?.IsChecked ?? false;

		_showHeld = all || onlyHeld;
		_showNotHeld = all || onlyNotHeld;
		UpdateViewTable();
	}

	private void UpdateFrom_TextBox(object sender, TextChangedEventArgs e) => UpdateViewTable();

	private void UpdateFrom_CheckBox(object sender, RoutedEventArgs e) => UpdateViewTable();

	private void UpdateFrom_DatePicker(object? sender, SelectionChangedEventArgs e) => UpdateViewTable();

#endregion
}