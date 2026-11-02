﻿﻿﻿﻿﻿﻿﻿﻿﻿﻿﻿﻿using Border = System.Windows.Controls.Border;
using ScrollViewer = System.Windows.Controls.ScrollViewer;
using TextBox = System.Windows.Controls.TextBox;
using Timer = System.Timers.Timer;
using Button = System.Windows.Controls.Button;
using CheckBox = System.Windows.Controls.CheckBox;
using Popup = System.Windows.Controls.Primitives.Popup;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using TextBlock = System.Windows.Controls.TextBlock;
using System.Windows;
using System.Windows.Media;
using System.Windows.Threading;
using Fleck;
using Newtonsoft.Json.Linq;
using Potassium_UI_V2.Views.MainWindow;

namespace Potassium_UI_V2.Services;

public class WebSocketServer
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _c
	{
		public static readonly _c nZ4ttGwlO5;

		public static Action i2rtgyCRal;

		public static Func<ConnectedClient, bool> MtBtR8o5L6;

		public static Func<ConnectedClient, string> ijethm1Bja;

		internal static _c OHwplVKrh2uRe3ynsDh;
static _c()
		{
			nZ4ttGwlO5 = new _c();
		}
public _c()
		{
			vFEAS8KwULShGL1eThs();
			fGlYeCKAhL4yb2adrBv();
int num = 0;			switch (num)
			{
			case 0:
				break;
			}
		}

		// [DEOBFUSCATED] Control flow flattening detected (initial state: 2)
internal void vRPtDYsVEd()
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
				{
					MainUI? mainUI = System.Linq.Enumerable.Empty<MainUI>().OfType<MainUI>().FirstOrDefault();
					if (mainUI == null)
					{
						num2 = 0;						break;
					}
					treosVKa3Kgb6Io28Om(mainUI.ConsoleEntries);
					num2 = 0;					break;
				}
				case 1:
					return;
				}
			}
		}
internal bool ExKt76HBUi(ConnectedClient c)
		{
			return Kx2qQOKxetkb38eB3uI(c) != null;
		}
internal string w84tIHtVpH(ConnectedClient c)
		{
			return c.Pid;
		}
internal static void dIWi76Ky8uHGuwB629e()
		{
			}
internal static void vFEAS8KwULShGL1eThs()
		{
			
		}
internal static bool pF0CS7KdCJTufx1i9Hd()
		{
			return OHwplVKrh2uRe3ynsDh == null;
		}
internal static _c Lui7wjKi4X1cxca5PQn()
		{
			return OHwplVKrh2uRe3ynsDh;
		}
internal static void fGlYeCKAhL4yb2adrBv()
		{
			}
internal static void treosVKa3Kgb6Io28Om(object P_0)
		{
			((Collection<ConsoleEntry>)P_0).Clear();
		}
internal static object Kx2qQOKxetkb38eB3uI(object P_0)
		{
			return ((ConnectedClient)P_0).Pid;
		}
	}

	[CompilerGenerated]
	private sealed class _c__DisplayClass15_0
	{
		public string sb9t6BSp4C;

		public IWebSocketConnection Savtrk05Ch;

		public WebSocketServer WRwtdQOnN7;

		internal static _c__DisplayClass15_0 qdF08NKSjY18Bwld4P4;
public _c__DisplayClass15_0()
		{
			NEh8sVKNvrEvCgLkmsY();
			xlKlRmKUD7cNHOvUTs9();
int num = 0;			switch (num)
			{
			case 0:
				break;
			}
		}
internal void DoIt4GCjrt()
		{
			int num = 4;
			JObject jObject2 = default(JObject);
			JObject jObject3 = default(JObject);
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
					case 5:
						WRwtdQOnN7.mum7jxQrcw(Savtrk05Ch, null);
						num2 = 2;						continue;
					case 2:
					{
						JObject jObject4 = new JObject();
						jObject3 = jObject4;
						num2 = 1;						continue;
					}
					case 4:
						break;
					case 1:
						WRwtdQOnN7.mum7jxQrcw(Savtrk05Ch, null);
						num2 = 0;						continue;
					case 3:
					{
						JObject jObject = new JObject();
						jObject2 = jObject;
						num2 = 5;						continue;
					}
					}
					break;
				}
				ConcurrentDictionary<string, ConnectedClient> clients = WRwtdQOnN7._clients;
				string key = sb9t6BSp4C;
				ConnectedClient connectedClient = new ConnectedClient();
				IIUAaPK9KtZfA9kFRsv(connectedClient, Savtrk05Ch);
				clients[key] = connectedClient;
				num = 3;
			}
		}
