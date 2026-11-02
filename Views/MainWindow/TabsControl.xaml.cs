using Border = System.Windows.Controls.Border;
using ScrollViewer = System.Windows.Controls.ScrollViewer;
using TextBox = System.Windows.Controls.TextBox;
using Timer = System.Timers.Timer;
using Button = System.Windows.Controls.Button;
using CheckBox = System.Windows.Controls.CheckBox;
using Popup = System.Windows.Controls.Primitives.Popup;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using TextBlock = System.Windows.Controls.TextBlock;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.Wpf;
using Potassium_UI_V2.Services;

namespace Potassium_UI_V2.Views.MainWindow;

public partial class TabsControl : UserControl
{
	[CompilerGenerated]
	private sealed class _c__DisplayClass14_0
	{
		[StructLayout(LayoutKind.Auto)]
		private struct CXNMTLt0Hk8jCXysMW2 : IAsyncStateMachine
		{
			public int fcitNGJRRk;

			public AsyncVoidMethodBuilder hiAtUFxWdE;

			public CoreWebView2NavigationCompletedEventArgs gMqt9RRY9S;

			public _c__DisplayClass14_0 Dn7tehVpyL;

			private TaskAwaiter<string> qftt1hwKuJ;

			internal static object zayRinKZsWZQLPh6BuM;
public void MoveNext()
			{
				int num = 5;
				int num2 = num;
				int num3 = default(int);
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(DefaultInterpolatedStringHandler);
				TaskAwaiter<string> awaiter = default(TaskAwaiter<string>);
				ThemeDefinition currentTheme = default(ThemeDefinition);
				_c__DisplayClass14_0 _c__DisplayClass14_ = default(_c__DisplayClass14_0);
				string text7 = default(string);
				string text5 = default(string);
				string text6 = default(string);
				string result = default(string);
				string text4 = default(string);
				string text = default(string);
				string text8 = default(string);
				string text2 = default(string);
				string text3 = default(string);
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
							int num5;
							switch (num3)
							{
							default:
								num4 = 1;								goto IL_0076;
							case 0:
								num4 = 13;
								goto IL_0076;
							case 3:
								goto IL_080d;
							case 2:
								goto IL_083c;
							case 1:
								goto IL_08c8;
								IL_0072:
								num4 = num5;
								goto IL_0076;
								IL_0076:
								while (true)
								{
									object obj2;
									object obj;
									switch (num4)
									{
									default:
										return;
									case 15:
										num4 = 34;
										continue;
									case 7:
										if (!awaiter.IsCompleted)
										{
											num4 = 3;
											continue;
										}
										goto case 41;
									case 12:
										currentTheme = ThemeManager.GetCurrentTheme();
										num4 = 2;
										continue;
									case 4:
										try
										{
											int num11;
											if (num3 != 3)
											{
												num11 = 8;
												goto IL_01a9;
											}
											goto IL_02fb;
											IL_02fb:
											awaiter = qftt1hwKuJ;
											num11 = 2;
											goto IL_01a9;
											IL_01a9:
											while (true)
											{
												switch (num11)
												{
												case 11:
													return;
												default:
													if (awaiter.IsCompleted)
													{
														num11 = 7;
														continue;
													}
													goto case 3;
												case 3:
													num3 = (fcitNGJRRk = 3);
													num11 = 5;
													continue;
												case 9:
													num3 = (fcitNGJRRk = -1);
													num11 = 1;													continue;
												case 6:
													hiAtUFxWdE.AwaitUnsafeOnCompleted(ref awaiter, ref this);
													num11 = 11;
													continue;
												case 5:
													qftt1hwKuJ = awaiter;
													num11 = 4;													continue;
												case 8:
													awaiter = default;
													num11 = 0;													continue;
												case 2:
													qftt1hwKuJ = default(TaskAwaiter<string>);
													num11 = 9;
													continue;
												case 10:
													break;
												case 4:
												case 7:
													awaiter.GetResult();
													num11 = 0;													continue;
												case 1:
													goto end_IL_01a9;
												}
												goto IL_02fb;
												continue;
												end_IL_01a9:
												break;
											}
										}
										catch
										{
											int num12 = 0;											switch (num12)
											{
											case 0:
												break;
											}
										}
										goto case 16;
									case 8:
										qftt1hwKuJ = awaiter;
										num4 = 10;										continue;
									case 38:
										text5 = JsonSerializer.Serialize(_c__DisplayClass14_.ai5IqNE54j);
										num4 = 1;										continue;
									case 9:
										num4 = 4;										continue;
									case 33:
										num3 = (fcitNGJRRk = -1);
										num4 = 23;										continue;
									case 34:
										num4 = 32;										continue;
									case 21:
										if (true)
										{
											num4 = 36;
											continue;
										}
										goto case 1;
									case 10:
										hiAtUFxWdE.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										num4 = 0;										continue;
									case 37:
										break;
									case 1:
									case 5:
										if (false)
										{
											num4 = 6;											continue;
										}
										goto case 38;
									case 13:
										try
										{
											int num9;
											if (num3 == 0)
											{
												num9 = 8;
												goto IL_0522;
											}
											goto IL_05cc;
											IL_05cc:
											awaiter = default;
											num9 = 12;
											goto IL_0522;
											IL_0522:
											while (true)
											{
												switch (num9)
												{
												case 3:
												case 7:
													awaiter.GetResult();
													num9 = 11;													continue;
												case 2:
													qftt1hwKuJ = awaiter;
													num9 = 5;
													continue;
												case 10:
													return;
												case 4:
													break;
												case 9:
													num3 = (fcitNGJRRk = -1);
													num9 = 3;
													continue;
												case 1:
												case 8:
													awaiter = qftt1hwKuJ;
													num9 = 0;													continue;
												default:
													qftt1hwKuJ = default(TaskAwaiter<string>);
													num9 = 9;
													continue;
												case 12:
													if (awaiter.IsCompleted)
													{
														num9 = 2;														continue;
													}
													goto case 6;
												case 5:
													hiAtUFxWdE.AwaitUnsafeOnCompleted(ref awaiter, ref this);
													num9 = 6;													continue;
												case 6:
													num3 = (fcitNGJRRk = 0);
													num9 = 2;
													continue;
												case 11:
													goto end_IL_0522;
												}
												goto IL_05cc;
												continue;
												end_IL_0522:
												break;
											}
										}
										catch
										{
											int num10 = 0;											switch (num10)
											{
											case 0:
												break;
											}
										}
										goto case 12;
									case 40:
										goto IL_0717;
									case 28:
										awaiter = RnNW5qfBAn(LtrJZBKYFighbeCnA2G(currentTheme)).GetAwaiter();
										num4 = 7;										continue;
									case 27:
										if (false)
										{
											num4 = 5;											continue;
										}
										goto case 28;
									case 14:
										text = null;
										num4 = 27;										continue;
									case 0:
										return;
									case 31:
										goto IL_080d;
									case 41:
										result = awaiter.GetResult();
										num4 = 21;
										continue;
									case 2:
										if (currentTheme != null)
										{
											num4 = 27;
											continue;
										}
										goto case 1;
									case 42:
										goto IL_083c;
									case 22:
										goto end_IL_003e;
									case 32:
										num4 = 39;										continue;
									case 26:
										goto IL_08c8;
									case 30:
										text7 = null;
										num4 = 31;
										continue;
									case 36:
										text8 = null;
										num4 = 14;
										continue;
									case 3:
										num3 = (fcitNGJRRk = 1);
										num4 = 8;
										continue;
									case 20:
										num4 = 44;
										continue;
									case 44:
										num4 = 39;										continue;
									case 43:
										num4 = 15;
										continue;
									case 39:
										text4 = null;
										num4 = 37;
										continue;
									case 18:
										if (true)
										{
											num4 = 22;											continue;
										}
										goto case 11;
									case 24:
										try
										{
											int num6;
											if (num3 != 2)
											{
												num6 = 0;												goto IL_0ad9;
											}
											goto IL_0b66;
											IL_0ad9:
											while (true)
											{
												switch (num6)
												{
												default:
													qftt1hwKuJ = default(TaskAwaiter<string>);
													num6 = 8;													continue;
												case 11:
												{
													awaiter = default;
													int num7 = 3;
													num6 = num7;
													continue;
												}
												case 9:
													break;
												case 10:
													return;
												case 3:
													if (awaiter.IsCompleted)
													{
														num6 = 4;
														continue;
													}
													goto case 6;
												case 2:
													qftt1hwKuJ = awaiter;
													num6 = 0;													continue;
												case 1:
													hiAtUFxWdE.AwaitUnsafeOnCompleted(ref awaiter, ref this);
													num6 = 10;
													continue;
												case 4:
												case 5:
													awaiter.GetResult();
													num6 = 5;													continue;
												case 6:
													num3 = (fcitNGJRRk = 2);
													num6 = 2;													continue;
												case 8:
													num3 = (fcitNGJRRk = -1);
													num6 = 5;
													continue;
												case 7:
													goto end_IL_0ad9;
												}
												goto IL_0b66;
												continue;
												end_IL_0ad9:
												break;
											}
											goto end_IL_0aae;
											IL_0b66:
											awaiter = qftt1hwKuJ;
											num6 = 0;											goto IL_0ad9;
											end_IL_0aae:;
										}
										catch
										{
											int num8 = 0;											switch (num8)
											{
											case 0:
												break;
											}
										}
										goto case 1;
									case 25:
										qftt1hwKuJ = default(TaskAwaiter<string>);
										num4 = 33;
										continue;
									case 11:
									{
										object obj4 = OxhSG4KbOmoy4aiaqHj();
										if (obj4 == null)
										{
											num4 = 29;
											continue;
										}
										obj2 = ((ThemeDefinition)obj4).Colors;
										goto IL_0d10;
									}
									case 29:
										obj2 = null;
										goto IL_0d10;
									case 19:
										obj = null;
										goto IL_0e61;
									case 6:
										obj = null;
										goto IL_0e98;
									case 16:
									case 17:
									{
										Action<WebView2>? action = _c__DisplayClass14_.I64IU2btj4.WgtDIDvO9H;
										if (action == null)
										{
											num4 = 23;
											continue;
										}
										action(_c__DisplayClass14_.gOoI1hObsF);
										num4 = 26;										continue;
									}
									case 23:
										goto end_IL_003e;
									case 35:
										goto end_IL_003e;
										IL_0d10:
										text2 = (string)(((IReadOnlyDictionary<string, string>)obj2)?.GetValueOrDefault("\\*\" \"", (string)KmOOosK3fCBMyvL6anM(0x3365D46D ^ 0)) ?? KmOOosK3fCBMyvL6anM(0x1BCA2B7D ^ 0));
										text3 = (string)(((IReadOnlyDictionary<string, string>)obj2)?.GetValueOrDefault((string)KmOOosK3fCBMyvL6anM(0xF2D69C5 ^ 0), "#C7C7C7") ?? KmOOosK3fCBMyvL6anM(0x1BCA2B93 ^ 0));
										if (obj2 == null)
										{
											num4 = 19;											continue;
										}
										obj = ((IReadOnlyDictionary<string, string>)obj2).GetValueOrDefault((string)KmOOosK3fCBMyvL6anM(0xBC0639A ^ 0), "#70000000");
										goto IL_0e61;
										IL_0e61:
										if (obj != null)
										{
											goto IL_0e98;
										}
										num4 = 6;
										continue;
										IL_0e98:
										text6 = (string)obj;
										num4 = 40;
										continue;
									}
									break;
								}
								goto case 0;
								IL_08c8:
								awaiter = qftt1hwKuJ;
								num4 = 2;								goto IL_0076;
								IL_083c:
								num5 = 24;
								goto IL_0072;
								IL_080d:
								num4 = 4;
								goto IL_0076;
								IL_0717:
								defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(345, 3);
								num5 = 9;
								goto IL_0072;
								end_IL_003e:
								break;
							}
						}
						catch (Exception ex)
						{
							int num13 = 1;							while (true)
							{
								switch (num13)
								{
								case 1:
									fcitNGJRRk = -2;
									num13 = 0;									break;
								default:
									num13 = 1;									break;
								case 2:
									return;
								}
							}
						}
						goto case 2;
					case 2:
						fcitNGJRRk = -2;
						num2 = 3;
						break;
					case 4:
						_c__DisplayClass14_ = Dn7tehVpyL;
						num2 = 0;						break;
					case 0:
						return;
					case 5:
						num3 = fcitNGJRRk;
						num2 = 4;
						break;
					case 3:
						num2 = 0;						break;
					}
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
					case 1:
						num2 = 0;						break;
					case 0:
						return;
					}
				}
			}

			/* IAsyncStateMachine\.SetStateMachine removed */
