﻿﻿﻿﻿﻿﻿﻿﻿﻿﻿﻿﻿using Border = System.Windows.Controls.Border;
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
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Json;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Threading.Tasks;
using System.Timers;
using TextBlock = System.Windows.Controls.TextBlock;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using EleCho.WpfSuite.Controls;
using Newtonsoft.Json.Linq;
using Potassium_UI_V2.Services;
using Potassium_UI_V2.Utils;
using Potassium_UI_V2.Views.MainWindow;

namespace Potassium_UI_V2.Views.ScriptHub;

public partial class ScriptHub : UserControl
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _ctor_b_9_0_d : IAsyncStateMachine
	{
		public int _state1;

		public AsyncVoidMethodBuilder _asyncBuilder;

		public ScriptHub _this4;

		private TaskAwaiter<Task> _awaiter_1;

		internal static object xlBbLb8dUEoRpTMUsLc;
public void MoveNext()
		{
			int num = 4;
			int num2 = num;
			int num3 = default(int);
			TaskAwaiter<Task> awaiter = default(TaskAwaiter<Task>);
			ScriptHub @object = default(ScriptHub);
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
							num4 = 6;
							goto IL_0051;
						}
						goto IL_00c1;
						IL_0126:
						awaiter = @object.Dispatcher.InvokeAsync((Func<Task>)@object.LuxOvA4cw).GetAwaiter();
						num4 = 7;
						goto IL_0051;
						IL_0051:
						int num5 = num4;
						goto IL_0055;
						IL_0055:
						while (true)
						{
							switch (num5)
							{
							default:
								return;
							case 0:
								return;
							case 3:
								awaiter.GetResult();
								num5 = 3;								continue;
							case 8:
								break;
							case 10:
								num3 = (_state1 = -1);
								num5 = 3;
								continue;
							case 1:
								_awaiter_1 = default(TaskAwaiter<Task>);
								num5 = 10;
								continue;
							case 9:
								num3 = (_state1 = 0);
								num5 = 2;
								continue;
							case 6:
								goto IL_0126;
							case 5:
								_asyncBuilder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num5 = 0;								continue;
							case 7:
								if (!awaiter.IsCompleted)
								{
									num5 = 1;									continue;
								}
								goto case 3;
							case 2:
								_awaiter_1 = awaiter;
								num5 = 5;								continue;
							case 4:
								goto end_IL_003c;
							}
							break;
						}
						goto IL_00c1;
						IL_00c1:
						awaiter = _awaiter_1;
						num5 = 1;						goto IL_0055;
						end_IL_003c:;
					}
					catch (Exception ex)
					{
						int num6 = 0;						while (true)
						{
							switch (num6)
							{
							default:
								_state1 = -2;
								num6 = 2;
								break;
							case 2:
								num6 = 1;								break;
							case 1:
								return;
							}
						}
					}
					goto case 2;
				case 3:
					@object = _this4;
					num2 = 0;					break;
				case 2:
					_state1 = -2;
					num2 = 5;
					break;
				case 4:
					num3 = _state1;
					num2 = 3;
					break;
				case 5:
					num2 = 0;					break;
				case 0:
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
				case 1:
					num2 = 0;					break;
				case 0:
					return;
				}
			}
		}

		/* IAsyncStateMachine\.SetStateMachine removed */
static _ctor_b_9_0_d()
		{
			}
internal static bool Mxrrm08i0mdkyt9BNLZ()
		{
			return xlBbLb8dUEoRpTMUsLc == null;
		}