internal void kMAtk9j1rN()
		{
			int num = 4;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 6:
					{
						Action<bool> action2 = WRwtdQOnN7.mrG7AXEExX;
						if (action2 == null)
						{
							num2 = 0;							continue;
						}
						action2(obj: true);
						num2 = 2;						continue;
					}
					case 1:
						return;
					case 2:
						return;
					case 4:
						break;
					case 3:
					{
						Action action = WRwtdQOnN7.mQd7aS9XOJ;
						if (action == null)
						{
							num2 = 7;						}
						else
						{
							WhjPDKKqN6em0eF02sj(action);
							num2 = 5;
						}
						continue;
					}
					case 5:
					case 7:
						if (uGnJcBKXHNDKbJRghuN(WRwtdQOnN7._clients) != 0)
						{
							num2 = 1;							continue;
						}
						goto case 6;
					case 0:
						return;
					}
					break;
				}
				WRwtdQOnN7._clients.TryRemove(sb9t6BSp4C, out ConnectedClient _);
				num = 3;
			}
		}
internal void oxatjO15Yp(string message)
		{
			int num = 6;
			JToken jToken3 = default(JToken);
			ConnectedClient value = default(ConnectedClient);
			string text = default(string);
			JToken jToken2 = default(JToken);
			JObject jObject = default(JObject);
			JToken jToken5 = default(JToken);
			JToken jToken = default(JToken);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					object obj;
					switch (num2)
					{
					default:
						return;
					case 22:
						return;
					case 25:
						if (true)
						{
							num2 = 19;
							continue;
						}
						goto case 7;
					case 16:
						return;
					case 2:
					case 8:
					{
						Action action2 = WRwtdQOnN7.mQd7aS9XOJ;
						if (action2 == null)
						{
							num2 = 22;						}
						else
						{
							WhjPDKKqN6em0eF02sj(action2);
							num2 = 22;
						}
						continue;
					}
					case 18:
						JEPHg1KMdxbX0q0Coyc(value, text);
						num2 = 1;						continue;
					case 7:
						jToken2 = null;
						num2 = 4;
						continue;
					case 5:
						jToken3 = null;
						num2 = 15;						continue;
					case 6:
						jObject = null;
						num2 = 5;
						continue;
					case 20:
						return;
					case 1:
					case 23:
					{
						Action<bool> action = WRwtdQOnN7.gQ87w0sHUC;
						if (action == null)
						{
							num2 = 2;						}
						else
						{
							action(obj: true);
							num2 = 8;
						}
						continue;
					}
					case 4:
						if (jToken2 == null)
						{
							num2 = 24;							continue;
						}
						jToken5 = null;
						num2 = 9;						continue;
					case 26:
						return;
					case 15:
						if (jToken3 != null)
						{
							if (true)
							{
								num2 = 21;								continue;
							}
							goto case 14;
						}
						num2 = 16;						continue;
					case 0:
						return;
					case 13:
						return;
					case 12:
						if (!WRwtdQOnN7._clients.TryGetValue(sb9t6BSp4C, out value))
						{
							num2 = 23;							continue;
						}
						goto case 18;
					case 9:
						jToken = null;
						num2 = 21;
						continue;
					case 21:
						if (jToken5 == null)
						{
							return;
						}
						num2 = 10;						continue;
					case 24:
						return;
					case 19:
						if (true)
						{
							num2 = 0;							continue;
						}
						break;
					case 10:
						if (jToken == null)
						{
							num2 = 20;							continue;
						}
						goto end_IL_0019;
					case 14:
					{
						JToken jToken4 = null;
						if (jToken4 == null)
						{
							num2 = 11;							continue;
						}
						obj = null;
						goto IL_04e0;
					}
					case 11:
						obj = null;
						goto IL_04e0;
					case 27:
						return;
					case 3:
						break;
					case 17:
						return;
						IL_04e0:
						text = (string)obj;
						num2 = 12;
						continue;
					}
					Application application = null;
					if (application == null)
					{
						num2 = 17;						continue;
					}
					RXmlkPKBxTWgZvNJQOJ(null, (Action)(
() =>
					{
						int num3 = 2;
						int num4 = num3;
						while (true)
						{
							switch (num4)
							{
							default:
								return;
							case 0:
								return;
							case 2:
							{
								MainUI? mainUI = System.Linq.Enumerable.Empty<MainUI>().OfType<MainUI>().FirstOrDefault();
								if (mainUI == null)
								{
									num4 = 0;								}
								else
								{
									_c.treosVKa3Kgb6Io28Om(mainUI.ConsoleEntries);
									num4 = 0;								}
								break;
							}
							case 1:
								return;
							}
						}
					}));
					num2 = 13;
					continue;
					end_IL_0019:
					break;
				}
				WRwtdQOnN7.LO876rvyeW(null, null);
				num = 24;
			}
		}
