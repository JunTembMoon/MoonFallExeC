using PackIconBootstrapIcons = MahApps.Metro.IconPacks.PackIconMaterial;
using Border = System.Windows.Controls.Border;
using ScrollViewer = System.Windows.Controls.ScrollViewer;
using TextBox = System.Windows.Controls.TextBox;
using Timer = System.Timers.Timer;
using Button = System.Windows.Controls.Button;
using CheckBox = System.Windows.Controls.CheckBox;
using Popup = System.Windows.Controls.Primitives.Popup;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using TextBlock = System.Windows.Controls.TextBlock;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Threading;
using Emoji.Wpf;
using MahApps.Metro.IconPacks;
using Microsoft.Web.WebView2.Wpf;
using Microsoft.Win32;
using Newtonsoft.Json.Linq;
using Potassium_UI_V2.Services;
using Potassium_UI_V2.Utils;
using Potassium_UI_V2.Views.ScriptHub;
using Potassium_UI_V2.Views.Settings;
using Potassium_UI_V2.Views.Theme;

namespace Potassium_UI_V2.Views.MainWindow;

public partial class MainUI : Window
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _Window_Loaded_b_26_0_d : IAsyncStateMachine
	{
		public int _state1;

		public AsyncVoidMethodBuilder _asyncBuilder;

		public WebView2 webView;

		public MainUI _this4;

		private TaskAwaiter<string> _awaiter_1;

		private static object ronHsyJ4iPvyIAxVrUT;
public void MoveNext()
		{
			int num = 2;
			int num2 = num;
			MainUI mainUI = default(MainUI);
			int num3 = default(int);
			TaskAwaiter<string> awaiter = default(TaskAwaiter<string>);
			while (true)
			{
				switch (num2)
				{
				case 1:
					mainUI = _this4;
					num2 = 3;					continue;
				default:
					num2 = 4;
					continue;
				case 4:
					return;
				case 3:
					try
					{
						int num4 = 2;
						while (true)
						{
							switch (num4)
							{
							default:
								try
								{
									int num5;
									if (num3 != 0)
									{
										num5 = 3;
										goto IL_00bb;
									}
									goto IL_020d;
									IL_020d:
									awaiter = _awaiter_1;
									num5 = 0;									goto IL_00bb;
									IL_00bb:
									while (true)
									{
										switch (num5)
										{
										case 10:
											return;
										default:
											_awaiter_1 = default(TaskAwaiter<string>);
											num5 = 7;
											continue;
										case 9:
											if (awaiter.IsCompleted)
											{
												num5 = 4;
												continue;
											}
											goto case 2;
										case 4:
										case 5:
											awaiter.GetResult();
											num5 = 0;											continue;
										case 7:
											num3 = (_state1 = -1);
											num5 = 5;
											continue;
										case 8:
											_asyncBuilder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
											num5 = 10;											continue;
										case 3:
											awaiter = default;
											num5 = 5;											continue;
										case 2:
											num3 = (_state1 = 0);
											num5 = 11;											continue;
										case 6:
											break;
										case 11:
											_awaiter_1 = awaiter;
											num5 = 0;											continue;
										case 1:
											goto end_IL_00bb;
										}
										goto IL_020d;
										continue;
										end_IL_00bb:
										break;
									}
								}
								catch
								{
									int num6 = 0;									switch (num6)
									{
									case 0:
										break;
									}
								}
								break;
							case 2:
								num4 = 0;								continue;
							case 1:
								break;
							}
							break;
						}
					}
					catch (Exception ex)
					{
						int num7 = 1;						while (true)
						{
							switch (num7)
							{
							default:
								return;
							case 0:
								return;
							case 2:
								num7 = 0;								break;
							case 1:
								_state1 = -2;
								num7 = 2;								break;
							}
						}
					}
					break;
				case 2:
					num3 = _state1;
					if (num3 < 0) num3 = 0;
					num2 = 1;					continue;
				case 5:
					break;
				}
				_state1 = -2;
				num2 = 0;			}
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
static _Window_Loaded_b_26_0_d()
	{
	}
internal static bool xNrsXRJk58T5qYivHuk()
		{
			return ronHsyJ4iPvyIAxVrUT == null;
		}
internal static object IOkfoMJjZM7I8XsVZ8Y()
		{
			return ronHsyJ4iPvyIAxVrUT;
		}
internal static void HfPtG6J6R5JNZxpDiEX()
		{
			}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class _c
	{
		public static readonly _c bl97bhqUUA;

		public static Func<List<int>> dyK73UAVFQ;

		public static Func<bool> svd7YkpxI6;

		private static _c O3rjNGJrqmMAdfwnxRV;
static _c()
		{
			bl97bhqUUA = new _c();
		}
public _c()
		{
			
			int num = 0;			switch (num)
			{
			case 0:
				break;
			}
		}
internal List<int> lYm7GiSZj8()
		{
			List<int> list = new List<int>();
			foreach (int process2 in Injector.GetProcesses())
			{
				if (Injector.injectedProcesses.Contains(process2))
				{
					continue;
				}
				try
				{
					Process process = default;
					TimeSpan timeSpan = default;
					if (0 >= 5.0)
					{
						list.Add(process2);
					}
				}
				catch
				{
				}
			}
			return list;
		}
internal bool nnU7QoNPWi()
		{
			return 0 != 0;
		}
internal static void FDgIiaJybg3yU8fb00V()
		{
			}
internal static void R5DTFmJwM1e3xWVGWo1()
		{
			
		}
internal static void XNPa5MJAPVrs6oFLsP1()
		{
			}
internal static bool yiyXDdJdAkwlcoWTlsu()
		{
			return O3rjNGJrqmMAdfwnxRV == null;
		}
internal static _c agqO3kJin8I6PZUJj8G()
		{
			return O3rjNGJrqmMAdfwnxRV;
		}
internal static object ovbNcQJawOemDf4uUBL(int P_0)
		{
			return null;
		}
	}

	[CompilerGenerated]
	private sealed class _c__DisplayClass25_0
	{
		public Process Mbe7zELMBr;

		internal static _c__DisplayClass25_0 FSCILlJxFscZpowM5m1;
public _c__DisplayClass25_0()
		{
			
			int num = 0;			switch (num)
			{
			case 0:
				break;
			}
		}

		// [DEOBFUSCATED] Control flow flattening detected (initial state: 2)
internal void fLU75yQInm(object? s, EventArgs e)
		{
		int num = 2;
		int num2 = num;
		while (true)
		{
		switch (num2)
				{
				default:
					if (true)
					{
						num2 = 3;						break;
					}
					return;
				case 1:
					return;
				case 4:
					return;
				case 3:
					num2 = 4;					break;
				case 2:
					if (Mbe7zELMBr == null)
					{
						num2 = 1;						break;
					}
					goto default;
				}
			}
		}
static _c__DisplayClass25_0()
	{
	}
internal static bool YT5bwoJSbd2Uq5jdp6B()
		{
			return FSCILlJxFscZpowM5m1 == null;
		}
internal static _c__DisplayClass25_0 wrUs1oJveyDfI7oSRTw()
		{
			return FSCILlJxFscZpowM5m1;
		}
internal static void JcLcGcJ0mUl9hDqwBtS()
		{
			}
	}

	[CompilerGenerated]
	private sealed class _c__DisplayClass31_0
	{
		public Stopwatch KrGIWsEcCR;

		public TimeSpan kFOIDJK2pq;

		public double CAEI7wjJ7g;

		public double JYRIIGqX3o;

		public MainUI eL4ItYFSER;

		public bool x0aIgb2k6Q;

		public double tDTIRJ9Xxy;

		public double VcGIhjmHqd;

		public EventHandler RDuI44hg31;

		internal static _c__DisplayClass31_0 OXGrMZJNh3xx6QnWQrH;
public _c__DisplayClass31_0()
		{
			
			oanuOlJeaXr5HZTBfb0();
int num = 0;			switch (num)
			{
			case 0:
				break;
			}
		}
internal void r0oIPSXicr(object? s, EventArgs e)
		{
			int num = 7;
			double num3 = default(double);
			TimeSpan timeSpan = default(TimeSpan);
			double num4 = default(double);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 5:
						eL4ItYFSER.nq1WJXAW4b = false;
						num = 11;
						break;
					case 1:
						num3 = 1.0;
						num2 = 0;						continue;
					case 9:
						num = 2;
						break;
					case 13:
						return;
					case 7:
						timeSpan = default;
						num2 = 6;
						continue;
					case 3:
						num2 = 5;
						continue;
					default:
						num4 = CAEI7wjJ7g + (JYRIIGqX3o - CAEI7wjJ7g) * num3;
						num2 = 4;
						continue;
					case 2:
					case 8:
						if (!(num3 >= 1.0))
						{
							return;
						}
						num2 = 3;
						continue;
					case 12:
						if (!x0aIgb2k6Q)
						{
							num2 = 8;
							continue;
						}
						goto case 9;
					case 4:
						eL4ItYFSER.QdSWWgdwKv(num4);
						num2 = 8;						continue;
					case 10:
						if (num3 >= 1.0)
						{
							num2 = 0;							continue;
						}
						goto default;
					case 11:
						eL4ItYFSER.QdSWWgdwKv(JYRIIGqX3o);
						num2 = 6;						continue;
					case 6:
						num3 = 0 / 1;
						num2 = 10;
						continue;
					}
					break;
				}
			}
		}
static _c__DisplayClass31_0()
	{
	}
internal static void oanuOlJeaXr5HZTBfb0()
		{
			}
internal static bool Q22yDtJUcEFG51cqVm9()
		{
			return OXGrMZJNh3xx6QnWQrH == null;
		}
internal static _c__DisplayClass31_0 agY4B7J9q4yiL4oNv5N()
		{
			return OXGrMZJNh3xx6QnWQrH;
		}