static CXNMTLt0Hk8jCXysMW2()
			{
				}
internal static object OxhSG4KbOmoy4aiaqHj()
			{
				return ThemeManager.GetCurrentTheme();
			}
internal static object KmOOosK3fCBMyvL6anM(int P_0)
			{
				return null;
			}
internal static object LtrJZBKYFighbeCnA2G(object P_0)
			{
				return ((ThemeDefinition)P_0).EditorImage;
			}
internal static bool jfjrn3KGbXX048vhSan()
			{
				return zayRinKZsWZQLPh6BuM == null;
			}
internal static object t3UJs7KQRbikmg3Dw0h()
			{
				return zayRinKZsWZQLPh6BuM;
			}
		}

		public TabsControl I64IU2btj4;

		public Button rrEI9hqRo0;

		public Border EgBIe5R4As;

		public WebView2 gOoI1hObsF;

		public string ai5IqNE54j;

		internal static _c__DisplayClass14_0 ovl67ATCtMsUrNcTgCf;
public _c__DisplayClass14_0()
		{
			CDqvTkTsPsxFKEpEu2g();
			FbinTBT8qDyKFHVBGdm();
int num = 0;			switch (num)
			{
			case 0:
				break;
			}
		}

		// [DEOBFUSCATED] Control flow flattening detected (initial state: 1)
internal void Lk2IaX5hyI(object s, RoutedEventArgs args)
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
					I64IU2btj4.IIRWcGRgDL(rrEI9hqRo0);
					num2 = 0;					break;
				}
			}
		}

		// [DEOBFUSCATED] Control flow flattening detected (initial state: 1)
internal void cCWIxtYPA4(object s, RoutedEventArgs e)
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
					I64IU2btj4.wFQWVSyWwP(rrEI9hqRo0);
					num2 = 0;					break;
				case 0:
					return;
				}
			}
		}

		// [DEOBFUSCATED] Control flow flattening detected (initial state: 1)
internal void BFSIS8ACNS(object s, MouseButtonEventArgs e)
		{
		int num = 1;
		int num2 = num;
		while (true)
		{
		switch (num2)
				{
				case 2:
					return;
				case 1:
					num2 = 0;					break;
				default:
					num2 = 2;					break;
				}
			}
		}
internal void v8qIv7K589(object s, MouseEventArgs args)
		{
			int num = 3;
			int num2 = num;
			ColorAnimation colorAnimation = default(ColorAnimation);
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 4:
					num2 = 0;					break;
				case 1:
					num2 = 1;					break;
				case 2:
					return;
				case 3:
					if (rrEI9hqRo0 != I64IU2btj4.y9JD7OvtqB)
					{
						colorAnimation = new ColorAnimation(KSXioeTTl01vxLZdVyb(MHXOogTJajKN2kOWo7e(0x16338253 ^ 0)), default(Duration));
						num2 = 1;					}
					else
					{
						num2 = 0;					}
					break;
				case 0:
					return;
				}
			}
		}
internal void rONI0WpJaa(object s, MouseEventArgs args)
		{
			int num = 1;
			ColorAnimation colorAnimation = default(ColorAnimation);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 2:
						return;
					case 1:
						if (rrEI9hqRo0 != I64IU2btj4.y9JD7OvtqB)
						{
							goto end_IL_0019;
						}
						num2 = 0;						break;
					case 4:
						num2 = 3;
						break;
					case 0:
						return;
					case 3:
						num2 = 0;						break;
					}
					continue;
					end_IL_0019:
					break;
				}
				colorAnimation = new ColorAnimation(KSXioeTTl01vxLZdVyb(null), default(Duration));
				num = 4;
			}
		}
[AsyncStateMachine(typeof(CXNMTLt0Hk8jCXysMW2))]
		internal void malINZvbtJ(object? _, CoreWebView2NavigationCompletedEventArgs args)
		{
			CXNMTLt0Hk8jCXysMW2 stateMachine = default(CXNMTLt0Hk8jCXysMW2);
			stateMachine.hiAtUFxWdE = default;
			stateMachine.Dn7tehVpyL = this;
			stateMachine.gMqt9RRY9S = args;
			stateMachine.fcitNGJRRk = -1;
			stateMachine.hiAtUFxWdE.Start(ref stateMachine);
		}
static _c__DisplayClass14_0()
		{
			}
internal static void CDqvTkTsPsxFKEpEu2g()
		{
			
		}
internal static void FbinTBT8qDyKFHVBGdm()
		{
			}
internal static bool SGKNupTFsAJhF2y6PWO()
		{
			return ovl67ATCtMsUrNcTgCf == null;
		}
internal static _c__DisplayClass14_0 MD15HWTOEson4V2KaCh()
		{
			return ovl67ATCtMsUrNcTgCf;
		}
internal static object MHXOogTJajKN2kOWo7e(int P_0)
		{
			return null;
		}