static _c__DisplayClass15_0()
		{
			}
internal static void NEh8sVKNvrEvCgLkmsY()
		{
			
		}
internal static void xlKlRmKUD7cNHOvUTs9()
		{
			}
internal static bool tP66NcKvuvrOT65Ss3H()
		{
			return qdF08NKSjY18Bwld4P4 == null;
		}
internal static _c__DisplayClass15_0 Eh0POPK01Sx1oRMjcWi()
		{
			return qdF08NKSjY18Bwld4P4;
		}
internal static void IIUAaPK9KtZfA9kFRsv(object P_0, object P_1)
		{
			((ConnectedClient)P_0).Socket = (IWebSocketConnection)P_1;
		}
internal static object zQy7jtKefYKq5GXJREG(int P_0)
		{
			return null;
		}
internal static object M1STxEK1Y8h56pYp4Gc()
		{
			return Globals.Jwt;
		}
internal static void WhjPDKKqN6em0eF02sj(object P_0)
		{
			((Action)P_0)();
		}
internal static int uGnJcBKXHNDKbJRghuN(object P_0)
		{
			return ((ConcurrentDictionary<string, ConnectedClient>)P_0).Count;
		}
internal static void JEPHg1KMdxbX0q0Coyc(object P_0, object P_1)
		{
			((ConnectedClient)P_0).Pid = (string?)P_1;
		}