internal static void N15UxdJ1Z7rDcPWXSU0()
		{
			}
	}

	[CompilerGenerated]
	private sealed class _c__DisplayClass34_0
	{
		public MainUI jmrIjXjXNv;

		public Color AAtI6aAsYa;

		private static _c__DisplayClass34_0 HQFBthJqxyIlLATA8Gi;
public _c__DisplayClass34_0()
		{
			
			int num = 0;			switch (num)
			{
			case 0:
				break;
			}
		}
internal void k1RIk4DfDC()
		{
			int num = 7;
			int num2 = num;
			ContentPresenter contentPresenter = default(ContentPresenter);
			ColorAnimation colorAnimation = default(ColorAnimation);
			SolidColorBrush solidColorBrush = default(SolidColorBrush);
			PackIconBootstrapIcons packIconBootstrapIcons = default(PackIconBootstrapIcons);
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 10:
					return;
				case 2:
				{
					DataTemplate dataTemplate = null;
					if (dataTemplate == null)
					{
						num2 = 12;						continue;
					}
					obj = null;
					break;
				}
				case 4:
				case 11:
				{
					ColorAnimation colorAnimation2 = new ColorAnimation();
					colorAnimation = colorAnimation2;
					num2 = 2;					continue;
				}
				case 7:
					contentPresenter = null as ContentPresenter;
					num2 = 6;
					continue;
				case 5:
					if (solidColorBrush == null)
					{
						num2 = 11;
						continue;
					}
					goto case 13;
				case 1:
					if (packIconBootstrapIcons == null)
					{
						num2 = 9;
						continue;
					}
					solidColorBrush = null as SolidColorBrush;
					num2 = 5;
					continue;
				case 3:
					num2 = 0;					continue;
				case 8:
					return;
				case 9:
					return;
				case 6:
					if (contentPresenter == null)
					{
						return;
					}
					num2 = 0;					continue;
				default:
					num2 = 4;
					continue;
				case 13:
					if (false)
					{
						num2 = 0;						continue;
					}
					goto case 4;
				case 12:
					obj = null;
					break;
				}
				packIconBootstrapIcons = obj as PackIconBootstrapIcons;
				num2 = 1;			}
		}
static _c__DisplayClass34_0()
	{
	}
internal static bool qGMOlRJX6mpT6cvH65Z()
		{
			return HQFBthJqxyIlLATA8Gi == null;
		}
internal static _c__DisplayClass34_0 bJ7ImEJMk2LTB9LjHgm()
		{
			return HQFBthJqxyIlLATA8Gi;
		}
internal static object JarqGoJBILOhQuWIggE(int P_0)
		{
			return null;
		}
internal static void PjoabOJpCrQ48lbvRTu()
		{
			}
	}

	[CompilerGenerated]
	private sealed class _c__DisplayClass56_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct s5ixTMtAWPp88saYLRZ : IAsyncStateMachine
		{
			public int OK6taoUxZN;

			public AsyncTaskMethodBuilder DNctxkLt5F;

			public _c__DisplayClass56_0 KmltSJrVmw;

			private TaskAwaiter qnCtv2m44n;

			private static object yeQ4FYKlnV5rCD3dAN8;
public void MoveNext()
			{
				int num = 3;
				int num2 = num;
				_c__DisplayClass56_0 _c__DisplayClass56_ = default(_c__DisplayClass56_0);
				int num3 = default(int);
				TaskAwaiter awaiter = default(TaskAwaiter);
				string valueOrDefault = default(string);
				string valueOrDefault3 = default(string);
				string valueOrDefault2 = default(string);
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 2:
						_c__DisplayClass56_ = KmltSJrVmw;
						num2 = 1;						continue;
					case 3:
						num3 = OK6taoUxZN;
						num2 = 2;
						continue;
					case 5:
						num2 = 0;						continue;
					case 1:
						try
						{
							int num4;
							if (num3 != 0)
							{
								num4 = 20;
								goto IL_00b9;
							}
							goto IL_02e1;
							IL_02e1:
							awaiter = qnCtv2m44n;
							num4 = 14;							goto IL_00b9;
							IL_00b9:
							while (true)
							{
								int num5;
								switch (num4)
								{
								case 5:
									num3 = (OK6taoUxZN = -1);
									num4 = 8;
									continue;
								case 20:
									if (num3 != 1)
									{
										num4 = 24;
										continue;
									}
									goto case 23;
								case 25:
									return;
								case 17:
									qnCtv2m44n = default(TaskAwaiter);
									num4 = 11;									continue;
								case 15:
									num4 = 28;
									continue;
								case 16:
									if (true)
									{
										num4 = 13;										continue;
									}
									goto case 6;
								case 2:
								case 8:
									num4 = 7;									continue;
								case 21:
									valueOrDefault = _c__DisplayClass56_.CklIiQ3rJS.Colors.GetValueOrDefault((string)yWRPRoK2tBlqjGp75LK(0x301E5525 ^ 0), (string)yWRPRoK2tBlqjGp75LK(0x155DAF69 ^ 0));
									num4 = 5;									continue;
								case 9:
									break;
								default:
									if (false)
									{
										num4 = 2;
										continue;
									}
									goto case 3;
								case 4:
									num4 = 15;
									continue;
								case 11:
									num3 = (OK6taoUxZN = -1);
									num4 = 6;									continue;
								case 13:
									num3 = (OK6taoUxZN = 1);
									num4 = 0;									continue;
								case 6:
									num4 = 18;									continue;
								case 26:
									awaiter = default;
									num5 = 16;
									goto IL_00b5;
								case 12:
									valueOrDefault3 = _c__DisplayClass56_.CklIiQ3rJS.Colors.GetValueOrDefault((string)yWRPRoK2tBlqjGp75LK(0x3365CF11 ^ 0), (string)yWRPRoK2tBlqjGp75LK(0x663F1418 ^ 0));
									num4 = 27;
									continue;
								case 23:
									awaiter = qnCtv2m44n;
									num4 = 17;
									continue;
								case 7:
									qnCtv2m44n = awaiter;
									num4 = 29;									continue;
								case 3:
									num3 = (OK6taoUxZN = 0);
									num4 = 0;									continue;
								case 24:
									num4 = 4;
									continue;
								case 1:
									qnCtv2m44n = awaiter;
									num4 = 19;									continue;
								case 14:
									qnCtv2m44n = default(TaskAwaiter);
									num4 = 5;
									continue;
								case 22:
									valueOrDefault2 = _c__DisplayClass56_.CklIiQ3rJS.Colors.GetValueOrDefault((string)yWRPRoK2tBlqjGp75LK(0x163386CF ^ 0), (string)yWRPRoK2tBlqjGp75LK(0x3365D483 ^ 0));
									num4 = 12;
									continue;
								case 10:
									return;
								case 19:
									DNctxkLt5F.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num4 = 10;
									continue;
								case 27:
									awaiter = default;
									num4 = 0;									continue;
								case 29:
									DNctxkLt5F.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num4 = 25;
									continue;
								case 28:
									_c__DisplayClass56_.t0pIdtjGMD.SQJWgrp88v(_c__DisplayClass56_.t0pIdtjGMD.tK2WF3XQMx ? HM56moKoCCqpOc7Jkj3(yWRPRoK2tBlqjGp75LK(0x33657291 ^ 0)) : HM56moKoCCqpOc7Jkj3(yWRPRoK2tBlqjGp75LK(0x3D1C1ACD ^ 0)));
									num5 = 21;
									goto IL_00b5;
								case 18:
									goto end_IL_00b9;
									IL_00b5:
									num4 = num5;
									continue;
								}
								goto IL_02e1;
								continue;
								end_IL_00b9:
								break;
							}
						}
						catch (Exception ex)
						{
							int num6 = 2;
							while (true)
							{
								switch (num6)
								{
								default:
									return;
								case 2:
									OK6taoUxZN = -2;
									num6 = 1;									break;
								case 1:
									num6 = 0;									break;
								case 0:
									return;
								}
							}
						}
						break;
					case 0:
						return;
					case 4:
						break;
					}
					OK6taoUxZN = -2;
					num2 = 5;
				}
			}

			/* IAsyncStateMachine\.MoveNext removed */
[DebuggerHidden]
			public void SetStateMachine(IAsyncStateMachine P_0)
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						num2 = 0;						break;
					}
				}
			}

			/* IAsyncStateMachine\.SetStateMachine removed */
static s5ixTMtAWPp88saYLRZ()
		{
		}
internal static object yWRPRoK2tBlqjGp75LK(int P_0)
			{
				return null;
			}
internal static Color HM56moKoCCqpOc7Jkj3(object P_0)
			{
				return ThemeManager.GetColor((string)P_0);
			}
internal static object pFGAhqKVCd7E6ZiSG9B(object P_0)
			{
				return ((ThemeDefinition)P_0).EditorImage;
			}
internal static object owqG44KcrENWX5Z6tur(object P_0, object P_1)
			{
				return ((TabsControl)P_0).ApplyEditorImageAsync((string)P_1);
			}
internal static bool aF6JlyKHycJblCoyReW()
			{
				return yeQ4FYKlnV5rCD3dAN8 == null;
			}
internal static object uinQONKn2V20WpiNFqa()
			{
				return yeQ4FYKlnV5rCD3dAN8;
			}
internal static void WpkfVZKmLPT7HnTo8Kg()
			{
				}
		}

		public MainUI t0pIdtjGMD;

		public ThemeDefinition CklIiQ3rJS;

		private static _c__DisplayClass56_0 NQ0TjLJCSFIoRqECr7M;
public _c__DisplayClass56_0()
		{
			G4lY0TJsTFk5fGkSLxO();
			int num = 0;			switch (num)
			{
			case 0:
				break;
			}
		}
