using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Threading;

using Potassium_UI_V2.Services;

namespace Potassium_UI_V2;

public partial class App : Application
{
	internal static App stLo7ZCNkDBlkHTKQcv;

	protected override void OnStartup(StartupEventArgs e)
	{
		DispatcherUnhandledException += App_DispatcherUnhandledException;
		AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
		try
		{
			ThemeManager.Initialize();
		}
		catch { }
		base.OnStartup(e);
		try
		{
			var login = new Potassium_UI_V2.Views.Login.Login();
			login.Show();
		}
		catch { }
	}

	private void App_DispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
	{
		e.Handled = true;
	}

	private void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
	{
	}

	public App()
	{
	}

	internal static void _InitThemeManager()
	{
		ThemeManager.Initialize();
	}
}