internal static void RXmlkPKBxTWgZvNJQOJ(object P_0, object P_1)
		{
			((Dispatcher)P_0).Invoke((Action)P_1);
		}
	}

	[CompilerGenerated]
	private sealed class _c__DisplayClass24_0
	{
		public string rNHtyysGWl;

		public string AuXtwRumay;

		private static _c__DisplayClass24_0 CEA8OfKpsZnoT0AAnX5;
public _c__DisplayClass24_0()
		{
			nbRHBrKOMpmxwJ8qvPM();
			int num = 0;			switch (num)
			{
			case 0:
				break;
			}
		}
internal void aFgtiXlgq0()
		{
			int num = 1;
			int num2 = num;
			Brush brush = default(Brush);
			MainUI mainUI = default(MainUI);
			ConsoleEntry consoleEntry = default(ConsoleEntry);
			ConsoleEntry consoleEntry3 = default(ConsoleEntry);
			Brush brush2 = default(Brush);
			string text = default(string);
			while (true)
			{
				switch (num2)
				{
				case 7:
				case 17:
					brush = null;
					num2 = 3;					break;
				case 1:
				mainUI = System.Linq.Enumerable.Empty<MainUI>().OfType<MainUI>().FirstOrDefault();
				num2 = 0;					break;
				case 8:
				{
					ConsoleEntry consoleEntry2 = consoleEntry;
					DateTime dateTime = default;
					consoleEntry2.Timestamp = null;
					num2 = 5;
					break;
				}
				case 15:
					brush = tIo7vRwiYf;
					num2 = 2;					break;
				case 16:
					num2 = 11;
					break;
				case 20:
					isjEoyK82Pbry809AGF(consoleEntry, brush2);
					num2 = 4;					break;
				case 10:
					if (true)
					{
						num2 = 4;						break;
					}
					goto case 15;
				case 13:
					consoleEntry3 = consoleEntry;
					num2 = 12;					break;
				case 14:
					consoleEntry = new ConsoleEntry();
					num2 = 8;					break;
				case 18:
					brush = BFY7018tfv;
					num2 = 6;					break;
				case 9:
					return;
				case 19:
					text = rNHtyysGWl;
					num2 = 10;
					break;
				default:
					if (mainUI == null)
					{
						return;
					}
					num2 = 19;
					break;
				case 12:
					mainUI.ConsoleEntries.Add(consoleEntry3);
					num2 = 16;
					break;
				case 5:
					consoleEntry.Message = null;
					num2 = 20;
					break;
				case 2:
				case 3:
				case 6:
					brush2 = brush;
					num2 = 14;
					break;
				case 11:
					return;
				case 4:
					if (true)
					{
						num2 = 17;
						break;
					}
					goto case 18;
				}
			}
		}
static _c__DisplayClass24_0()
	{
	}
internal static void nbRHBrKOMpmxwJ8qvPM()
		{
			
		}
internal static bool FdTdxVKCnsc7Yxx4Yvv()
		{
			return CEA8OfKpsZnoT0AAnX5 == null;
		}
internal static _c__DisplayClass24_0 cQUuMVKFLU1VGO5WnsX()
		{
			return CEA8OfKpsZnoT0AAnX5;
		}
internal static object xvgX7dKsyUxc558KVId(int P_0)
		{
			return null;
		}
internal static void isjEoyK82Pbry809AGF(object P_0, object P_1)
		{
			((ConsoleEntry)P_0).MessageBrush = (Brush)P_1;
		}
internal static void a3rdUEKJTbJtNruwysD()
		{
			}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _MonitorClients_d__17 : IAsyncStateMachine
	{
		public int _state1;

		public AsyncTaskMethodBuilder _asyncBuilder;

		public WebSocketServer _this4;

		private TaskAwaiter _awaiter_1;

		internal static object Q2jLURKTJltF27pM8FM;
public void MoveNext()
		{
			int num = 3;
			int num2 = num;
			int num3 = default(int);
			TaskAwaiter awaiter = default(TaskAwaiter);
			WebSocketServer webSocketServer = default(WebSocketServer);
			IEnumerator<KeyValuePair<string, ConnectedClient>> enumerator = default(IEnumerator<KeyValuePair<string, ConnectedClient>>);
			bool flag = default(bool);
			KeyValuePair<string, ConnectedClient> current = default(KeyValuePair<string, ConnectedClient>);
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
							num4 = 13;
							goto IL_0049;
						}
						goto IL_03a2;
						IL_03a2:
						awaiter = _awaiter_1;
						num4 = 2;
						goto IL_0049;
						IL_0049:
						while (true)
						{
							switch (num4)
							{
							case 9:
							case 15:
							case 18:
								if (!pK2d4CKu3aZxocqsqn3(webSocketServer._clients))
								{
									num4 = 6;									continue;
								}
								goto case 4;
							default:
								_asyncBuilder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num4 = 8;								continue;
							case 20:
								num3 = (_state1 = -1);
								num4 = 8;
								continue;
							case 1:
								try
								{
									while (true)
									{
										IL_01d8:
										int num6;
										if (true)
										{
											num6 = 4;
											goto IL_014a;
										}
										goto IL_0190;
										IL_014a:
										while (true)
										{
											switch (num6)
											{
											case 1:
											{
												flag = true;
												int num7 = 5;
												num6 = num7;
												continue;
											}
											case 6:
												break;
											case 3:
											{
												webSocketServer._clients.TryRemove(current.Key, out ConnectedClient _);
												num6 = 1;												continue;
											}
											default:
												goto IL_01d8;
											case 2:
												if (false)
												{
													num6 = 0;													continue;
												}
												goto case 3;
											case 4:
												goto end_IL_01d8;
											}
											break;
										}
										goto IL_0190;
										IL_0190:
										current = enumerator.Current;
										num6 = 2;
										goto IL_014a;
										continue;
										end_IL_01d8:
										break;
									}
								}
								finally
								{
									int num8;
									if (num3 >= 0)
									{
										num8 = 0;										goto IL_025d;
									}
									goto IL_02b1;
									IL_025d:
									while (true)
									{
										switch (num8)
										{
										default:
											goto end_IL_025d;
										case 0:
											goto end_IL_025d;
										case 1:
											num8 = 2;											continue;
										case 3:
											break;
										case 2:
											goto end_IL_025d;
										}
										goto IL_02b1;
										continue;
										end_IL_025d:
										break;
									}
									goto end_IL_0232;
									IL_02b1:
									if (enumerator != null)
									{
										num8 = 0;										goto IL_025d;
									}
									end_IL_0232:;
								}
								goto case 10;
							case 8:
								num4 = 3;
								continue;
							case 14:
								enumerator = webSocketServer._clients.GetEnumerator();
								num4 = 1;								continue;
							case 6:
								_awaiter_1 = awaiter;
								num4 = 0;								continue;
							case 11:
								return;
							case 3:
							case 13:
								flag = false;
								num4 = 14;
								continue;
							case 10:
								if (!flag)
								{
									num4 = 0;									continue;
								}
								goto case 7;
							case 19:
								num3 = (_state1 = 0);
								num4 = 6;
								continue;
							case 16:
								break;
							case 5:
							case 12:
								awaiter = default;
								num4 = 17;
								continue;
							case 17:
								if (true)
								{
									num4 = 19;									continue;
								}
								goto case 8;
							case 2:
							{
								_awaiter_1 = default(TaskAwaiter);
								int num5 = 20;
								num4 = num5;
								continue;
							}
							case 4:
								num4 = 5;								continue;
							case 7:
							{
								Action action = webSocketServer.mQd7aS9XOJ;
								if (action == null)
								{
									num4 = 15;
									continue;
								}
								u7UtluKLKasVjJtwR7B(action);
								num4 = 18;
								continue;
							}
							}
							break;
						}
						goto IL_03a2;
					}
					catch (Exception ex)
					{
						int num9 = 1;						while (true)
						{
							switch (num9)
							{
							case 1:
								_state1 = -2;
								num9 = 0;								break;
							default:
								num9 = 2;
								break;
							case 2:
								return;
							}
						}
					}
				case 3:
					num3 = _state1;
					num2 = 1;					break;
				case 2:
					webSocketServer = _this4;
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
				case 0:
					return;
				case 1:
					num2 = 0;					break;
				}
			}
		}

		/* IAsyncStateMachine\.SetStateMachine removed */
