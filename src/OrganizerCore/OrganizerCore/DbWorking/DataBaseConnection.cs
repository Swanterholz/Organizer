﻿using System;
using System.Collections.ObjectModel;
using Microsoft.EntityFrameworkCore;

namespace Organizer.DbWorking;

public class DataBaseConnection
{
	private static DataBaseConnection? _instance;
	private ApplicationContext? _currentContext;

	private DataBaseConnection() { }

	public static DataBaseConnection Instance => _instance ??= new DataBaseConnection();

	public ApplicationContext CurrentContext => _currentContext ?? throw new NullReferenceException();

	public ObservableCollection<T> Observable<T>()
		where T : class
		=> CurrentContext.GetTable<T>().Local.ToObservableCollection();

	public void OpenDataBase()
	{
		_currentContext = new ApplicationContext();
		_currentContext.Database.Migrate();
		_currentContext.Database.EnsureCreated();

		_currentContext.TypesOfLessons.Load();
		_currentContext.Courses.Load();
		_currentContext.Topics.Load();
		_currentContext.Lessons.Load();
	}
}