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
using System.IO;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;
using TextBlock = System.Windows.Controls.TextBlock;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using Newtonsoft.Json;
using Potassium_UI_V2.Services;
using Potassium_UI_V2.Views.MainWindow;
using Potassium.DataModels;
using Potassium.Services;

namespace Potassium_UI_V2.Views.Login;

public partial class Login : Window
{
	[CompilerGenerated]
	private sealed class _c__DisplayClass14_0
	{
		public Login sYrIB7wSae;

		public BlurEffect baQIpwi9XE;

		private static _c__DisplayClass14_0 I2jcHWEgEl7vrlH3S4f;
public _c__DisplayClass14_0()
		{
			C4KnqnE4aXSyUTCHmEc();
			dIhaIQEknT8vcovUm6K();
int num = 0;			switch (num)
			{
			case 0:
				break;
			}
		}

		// [DEOBFUSCATED] Control flow flattening detected (initial state: 1)
internal void K76IX37WPE(object? s, EventArgs e)
		{
		int num = 1;
		int num2 = num;
		while (true)
		{
		switch (num2)
				{
				default:
					num2 = 2;
					break;
				case 1:
					num2 = 0;
					break;
				case 2:
					return;
				}
			}
		}

		// [DEOBFUSCATED] Control flow flattening detected (initial state: 1)
internal void le4IMsnCsH(object? s, EventArgs e)
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
					num2 = 0;
					break;
				case 0:
					return;
				}
			}
		}
static _c__DisplayClass14_0()
	{
	}
internal static void C4KnqnE4aXSyUTCHmEc()
		{
			
		}
internal static void dIhaIQEknT8vcovUm6K()
		{
			}
internal static bool CTIZwcERe17nbqZmArS()
		{
			return I2jcHWEgEl7vrlH3S4f == null;
		}
internal static _c__DisplayClass14_0 Gr6L6rEhN8W92mIG5EL()
		{
			return I2jcHWEgEl7vrlH3S4f;
		}