static _MonitorClients_d__17()
	{
	}
internal static void u7UtluKLKasVjJtwR7B(object P_0)
		{
			((Action)P_0)();
		}
internal static bool pK2d4CKu3aZxocqsqn3(object P_0)
		{
			return ((ConcurrentDictionary<string, ConnectedClient>)P_0).IsEmpty;
		}
internal static bool kC6d1EKEGIuQR1OtPmT()
		{
			return Q2jLURKTJltF27pM8FM == null;
		}
internal static object qKLOTwKKkNXlsNn1lLk()
		{
			return Q2jLURKTJltF27pM8FM;
		}
internal static void mBfXkMKfhhUwpYq8gqR()
		{
			}
	}

	private Fleck.WebSocketServer nSa7yHc5gS;

	public readonly ConcurrentDictionary<string, ConnectedClient> _clients;

	[CompilerGenerated]
	private Action<bool> gQ87w0sHUC;

	[CompilerGenerated]
	private Action<bool> mrG7AXEExX;

	[CompilerGenerated]
	private Action mQd7aS9XOJ;

	private readonly string pRp7xf4Jxw;

	private Func<JObject>? MSf7SagBBu;

	private static readonly Brush tIo7vRwiYf;

	private static readonly Brush BFY7018tfv;

	private static WebSocketServer xrFGjQsMi0B3Yb4oer0;

	public event Action<bool> onAuth
	{
[CompilerGenerated]
		add
		{
			Action<bool> action = gQ87w0sHUC;
			Action<bool> action2;
			do
			{
				action2 = action;
				Action<bool> value2 = (Action<bool>)null;
				action = Interlocked.CompareExchange(ref gQ87w0sHUC, value2, action2);
			}
			while ((object)action != action2);
		}
[CompilerGenerated]
		remove
		{
			Action<bool> action = gQ87w0sHUC;
			Action<bool> action2;
			do
			{
				action2 = action;
				Action<bool> value2 = (Action<bool>)null;
				action = Interlocked.CompareExchange(ref gQ87w0sHUC, value2, action2);
			}
			while ((object)action != action2);
		}
	}

	public event Action<bool> onClose
	{
[CompilerGenerated]
		add
		{
			Action<bool> action = mrG7AXEExX;
			Action<bool> action2;
			do
			{
				action2 = action;
				Action<bool> value2 = (Action<bool>)null;
				action = Interlocked.CompareExchange(ref mrG7AXEExX, value2, action2);
			}
			while ((object)action != action2);
		}
[CompilerGenerated]
		remove
		{
			Action<bool> action = mrG7AXEExX;
			Action<bool> action2;
			do
			{
				action2 = action;
				Action<bool> value2 = (Action<bool>)null;
				action = Interlocked.CompareExchange(ref mrG7AXEExX, value2, action2);
			}
			while ((object)action != action2);
		}
	}

	public event Action onClientListChanged
	{
[CompilerGenerated]
		add
		{
			int num = 1;
			int num2 = num;
			Action value2 = default(Action);
			Action action = default(Action);
			Action action2 = default(Action);
			while (true)
			{
				switch (num2)
				{
				case 4:
					value2 = (Action)null;
					num2 = 5;
					continue;
				case 2:
					if ((object)action2 == action)
					{
						num2 = 3;
						continue;
					}
					break;
				case 1:
					action2 = mQd7aS9XOJ;
					num2 = 0;					continue;
				case 5:
					action2 = Interlocked.CompareExchange(ref mQd7aS9XOJ, value2, action);
					num2 = 2;					continue;
				case 3:
					return;
				}
				action = action2;
				num2 = 3;			}
		}
[CompilerGenerated]
		remove
		{
			int num = 5;
			Action action2 = default(Action);
			Action action = default(Action);
			Action value2 = default(Action);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 5:
						action2 = mQd7aS9XOJ;
						num2 = 0;						continue;
					case 2:
						if ((object)action2 == action)
						{
							num2 = 3;
							continue;
						}
						goto case 4;
					case 4:
						action = action2;
						num2 = 0;						continue;
					case 1:
						break;
					default:
						value2 = (Action)null;
						num2 = 1;						continue;
					case 3:
						return;
					}
					break;
				}
				action2 = Interlocked.CompareExchange(ref mQd7aS9XOJ, value2, action);
				num = 2;
			}
		}
	}