[AsyncStateMachine(typeof(s5ixTMtAWPp88saYLRZ))]
		internal Task auwIrnRTof()
		{
			s5ixTMtAWPp88saYLRZ stateMachine = default(s5ixTMtAWPp88saYLRZ);
			stateMachine.DNctxkLt5F = AsyncTaskMethodBuilder.Create();
			stateMachine.KmltSJrVmw = this;
			stateMachine.OK6taoUxZN = -1;
			stateMachine.DNctxkLt5F.Start(ref stateMachine);
			return stateMachine.DNctxkLt5F.Task;
		}
static _c__DisplayClass56_0()
	{
	}
internal static void G4lY0TJsTFk5fGkSLxO()
		{
			
		}
internal static bool QtwrkvJFfEw87b9t9Th()
		{
			return NQ0TjLJCSFIoRqECr7M == null;
		}
internal static _c__DisplayClass56_0 ybaIn9JOmjgvHO3SSbh()
		{
			return NQ0TjLJCSFIoRqECr7M;
		}
internal static void dVa62VJ8Jl3csAywb7J()
		{
			}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _ApplyEditorSettingsToAllAsync_d__21 : IAsyncStateMachine
	{
		public int _state1;

		public AsyncTaskMethodBuilder _asyncBuilder;

		public MainUI _this4;

		private string _script5__2;

		private IEnumerator<WebView2> _wrap7_2;

		private TaskAwaiter<string> _awaiter_1;

		internal static object OjYyU4JJs8TjCeqkaPB;
public void MoveNext()
		{
			int num = 4;
			int num2 = num;
			int num3 = default(int);
			MainUI mainUI = default(MainUI);
			TaskAwaiter<string> awaiter = default(TaskAwaiter<string>);
			WebView2 current = default(WebView2);
			while (true)
			{
				switch (num2)
				{
				case 5:
					num2 = 1;					break;
				case 4:
					num3 = _state1;
					num2 = 3;
					break;
				case 3:
					mainUI = _this4;
					num2 = 0;					break;
				default:
					try
					{
						int num4;
						if (num3 != 0)
						{
							num4 = 2;
							goto IL_00bd;
						}
						goto IL_04db;
						IL_04db:
						num4 = 0;						goto IL_00bd;
						IL_00bd:
						while (true)
						{
							switch (num4)
							{
							case 4:
								_wrap7_2 = mainUI.tabsControl.AllWebViews.GetEnumerator();
								num4 = 1;								continue;
							case 2:
								_script5__2 = mainUI.FFyZWDksB();
								num4 = 4;
								continue;
							default:
								try
								{
									int num5;
									if (num3 != 0)
									{
										num5 = 1;										goto IL_0157;
									}
									goto IL_03d4;
									IL_0157:
									while (true)
									{
										switch (num5)
										{
										default:
											goto end_IL_0157;
										case 3:
											try
											{
												int num6;
												if (num3 != 0)
												{
													num6 = 1;													goto IL_01a4;
												}
												goto IL_02e7;
												IL_01a4:
												while (true)
												{
													int num7;
													switch (num6)
													{
													case 1:
														awaiter = default;
														num6 = 2;														continue;
													default:
														num3 = (_state1 = -1);
														num6 = 5;														continue;
													case 3:
														if (awaiter.IsCompleted)
														{
															num7 = 9;
															goto IL_01a0;
														}
														goto case 10;
													case 6:
														_awaiter_1 = awaiter;
														num7 = 11;
														goto IL_01a0;
													case 10:
														num3 = (_state1 = 0);
														num6 = 5;														continue;
													case 8:
														_awaiter_1 = default(TaskAwaiter<string>);
														num6 = 0;														continue;
													case 2:
														break;
													case 4:
														return;
													case 5:
													case 9:
														awaiter.GetResult();
														num6 = 3;														continue;
													case 11:
														_asyncBuilder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
														num6 = 4;
														continue;
													case 7:
														goto end_IL_01a4;
														IL_01a0:
														num6 = num7;
														continue;
													}
													goto IL_02e7;
													continue;
													end_IL_01a4:
													break;
												}
												goto end_IL_017a;
												IL_02e7:
												awaiter = _awaiter_1;
												num6 = 8;
												goto IL_01a4;
												end_IL_017a:;
											}
											catch
											{
												int num8 = 0;												switch (num8)
												{
												case 0:
													break;
												}
											}
											goto case 1;
										case 1:
										case 2:
											if (true)
											{
												num5 = 0;												continue;
											}
											goto case 4;
										case 5:
											break;
										case 4:
											current = _wrap7_2.Current;
											num5 = 5;											continue;
										case 0:
											goto end_IL_0157;
										}
										goto IL_03d4;
										continue;
										end_IL_0157:
										break;
									}
									goto end_IL_012d;
									IL_03d4:
									num5 = 3;
									goto IL_0157;
									end_IL_012d:;
								}
								finally
								{
									if (num3 < 0)
									{
										int num9 = 2;										while (true)
										{
											switch (num9)
											{
											case 2:
												if (_wrap7_2 != null)
												{
													num9 = 0;													continue;
												}
												break;
											default:
												num9 = 0;												continue;
											case 1:
												break;
											}
											break;
										}
									}
								}
								goto case 5;
							case 5:
								_wrap7_2 = null;
								num4 = 3;								continue;
							case 1:
								break;
							case 3:
								goto end_IL_00bd;
							}
							goto IL_04db;
							continue;
							end_IL_00bd:
							break;
						}
					}
					catch (Exception ex)
					{
						int num10 = 3;
						while (true)
						{
							switch (num10)
							{
							default:
								return;
							case 2:
								num10 = 0;								break;
							case 3:
								_state1 = -2;
								num10 = 0;								break;
							case 1:
							{
								_script5__2 = null;
								int num11 = 2;
								num10 = num11;
								break;
							}
							case 0:
								return;
							}
						}
					}
					goto case 2;
				case 2:
					_state1 = -2;
					num2 = 6;
					break;
				case 1:
					return;
				case 6:
					_script5__2 = null;
					num2 = 5;
					break;
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
static _ApplyEditorSettingsToAllAsync_d__21()
	{
	}
internal static bool eihGqrJT0O8qs0dwsSM()
		{
			return OjYyU4JJs8TjCeqkaPB == null;
		}
internal static object KKdqsgJExDGmiFFXDHW()
		{
			return OjYyU4JJs8TjCeqkaPB;
		}
internal static void HED3ECJK1OFPcbb0N4K()
		{
			}
	}
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _LocalSettings_SettingChanged_d__19 : IAsyncStateMachine
	{
		public int _state1;

		public AsyncVoidMethodBuilder _asyncBuilder;

		public MainUI _this4;

		public string key;

		public bool value;

		private TaskAwaiter _awaiter_1;

		private static object DEhSxmJmmW5Et6tRh2p;
public void MoveNext()
		{
			int num = 5;
			int num3 = default(int);
			TaskAwaiter awaiter = default(TaskAwaiter);
			MainUI mainUI = default(MainUI);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 1:
						_state1 = -2;
						num2 = 2;
						continue;
					case 3:
						return;
					default:
						try
						{
							int num4;
							if (num3 == 0)
							{
								num4 = 4;
								goto IL_0064;
							}
							goto IL_0207;
							IL_0207:
							num4 = 12;							goto IL_0064;
							IL_0064:
							while (true)
							{
								int num7;
								switch (num4)
								{
								case 1:
									return;
								case 11:
									awaiter = default;
									num4 = 3;									continue;
								default:
									_asyncBuilder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num4 = 1;									continue;
								case 5:
									if (false)
									{
										num4 = 18;
										continue;
									}
									goto case 14;
								case 8:
								case 10:
									num4 = 2;
									continue;
								case 16:
									num3 = (_state1 = 0);
									num7 = 9;
									goto IL_0060;
								case 13:
									mainUI.eqMW8D2F19 = value;
									num4 = 6;
									continue;
								case 14:
									if (UjXWTUXWvY.Contains(key))
									{
										num7 = 11;
										goto IL_0060;
									}
									goto end_IL_0064;
								case 4:
								case 17:
									awaiter = _awaiter_1;
									num4 = 19;
									continue;
								case 7:
									num3 = (_state1 = -1);
									num4 = 8;
									continue;
								case 15:
									break;
								case 6:
									mainUI.nscW7Je1H5(value);
									num4 = 14;									continue;
								case 9:
									_awaiter_1 = awaiter;
									num4 = 0;									continue;
								case 3:
									if (false)
									{
										num4 = 6;										continue;
									}
									goto case 16;
								case 18:
									if (value != mainUI.eqMW8D2F19)
									{
										num4 = 1;										continue;
									}
									goto case 14;
								case 19:
									_awaiter_1 = default(TaskAwaiter);
									num4 = 7;
									continue;
								case 12:
									try
									{
										JObject jObject = new JObject();
										JObject jObject2 = jObject;
										int num5 = 0;										while (true)
										{
											switch (num5)
											{
											default:
												mainUI._webSocketServer.Broadcast(null);
												num5 = 1;												continue;
											case 1:
												break;
											}
											break;
										}
									}
									catch
									{
										int num6 = 0;										switch (num6)
										{
										case 0:
											break;
										}
									}
									goto case 5;
								case 2:
									goto end_IL_0064;
									IL_0060:
									num4 = num7;
									continue;
								}
								goto IL_0207;
								continue;
								end_IL_0064:
								break;
							}
						}
						catch (Exception ex)
						{
							int num8 = 0;							while (true)
							{
								switch (num8)
								{
								case 2:
									return;
								case 1:
									_state1 = -2;
									num8 = 0;									break;
								default:
									num8 = 2;									break;
								}
							}
						}
						goto case 1;
					case 2:
						break;
					case 4:
						mainUI = _this4;
						num2 = 0;						continue;
					case 5:
						num3 = _state1;
						num2 = 4;
						continue;
					}
					break;
				}
				num = 3;
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
static _LocalSettings_SettingChanged_d__19()
		{
			}
internal static object Hhi5ofJQ1C7RjK2mvXU(int P_0)
		{
			return null;
		}
internal static object x0uprlJbhLXr9VQn6hr(object P_0)
		{
			return ((Potassium_UI_V2.Views.Settings.Settings)P_0).GetSnapshot();
		}
internal static bool yVW0ZsJZnNf6g7JUjgl()
		{
			return DEhSxmJmmW5Et6tRh2p == null;
		}
internal static object I204EnJGucURikLTqXR()
		{
			return DEhSxmJmmW5Et6tRh2p;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _StartDecompiler_d__25 : IAsyncStateMachine
	{
		public int _state1;

		public AsyncVoidMethodBuilder _asyncBuilder;

		private _c__DisplayClass25_0 _closure8_1;

		private TaskAwaiter<bool> _awaiter_1;

		private static object S9HZPoTWZ6gCTPGt1M8;
public void MoveNext()
		{
			int num = 2;
			int num2 = num;
			int num3 = default(int);
			ProcessStartInfo processStartInfo2 = default(ProcessStartInfo);
			TaskAwaiter<bool> awaiter = default(TaskAwaiter<bool>);
			string text = default(string);
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					try
					{
						int num4;
						if (num3 != 0)
						{
							num4 = 8;							goto IL_0066;
						}
						goto IL_0182;
						IL_0066:
						while (true)
						{
							Func<bool> func;
							int num7;
							switch (num4)
							{
							case 3:
								_closure8_1.Mbe7zELMBr = null;
								num4 = 0;								continue;
							case 13:
								_awaiter_1 = default(TaskAwaiter<bool>);
								num4 = 17;								continue;
							case 11:
								goto end_IL_0066;
							case 12:
								num3 = (_state1 = 0);
								num4 = 4;								continue;
							case 18:
								_asyncBuilder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num4 = 1;								continue;
							case 5:
								break;
							case 15:
								func = _c.svd7YkpxI6;
								if (func == null)
								{
									num4 = 14;
									continue;
								}
								goto IL_038a;
							case 2:
								if (!awaiter.IsCompleted)
								{
									num7 = 12;
									goto IL_0062;
								}
								goto case 1;
							case 17:
								num3 = (_state1 = -1);
								num4 = 1;								continue;
							case 1:
								if (awaiter.GetResult())
								{
									goto end_IL_0066;
								}
								num7 = 6;
								goto IL_0062;
							case 10:
								_awaiter_1 = awaiter;
								num4 = 18;
								continue;
							default:
								num4 = 8;								continue;
							case 6:
							case 7:
								text = null;
								num4 = 16;
								continue;
							case 4:
								return;
							case 9:
								_closure8_1 = new _c__DisplayClass25_0();
								num4 = 15;
								continue;
							case 16:
							{
								ProcessStartInfo processStartInfo = new ProcessStartInfo();
								processStartInfo2 = processStartInfo;
								num4 = 3;
								continue;
							}
							case 14:
								func = (_c.svd7YkpxI6 =
() => 0 != 0);
								goto IL_038a;
							case 8:
								goto end_IL_0066;
								IL_038a:
								awaiter = Task.Run(func).GetAwaiter();
								num4 = 2;
								continue;
								IL_0062:
								num4 = num7;
								continue;
							}
							goto IL_0182;
							continue;
							end_IL_0066:
							break;
						}
						goto end_IL_003c;
						IL_0182:
						awaiter = _awaiter_1;
						num4 = 13;						goto IL_0066;
						end_IL_003c:;
					}
					catch (Exception ex)
					{
						int num8 = 2;
						int num9 = num8;
						while (true)
						{
							switch (num9)
							{
							case 1:
								_closure8_1 = null;
								num9 = 0;								break;
							case 2:
								_state1 = -2;
								num9 = 1;								break;
							default:
								num9 = 3;
								break;
							case 3:
								return;
							}
						}
					}
					goto case 5;
				case 5:
					_state1 = -2;
					num2 = 4;
					break;
				case 4:
					_closure8_1 = null;
					num2 = 3;
					break;
				case 2:
					num3 = _state1;
					num2 = 1;					break;
				case 0:
					return;
				case 3:
					num2 = 0;					break;
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
				case 0:
					return;
				case 1:
					num2 = 0;					break;
				}
			}
		}

		/* IAsyncStateMachine\.SetStateMachine removed */
static _StartDecompiler_d__25()
	{
	}
internal static object FsfmJ4TIsXVxsRK7ph8(int P_0)
		{
			return null;
		}
internal static bool Fy762dTD7LYaK1owxgs()
		{
			return S9HZPoTWZ6gCTPGt1M8 == null;
		}
internal static object nmqL0oT7KYA2nI7Ufnw()
		{
			return S9HZPoTWZ6gCTPGt1M8;
		}
internal static void QNYVfsTtpGjYfSw0COf()
		{
			}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _StartTimer_d__24 : IAsyncStateMachine
	{
		public int _state1;

		public AsyncVoidMethodBuilder _asyncBuilder;

		public MainUI _this4;

		private TaskAwaiter<List<int>> _awaiter_1;

		private List<int>.Enumerator _wrap7_1;

		private TaskAwaiter _awaiter_2;

		internal static object cAFmvBTgrsuInYURaOn;
public void MoveNext()
		{
			int num = 2;
			int num2 = num;
			int num3 = default(int);
			MainUI mainUI = default(MainUI);
			TaskAwaiter<List<int>> awaiter2 = default(TaskAwaiter<List<int>>);
			TaskAwaiter awaiter = default(TaskAwaiter);
			List<int> result = default(List<int>);
			CancellationToken cancellationToken = default(CancellationToken);
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 2:
					num3 = _state1;
					num2 = 1;					break;
				case 4:
					num2 = 0;					break;
				case 3:
					_state1 = -2;
					num2 = 4;
					break;
				case 1:
					mainUI = _this4;
					num2 = 1;					break;
				case 0:
					return;
				case 5:
					try
					{
						int num5;
						if ((uint)num3 > 2u)
						{
							int num4 = 2;
							num5 = num4;
							goto IL_00e6;
						}
						goto IL_012b;
						IL_012b:
						num5 = 3;						goto IL_00e6;
						IL_00e6:
						while (true)
						{
							switch (num5)
							{
							case 2:
								mainUI.zLpWCJEjPK = new CancellationTokenSource();
								num5 = 0;								continue;
							case 3:
								try
								{
									int num6;
									if ((uint)num3 <= 2u)
									{
										num6 = 2;										goto IL_0177;
									}
									goto IL_0195;
									IL_0177:
									while (true)
									{
										switch (num6)
										{
										case 1:
											break;
										case 3:
											try
											{
												int num7;
												switch (num3)
												{
												default:
													num7 = 12;
													goto IL_01e9;
												case 0:
													awaiter2 = _awaiter_1;
													num7 = 22;
													goto IL_01e9;
												case 1:
													goto IL_0637;
												case 2:
													goto IL_0656;
													IL_01e9:
													while (true)
													{
														int num8;
														Func<List<int>> func;
														switch (num7)
														{
														case 4:
															return;
														case 8:
															return;
														case 12:
															mainUI.VA1Yi9v8W();
															num7 = 20;															continue;
														case 22:
															_awaiter_1 = default(TaskAwaiter<List<int>>);
															num8 = 24;
															goto IL_01e5;
														case 28:
															if (!awaiter2.IsCompleted)
															{
																num7 = 7;																continue;
															}
															goto case 6;
														case 10:
															try
															{
																int num9;
																if (num3 != 1)
																{
																	num9 = 5;																	goto IL_0306;
																}
																goto IL_047e;
																IL_0306:
																while (true)
																{
																	switch (num9)
																	{
																	case 2:
																		return;
																	default:
																		if (!_wrap7_1.MoveNext())
																		{
																			num9 = 11;
																			continue;
																		}
																		goto case 8;
																	case 13:
																		num3 = (_state1 = -1);
																		num9 = 3;
																		continue;
																	case 12:
																		_awaiter_2 = awaiter;
																		num9 = 4;
																		continue;
																	case 3:
																	case 6:
																		num9 = 0;																		continue;
																	case 9:
																		if (false)
																		{
																			num9 = 6;
																			continue;
																		}
																		goto case 1;
																	case 10:
																		_awaiter_2 = default(TaskAwaiter);
																		num9 = 13;
																		continue;
																	case 4:
																		_asyncBuilder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
																		num9 = 0;																		continue;
																	case 8:
																		awaiter = default;
																		num9 = 9;
																		continue;
																	case 1:
																		num3 = (_state1 = 1);
																		num9 = 12;
																		continue;
																	case 7:
																		break;
																	case 11:
																		goto end_IL_0306;
																	}
																	goto IL_047e;
																	continue;
																	end_IL_0306:
																	break;
																}
																goto end_IL_02db;
																IL_047e:
																awaiter = _awaiter_2;
																num9 = 10;																goto IL_0306;
																end_IL_02db:;
															}
															finally
															{
																int num10;
																if (num3 >= 0)
																{
																	num10 = 1;																	goto IL_04f9;
																}
																goto IL_050f;
																IL_04f9:
																switch (num10)
																{
																case 1:
																	goto end_IL_04ce;
																case 2:
																	goto end_IL_04ce;
																}
																goto IL_050f;
																IL_050f:
																((IDisposable)_wrap7_1/*cast due to .constrained prefix*/).Dispose();
																num10 = 2;
																goto IL_04f9;
																end_IL_04ce:;
															}
															goto case 3;
														case 14:
															break;
														case 18:
														case 19:
															awaiter = default;
															num7 = 7;
															continue;
														case 5:
															_asyncBuilder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
															num7 = 4;
															continue;
														case 2:
															num3 = (_state1 = 2);
															num7 = 23;
															continue;
														case 29:
															_wrap7_1 = result.GetEnumerator();
															num7 = 16;															continue;
														case 13:
														case 27:
															num7 = 30;
															continue;
														case 16:
															goto IL_0637;
														default:
															num3 = (_state1 = -1);
															num7 = 27;
															continue;
														case 1:
															goto IL_0656;
														case 11:
															num3 = (_state1 = 0);
															num7 = 9;
															continue;
														case 24:
															num3 = (_state1 = -1);
															num7 = 6;															continue;
														case 20:
															num7 = 26;
															continue;
														case 3:
															_wrap7_1 = default(List<int>.Enumerator);
															num7 = 18;															continue;
														case 26:
															if (!NjO3gOTkq2RBFQEH4lE(mainUI.localSettings, null))
															{
																num7 = 19;																continue;
															}
															goto case 17;
														case 7:
															if (false)
															{
																num7 = 13;																continue;
															}
															goto case 2;
														case 6:
															result = awaiter2.GetResult();
															num7 = 29;															continue;
														case 9:
															_awaiter_1 = awaiter2;
															num7 = 5;
															continue;
														case 15:
															_awaiter_2 = default(TaskAwaiter);
															num7 = 0;															continue;
														case 23:
															_awaiter_2 = awaiter;
															num8 = 21;
															goto IL_01e5;
														case 21:
															_asyncBuilder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
															num7 = 8;
															continue;
														case 17:
															func = _c.dyK73UAVFQ;
															if (func != null)
															{
																goto IL_08a9;
															}
															num7 = 25;
															continue;
														case 25:
															func = (_c.dyK73UAVFQ =
() =>
															{
																List<int> list = new List<int>();
																foreach (int process2 in Injector.GetProcesses())
																{
																	if (!Injector.injectedProcesses.Contains(process2))
																	{
																		try
																		{
																			Process process = default;
																			TimeSpan timeSpan = default;
																			if (0 >= 5.0)
																			{
																				list.Add(process2);
																			}
																		}
																		catch
																		{
																		}
																	}
																}
																return list;
															});
															goto IL_08a9;
														case 30:
															goto end_IL_01ca;
															IL_08a9:
															awaiter2 = Task.Run(func).GetAwaiter();
															num7 = 28;
															continue;
															IL_01e5:
															num7 = num8;
															continue;
														}
														break;
													}
													goto case 0;
													IL_0656:
													awaiter = _awaiter_2;
													num7 = 15;
													goto IL_01e9;
													IL_0637:
													num7 = 10;
													goto IL_01e9;
													end_IL_01ca:
													break;
												}
											}
											catch (Exception)
											{
												int num11 = 0;												switch (num11)
												{
												case 0:
													break;
												}
											}
											break;
										default:
											if (false)
											{
												num6 = 4;
												continue;
											}
											goto case 2;
										case 2:
										{
											int num12 = 3;
											num6 = num12;
											continue;
										}
										case 4:
											goto end_IL_0177;
										}
										goto IL_0195;
										continue;
										end_IL_0177:
										break;
									}
									goto end_IL_014c;
									IL_0195:
									cancellationToken = default;
									num6 = 0;									goto IL_0177;
									end_IL_014c:;
								}
								catch (Exception ex2)
								{
									int num13 = 0;									switch (num13)
									{
									case 0:
										break;
									}
								}
								goto end_IL_00e6;
							case 1:
								goto end_IL_00e6;
							}
							goto IL_012b;
							continue;
							end_IL_00e6:
							break;
						}
					}
					catch (Exception ex3)
					{
						int num14 = 1;						while (true)
						{
							switch (num14)
							{
							default:
								return;
							case 0:
								return;
							case 1:
								_state1 = -2;
								num14 = 2;
								break;
							case 2:
								num14 = 0;								break;
							}
						}
					}
					goto case 3;
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
				case 0:
					return;
				case 1:
					num2 = 0;					break;
				}
			}
		}

		/* IAsyncStateMachine\.SetStateMachine removed */
static _StartTimer_d__24()
	{
	}
internal static object xsDmVcT49wSHDWfKrwr(int P_0)
		{
			return null;
		}
internal static bool NjO3gOTkq2RBFQEH4lE(object P_0, object P_1)
		{
			return ((Potassium_UI_V2.Views.Settings.Settings)P_0).GetSettingValue((string)P_1);
		}
internal static bool fCD0icTRBEHwByFhUb5()
		{
			return cAFmvBTgrsuInYURaOn == null;
		}
internal static object KQf3rtThf5NDslP8fU3()
		{
			return cAFmvBTgrsuInYURaOn;
		}
internal static void OlhluqTjHAXwWJHS59s()
		{
			}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _Window_Closing_d__22 : IAsyncStateMachine
	{
		public int _state1;

		public AsyncVoidMethodBuilder _asyncBuilder;

		public MainUI _this4;

		public CancelEventArgs e;

		private TaskAwaiter _awaiter_1;

		private static object P7YvFyT6tDVJLEHVsGk;
public void MoveNext()
		{
			int num = 1;
			int num2 = num;
			int num3 = default(int);
			MainUI mainUI = default(MainUI);
			TaskAwaiter awaiter = default(TaskAwaiter);
			while (true)
			{
				switch (num2)
				{
				case 2:
					num2 = 5;
					break;
				case 1:
					num3 = _state1;
					num2 = 0;					break;
				case 4:
					_state1 = -2;
					num2 = 0;					break;
				case 5:
					return;
				default:
					mainUI = _this4;
					num2 = 0;					break;
				case 3:
					try
					{
						int num4;
						if (num3 == 0)
						{
							num4 = 1;							goto IL_00f6;
						}
						goto IL_0179;
						IL_0179:
						if (mainUI.jMJWOycNZQ)
						{
							num4 = 3;
							goto IL_00f6;
						}
						goto IL_0149;
						IL_0149:
						num4 = 7;						goto IL_00f6;
						IL_00f6:
						while (true)
						{
							switch (num4)
							{
							case 4:
								num4 = 2;
								continue;
							case 3:
								break;
							case 5:
								goto IL_0149;
							default:
								goto IL_0179;
							case 1:
							case 7:
								num4 = 8;
								continue;
							case 6:
								mainUI.jMJWOycNZQ = true;
								num4 = 4;
								continue;
							case 8:
								try
								{
									int num5;
									if (num3 == 0)
									{
										num5 = 5;										goto IL_01fb;
									}
									goto IL_0239;
									IL_01fb:
									while (true)
									{
										switch (num5)
										{
										case 1:
											return;
										case 7:
											break;
										case 10:
											_awaiter_1 = awaiter;
											num5 = 11;
											continue;
										case 11:
											_asyncBuilder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
											num5 = 1;											continue;
										default:
											num5 = 9;											continue;
										case 6:
										case 9:
											awaiter = _awaiter_1;
											num5 = 3;
											continue;
										case 2:
											if (false)
											{
												num5 = 0;												continue;
											}
											goto case 4;
										case 4:
											num3 = (_state1 = 0);
											num5 = 10;											continue;
										case 3:
											_awaiter_1 = default(TaskAwaiter);
											num5 = 0;											continue;
										case 8:
											num3 = (_state1 = -1);
											num5 = 5;											continue;
										case 12:
											goto end_IL_01fb;
										}
										goto IL_0239;
										continue;
										end_IL_01fb:
										break;
									}
									goto end_IL_01d1;
									IL_0239:
									awaiter = default;
									num5 = 2;									goto IL_01fb;
									end_IL_01d1:;
								}
								catch
								{
									int num6 = 0;									switch (num6)
									{
									case 0:
										break;
									}
								}
								goto case 6;
							case 2:
								break;
							}
							break;
						}
					}
					catch (Exception ex)
					{
						int num7 = 1;						while (true)
						{
							switch (num7)
							{
							case 2:
								return;
							default:
							{
								int num8 = 2;
								num7 = num8;
								break;
							}
							case 1:
								_state1 = -2;
								num7 = 0;								break;
							}
						}
					}
					goto case 4;
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
static _Window_Closing_d__22()
	{
	}
internal static object PIjAVdTiKeX2AM15klx(object P_0)
		{
			return ((TabsControl)P_0).SaveTabsAsync();
		}
internal static bool UQplnBTrdN7U18QVidK()
		{
			return P7YvFyT6tDVJLEHVsGk == null;
		}
internal static object nQ2IC8TdEZnb6GPJV42()
		{
			return P7YvFyT6tDVJLEHVsGk;
		}
internal static void VUDdSHTy0Xyy7WwLW6f()
		{
			}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _Window_Loaded_d__26 : IAsyncStateMachine
	{
		public int _state1;

		public AsyncVoidMethodBuilder _asyncBuilder;

		public MainUI _this4;

		internal static object VFw73qTwNZ3EU71N6UA;
public void MoveNext()
		{
			int num = 2;
			MainUI mainUI = default(MainUI);
			Rect rect = default(Rect);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 4:
						return;
					case 1:
						try
						{
							mainUI.VA1Yi9v8W();
							int num3 = 7;
							while (true)
							{
								switch (num3)
								{
								case 5:
								rect = default;
									num3 = 3;									continue;
								case 3:
									num3 = 2;
									continue;
								case 6:
									mainUI.eqMW8D2F19 = hlv6nSTSqUg9SGpICSK(mainUI.localSettings, gTOqkUTxmgEh8O9Bg7c(0x12E94D72 ^ 0));
									num3 = 4;									continue;
								case 7:
									mainUI.RkKzgUZxr();
									num3 = 3;									continue;
								case 4:
									mainUI.eskWDm8G2K();
									num3 = 5;									continue;
								case 8:
									if (0 == WindowState.Normal)
									{
										num3 = 0;										continue;
									}
									goto case 10;
								case 10:
								case 11:
									mainUI.tabsControl.TabReady += mainUI.xKrWB9509p;
									num3 = 1;									continue;
								default:
									num3 = 4;									continue;
								case 9:
									if (mainUI.eqMW8D2F19)
									{
										num3 = 4;										continue;
									}
									goto case 8;
								case 2:
									num3 = 11;									continue;
								case 1:
									break;
								}
								break;
							}
						}
						catch (Exception ex)
						{
							int num4 = 2;							while (true)
							{
								switch (num4)
								{
								case 1:
									return;
								default:
									num4 = 1;									break;
								case 2:
									_state1 = -2;
									num4 = 0;									break;
								}
							}
						}
						break;
					case 3:
					return;
				case 2:
						mainUI = _this4;
						num2 = 1;						continue;
					}
					break;
				}
				_state1 = -2;
				num = 3;
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
static _Window_Loaded_d__26()
		{
			}
internal static object gTOqkUTxmgEh8O9Bg7c(int P_0)
		{
			return null;
		}
internal static bool hlv6nSTSqUg9SGpICSK(object P_0, object P_1)
		{
			return ((Potassium_UI_V2.Views.Settings.Settings)P_0).GetSettingValue((string)P_1);
		}
internal static bool anwOuMTAaYynq0mPCDj()
		{
			return VFw73qTwNZ3EU71N6UA == null;
		}
internal static object yLflnjTaY1eDaMCXbuT()
		{
			return VFw73qTwNZ3EU71N6UA;
		}
	}

	public readonly WebSocketServer _webSocketServer;

	[CompilerGenerated]
	private readonly ObservableCollection<ConsoleEntry> CYaWpEAEcu;

	private CancellationTokenSource? zLpWCJEjPK;

	private bool tK2WF3XQMx;

	private bool jMJWOycNZQ;

	private double Ym5Ws2C5Ra;

	private bool eqMW8D2F19;

	private bool nq1WJXAW4b;

	private static readonly HashSet<string> UjXWTUXWvY;

																											private bool W3XWEAhc5J;

	internal static MainUI RIZj2NF4g9xD5hmsgvy;

	public ObservableCollection<ConsoleEntry> ConsoleEntries
	{
[CompilerGenerated]
		get
		{
			return CYaWpEAEcu;
		}
	}

	[DllImport("kernel32.dll", EntryPoint = "CreateMutex", SetLastError = true)]
	private static extern nint r6ocIDmri(nint P_0, bool P_1, string P_2);
public MainUI()
	{
		InitializeComponent();

		try
		{
			CYaWpEAEcu = new ObservableCollection<ConsoleEntry>();
			consoleStack.ItemsSource = ConsoleEntries;
		}
		catch { }

		try
		{
			_webSocketServer = new WebSocketServer("http://localhost:5678/");
			_webSocketServer.Start();
			_webSocketServer.onAuth += l8hWRcUDHh;
			_webSocketServer.onClose += fslWhIxnmI;
			if (localSettings != null)
				_webSocketServer.SetConfigSnapshotProvider(() => localSettings.GetSnapshot());
		}
		catch { }

		try { ThemeManager.ThemeChanged += qTGW94dgg4; } catch { }

		try { SwitchToPage(codePage); } catch { }
		try { SetSelectedButton(BracketButton); } catch { }
	}

[AsyncStateMachine(typeof(_LocalSettings_SettingChanged_d__19))]
	private void TkCmH4EDu(string P_0, bool P_1)
	{
		_LocalSettings_SettingChanged_d__19 stateMachine = default(_LocalSettings_SettingChanged_d__19);
		stateMachine._asyncBuilder = default;
		stateMachine._this4 = this;
		stateMachine.key = P_0;
		stateMachine.value = P_1;
		stateMachine._state1 = -1;
		stateMachine._asyncBuilder.Start(ref stateMachine);
	}
private string FFyZWDksB()
	{
		int num = 10;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(DefaultInterpolatedStringHandler);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					num2 = 15;
					continue;
				case 9:
					num2 = 4;					continue;
				case 12:
					num2 = 17;
					continue;
				case 15:
					num2 = 18;
					continue;
				default:
					num2 = 7;					continue;
				case 4:
					num2 = 1;					continue;
				case 13:
					num2 = 3;					continue;
				case 10:
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(166, 6);
					num2 = 9;
					continue;
				case 14:
					num2 = 19;
					continue;
				case 11:
					num2 = 7;
					continue;
				case 3:
					num2 = 12;					continue;
				case 18:
					num2 = 14;
					continue;
				case 17:
					num2 = 5;
					continue;
				case 16:
					return null;
				case 7:
					num2 = 6;
					continue;
				case 1:
					num2 = 6;					continue;
				case 19:
					num2 = 15;					continue;
				case 5:
					break;
				case 2:
					num2 = 0;					continue;
				case 8:
					num2 = 0;					continue;
				}
				break;
			}
			num = 8;
		}
	}
[AsyncStateMachine(typeof(_ApplyEditorSettingsToAllAsync_d__21))]
	private Task Q3ZGLf4cl()
	{
		_ApplyEditorSettingsToAllAsync_d__21 stateMachine = default(_ApplyEditorSettingsToAllAsync_d__21);
		stateMachine._asyncBuilder = AsyncTaskMethodBuilder.Create();
		stateMachine._this4 = this;
		stateMachine._state1 = -1;
		stateMachine._asyncBuilder.Start(ref stateMachine);
		return stateMachine._asyncBuilder.Task;
	}
[AsyncStateMachine(typeof(_Window_Closing_d__22))]
	private void OFTQ2EaNX(object? sender, CancelEventArgs P_1)
	{
		_Window_Closing_d__22 stateMachine = default(_Window_Closing_d__22);
		stateMachine._asyncBuilder = default;
		stateMachine._this4 = this;
		stateMachine.e = P_1;
		stateMachine._state1 = -1;
		stateMachine._asyncBuilder.Start(ref stateMachine);
	}

	// [DEOBFUSCATED] Control flow flattening detected (initial state: 2)
private void mmZbQg0Xc(object? sender, EventArgs P_1)
	{
	int num = 2;
	int num2 = num;
	while (true)
	{
	switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				if (0 != WindowState.Maximized)
				{
					num2 = 3;
					break;
				}
				num2 = 1;				break;
			case 3:
				return;
			case 1:
				num2 = 0;				break;
			}
		}
	}
[AsyncStateMachine(typeof(_StartTimer_d__24))]
	private void Ffl3tKIqn()
	{
		_StartTimer_d__24 stateMachine = default(_StartTimer_d__24);
		stateMachine._asyncBuilder = default;
		stateMachine._this4 = this;
		stateMachine._state1 = -1;
		stateMachine._asyncBuilder.Start(ref stateMachine);
	}
[AsyncStateMachine(typeof(_StartDecompiler_d__25))]
	private void VA1Yi9v8W()
	{
		_StartDecompiler_d__25 stateMachine = default(_StartDecompiler_d__25);
		stateMachine._asyncBuilder = default;
		stateMachine._state1 = -1;
		stateMachine._asyncBuilder.Start(ref stateMachine);
	}
[AsyncStateMachine(typeof(_Window_Loaded_d__26))]
	private void h3k5k17gv(object P_0, RoutedEventArgs P_1)
	{
		_Window_Loaded_d__26 stateMachine = default(_Window_Loaded_d__26);
		stateMachine._asyncBuilder = default;
		stateMachine._this4 = this;
		stateMachine._state1 = -1;
		stateMachine._asyncBuilder.Start(ref stateMachine);
	}
private void RkKzgUZxr()
	{
		switch (1)
		{
		case 1:
			try
			{
				Ym5Ws2C5Ra = default;
				int num = 0;				switch (num)
				{
				case 0:
					break;
				}
				break;
			}
			catch
			{
				int num2 = 0;				switch (num2)
				{
				case 0:
					break;
				}
				break;
			}
		case 0:
			break;
		}
	}
private void bVPWP8bnBI()
	{
		switch (1)
		{
		case 1:
			try
			{
				oUbNtqFaNd2Ibpf6373(Ym5Ws2C5Ra);
				int num = 0;				switch (num)
				{
				case 0:
					break;
				}
				break;
			}
			catch
			{
				int num2 = 0;				switch (num2)
				{
				case 0:
					break;
				}
				break;
			}
		case 0:
			break;
		}
	}

	// [DEOBFUSCATED] Control flow flattening detected (initial state: 1)
private void QdSWWgdwKv(double P_0)
	{
	int num = 1;
	int num2 = num;
	while (true)
	{
	switch (num2)
			{
			case 1:
				num2 = 0;				break;
			case 2:
				return;
			case 3:
				num2 = 2;				break;
			default:
				num2 = 1;				break;
			}
		}
	}
private void eskWDm8G2K()
	{
		int num = 2;
		double num3 = default(double);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				double num4;
				switch (num2)
				{
				case 3:
					return;
				case 4:
					goto end_IL_0012;
				case 2:
					if (!eqMW8D2F19)
					{
						num2 = 1;						continue;
					}
					num4 = Ym5Ws2C5Ra;
					break;
				case 1:
					num4 = 0.0;
					break;
				default:
					QdSWWgdwKv(num3);
					num2 = 4;
					continue;
				}
				num3 = num4;
				num2 = 0;				continue;
				end_IL_0012:
				break;
			}
			num = 3;
		}
	}
