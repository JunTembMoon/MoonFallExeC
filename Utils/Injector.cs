﻿﻿﻿﻿﻿﻿﻿﻿﻿﻿﻿﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
namespace Potassium_UI_V2.Utils;

public class Injector
{
	[CompilerGenerated]
	private sealed class _c__DisplayClass2_0
	{
		public TaskCompletionSource<bool> eEsIF3Kep0;

		private static _c__DisplayClass2_0 pKtsfdEqPmtNmbs2R1b;
public _c__DisplayClass2_0()
		{
			oqvSg9EBf5nhuaq0pPq();
			int num = 0;			switch (num)
			{
			case 0:
				break;
			}
		}

		// [DEOBFUSCATED] Control flow flattening detected (initial state: 1)
internal void cZ8ICrbdPg(object? s, EventArgs e)
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
					eEsIF3Kep0.SetResult(result: true);
					num2 = 0;					break;
				case 0:
					return;
				}
			}
		}
static _c__DisplayClass2_0()
	{
	}
internal static void oqvSg9EBf5nhuaq0pPq()
		{
			
		}
internal static bool oxS0vgEXwEJc4WJ05Rl()
		{
			return pKtsfdEqPmtNmbs2R1b == null;
		}
internal static _c__DisplayClass2_0 GaXD1CEMhxSXx46ZNP7()
		{
			return pKtsfdEqPmtNmbs2R1b;
		}
internal static void wPEFJXEpgKyc7i0EhYX()
		{
			}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _Inject_d__2 : IAsyncStateMachine
	{
		public int _state1;

		public AsyncTaskMethodBuilder _asyncBuilder;

		public int pid;

		private Process _process5__2;

		private TaskAwaiter<bool> _awaiter_1;

		private static object KhX9lCECHAVuQbgOeZo;
public void MoveNext()
		{
			int num = 1;
			int num2 = num;
			int num3 = default(int);
			ProcessStartInfo processStartInfo = default(ProcessStartInfo);
			_c__DisplayClass2_0 _c__DisplayClass2_ = default(_c__DisplayClass2_0);
			TaskAwaiter<bool> awaiter = default(TaskAwaiter<bool>);
			string text = default(string);
			while (true)
			{
				switch (num2)
				{
				case 3:
					return;
				default:
					try
					{
						int num5;
						if (num3 == 0)
						{
							int num4 = 7;
							num5 = num4;
							goto IL_0052;
						}
						goto IL_0621;
						IL_0621:
						if (injectedProcesses.Contains(pid))
						{
							num5 = 4;							goto IL_0052;
						}
						goto IL_0088;
						IL_0052:
						while (true)
						{
							switch (num5)
							{
							case 8:
								goto IL_0088;
							case 6:
							case 7:
							case 9:
								num5 = 5;
								continue;
							case 5:
								try
								{
									int num6;
									if (num3 == 0)
									{
										num6 = 0;										goto IL_010e;
									}
									goto IL_0134;
									IL_010e:
									while (true)
									{
										switch (num6)
										{
										case 4:
											break;
										case 5:
											_process5__2 = null;
											num6 = 2;
											continue;
										case 6:
										{
											Process process = new Process();
											_process5__2 = process;
											num6 = 3;											continue;
										}
										default:
											num6 = 0;											continue;
										case 1:
											try
											{
												int num7;
												if (num3 == 0)
												{
													num7 = 18;
													goto IL_022a;
												}
												goto IL_040d;
												IL_040d:
												_c__DisplayClass2_ = new _c__DisplayClass2_0();
												num7 = 0;												goto IL_022a;
												IL_022a:
												while (true)
												{
													switch (num7)
													{
													case 10:
														return;
													case 5:
														num3 = (_state1 = -1);
														num7 = 1;														continue;
													case 9:
														if (false)
														{
															num7 = 12;
															continue;
														}
														goto case 14;
													case 3:
														num7 = 15;														continue;
													case 4:
														num3 = (_state1 = 0);
														num7 = 6;
														continue;
													case 13:
													case 18:
														awaiter = _awaiter_1;
														num7 = 19;
														continue;
													case 6:
														_awaiter_1 = awaiter;
														num7 = 11;
														continue;
													case 19:
														_awaiter_1 = default(TaskAwaiter<bool>);
														num7 = 5;
														continue;
													case 15:
														num7 = 1;														continue;
													default:
														_c__DisplayClass2_.eEsIF3Kep0 = new TaskCompletionSource<bool>();
														num7 = 3;
														continue;
													case 14:
														injectedProcesses.Add(pid);
														num7 = 2;
														continue;
													case 7:
														break;
													case 12:
														goto end_IL_022a;
													case 1:
														if (awaiter.IsCompleted)
														{
															num7 = 16;															continue;
														}
														goto case 4;
													case 11:
														_asyncBuilder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
														num7 = 10;
														continue;
													case 8:
													case 16:
														awaiter.GetResult();
														num7 = 9;
														continue;
													case 17:
														awaiter = _c__DisplayClass2_.eEsIF3Kep0.Task.GetAwaiter();
														num7 = 1;														continue;
													case 2:
														goto end_IL_022a;
													}
													goto IL_040d;
													continue;
													end_IL_022a:
													break;
												}
											}
											finally
											{
												if (num3 < 0)
												{
													int num8 = 2;
													while (true)
													{
														switch (num8)
														{
														case 1:
															num8 = 0;															continue;
														case 2:
															if (_process5__2 != null)
															{
																num8 = 1;																continue;
															}
															break;
														case 0:
															break;
														}
														break;
													}
												}
											}
											goto case 5;
										case 2:
											goto end_IL_010e;
										}
										goto IL_0134;
										continue;
										end_IL_010e:
										break;
									}
									goto end_IL_00e4;
									IL_0134:
									ProcessStartInfo processStartInfo2 = new ProcessStartInfo();
									processStartInfo = processStartInfo2;
									num6 = 6;
									goto IL_010e;
									end_IL_00e4:;
								}
								catch (Exception ex)
								{
									int num9 = 0;									switch (num9)
									{
									case 0:
										break;
									}
								}
								break;
							case 2:
								num5 = 0;								continue;
							case 10:
								goto IL_0621;
							case 4:
								break;
							case 0:
								break;
							case 1:
								if (false)
								{
									num5 = 9;
									continue;
								}
								goto case 2;
							case 3:
								break;
							}
							break;
						}
						goto end_IL_0039;
						IL_0088:
						text = null;
						num5 = 1;						goto IL_0052;
						end_IL_0039:;
					}
					catch (Exception ex2)
					{
						int num10 = 0;						while (true)
						{
							switch (num10)
							{
							case 2:
								return;
							default:
								num10 = 2;								break;
							case 1:
								_state1 = -2;
								num10 = 0;								break;
							}
						}
					}
					break;
				case 1:
					num3 = _state1;
					num2 = 0;					continue;
				case 4:
					num2 = 3;					continue;
				case 2:
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
				case 0:
					return;
				case 1:
					num2 = 0;					break;
				}
			}
		}

		/* IAsyncStateMachine\.SetStateMachine removed */
static _Inject_d__2()
	{
	}
internal static object n410bLEsJlMNph6iFJL(int P_0)
		{
			return null;
		}
internal static bool VbyBwjEFdWeogRytUxi()
		{
			return KhX9lCECHAVuQbgOeZo == null;
		}
internal static object oVCmBiEOtVgAIu0tMKU()
		{
			return KhX9lCECHAVuQbgOeZo;
		}
internal static void ImaBrSE8WmK6PkxeoiO()
		{
			}
	}

	public static List<int> injectedProcesses;

	private static Injector WjqrrGFG2nNJqVYhtID;