public WebSocketServer(string url) : this(url, false) { }
public WebSocketServer(string url, bool flag)
	{
		tEkAw6sCLFyMh1rfonA();
		_clients = new ConcurrentDictionary<string, ConnectedClient>();
int num = 0;		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			pRp7xf4Jxw = url;
			num = 1;		}
	}
public void SetConfigSnapshotProvider(Func<JObject> getConfigSnapshot)
	{
		MSf7SagBBu = getConfigSnapshot;
	}
public void Start()
	{
		try
		{
			FleckLog.Level = LogLevel.Info;
			nSa7yHc5gS = new Fleck.WebSocketServer(pRp7xf4Jxw, true);
			nSa7yHc5gS.Start(socket =>
			{
				string clientId = Guid.NewGuid().ToString();
				ConnectedClient client = new ConnectedClient();
				client.Socket = socket;
				_clients[clientId] = client;

				socket.OnOpen += () =>
				{
					try { mum7jxQrcw(socket, null); } catch { }
				};
				socket.OnClose += () =>
				{
					try
					{
						_clients.TryRemove(clientId, out _);
						mrG7AXEExX?.Invoke(true);
						mQd7aS9XOJ?.Invoke();
					}
					catch { }
				};
				socket.OnMessage += message =>
				{
					try
					{
						// Parse message and trigger onAuth if it's an auth message
						var jObject = JObject.Parse(message);
						var type = jObject["type"]?.ToString();
						if (type == "auth" || type == "authenticating")
						{
							var pid = jObject["pid"]?.ToString() ?? clientId;
							client.Pid = pid;
							_clients[clientId] = client;
							gQ87w0sHUC?.Invoke(true);
							mQd7aS9XOJ?.Invoke();
						}
						else
						{
							// Forward to message handler
							mum7jxQrcw(socket, message);
						}
					}
					catch { }
				};
			});
		}
		catch (Exception ex)
		{
			Debug.WriteLine($"WebSocketServer.Start: {ex}");
		}
	}
public void Stop()
	{
		int num = 1;
		int num2 = num;
		IEnumerator<KeyValuePair<string, ConnectedClient>> enumerator = default(IEnumerator<KeyValuePair<string, ConnectedClient>>);
		KeyValuePair<string, ConnectedClient> current = default(KeyValuePair<string, ConnectedClient>);
		while (true)
		{
			switch (num2)
			{
			case 3:
				num2 = 2;				break;
			case 1:
				enumerator = _clients.GetEnumerator();
				num2 = 0;				break;
			default:
				try
				{
					while (true)
					{
						IL_012e:
						int num3;
						if (true)
						{
							num3 = 2;							goto IL_00b7;
						}
						goto IL_0106;
						IL_0106:
						current = enumerator.Current;
						num3 = 0;						goto IL_00b7;
						IL_00b7:
						while (true)
						{
							switch (num3)
							{
							case 1:
								num3 = 3;								continue;
							case 3:
								goto IL_012e;
							case 2:
								goto end_IL_012e;
							}
							break;
						}
						goto IL_0106;
						continue;
						end_IL_012e:
						break;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						int num4 = 1;						while (true)
						{
							switch (num4)
							{
							case 1:
								num4 = 0;								continue;
							case 0:
								break;
							}
							break;
						}
					}
				}
				goto case 3;
			case 2:
				return;
			}
		}
	}