private void nscW7Je1H5(bool P_0)
	{
		int num = 14;
		int num2 = num;
		_c__DisplayClass31_0 _c__DisplayClass31_ = default(_c__DisplayClass31_0);
		while (true)
		{
			switch (num2)
			{
			case 7:
				if (0 < 0.5)
				{
					num2 = 9;
					break;
				}
				num2 = 1;				break;
			case 13:
				_c__DisplayClass31_.eL4ItYFSER = this;
				num2 = 1;				break;
			case 5:
				_c__DisplayClass31_.RDuI44hg31 = null;
				num2 = 17;
				break;
			case 3:
				_c__DisplayClass31_.x0aIgb2k6Q = 0 == WindowState.Normal;
				num2 = 11;				break;
			case 10:
				return;
			default:
				_c__DisplayClass31_.kFOIDJK2pq = default;
				num2 = 1;				break;
			case 14:
				_c__DisplayClass31_ = new _c__DisplayClass31_0();
				num2 = 13;
				break;
			case 15:
				return;
			case 1:
				if (!nq1WJXAW4b)
				{
					num2 = 6;
					break;
				}
				return;
			case 18:
				_c__DisplayClass31_.KrGIWsEcCR = null;
				num2 = 0;				break;
			case 9:
				eskWDm8G2K();
				num2 = 10;
				break;
			case 17:
				_c__DisplayClass31_.RDuI44hg31 = _c__DisplayClass31_.r0oIPSXicr;
				num2 = 2;
				break;
			case 11:
				_c__DisplayClass31_.tDTIRJ9Xxy = default;
				num2 = 4;
				break;
			case 8:
				return;
			case 6:
				_c__DisplayClass31_.CAEI7wjJ7g = default;
				num2 = 3;				break;
			case 2:
				num2 = 15;
				break;
			case 12:
				nq1WJXAW4b = true;
				num2 = 18;				break;
			case 16:
				_c__DisplayClass31_.JYRIIGqX3o = (P_0 ? Ym5Ws2C5Ra : 0.0);
				num2 = 7;
				break;
			case 4:
				_c__DisplayClass31_.VcGIhjmHqd = _c__DisplayClass31_.tDTIRJ9Xxy + (P_0 ? 195.0 : (-195.0));
				num2 = 12;
				break;
			}
		}
	}