internal static Color KSXioeTTl01vxLZdVyb(object P_0)
		{
			return ThemeManager.GetColor((string)P_0);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _ApplyEditorColorsAsync_d__25 : IAsyncStateMachine
	{
		public int _state1;

		public AsyncTaskMethodBuilder _asyncBuilder;

		public string bgColor;

		public string lineHighlight;

		public string lineHighlightBorder;

		public TabsControl _this4;

		private string _script5__2;

		private Dictionary<Button, WebView2>.ValueCollection.Enumerator _wrap7_2;

		private TaskAwaiter<string> _awaiter_1;

		private static object Flvp8xTE4dueRGsI72C;
public void MoveNext()
		{
			int num = 3;
			int num2 = num;
			int num3 = default(int);
			TabsControl tabsControl = default(TabsControl);
			WebView2 current = default(WebView2);
			TaskAwaiter<string> awaiter = default(TaskAwaiter<string>);
			while (true)
			{
				switch (num2)
				{
				case 1:
					return;
				default:
					num2 = 1;					break;
				case 3:
					num3 = _state1;
					num2 = 2;					break;
				case 5:
					try
					{
						int num4;
						if (num3 == 0)
						{
							num4 = 0;							goto IL_00c1;
						}
						goto IL_04ed;
						IL_00c1:
						while (true)
						{
							switch (num4)
							{
							case 2:
								_wrap7_2 = default(Dictionary<Button, WebView2>.ValueCollection.Enumerator);
								num4 = 5;								continue;
							case 3:
								_wrap7_2 = tabsControl.J7cDD1I2ny.Values.GetEnumerator();
								num4 = 1;								continue;
							case 6:
								try
								{
									int num5;
									if (num3 != 0)
									{
										num5 = 3;
										goto IL_0182;
									}
									goto IL_0465;
									IL_0465:
									num5 = 5;
									goto IL_0182;
									IL_0182:
									while (true)
									{
										switch (num5)
										{
										default:
											goto end_IL_0182;
										case 1:
											current = _wrap7_2.Current;
											num5 = 2;
											continue;
										case 5:
											try
											{
												int num6;
												if (num3 == 0)
												{
													num6 = 12;
													goto IL_01d1;
												}
												goto IL_0384;
												IL_0384:
												if (0 != null)
												{
													num6 = 4;
													goto IL_01d1;
												}
												goto end_IL_01bc;
												IL_01d1:
												while (true)
												{
													switch (num6)
													{
													case 1:
														return;
													case 3:
														num3 = (_state1 = -1);
														num6 = 6;														continue;
													case 10:
														num3 = (_state1 = 0);
														num6 = 3;														continue;
													case 8:
														_awaiter_1 = default(TaskAwaiter<string>);
														num6 = 3;
														continue;
													default:
														awaiter.GetResult();
														num6 = 2;														continue;
													case 5:
														if (awaiter.IsCompleted)
														{
															num6 = 0;															continue;
														}
														goto case 10;
													case 4:
														awaiter = default;
														num6 = 5;
														continue;
													case 7:
														_awaiter_1 = awaiter;
														num6 = 13;														continue;
													case 11:
													case 12:
														awaiter = _awaiter_1;
														num6 = 8;														continue;
													case 9:
														break;
													case 13:
														_asyncBuilder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
														num6 = 1;														continue;
													case 2:
														goto end_IL_01d1;
													}
													goto IL_0384;
													continue;
													end_IL_01d1:
													break;
												}
												end_IL_01bc:;
											}
											catch
											{
												int num7 = 0;												switch (num7)
												{
												case 0:
													break;
												}
											}
											goto case 3;
										case 3:
										case 4:
											if (!_wrap7_2.MoveNext())
											{
												num5 = 0;												continue;
											}
											goto case 1;
										case 2:
											break;
										case 0:
											goto end_IL_0182;
										}
										goto IL_0465;
										continue;
										end_IL_0182:
										break;
									}
								}
								finally
								{
									if (num3 < 0)
									{
										int num8 = 1;										while (true)
										{
											switch (num8)
											{
											case 1:
												((IDisposable)_wrap7_2/*cast due to .constrained prefix*/).Dispose();
												num8 = 0;												continue;
											case 0:
												break;
											}
											break;
										}
									}
								}
								goto case 2;
							case 4:
								break;
							default:
								num4 = 6;								continue;
							case 5:
								goto end_IL_00c1;
							}
							goto IL_04ed;
							continue;
							end_IL_00c1:
							break;
						}
						goto end_IL_0097;
						IL_04ed:
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(65, 3);
						_script5__2 = null;
						num4 = 3;						goto IL_00c1;
						end_IL_0097:;
					}
					catch (Exception ex)
					{
						int num9 = 1;						while (true)
						{
							switch (num9)
							{
							case 2:
								return;
							default:
								_script5__2 = null;
								num9 = 2;								break;
							case 1:
								_state1 = -2;
								num9 = 0;								break;
							case 3:
								num9 = 2;
								break;
							}
						}
					}
					goto case 4;
				case 4:
					_state1 = -2;
					num2 = 6;
					break;
				case 2:
					tabsControl = _this4;
					num2 = 5;
					break;
				case 6:
					_script5__2 = null;
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
				case 1:
					num2 = 0;					break;
				case 0:
					return;
				}
			}
		}

		/* IAsyncStateMachine\.SetStateMachine removed */
static _ApplyEditorColorsAsync_d__25()
	{
	}
internal static object RgnHm0TuNnfkyr3eAjI(int P_0)
		{
			return null;
		}
internal static bool VCdha2TKQNcuZ2Oi8NU()
		{
			return Flvp8xTE4dueRGsI72C == null;
		}
internal static object mwN7paTLcruLwyLbSMR()
		{
			return Flvp8xTE4dueRGsI72C;
		}
internal static void YuULKVTfXInq6OUACJ9()
		{
			}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _ApplyEditorImageAsync_d__27 : IAsyncStateMachine
	{
		public int _state1;

		public AsyncTaskMethodBuilder _asyncBuilder;

		public string imageSource;

		public TabsControl _this4;

		private string _script5__2;

		private TaskAwaiter<string> _awaiter_1;

		private Dictionary<Button, WebView2>.ValueCollection.Enumerator _wrap7_2;

		internal static object DB9YEITliO7Fm5OO2pe;
public void MoveNext()
		{
			int num = 2;
			int num2 = num;
			int num3 = default(int);
			TaskAwaiter<string> awaiter = default(TaskAwaiter<string>);
			string text = default(string);
			TabsControl tabsControl = default(TabsControl);
			WebView2 current = default(WebView2);
			while (true)
			{
				switch (num2)
				{
				case 2:
					num3 = _state1;
					num2 = 0;					break;
				default:
					num2 = 3;
					break;
				case 4:
					_state1 = -2;
					num2 = 0;					break;
				case 5:
					try
					{
						int num4;
						if (num3 == 0)
						{
							num4 = 4;
							goto IL_00bd;
						}
						goto IL_0150;
						IL_0150:
						if (num3 != 1)
						{
							num4 = 16;
							goto IL_00bd;
						}
						goto IL_0370;
						IL_00bd:
						while (true)
						{
							int num10;
							switch (num4)
							{
							case 3:
								_wrap7_2 = default(Dictionary<Button, WebView2>.ValueCollection.Enumerator);
								num10 = 11;
								goto IL_00b9;
							case 2:
								_awaiter_1 = awaiter;
								num4 = 9;								continue;
							case 17:
								break;
							case 6:
								_script5__2 = null;
								num4 = 0;								continue;
							case 15:
								text = null;
								num4 = 6;
								continue;
							case 16:
								awaiter = RnNW5qfBAn(imageSource).GetAwaiter();
								num4 = 10;								continue;
							case 9:
								_asyncBuilder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num4 = 14;
								continue;
							case 7:
								num3 = (_state1 = -1);
								num4 = 15;
								continue;
							case 12:
								num3 = (_state1 = 0);
								num4 = 2;
								continue;
							default:
								_wrap7_2 = tabsControl.J7cDD1I2ny.Values.GetEnumerator();
								num4 = 8;
								continue;
							case 13:
								_awaiter_1 = default(TaskAwaiter<string>);
								num10 = 7;
								goto IL_00b9;
							case 14:
								return;
							case 10:
								if (!awaiter.IsCompleted)
								{
									num4 = 12;
									continue;
								}
								goto case 15;
							case 4:
							case 5:
								awaiter = _awaiter_1;
								num4 = 13;								continue;
							case 8:
								goto IL_0370;
							case 1:
								try
								{
									int num5;
									if (num3 != 1)
									{
										num5 = 5;
										goto IL_03a7;
									}
									goto IL_0621;
									IL_0621:
									num5 = 2;									goto IL_03a7;
									IL_03a7:
									while (true)
									{
										switch (num5)
										{
										default:
											goto end_IL_03a7;
										case 3:
											current = _wrap7_2.Current;
											num5 = 4;
											continue;
										case 2:
											try
											{
												int num6;
												if (num3 != 1)
												{
													num6 = 11;
													goto IL_041b;
												}
												goto IL_04ee;
												IL_04ee:
												awaiter = _awaiter_1;
												int num7 = 10;
												goto IL_041f;
												IL_041b:
												num7 = num6;
												goto IL_041f;
												IL_041f:
												while (true)
												{
													switch (num7)
													{
													case 10:
														_awaiter_1 = default(TaskAwaiter<string>);
														num7 = 9;														continue;
													default:
														awaiter.GetResult();
														num7 = 4;														continue;
													case 4:
														return;
													case 13:
														num3 = (_state1 = 1);
														num7 = 5;
														continue;
													case 2:
														_asyncBuilder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
														num7 = 4;
														continue;
													case 12:
														break;
													case 5:
														goto IL_0500;
													case 11:
														if (0 == null)
														{
															num7 = 6;
															continue;
														}
														goto case 3;
													case 1:
														if (awaiter.IsCompleted)
														{
															num7 = 0;															continue;
														}
														goto case 13;
													case 9:
														num3 = (_state1 = -1);
														num7 = 8;
														continue;
													case 3:
														awaiter = default;
														num7 = 0;														continue;
													case 6:
														goto end_IL_0405;
													case 7:
														goto end_IL_0405;
													}
													break;
												}
												goto IL_04ee;
												IL_0500:
												_awaiter_1 = awaiter;
												num6 = 2;
												goto IL_041b;
												end_IL_0405:;
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
										case 4:
											break;
										case 1:
										case 5:
											if (!_wrap7_2.MoveNext())
											{
												num5 = 0;												continue;
											}
											goto case 3;
										case 0:
											goto end_IL_03a7;
										}
										goto IL_0621;
										continue;
										end_IL_03a7:
										break;
									}
								}
								finally
								{
									if (num3 < 0)
									{
										int num9 = 1;										while (true)
										{
											switch (num9)
											{
											case 1:
												((IDisposable)_wrap7_2/*cast due to .constrained prefix*/).Dispose();
												num9 = 0;												continue;
											case 0:
												break;
											}
											break;
										}
									}
								}
								goto case 3;
							case 11:
								goto end_IL_00a8;
								IL_00b9:
								num4 = num10;
								continue;
							}
							break;
						}
						goto IL_0150;
						IL_0370:
						num4 = 1;						goto IL_00bd;
						end_IL_00a8:;
					}
					catch (Exception ex)
					{
						int num11 = 2;
						while (true)
						{
							switch (num11)
							{
							case 2:
								_state1 = -2;
								num11 = 3;
								break;
							case 3:
								_script5__2 = null;
								num11 = 0;								break;
							default:
								num11 = 1;								break;
							case 1:
								return;
							}
						}
					}
					goto case 4;
				case 6:
					_script5__2 = null;
					num2 = 0;					break;
				case 1:
					tabsControl = _this4;
					num2 = 5;					break;
				case 3:
					return;
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
static _ApplyEditorImageAsync_d__27()
	{
	}
internal static object OEu4C0T2FuOM70Y4Sgs(int P_0)
		{
			return null;
		}
internal static bool UwNZIJTHYlfs6hUU7yT()
		{
			return DB9YEITliO7Fm5OO2pe == null;
		}
internal static object qcObN3Tnuu8m3Vn4PpF()
		{
			return DB9YEITliO7Fm5OO2pe;
		}
internal static void xoAAvuToADfDpTG4mJj()
		{
			}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _ResolveEditorImageDataUrlAsync_d__28 : IAsyncStateMachine
	{
		public int _state1;

		public AsyncTaskMethodBuilder<string> _asyncBuilder;

		public string imageSource;

		private string _filePath2;

		private TaskAwaiter<byte[]> _awaiter_1;

		private static object bjxixbTVnSNOewPqka0;
public void MoveNext()
		{
			int num = 5;
			int num2 = num;
			int num3 = default(int);
			TaskAwaiter<byte[]> awaiter = default(TaskAwaiter<byte[]>);
			string text2 = default(string);
			byte[] result3 = default(byte[]);
			string result = default(string);
			string text = default(string);
			byte[] result2 = default(byte[]);
			while (true)
			{
				switch (num2)
				{
				case 5:
					num3 = _state1;
					num2 = 4;					break;
				case 4:
					try
					{
						int num4;
						if (num3 != 0)
						{
							num4 = 0;							goto IL_008d;
						}
						goto IL_05a9;
						IL_008d:
						while (true)
						{
							switch (num4)
							{
							case 10:
								try
								{
									int num9;
									if (num3 == 0)
									{
										num9 = 1;										goto IL_0121;
									}
									goto IL_0218;
									IL_0121:
									while (true)
									{
										switch (num9)
										{
										case 3:
											return;
										case 12:
											num3 = (_state1 = -1);
											num9 = 0;											continue;
										case 10:
											_asyncBuilder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
											num9 = 3;
											continue;
										case 4:
										case 13:
											awaiter = _awaiter_1;
											num9 = 7;
											continue;
										case 11:
											text2 = (string)Yrepv6TGekukq48Gua9(imageSource, result3);
											num9 = 6;
											continue;
										case 2:
											_awaiter_1 = awaiter;
											num9 = 10;
											continue;
										case 8:
											break;
										case 9:
											num3 = (_state1 = 0);
											num9 = 2;											continue;
										case 1:
											result3 = awaiter.GetResult();
											num9 = 11;
											continue;
										case 6:
											result = null;
											num9 = 3;											continue;
										default:
											if (!awaiter.IsCompleted)
											{
												num9 = 3;												continue;
											}
											goto case 1;
										case 7:
											_awaiter_1 = default(TaskAwaiter<byte[]>);
											num9 = 12;											continue;
										case 5:
											goto end_IL_0121;
										}
										goto IL_0218;
										continue;
										end_IL_0121:
										break;
									}
									goto end_IL_00f7;
									IL_0218:
									awaiter = default;
									num9 = 0;									goto IL_0121;
									end_IL_00f7:;
								}
								catch
								{
									int num10 = 0;									while (true)
									{
										switch (num10)
										{
										default:
											result = "";
											num10 = 1;											continue;
										case 1:
											break;
										}
										break;
									}
								}
								goto end_IL_008d;
							case 11:
								if (num3 != 1)
								{
									num4 = 14;
									continue;
								}
								goto case 5;
							case 6:
							case 17:
								if (true)
								{
									int num5 = 16;
									num4 = num5;
									continue;
								}
								break;
							case 16:
								if (true)
								{
									num4 = 8;
									continue;
								}
								break;
							case 14:
								if (true)
								{
									num4 = 1;									continue;
								}
								goto case 13;
							case 2:
								_filePath2 = null;
								num4 = 1;								continue;
							case 18:
								if (false)
								{
									num4 = 19;
									continue;
								}
								goto case 2;
							case 13:
								result = "";
								num4 = 3;								continue;
							default:
								_filePath2 = imageSource;
								num4 = 18;								continue;
							case 12:
								break;
							case 3:
								goto end_IL_008d;
							case 5:
								num4 = 3;								continue;
							case 1:
							case 19:
								if (true)
								{
									num4 = 11;									continue;
								}
								goto case 5;
							case 4:
								try
								{
									int num6;
									if (num3 != 1)
									{
										num6 = 11;
										goto IL_066b;
									}
									goto IL_0714;
									IL_0714:
									awaiter = _awaiter_1;
									num6 = 4;
									goto IL_066b;
									IL_066b:
									while (true)
									{
										switch (num6)
										{
										case 4:
											_awaiter_1 = default(TaskAwaiter<byte[]>);
											num6 = 0;											continue;
										case 11:
											awaiter = default;
											num6 = 8;											continue;
										case 2:
											break;
										case 1:
											result = null;
											num6 = 7;
											continue;
										case 8:
											return;
										case 6:
											text = (string)Yrepv6TGekukq48Gua9(_filePath2, result2);
											num6 = 1;											continue;
										case 12:
											result2 = awaiter.GetResult();
											num6 = 6;
											continue;
										default:
											num3 = (_state1 = -1);
											num6 = 12;
											continue;
										case 10:
											if (!awaiter.IsCompleted)
											{
												int num7 = 5;
												num6 = num7;
												continue;
											}
											goto case 12;
										case 9:
											_awaiter_1 = awaiter;
											num6 = 3;											continue;
										case 5:
											num3 = (_state1 = 1);
											num6 = 7;											continue;
										case 3:
											_asyncBuilder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
											num6 = 8;
											continue;
										case 7:
											goto end_IL_066b;
										}
										goto IL_0714;
										continue;
										end_IL_066b:
										break;
									}
								}
								catch
								{
									int num8 = 1;									while (true)
									{
										switch (num8)
										{
										case 1:
											result = "";
											num8 = 0;											continue;
										case 0:
											break;
										}
										break;
									}
								}
								goto end_IL_008d;
							case 9:
							case 15:
								result = "";
								num4 = 7;								continue;
							case 7:
								goto end_IL_008d;
							}
							goto IL_05a9;
							continue;
							end_IL_008d:
							break;
						}
						goto end_IL_0063;
						IL_05a9:
						num4 = 4;						goto IL_008d;
						end_IL_0063:;
					}
					catch (Exception exception)
					{
						int num11 = 3;
						while (true)
						{
							switch (num11)
							{
							case 3:
								_state1 = -2;
								num11 = 2;
								break;
							case 2:
								_filePath2 = null;
								num11 = 0;								break;
							default:
								_asyncBuilder.SetException(exception);
								num11 = 0;								break;
							case 1:
								return;
							}
						}
					}
					goto case 2;
				case 1:
					return;
				case 2:
					_state1 = -2;
					num2 = 3;
					break;
				case 3:
					_filePath2 = null;
					num2 = 0;					break;
				default:
					_asyncBuilder.SetResult(result);
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
				case 1:
					_asyncBuilder.SetStateMachine(stateMachine);
					num2 = 0;					break;
				case 0:
					return;
				}
			}
		}

		/* IAsyncStateMachine\.SetStateMachine removed */
static _ResolveEditorImageDataUrlAsync_d__28()
	{
	}
internal static object P9ZRAyTZpCdwciadBiu(int P_0)
		{
			return null;
		}
internal static object Yrepv6TGekukq48Gua9(object P_0, object P_1)
		{
			return CKbWz2xyke(P_0, P_1);
		}
internal static bool AL2oE7TcRlKQ4PIf2ry()
		{
			return bjxixbTVnSNOewPqka0 == null;
		}
internal static object JknmywTmxalWKquPcG3()
		{
			return bjxixbTVnSNOewPqka0;
		}
internal static void oVgUckTQ8vPBQNy4JuH()
		{
			}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _SaveTabsAsync_d__24 : IAsyncStateMachine
	{
		public int _state1;

		public AsyncTaskMethodBuilder _asyncBuilder;

		public TabsControl _this4;

		private SavedTabState _previousState2;

		private List<SavedTab> _saved3;

		private int _activeIndex4;

		private int _i5;

		private Dictionary<Button, WebView2>.Enumerator _wrap7_5;

		private string _name7;

		private string _content8;

		private bool _extracted9;

		private TaskAwaiter<string> _awaiter_1;

		private static object udb9T0Tb6ssygPZr8th;
public void MoveNext()
		{
			int num = 5;
			int num2 = num;
			int num3 = default(int);
			TabsControl tabsControl = default(TabsControl);
			TextBlock textBlock = default(TextBlock);
			Button key = default(Button);
			KeyValuePair<Button, WebView2> current = default(KeyValuePair<Button, WebView2>);
			int num11 = default(int);
			WebView2 value = default(WebView2);
			TaskAwaiter<string> awaiter = default(TaskAwaiter<string>);
			string result = default(string);
			while (true)
			{
				switch (num2)
				{
				case 5:
					num3 = _state1;
					num2 = 4;
					continue;
				case 7:
					return;
				default:
					_previousState2 = null;
					num2 = 0;					continue;
				case 4:
					tabsControl = _this4;
					num2 = 1;					continue;
				case 6:
					num2 = 4;					continue;
				case 1:
					try
					{
						int num4;
						if (num3 != 0)
						{
							num4 = 0;							goto IL_00fd;
						}
						goto IL_012f;
						IL_00fd:
						while (true)
						{
							switch (num4)
							{
							case 7:
								break;
							case 8:
								_wrap7_5 = default(Dictionary<Button, WebView2>.Enumerator);
								num4 = 5;
								continue;
							case 2:
								try
								{
									int num5;
									if (num3 != 0)
									{
										num5 = 17;
										goto IL_0166;
									}
									goto IL_0325;
									IL_0325:
									num5 = 9;									goto IL_0166;
									IL_0166:
									while (true)
									{
										switch (num5)
										{
										case 5:
											textBlock = (TextBlock)null;
											num5 = 2;
											continue;
										case 2:
											if (textBlock == null)
											{
												num5 = 16;												continue;
											}
											goto case 23;
										case 11:
											num5 = 5;
											continue;
										case 3:
										case 7:
										case 20:
											_content8 = string.Empty;
											num5 = 2;											continue;
										case 6:
											_extracted9 = false;
											num5 = 1;											continue;
										case 4:
											if (_i5 < edNyX3TzleyFKQBD8xg(_previousState2.Tabs))
											{
												num5 = 18;
												continue;
											}
											goto case 9;
										case 8:
											_content8 = null;
											num5 = 26;
											continue;
										case 24:
											_name7 = null;
											num5 = 8;
											continue;
										case 28:
											key = current.Key;
											num5 = 10;											continue;
										case 1:
											break;
										case 9:
										case 16:
										{
											List<SavedTab> list = _saved3;
											SavedTab savedTab = new SavedTab();
											fkgHTYEWKq2a0DGVW82(savedTab, _name7);
											CplotnEDhnMCIOOMwlQ(savedTab, _content8);
											list.Add(savedTab);
											num5 = 27;
											continue;
										}
										case 23:
											if (false)
											{
												num5 = 7;
												continue;
											}
											goto case 14;
										case 27:
											num11 = _i5;
											num5 = 19;
											continue;
										case 14:
											_name7 = null;
											num5 = 3;											continue;
										case 17:
										case 26:
											if (!_wrap7_5.MoveNext())
											{
												num5 = 22;
												continue;
											}
											goto case 15;
										case 12:
											value = current.Value;
											num5 = 0;											continue;
										case 19:
											_i5 = num11 + 1;
											num5 = 24;
											continue;
										case 15:
											current = _wrap7_5.Current;
											num5 = 28;
											continue;
										case 21:
											if (_extracted9)
											{
												num5 = 16;
												continue;
											}
											goto case 4;
										case 18:
											_content8 = (string)l4IywGEPrWFOIxvLf3u(_previousState2.Tabs[_i5]);
											num5 = 9;
											continue;
										case 25:
											_name7 = null;
											num5 = 11;											continue;
										case 13:
											_activeIndex4 = _i5;
											num5 = 25;
											continue;
										case 10:
											try
											{
												int num6;
												if (num3 == 0)
												{
													num6 = 4;
													goto IL_0564;
												}
												goto IL_0864;
												IL_0864:
												if (0 == null)
												{
													num6 = 18;
													goto IL_0564;
												}
												goto IL_071a;
												IL_0564:
												while (true)
												{
													switch (num6)
													{
													case 7:
														return;
													case 5:
														_awaiter_1 = awaiter;
														num6 = 11;														continue;
													case 4:
													case 17:
														awaiter = _awaiter_1;
														num6 = 10;
														continue;
													case 11:
														_asyncBuilder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
														num6 = 0;														continue;
													case 15:
														try
														{
															_content8 = JsonSerializer.Deserialize<string>(result) ?? string.Empty;
															int num7 = 0;															switch (num7)
															{
															case 0:
																break;
															}
														}
														catch
														{
															int num8 = 0;															while (true)
															{
																switch (num8)
																{
																case 1:
																	_content8 = string.Empty;
																	num8 = 0;																	continue;
																case 0:
																	break;
																}
																break;
															}
														}
														goto case 3;
													case 8:
														if (!awaiter.IsCompleted)
														{
															num6 = 14;															continue;
														}
														goto default;
													case 1:
														break;
													case 10:
													{
														_awaiter_1 = default(TaskAwaiter<string>);
														int num9 = 14;
														num6 = num9;
														continue;
													}
													case 2:
														if (false)
														{
															num6 = 12;
															continue;
														}
														goto case 9;
													case 16:
														num3 = (_state1 = 0);
														num6 = 5;														continue;
													case 18:
														goto end_IL_054f;
													case 3:
														_extracted9 = true;
														num6 = 13;														continue;
													case 9:
														if (false)
														{
															num6 = 15;
															continue;
														}
														goto end_IL_054f;
													case 12:
														goto end_IL_054f;
													case 6:
														goto IL_0864;
													case 14:
														num3 = (_state1 = -1);
														num6 = 0;														continue;
													default:
														result = awaiter.GetResult();
														num6 = 2;
														continue;
													case 13:
														goto end_IL_054f;
													}
													break;
												}
												goto IL_071a;
												IL_071a:
												awaiter = default;
												num6 = 8;												goto IL_0564;
												end_IL_054f:;
											}
											catch
											{
												int num10 = 0;												switch (num10)
												{
												case 0:
													break;
												}
											}
											goto case 21;
										default:
											if (key == tabsControl.y9JD7OvtqB)
											{
												num5 = 3;												continue;
											}
											goto case 25;
										case 22:
											goto end_IL_0166;
										}
										goto IL_0325;
										continue;
										end_IL_0166:
										break;
									}
								}
								finally
								{
									int num12;
									if (num3 >= 0)
									{
										num12 = 2;
										goto IL_0949;
									}
									goto IL_095f;
									IL_095f:
									((IDisposable)_wrap7_5/*cast due to .constrained prefix*/).Dispose();
									num12 = 0;									goto IL_0949;
									IL_0949:
									switch (num12)
									{
									default:
										goto end_IL_0933;
									case 1:
										break;
									case 2:
										goto end_IL_0933;
									case 0:
										goto end_IL_0933;
									}
									goto IL_095f;
									end_IL_0933:;
								}
								goto case 8;
							case 6:
								_saved3 = new List<SavedTab>();
								num4 = 0;								continue;
							case 1:
								_activeIndex4 = 0;
								num4 = 3;
								continue;
							case 5:
							{
								SavedTabState savedTabState = new SavedTabState();
								ABvyYlE7JIl7fFenMSq(savedTabState, _activeIndex4);
								savedTabState.Tabs = _saved3;
								WmW9OiEI3JWjW1OcjOi(savedTabState);
								num4 = 5;								continue;
							}
							default:
								_previousState2 = TabPersistence.Load();
								num4 = 2;								continue;
							case 3:
								_i5 = 0;
								num4 = 4;
								continue;
							case 4:
								_wrap7_5 = tabsControl.J7cDD1I2ny.GetEnumerator();
								num4 = 7;
								continue;
							case 9:
								goto end_IL_00fd;
							}
							goto IL_012f;
							continue;
							end_IL_00fd:
							break;
						}
						goto end_IL_00d3;
						IL_012f:
						num4 = 2;
						goto IL_00fd;
						end_IL_00d3:;
					}
					catch (Exception ex)
					{
						int num13 = 3;
						while (true)
						{
							switch (num13)
							{
							case 2:
								return;
							case 4:
								_previousState2 = null;
								num13 = 0;								break;
							case 3:
								_state1 = -2;
								num13 = 4;
								break;
							default:
								_saved3 = null;
								num13 = 1;								break;
							case 1:
							{
								int num14 = 2;
								num13 = num14;
								break;
							}
							}
						}
					}
					break;
				case 2:
					_saved3 = null;
					num2 = 6;					continue;
				case 3:
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
static _SaveTabsAsync_d__24()
	{
	}
internal static object jy3E8rT5YT7eRQGIowM(int P_0)
		{
			return null;
		}
internal static int edNyX3TzleyFKQBD8xg(object P_0)
		{
			return ((List<SavedTab>)P_0).Count;
		}
internal static object l4IywGEPrWFOIxvLf3u(object P_0)
		{
			return ((SavedTab)P_0).Content;
		}
internal static void fkgHTYEWKq2a0DGVW82(object P_0, object P_1)
		{
			((SavedTab)P_0).Name = (string)P_1;
		}
internal static void CplotnEDhnMCIOOMwlQ(object P_0, object P_1)
		{
			((SavedTab)P_0).Content = (string)P_1;
		}
internal static void ABvyYlE7JIl7fFenMSq(object P_0, int value)
		{
			((SavedTabState)P_0).ActiveIndex = value;
		}
internal static void WmW9OiEI3JWjW1OcjOi(object P_0)
		{
			TabPersistence.Save((SavedTabState)P_0);
		}
internal static bool QMDDndT35fn5si1iBQc()
		{
			return udb9T0Tb6ssygPZr8th == null;
		}
internal static object tO4mWKTYJGacpxuuiXs()
		{
			return udb9T0Tb6ssygPZr8th;
		}
internal static void FhidsvEtiXLl1T3nu13()
		{
			}
	}

	private readonly Dictionary<Button, WebView2> J7cDD1I2ny;

	public WebView2? currentWebView;

	private Button? y9JD7OvtqB;

	[CompilerGenerated]
	private Action<WebView2>? WgtDIDvO9H;

	private double FZDDtkUDSm;

	private bool m8nDgbNrb2;

	private static readonly HttpClient SgFDRJ6t9X;

							private bool r9oDhZjGm6;

	private static TabsControl xwVUv6FFyVRRBZasnwE;

	public IEnumerable<WebView2> AllWebViews
	{
get
		{
			return J7cDD1I2ny.Values;
		}
	}

	public event Action<WebView2>? TabReady
	{
[CompilerGenerated]
		add
		{
			Action<WebView2> action = WgtDIDvO9H;
			Action<WebView2> action2;
			do
			{
				action2 = action;
				Action<WebView2> value2 = (Action<WebView2>)null;
				action = Interlocked.CompareExchange(ref WgtDIDvO9H, value2, action2);
			}
			while ((object)action != action2);
		}
[CompilerGenerated]
		remove
		{
			Action<WebView2> action = WgtDIDvO9H;
			Action<WebView2> action2;
			do
			{
				action2 = action;
				Action<WebView2> value2 = (Action<WebView2>)null;
				action = Interlocked.CompareExchange(ref WgtDIDvO9H, value2, action2);
			}
			while ((object)action != action2);
		}
	}
public TabsControl()
	{
		J7cDD1I2ny = new Dictionary<Button, WebView2>();
		InitializeComponent();
		Loaded += (s, e) => AddNewTab();
	}

	// [DEOBFUSCATED] Control flow flattening detected (initial state: 1)
private void hBZW222hLV(ThemeDefinition P_0)
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
				_ = new Action(
() =>
				{
					int num3 = 1;
					int num4 = num3;
					Dictionary<Button, WebView2>.KeyCollection.Enumerator enumerator = default(Dictionary<Button, WebView2>.KeyCollection.Enumerator);
					Button current = default(Button);
					Color color = default(Color);
					DropShadowEffect dropShadowEffect = default(DropShadowEffect);
					Border border2 = default(Border);
					Border border = default(Border);
					Grid grid = default(Grid);
					Color color2 = default(Color);
					Color color4 = default(Color);
					Color color5 = default(Color);
					TextBlock textBlock = default(TextBlock);
					while (true)
					{
						switch (num4)
						{
						case 2:
							return;
						default:
							try
							{
								while (true)
								{
									int num5;
									if (!enumerator.MoveNext())
									{
										num5 = 0;										goto IL_0044;
									}
									goto IL_045e;
									IL_045e:
									current = enumerator.Current;
									num5 = 5;
									goto IL_0044;
									IL_0044:
									while (true)
									{
										Color color3;
										int num6;
										switch (num5)
										{
										default:
											return;
										case 0:
											return;
										case 1:
											if (current != y9JD7OvtqB)
											{
												num5 = 9;
												continue;
											}
											color3 = HZMwVyFlMiNJ3Rcv3y3(tdKJnCFf1lOmdHO9QSu(0x552216F5 ^ 0));
											goto IL_0497;
										case 12:
											color = HZMwVyFlMiNJ3Rcv3y3(tdKJnCFf1lOmdHO9QSu(0x7BE94A1B ^ 0));
											num5 = 13;											continue;
										case 21:
											dropShadowEffect = null as DropShadowEffect;
											num5 = 10;
											continue;
										case 11:
										case 19:
											num5 = 10;											continue;
										case 23:
											border = (Border)null;
											num5 = 4;											continue;
										case 20:
											num5 = 21;											continue;
										case 14:
										{
											Grid obj = (Grid)null;
											border2 = (Border)null;
											border = (Border)null;
											num6 = 4;
											goto IL_0040;
										}
										case 18:
											num5 = 6;
											continue;
										case 10:
											if (dropShadowEffect != null)
											{
												num5 = 22;
												continue;
											}
											goto case 11;
										case 7:
											num5 = 11;
											continue;
										case 8:
											color5 = HZMwVyFlMiNJ3Rcv3y3(tdKJnCFf1lOmdHO9QSu(0x2FFAE5F1 ^ 0));
											num6 = 7;
											goto IL_0040;
										case 16:
											textBlock = (TextBlock)null;
											num6 = 15;
											goto IL_0040;
										case 6:
											break;
										case 9:
											color3 = HZMwVyFlMiNJ3Rcv3y3(".png");
											goto IL_0497;
										case 17:
											color2 = HZMwVyFlMiNJ3Rcv3y3(tdKJnCFf1lOmdHO9QSu(0x78D5DA98 ^ 0));
											num5 = 20;
											continue;
										case 5:
											grid = (Grid)null;
											num5 = 23;											continue;
										case 4:
											if (current == y9JD7OvtqB)
											{
												num6 = 12;
												goto IL_0040;
											}
											goto case 8;
										case 3:
											num5 = 18;
											continue;
										case 15:
											if (textBlock != null)
											{
												num5 = 0;												continue;
											}
											break;
										case 22:
											num5 = 19;
											continue;
										case 13:
											num5 = 17;
											continue;
										case 2:
											goto IL_045e;
											IL_0497:
											color4 = color3;
											num5 = 1;											continue;
											IL_0040:
											num5 = num6;
											continue;
										}
										break;
									}
								}
							}
							finally
							{
								((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
								int num7 = 0;								switch (num7)
								{
								case 0:
									break;
								}
							}
						case 1:
							enumerator = J7cDD1I2ny.Keys.GetEnumerator();
							num4 = 0;							break;
						}
					}
				});
				num2 = 0;				break;
			}
		}
	}
private void nVGWo8WgEp(object P_0, RoutedEventArgs P_1)
	{
		AddNewTab();
	}

public void AddNewTab()
	{
		AddNewTab($"Tab {J7cDD1I2ny.Count + 1}", string.Empty);
	}
public void AddNewTab(string tabName, string initialContent)
	{
		try
		{
			WebView2 webView = new WebView2();
			Button button = new Button
			{
				Style = (Style)FindResource("TabButtonStyle"),
				Content = tabName,
				Tag = tabName
			};
			ContextMenu contextMenu = new ContextMenu();
			MenuItem renameItem = new MenuItem { Header = "Rename" };
			renameItem.Click += (s, e) => wFQWVSyWwP(button);
			contextMenu.Items.Add(renameItem);
			button.ContextMenu = contextMenu;
			button.Click += (s, e) => IIRWcGRgDL(button);
			button.Loaded += (s, e) =>
			{
				var closeBtn = button.Template?.FindName("CloseBtn", button) as Border;
				if (closeBtn != null)
				{
					closeBtn.MouseLeftButtonDown += (cs, ce) =>
					{
						ce.Handled = true;
						CloseTab(button);
					};
				}
			};
			J7cDD1I2ny[button] = webView;
		if (tabContainer != null)
		{
			tabContainer.Children.Add(button);
		}
		if (contentArea != null)
		{
			contentArea.Children.Add(webView);
		}
		IIRWcGRgDL(button);
		InitializeWebViewAsync(webView, initialContent);
		}
		catch (Exception ex)
		{
			Debug.WriteLine($"AddNewTab failed: {ex}");
		}
	}
private async void InitializeWebViewAsync(WebView2 webView, string initialContent)
	{
		try
		{
			await webView.EnsureCoreWebView2Async();

			string editorPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "monaco", "index.html");
			if (!System.IO.File.Exists(editorPath))
			{
				editorPath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Potassium", "monaco", "index.html");
			}

			webView.HorizontalAlignment = HorizontalAlignment.Stretch;
			webView.VerticalAlignment = VerticalAlignment.Stretch;
			webView.Width = double.NaN;
			webView.Height = double.NaN;

			webView.CoreWebView2.Navigate(new Uri(editorPath).AbsoluteUri);

			webView.CoreWebView2.NavigationCompleted += async (s, e) =>
			{
				try
				{
					if (!string.IsNullOrEmpty(initialContent))
					{
						string escaped = Newtonsoft.Json.JsonConvert.SerializeObject(initialContent);
						await webView.ExecuteScriptAsync($"SetText({escaped})");
					}
				}
				catch { }

				try { WgtDIDvO9H?.Invoke(webView); } catch { }
			};
		}
		catch (Exception ex)
		{
			Debug.WriteLine($"InitWebView: {ex}");
		}
	}
private void wFQWVSyWwP(Button button)
	{
		try
		{
			button.ApplyTemplate();
			var textBlock = button.Template.FindName("TabText", button) as TextBlock;
			var textBox = button.Template.FindName("TabEditBox", button) as TextBox;
			if (textBlock == null || textBox == null) return;

			textBox.Text = textBlock.Text;
			textBlock.Visibility = Visibility.Collapsed;
			textBox.Visibility = Visibility.Visible;
			textBox.Focus();
			textBox.SelectAll();

			void CommitRename()
			{
				textBlock.Text = textBox.Text;
				button.Content = textBox.Text;
				textBlock.Visibility = Visibility.Visible;
				textBox.Visibility = Visibility.Collapsed;
				udwDPwrbit(button, textBox.Text);
			}

			textBox.KeyDown += (s, e) =>
			{
				if (e.Key == Key.Return)
					CommitRename();
				else if (e.Key == Key.Escape)
				{
					textBlock.Visibility = Visibility.Visible;
					textBox.Visibility = Visibility.Collapsed;
				}
			};

			textBox.LostFocus += (s, e) => CommitRename();
		}
		catch (Exception ex)
		{
			Debug.WriteLine($"Rename failed: {ex}");
		}
	}
private void IIRWcGRgDL(Button P_0)
	{
		try
		{
			if (currentWebView != null)
				currentWebView.Visibility = Visibility.Hidden;
			if (J7cDD1I2ny.TryGetValue(P_0, out var webView))
			{
				currentWebView = webView;
				currentWebView.Visibility = Visibility.Visible;
			}
			y9JD7OvtqB = P_0;
		}
		catch { }
	}
private void CloseTab(Button button)
	{
		try
		{
			if (button == null || !J7cDD1I2ny.ContainsKey(button)) return;

			var webView = J7cDD1I2ny[button];
			if (contentArea != null)
				contentArea.Children.Remove(webView);
			if (currentWebView == webView)
				currentWebView = null;
			J7cDD1I2ny.Remove(button);

			Button nextButton = null;
			foreach (var key in J7cDD1I2ny.Keys)
			{
				nextButton = key;
				break;
			}

			if (tabContainer != null)
				tabContainer.Children.Remove(button);
			if (nextButton != null)
				IIRWcGRgDL(nextButton);
		}
		catch (Exception ex)
		{
			Debug.WriteLine($"CloseTab failed: {ex}");
		}
	}
private void YxKWmAR3Jx(object P_0, RoutedEventArgs P_1)
	{
		CloseTab(P_0 as Button);
	}
private void HYmWZrTF74(object P_0, MouseWheelEventArgs P_1)
	{
		int num = 1;
		int num2 = num;
		double num3 = default(double);
		while (true)
		{
			switch (num2)
			{
			case 8:
				num2 = 4;
				break;
			case 1:
				num3 = 80.0;
				num2 = 0;				break;
			case 3:
				m8nDgbNrb2 = true;
				num2 = 8;
				break;
			case 7:
				FZDDtkUDSm = default;
				num2 = 4;				break;
			case 5:
				return;
			case 2:
			case 4:
				num2 = 5;
				break;
			case 6:
				if (m8nDgbNrb2)
				{
					num2 = 2;					break;
				}
				goto case 3;
			default:
				FZDDtkUDSm += ((0 > 0) ? (0.0 - num3) : num3);
				num2 = 7;				break;
			}
		}
	}
private void W00WG7CxbG(object P_0, EventArgs P_1)
	{
		int num = 1;
		int num2 = num;
		double num4 = default(double);
		double num3 = default(double);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return;
			case 7:
				num2 = 2;				break;
			case 2:
				m8nDgbNrb2 = false;
				num2 = 4;
				break;
			case 6:
				if (0 < 0.5)
				{
					num2 = 4;					break;
				}
				num2 = 3;				break;
			case 4:
				return;
			default:
				num4 = FZDDtkUDSm - num3;
				num2 = 6;
				break;
			case 5:
				num2 = 7;
				break;
			case 1:
				num3 = default;
				num2 = 0;				break;
			}
		}
	}
private void KagWQ9hfyV(TextBox P_0)
	{
		int num = 5;
		Button button = default(Button);
		TextBlock textBlock = default(TextBlock);
		DependencyObject dependencyObject = default(DependencyObject);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 17:
					udwDPwrbit(button, null);
					num2 = 7;
					continue;
				case 9:
					num2 = 18;
					continue;
				case 3:
					if (dependencyObject is Button)
					{
						num2 = 8;						continue;
					}
					goto case 14;
				case 16:
					num2 = 1;					continue;
				case 8:
					return;
				case 2:
					num2 = 1;					continue;
				case 12:
				case 19:
					if (dependencyObject != null)
					{
						num = 3;
						break;
					}
					goto case 15;
				case 11:
					num2 = 17;					continue;
				case 18:
					num2 = 11;
					continue;
				case 1:
					textBlock = (TextBlock)null;
					num2 = 10;
					continue;
				case 14:
					dependencyObject = null;
					num = 12;
					break;
				case 10:
					if (textBlock != null)
					{
						num2 = 16;						continue;
					}
					goto case 6;
				default:
					num2 = 8;
					continue;
				case 13:
					if (button == null)
					{
						num2 = 6;
						continue;
					}
					goto case 2;
				case 15:
					button = dependencyObject as Button;
					num2 = 13;					continue;
				case 5:
					if (P_0 == null)
					{
						num2 = 4;
						continue;
					}
					dependencyObject = null;
					num2 = 19;
					continue;
				case 6:
				case 7:
					num2 = 0;					continue;
				case 4:
					return;
				}
				break;
			}
		}
	}
private void h6cWbKO4aY(object P_0, TextChangedEventArgs P_1)
	{
		int num = 6;
		int num2 = num;
		TextBox textBox = default(TextBox);
		DependencyObject dependencyObject = default(DependencyObject);
		Button button = default(Button);
		while (true)
		{
			switch (num2)
			{
			case 6:
				textBox = P_0 as TextBox;
				num2 = 5;
				break;
			case 9:
			case 11:
				if (dependencyObject != null)
				{
					num2 = 0;					break;
				}
				goto case 7;
			case 5:
				if (textBox != null)
				{
					num2 = 4;
					break;
				}
				return;
			case 7:
				button = dependencyObject as Button;
				num2 = 2;				break;
			case 4:
				dependencyObject = null;
				num2 = 0;				break;
			case 1:
				udwDPwrbit(button, null);
				num2 = 12;				break;
			case 2:
				if (button == null)
				{
					num2 = 10;
					break;
				}
				goto case 1;
			case 10:
				return;
			default:
				if (!(dependencyObject is Button))
				{
					num2 = 8;
					break;
				}
				goto case 7;
			case 3:
			case 8:
				dependencyObject = null;
				num2 = 9;				break;
			case 12:
				return;
			}
		}
	}
private void kYyW3GPrJ8(object P_0, RoutedEventArgs P_1)
	{
		int num = 2;
		int num2 = num;
		TextBox textBox = default(TextBox);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				if (textBox == null)
				{
					num2 = 3;
					continue;
				}
				break;
			case 3:
				return;
			case 0:
				return;
			case 2:
				textBox = P_0 as TextBox;
				num2 = 1;				continue;
			case 4:
				break;
			}
			KagWQ9hfyV(textBox);
			num2 = 0;		}
	}
private void hDFWYBDlos(object P_0, KeyEventArgs P_1)
	{
		int num = 3;
		TextBox textBox = default(TextBox);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					textBox = P_0 as TextBox;
					num2 = 0;					continue;
				case 3:
					if (0 == Key.Return)
					{
						num = 2;
						break;
					}
					return;
				case 1:
					if (textBox != null)
					{
						num2 = 0;						continue;
					}
					return;
				case 4:
					return;
				default:
					KagWQ9hfyV(textBox);
					num = 4;
					break;
				}
				break;
			}
		}
	}