internal static void T9gx7OEjqYgQWPTD6j7()
		{
			}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _DownloadBinaries_d__15 : IAsyncStateMachine
	{
		public int _state1;

		public AsyncTaskMethodBuilder<bool> _asyncBuilder;

		public Login _this4;

		private string _replacement2;

		private string[] _urls3;

		private Dictionary<string, string> _hashes4;

		private TaskAwaiter<string> _awaiter_1;

		private string[] _wrap7_4;

		private int _wrap7_5;

		private string _filePath7;

		private HttpResponseMessage _response8;

		private TaskAwaiter<HttpResponseMessage> _awaiter_2;

		private long _totalBytes9;

		private bool _canReportProgress10;

		private Stream _contentStream11;

		private TaskAwaiter<Stream> _awaiter_3;

		private FileStream _fileStream12;

		private long _totalRead13;

		private byte[] _buffer14;

		private int _read15;

		private TaskAwaiter _awaiter_4;

		private ValueTaskAwaiter<int> _awaiter_5;

		private static object YG43XiE6neCKreoGT2l;
public void MoveNext()
		{
			int num = 4;
			int num2 = num;
			Login login = default(Login);
			int num3 = default(int);
			TaskAwaiter<string> awaiter = default(TaskAwaiter<string>);
			HttpResponseMessage result2 = default(HttpResponseMessage);
			TaskAwaiter<HttpResponseMessage> awaiter2 = default(TaskAwaiter<HttpResponseMessage>);
			bool result = default(bool);
			string text = default(string);
			Dictionary<string, string> dictionary = default(Dictionary<string, string>);
			string text3 = default(string);
			string value = default(string);
			string text4 = default(string);
			string text2 = default(string);
			TaskAwaiter<Stream> awaiter3 = default(TaskAwaiter<Stream>);
			TaskAwaiter awaiter4 = default(TaskAwaiter);
			double num10 = default(double);
			ValueTaskAwaiter<int> awaiter5 = default(ValueTaskAwaiter<int>);
			ValueTask<int> valueTask = default(ValueTask<int>);
		int result4 = default(int);
		int num11 = default(int);
		Stream result3 = default(Stream);
		string result5 = default(string);
		while (true)
		{
			switch (num2)
			{
			case 3:
			login = _this4;
			num2 = 5;
			break;
		case 5:
			try
			{
						_ = 5;
						int num4 = 0;						while (true)
						{
							switch (num4)
						{
						case 1:
							num4 = 0;							continue;
						default:
							try
							{
								int num5;
								int num16;
								switch (num3)
								{
								default:
									num5 = 15;
									goto IL_00eb;
									case 0:
										awaiter = _awaiter_1;
										num5 = 39;
										goto IL_00eb;
									case 1:
										goto IL_0434;
									case 2:
										goto IL_1132;
									case 3:
									case 4:
									case 5:
										goto IL_11ed;
										IL_00eb:
									while (true)
									{
										object obj;
										switch (num5)
										{
											case 17:
												if (_hashes4 != null)
												{
													num5 = 16;													continue;
												}
												goto case 61;
											case 45:
												result2 = awaiter2.GetResult();
												num5 = 49;
												continue;
											case 60:
												result = false;
												num5 = 46;
												continue;
											case 64:
												_urls3 = new string[3]
												{
													null,
													null,
													(string)b8yGFOEiIgxEwX5tf4q(0x1BCA3933 ^ 0)
												};
												num5 = 8;
												continue;
											case 61:
												result = false;
												num5 = 27;												continue;
											case 56:
												text = _wrap7_4[_wrap7_5];
												num5 = 28;												continue;
											case 47:
												return;
											case 54:
												_wrap7_4 = null;
												num5 = 7;												continue;
											case 25:
											case 53:
												dictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(awaiter.GetResult());
												num5 = 0;												continue;
											case 11:
												if (_hashes4.TryGetValue(text3, out value))
												{
													num5 = 2;													continue;
												}
												goto case 59;
											case 4:
												if (dictionary != null)
												{
													num5 = 2;													continue;
												}
												goto case 60;
											case 29:
												goto IL_0434;
											case 6:
												if (true)
												{
													num5 = 59;
													continue;
												}
												goto case 30;
											case 27:
												_awaiter_1 = awaiter;
												num5 = 57;
												continue;
											case 13:
												if (awaiter.IsCompleted)
												{
													num5 = 25;													continue;
												}
												goto case 43;
											case 41:
												return;
											case 63:
												goto IL_04c2;
											case 23:
												obj = "";
												goto IL_15bb;
											case 30:
												_wrap7_5++;
												num5 = 35;
												continue;
											case 20:
											case 52:
												if (true)
												{
													num5 = 23;
													continue;
												}
												obj = sOxUl9EyP5xRqdEUMif(_filePath7);
												goto IL_15bb;
											case 35:
											case 50:
												if (_wrap7_5 >= _wrap7_4.Length)
												{
													num5 = 54;													continue;
												}
												goto case 56;
											case 42:
												num5 = 66;												continue;
											case 44:
												goto end_IL_00c0;
											case 48:
												if (!awaiter.IsCompleted)
												{
													goto IL_05ac;
												}
												goto case 62;
											case 19:
												_wrap7_5 = 0;
												num5 = 50;
												continue;
											case 18:
												if (!awaiter2.IsCompleted)
												{
													num5 = 6;													continue;
												}
												goto case 45;
											case 12:
												num3 = (_state1 = -1);
												num5 = 53;
												continue;
											case 38:
												try
												{
													int num7;
													if (num3 != 3)
													{
														num7 = 12;
														goto IL_0654;
													}
													goto IL_0fe2;
													IL_0fe2:
													awaiter3 = _awaiter_3;
													num7 = 0;													goto IL_0654;
													IL_0654:
													while (true)
													{
														switch (num7)
														{
														default:
															return;
														case 11:
															awaiter3 = default;
															num7 = 10;
															continue;
														case 5:
															num7 = 8;															continue;
														case 18:
															try
															{
																int num8;
																if ((uint)(num3 - 4) > 1u)
																{
																	num8 = 0;																	goto IL_0737;
																}
																goto IL_0755;
																IL_0737:
																while (true)
																{
																	switch (num8)
																	{
																	case 4:
																		break;
																	case 1:
																		try
																		{
																			int num9;
																			if (num3 != 4)
																			{
																				num9 = 26;
																				goto IL_078c;
																			}
																			goto IL_097e;
																			IL_097e:
																			awaiter4 = _awaiter_4;
																			num9 = 32;
																			goto IL_078c;
																			IL_078c:
																			while (true)
																			{
																				switch (num9)
																				{
																				case 9:
																					num3 = (_state1 = -1);
																					num9 = 33;
																					continue;
																				case 1:
																					if (_canReportProgress10)
																					{
																						num9 = 12;																						continue;
																					}
																					goto case 3;
																				case 25:
																				{
																					TextBlock progressText = login.progressText;
																					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
																					defaultInterpolatedStringHandler.AppendFormatted(num10, null);
																					num9 = 3;
																					continue;
																				}
																				case 7:
																					return;
																				case 8:
																				case 14:
																					num9 = 31;																					continue;
																				case 21:
																					awaiter5 = valueTask.GetAwaiter();
																					num9 = 18;
																					continue;
																				case 10:
																					_awaiter_5 = awaiter5;
																					num9 = 34;																					continue;
																				case 12:
																					num3 = (_state1 = -1);
																					num9 = 13;																					continue;
																				case 30:
																					break;
																				case 6:
																				{
																					_asyncBuilder.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
																					int num12 = 27;
																					num9 = num12;
																					continue;
																				}
																				case 22:
																					awaiter = default;
																					num9 = 29;
																					continue;
																				case 5:
																					num3 = (_state1 = 4);
																					num9 = 1;																					continue;
																				case 34:
																					_asyncBuilder.AwaitUnsafeOnCompleted(ref awaiter5, ref this);
																					num9 = 7;
																					continue;
																				case 3:
																				case 24:
																					valueTask = default;
																					num9 = 21;																					continue;
																				case 4:
																					num3 = (_state1 = 5);
																					num9 = 2;																					continue;
																				case 2:
																					_awaiter_5 = default(ValueTaskAwaiter<int>);
																					num9 = 4;																					continue;
																				case 32:
																					_awaiter_4 = default(TaskAwaiter);
																					num9 = 12;
																					continue;
																				case 28:
																					_totalRead13 = 0L;
																					num9 = 20;
																					continue;
																				case 33:
																					result4 = awaiter5.GetResult();
																					num9 = 11;
																					continue;
																				case 20:
																					_buffer14 = new byte[8192];
																					num9 = 24;
																					continue;
																				case 31:
																					_totalRead13 += _read15;
																					num9 = 1;																					continue;
																				case 13:
																					awaiter5 = _awaiter_5;
																					num9 = 2;																					continue;
																				case 18:
																					if (!awaiter5.IsCompleted)
																					{
																						num9 = 4;
																						continue;
																					}
																					goto case 33;
																				case 26:
																					if (num3 != 5)
																					{
																						num9 = 28;
																						continue;
																					}
																					goto case 13;
																				case 17:
																					if (num11 <= 0)
																					{
																						num9 = 23;																						continue;
																					}
																					goto case 22;
																				case 23:
																					_buffer14 = null;
																					num9 = 15;
																					continue;
																				case 27:
																					return;
																				case 16:
																					_awaiter_4 = awaiter4;
																					num9 = 6;
																					continue;
																				case 11:
																					num11 = (_read15 = result4);
																					num9 = 13;																					continue;
																				case 19:
																					num10 = (double)_totalRead13 * 100.0 / (double)_totalBytes9;
																					num9 = 0;																					continue;
																				default:
																					num9 = 0;																					continue;
																				case 29:
																					if (false)
																					{
																						num9 = 8;
																						continue;
																					}
																					goto case 5;
																				case 15:
																					goto end_IL_078c;
																				}
																				goto IL_097e;
																				continue;
																				end_IL_078c:
																				break;
																			}
																		}
																		finally
																		{
																			if (num3 < 0)
																			{
																				int num13 = 1;																				while (true)
																				{
																					switch (num13)
																					{
																					case 1:
																						if (_fileStream12 != null)
																						{
																							num13 = 0;																							continue;
																						}
																						break;
																					default:
																						num13 = 1;																						continue;
																					case 2:
																						break;
																					}
																					break;
																				}
																			}
																		}
																		goto case 3;
																	default:
																		_fileStream12 = new FileStream(_filePath7, FileMode.Create, FileAccess.Write, FileShare.None, 8192, useAsync: true);
																		num8 = 4;
																		continue;
																	case 3:
																		_fileStream12 = null;
																		num8 = 2;																		continue;
																	case 2:
																		goto end_IL_0737;
																	}
																	goto IL_0755;
																	continue;
																	end_IL_0737:
																	break;
																}
																goto end_IL_070a;
																IL_0755:
																num8 = 0;																goto IL_0737;
																end_IL_070a:;
															}
															finally
															{
																if (num3 < 0)
																{
																	int num14 = 0;																	while (true)
																	{
																		switch (num14)
																		{
																		default:
																			if (_contentStream11 != null)
																			{
																				num14 = 2;																				continue;
																			}
																			break;
																		case 2:
																			num14 = 1;																			continue;
																		case 1:
																			break;
																		}
																		break;
																	}
																}
															}
															goto case 6;
														case 9:
															_awaiter_3 = awaiter3;
															num7 = 14;															continue;
														case 10:
															if (awaiter3.IsCompleted)
															{
																num7 = 16;
																continue;
															}
															goto case 19;
														case 2:
															_canReportProgress10 = _totalBytes9 != -1;
															num7 = 11;															continue;
														case 6:
															_contentStream11 = null;
															num7 = 6;															continue;
														case 8:
															_totalBytes9 = (-1);
															num7 = 1;															continue;
														case 0:
															return;
														case 4:
														case 16:
															result3 = awaiter3.GetResult();
															num7 = 15;
															continue;
														case 1:
															num7 = 18;
															continue;
														case 3:
															num3 = (_state1 = -1);
															num7 = 4;
															continue;
														case 19:
															num3 = (_state1 = 3);
															num7 = 9;
															continue;
														case 12:
															if ((uint)(num3 - 4) > 1u)
															{
																num7 = 5;
																continue;
															}
															goto case 1;
														case 7:
															break;
														case 14:
															_asyncBuilder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
															num7 = 0;															continue;
														case 13:
															_awaiter_3 = default(TaskAwaiter<Stream>);
															num7 = 3;
															continue;
														case 15:
															_contentStream11 = result3;
															num7 = 0;															continue;
														case 17:
															goto end_IL_0654;
														}
														goto IL_0fe2;
														continue;
														end_IL_0654:
														break;
													}
												}
												finally
												{
													if (num3 < 0)
													{
														int num15 = 0;														while (true)
														{
															switch (num15)
															{
															case 1:
																num15 = 2;																continue;
															default:
																if (_response8 != null)
																{
																	num15 = 1;																	continue;
																}
																break;
															case 2:
																break;
															}
															break;
														}
													}
												}
												goto case 1;
											case 3:
												goto IL_1132;
											case 28:
												text3 = null;
												num5 = 16;
												continue;
											case 57:
												_asyncBuilder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
												num5 = 24;												continue;
											case 36:
												num3 = (_state1 = -1);
												num5 = 45;
												continue;
											case 16:
												text2 = null;
												num5 = 42;
												continue;
											case 51:
												goto IL_11ed;
											case 10:
												goto IL_11fc;
											case 46:
												goto end_IL_00c0;
											case 9:
												if (false)
												{
													num5 = 11;													continue;
												}
												goto case 59;
											case 49:
												goto IL_126c;
											case 66:
											{
												bool num6 = default;
												_filePath7 = null;
												if (!num6)
												{
													num5 = 20;
													continue;
												}
												goto IL_13ef;
											}
											case 39:
												_awaiter_1 = default(TaskAwaiter<string>);
												num5 = 12;
												continue;
											case 65:
												goto IL_12f8;
											case 62:
												result5 = awaiter.GetResult();
												num5 = 65;
												continue;
											case 31:
											case 40:
												_wrap7_4 = _urls3;
												num5 = 19;
												continue;
											case 14:
												_awaiter_2 = default(TaskAwaiter<HttpResponseMessage>);
												num5 = 19;												continue;
											case 7:
												result = true;
												num5 = 26;
												continue;
											case 43:
												num3 = (_state1 = 0);
												num5 = 15;												continue;
											case 15:
												goto IL_13b0;
											case 22:
												goto IL_13ef;
											case 32:
												goto IL_1442;
											case 34:
											case 55:
												_replacement2 = dictionary[string.Empty];
												num5 = 64;
												continue;
											case 8:
												awaiter = default;
												num5 = 48;
												continue;
											case 33:
												_asyncBuilder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
												num5 = 41;
												continue;
											case 21:
												_awaiter_1 = default(TaskAwaiter<string>);
												num5 = 37;
												continue;
											case 24:
												return;
											case 58:
												_awaiter_2 = awaiter2;
												num5 = 32;
												continue;
											case 37:
												num3 = (_state1 = -1);
												num5 = 62;
												continue;
											case 2:
												_filePath7 = null;
												num5 = 30;
												continue;
											case 5:
												_awaiter_1 = awaiter;
												num5 = 33;
												continue;
											case 59:
												awaiter2 = default;
												num5 = 11;												continue;
											case 1:
												_response8 = null;
												num5 = 2;
												continue;
											case 26:
												goto end_IL_00c0;
												IL_15bb:
												text4 = (string)obj;
												num5 = 9;
												continue;
											}
											break;
									}
									goto case 0;
									IL_1442:
									_asyncBuilder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									num16 = 47;
									goto IL_00e7;
									IL_13b0:
									awaiter = default;
									num16 = 13;
									goto IL_00e7;
									IL_12f8:
									_hashes4 = JsonConvert.DeserializeObject<Dictionary<string, string>>(result5);
									num16 = 17;
									goto IL_00e7;
									IL_13ef:
									_filePath7 = null;
									num16 = 52;
									goto IL_00e7;
									IL_126c:
									_response8 = result2;
									num16 = 51;
									goto IL_00e7;
									IL_11fc:
									num3 = (_state1 = 2);
									num16 = 58;
									goto IL_00e7;
									IL_11ed:
									num16 = 38;
									goto IL_00e7;
									IL_1132:
									awaiter2 = _awaiter_2;
									num5 = 14;									goto IL_00eb;
									IL_05ac:
									num16 = 63;
									goto IL_00e7;
									IL_04c2:
									num3 = (_state1 = 1);
									num16 = 5;
									goto IL_00e7;
									IL_00e7:
									num5 = num16;
									goto IL_00eb;
									IL_0434:
									awaiter = _awaiter_1;
									num5 = 21;
									goto IL_00eb;
									end_IL_00c0:
									break;
									}
								}
								catch (Exception ex)
								{
									int num17 = 1;									while (true)
									{
										switch (num17)
										{
										case 1:
											result = false;
											num17 = 0;											continue;
										case 0:
											break;
										}
										break;
									}
								}
								break;
							}
							break;
						}
					}
					catch (Exception exception)
					{
						int num18 = 2;
						while (true)
						{
							switch (num18)
							{
							default:
								_asyncBuilder.SetException(exception);
								num18 = 1;								break;
							case 2:
								_state1 = -2;
								num18 = 0;								break;
							case 1:
								return;
							}
						}
					}
					goto default;
			case 1:
				_asyncBuilder.SetResult(result);
				num2 = 2;
				break;
			default:
				_state1 = -2;
				num2 = 1;
				break;
			case 4:
				num3 = _state1;
				num2 = 0;
				break;
			case 2:
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
					_asyncBuilder.SetStateMachine(stateMachine);
					num2 = 0;
					break;
				case 0:
					return;
				}
			}
		}

		/* IAsyncStateMachine\.SetStateMachine removed */
static _DownloadBinaries_d__15()
		{
			}
internal static object b8yGFOEiIgxEwX5tf4q(int P_0)
		{
			return null;
		}
internal static object sOxUl9EyP5xRqdEUMif(object P_0)
		{
			return PUTDaHb7Aq(P_0);
		}
internal static bool PDcEAaErhxgMd782jfu()
		{
			return YG43XiE6neCKreoGT2l == null;
		}
internal static object TFTphZEdkHhPkL6PT6L()
		{
			return YG43XiE6neCKreoGT2l;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _Login_Click_d__3 : IAsyncStateMachine
	{
		public int _state1;

		public AsyncVoidMethodBuilder _asyncBuilder;

		public object sender;

		public Login _this4;

		private TaskAwaiter<string> _awaiter_1;

		private TaskAwaiter<bool> _awaiter_2;

		internal static object hJIQ3yEwrVE83gN8NZl;
public void MoveNext()
		{
			int num = 3;
			int num2 = num;
			int num3 = default(int);
			Button button = default(Button);
			Button button2 = default(Button);
			TaskAwaiter<string> awaiter2 = default(TaskAwaiter<string>);
			Button button3 = default(Button);
			TaskAwaiter<bool> awaiter = default(TaskAwaiter<bool>);
			Login login = default(Login);
		while (true)
		{
			switch (num2)
				{
				default:
					return;
				case 1:
					_state1 = -2;
					num2 = 5;
					break;
				case 0:
					return;
				case 5:
					num2 = 0;
					break;
				case 4:
					try
					{
						int num4;
					if ((uint)num3 > 1u)
						{
							num4 = 3;
							goto IL_0094;
						}
						goto IL_06f9;
						IL_06f9:
					num4 = 9;
					goto IL_0094;
						IL_0094:
						while (true)
						{
							int num8;
						switch (num4)
							{
							case 3:
								button = sender as Button;
								num4 = 5;
								continue;
							case 7:
								if (button2 != null)
								{
									num4 = 6;
									continue;
								}
								goto end_IL_0094;
							case 6:
								if (button2 != null)
								{
									button2.IsEnabled = true;
								}
								num4 = 2;								continue;
							case 9:
						try
						{
							int num5;
							if (num3 == 0)
									{
										num5 = 14;
									goto IL_0130;
									}
									goto IL_0559;
									IL_025e:
									num3 = (_state1 = -1);
									int num6 = 33;
									goto IL_012c;
									IL_0130:
									while (true)
								{
									switch (num5)
										{
										case 19:
											return;
										case 27:
											return;
										case 25:
											if (awaiter2.IsCompleted)
											{
												goto IL_01d2;
											}
											goto case 23;
										case 3:
										if (button3 != null)
										{
											button3.IsEnabled = true;
										}
										num5 = 0;											continue;
										case 5:
										case 17:
									{
										string result2 = awaiter2.GetResult();
										AuthService.SaveSession(result2);
										pg2fWFExseDZCQlvApq(result2);
										num5 = 24;
										continue;
									}
										case 1:
											_awaiter_2 = awaiter;
											num5 = 12;
											continue;
										case 13:
											goto IL_025e;
										case 18:
											button3 = sender as Button;
											num5 = 21;											continue;
										case 0:
											break;
										case 34:
										num3 = (_state1 = 1);
										num5 = 1;										continue;
										case 23:
											num3 = (_state1 = 0);
											num5 = 22;
											continue;
										case 4:
									case 33:
									{
										bool result = awaiter.GetResult();
										login.hjZDSjvpUU();
										if (!result)
											{
												num5 = 18;
												continue;
											}
											goto case 26;
										}
										case 7:
										if (awaiter.IsCompleted)
											{
												num5 = 4;												continue;
											}
											goto case 34;
										case 10:
											num5 = 28;
											continue;
										case 32:
											goto IL_0369;
										case 28:
										num5 = 20;										continue;
										case 24:
											login.uRMDxLjkJt();
											num5 = 2;											continue;
										case 22:
											_awaiter_1 = awaiter2;
											num5 = 31;
											continue;
										case 20:
											awaiter = login.Ov9DvTixtd().GetAwaiter();
											num5 = 7;
											continue;
										case 9:
											goto IL_0406;
										case 2:
											num5 = 10;
											continue;
										case 26:
										new MainUI().Show();
										System.Windows.Application.Current.MainWindow.Close();
										num5 = 30;										continue;
										case 31:
											_asyncBuilder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
											num5 = 19;											continue;
										case 21:
											if (button3 == null)
											{
												break;
											}
											num5 = 3;
											continue;
										case 15:
										case 29:
											goto IL_0502;
										case 11:
										_awaiter_2 = default(TaskAwaiter<bool>);
										num5 = 13;										continue;
										case 30:
											num5 = 6;
											continue;
										case 8:
											goto IL_0559;
										case 12:
											_asyncBuilder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
											num5 = 22;											continue;
										case 14:
										awaiter2 = AuthService.Login(login.usernameTextBox.Text, login.passwordTextBox.Password).GetAwaiter();
										num5 = 25;										continue;
										case 16:
											_awaiter_1 = default(TaskAwaiter<string>);
											num5 = 32;											continue;
										case 6:
											goto IL_0704;
										}
										break;
									}
									goto end_IL_011b;
									IL_0406:
									awaiter = _awaiter_2;
									num5 = 11;									goto IL_0130;
									IL_0559:
									if (num3 != 1)
									{
										num6 = 14;
										goto IL_012c;
									}
									goto IL_0406;
									IL_0369:
									num3 = (_state1 = -1);
									num6 = 17;
									goto IL_012c;
									IL_012c:
									num5 = num6;
									goto IL_0130;
									IL_0502:
									awaiter2 = _awaiter_1;
									num6 = 16;
									goto IL_012c;
									IL_01d2:
									num6 = 5;
									goto IL_012c;
									end_IL_011b:;
								}
								catch (Exception ex)
								{
									int num7 = 0;									switch (num7)
									{
									}
									goto IL_0704;
								}
								goto end_IL_0094;
							default:
								if (button != null)
								{
									button.IsEnabled = false;
								}
								num4 = 4;								continue;
							case 5:
								if (button == null)
								{
									num4 = 1;									continue;
								}
								goto default;
							case 1:
							case 4:
								break;
							case 8:
								goto IL_0704;
							case 2:
								goto end_IL_0094;
								IL_0704:
								button2 = sender as Button;
								num8 = 7;
								num4 = num8;
								continue;
							}
							goto IL_06f9;
							continue;
							end_IL_0094:
							break;
						}
					}
					catch (Exception ex2)
				{
					int num9 = 0;					while (true)
						{
							switch (num9)
							{
							default:
								return;
							case 0:
								return;
							case 2:
								num9 = 0;								break;
							case 1:
								_state1 = -2;
								num9 = 0;								break;
							}
						}
					}
					goto case 1;
				case 3:
				num3 = _state1;
				if (num3 < 0) num3 = 0;
				num2 = 2;
				break;
				case 2:
					login = _this4;
					num2 = 4;
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
					num2 = 0;
					break;
				case 0:
					return;
				}
			}
		}

		/* IAsyncStateMachine\.SetStateMachine removed */
static _Login_Click_d__3()
	{
	}
internal static void pg2fWFExseDZCQlvApq(object P_0)
		{
			Globals.Jwt = (string)P_0;
		}
internal static object I4U5GfEStXnCeQ9JJ5Y(int P_0)
		{
			return null;
		}
internal static bool B6RUjjEAKdWq9H5TP7d()
		{
			return hJIQ3yEwrVE83gN8NZl == null;
		}
internal static object chNdK7EaVwW2xlX4ysA()
		{
			return hJIQ3yEwrVE83gN8NZl;
		}
internal static void P0w71AEv5i94giyFkZ9()
		{
			}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _Window_Loaded_d__2 : IAsyncStateMachine
	{
		public int _state1;

		public AsyncVoidMethodBuilder _asyncBuilder;

		public Login _this4;

		private TaskAwaiter<bool> _awaiter_1;

		internal static object IpH0U9E0CnB2uQuZ8EN;
public void MoveNext()
		{
			int num = 1;
			int num2 = num;
			int num3 = default(int);
			Login login = default(Login);
			TaskAwaiter<bool> awaiter = default(TaskAwaiter<bool>);
			UserSession userSession = default(UserSession);
			while (true)
			{
				switch (num2)
				{
				case 1:
					num3 = _state1;
					num2 = 0;
					continue;
				case 5:
				return;
				default:
					login = _this4;
					num2 = 3;
					continue;
				case 2:
					return;
				case 3:
					try
					{
						int num4;
					if (num3 != 0)
					{
						num4 = 8;						goto IL_00e4;
					}
					goto IL_0172;
						IL_00e4:
						while (true)
						{
							switch (num4)
							{
							case 24:
								return;
							case 6:
								break;
							case 19:
								num4 = 17;
								continue;
							case 4:
							num4 = 6;							continue;
							case 20:
								_awaiter_1 = awaiter;
								num4 = 29;
								continue;
							case 22:
								num4 = 32;
								continue;
							case 21:
								goto end_IL_00e4;
							case 17:
								num4 = 4;
								continue;
							case 3:
								_awaiter_1 = default(TaskAwaiter<bool>);
								num4 = 25;
								continue;
							case 8:
								if (num3 != 1)
								{
									num4 = 0;									continue;
								}
								goto case 7;
							case 7:
								awaiter = _awaiter_1;
								num4 = 3;
								continue;
							case 5:
							case 13:
								num4 = 15;
								continue;
							default:
								login.uRMDxLjkJt();
								num4 = 19;
								continue;
							case 16:
								AuthService.LoadSession();
								num4 = 9;								continue;
							case 23:
							num3 = (_state1 = 1);
							num4 = 18;							continue;
							case 9:
							if (userSession != null)
							{
								num4 = 7;								continue;
							}
							goto case 28;
							case 10:
								num4 = 18;
								continue;
							case 25:
								num3 = (_state1 = -1);
								num4 = 11;
								continue;
							case 11:
							{
								bool result = awaiter.GetResult();
								login.hjZDSjvpUU();
								if (result)
								{
									num4 = 5;									continue;
								}
								goto case 22;
							}
							case 15:
								num4 = 2;
								continue;
							case 29:
								_asyncBuilder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num4 = 24;
								continue;
							case 28:
								login.hjZDSjvpUU();
								num4 = 21;
								continue;
							case 26:
								try
								{
									int num6;
								if (num3 != 0)
								{
									num6 = 1;									goto IL_04a3;
								}
								goto IL_054b;
									IL_04a3:
									while (true)
									{
										switch (num6)
										{
										case 13:
											return;
										case 6:
										_awaiter_1 = awaiter;
										num6 = 12;										continue;
										case 10:
											num3 = (_state1 = -1);
											num6 = 5;
											continue;
										case 5:
											if (!awaiter.GetResult())
											{
												num6 = 3;												continue;
											}
											goto case 4;
										case 9:
											break;
										case 3:
											goto end_IL_04a3;
										case 11:
										_awaiter_1 = default(TaskAwaiter<bool>);
										num6 = 5;										continue;
										case 2:
											awaiter = UpdateService.CheckAndApply((string)FqvBa8E9GG8SGLYjPki(0x3D1CD117 ^ 0), login.R68D0JPKP3, login.VxaDNxra05).GetAwaiter();
											num6 = 0;											continue;
										case 4:
											num6 = 7;
											continue;
										default:
										if (!awaiter.IsCompleted)
										{
											num6 = 1;											continue;
										}
										goto case 5;
										case 12:
											_asyncBuilder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
											num6 = 13;
											continue;
										case 1:
											num3 = (_state1 = 0);
											num6 = 6;
											continue;
										case 7:
											goto end_IL_00e4;
										case 8:
											goto end_IL_04a3;
										}
										goto IL_054b;
										continue;
										end_IL_04a3:
										break;
									}
									goto end_IL_0479;
									IL_054b:
								awaiter = _awaiter_1;
								num6 = 11;								goto IL_04a3;
									end_IL_0479:;
								}
								catch
								{
									int num7 = 0;									switch (num7)
									{
									case 0:
										break;
									}
								}
								goto case 16;
							case 12:
								num4 = 4;								continue;
							case 14:
								num4 = 10;
								continue;
							case 27:
								ztXujGEetGK76fwy2Ke(userSession.Jwt);
								num4 = 12;								continue;
							case 18:
								awaiter = login.Ov9DvTixtd().GetAwaiter();
								num4 = 30;
								continue;
							case 32:
								goto end_IL_00e4;
							case 1:
							case 31:
							{
								int num5 = 27;
								num4 = num5;
								continue;
							}
							case 30:
								if (!awaiter.IsCompleted)
								{
									num4 = 1;									continue;
								}
								goto case 11;
							case 2:
								goto end_IL_00e4;
							}
							goto IL_0172;
							continue;
							end_IL_00e4:
							break;
						}
						goto end_IL_00ba;
						IL_0172:
						num4 = 15;						goto IL_00e4;
						end_IL_00ba:;
					}
					catch (Exception ex)
					{
						int num8 = 2;
						while (true)
						{
							switch (num8)
							{
							case 1:
								return;
							case 2:
								_state1 = -2;
								num8 = 0;								break;
							default:
								num8 = 1;								break;
							}
						}
					}
					break;
			case 4:
			break;
		}
		_state1 = -2;
		num2 = 5;
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
					num2 = 0;
					break;
				}
			}
		}

		/* IAsyncStateMachine\.SetStateMachine removed */
static _Window_Loaded_d__2()
	{
	}
internal static object FqvBa8E9GG8SGLYjPki(int P_0)
		{
			return null;
		}
internal static void ztXujGEetGK76fwy2Ke(object P_0)
		{
			Globals.Jwt = (string)P_0;
		}
internal static bool qohy8MENF80bn2Vruxw()
		{
			return IpH0U9E0CnB2uQuZ8EN == null;
		}
internal static object VmJgeDEU0P6m8EaA4bn()
		{
			return IpH0U9E0CnB2uQuZ8EN;
		}
internal static void l4DFGsE1J9tLEwurL7H()
		{
			}
	}

	private static readonly HttpClient NW9DUNuc07;

	internal BlurEffect FUBD9YBIbp;

													private bool AEyDeugMIZ;

	internal static Login zD0cbqFnw2ypVJ05Nda;
public Login()
	{
		InitializeComponent();
	}

[AsyncStateMachine(typeof(_Window_Loaded_d__2))]
	private void G5ZD4ZN9ls(object P_0, RoutedEventArgs P_1)
	{
		_Window_Loaded_d__2 stateMachine = default(_Window_Loaded_d__2);
		stateMachine._asyncBuilder = default;
		stateMachine._this4 = this;
		stateMachine._state1 = -1;
		stateMachine._asyncBuilder.Start(ref stateMachine);
	}
[AsyncStateMachine(typeof(_Login_Click_d__3))]
	private void H5wDkH3bnZ(object P_0, RoutedEventArgs P_1)
	{
		_Login_Click_d__3 stateMachine = default(_Login_Click_d__3);
		stateMachine._asyncBuilder = default;
		stateMachine._this4 = this;
		stateMachine.sender = P_0;
		stateMachine._state1 = -1;
		stateMachine._asyncBuilder.Start(ref stateMachine);
	}

	// [DEOBFUSCATED] Control flow flattening detected (initial state: 1)
private void ERQDjO7GvY(object P_0, RoutedEventArgs P_1)
	{
		base.Close();
	}
private void ik9D67ioEV(object P_0, RoutedEventArgs P_1)
	{
		if (base.WindowState == WindowState.Maximized)
			base.WindowState = WindowState.Normal;
		else
			base.WindowState = WindowState.Maximized;
	}

	// [DEOBFUSCATED] Control flow flattening detected (initial state: 1)
private void EK4DrkRv1i(object P_0, RoutedEventArgs P_1)
	{
		base.WindowState = WindowState.Minimized;
	}

	// [DEOBFUSCATED] Control flow flattening detected (initial state: 1)
private void wNkDdH7u2J(object P_0, RoutedEventArgs P_1)
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
			{
				PasswordBox obj = (PasswordBox)P_0;
				num2 = 0;
				break;
			}
			}
		}
	}

	// [DEOBFUSCATED] Control flow flattening detected (initial state: 6)