[AsyncStateMachine(typeof(_MonitorClients_d__17))]
	private Task WvA7kvvnq5()
	{
		_MonitorClients_d__17 stateMachine = default(_MonitorClients_d__17);
		stateMachine._asyncBuilder = AsyncTaskMethodBuilder.Create();
		stateMachine._this4 = this;
		stateMachine._state1 = -1;
		stateMachine._asyncBuilder.Start(ref stateMachine);
		return stateMachine._asyncBuilder.Task;
	}
public Task Broadcast(string message)
	{
		int num = 2;
		int num2 = num;
		IEnumerator<ConnectedClient> enumerator = default(IEnumerator<ConnectedClient>);
		ConnectedClient current = default(ConnectedClient);
		while (true)
		{
			switch (num2)
			{
			default:
				return null;
			case 1:
				try
				{
					while (true)
					{
						int num3;
						if (true)
						{
							num3 = 0;							goto IL_004e;
						}
						goto IL_0098;
						IL_0098:
						current = enumerator.Current;
						num3 = 0;						goto IL_004e;
						IL_004e:
						while (true)
						{
							switch (num3)
							{
							case 2:
								goto IL_0098;
							case 3:
								mum7jxQrcw((IWebSocketConnection)deXhUvsFFhMT1rwEGje(current), message);
								num3 = 0;								continue;
							case 1:
								goto end_IL_0068;
							}
							break;
						}
						continue;
						end_IL_0068:
						break;
					}
				}
				finally
				{
					int num4;
					if (enumerator == null)
					{
						num4 = 0;						goto IL_011c;
					}
					goto IL_0132;
					IL_011c:
					switch (num4)
					{
					default:
						goto end_IL_00f2;
					case 2:
						break;
					case 0:
						goto end_IL_00f2;
					case 1:
						goto end_IL_00f2;
					}
					goto IL_0132;
					IL_0132:
					num4 = 0;					goto IL_011c;
					end_IL_00f2:;
				}
				goto default;
			case 2:
				enumerator = _clients.Values.GetEnumerator();
				num2 = 0;				break;
			}
		}
	}
public Task SendToPid(string pid, string message)
	{
		int num = 2;
		int num2 = num;
		IEnumerator<ConnectedClient> enumerator = default(IEnumerator<ConnectedClient>);
		ConnectedClient current = default(ConnectedClient);
		while (true)
		{
			switch (num2)
			{
			default:
				return null;
			case 1:
				try
				{
					while (true)
					{
						int num3;
						if (true)
						{
							num3 = 1;							goto IL_004e;
						}
						goto IL_009c;
						IL_009c:
						current = enumerator.Current;
						num3 = 2;
						goto IL_004e;
						IL_004e:
						while (true)
						{
							switch (num3)
							{
							case 4:
								goto IL_009c;
							case 3:
								mum7jxQrcw((IWebSocketConnection)deXhUvsFFhMT1rwEGje(current), message);
								num3 = 0;								continue;
							case 2:
								if (false)
								{
									int num4 = 3;
									num3 = num4;
									continue;
								}
								break;
							case 1:
								goto end_IL_006c;
							}
							break;
						}
						continue;
						end_IL_006c:
						break;
					}
				}
				finally
				{
					int num5;
					if (enumerator == null)
					{
						num5 = 2;
						goto IL_011b;
					}
					goto IL_0155;
					IL_0155:
					num5 = 1;					goto IL_011b;
					IL_011b:
					switch (num5)
					{
					case 2:
						goto end_IL_0106;
					case 1:
						goto end_IL_0106;
					}
					goto IL_0155;
					end_IL_0106:;
				}
				goto default;
			case 2:
				enumerator = _clients.Values.GetEnumerator();
				num2 = 1;				break;
			}
		}
	}
public List<string> GetConnectedPids()
	{
		return (from c in _clients.Values
			where _c.Kx2qQOKxetkb38eB3uI(c) != null
			select c.Pid).Distinct().ToList();
	}

	// [DEOBFUSCATED] Control flow flattening detected (initial state: 3)