[AsyncStateMachine(typeof(_SaveTabsAsync_d__24))]
	public Task SaveTabsAsync()
	{
		_SaveTabsAsync_d__24 stateMachine = default(_SaveTabsAsync_d__24);
		stateMachine._asyncBuilder = AsyncTaskMethodBuilder.Create();
		stateMachine._this4 = this;
		stateMachine._state1 = -1;
		stateMachine._asyncBuilder.Start(ref stateMachine);
		return stateMachine._asyncBuilder.Task;
	}
[AsyncStateMachine(typeof(_ApplyEditorColorsAsync_d__25))]
	public Task ApplyEditorColorsAsync(string bgColor, string lineHighlight = "#00000000", string lineHighlightBorder = "#00000000")
	{
		_ApplyEditorColorsAsync_d__25 stateMachine = default(_ApplyEditorColorsAsync_d__25);
		stateMachine._asyncBuilder = AsyncTaskMethodBuilder.Create();
		stateMachine._this4 = this;
		stateMachine.bgColor = bgColor;
		stateMachine.lineHighlight = lineHighlight;
		stateMachine.lineHighlightBorder = lineHighlightBorder;
		stateMachine._state1 = -1;
		stateMachine._asyncBuilder.Start(ref stateMachine);
		return stateMachine._asyncBuilder.Task;
	}