internal static object QDGD4M8yda8m9Ick1bA()
		{
			return xlBbLb8dUEoRpTMUsLc;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _ctor_b_9_1_d : IAsyncStateMachine
	{
		public int _state1;

		public AsyncTaskMethodBuilder _asyncBuilder;

		public ScriptHub _this4;

		private TaskAwaiter _awaiter_1;

		private static object BLE23S8w4u5e6lJVR4c;
public void MoveNext()
		{
			int num = 4;
			int num2 = num;
			int num3 = default(int);
			TaskAwaiter awaiter = default(TaskAwaiter);
			ScriptHub scriptHub = default(ScriptHub);
			while (true)
			{
				switch (num2)
				{
				case 5:
					return;
				case 2:
					num2 = 5;
					continue;
				case 4:
					num3 = _state1;
					num2 = 3;
					continue;
				default:
					try
					{
						int num4;
						if (num3 == 0)
						{
							num4 = 3;
							goto IL_007e;
						}
						goto IL_0130;
						IL_0130:
						awaiter = default;
						num4 = 0;						goto IL_007e;
						IL_007e:
						while (true)
						{
							switch (num4)
							{
							case 8:
								return;
							default:
								goto end_IL_007e;
							case 3:
							case 4:
								awaiter = _awaiter_1;
								num4 = 5;
								continue;
							case 2:
								num3 = (_state1 = 0);
								num4 = 6;								continue;
							case 7:
								num3 = (_state1 = -1);
								num4 = 11;
								continue;
							case 5:
								_awaiter_1 = default(TaskAwaiter);
								num4 = 7;
								continue;
							case 9:
								break;
							case 1:
								if (false)
								{
									int num5 = 12;
									num4 = num5;
									continue;
								}
								goto case 2;
							case 11:
							case 12:
								num4 = 0;								continue;
							case 10:
								_asyncBuilder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num4 = 8;
								continue;
							case 6:
								_awaiter_1 = awaiter;
								num4 = 10;								continue;
							case 0:
								goto end_IL_007e;
							}
							goto IL_0130;
							continue;
							end_IL_007e:
							break;
						}
					}
					catch (Exception ex)
					{
						int num6 = 1;						while (true)
						{
							switch (num6)
							{
							case 2:
								return;
							default:
								num6 = 2;
								break;
							case 1:
								_state1 = -2;
								num6 = 0;								break;
							}
						}
					}
					break;
				case 3:
					scriptHub = _this4;
					num2 = 0;					continue;
				case 1:
					break;
				}
				_state1 = -2;
				num2 = 2;
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
static _ctor_b_9_1_d()
	{
	}
internal static bool qSoBNw8AAYXELaSFLh9()
		{
			return BLE23S8w4u5e6lJVR4c == null;
		}
internal static object V5sE0U8aK8Xx6SuMMmQ()
		{
			return BLE23S8w4u5e6lJVR4c;
		}
internal static void iEIBgM8xWBFMfxcMBaw()
		{
			}
	}

	[CompilerGenerated]
	private sealed class _c__DisplayClass10_0
	{
		public ScriptHub ikK7lt9qGs;

		public List<ScriptItem> gN47HV2uYK;

		private static _c__DisplayClass10_0 dtBwQT8SEwWO57w4Rrd;
public _c__DisplayClass10_0()
		{
			YNWChF8NqFbMPsl67fU();
			Qvpgft8UFwfFiTD6vfF();
int num = 0;			switch (num)
			{
			case 0:
				break;
			}
		}
internal void iRq7fP0f6t()
		{
			int num = 1;
			int num2 = num;
			List<ScriptItem>.Enumerator enumerator = default(List<ScriptItem>.Enumerator);
			ScriptItem current = default(ScriptItem);
			while (true)
			{
				switch (num2)
				{
				case 1:
					enumerator = gN47HV2uYK.GetEnumerator();
					num2 = 0;					continue;
				case 2:
					return;
				}
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 2;
							goto IL_0084;
						}
						goto IL_00d0;
						IL_0084:
						while (true)
						{
							switch (num3)
							{
							case 1:
								ikK7lt9qGs.MWWsdIUpt().Add(current);
								num3 = 3;
								continue;
							case 3:
								break;
							default:
								goto IL_00d0;
							case 2:
								return;
							}
							break;
						}
						continue;
						IL_00d0:
						current = enumerator.Current;
						num3 = 1;						goto IL_0084;
					}
				}
				finally
				{
					((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
					int num4 = 0;					switch (num4)
					{
					case 0:
						break;
					}
				}
			}
		}
static _c__DisplayClass10_0()
	{
	}
internal static void YNWChF8NqFbMPsl67fU()
		{
			
		}
internal static void Qvpgft8UFwfFiTD6vfF()
		{
			}
internal static bool NYeLuX8v4J4wutQRkfe()
		{
			return dtBwQT8SEwWO57w4Rrd == null;
		}
internal static _c__DisplayClass10_0 V5dqWd80mhGrnogp3oO()
		{
			return dtBwQT8SEwWO57w4Rrd;
		}
internal static void kvZ3O889VkoJbA94Ke3()
		{
			}
	}

	[CompilerGenerated]
	private sealed class _c__DisplayClass10_1
	{
		public Exception J4f72qRJaO;

		private static _c__DisplayClass10_1 vZe7fj8e8Xtc5kGPaxx;
public _c__DisplayClass10_1()
		{
			
			int num = 0;			switch (num)
			{
			case 0:
				break;
			}
		}
internal MessageBoxResult QtJ7n1SfrD()
	{
		return default;
	}
static _c__DisplayClass10_1()
	{
	}
internal static bool Yv4J8U81t0lIwYsyvan()
		{
			return vZe7fj8e8Xtc5kGPaxx == null;
		}
internal static _c__DisplayClass10_1 uuauUi8qUK2SUiZsglb()
		{
			return vZe7fj8e8Xtc5kGPaxx;
		}
internal static object biV3Mq8XjKRXeafEAyF(int P_0)
		{
			return null;
		}
internal static void PKPWhY8MyXWGFalLeY3()
		{
			}
	}

	[CompilerGenerated]
	private sealed class _c__DisplayClass14_0
	{
		public ScriptHub hts7V8Wco6;

		public List<ScriptItem> OKM7cp6niD;

		private static _c__DisplayClass14_0 HETHCr8B7GQ6jSRWgWr;
public _c__DisplayClass14_0()
		{
			
			int num = 0;			switch (num)
			{
			case 0:
				break;
			}
		}
internal void GGr7okEmEc()
		{
			int num = 1;
			int num2 = num;
			List<ScriptItem>.Enumerator enumerator = default(List<ScriptItem>.Enumerator);
			ScriptItem current = default(ScriptItem);
			while (true)
			{
				switch (num2)
				{
				case 2:
					return;
				case 1:
					enumerator = OKM7cp6niD.GetEnumerator();
					num2 = 0;					continue;
				}
				try
				{
					while (true)
					{
						IL_00e3:
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 3;
							goto IL_0085;
						}
						goto IL_00d0;
						IL_0085:
						while (true)
						{
							switch (num3)
							{
							case 3:
								return;
							case 2:
								hts7V8Wco6.MWWsdIUpt().Add(current);
								num3 = 0;								continue;
							case 1:
								break;
							default:
								goto IL_00e3;
							}
							break;
						}
						goto IL_00d0;
						IL_00d0:
						current = enumerator.Current;
						num3 = 2;
						goto IL_0085;
					}
				}
				finally
				{
					((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
					int num4 = 0;					switch (num4)
					{
					case 0:
						break;
					}
				}
			}
		}
static _c__DisplayClass14_0()
	{
	}
internal static bool LfPYC88pYOBHbyrFaty()
		{
			return HETHCr8B7GQ6jSRWgWr == null;
		}
internal static _c__DisplayClass14_0 KTAjkZ8C4lJcus9xYCL()
		{
			return HETHCr8B7GQ6jSRWgWr;
		}
internal static void w6D7Gi8FtguFcwpccfm()
		{
			}
	}

	[CompilerGenerated]
	private sealed class _c__DisplayClass14_1
	{
		public Exception rgB7Zy0pnv;

		internal static _c__DisplayClass14_1 obdPk18OAHvoTYcr5kJ;
public _c__DisplayClass14_1()
		{
			
			int num = 0;			switch (num)
			{
			case 0:
				break;
			}
		}
internal MessageBoxResult W887m6gQxx()
	{
		return default;
	}
static _c__DisplayClass14_1()
	{
	}
internal static bool fG1d3F8svSmjcWGf5xi()
		{
			return obdPk18OAHvoTYcr5kJ == null;
		}
internal static _c__DisplayClass14_1 QJ3BXN88qvrWHMUgllO()
		{
			return obdPk18OAHvoTYcr5kJ;
		}
internal static void UybSg28JqDYRL463v7A()
		{
			}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _LoadScriptsAsync_d__10 : IAsyncStateMachine
	{
		public int _state1;

		public AsyncTaskMethodBuilder _asyncBuilder;

		public ScriptHub _this4;

		private _c__DisplayClass10_0 _closure8_1;

		private object _wrap7_1;

		private int _wrap7_2;

		private JsonElement _result4;

		private ConfiguredTaskAwaitable<JsonElement>.ConfiguredTaskAwaiter _awaiter_1;

		private TaskAwaiter _awaiter_2;

		private TaskAwaiter<MessageBoxResult> _awaiter_3;

		internal static object JCP9uu8TdWqNyiM4QGK;
public void MoveNext()
		{
			int num = 1;
			int num2 = num;
			ScriptHub scriptHub = default(ScriptHub);
			int num3 = default(int);
			TaskAwaiter<MessageBoxResult> awaiter = default(TaskAwaiter<MessageBoxResult>);
			int num8 = default(int);
			_c__DisplayClass10_1 _c__DisplayClass10_ = default(_c__DisplayClass10_1);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(DefaultInterpolatedStringHandler);
			TaskAwaiter awaiter2 = default(TaskAwaiter);
			ConfiguredTaskAwaitable<JsonElement> configuredTaskAwaitable = default(ConfiguredTaskAwaitable<JsonElement>);
			string requestUri = default(string);
			ConfiguredTaskAwaitable<JsonElement>.ConfiguredTaskAwaiter awaiter3 = default(ConfiguredTaskAwaitable<JsonElement>.ConfiguredTaskAwaiter);
			JsonElement jsonElement = default(JsonElement);
			JsonElement.ArrayEnumerator arrayEnumerator = default(JsonElement.ArrayEnumerator);
			JsonElement jsonElement2 = default(JsonElement);
			JsonElement.ArrayEnumerator enumerator = default(JsonElement.ArrayEnumerator);
			JsonElement jsonElement3 = default(JsonElement);
			JsonElement jsonElement4 = default(JsonElement);
			string text = default(string);
			string code = default(string);
			string text4 = default(string);
			string text2 = default(string);
			string text3 = default(string);
			JsonElement result = default(JsonElement);
			while (true)
			{
				switch (num2)
				{
				default:
					scriptHub = _this4;
					num2 = 4;
					break;
				case 3:
					_state1 = -2;
					num2 = 1;					break;
				case 4:
					try
					{
						int num4;
						if ((uint)num3 <= 2u)
						{
							num4 = 6;							goto IL_00a4;
						}
						goto IL_10aa;
						IL_00a4:
						while (true)
						{
							switch (num4)
							{
							default:
								goto end_IL_00a4;
							case 5:
								if (!scriptHub.WB7upf0Tm)
								{
									num4 = 0;									continue;
								}
								goto case 9;
							case 2:
								try
								{
									int num6;
									if ((uint)num3 <= 1u)
									{
										num6 = 6;										goto IL_013c;
									}
									goto IL_024a;
									IL_024a:
									if (num3 != 2)
									{
										num6 = 14;
										goto IL_013c;
									}
									goto IL_02b9;
									IL_02b9:
									awaiter = _awaiter_3;
									num6 = 7;
									goto IL_013c;
									IL_013c:
									while (true)
									{
										int num7;
										switch (num6)
										{
										case 1:
											_awaiter_3 = awaiter;
											num6 = 3;
											continue;
										case 14:
											_wrap7_2 = 0;
											num6 = 16;											continue;
										case 12:
											num8 = _wrap7_2;
											num7 = 15;
											goto IL_0138;
										case 11:
											_c__DisplayClass10_ = new _c__DisplayClass10_1();
											num6 = 4;
											continue;
										case 13:
											_wrap7_1 = null;
											num6 = 10;											continue;
										case 9:
										case 18:
											awaiter.GetResult();
											num6 = 1;											continue;
										case 21:
											break;
										case 20:
											if (awaiter.IsCompleted)
											{
												num7 = 9;
												goto IL_0138;
											}
											goto case 17;
										case 3:
											_asyncBuilder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
											num6 = 3;											continue;
										case 7:
											_awaiter_3 = default(TaskAwaiter<MessageBoxResult>);
											num6 = 8;
											continue;
										case 2:
											goto IL_02b9;
										default:
											try
											{
												int num9;
												if (num3 != 0)
												{
													num9 = 6;													goto IL_02f6;
												}
												goto IL_0aa5;
												IL_02f6:
												while (true)
												{
													int num10;
													switch (num9)
													{
													case 9:
														scriptHub.WB7upf0Tm = false;
														num9 = 13;														continue;
													case 11:
														num9 = 15;
														continue;
													case 28:
														num9 = 2;														continue;
													case 29:
														configuredTaskAwaitable = xMDEPcOfq.GetFromJsonAsync<JsonElement>(requestUri).ConfigureAwait(continueOnCapturedContext: false);
														num9 = 5;
														continue;
													case 24:
														_awaiter_1 = awaiter3;
														num10 = 41;
														goto IL_02f2;
													case 30:
														_awaiter_2 = default(TaskAwaiter);
														num9 = 4;
														continue;
													case 34:
														if (awaiter3.IsCompleted)
														{
															num9 = 23;															continue;
														}
														goto case 42;
													case 12:
														if (0 == JsonValueKind.Number)
														{
															num9 = 1;															continue;
														}
														goto case 9;
													case 3:
														num9 = 16;														continue;
													case 35:
														if (true)
														{
															num10 = 22;
															goto IL_02f2;
														}
														goto case 28;
													case 16:
														requestUri = null;
														num9 = 29;
														continue;
													case 4:
														num3 = (_state1 = -1);
														num9 = 28;
														continue;
													case 19:
														arrayEnumerator = jsonElement2.EnumerateArray();
														num9 = 0;														continue;
													case 15:
														defaultInterpolatedStringHandler.AppendFormatted(scriptHub.GF1KNtnlB);
														num9 = 1;														continue;
													case 5:
														awaiter3 = configuredTaskAwaitable.GetAwaiter();
														num9 = 34;
														continue;
													case 43:
														try
														{
															while (true)
															{
																IL_06cd:
																int num11;
																if (true)
																{
																	num11 = 0;																	goto IL_062f;
																}
																goto IL_077c;
																IL_077c:
																jsonElement3 = default;
																num11 = 10;
																goto IL_062f;
																IL_062f:
																while (true)
																{
																	object obj;
																	switch (num11)
																	{
																	case 15:
																		jsonElement4 = default;
																		num11 = 3;
																		continue;
																	case 1:
																		goto IL_06cd;
																	case 17:
																		jsonElement4 = default;
																		num11 = 2;																		continue;
																	case 7:
																		if (false)
																		{
																			num11 = 13;
																			continue;
																		}
																		goto case 16;
																	case 8:
																		goto IL_077c;
																	case 2:
																		code = null;
																		num11 = 5;																		continue;
																	case 12:
																		jsonElement4 = default;
																		num11 = 14;
																		continue;
																	case 16:
																		text = null;
																		num11 = 1;																		continue;
																	case 4:
																	{
																		text4 = null;
																		int num12 = 12;
																		num11 = num12;
																		continue;
																	}
																	case 11:
																	case 13:
																	{
																		List<ScriptItem> list = _closure8_1.gN47HV2uYK;
																		ScriptItem scriptItem = new ScriptItem();
																		SZhIY28uP8MuPmbdNkQ(scriptItem, text4);
																		bOZkpd8fbUTWo4JTkih(scriptItem, text2);
																		kTZsJr8ls2pw7xaxiXo(scriptItem, text);
																		pJLCac8HZbDquECfYDl(scriptItem, text3);
																		scriptItem.Code = code;
																		list.Add(scriptItem);
																		num11 = 1;																		continue;
																	}
																	case 14:
																		jsonElement4 = default;
																		num11 = 0;																		continue;
																	case 3:
																		text3 = null;
																		num11 = 3;																		continue;
																	case 5:
																		obj = null;
																		jsonElement4 = default;
																		text = null;
																		if (obj == null)
																		{
																			num11 = 9;
																			continue;
																		}
																		goto IL_09f8;
																	case 10:
																		jsonElement4 = default;
																		num11 = 4;
																		continue;
																	case 6:
																		if (true)
																		{
																			num11 = 7;
																			continue;
																		}
																		goto case 11;
																	case 9:
																		obj = yH3Tft8LekjCFILtMG1(0x7EE10F2F ^ 0);
																		goto IL_09f8;
																	case 0:
																		break;
																		IL_09f8:
																		text2 = (string)obj;
																		num11 = 15;
																		continue;
																	}
																	break;
																}
																break;
															}
														}
														finally
														{
															if (num3 < 0)
															{
																int num13 = 0;																while (true)
																{
																	switch (num13)
																	{
																	default:
																		((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
																		num13 = 1;																		continue;
																	case 1:
																		break;
																	}
																	break;
																}
															}
														}
														goto case 17;
													case 1:
														enumerator = arrayEnumerator.GetEnumerator();
														num9 = 43;
														continue;
													case 27:
														_asyncBuilder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
														num9 = 31;														continue;
													case 32:
														_awaiter_2 = awaiter2;
														num10 = 27;
														goto IL_02f2;
													case 22:
														num3 = (_state1 = 1);
														num9 = 32;
														continue;
													case 36:
														return;
													case 6:
														if (num3 != 1)
														{
															num9 = 8;															continue;
														}
														goto case 39;
													case 20:
														_result4 = default;
														num10 = 10;
														goto IL_02f2;
													case 7:
														if (true)
														{
															num9 = 18;
															continue;
														}
														goto case 19;
													case 23:
													case 25:
														result = awaiter3.GetResult();
														num9 = 20;
														continue;
													case 13:
													case 26:
													case 38:
														_result4 = default(JsonElement);
														num10 = 14;
														goto IL_02f2;
													case 21:
														num3 = (_state1 = -1);
														num9 = 25;
														continue;
													case 37:
														scriptHub.WB7upf0Tm = false;
														num9 = 26;														continue;
													case 17:
													case 18:
														awaiter = default;
														num9 = 35;
														continue;
													case 8:
														defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(80, 1);
														num9 = 10;														continue;
													case 31:
														return;
													case 42:
														num3 = (_state1 = 0);
														num9 = 24;														continue;
													case 41:
														_asyncBuilder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
														num9 = 36;
														continue;
													case 33:
														_awaiter_1 = default(ConfiguredTaskAwaitable<JsonElement>.ConfiguredTaskAwaiter);
														num9 = 10;														continue;
													case 10:
														_closure8_1.gN47HV2uYK = new List<ScriptItem>();
														num9 = 7;														continue;
													case 39:
														awaiter2 = _awaiter_2;
														num9 = 30;														continue;
													case 40:
														scriptHub.GF1KNtnlB = default;
														num9 = 38;														continue;
													case 2:
														if (false)
														{
															num9 = 12;
															continue;
														}
														goto case 37;
													case 14:
														goto end_IL_02f6;
														IL_02f2:
														num9 = num10;
														continue;
													}
													goto IL_0aa5;
													continue;
													end_IL_02f6:
													break;
												}
												goto end_IL_02cc;
												IL_0aa5:
												awaiter3 = _awaiter_1;
												num9 = 33;
												goto IL_02f6;
												end_IL_02cc:;
											}
											catch (Exception ex)
											{
												int num18 = 1;												while (true)
												{
													switch (num18)
													{
													case 2:
														_wrap7_2 = 1;
														num18 = 0;														continue;
													case 1:
														_wrap7_1 = ex;
														num18 = 2;
														continue;
													case 0:
														break;
													}
													break;
												}
											}
											goto case 12;
										case 8:
											num3 = (_state1 = -1);
											num6 = 18;
											continue;
										case 6:
										case 16:
											num6 = 0;											continue;
										case 15:
											if (num8 == 1)
											{
												num7 = 11;
												goto IL_0138;
											}
											goto case 13;
										case 4:
											_c__DisplayClass10_.J4f72qRJaO = (Exception)_wrap7_1;
											num6 = 19;											continue;
										case 5:
											return;
										case 19:
											awaiter = scriptHub.Dispatcher.InvokeAsync((Func<MessageBoxResult>)_c__DisplayClass10_.QtJ7n1SfrD).GetAwaiter();
											num7 = 20;
											goto IL_0138;
										case 17:
											num3 = (_state1 = 2);
											num6 = 1;											continue;
										case 10:
											goto end_IL_0111;
											IL_0138:
											num6 = num7;
											continue;
										}
										break;
									}
									goto IL_024a;
									end_IL_0111:;
								}
								finally
								{
									int num19;
									if (num3 >= 0)
									{
										num19 = 1;										goto IL_1029;
									}
									goto IL_103f;
									IL_1029:
									switch (num19)
									{
									case 1:
										goto end_IL_0ffe;
									case 2:
										goto end_IL_0ffe;
									}
									goto IL_103f;
									IL_103f:
									scriptHub.MEjLDLhVD = false;
									num19 = 1;									goto IL_1029;
									end_IL_0ffe:;
								}
								goto end_IL_00a4;
							case 3:
								break;
							case 4:
								goto end_IL_00a4;
							case 9:
								scriptHub.MEjLDLhVD = true;
								num4 = 8;								continue;
							case 7:
								if (scriptHub.MEjLDLhVD)
								{
									goto end_IL_00a4;
								}
								num4 = 0;								continue;
							case 1:
							{
								_closure8_1.ikK7lt9qGs = _this4;
								int num5 = 7;
								num4 = num5;
								continue;
							}
							case 6:
							case 8:
								num4 = 2;
								continue;
							case 0:
								goto end_IL_00a4;
							}
							goto IL_10aa;
							continue;
							end_IL_00a4:
							break;
						}
						goto end_IL_0079;
						IL_10aa:
						_closure8_1 = new _c__DisplayClass10_0();
						num4 = 1;						goto IL_00a4;
						end_IL_0079:;
					}
					catch (Exception ex2)
					{
						int num20 = 3;						while (true)
						{
							switch (num20)
							{
							case 3:
								_state1 = -2;
								num20 = 0;								break;
							case 2:
								num20 = 1;								break;
							default:
								_closure8_1 = null;
								num20 = 2;
								break;
							case 1:
								return;
							}
						}
					}
					goto case 3;
				case 5:
					num2 = 6;
					break;
				case 1:
					num3 = _state1;
					num2 = 0;					break;
				case 6:
					return;
				case 2:
					_closure8_1 = null;
					num2 = 2;					break;
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
static _LoadScriptsAsync_d__10()
	{
	}
internal static object yH3Tft8LekjCFILtMG1(int P_0)
		{
			return null;
		}
internal static void SZhIY28uP8MuPmbdNkQ(object P_0, object P_1)
		{
			((ScriptItem)P_0).Title = (string)P_1;
		}
internal static void bOZkpd8fbUTWo4JTkih(object P_0, object P_1)
		{
			((ScriptItem)P_0).Author = (string)P_1;
		}
internal static void kTZsJr8ls2pw7xaxiXo(object P_0, object P_1)
		{
			((ScriptItem)P_0).ImageUrl = (string)P_1;
		}
internal static void pJLCac8HZbDquECfYDl(object P_0, object P_1)
		{
			((ScriptItem)P_0).ScriptId = (string)P_1;
		}
internal static bool jK7Csj8ETEtJra7B9bx()
		{
			return JCP9uu8TdWqNyiM4QGK == null;
		}
internal static object for2we8KJUDlEjXTQJE()
		{
			return JCP9uu8TdWqNyiM4QGK;
		}
internal static void MQZcfy8nZ9S2nZk1u5J()
		{
			}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _OpenScriptButton_Click_d__13 : IAsyncStateMachine
	{
		public int _state1;

		public AsyncVoidMethodBuilder _asyncBuilder;

		public object sender;

		public ScriptHub _this4;

		private MainUI _mainUI2;

		private string _js3;

		private bool _setTextExists4;

		private int _wrap7_4;

		private TaskAwaiter<string> _awaiter_1;

		private TaskAwaiter _awaiter_2;

		internal static object VYeDYI82S6DxHXOi651;
public void MoveNext()
		{
			int num = 1;
			int num2 = num;
			int num3 = default(int);
			TaskAwaiter awaiter = default(TaskAwaiter);
			TaskAwaiter<string> awaiter2 = default(TaskAwaiter<string>);
			Window window = default(Window);
			ScriptHub scriptHub = default(ScriptHub);
			string text = default(string);
			ScriptItem scriptItem = default(ScriptItem);
			int num6 = default(int);
			Button button = default(Button);
			while (true)
			{
				switch (num2)
				{
				case 1:
					num3 = _state1;
					num2 = 0;					break;
				case 2:
					_state1 = -2;
					num2 = 4;
					break;
				case 4:
					num2 = 5;
					break;
				case 5:
					return;
				case 3:
					try
					{
						int num4;
						switch (num3)
						{
						default:
							num4 = 46;
							goto IL_00b9;
						case 3:
							awaiter = _awaiter_2;
							num4 = 17;
							goto IL_00b9;
						case 0:
						case 1:
							goto IL_05c4;
						case 2:
							goto IL_05cf;
						case 4:
							goto IL_0af0;
							IL_00b9:
							while (true)
							{
								int num5;
								switch (num4)
								{
								case 30:
									return;
								case 36:
									return;
								case 56:
									return;
								case 49:
									num4 = 16;									continue;
								default:
									_asyncBuilder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									num5 = 36;
									goto IL_00b5;
								case 9:
									break;
								case 24:
									SyjliE8GNJg3ELXyI09(_mainUI2, _mainUI2.codePage);
									num4 = 41;									continue;
								case 38:
									goto end_IL_0092;
								case 17:
									_awaiter_2 = default(TaskAwaiter);
									num4 = 34;									continue;
								case 47:
									_mainUI2.SetSelectedButton(_mainUI2.BracketButton);
									num4 = 31;									continue;
								case 41:
									goto end_IL_0092;
								case 44:
									window = null;
									num4 = 42;									continue;
								case 35:
									_asyncBuilder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num4 = 30;									continue;
								case 8:
									_awaiter_2 = awaiter;
									num4 = 26;
									continue;
								case 15:
									if (awaiter2.IsCompleted)
									{
										num4 = 12;										continue;
									}
									goto case 4;
								case 53:
									_awaiter_2 = awaiter;
									num4 = 35;									continue;
								case 10:
									_awaiter_2 = default(TaskAwaiter);
									num4 = 45;									continue;
								case 20:
									text = JsonSerializer.Serialize<object>(null);
									num4 = 11;									continue;
								case 50:
									if (_mainUI2 == null)
									{
										num4 = 36;										continue;
									}
									goto case 6;
								case 6:
									WOyN9x8cLp7WMEC0RKb(_mainUI2.tabsControl);
									num4 = 51;
									continue;
								case 2:
									goto end_IL_0092;
								case 11:
									_js3 = null;
									num4 = 54;
									continue;
								case 23:
									_awaiter_1 = default(TaskAwaiter<string>);
									num4 = 22;
									continue;
								case 21:
									num6 = _wrap7_4;
									num5 = 18;
									goto IL_00b5;
								case 45:
									num3 = (_state1 = -1);
									num5 = 29;
									goto IL_00b5;
								case 51:
									if (_mainUI2.tabsControl.currentWebView != null)
									{
										num4 = 20;
										continue;
									}
									goto case 24;
								case 1:
									_wrap7_4 = 0;
									num4 = 14;
									continue;
								case 19:
								case 27:
									if (_setTextExists4)
									{
										num4 = 52;										continue;
									}
									goto case 1;
								case 28:
								case 40:
									awaiter2.GetResult();
									num4 = 25;
									continue;
								case 39:
									_awaiter_1 = awaiter2;
									num4 = 0;									continue;
								case 55:
									if (scriptItem == null)
									{
										num4 = 2;										continue;
									}
									goto case 44;
								case 14:
									goto IL_05c4;
								case 48:
									goto IL_05cf;
								case 22:
									num3 = (_state1 = -1);
									num4 = 40;
									continue;
								case 46:
									button = sender as Button;
									num5 = 12;
									goto IL_00b5;
								case 5:
									num3 = (_state1 = 2);
									num4 = 8;
									continue;
								case 32:
									try
									{
										int num7;
										if (num3 != 0)
										{
											num7 = 15;
											goto IL_063a;
										}
										goto IL_087e;
										IL_087e:
										awaiter2 = _awaiter_1;
										num7 = 22;
										goto IL_063a;
										IL_063a:
										while (true)
										{
											object obj;
											switch (num7)
											{
											case 1:
												return;
											case 11:
												return;
											default:
												goto end_IL_063a;
											case 24:
												num7 = 0;												continue;
											case 17:
												_asyncBuilder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
												num7 = 11;
												continue;
											case 20:
												awaiter2 = default;
												num7 = 23;
												continue;
											case 3:
												_awaiter_2 = awaiter;
												num7 = 10;												continue;
											case 18:
												_awaiter_2 = default(TaskAwaiter);
												num7 = 4;												continue;
											case 2:
												num3 = (_state1 = -1);
												num7 = 21;												continue;
											case 21:
											{
												string result = awaiter2.GetResult();
												if (result == null)
												{
													num7 = 6;
													continue;
												}
												obj = null;
												goto IL_0960;
											}
											case 22:
												_awaiter_1 = default(TaskAwaiter<string>);
												num7 = 2;
												continue;
											case 8:
												num3 = (_state1 = 0);
												num7 = 5;
												continue;
											case 14:
												awaiter = default;
												num7 = 7;
												continue;
											case 16:
												num3 = (_state1 = -1);
												num7 = 24;												continue;
											case 5:
												_awaiter_1 = awaiter2;
												num7 = 9;
												continue;
											case 19:
												_setTextExists4 = true;
												num7 = 10;
												continue;
											case 12:
												break;
											case 7:
												if (true)
												{
													num7 = 13;
													continue;
												}
												goto case 24;
											case 10:
												goto end_IL_063a;
											case 9:
												_asyncBuilder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
												num7 = 1;												continue;
											case 23:
												if (!awaiter2.IsCompleted)
												{
													num7 = 8;
													continue;
												}
												goto case 21;
											case 4:
												awaiter = _awaiter_2;
												num7 = 18;
												continue;
											case 13:
												num3 = (_state1 = 1);
												num7 = 3;
												continue;
											case 15:
												if (num3 != 1)
												{
													int num8 = 20;
													num7 = num8;
													continue;
												}
												goto case 4;
											case 6:
												obj = null;
												goto IL_0960;
											case 0:
												goto end_IL_063a;
												IL_0960:
												if (false)
												{
													num7 = 19;
													continue;
												}
												goto case 14;
											}
											goto IL_087e;
											continue;
											end_IL_063a:
											break;
										}
									}
									catch
									{
										int num9 = 1;										while (true)
										{
											switch (num9)
											{
											case 1:
												_wrap7_4 = 1;
												num9 = 0;												continue;
											case 0:
												break;
											}
											break;
										}
									}
									goto case 21;
								case 25:
									_js3 = null;
									num4 = 24;
									continue;
								case 43:
									if (true)
									{
										num5 = 13;
										goto IL_00b5;
									}
									goto case 49;
								case 18:
									if (num6 == 1)
									{
										num4 = 33;
										continue;
									}
									goto case 19;
								case 29:
									num5 = 27;
									goto IL_00b5;
								case 54:
									_setTextExists4 = false;
									num4 = 19;
									continue;
								case 42:
									_mainUI2 = window as MainUI;
									num4 = 50;									continue;
								case 26:
									_asyncBuilder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num4 = 56;
									continue;
								case 12:
									if (button == null)
									{
										num4 = 39;										continue;
									}
									goto case 3;
								case 37:
									goto IL_0af0;
								case 33:
									awaiter = default;
									num4 = 7;
									continue;
								case 7:
									if (true)
									{
										num4 = 5;
										continue;
									}
									goto case 29;
								case 4:
									num3 = (_state1 = 4);
									num4 = 39;
									continue;
								case 34:
									num3 = (_state1 = -1);
									num4 = 49;
									continue;
								case 13:
									num3 = (_state1 = 3);
									num4 = 53;
									continue;
								case 16:
									awaiter2 = default;
									num4 = 11;									continue;
								case 52:
									awaiter = default;
									num4 = 43;									continue;
								case 3:
									scriptItem = null as ScriptItem;
									num4 = 55;
									continue;
								case 31:
									goto end_IL_0092;
									IL_00b5:
									num4 = num5;
									continue;
								}
								break;
							}
							goto case 3;
							IL_0af0:
							awaiter2 = _awaiter_1;
							num4 = 23;
							goto IL_00b9;
							IL_05cf:
							awaiter = _awaiter_2;
							num4 = 10;
							goto IL_00b9;
							IL_05c4:
							num4 = 32;
							goto IL_00b9;
							end_IL_0092:
							break;
						}
					}
					catch (Exception ex)
					{
						int num10 = 0;						while (true)
						{
							switch (num10)
							{
							case 1:
								return;
							case 2:
								num10 = 1;								break;
							default:
								_state1 = -2;
								num10 = 2;								break;
							}
						}
					}
					goto case 2;
				default:
					scriptHub = _this4;
					num2 = 3;					break;
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
static _OpenScriptButton_Click_d__13()
	{
	}
internal static void WOyN9x8cLp7WMEC0RKb(object P_0)
		{
			((TabsControl)P_0).AddNewTab();
		}
internal static object UobXJW8mHJgf0CJf5Kf(object P_0)
		{
			return ((ScriptItem)P_0).Code;
		}
internal static object jPppal8Z959M4x6yDuw(int P_0)
		{
			return null;
		}
internal static void SyjliE8GNJg3ELXyI09(object P_0, object P_1)
		{
			((MainUI)P_0).SwitchToPage((Grid)P_1);
		}
internal static bool GyEolt8o59h99vyGAXw()
		{
			return VYeDYI82S6DxHXOi651 == null;
		}
internal static object KMgVvl8V0jMdfClOOtG()
		{
			return VYeDYI82S6DxHXOi651;
		}
internal static void uUyBT58QnsIvvwnIIrg()
		{
			}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _ScrollViewerMain_ScrollChanged_d__11 : IAsyncStateMachine
	{
		public int _state1;

		public AsyncVoidMethodBuilder _asyncBuilder;

		public ScrollChangedEventArgs e;

		public ScriptHub _this4;

		private TaskAwaiter _awaiter_1;

		private static object H1Fme98bPXdxDFwfZ53;
public void MoveNext()
		{
			int num = 5;
			int num3 = default(int);
			TaskAwaiter awaiter = default(TaskAwaiter);
			ScriptHub scriptHub = default(ScriptHub);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 1:
						return;
					case 5:
						break;
					case 3:
						num2 = 1;						continue;
					default:
						_state1 = -2;
						num2 = 3;
						continue;
					case 2:
						try
						{
							int num4;
							if (num3 == 0)
							{
								num4 = 2;
								goto IL_00a9;
							}
							goto IL_01b4;
							IL_01b4:
							if (0 == 0.0)
							{
								num4 = 0;								goto IL_00a9;
							}
							goto IL_0214;
							IL_00a9:
							while (true)
							{
								switch (num4)
								{
								case 9:
									return;
								default:
								{
									_asyncBuilder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									int num5 = 9;
									num4 = num5;
									continue;
								}
								case 12:
								case 15:
									num4 = 10;
									continue;
								case 2:
								case 13:
									awaiter = _awaiter_1;
									num4 = 0;									continue;
								case 14:
									_awaiter_1 = awaiter;
									num4 = 0;									continue;
								case 8:
									awaiter = default;
									num4 = 7;
									continue;
								case 4:
									break;
								case 5:
									num3 = (_state1 = -1);
									num4 = 15;
									continue;
								case 11:
									goto IL_0214;
								case 7:
									if (false)
									{
										num4 = 5;										continue;
									}
									goto case 3;
								case 3:
									num3 = (_state1 = 0);
									num4 = 14;									continue;
								case 1:
									_awaiter_1 = default(TaskAwaiter);
									num4 = 5;
									continue;
								case 6:
									goto end_IL_0094;
								case 10:
									goto end_IL_0094;
								}
								break;
							}
							goto IL_01b4;
							IL_0214:
							if (0 + 0 >= 0 - 400.0)
							{
								num4 = 8;
								goto IL_00a9;
							}
							end_IL_0094:;
						}
						catch (Exception ex)
						{
							int num6 = 0;							while (true)
							{
								switch (num6)
								{
								case 1:
									return;
								case 2:
									num6 = 1;									break;
								default:
									_state1 = -2;
									num6 = 2;
									break;
								}
							}
						}
						goto default;
					case 4:
						scriptHub = _this4;
						num2 = 2;						continue;
					}
					break;
				}
				num3 = _state1;
				num = 4;
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
static _ScrollViewerMain_ScrollChanged_d__11()
	{
	}
internal static bool F64tVu83owdiDw0ZTFG()
		{
			return H1Fme98bPXdxDFwfZ53 == null;
		}
internal static object pa2j8k8YGr0GdZtgSKu()
		{
			return H1Fme98bPXdxDFwfZ53;
		}
internal static void iymhjN85v995egMF3QQ()
		{
			}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _SearchScriptsAsync_d__14 : IAsyncStateMachine
	{
		public int _state1;

		public AsyncTaskMethodBuilder _asyncBuilder;

		public ScriptHub _this4;

		public string query;

		private _c__DisplayClass14_0 _closure8_1;

		private TaskAwaiter _awaiter_1;

		private object _wrap7_1;

		private int _wrap7_2;

		private ConfiguredTaskAwaitable<JsonElement>.ConfiguredTaskAwaiter _awaiter_2;

		private TaskAwaiter<MessageBoxResult> _awaiter_3;

		internal static object ivxnXf8zlAii21KS39m;
public void MoveNext()
		{
			int num = 6;
			int num2 = num;
			int num3 = default(int);
			TaskAwaiter awaiter = default(TaskAwaiter);
			ScriptHub scriptHub = default(ScriptHub);
			TaskAwaiter<MessageBoxResult> awaiter2 = default(TaskAwaiter<MessageBoxResult>);
			_c__DisplayClass14_1 _c__DisplayClass14_ = default(_c__DisplayClass14_1);
			int num6 = default(int);
			ConfiguredTaskAwaitable<JsonElement> configuredTaskAwaitable = default(ConfiguredTaskAwaitable<JsonElement>);
			string requestUri = default(string);
			JsonElement.ArrayEnumerator arrayEnumerator = default(JsonElement.ArrayEnumerator);
			JsonElement jsonElement4 = default(JsonElement);
			JsonElement.ArrayEnumerator enumerator = default(JsonElement.ArrayEnumerator);
			JsonElement result = default(JsonElement);
			JsonElement jsonElement3 = default(JsonElement);
			ConfiguredTaskAwaitable<JsonElement>.ConfiguredTaskAwaiter awaiter3 = default(ConfiguredTaskAwaitable<JsonElement>.ConfiguredTaskAwaiter);
			JsonElement jsonElement2 = default(JsonElement);
			JsonElement jsonElement = default(JsonElement);
			string text = default(string);
			string text3 = default(string);
			string text4 = default(string);
			string text2 = default(string);
			string scriptId = default(string);
			while (true)
			{
				switch (num2)
				{
				default:
					try
					{
						int num4;
						if (num3 == 0)
						{
							num4 = 12;
							goto IL_0055;
						}
						goto IL_1014;
						IL_1014:
						if ((uint)(num3 - 1) <= 2u)
						{
							num4 = 18;
							goto IL_0055;
						}
						goto IL_0fd5;
						IL_0055:
						while (true)
						{
							switch (num4)
							{
							case 15:
								awaiter = default;
								num4 = 8;
								continue;
							case 22:
								scriptHub.GF1KNtnlB = 1;
								num4 = 7;
								continue;
							case 7:
								scriptHub.WB7upf0Tm = true;
								num4 = 15;
								continue;
							case 11:
								YoR5eNJDd6wraw0n8Py(scriptHub.MWWsdIUpt());
								num4 = 20;
								continue;
							case 5:
								return;
							case 21:
								try
								{
									int num5;
									if ((uint)(num3 - 1) > 1u)
									{
										num5 = 16;
										goto IL_018a;
									}
									goto IL_0d79;
									IL_0d79:
									num5 = 11;									goto IL_018a;
									IL_018a:
									while (true)
									{
										int num17;
										switch (num5)
										{
										case 19:
											_asyncBuilder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
											num5 = 13;
											continue;
										case 4:
											num3 = (_state1 = -1);
											num5 = 10;
											continue;
										case 13:
											return;
										case 6:
											_c__DisplayClass14_.rgB7Zy0pnv = (Exception)_wrap7_1;
											num5 = 15;											continue;
										case 10:
										case 20:
											awaiter2.GetResult();
											num5 = 0;											continue;
										case 16:
											if (num3 != 3)
											{
												num5 = 8;												continue;
											}
											goto case 14;
										default:
											_wrap7_1 = null;
											num5 = 7;											continue;
										case 12:
											_awaiter_3 = default(TaskAwaiter<MessageBoxResult>);
											num5 = 4;											continue;
										case 8:
											_wrap7_2 = 0;
											num17 = 2;
											goto IL_0186;
										case 17:
											num6 = _wrap7_2;
											num17 = 7;
											goto IL_0186;
										case 11:
											try
											{
												int num7;
												if (num3 != 1)
												{
													num7 = 10;													goto IL_0383;
												}
												goto IL_0696;
												IL_0383:
												while (true)
												{
													switch (num7)
													{
													case 6:
														configuredTaskAwaitable = xMDEPcOfq.GetFromJsonAsync<JsonElement>(requestUri).ConfigureAwait(continueOnCapturedContext: false);
														num7 = 18;
														continue;
													case 10:
														_awaiter_2 = default(ConfiguredTaskAwaitable<JsonElement>.ConfiguredTaskAwaiter);
														num7 = 2;														continue;
													case 21:
														num3 = (_state1 = -1);
														num7 = 1;														continue;
													case 26:
														if (false)
														{
															num7 = 8;
															continue;
														}
														goto case 19;
													case 17:
														arrayEnumerator = jsonElement4.EnumerateArray();
														num7 = 30;
														continue;
													case 30:
														enumerator = arrayEnumerator.GetEnumerator();
														num7 = 29;
														continue;
													default:
														num3 = (_state1 = -1);
														num7 = 2;														continue;
													case 5:
														if (false)
														{
															num7 = 16;															continue;
														}
														goto case 24;
													case 25:
														return;
													case 8:
													case 15:
														num7 = 23;
														continue;
													case 12:
														_awaiter_1 = default(TaskAwaiter);
														num7 = 0;														continue;
													case 3:
														_asyncBuilder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
														num7 = 25;														continue;
													case 11:
														if (num3 != 2)
														{
															num7 = 13;
															continue;
														}
														goto case 9;
													case 4:
														_closure8_1.OKM7cp6niD = new List<ScriptItem>();
														num7 = 5;
														continue;
													case 18:
														awaiter3 = configuredTaskAwaitable.GetAwaiter();
														num7 = 20;
														continue;
													case 24:
														awaiter = default;
														num7 = 26;
														continue;
													case 9:
														awaiter = _awaiter_1;
														num7 = 12;
														continue;
													case 16:
														if (false)
														{
															num7 = 17;
															continue;
														}
														goto case 24;
													case 14:
														break;
													case 20:
														if (!awaiter3.IsCompleted)
														{
															num7 = 28;
															continue;
														}
														goto case 1;
													case 27:
														_awaiter_2 = awaiter3;
														num7 = 7;
														continue;
													case 13:
														requestUri = null;
														num7 = 0;														continue;
													case 1:
														result = awaiter3.GetResult();
														num7 = 4;														continue;
													case 7:
														_asyncBuilder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
														num7 = 2;														continue;
													case 28:
													{
														num3 = (_state1 = 1);
														int num11 = 27;
														num7 = num11;
														continue;
													}
													case 22:
														_awaiter_1 = awaiter;
														num7 = 3;
														continue;
													case 2:
														return;
													case 29:
														try
														{
															while (true)
															{
																IL_08ba:
																int num8;
																if (true)
																{
																	num8 = 2;
																	goto IL_07fe;
																}
																goto IL_0854;
																IL_07fe:
																while (true)
																{
																	object obj;
																	switch (num8)
																	{
																	case 12:
																		break;
																	case 3:
																		jsonElement2 = default;
																		num8 = 18;
																		continue;
																	case 11:
																		goto IL_08ba;
																	case 6:
																		if (false)
																		{
																			num8 = 1;																			continue;
																		}
																		goto default;
																	case 13:
																		if (false)
																		{
																			num8 = 7;																			continue;
																		}
																		goto case 6;
																	case 15:
																		jsonElement2 = default;
																		num8 = 4;																		continue;
																	case 18:
																		text3 = null;
																		num8 = 8;
																		continue;
																	case 9:
																		jsonElement2 = default;
																		num8 = 2;																		continue;
																	case 4:
																		text4 = null;
																		num8 = 13;
																		continue;
																	default:
																		text = null;
																		num8 = 16;
																		continue;
																	case 8:
																		jsonElement2 = default;
																		num8 = 15;
																		continue;
																	case 1:
																	case 7:
																	case 16:
																	{
																		List<ScriptItem> list = _closure8_1.OKM7cp6niD;
																		ScriptItem scriptItem = new ScriptItem();
																		BEiS6OJISHhkeWhcCYB(scriptItem, text3);
																		vWRmCMJtj7NrRM2wfpl(scriptItem, text2);
																		oSPgpkJgVRnsvpWidSs(scriptItem, text);
																		scriptItem.ScriptId = scriptId;
																		w3HlYvJR1dyoOXcsKBr(scriptItem, text4);
																		list.Add(scriptItem);
																		int num9 = 11;
																		num8 = num9;
																		continue;
																	}
																	case 5:
																		scriptId = null;
																		num8 = 17;
																		continue;
																	case 14:
																		obj = null;
																		jsonElement2 = default;
																		text = null;
																		if (obj == null)
																		{
																			num8 = 9;																			continue;
																		}
																		goto IL_0c06;
																	case 17:
																		jsonElement2 = default;
																		num8 = 4;																		continue;
																	case 10:
																		obj = kXTgxKJ7WGIyEn2NYSW(0x243111E1 ^ 0);
																		goto IL_0c06;
																	case 2:
																		goto end_IL_08ba;
																		IL_0c06:
																		text2 = (string)obj;
																		num8 = 9;
																		continue;
																	}
																	break;
																}
																goto IL_0854;
																IL_0854:
																jsonElement = default;
																num8 = 3;																goto IL_07fe;
																continue;
																end_IL_08ba:
																break;
															}
														}
														finally
														{
															int num10;
															if (num3 >= 0)
															{
																num10 = 2;																goto IL_0c42;
															}
															goto IL_0c58;
															IL_0c42:
															switch (num10)
															{
															default:
																goto end_IL_0c17;
															case 1:
																break;
															case 2:
																goto end_IL_0c17;
															case 0:
																goto end_IL_0c17;
															}
															goto IL_0c58;
															IL_0c58:
															((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
															num10 = 0;															goto IL_0c42;
															end_IL_0c17:;
														}
														goto case 24;
													case 19:
														num3 = (_state1 = 2);
														num7 = 22;
														continue;
													case 23:
														goto end_IL_0383;
													}
													goto IL_0696;
													continue;
													end_IL_0383:
													break;
												}
												goto end_IL_0358;
												IL_0696:
												awaiter3 = _awaiter_2;
												num7 = 10;
												goto IL_0383;
												end_IL_0358:;
											}
											catch (Exception ex)
											{
												int num16 = 2;												while (true)
												{
													switch (num16)
													{
													case 2:
														_wrap7_1 = ex;
														num16 = 0;														continue;
													default:
														_wrap7_2 = 1;
														num16 = 1;														continue;
													case 1:
														break;
													}
													break;
												}
											}
											goto case 17;
										case 18:
											_awaiter_3 = awaiter2;
											num5 = 19;
											continue;
										case 2:
											break;
										case 3:
											if (awaiter2.IsCompleted)
											{
												num5 = 20;
												continue;
											}
											goto case 1;
										case 5:
											_c__DisplayClass14_ = new _c__DisplayClass14_1();
											num5 = 6;											continue;
										case 14:
											awaiter2 = _awaiter_3;
											num5 = 12;											continue;
										case 15:
											awaiter2 = scriptHub.Dispatcher.InvokeAsync((Func<MessageBoxResult>)_c__DisplayClass14_.W887m6gQxx).GetAwaiter();
											num5 = 3;											continue;
										case 1:
											num3 = (_state1 = 3);
											num5 = 18;											continue;
										case 7:
											if (num6 == 1)
											{
												num5 = 4;												continue;
											}
											goto default;
										case 9:
											goto end_IL_018a;
											IL_0186:
											num5 = num17;
											continue;
										}
										goto IL_0d79;
										continue;
										end_IL_018a:
										break;
									}
								}
								finally
								{
									if (num3 < 0)
									{
										int num18 = 0;										while (true)
										{
											switch (num18)
											{
											default:
												scriptHub.MEjLDLhVD = false;
												num18 = 1;												continue;
											case 1:
												break;
											}
											break;
										}
									}
								}
								break;
							case 12:
							case 16:
								awaiter = _awaiter_1;
								num4 = 3;
								continue;
							case 17:
								scriptHub.MEjLDLhVD = true;
								num4 = 11;
								continue;
							case 13:
								num4 = 20;								continue;
							case 24:
								break;
							case 2:
								scriptHub.MWWsdIUpt().Clear();
								num4 = 22;
								continue;
							case 1:
								num3 = (_state1 = -1);
								num4 = 13;
								continue;
							default:
								_awaiter_1 = awaiter;
								num4 = 4;
								continue;
							case 3:
								_awaiter_1 = default(TaskAwaiter);
								num4 = 1;								continue;
							case 10:
								goto IL_0fd5;
							case 8:
								if (true)
								{
									num4 = 9;
									continue;
								}
								goto case 13;
							case 18:
							case 20:
							{
								int num19 = 21;
								num4 = num19;
								continue;
							}
							case 23:
								goto IL_1014;
							case 4:
								_asyncBuilder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num4 = 5;
								continue;
							case 6:
								_closure8_1.hts7V8Wco6 = _this4;
								num4 = 19;
								continue;
							case 9:
								num3 = (_state1 = 0);
								num4 = 0;								continue;
							case 19:
								if (false)
								{
									num4 = 1;									continue;
								}
								goto case 17;
							case 14:
								break;
							}
							break;
						}
						goto end_IL_0040;
						IL_0fd5:
						_closure8_1 = new _c__DisplayClass14_0();
						num4 = 6;
						goto IL_0055;
						end_IL_0040:;
					}
					catch (Exception ex2)
					{
						int num20 = 2;
						while (true)
						{
							switch (num20)
							{
							case 2:
								_state1 = -2;
								num20 = 0;								break;
							case 3:
								num20 = 1;								break;
							default:
								_closure8_1 = null;
								num20 = 3;
								break;
							case 1:
								return;
							}
						}
					}
					break;
				case 2:
					_closure8_1 = null;
					num2 = 4;
					continue;
				case 1:
					return;
				case 6:
					num3 = _state1;
					num2 = 5;					continue;
				case 5:
					scriptHub = _this4;
					num2 = 0;					continue;
				case 4:
					num2 = 1;					continue;
				case 3:
					break;
				}
				_state1 = -2;
				num2 = 2;
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
static _SearchScriptsAsync_d__14()
	{
	}
internal static void YoR5eNJDd6wraw0n8Py(object P_0)
		{
			((Collection<ScriptItem>)P_0).Clear();
		}
internal static object kXTgxKJ7WGIyEn2NYSW(int P_0)
		{
			return null;
		}
internal static void BEiS6OJISHhkeWhcCYB(object P_0, object P_1)
		{
			((ScriptItem)P_0).Title = (string)P_1;
		}
internal static void vWRmCMJtj7NrRM2wfpl(object P_0, object P_1)
		{
			((ScriptItem)P_0).Author = (string)P_1;
		}
internal static void oSPgpkJgVRnsvpWidSs(object P_0, object P_1)
		{
			((ScriptItem)P_0).ImageUrl = (string)P_1;
		}
internal static void w3HlYvJR1dyoOXcsKBr(object P_0, object P_1)
		{
			((ScriptItem)P_0).Code = (string)P_1;
		}
internal static bool waYQ1kJPkSEPN8t0Qws()
		{
			return ivxnXf8zlAii21KS39m == null;
		}
internal static object ySDedrJWom3NerXcva2()
		{
			return ivxnXf8zlAii21KS39m;
		}
internal static void uRYYSfJhOtsxquaT6bu()
		{
			}
	}

	[CompilerGenerated]
	private ObservableCollection<ScriptItem> dXATkqhHD;

	private static readonly HttpClient xMDEPcOfq;

	private int GF1KNtnlB;

	private bool MEjLDLhVD;

	private bool WB7upf0Tm;

	private readonly Timer EIAfdLpL0;

						private bool hrrl5qTgc;

	private static ScriptHub mOZVI3CQJiL5nZMjrJD;
[SpecialName]
	[CompilerGenerated]
	private ObservableCollection<ScriptItem> MWWsdIUpt()
	{
		return dXATkqhHD;
	}
[SpecialName]
	[CompilerGenerated]
	private void f0x8Q36wx(ObservableCollection<ScriptItem> P_0)
	{
		dXATkqhHD = P_0;
	}
public ScriptHub()
	{
		InitializeComponent();
		dXATkqhHD = new ObservableCollection<ScriptItem>();
		GF1KNtnlB = 1;
		WB7upf0Tm = true;
		gLfrY9C53kxdNTuVy3e(ScrollViewerMain);
		Timer timer = new Timer(500.0);
		EIAfdLpL0 = timer;
		// 加载脚本
		_ = QCvqhq2lY();
	}

[AsyncStateMachine(typeof(_LoadScriptsAsync_d__10))]
	private async Task QCvqhq2lY()
	{
		try
		{
			using var client = new System.Net.Http.HttpClient();
			client.Timeout = TimeSpan.FromSeconds(15);

			string searchQuery = SearchBox?.Text?.Trim() ?? "";
			string url;
			if (string.IsNullOrEmpty(searchQuery))
			{
				url = $"https://scriptblox.com/api/script/fetch?page={GF1KNtnlB}";
			}
			else
			{
				url = $"https://scriptblox.com/api/script/fetch?page={GF1KNtnlB}&q={Uri.EscapeDataString(searchQuery)}";
			}

			var response = await client.GetStringAsync(url);
			var json = System.Text.Json.JsonDocument.Parse(response);
			var root = json.RootElement;

			if (root.TryGetProperty("result", out var results))
			{
				foreach (var item in results.EnumerateArray())
				{
					var scriptItem = new ScriptItem();
					scriptItem.ScriptId = item.TryGetProperty("_id", out var id) ? id.GetString() ?? "" : "";
					scriptItem.Title = item.TryGetProperty("title", out var title) ? title.GetString() ?? "Untitled" : "Untitled";
					scriptItem.Author = item.TryGetProperty("creator", out var creator) ? (creator.ValueKind == System.Text.Json.JsonValueKind.String ? creator.GetString() ?? "Unknown" : "Unknown") : "Unknown";
					scriptItem.ImageUrl = item.TryGetProperty("image", out var img) ? img.GetString() ?? "" : "";
					scriptItem.Code = item.TryGetProperty("script", out var code) ? code.GetString() ?? "" : "";

					dXATkqhHD.Add(scriptItem);
				}
			}

			if (root.TryGetProperty("totalPages", out var totalPages))
			{
				int tp = totalPages.GetInt32();
				if (GF1KNtnlB < tp)
				{
					GF1KNtnlB++;
					WB7upf0Tm = true;
				}
				else
				{
					WB7upf0Tm = false;
				}
			}

			if (ScriptItemsControl != null)
			{
				ScriptItemsControl.ItemsSource = dXATkqhHD;
			}
		}
		catch (Exception ex)
		{
			Debug.WriteLine($"LoadScriptsAsync: {ex}");
		}
	}
[AsyncStateMachine(typeof(_ScrollViewerMain_ScrollChanged_d__11))]
	private void cZ4X5VD22(object P_0, ScrollChangedEventArgs P_1)
	{
		_ScrollViewerMain_ScrollChanged_d__11 stateMachine = default(_ScrollViewerMain_ScrollChanged_d__11);
		stateMachine._asyncBuilder = default;
		stateMachine._this4 = this;
		stateMachine.e = P_1;
		stateMachine._state1 = -1;
		stateMachine._asyncBuilder.Start(ref stateMachine);
	}
private void yqOMnNurq(object P_0, RoutedEventArgs P_1)
	{
		int num = 6;
		ScriptItem scriptItem = default(ScriptItem);
		Button button = default(Button);
		MainUI mainUI = default(MainUI);
		JObject jObject2 = default(JObject);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 9:
					if (scriptItem != null)
					{
						num2 = 2;						continue;
					}
					return;
				case 3:
					return;
				case 6:
					button = P_0 as Button;
					num2 = 1;					continue;
				case 4:
					return;
				case 7:
					return;
				default:
					i3h0ceFW5I5nv4ntf7c(mainUI._webSocketServer, null);
					num2 = 1;					continue;
				case 8:
					break;
				case 10:
				{
					JObject jObject = new JObject();
					jObject2 = jObject;
					num2 = 0;					continue;
				}
				case 1:
					if (mainUI == null)
					{
						return;
					}
					num2 = 11;
					continue;
				case 2:
					mainUI = null as MainUI;
					num2 = 1;					continue;
				case 5:
					if (button == null)
					{
						num2 = 7;
						continue;
					}
					break;
				case 11:
					if (BPIWuWCzvCWrKiocixR(mainUI._webSocketServer._clients))
					{
						num2 = 3;
						continue;
					}
					goto case 10;
				}
				break;
			}
			scriptItem = null as ScriptItem;
			num = 9;
		}
	}
[AsyncStateMachine(typeof(_OpenScriptButton_Click_d__13))]
	private void IgZBZf55p(object P_0, RoutedEventArgs P_1)
	{
		_OpenScriptButton_Click_d__13 stateMachine = default(_OpenScriptButton_Click_d__13);
		stateMachine._asyncBuilder = default;
		stateMachine._this4 = this;
		stateMachine.sender = P_0;
		stateMachine._state1 = -1;
		stateMachine._asyncBuilder.Start(ref stateMachine);
	}
[AsyncStateMachine(typeof(_SearchScriptsAsync_d__14))]
	private Task HpKpW1Khp(string P_0)
	{
		_SearchScriptsAsync_d__14 stateMachine = default(_SearchScriptsAsync_d__14);
		stateMachine._asyncBuilder = AsyncTaskMethodBuilder.Create();
		stateMachine._this4 = this;
		stateMachine.query = P_0;
		stateMachine._state1 = -1;
		stateMachine._asyncBuilder.Start(ref stateMachine);
		return stateMachine._asyncBuilder.Task;
	}

	// [DEOBFUSCATED] Control flow flattening detected (initial state: 2)
private void njwCVp8Zs(object P_0, TextChangedEventArgs P_1)
	{
	int num = 2;
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
			case 2:
				num2 = 1;				break;
			}
		}
	}
/* InitializeComponent provided by .g.cs */
/* IComponentConnector\.Connect removed */
/* IStyleConnector\.Connect removed */
static ScriptHub()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 4:
				num2 = 0;				break;
			case 2:
				Pduiv9FDu60SCQhoOKk();
				num2 = 1;				break;
			default:
				xMDEPcOfq = new HttpClient();
				num2 = 3;
				break;
			case 3:
				return;
			case 1:
				
				num2 = 4;
				break;
			}
		}
	}
[CompilerGenerated]
	[AsyncStateMachine(typeof(_ctor_b_9_0_d))]
	private void AKSFitb7q(object? s, ElapsedEventArgs P_1)
	{
		_ctor_b_9_0_d stateMachine = default(_ctor_b_9_0_d);
		stateMachine._asyncBuilder = default;
		stateMachine._this4 = this;
		stateMachine._state1 = -1;
		stateMachine._asyncBuilder.Start(ref stateMachine);
	}
[CompilerGenerated]
	[AsyncStateMachine(typeof(_ctor_b_9_1_d))]
	private Task LuxOvA4cw()
	{
		_ctor_b_9_1_d stateMachine = default(_ctor_b_9_1_d);
		stateMachine._asyncBuilder = AsyncTaskMethodBuilder.Create();
		stateMachine._this4 = this;
		stateMachine._state1 = -1;
		stateMachine._asyncBuilder.Start(ref stateMachine);
		return stateMachine._asyncBuilder.Task;
	}
internal static void r6pq1xCYCG4IKYlBYX5()
	{
		
	}
internal static void gLfrY9C53kxdNTuVy3e(object P_0)
	{
		SmoothScroll.Attach((ScrollViewer)P_0);
	}
internal static bool A4XC7cCbbo9najjxMBj()
	{
		return mOZVI3CQJiL5nZMjrJD == null;
	}
internal static ScriptHub wwX15mC3yqbJw9qvLJg()
	{
		return mOZVI3CQJiL5nZMjrJD;
	}
internal static bool BPIWuWCzvCWrKiocixR(object P_0)
	{
		return ((ConcurrentDictionary<string, ConnectedClient>)P_0).IsEmpty;
	}
internal static object ryPYOoFP43rIyK4B94q(int P_0)
	{
		return null;
	}
internal static object i3h0ceFW5I5nv4ntf7c(object P_0, object P_1)
	{
		return ((WebSocketServer)P_0).Broadcast((string)P_1);
	}
internal static void Pduiv9FDu60SCQhoOKk()
	{
		}
}
