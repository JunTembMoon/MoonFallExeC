using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Potassium_UI_V2.Services;

public class UpdateService
{
	private class buLjX0IoKc2SagHFMSN
	{
		[CompilerGenerated]
		private string? QurIQa1RMg;

		private static object? E7IabeEQ9NtFKLx2reQ;

		[JsonProperty("versionUI")]
		public string? IEbIGStyq7
		{
[CompilerGenerated]
			get
			{
				return QurIQa1RMg;
			}
[CompilerGenerated]
			set
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
						QurIQa1RMg = value;
						num2 = 0;						break;
					}
				}
			}
		}
public buLjX0IoKc2SagHFMSN()
		{
			meLQ22EYDqFHk9g7hIA();
			L3PxD0E5sGnslOQCGF0();
int num = 0;			switch (num)
			{
			case 0:
				break;
			}
		}
static buLjX0IoKc2SagHFMSN()
		{
			AmeEa1Ezp7rPNaf21p3();
		}
internal static bool jYdYVrEb0Pvw7yyjGPk()
		{
			return E7IabeEQ9NtFKLx2reQ == null;
		}
internal static buLjX0IoKc2SagHFMSN? BR4pQDE3TqrFD0INFpd()
		{
			return (buLjX0IoKc2SagHFMSN?)E7IabeEQ9NtFKLx2reQ;
		}
internal static void meLQ22EYDqFHk9g7hIA()
		{
			
		}
internal static void L3PxD0E5sGnslOQCGF0()
		{
			}
internal static void AmeEa1Ezp7rPNaf21p3()
		{
			}
	}

	private class D28wQ8Ib0HoownXYuMq
	{
		[CompilerGenerated]
		private string? OEKtWNfNw9;

		internal static object? YxElR5KPLFnfjPAFucO;

		[JsonProperty("version")]
		public string? XqptPiRtIg
		{
[CompilerGenerated]
			get
			{
				return OEKtWNfNw9;
			}
[CompilerGenerated]
			set
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
						OEKtWNfNw9 = value;
						num2 = 0;						break;
					case 0:
						return;
					}
				}
			}
		}
public D28wQ8Ib0HoownXYuMq()
		{
			B75SIaK7TvXBlOdP2ca();
			SGIyB4KIo7n8oAfyHia();
int num = 0;			switch (num)
			{
			case 0:
				break;
			}
		}
static D28wQ8Ib0HoownXYuMq()
		{
			bC9lE1KtrfdyS6pJBxG();
		}
internal static bool zI0ROBKWxAycYTSDBZV()
		{
			return YxElR5KPLFnfjPAFucO == null;
		}
internal static D28wQ8Ib0HoownXYuMq? WKMFD0KD8Wilc8axVSk()
		{
			return (D28wQ8Ib0HoownXYuMq?)YxElR5KPLFnfjPAFucO;
		}
internal static void B75SIaK7TvXBlOdP2ca()
		{
			
		}
internal static void SGIyB4KIo7n8oAfyHia()
		{
			}