private void UIkWIRv0NQ(object P_0, DragDeltaEventArgs P_1)
	{
		int num = 1;
		double num5 = default(double);
		double num3 = default(double);
		double num4 = default(double);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 4:
					num5 = 500.0;
					num2 = 7;					break;
				case 1:
					if (!eqMW8D2F19)
					{
						num2 = 0;						break;
					}
					goto case 2;
				case 11:
					num5 = num3;
					num2 = 12;					break;
				case 3:
					if (num3 < num5)
					{
						num2 = 11;						break;
					}
					goto case 12;
				case 6:
					return;
				case 2:
					if (!nq1WJXAW4b)
					{
						num4 = 0 - 0;
						num2 = 4;
						break;
					}
					goto end_IL_0012;
				case 12:
					num4 = default;
					num2 = 10;
					break;
				case 10:
					Ym5Ws2C5Ra = num4;
					num2 = 9;					break;
				case 9:
					QdSWWgdwKv(num4);
					num2 = 3;					break;
				case 7:
					num3 = 0 - 43.0 - 50.0 - 100.0;
					num2 = 5;
					break;
				case 5:
					if (num3 > 0.0)
					{
						num2 = 2;						break;
					}
					goto case 12;
				case 8:
					return;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 8;
		}
	}
private void kgQWtKBjmK(object P_0, DragCompletedEventArgs P_1)
	{
		bVPWP8bnBI();
	}