[AsyncStateMachine(typeof(_ApplyEditorImageAsync_d__27))]
	public Task ApplyEditorImageAsync(string imageSource)
	{
		_ApplyEditorImageAsync_d__27 stateMachine = default(_ApplyEditorImageAsync_d__27);
		stateMachine._asyncBuilder = AsyncTaskMethodBuilder.Create();
		stateMachine._this4 = this;
		stateMachine.imageSource = imageSource;
		stateMachine._state1 = -1;
		stateMachine._asyncBuilder.Start(ref stateMachine);
		return stateMachine._asyncBuilder.Task;
	}
[AsyncStateMachine(typeof(_ResolveEditorImageDataUrlAsync_d__28))]
	private static Task<string> RnNW5qfBAn(object P_0)
	{
		_ResolveEditorImageDataUrlAsync_d__28 stateMachine = default(_ResolveEditorImageDataUrlAsync_d__28);
		stateMachine._asyncBuilder = AsyncTaskMethodBuilder<string>.Create();
		stateMachine.imageSource = (string)P_0;
		stateMachine._state1 = -1;
		stateMachine._asyncBuilder.Start(ref stateMachine);
		return stateMachine._asyncBuilder.Task;
	}
private static string CKbWz2xyke(object P_0, object P_1)
	{
		int num = 17;
		string result = default(string);
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
				case 4:
				case 12:
				case 19:
				case 25:
				case 28:
					return result;
				case 8:
				case 30:
					result = (string)tdKJnCFf1lOmdHO9QSu(0x336576C7 ^ 0);
					num2 = 1;					continue;
				case 11:
					return (string)tdKJnCFf1lOmdHO9QSu(0x619512BB ^ 0);
				case 27:
				case 29:
					result = null;
					num2 = 28;
					continue;
				case 22:
					if (false)
					{
						num2 = 36;
						continue;
					}
					goto case 9;
				case 18:
				case 33:
				case 36:
					result = (string)tdKJnCFf1lOmdHO9QSu(0x3551F38F ^ 0);
					num2 = 4;					continue;
				case 5:
					if (false)
					{
						num2 = 16;						continue;
					}
					goto case 22;
				case 26:
					if (((byte[])P_1)[1] == 73)
					{
						num2 = 11;
						continue;
					}
					goto IL_0154;
				case 34:
					result = (string)tdKJnCFf1lOmdHO9QSu(0x155D1207 ^ 0);
					num2 = 25;
					continue;
				case 9:
					if (false)
					{
						num2 = 12;						continue;
					}
					goto default;
				case 21:
					if (((byte[])P_1)[3] == 70)
					{
						num2 = 14;
						continue;
					}
					goto case 16;
				case 17:
					if (((Array)P_1).Length < 4)
					{
						num = 16;
						break;
					}
					goto case 7;
				case 32:
					if (((byte[])P_1)[1] == 73)
					{
						num2 = 23;						continue;
					}
					goto case 16;
				case 14:
					return (string)tdKJnCFf1lOmdHO9QSu(0x4BF57BEE ^ 0);
				case 16:
					text = null;
					num2 = 5;
					continue;
				case 24:
					return (string)tdKJnCFf1lOmdHO9QSu(0x3551EC65 ^ 0);
				case 31:
					if (true)
					{
						goto case 27;
					}
					num2 = 6;					continue;
				case 3:
					if (true)
					{
						num2 = 31;
						continue;
					}
					goto case 34;
				case 7:
					if (((byte[])P_1)[0] == 137)
					{
						num2 = 15;						continue;
					}
					goto IL_0467;
				default:
					if (false)
					{
						num2 = 2;
						continue;
					}
					goto case 3;
				case 20:
					return null;
				case 13:
					if (((byte[])P_1)[1] == 216)
					{
						num = 20;
						break;
					}
					goto IL_05ac;
				case 15:
					if (((byte[])P_1)[1] == 80)
					{
						num2 = 24;
						continue;
					}
					goto IL_0467;
				case 2:
				case 35:
					result = null;
					num2 = 3;					continue;
				case 23:
					if (((byte[])P_1)[2] == 70)
					{
						num2 = 21;
						continue;
					}
					goto case 16;
				case 6:
				case 10:
					{
						result = (string)tdKJnCFf1lOmdHO9QSu(0x4B7954C7 ^ 0);
						num2 = 12;
						continue;
					}
					IL_0154:
					if (((byte[])P_1)[0] == 82)
					{
						num2 = 32;
						continue;
					}
					goto case 16;
					IL_0467:
					if (((byte[])P_1)[0] == byte.MaxValue)
					{
						num2 = 6;						continue;
					}
					goto IL_05ac;
					IL_05ac:
					if (((byte[])P_1)[0] == 71)
					{
						num2 = 26;						continue;
					}
					goto IL_0154;
				}
				break;
			}
		}
	}
