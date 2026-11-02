using Border = System.Windows.Controls.Border;
using ScrollViewer = System.Windows.Controls.ScrollViewer;
using TextBox = System.Windows.Controls.TextBox;
using Timer = System.Timers.Timer;
using Button = System.Windows.Controls.Button;
using CheckBox = System.Windows.Controls.CheckBox;
using Popup = System.Windows.Controls.Primitives.Popup;
using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Threading;
using TextBlock = System.Windows.Controls.TextBlock;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;
using EleCho.WpfSuite.Controls;
using Potassium_UI_V2.Services;
using Potassium_UI_V2.Utils;

namespace Potassium_UI_V2.Views.MainWindow;

public partial class ScriptsFolder : UserControl
{
	[CompilerGenerated]
	private sealed class _c__DisplayClass7_0
	{
		public string ntrIAYaw4N;

		internal static _c__DisplayClass7_0 GRVUWtTU7PFCBXy2pPF;
public _c__DisplayClass7_0()
		{
			
			int num = 0;			switch (num)
			{
			case 0:
				break;
			}
		}

		// [DEOBFUSCATED] Control flow flattening detected (initial state: 1)
internal bool U6kIwSi9F9(string name)
	{
	int num = 1;
	int num2 = num;
	while (true)
	{
	switch (num2)
			{
			default:
				return default;
				case 1:
					if (false)
					{
						return true;
					}
					num2 = 0;					break;
				}
			}
		}
static _c__DisplayClass7_0()
	{
	}
internal static bool rsmcJOT960aW0DM3slQ()
		{
			return GRVUWtTU7PFCBXy2pPF == null;
		}
internal static _c__DisplayClass7_0 ERY7daTeSwl6oK6sMdE()
		{
			return GRVUWtTU7PFCBXy2pPF;
		}
internal static void DT0t3hT18fJh7T60Bbw()
		{
			}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _ScriptButton_Click_d__6 : IAsyncStateMachine
	{
		public int _state1;

		public AsyncVoidMethodBuilder _asyncBuilder;

		public object sender;

		public ScriptsFolder _this4;

		private TaskAwaiter<string> _awaiter_1;

		internal static object ybUGubTq53a63P72N9M;
public void MoveNext()
		{
			int num = 4;
			int num2 = num;
			int num3 = default(int);
			TaskAwaiter<string> awaiter = default(TaskAwaiter<string>);
			MainUI mainUI = default(MainUI);
			string text3 = default(string);
			Button button = default(Button);
			string text = default(string);
			string text2 = default(string);
			ScriptsFolder scriptsFolder = default(ScriptsFolder);
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 2:
					_state1 = -2;
					num2 = 1;					break;
				case 5:
					try
					{
						int num4;
						if (num3 == 0)
						{
							num4 = 14;
							goto IL_0078;
						}
						goto IL_0166;
						IL_0166:
						if (num3 != 1)
						{
							num4 = 25;							goto IL_0078;
						}
						goto IL_02a3;
						IL_0078:
						while (true)
						{
							switch (num4)
							{
							case 33:
								num3 = (_state1 = 1);
								num4 = 30;
								continue;
							case 18:
								awaiter = default;
								num4 = 10;
								continue;
							case 25:
								button = sender as Button;
								num4 = 15;
								continue;
							case 9:
								text = null as string;
								num4 = 2;
								continue;
							case 17:
							case 34:
								awaiter.GetResult();
								num4 = 1;								continue;
							case 28:
								_awaiter_1 = awaiter;
								num4 = 11;
								continue;
							case 3:
								_asyncBuilder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num4 = 23;
								continue;
							case 22:
								_awaiter_1 = default(TaskAwaiter<string>);
								num4 = 4;
								continue;
							case 27:
								goto end_IL_0063;
							case 13:
								return;
							case 30:
							{
								_awaiter_1 = awaiter;
								int num5 = 3;
								num4 = num5;
								continue;
							}
							case 26:
								if (awaiter.IsCompleted)
								{
									num4 = 35;
									continue;
								}
								goto case 32;
							case 24:
								goto IL_02a3;
							case 29:
								if (mainUI.tabsControl.currentWebView == null)
								{
									num4 = 16;
									continue;
								}
								goto case 7;
							case 2:
								if (false)
								{
									num4 = 27;									continue;
								}
								goto case 31;
							case 12:
								num3 = (_state1 = -1);
								num4 = 24;								continue;
							case 31:
								awaiter = default;
								num4 = 26;								continue;
							case 10:
								if (awaiter.IsCompleted)
								{
									num4 = 17;									continue;
								}
								goto case 33;
							case 6:
								if (mainUI != null)
								{
									num4 = 29;
									continue;
								}
								goto end_IL_0063;
							case 15:
								if (button == null)
								{
									num4 = 8;
									continue;
								}
								goto case 9;
							case 21:
							case 35:
								text2 = JsonSerializer.Serialize(awaiter.GetResult());
								num4 = 5;								continue;
							case 7:
								text3 = null;
								num4 = 18;
								continue;
							case 16:
								goto end_IL_0063;
							case 5:
								mainUI = null as MainUI;
								num4 = 5;								continue;
							case 19:
								_awaiter_1 = default(TaskAwaiter<string>);
								num4 = 12;
								continue;
							case 8:
								goto end_IL_0063;
							case 4:
								num3 = (_state1 = -1);
								num4 = 21;
								continue;
							case 32:
								num3 = (_state1 = 0);
								num4 = 28;								continue;
							case 23:
								return;
							case 14:
							case 20:
								awaiter = _awaiter_1;
								num4 = 22;								continue;
							case 11:
								_asyncBuilder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num4 = 13;								continue;
							case 1:
								goto end_IL_0063;
							}
							break;
						}
						goto IL_0166;
						IL_02a3:
						awaiter = _awaiter_1;
						num4 = 14;						goto IL_0078;
						end_IL_0063:;
					}
					catch (Exception ex)
					{
						int num6 = 2;						while (true)
						{
							switch (num6)
							{
							case 2:
								_state1 = -2;
								num6 = 0;								break;
							default:
								num6 = 0;								break;
							case 1:
								return;
							}
						}
					}
					goto case 2;
				case 4:
					num3 = _state1;
					num2 = 3;
					break;
				case 0:
					return;
				case 1:
					num2 = 0;					break;
				case 3:
					scriptsFolder = _this4;
					num2 = 5;					break;
				}
			}
		}