private void SQJWgrp88v(Color P_0)
	{
		try
		{
			Dispatcher.Invoke(() =>
			{
				if (ButtonAttach != null)
				{
					var brush = new SolidColorBrush(P_0);
					brush.Freeze();
					ButtonAttach.Foreground = brush;
				}
			});
		}
		catch { }
	}

	// [DEOBFUSCATED] onAuth - WebSocket 连接成功
private void l8hWRcUDHh(bool P_0)
	{
		try
		{
			tK2WF3XQMx = true;
			// 绿色表示已连接
			SQJWgrp88v(Color.FromRgb(0x4C, 0xC5, 0x6A));
		}
		catch { }
	}

	// [DEOBFUSCATED] onClose - WebSocket 断开
private void fslWhIxnmI(bool P_0)
	{
		try
		{
			tK2WF3XQMx = false;
			// 恢复默认颜色
			SQJWgrp88v(Color.FromRgb(0xFF, 0xFF, 0xFF));
		}
		catch { }
	}

	// [DEOBFUSCATED] Control flow flattening detected (initial state: 1)
private void IGiW473V0w(object P_0, RoutedEventArgs P_1)
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
				num2 = 0;				break;
			case 0:
				return;
			}
		}
	}
private void lUSWkh2rY2(object P_0, RoutedEventArgs P_1)
	{
		LmZWiQNFty();
	}