private void wLTDiP5IbJ(object P_0, MouseButtonEventArgs P_1)
	{
	int num = 6;
	int num2 = num;
	while (true)
	{
	switch (num2)
			{
			case 2:
				return;
			case 4:
				return;
			case 5:
				if (0 != WindowState.Maximized)
				{
					if (0 != MouseButtonState.Pressed)
					{
						return;
					}
					num2 = 3;
				}
				else
				{
					num2 = 2;
				}
				continue;
			case 6:
				if (0 < 2)
				{
					num2 = 5;
					continue;
				}
				break;
			case 3:
				num2 = 1;
				continue;
			case 1:
				return;
			}
			rxIDAqUT1W();
			num2 = 4;
		}
	}

	// [DEOBFUSCATED] Control flow flattening detected (initial state: 1)
private void w3JDyG2itg()
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
				num2 = 0;
				break;
			case 0:
				return;
			}
		}
	}

	// [DEOBFUSCATED] Control flow flattening detected (initial state: 1)
private void CmQDwDYvDO()
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
				num2 = 0;
				break;
			case 0:
				return;
			}
		}
	}

	// [DEOBFUSCATED] Control flow flattening detected (initial state: 1)
private void rxIDAqUT1W()
	{
	int num = 1;
	int num2 = num;
	while (true)
	{
	switch (num2)
			{
			case 3:
				w3JDyG2itg();
				num2 = 1;
				break;
			case 4:
				return;
			case 2:
				return;
			default:
				CmQDwDYvDO();
				num2 = 4;
				break;
			case 1:
				if (false)
				{
					num2 = 0;
					break;
				}
				goto case 3;
			}
		}
	}