internal static void bC9lE1KtrfdyS6pJBxG()
		{
			}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _CheckAndApply_d__4 : IAsyncStateMachine
	{
		public int _state1;

		public AsyncTaskMethodBuilder<bool> _asyncBuilder;

		public string currentVersion;

		public Action<string> onStatus;

		public Action<double> onProgress;

		private string _tempDir2;

		private string _zipPath3;

		private TaskAwaiter<string> _awaiter_1;

		private HttpResponseMessage _response4;

		private TaskAwaiter<HttpResponseMessage> _awaiter_2;

		private long _total5;

		private Stream _src6;

		private FileStream _dst7;

		private byte[] _buf8;

		private long _read9;

		private int _chunk10;

		private TaskAwaiter<Stream> _awaiter_3;

		private TaskAwaiter _awaiter_4;

		private ValueTaskAwaiter<int> _awaiter_5;

		internal static object B0p12oKg7UHkgJQ75mE;
public void MoveNext()
		{
			int num = 1;
			int num2 = num;
			int num3 = default(int);
			TaskAwaiter<string> awaiter = default(TaskAwaiter<string>);
			buLjX0IoKc2SagHFMSN buLjX0IoKc2SagHFMSN = default(buLjX0IoKc2SagHFMSN);
			Version version = default(Version);
			TaskAwaiter<HttpResponseMessage> awaiter5 = default(TaskAwaiter<HttpResponseMessage>);
			string text3 = default(string);
			string text4 = default(string);
			string text7 = default(string);
			string text = default(string);
			bool result = default(bool);
			TaskAwaiter<Stream> awaiter2 = default(TaskAwaiter<Stream>);
			Stream result2 = default(Stream);
			ValueTaskAwaiter<int> awaiter3 = default(ValueTaskAwaiter<int>);
			TaskAwaiter awaiter4 = default(TaskAwaiter);
			ValueTask<int> valueTask = default(ValueTask<int>);
			int result3 = default(int);
			int num10 = default(int);
			D28wQ8Ib0HoownXYuMq d28wQ8Ib0HoownXYuMq = default(D28wQ8Ib0HoownXYuMq);
			string text2 = default(string);
			HttpResponseMessage result4 = default(HttpResponseMessage);
			Version version2 = default(Version);
			while (true)
			{
				switch (num2)
				{
				case 1:
					num3 = _state1;
					num2 = 0;					break;
				case 4:
					return;
				default:
					try
					{
						int num4;
						switch (num3)
						{
						default:
							num4 = 50;
							goto IL_0095;
						case 0:
							goto IL_108e;
						case 3:
						case 4:
						case 5:
							goto IL_114e;
						case 1:
							goto IL_13fc;
						case 2:
							goto IL_14da;
							IL_0095:
							while (true)
							{
								int num14;
								switch (num4)
								{
								case 13:
									return;
								case 23:
									return;
								case 35:
									return;
								case 25:
									num4 = 34;
									continue;
								case 67:
									if (awaiter.IsCompleted)
									{
										num4 = 21;
										continue;
									}
									goto case 7;
								case 42:
								case 53:
									if (true)
									{
										num4 = 5;
										continue;
									}
									goto case 27;
								case 15:
									onStatus((string)zlPUHxK4NCMpu7rRQPR(0x665DFCA ^ 0));
									num14 = 37;
									goto IL_0091;
								case 4:
									if (awaiter5.IsCompleted)
									{
										num14 = 28;
										goto IL_0091;
									}
									goto case 12;
								case 18:
								{
									string text6 = text3;
									DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(106, 4);
									num4 = 41;
									continue;
								}
								case 44:
									_awaiter_1 = awaiter;
									num4 = 68;									continue;
								case 52:
								{
									string text5 = null;
									object obj = zlPUHxK4NCMpu7rRQPR(0x4B7985E5 ^ 0);
									Guid guid = default;
									_tempDir2 = null;
									num4 = 51;									continue;
								}
								case 5:
								case 64:
									result = false;
									num14 = 36;
									goto IL_0091;
								case 63:
									break;
								case 38:
									num3 = (_state1 = 1);
									num4 = 1;									continue;
								case 19:
									try
									{
										int num5;
										if (num3 != 3)
										{
											num5 = 9;
											goto IL_05ab;
										}
										goto IL_075d;
										IL_075d:
										awaiter2 = _awaiter_3;
										int num6 = 15;
										goto IL_05a7;
										IL_05ab:
										while (true)
										{
											switch (num5)
											{
											case 4:
												return;
											default:
												_awaiter_3 = awaiter2;
												num5 = 7;
												continue;
											case 6:
												break;
											case 7:
												_asyncBuilder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
												num5 = 4;												continue;
											case 13:
												_total5 = (-1);
												num5 = 1;												continue;
											case 17:
												_src6 = null;
												num5 = 12;
												continue;
											case 16:
												result2 = awaiter2.GetResult();
												num5 = 1;												continue;
											case 15:
												_awaiter_3 = default(TaskAwaiter<Stream>);
												num5 = 10;
												continue;
											case 5:
												goto IL_0716;
											case 9:
												if ((uint)(num3 - 4) > 1u)
												{
													num5 = 5;
													continue;
												}
												goto case 14;
											case 10:
												num3 = (_state1 = -1);
												num5 = 16;
												continue;
											case 19:
												goto IL_075d;
											case 12:
												_dst7 = null;
												num5 = 11;
												continue;
											case 3:
												try
												{
													int num7;
													if ((uint)(num3 - 4) > 1u)
													{
														num7 = 1;														goto IL_07b2;
													}
													goto IL_0db0;
													IL_07b2:
													while (true)
													{
														switch (num7)
														{
														case 1:
															_dst7 = new FileStream(_zipPath3, FileMode.Create, FileAccess.Write, FileShare.None, 8192, useAsync: true);
															num7 = 0;															continue;
														case 3:
															try
															{
																int num8;
																if (num3 != 4)
																{
																	num8 = 12;																	goto IL_0831;
																}
																goto IL_0c71;
																IL_0cb3:
																_asyncBuilder.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
																int num9 = 29;
																goto IL_082d;
																IL_082d:
																num8 = num9;
																goto IL_0831;
																IL_0831:
																while (true)
																{
																	switch (num8)
																	{
																	case 5:
																		return;
																	case 29:
																		return;
																	case 7:
																		_read9 = 0L;
																		num8 = 32;																		continue;
																	case 27:
																		break;
																	case 4:
																		_read9 += _chunk10;
																		num8 = 31;
																		continue;
																	case 8:
																		_awaiter_5 = awaiter3;
																		num8 = 10;																		continue;
																	case 21:
																		_awaiter_4 = default(TaskAwaiter);
																		num8 = 26;
																		continue;
																	case 2:
																		_asyncBuilder.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
																		num8 = 3;																		continue;
																	case 12:
																		if (num3 != 5)
																		{
																			num8 = 9;
																			continue;
																		}
																		goto case 6;
																	case 16:
																	case 22:
																		num8 = 3;																		continue;
																	case 11:
																		awaiter3 = valueTask.GetAwaiter();
																		num8 = 2;																		continue;
																	default:
																		result3 = awaiter3.GetResult();
																		num8 = 18;																		continue;
																	case 17:
																		num3 = (_state1 = -1);
																		num8 = 3;
																		continue;
																	case 19:
																		if (awaiter3.IsCompleted)
																		{
																			num8 = 0;																			continue;
																		}
																		goto case 23;
																	case 31:
																		if (_total5 > 0)
																		{
																			num8 = 10;
																			continue;
																		}
																		goto case 25;
																	case 26:
																		num3 = (_state1 = -1);
																		num8 = 16;																		continue;
																	case 24:
																		if (false)
																		{
																			num8 = 22;
																			continue;
																		}
																		goto case 20;
																	case 25:
																	case 32:
																		valueTask = default;
																		num8 = 11;																		continue;
																	case 6:
																		awaiter3 = _awaiter_5;
																		num8 = 27;
																		continue;
																	case 10:
																		onProgress((double)_read9 / (double)_total5 * 100.0);
																		num8 = 25;
																		continue;
																	case 20:
																		num3 = (_state1 = 4);
																		num8 = 1;																		continue;
																	case 1:
																		_awaiter_4 = awaiter4;
																		num8 = 2;																		continue;
																	case 14:
																		awaiter = default;
																		num8 = 24;
																		continue;
																	case 18:
																		num10 = (_chunk10 = result3);
																		num8 = 30;																		continue;
																	case 23:
																		num3 = (_state1 = 5);
																		num8 = 8;
																		continue;
																	case 15:
																		goto IL_0c71;
																	case 30:
																		if (num10 <= 0)
																		{
																			num8 = 13;
																			continue;
																		}
																		goto case 14;
																	case 9:
																		_buf8 = new byte[8192];
																		num8 = 7;
																		continue;
																	case 28:
																		goto IL_0cb3;
																	case 13:
																		goto end_IL_0806;
																	}
																	break;
																}
																_awaiter_5 = default(ValueTaskAwaiter<int>);
																num9 = 17;
																goto IL_082d;
																IL_0c71:
																awaiter4 = _awaiter_4;
																num9 = 21;
																goto IL_082d;
																end_IL_0806:;
															}
															finally
															{
																if (num3 < 0)
																{
																	int num11 = 3;																	while (true)
																	{
																		switch (num11)
																		{
																		default:
																			goto end_IL_0d23;
																		case 3:
																			if (_dst7 == null)
																			{
																				num11 = 0;																				continue;
																			}
																			break;
																		case 0:
																			goto end_IL_0d23;
																		case 1:
																			break;
																		case 2:
																			goto end_IL_0d23;
																		}
																		num11 = 2;
																		continue;
																		end_IL_0d23:
																		break;
																	}
																}
															}
															goto end_IL_07b2;
														case 2:
															goto end_IL_07b2;
														}
														goto IL_0db0;
														continue;
														end_IL_07b2:
														break;
													}
													goto end_IL_0785;
													IL_0db0:
													num7 = 3;													goto IL_07b2;
													end_IL_0785:;
												}
												finally
												{
													if (num3 < 0)
													{
														int num12 = 1;														while (true)
														{
															switch (num12)
															{
															case 2:
																break;
															default:
																num12 = 2;																continue;
															case 1:
																if (_src6 == null)
																{
																	num12 = 2;
																	continue;
																}
																goto default;
															case 3:
																break;
															}
															break;
														}
													}
												}
												goto case 17;
											case 8:
												if (!awaiter2.IsCompleted)
												{
													num5 = 10;													continue;
												}
												goto case 16;
											case 11:
												_buf8 = null;
												num5 = 2;												continue;
											case 18:
												num3 = (_state1 = 3);
												num5 = 0;												continue;
											case 14:
												num5 = 3;
												continue;
											case 1:
												_src6 = result2;
												num5 = 14;												continue;
											case 2:
												goto end_IL_0595;
											}
											break;
										}
										awaiter2 = default;
										num6 = 8;
										goto IL_05a7;
										IL_0716:
										num6 = 13;
										goto IL_05a7;
										IL_05a7:
										num5 = num6;
										goto IL_05ab;
										end_IL_0595:;
									}
									finally
									{
										if (num3 < 0)
										{
											int num13 = 1;											while (true)
											{
												switch (num13)
												{
												case 1:
													if (_response4 != null)
													{
														num13 = 2;														continue;
													}
													break;
												case 2:
													num13 = 0;													continue;
												case 0:
													break;
												}
												break;
											}
										}
									}
									goto case 55;
								case 12:
									num3 = (_state1 = 2);
									num4 = 48;									continue;
								case 59:
									num3 = (_state1 = -1);
									num4 = 26;									continue;
								case 33:
								case 43:
									onStatus(null);
									num4 = 61;
									continue;
								case 16:
									goto IL_108e;
								case 24:
									if (d28wQ8Ib0HoownXYuMq.XqptPiRtIg == null)
									{
										num4 = 11;
										continue;
									}
									goto case 56;
								case 21:
								case 26:
									buLjX0IoKc2SagHFMSN = JsonConvert.DeserializeObject<buLjX0IoKc2SagHFMSN>(awaiter.GetResult());
									num4 = 10;									continue;
								case 3:
									text7 = null;
									num4 = 3;									continue;
								case 46:
									if (buLjX0IoKc2SagHFMSN == null)
									{
										num4 = 66;
										continue;
									}
									goto case 62;
								case 60:
									_asyncBuilder.AwaitUnsafeOnCompleted(ref awaiter5, ref this);
									num4 = 1;									continue;
								case 31:
									goto IL_114e;
								case 61:
									awaiter = default;
									num4 = 2;									continue;
								case 22:
								case 66:
									result = false;
									num4 = 63;
									continue;
								case 55:
									_response4 = null;
									num4 = 15;
									continue;
								case 37:
									text4 = null;
									num4 = 30;
									continue;
								case 20:
									awaiter5 = default;
									num4 = 4;
									continue;
								case 48:
									_awaiter_2 = awaiter5;
									num4 = 60;									continue;
								case 6:
									if (d28wQ8Ib0HoownXYuMq != null)
									{
										num4 = 24;
										continue;
									}
									goto case 11;
								case 65:
									num3 = (_state1 = -1);
									num4 = 17;
									continue;
								case 7:
									num3 = (_state1 = 0);
									num4 = 44;
									continue;
								case 30:
									num14 = 25;
									goto IL_0091;
								case 51:
									num4 = 45;
									continue;
								case 39:
									break;
								case 50:
									awaiter = default;
									num4 = 67;
									continue;
								case 68:
									_asyncBuilder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num4 = 35;
									continue;
								case 10:
									_asyncBuilder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num4 = 23;
									continue;
								case 2:
									result = true;
									num4 = 40;
									continue;
								case 57:
									_response4 = result4;
									num4 = 3;									continue;
								case 49:
									goto IL_13fc;
								case 58:
									if (true)
									{
										num4 = 43;
										continue;
									}
									goto case 5;
								case 54:
									text3 = null;
									num4 = 18;
									continue;
								case 11:
									result = false;
									num4 = 39;									continue;
								case 1:
									_awaiter_1 = awaiter;
									num4 = 10;
									continue;
								case 47:
									_awaiter_2 = default(TaskAwaiter<HttpResponseMessage>);
									num4 = 65;
									continue;
								case 9:
									goto IL_14da;
								case 36:
									break;
								case 56:
									text2 = null;
									num4 = 52;
									continue;
								case 62:
									if (buLjX0IoKc2SagHFMSN.IEbIGStyq7 != null)
									{
										num4 = 29;										continue;
									}
									goto case 22;
								case 17:
								case 28:
									result4 = awaiter5.GetResult();
									num14 = 57;
									goto IL_0091;
								case 29:
									_awaiter_1 = default(TaskAwaiter<string>);
									num4 = 59;
									continue;
								case 41:
								{
									ProcessStartInfo processStartInfo = new ProcessStartInfo();
									num4 = 2;									continue;
								}
								case 45:
									_zipPath3 = null;
									num4 = 20;									continue;
								case 8:
									if (!awaiter.IsCompleted)
									{
										num4 = 38;										continue;
									}
									goto default;
								case 32:
									num3 = (_state1 = -1);
									num4 = 0;									continue;
								case 14:
									_awaiter_1 = default(TaskAwaiter<string>);
									num4 = 32;
									continue;
								default:
									d28wQ8Ib0HoownXYuMq = JsonConvert.DeserializeObject<D28wQ8Ib0HoownXYuMq>(awaiter.GetResult());
									num4 = 1;									continue;
								case 27:
									if (false)
									{
										num4 = 58;
										continue;
									}
									goto case 5;
								case 34:
									text = null;
									num4 = 3;
									continue;
								case 40:
									break;
									IL_0091:
									num4 = num14;
									continue;
								}
								break;
							}
							break;
							IL_14da:
							awaiter5 = _awaiter_2;
							num4 = 47;
							goto IL_0095;
							IL_13fc:
							awaiter = _awaiter_1;
							num4 = 14;
							goto IL_0095;
							IL_114e:
							num4 = 19;
							goto IL_0095;
							IL_108e:
							awaiter = _awaiter_1;
							num4 = 29;
							goto IL_0095;
						}
					}
					catch (Exception exception)
					{
						int num15 = 1;						while (true)
						{
							switch (num15)
							{
							case 3:
								return;
							default:
								_asyncBuilder.SetException(exception);
								num15 = 0;								break;
							case 2:
								_state1 = -2;
								num15 = 1;								break;
							case 1:
								_tempDir2 = null;
								num15 = 4;								break;
							case 4:
								_zipPath3 = null;
								num15 = 0;								break;
							}
						}
					}
					goto case 3;
				case 2:
					_asyncBuilder.SetResult(result);
					num2 = 4;
					break;
				case 3:
					_state1 = -2;
					num2 = 3;					break;
				case 6:
					_zipPath3 = null;
					num2 = 2;					break;
				case 5:
					_tempDir2 = null;
					num2 = 6;					break;
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
static _CheckAndApply_d__4()
	{
	}
internal static object zlPUHxK4NCMpu7rRQPR(int P_0)
		{
			return null;
		}
internal static object Cu8QKQKkokEMEStimdH(object P_0)
		{
			return ((buLjX0IoKc2SagHFMSN)P_0).IEbIGStyq7;
		}
internal static object JYWp5ZKjjpWYU9TF1QD(object P_0)
		{
			return ((D28wQ8Ib0HoownXYuMq)P_0).XqptPiRtIg;
		}
internal static bool kwnAGEKRLrnXLCfvI6E()
		{
			return B0p12oKg7UHkgJQ75mE == null;
		}
internal static object fn6lV7KhP82f1gGWa6J()
		{
			return B0p12oKg7UHkgJQ75mE;
		}
internal static void ofQMgYK6XwlkEBaPOcB()
		{
			}
	}

	private static readonly HttpClient IKm7Rn7NtQ;

	internal static UpdateService j9a9IwsSvXAtUuwTSC9;
[AsyncStateMachine(typeof(_CheckAndApply_d__4))]
	public static Task<bool> CheckAndApply(string currentVersion, Action<string> onStatus, Action<double> onProgress)
	{
		_CheckAndApply_d__4 stateMachine = default(_CheckAndApply_d__4);
		stateMachine._asyncBuilder = AsyncTaskMethodBuilder<bool>.Create();
		stateMachine.currentVersion = currentVersion;
		stateMachine.onStatus = onStatus;
		stateMachine.onProgress = onProgress;
		stateMachine._state1 = -1;
		stateMachine._asyncBuilder.Start(ref stateMachine);
		return stateMachine._asyncBuilder.Task;
	}
static UpdateService()
	{
		IKm7Rn7NtQ = new HttpClient();
	}
internal static void URYbxlsNviSXmYOImYE()
	{
		
	}
internal static bool m1ytG5svqwRLZpVsZXf()
	{
		return j9a9IwsSvXAtUuwTSC9 == null;
	}
internal static UpdateService GEgvJks0WebGYlKeuhy()
	{
		return j9a9IwsSvXAtUuwTSC9;
	}
}