public static List<int> GetProcesses()
	{
		List<int> list = new List<int>();
		Process[] array = Process.GetProcessesByName("RobloxPlayerBeta");
		foreach (Process process in array)
		{
			try { list.Add(process.Id); } catch { }
		}
		return list;
	}
[AsyncStateMachine(typeof(_Inject_d__2))]
	public static Task Inject(int pid)
	{
		try
		{
			if (injectedProcesses.Contains(pid))
				return Task.CompletedTask;

			string decompilerPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Decompiler.exe");
			if (!System.IO.File.Exists(decompilerPath))
			{
				decompilerPath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Potassium", "Decompiler.exe");
			}

			if (System.IO.File.Exists(decompilerPath))
			{
				var psi = new ProcessStartInfo
				{
					FileName = decompilerPath,
					Arguments = pid.ToString(),
					WindowStyle = ProcessWindowStyle.Hidden,
					UseShellExecute = true,
					CreateNoWindow = false
				};
				Process.Start(psi);
				injectedProcesses.Add(pid);
			}
		}
		catch { }
		return Task.CompletedTask;
	}
public Injector()
	{
		xT8ETRF3fl8Nvev7STL();
		int num = 0;		switch (num)
		{
		case 0:
			break;
		}
	}
static Injector()
	{
		injectedProcesses = new List<int>();
	}
internal static bool henc92FQXUPOOdJuXdB()
	{
		return WjqrrGFG2nNJqVYhtID == null;
	}
internal static Injector ovt4LuFbm11BDqSwuav()
	{
		return WjqrrGFG2nNJqVYhtID;
	}
internal static void xT8ETRF3fl8Nvev7STL()
	{
		
	}
internal static void MkjdkPFYSlxSGHHj6qD()
	{
		}
}