private void ERQDjO7GvY(object P_0, RoutedEventArgs P_1)
	{
		try
		{
			// 停止 WebSocket 服务器
			if (_webSocketServer != null)
			{
				try { _webSocketServer.Stop(); } catch { }
			}
			// 取消后台任务
			try { zLpWCJEjPK?.Cancel(); } catch { }
		}
		catch { }
		Environment.Exit(0);
	}
private void ik9D67ioEV(object P_0, RoutedEventArgs P_1)
	{
		if (base.WindowState == WindowState.Maximized)
			base.WindowState = WindowState.Normal;
		else
			base.WindowState = WindowState.Maximized;
	}
private void EK4DrkRv1i(object P_0, RoutedEventArgs P_1)
	{
		base.WindowState = WindowState.Minimized;
	}

	// [DEOBFUSCATED] Control flow flattening detected (initial state: 1)
private void JSFWjcFYZx(object P_0, RoutedEventArgs P_1)
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
				num2 = 0;				break;
			case 0:
				return;
			}
		}
	}

	// [DEOBFUSCATED] Control flow flattening detected (initial state: 3)
private void emIW6jZNaP(object P_0, MouseButtonEventArgs P_1)
	{
		try
		{
			if (WindowState == WindowState.Maximized)
			{
				WindowState = WindowState.Normal;
			}
			if (P_1.ButtonState == MouseButtonState.Pressed)
			{
				DragMove();
			}
		}
		catch { }
	}

	// [DEOBFUSCATED] Control flow flattening detected (initial state: 1)
private void pIVWrgtIHN()
	{
	int num = 1;
	int num2 = num;
	while (true)
	{
	switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				num2 = 0;				break;
			}
		}
	}

	// [DEOBFUSCATED] Control flow flattening detected (initial state: 1)
private void r9rWdGYoAF()
	{
	int num = 1;
	int num2 = num;
	while (true)
	{
	switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				num2 = 0;				break;
			}
		}
	}

	// [DEOBFUSCATED] Control flow flattening detected (initial state: 2)
private void LmZWiQNFty()
	{
	int num = 2;
	int num2 = num;
	while (true)
	{
	switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 3:
				return;
			case 2:
				if (false)
				{
					r9rWdGYoAF();
					num2 = 3;
					break;
				}
				num2 = 1;				break;
			case 1:
				pIVWrgtIHN();
				num2 = 0;				break;
			}
		}
	}
	private async void vfsWywqS99(object P_0, RoutedEventArgs P_1)
	{
		try
		{
			Button button = P_0 as Button;
			if (button != null) button.IsEnabled = false;

			var processes = Injector.GetProcesses();
			foreach (var proc in processes)
			{
				try { await Injector.Inject(proc); } catch { }
			}

			if (button != null) button.IsEnabled = true;
		}
		catch { }
	}

	// [DEOBFUSCATED] Control flow flattening detected (initial state: 2)
private void Gh3Ww942jO(object P_0, RoutedEventArgs P_1)
	{
		SwitchToPage(codePage);
		SetSelectedButton(P_0 as ToggleButton);
	}

	// [DEOBFUSCATED] Control flow flattening detected (initial state: 1)
private void WE8WATRkRw(object P_0, RoutedEventArgs P_1)
	{
		SwitchToPage(settingsPage);
		SetSelectedButton(P_0 as ToggleButton);
	}

	// [DEOBFUSCATED] Control flow flattening detected (initial state: 2)
private void q9ZWaRTSlL(object P_0, RoutedEventArgs P_1)
	{
		SwitchToPage(scripthubPage);
		SetSelectedButton(P_0 as ToggleButton);
	}

	// [DEOBFUSCATED] Control flow flattening detected (initial state: 1)
private void GBMWxywlBu(object P_0, RoutedEventArgs P_1)
	{
		SwitchToPage(themePage);
		SetSelectedButton(P_0 as ToggleButton);
	}