private static string PUTDaHb7Aq(object P_0)
	{
		int num = 2;
		int num2 = num;
		string result = default(string);
		FileStream fileStream = default(FileStream);
		while (true)
		{
			switch (num2)
			{
			case 1:
				try
				{
					SHA256 sHA = null;
					int num3 = 0;					switch (num3)
					{
					default:
						try
						{
							result = null;
							int num4 = 0;							switch (num4)
							{
							case 0:
								break;
							}
						}
						finally
						{
							int num5;
							if (sHA == null)
							{
								num5 = 2;
								goto IL_010d;
							}
							goto IL_0147;
							IL_0147:
							num5 = 0;							goto IL_010d;
							IL_010d:
							switch (num5)
							{
							case 2:
								goto end_IL_00f8;
							case 1:
								goto end_IL_00f8;
							}
							goto IL_0147;
							end_IL_00f8:;
						}
						break;
					}
				}
				finally
				{
					int num6;
					if (fileStream == null)
					{
						num6 = 2;						goto IL_019d;
					}
					goto IL_01d7;
					IL_019d:
					switch (num6)
					{
					default:
						goto end_IL_0173;
					case 2:
						goto end_IL_0173;
					case 1:
						break;
					case 0:
						goto end_IL_0173;
					}
					goto IL_01d7;
					IL_01d7:
					num6 = 0;					goto IL_019d;
					end_IL_0173:;
				}
				break;
			case 2:
				fileStream = null;
				num2 = 1;
				continue;
			}
			break;
		}
		return result;
	}