		/* IAsyncStateMachine\.MoveNext removed */
[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					num2 = 0;					break;
				case 0:
					return;
				}
			}
		}

		/* IAsyncStateMachine\.SetStateMachine removed */
static _ScriptButton_Click_d__6()
	{
	}
internal static object Q6CJ5kTBjPXCQte4sQj(int P_0)
		{
			return null;
		}
internal static bool J5N8mNTXsI29pjqi4Z8()
		{
			return ybUGubTq53a63P72N9M == null;
		}
internal static object qCyjIxTMOlhucWfL6gT()
		{
			return ybUGubTq53a63P72N9M;
		}
internal static void c75jA5TpVT6ON3yJ9Z7()
		{
			}
	}

								private bool x23WnlDZg8;

	internal static ScriptsFolder irijTyFeiH7bQwQk3Z9;

	public string? SelectedPid
	{
		get
		{
			return pidComboBox?.SelectedItem?.ToString();
		}
	}
public ScriptsFolder()
	{
		InitializeComponent();
	}

private void NycWKQvxh1(object P_0, RoutedEventArgs P_1)
	{
		try
		{
			pFdWlU1H9i();
			var window = Window.GetWindow(this);
			if (window is MainUI mainUI && mainUI._webSocketServer != null)
			{
				// 设置 pidComboBox Popup 向上弹出
				pidComboBox.IsEnabled = true;
				var popup = pidComboBox.Template.FindName("PART_Popup", pidComboBox) as System.Windows.Controls.Primitives.Popup;
				if (popup != null)
				{
					popup.Placement = System.Windows.Controls.Primitives.PlacementMode.Top;
					popup.VerticalOffset = -4;
				}

				mainUI._webSocketServer.onClientListChanged += Yp7WLA7yEK;
				Yp7WLA7yEK();
			}
		}
		catch { }
	}

	private void Yp7WLA7yEK()
	{
		try
		{
			var window = Window.GetWindow(this);
			if (window is not MainUI mainUI || mainUI._webSocketServer == null) return;

			var connectedPids = mainUI._webSocketServer.GetConnectedPids();
			Dispatcher.Invoke(() =>
			{
				pidComboBox.Items.Clear();
				foreach (var pid in connectedPids)
				{
					pidComboBox.Items.Add(pid);
				}
				if (connectedPids.Count > 1)
				{
					pidComboBox.Items.Add("All");
				}
				if (pidComboBox.Items.Count > 0 && pidComboBox.SelectedIndex < 0)
				{
					pidComboBox.SelectedIndex = 0;
				}
			});
		}
		catch { }
	}
private void NxDWuYAoc5(object P_0, TextChangedEventArgs P_1)
	{
		pFdWlU1H9i(searchBox?.Text ?? "");
	}
[AsyncStateMachine(typeof(_ScriptButton_Click_d__6))]
	private void HvGWfpI8OG(object P_0, RoutedEventArgs P_1)
	{
		try
		{
			if (P_0 is not Button btn || btn.Tag is not string filePath) return;

			var window = Window.GetWindow(this);
			if (window is not MainUI mainUI) return;
			if (mainUI.tabsControl?.currentWebView == null) return;

			string content = System.IO.File.Exists(filePath) ? System.IO.File.ReadAllText(filePath) : "";
			string escaped = Newtonsoft.Json.JsonConvert.SerializeObject(content);
			_ = mainUI.tabsControl.currentWebView.ExecuteScriptAsync($"SetText({escaped})");
		}
		catch { }
	}
