﻿using System.Windows;
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
		var studentsViewSource = new CollectionViewSource
		{
			Source = DataBaseConnection.Instance.Observe<Schedule>(),
		};

		studentsViewSource.Filter += FilterTable;
		ScheduleViewDataGrid.ItemsSource = studentsViewSource.View;
	}

	private void FilterTable(object sender, FilterEventArgs e) { }

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

	private void RadioButton_Checked(object sender, RoutedEventArgs e)
	{
		var all = ShowAllRadioButton.IsChecked!.Value;
		var onlyHeld = OnlyHeldRadioButton.IsChecked ?? false;
		var onlyNotHeld = OnlyNotHeldRadioButton.IsChecked ?? false;

		_showHeld = all || onlyHeld;
		_showNotHeld = all || onlyNotHeld;
	}
}