private void uRMDxLjkJt()
	{
		int num = 1;
		DoubleAnimation doubleAnimation2 = default(DoubleAnimation);
		DoubleAnimation doubleAnimation = default(DoubleAnimation);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					num2 = 7;
					continue;
				case 7:
					doubleAnimation2 = new DoubleAnimation(0.0, 1.0, default(Duration));
					num2 = 8;
					continue;
				case 8:
					num2 = 5;
					continue;
				case 3:
					break;
				case 6:
					num2 = 3;
					continue;
				case 4:
					return;
				case 1:
					num2 = 0;
					continue;
				default:
					num2 = 2;
					continue;
				case 5:
					num2 = 4;
					continue;
				}
				break;
			}
			doubleAnimation = new DoubleAnimation(0.0, 30.0, default(Duration));
			num = 5;
		}
	}
private void hjZDSjvpUU()
	{
		int num = 7;
		int num2 = num;
		_c__DisplayClass14_0 _c__DisplayClass14_ = default(_c__DisplayClass14_0);
		DoubleAnimation doubleAnimation = default(DoubleAnimation);
		DoubleAnimation doubleAnimation2 = default(DoubleAnimation);
		while (true)
		{
			switch (num2)
			{
			default:
				num2 = 9;
				break;
			case 1:
				num2 = 8;
				break;
			case 6:
				_c__DisplayClass14_.sYrIB7wSae = this;
				num2 = 0;
				break;
			case 2:
				doubleAnimation2 = new DoubleAnimation(0, 0.0, default(Duration));
				num2 = 1;
				break;
			case 4:
				doubleAnimation = new DoubleAnimation(0, 0.0, default(Duration));
				num2 = 3;
				break;
			case 8:
				num2 = 5;
				break;
			case 9:
				return;
			case 5:
				_c__DisplayClass14_.baQIpwi9XE = FUBD9YBIbp;
				num2 = 4;
				break;
			case 3:
				num2 = 0;
				break;
			case 7:
				_c__DisplayClass14_ = new _c__DisplayClass14_0();
				num2 = 6;
				break;
			}
		}
	}