private void udwDPwrbit(Button button, string text)
	{
		try
		{
			if (button == null) return;
			double minWidth = 60.0;
			double maxWidth = 300.0;
			double padding = 35.0;

			if (!string.IsNullOrEmpty(text))
			{
				var tb = new TextBlock { Text = text, FontSize = 14 };
				tb.Measure(new Size(double.PositiveInfinity, double.PositiveInfinity));
				double width = tb.DesiredSize.Width + padding + 25;
				button.Width = Math.Clamp(width, minWidth, maxWidth);
			}
		}
		catch { }
	}
/* InitializeComponent provided by .g.cs */
/* IComponentConnector\.Connect removed */
static TabsControl()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				num2 = 4;				break;
			case 1:
				Rvh3FkFHNcf5iqjfhqJ();
				num2 = 0;				break;
			case 4:
			{
				HttpClient httpClient = new HttpClient();
				SgFDRJ6t9X = httpClient;
				num2 = 2;				break;
			}
			default:
				NN680TF8MNXslmtkVFh();
				num2 = 3;				break;
			case 2:
				return;
			}
		}
	}
[CompilerGenerated]
	private void SV0DWsy6CO()
	{
		int num = 1;
		int num2 = num;
		Dictionary<Button, WebView2>.KeyCollection.Enumerator enumerator = default(Dictionary<Button, WebView2>.KeyCollection.Enumerator);
		Button current = default(Button);
		Color color = default(Color);
		DropShadowEffect dropShadowEffect = default(DropShadowEffect);
		Border border2 = default(Border);
		Border border = default(Border);
		Grid grid = default(Grid);
		Color color2 = default(Color);
		Color color4 = default(Color);
		Color color5 = default(Color);
		TextBlock textBlock = default(TextBlock);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				enumerator = J7cDD1I2ny.Keys.GetEnumerator();
				num2 = 0;				continue;
			}
			try
			{
				while (true)
				{
					int num3;
					if (!enumerator.MoveNext())
					{
						num3 = 0;						goto IL_0044;
					}
					goto IL_045e;
					IL_045e:
					current = enumerator.Current;
					num3 = 5;
					goto IL_0044;
					IL_0044:
					while (true)
					{
						Color color3;
						int num4;
						switch (num3)
						{
						default:
							return;
						case 0:
							return;
						case 1:
							if (current != y9JD7OvtqB)
							{
								num3 = 9;
								continue;
							}
							color3 = HZMwVyFlMiNJ3Rcv3y3(tdKJnCFf1lOmdHO9QSu(0x552216F5 ^ 0));
							goto IL_0497;
						case 12:
							color = HZMwVyFlMiNJ3Rcv3y3(tdKJnCFf1lOmdHO9QSu(0x7BE94A1B ^ 0));
							num3 = 13;							continue;
						case 21:
							dropShadowEffect = null as DropShadowEffect;
							num3 = 10;
							continue;
						case 11:
						case 19:
							num3 = 10;							continue;
						case 23:
							border = (Border)null;
							num3 = 4;							continue;
						case 20:
							num3 = 21;							continue;
						case 14:
						{
							Grid obj = (Grid)null;
							border2 = (Border)null;
							border = (Border)null;
							num4 = 4;
							goto IL_0040;
						}
						case 18:
							num3 = 6;
							continue;
						case 10:
							if (dropShadowEffect != null)
							{
								num3 = 22;
								continue;
							}
							goto case 11;
						case 7:
							num3 = 11;
							continue;
						case 8:
							color5 = HZMwVyFlMiNJ3Rcv3y3(tdKJnCFf1lOmdHO9QSu(0x2FFAE5F1 ^ 0));
							num4 = 7;
							goto IL_0040;
						case 16:
							textBlock = (TextBlock)null;
							num4 = 15;
							goto IL_0040;
						case 6:
							break;
						case 9:
							color3 = HZMwVyFlMiNJ3Rcv3y3(".png");
							goto IL_0497;
						case 17:
							color2 = HZMwVyFlMiNJ3Rcv3y3(tdKJnCFf1lOmdHO9QSu(0x78D5DA98 ^ 0));
							num3 = 20;
							continue;
						case 5:
							grid = (Grid)null;
							num3 = 23;							continue;
						case 4:
							if (current == y9JD7OvtqB)
							{
								num4 = 12;
								goto IL_0040;
							}
							goto case 8;
						case 3:
							num3 = 18;
							continue;
						case 15:
							if (textBlock != null)
							{
								num3 = 0;								continue;
							}
							break;
						case 22:
							num3 = 19;
							continue;
						case 13:
							num3 = 17;
							continue;
						case 2:
							goto IL_045e;
							IL_0497:
							color4 = color3;
							num3 = 1;							continue;
							IL_0040:
							num3 = num4;
							continue;
						}
						break;
					}
				}
			}
			finally
			{
				((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
				int num5 = 0;				switch (num5)
				{
				case 0:
					break;
				}
			}
		}
	}