private void pFdWlU1H9i(string P_0 = "")
	{
		try
		{
			scriptsContainer.Children.Clear();

			string appData = System.IO.Path.Combine(
				Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Potassium", "scripts");
			if (!System.IO.Directory.Exists(appData))
			{
				System.IO.Directory.CreateDirectory(appData);
				return;
			}

			var files = System.IO.Directory.GetFiles(appData, "*.lua", SearchOption.AllDirectories);
			foreach (var file in files)
			{
				string name = System.IO.Path.GetFileNameWithoutExtension(file);
				if (!string.IsNullOrEmpty(P_0) && !name.Contains(P_0, StringComparison.OrdinalIgnoreCase))
					continue;

				var btn = new Button
				{
					Style = (Style)FindResource("ScriptFileButtonStyle"),
					Content = name,
					Tag = file,
					Margin = new Thickness(5)
				};
				btn.Click += HvGWfpI8OG;
				scriptsContainer.Children.Add(btn);
			}
		}
		catch { }
	}
/* InitializeComponent provided by .g.cs */
/* IComponentConnector\.Connect removed */
[CompilerGenerated]
	private void jTEWHPplMD()
	{
		int num = 11;
		List<string> connectedPids = default(List<string>);
		MainUI mainUI = default(MainUI);
		bool flag2 = default(bool);
		string text = default(string);
		List<string>.Enumerator enumerator = default(List<string>.Enumerator);
		string current = default(string);
		bool flag = default(bool);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num3;
				switch (num2)
				{
				case 12:
					connectedPids = mainUI._webSocketServer.GetConnectedPids();
					num2 = 18;					continue;
				case 3:
					if (flag2)
					{
						num2 = 1;						continue;
					}
					if (text != null)
					{
						num2 = 5;
						continue;
					}
					goto IL_0336;
				case 16:
					try
					{
						while (true)
						{
							IL_015c:
							int num4;
							if (!enumerator.MoveNext())
							{
								num4 = 2;								goto IL_00f3;
							}
							goto IL_010d;
							IL_010d:
							current = enumerator.Current;
							num4 = 3;
							goto IL_00f3;
							IL_00f3:
							while (true)
							{
								switch (num4)
								{
								case 1:
									break;
								case 3:
									num4 = 0;									continue;
								default:
									goto IL_015c;
								case 2:
									goto end_IL_015c;
								}
								break;
							}
							goto IL_010d;
							continue;
							end_IL_015c:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
						int num5 = 0;						switch (num5)
						{
						case 0:
							break;
						}
					}
					goto case 3;
				case 7:
					num2 = 5;					continue;
				case 19:
					return;
				case 17:
					if (text != null)
					{
						num2 = 0;						continue;
					}
					num3 = 1;
					break;
				default:
					num3 = (false ? 1 : 0);
					break;
				case 15:
					num2 = 1;					continue;
				case 8:
					return;
				case 13:
					return;
				case 20:
					enumerator = connectedPids.GetEnumerator();
					num2 = 16;
					continue;
				case 2:
					num2 = 9;					continue;
				case 10:
					if (mainUI == null)
					{
						num2 = 2;					}
					else
					{
						flag = !mFV1EmFppm2SwB1Mc9K(mainUI._webSocketServer._clients);
						num2 = 12;
					}
					continue;
				case 5:
					if (false)
					{
						num2 = 7;
						continue;
					}
					goto IL_0336;
				case 9:
					if (flag)
					{
						num2 = 3;					}
					else
					{
						num2 = 15;
					}
					continue;
				case 4:
					return;
				case 6:
					num2 = 8;					continue;
				case 18:
					goto end_IL_0019;
				case 1:
					num2 = 19;
					continue;
				case 11:
					mainUI = null as MainUI;
					num2 = 10;					continue;
				case 14:
					return;
					IL_0336:
					num2 = 11;					continue;
				}
				flag2 = (byte)num3 != 0;
				num2 = 2;				continue;
				end_IL_0019:
				break;
			}
			text = null as string;
			num = 17;
		}
	}
static ScriptsFolder()
	{
		}
internal static bool qhdxjBF1sxqWnB5p0U8()
	{
		return irijTyFeiH7bQwQk3Z9 == null;
	}
internal static ScriptsFolder UM1HlDFqMCK7wTDwxYr()
	{
		return irijTyFeiH7bQwQk3Z9;
	}
internal static void mVuRoXFX04CIed4Uapk()
	{
		
	}
internal static void H16kipFMlChqYv1ksXZ()
	{
		}
internal static object CYnEmBFBIC7eV1cHLx8(int P_0)
	{
		return null;
	}
internal static bool mFV1EmFppm2SwB1Mc9K(object P_0)
	{
		return ((ConcurrentDictionary<string, ConnectedClient>)P_0).IsEmpty;
	}
internal static int Si8KyxFCZKF0N3NBHI0(object P_0)
	{
		return ((List<string>)P_0).Count;
	}
}