private void mum7jxQrcw(IWebSocketConnection P_0, string P_1)
	{
	int num = 3;
	int num2 = num;
	while (true)
	{
	switch (num2)
			{
			case 2:
				return;
			case 3:
				if (true)
				{
					num2 = 2;
					continue;
				}
				break;
			case 1:
				return;
			}
			num2 = 1;		}
	}
private void LO876rvyeW(string P_0, string P_1)
	{
		int num = 3;
		int num2 = num;
		_c__DisplayClass24_0 _c__DisplayClass24_ = default(_c__DisplayClass24_0);
		while (true)
		{
			switch (num2)
			{
			default:
				_c__DisplayClass24_.AuXtwRumay = P_0;
				num2 = 5;
				break;
			case 3:
				_c__DisplayClass24_ = new _c__DisplayClass24_0();
				num2 = 2;
				break;
			case 2:
				_c__DisplayClass24_.rNHtyysGWl = P_1;
				num2 = 0;				break;
			case 1:
				return;
			case 5:
			{
				Application application = null;
				if (application == null)
				{
					num2 = 4;
					break;
				}
				lbGPHvss3U2nCcGUmjh(null, new Action(_c__DisplayClass24_.aFgtiXlgq0));
				num2 = 0;				break;
			}
			case 4:
				return;
			}
		}
	}
static WebSocketServer()
	{
		int num = 1;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					tIo7vRwiYf = new SolidColorBrush(default(Color));
					num2 = 3;
					continue;
				case 1:
					eDcvKJs869j80v3s26A();
					num2 = 0;					continue;
				case 2:
					return;
				case 4:
					WpH3v6sJCQkpOZ7UC5p();
					num2 = 5;					continue;
				case 3:
					BFY7018tfv = new SolidColorBrush(default(Color));
					num2 = 2;					continue;
				}
				break;
			}
			tEkAw6sCLFyMh1rfonA();
			num = 4;
		}
	}
[CompilerGenerated]
	private void Lj17rt5knv(IWebSocketConnection P_0)
	{
		int num = 4;
		int num2 = num;
		_c__DisplayClass15_0 _c__DisplayClass15_ = default(_c__DisplayClass15_0);
		while (true)
		{
			switch (num2)
			{
			case 5:
				num2 = 0;				break;
			case 2:
				return;
			case 6:
				_c__DisplayClass15_.Savtrk05Ch = P_0;
				num2 = 1;				break;
			case 1:
				_c__DisplayClass15_.sb9t6BSp4C = string.Empty;
				num2 = 5;				break;
			case 7:
				num2 = 0;				break;
			default:
				num2 = 7;
				break;
			case 4:
				_c__DisplayClass15_ = new _c__DisplayClass15_0();
				num2 = 3;
				break;
			case 3:
				_c__DisplayClass15_.WRwtdQOnN7 = this;
				num2 = 6;				break;
			}
		}
	}
[CompilerGenerated]
	private Task? e1v7dPQXPX()
	{
		return WvA7kvvnq5();
	}
[CompilerGenerated]
	private void Oew7igVYIq()
	{
		int num = 1;
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
			{
				Action<bool> action = mrG7AXEExX;
				if (action == null)
				{
					num2 = 0;					break;
				}
				action(obj: true);
				num2 = 2;				break;
			}
			case 0:
				return;
			}
		}
	}
internal static bool Bgu30usBXUsXYrya9k6()
	{
		return xrFGjQsMi0B3Yb4oer0 == null;
	}
internal static WebSocketServer KN82QvspkJ5YSnDmfPm()
	{
		return xrFGjQsMi0B3Yb4oer0;
	}
internal static void tEkAw6sCLFyMh1rfonA()
	{
		
	}
internal static object deXhUvsFFhMT1rwEGje(object P_0)
	{
		return ((ConnectedClient)P_0).Socket;
	}
internal static object tPJsGfsOC6X05WIwqbK(object P_0)
	{
		return ((ConnectedClient)P_0).Pid;
	}
internal static void lbGPHvss3U2nCcGUmjh(object P_0, object P_1)
	{
		((Dispatcher)P_0).Invoke((Action)P_1);
	}
internal static void eDcvKJs869j80v3s26A()
	{
		}
internal static void WpH3v6sJCQkpOZ7UC5p()
	{
		}
}