public void SwitchToPage(Grid page)
	{
		try
		{
			Grid[] array = new Grid[4] { codePage, settingsPage, scripthubPage, themePage };
			foreach (Grid g in array)
			{
				g.Visibility = (g == page) ? Visibility.Visible : Visibility.Collapsed;
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show($"SwitchToPage failed: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
		}
	}
public void SetSelectedButton(ToggleButton selectedButton)
	{
		if (iconBar != null)
		{
			foreach (var child in iconBar.Children)
			{
				if (child is ToggleButton tb)
				{
					tb.IsChecked = (tb == selectedButton);
				}
			}
		}
	}
	private async void OgEWS5Dxjm(object P_0, RoutedEventArgs P_1)
	{
		try
		{
			if (tabsControl?.currentWebView == null) return;

			string json = await tabsControl.currentWebView.ExecuteScriptAsync("GetText()");
			string scriptText = "";
			if (!string.IsNullOrEmpty(json))
			{
				try { scriptText = System.Text.Json.JsonSerializer.Deserialize<string>(json) ?? ""; }
				catch { scriptText = json; }
			}

			var msg = new Newtonsoft.Json.Linq.JObject
			{
				["type"] = "execute",
				["script"] = scriptText
			};
			string message = msg.ToString();

			string pid = scriptsFolder?.SelectedPid;
			if (!string.IsNullOrEmpty(pid) && pid != "All")
			{
				await _webSocketServer.SendToPid(pid, message);
			}
			else
			{
				await _webSocketServer.Broadcast(message);
			}
		}
		catch { }
	}
private void KN5WvZM4gf(object P_0, RoutedEventArgs P_1)
	{
		try
		{
			ConsoleEntries.Clear();
		}
		catch { }
	}
private void H9vW0uHJai(object P_0, RoutedEventArgs P_1)
	{
		try
		{
			if (tabsControl?.currentWebView == null) return;
			var dlg = new Microsoft.Win32.OpenFileDialog
			{
				Filter = "Lua files (*.lua)|*.lua|Text files (*.txt)|*.txt|All files (*.*)|*.*",
				DefaultExt = ".lua"
			};
			if (dlg.ShowDialog() == true)
			{
				string content = System.IO.File.ReadAllText(dlg.FileName);
				string escaped = Newtonsoft.Json.JsonConvert.SerializeObject(content);
				tabsControl.currentWebView.ExecuteScriptAsync($"SetText({escaped})");
			}
		}
		catch { }
	}
	private async void euaWNcdY9I(object P_0, RoutedEventArgs P_1)
	{
		try
		{
			if (tabsControl?.currentWebView == null) return;
			var dlg = new Microsoft.Win32.SaveFileDialog
			{
				Filter = "Lua files (*.lua)|*.lua|Text files (*.txt)|*.txt|All files (*.*)|*.*",
				DefaultExt = ".lua"
			};
			if (dlg.ShowDialog() == true)
			{
				string json = await tabsControl.currentWebView.ExecuteScriptAsync("GetText()");
				string content = System.Text.Json.JsonSerializer.Deserialize<string>(json);
				System.IO.File.WriteAllText(dlg.FileName, content);
			}
		}
		catch { }
	}
private void g60WUkwP92(object P_0, RoutedEventArgs P_1)
	{
		int num = 14;
		int num3 = default(int);
		string text2 = default(string);
		string text = default(string);
		DateTime dateTime = default(DateTime);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 8:
					return;
				case 12:
					if (num3 != 7)
					{
						num2 = 11;						continue;
					}
					goto case 5;
				case 19:
					text2 = (string)Viho8IFiT7MsrlBEJev(0x1B50CE77 ^ 0);
					num2 = 15;
					continue;
				case 9:
					if (num3 > 7)
					{
						num2 = 10;						continue;
					}
					goto case 3;
				case 2:
				case 4:
				case 15:
				case 17:
				case 18:
					text = text2;
					num2 = 7;
					continue;
				case 6:
				case 10:
					if (num3 != 10)
					{
						num2 = 20;
						continue;
					}
					goto case 16;
				default:
					text2 = string.Empty;
					num2 = 4;					continue;
				case 21:
					text2 = (string)Viho8IFiT7MsrlBEJev(0x155D0EA3 ^ 0);
					num2 = 17;
					continue;
				case 13:
					num3 = default;
					num2 = 9;					continue;
				case 5:
					text2 = null;
					num2 = 0;					continue;
				case 20:
					if (num3 != 12)
					{
						num2 = 0;						continue;
					}
					goto case 21;
				case 3:
					if (num3 != 4)
					{
						num2 = 12;
						continue;
					}
					goto case 19;
				case 16:
					text2 = "http://";
					num2 = 18;
					continue;
				case 14:
					dateTime = default;
					num2 = 13;					continue;
				case 7:
					num = 8;
					break;
				}
				break;
			}
		}
	}
private void qTGW94dgg4(ThemeDefinition P_0)
	{
		int num = 3;
		int num2 = num;
		_c__DisplayClass56_0 _c__DisplayClass56_ = default(_c__DisplayClass56_0);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 3:
				_c__DisplayClass56_ = new _c__DisplayClass56_0();
				num2 = 2;
				break;
			case 2:
				_c__DisplayClass56_.t0pIdtjGMD = this;
				num2 = 1;				break;
			case 0:
				return;
			case 1:
				_c__DisplayClass56_.CklIiQ3rJS = P_0;
				num2 = 1;				break;
			case 4:
				_ = new Func<Task>((Func<Task>)_c__DisplayClass56_.auwIrnRTof);
				num2 = 0;				break;
			}
		}
	}

	// [DEOBFUSCATED] Control flow flattening detected (initial state: 1)
private void YLnWeQGLbo(ThemeDefinition? P_0)
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
				num2 = 0;				break;
			case 0:
				return;
			}
		}
	}

	// [DEOBFUSCATED] Control flow flattening detected (initial state: 1)
private void AaZW1QTKQT(object P_0, RoutedEventArgs P_1)
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
				gaXCK1Fv10om3JkoAvQ((P_0 is TextBlock) ? P_0 : null);
				num2 = 0;				break;
			case 0:
				return;
			}
		}
	}

	// [DEOBFUSCATED] Control flow flattening detected (initial state: 1)
private void u95WqFLXDM(object P_0, DependencyPropertyChangedEventArgs P_1)
	{
	int num = 1;
	int num2 = num;
	while (true)
	{
	switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				gaXCK1Fv10om3JkoAvQ((P_0 is TextBlock) ? P_0 : null);
				num2 = 0;				break;
			}
		}
	}
private static void TFGWXCruRS(object? P_0)
	{
		int num = 7;
		Run run2 = default(Run);
		ConsoleEntry consoleEntry = default(ConsoleEntry);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					num2 = 2;
					continue;
				case 6:
					return;
				case 8:
					((InlineCollection)P_0).Add(run2);
					num2 = 4;
					continue;
				case 1:
					break;
				case 9:
					if (consoleEntry != null)
					{
						num2 = 1;						continue;
					}
					return;
				case 3:
					return;
				case 5:
				{
					InlineCollection inlineCollection = null;
					Run run3 = new Run((string)MNwLc6FNUqSjV3UTGmB(consoleEntry));
					inlineCollection.Add(run3);
					num2 = 0;					continue;
				}
				case 2:
					return;
				case 7:
					if (P_0 != null)
					{
						yRFQASF0BxlK5KWswWB(null);
						num2 = 1;					}
					else
					{
						num2 = 6;
					}
					continue;
				default:
				{
					Run run = new Run((string)q1THCjFUvejp4fcNqIp(consoleEntry));
					run2 = run;
					num2 = 8;
					continue;
				}
				}
				break;
			}
			consoleEntry = null as ConsoleEntry;
			num = 9;
		}
	}
/* InitializeComponent provided by .g.cs */
/* _CreateDelegate provided by .g.cs */
/* IComponentConnector\.Connect removed */
/* IStyleConnector\.Connect removed */
static MainUI()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				num2 = 0;				continue;
			case 1:
				jk9PJrF69GadRgB0Sbu();
				num2 = 3;				continue;
			case 4:
				return;
			case 2:
				JDnKQXF9QvnTsCLlCn8();
				num2 = 1;				continue;
			}
			UjXWTUXWvY = new HashSet<string>
			{
				(string)Viho8IFiT7MsrlBEJev(0x7EE1B46B ^ 0),
				null,
				"Win",
				(string)Viho8IFiT7MsrlBEJev(0x25137060 ^ 0),
				(string)Viho8IFiT7MsrlBEJev(0x5A41431E ^ 0),
				(string)Viho8IFiT7MsrlBEJev(0xF2DD82F ^ 0)
			};
			num2 = 4;		}
	}
[CompilerGenerated]
	private JObject ElIWMVH3nG()
	{
		return localSettings.GetSnapshot();
	}
[AsyncStateMachine(typeof(_Window_Loaded_b_26_0_d))]
	[CompilerGenerated]
	private void xKrWB9509p(WebView2 P_0)
	{
		_Window_Loaded_b_26_0_d stateMachine = default(_Window_Loaded_b_26_0_d);
		stateMachine._asyncBuilder = default;
		stateMachine._this4 = this;
		stateMachine.webView = P_0;
		stateMachine._state1 = -1;
		stateMachine._asyncBuilder.Start(ref stateMachine);
	}
internal static void jk9PJrF69GadRgB0Sbu()
	{
		
	}
internal static void a50Sc9FrA2M6jDp2AOj()
	{
		}
internal static object DcYb8HFdvvQfWR44Typ()
	{
		return ThemeManager.GetCurrentTheme();
	}
internal static object Viho8IFiT7MsrlBEJev(int P_0)
	{
		return null;
	}
internal static void H3NMjjFyx0HHrOYWAcc(object P_0)
	{
		((WebSocketServer)P_0).Start();
	}
internal static bool IKpVMwFkhds8AC5Ertv()
	{
		return RIZj2NF4g9xD5hmsgvy == null;
	}
internal static MainUI SUnoB1FjXV7Ku2WFZrw()
	{
		return RIZj2NF4g9xD5hmsgvy;
	}
internal static object IyFFN5FwqAgvH6KNc9X(object P_0, object P_1)
	{
		return ((Potassium_UI_V2.Views.Settings.Settings)P_0).GetSettingValueString((string)P_1);
	}
internal static double Su5vChFA6qgZfu4FSPH()
	{
		return AppData.ConsoleHeight;
	}
internal static void oUbNtqFaNd2Ibpf6373(double value)
	{
		AppData.ConsoleHeight = value;
	}
internal static void aNDpZ0FxQ9dqSX6wjed(object P_0, object P_1)
	{
		((Dispatcher)P_0).Invoke((Action)P_1);
	}
internal static Color ipkhYvFSNlRuIfCpIEJ(object P_0)
	{
		return ThemeManager.GetColor((string)P_0);
	}
internal static void gaXCK1Fv10om3JkoAvQ(object P_0)
	{
		TFGWXCruRS(P_0);
	}
internal static void yRFQASF0BxlK5KWswWB(object P_0)
	{
		((TextElementCollection<Inline>)P_0).Clear();
	}
internal static object MNwLc6FNUqSjV3UTGmB(object P_0)
	{
		return ((ConsoleEntry)P_0).Timestamp;
	}
internal static object q1THCjFUvejp4fcNqIp(object P_0)
	{
		return ((ConsoleEntry)P_0).Message;
	}
internal static void JDnKQXF9QvnTsCLlCn8()
	{
		}
}