internal static void NN680TF8MNXslmtkVFh()
	{
		
	}
internal static void fRgPU5FJddquYgpaOHd()
	{
		}
internal static int DMjhqgFTMtGEsd3A2U5(object P_0)
	{
		return ((List<SavedTab>)P_0).Count;
	}
internal static object cI3vMMFEEXLZXfbcjMv(object P_0)
	{
		return ((SavedTab)P_0).Name;
	}
internal static object LfsbldFKDSyhLlMm3gb(object P_0)
	{
		return ((SavedTab)P_0).Content;
	}
internal static int UDjewLFLuD4wdJVVP3V(object P_0)
	{
		return ((SavedTabState)P_0).ActiveIndex;
	}
internal static int EJpMpiFuerf0vnn3Cm3(object P_0)
	{
		return ((Dictionary<Button, WebView2>)P_0).Count;
	}
internal static bool CEdTYAFO6EgvBiSFYuA()
	{
		return xwVUv6FFyVRRBZasnwE == null;
	}
internal static TabsControl VmWHFxFsJroL9rkN7rd()
	{
		return xwVUv6FFyVRRBZasnwE;
	}
internal static object tdKJnCFf1lOmdHO9QSu(int P_0)
	{
		return null;
	}
internal static Color HZMwVyFlMiNJ3Rcv3y3(object P_0)
	{
		return ThemeManager.GetColor((string)P_0);
	}
internal static void Rvh3FkFHNcf5iqjfhqJ()
	{
		}
}