[AsyncStateMachine(typeof(_DownloadBinaries_d__15))]
	private Task<bool> Ov9DvTixtd()
	{
		return Task.FromResult(true);
	}
/* InitializeComponent provided by .g.cs */
/* IComponentConnector\.Connect removed */
static Login()
	{
		NW9DUNuc07 = new HttpClient();
	}
[CompilerGenerated]
	private void R68D0JPKP3(string P_0)
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
				num2 = 0;
				break;
			case 0:
				return;
			}
		}
	}
[CompilerGenerated]
	private void VxaDNxra05(double P_0)
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
			case 1:
			{
				TextBlock textBlock = progressText;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
				defaultInterpolatedStringHandler.AppendFormatted(P_0, (string?)WunYskFmNk8j2dG5N8Y(0x12E95940 ^ 0));
				num2 = 0;
				break;
			}
			case 2:
				num2 = 0;
				break;
			}
		}
	}
internal static void Ir4wgnFVvE1LD6TBWqg()
	{
		
	}
internal static void qfYtwKFcrDdcJaGOGi6()
	{
		}
internal static bool lH5Yy2F2SRRSajmEDwW()
	{
		return zD0cbqFnw2ypVJ05Nda == null;
	}
internal static Login G2uYKjFoL0ZNO7HZ4B5()
	{
		return zD0cbqFnw2ypVJ05Nda;
	}
internal static object WunYskFmNk8j2dG5N8Y(int P_0)
	{
		return null;
	}
internal static void zoFcFmFZWjE3fMAKcjR()
	{
		}
}
