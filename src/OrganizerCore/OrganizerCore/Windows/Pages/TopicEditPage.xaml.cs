﻿using System.Collections.Generic;
using System.Linq;
using System.Windows;
using OrganizerCore.DbWorking;
using OrganizerCore.Model;
using OrganizerCore.Tools.Extensions;

namespace OrganizerCore.Windows.Pages;

public partial class TopicEditPage
{
	private readonly Topic _topic;

	public TopicEditPage(Topic topic)
	{
		_topic = topic;

		InitializeComponent();
	}

	private static ApplicationContext Context => DataBaseConnection.Instance.CurrentContext;

	private void Page_OnLoaded(object sender, RoutedEventArgs e)
	{
		CourseTitleTextBox.Text = _topic.Course.Title;
		TitleTextBox.Text = _topic.Title;
		LessonsDataGrid.ItemsSource = Context.Lessons.Where((l) => l.Topic == _topic).ToList();

		SetupLessonsTable();
	}

	private void SetupLessonsTable()
	{
		LessonsDataGrid.Columns.Clear();

		LessonsDataGrid.AddTextColumn("ID", nameof(Lesson.Id), Visibility.Collapsed);
		LessonsDataGrid.AddTextColumn("Номер занятия", nameof(Lesson.Number));
		LessonsDataGrid.AddComboBoxColumn
		(
			header: "Вид",
			binding: nameof(Lesson.Type),
			itemsSource: TypesOfLessons,
			displayMemberPath: nameof(TypeOfLesson.Title),
			selectedValuePath: nameof(TypeOfLesson.Id)
		);

		LessonsDataGrid.AddTextColumn("Количество часов", nameof(Lesson.HoursAmount));
	}

	private static IEnumerable<TypeOfLesson> TypesOfLessons
		=> DataBaseConnection.Instance.Observable<TypeOfLesson>();

	private void EditLessonsTypeButton_OnClick(object sender, RoutedEventArgs e)
		=> NavigationService!.Navigate(new TypesOfLessonsListPage());

	private void OkButton_OnClick(object sender, RoutedEventArgs e) => NavigationService!.GoBack();

	private void TitleTextBox_OnLostFocus(object sender, RoutedEventArgs e)
	{
		_topic.Title = TitleTextBox.Text;
		Context.SaveChanges();
	}
}