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
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Threading;
using TextBlock = System.Windows.Controls.TextBlock;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using EleCho.WpfSuite.Controls;
using MahApps.Metro.IconPacks;
using Newtonsoft.Json.Linq;
using Potassium_UI_V2.Utils;

namespace Potassium_UI_V2.Views.Settings;

public partial class Settings : UserControl
{
	public class SettingItem
	{
		[CompilerGenerated]
		private string VeH7qOs9dp;

		[CompilerGenerated]
		private string evb7XBB6jV;

		[CompilerGenerated]
		private string b517Mk8OrJ;

		[CompilerGenerated]
		private string qkT7BSGKeT;

		[CompilerGenerated]
		private bool PWZ7pKLOu3;

		internal static SettingItem l5xnndsV4xNiZMvj5Yp;

		public string Key
		{
[CompilerGenerated]
			get
			{
				return VeH7qOs9dp;
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
						VeH7qOs9dp = value;
						num2 = 0;						break;
					case 0:
						return;
					}
				}
			}
		}

		public string DisplayName
		{
[CompilerGenerated]
			get
			{
				return evb7XBB6jV;
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
						evb7XBB6jV = value;
						num2 = 0;						break;
					case 0:
						return;
					}
				}
			}
		}

		public string Category
		{
[CompilerGenerated]
			get
			{
				return b517Mk8OrJ;
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
						b517Mk8OrJ = value;
						num2 = 0;						break;
					case 0:
						return;
					}
				}
			}
		}

		public string ToolTip
		{
[CompilerGenerated]
			get
			{
				return qkT7BSGKeT;
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
						qkT7BSGKeT = value;
						num2 = 0;						break;
					case 0:
						return;
					}
				}
			}
		}

		public bool Value
		{
[CompilerGenerated]
			get
			{
				return PWZ7pKLOu3;
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
						PWZ7pKLOu3 = value;
						num2 = 0;						break;
					}
				}
			}
		}
public SettingItem()
		{
			
			ayMSjWsZSdeNnK3qDiS();
int num = 0;			switch (num)
			{
			case 0:
				break;
			}
		}
static SettingItem()
		{
			WSFjtPsGSQX9gUIT6N5();
		}
internal static bool oeU0R4scjZQTOtYYXV3()
		{
			return l5xnndsV4xNiZMvj5Yp == null;
		}
internal static SettingItem niGulGsmQTLbcth0kbH()
		{
			return l5xnndsV4xNiZMvj5Yp;
		}
internal static void ayMSjWsZSdeNnK3qDiS()
		{
			}
internal static void WSFjtPsGSQX9gUIT6N5()
		{
			}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class _c
	{
		public static readonly _c Rox7OpkqS8;

		public static Func<SettingItem, string> WZy7sqJ7TY;

		public static Func<SettingItem, bool> KSu78ncOgQ;

		internal static _c awhhkVsQUAQTnSKFkcp;
static _c()
	{
		Rox7OpkqS8 = new _c();
	}
public _c()
		{
			
			G9WTKUs5m8YqJH8tuNp();
int num = 0;			switch (num)
			{
			case 0:
				break;
			}
		}
internal string uc37CQypfN(SettingItem s)
		{
			return (string)SWkPyIszDM89p2cg9j4(s);
		}
internal bool ISr7FvPQHv(SettingItem s)
		{
			return o0eidv8PdE3yVmpibl3(s);
		}
internal static void h80VyxsYX6J8hIWK3Nw()
		{
			}
internal static void G9WTKUs5m8YqJH8tuNp()
		{
			}
internal static bool JYhvUYsbEM0wHpQDxfr()
		{
			return awhhkVsQUAQTnSKFkcp == null;
		}
internal static _c eaZ1dBs3VoMB1kmrgmq()
		{
			return awhhkVsQUAQTnSKFkcp;
		}
internal static object SWkPyIszDM89p2cg9j4(object P_0)
		{
			return ((SettingItem)P_0).Key;
		}
internal static bool o0eidv8PdE3yVmpibl3(object P_0)
		{
			return ((SettingItem)P_0).Value;
		}
	}

	[CompilerGenerated]
	private sealed class _c__DisplayClass13_0
	{
		public string HK57TDivvv;

		private static _c__DisplayClass13_0 C6cGQa8Wxi6ZGC8L3ll;
public _c__DisplayClass13_0()
		{
			IU5mWw8IOcHXCC4VLei();
			int num = 0;			switch (num)
			{
			case 0:
				break;
			}
		}
internal bool sOj7JtYm5K(SettingItem s)
	{
		return default;
	}
static _c__DisplayClass13_0()
	{
	}
internal static void IU5mWw8IOcHXCC4VLei()
		{
			
		}
internal static bool HNiuC38DnPYHe22yEIh()
		{
			return C6cGQa8Wxi6ZGC8L3ll == null;
		}
internal static _c__DisplayClass13_0 gy23uT87HEEI7UmJtxu()
		{
			return C6cGQa8Wxi6ZGC8L3ll;
		}
internal static void OGGsY98tDWALuOPtQnO()
		{
			}
	}

	[CompilerGenerated]
	private sealed class _c__DisplayClass18_0
	{
		public SettingItem PhO7LXKTWg;

		public Settings du77upfH2V;

		internal static _c__DisplayClass18_0 jvdBQ18g090r5XZEZrF;
public _c__DisplayClass18_0()
		{
			PyuoHM84D57flgs74v9();
			e3c0kM8ki2P3FEhDucp();
int num = 0;			switch (num)
			{
			case 0:
				break;
			}
		}
internal void Iki7E1BQOf(object s, RoutedEventArgs e)
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
					case 4:
						hdhDRc8jEohYkx7c4XN(PhO7LXKTWg, true);
						num2 = 3;
						continue;
					case 3:
						du77upfH2V.nut0ZDugL();
						num2 = 1;						continue;
					case 2:
						return;
					case 1:
					{
						Action<string, bool>? action = du77upfH2V.H83eQicO1;
						if (action == null)
						{
							num2 = 0;							continue;
						}
						action(PhO7LXKTWg.Key, arg2: true);
						num = 2;
						break;
					}
					case 0:
						return;
					}
					break;
				}
			}
		}

		// [DEOBFUSCATED] Control flow flattening detected (initial state: 4)
internal void QkD7KAuAQR(object s, RoutedEventArgs e)
		{
		int num = 4;
		int num2 = num;
		while (true)
		{
		switch (num2)
				{
				default:
					return;
				case 1:
					return;
				case 4:
					hdhDRc8jEohYkx7c4XN(PhO7LXKTWg, false);
					num2 = 3;
					break;
				case 3:
					du77upfH2V.nut0ZDugL();
					num2 = 2;
					break;
				case 2:
				{
					Action<string, bool>? action = du77upfH2V.H83eQicO1;
					if (action == null)
					{
						num2 = 0;						break;
					}
					action((string)X0BgCV86TOwvNRUhwsJ(PhO7LXKTWg), arg2: false);
					num2 = 1;					break;
				}
				case 0:
					return;
				}
			}
		}
static _c__DisplayClass18_0()
	{
	}
internal static void PyuoHM84D57flgs74v9()
		{
			
		}
internal static void e3c0kM8ki2P3FEhDucp()
		{
			}
internal static bool XwB0c28RcxWi4hNB3RN()
		{
			return jvdBQ18g090r5XZEZrF == null;
		}
internal static _c__DisplayClass18_0 OZrtPO8hcKH0y9QidwZ()
		{
			return jvdBQ18g090r5XZEZrF;
		}
internal static void hdhDRc8jEohYkx7c4XN(object P_0, bool value)
		{
			((SettingItem)P_0).Value = value;
		}
internal static object X0BgCV86TOwvNRUhwsJ(object P_0)
		{
			return ((SettingItem)P_0).Key;
		}
internal static void SRJS5J8rE8RwmcmSTGQ()
		{
			}
	}

	private bool qW5UaYYmM;

	[CompilerGenerated]
	private List<SettingItem> V8e9QyoAc;

	[CompilerGenerated]
	private Action<string, bool>? H83eQicO1;

		private bool Edh1U5XoR;

	internal static Settings drBjiACuc4tZEI5mtMN;

	public List<SettingItem> SettingsList
	{
[CompilerGenerated]
		get
		{
			return V8e9QyoAc;
		}
[CompilerGenerated]
		set
		{
			V8e9QyoAc = value;
		}
	}

	public static List<SettingItem> DefaultSettings
	{
get
		{
			return new List<SettingItem>
			{
				new SettingItem
				{
					Key = null,
					DisplayName = "ControlButtonBackground5C",
					Category = "\" Duration=\"0:0:0.10\"/>\n                           ",
					ToolTip = "堉翼Theme_IconTextForeground堉翼Theme_Button",
					Value = false
				},
				new SettingItem
				{
					Key = null,
					DisplayName = null,
					Category = null,
					ToolTip = null,
					Value = true
				},
				new SettingItem
				{
					Key = null,
					DisplayName = "WorkSans",
					Category = "window.SetText(",
					ToolTip = "堉翼Theme_ControlButtonForeground堉翼Theme_",
					Value = true
				},
				new SettingItem
				{
					Key = null,
					DisplayName = "InvokeStub_eYAtRttqqCWupA",
					Category = "Redirect Errors",
					ToolTip = null,
					Value = true
				},
				new SettingItem
				{
					Key = null,
					DisplayName = null,
					Category = null,
					ToolTip = null,
					Value = false
				},
				new SettingItem
				{
					Key = "#e2e2e2",
					DisplayName = "','",
					Category = null,
					ToolTip = null,
					Value = true
				},
				new SettingItem
				{
					Key = "ProgressBarBa",
					DisplayName = null,
					Category = "window.SetText(\"\")",
					ToolTip = null,
					Value = true
				},
				new SettingItem
				{
					Key = "game",
					DisplayName = null,
					Category = null,
					ToolTip = null,
					Value = false
				},
				new SettingItem
				{
					Key = null,
					DisplayName = null,
					Category = ".exe",
					ToolTip = null,
					Value = false
				},
				new SettingItem
				{
					Key = "HorizontalOffset",
					DisplayName = null,
					Category = null,
					ToolTip = "IconHoverBrush",
					Value = false
				},
				new SettingItem
				{
					Key = null,
					DisplayName = "Downloading files...",
					Category = "㛠塻翼ﰀ㾉Ȍ堉翼iMahApps.Metro.IconPacks.MaterialDesign, Version=6.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a㛠塻翼ﴘ㾉Ȍ堉翼hMahApps.Metro.IconPacks.MaterialLight, Version=6.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915",
					ToolTip = null,
					Value = false
				},
				new SettingItem
				{
					Key = "TabInactiveText'Tab",
					DisplayName = "ButtonBackground7ButtonBac",
					Category = "bin\\tabs.json",
					ToolTip = null,
					Value = false
				},
				new SettingItem
				{
					Key = null,
					DisplayName = null,
					Category = null,
					ToolTip = "()",
					Value = false
				}
			};
		}
	}

	public event Action<string, bool>? SettingChanged
	{
[CompilerGenerated]
		add
		{
			Action<string, bool> action = H83eQicO1;
			Action<string, bool> action2;
			do
			{
				action2 = action;
				Action<string, bool> value2 = (Action<string, bool>)null;
				action = Interlocked.CompareExchange(ref H83eQicO1, value2, action2);
			}
			while ((object)action != action2);
		}
[CompilerGenerated]
		remove
		{
			Action<string, bool> action = H83eQicO1;
			Action<string, bool> action2;
			do
			{
				action2 = action;
				Action<string, bool> value2 = (Action<string, bool>)null;
				action = Interlocked.CompareExchange(ref H83eQicO1, value2, action2);
			}
			while ((object)action != action2);
		}
	}
public Settings()
	{
		InitializeComponent();
				F5qjuOCHP60aRRQqkSE(ScrollViewer, 40.0, 0.2);
	}

public bool GetSettingValue(string key)
	{
		int num = 1;
		_c__DisplayClass13_0 _c__DisplayClass13_ = default(_c__DisplayClass13_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					_c__DisplayClass13_.HK57TDivvv = key;
					num2 = 1;					continue;
				case 1:
					_c__DisplayClass13_ = new _c__DisplayClass13_0();
					num2 = 0;					continue;
				case 2:
				{
					SettingItem? settingItem = SettingsList.FirstOrDefault(_c__DisplayClass13_.sOj7JtYm5K);
					if (settingItem != null)
					{
						return settingItem.Value;
					}
					break;
				}
				case 3:
					return false;
				}
				break;
			}
			num = 3;
		}
	}

	// [DEOBFUSCATED] Control flow flattening detected (initial state: 1)
public string GetSettingValueString(string key)
	{
	int num = 1;
	int num2 = num;
	while (true)
	{
	switch (num2)
			{
			case 2:
				return (string)FlmbmpCno1t5tT1VApG(0x3A2A7664 ^ 0);
			default:
				return (string)FlmbmpCno1t5tT1VApG(0x600E1F44 ^ 0);
			case 1:
				if (GetSettingValue(key))
				{
					num2 = 0;					break;
				}
				goto case 2;
			}
		}
	}
public JObject GetSnapshot()
	{
		int num = 3;
		int num2 = num;
		List<SettingItem>.Enumerator enumerator = default(List<SettingItem>.Enumerator);
		SettingItem current = default(SettingItem);
		JObject jObject = default(JObject);
		while (true)
		{
			switch (num2)
			{
			case 1:
				try
				{
					while (true)
					{
						IL_0120:
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 6;
							goto IL_0064;
						}
						goto IL_00df;
						IL_0064:
						while (true)
						{
							object obj;
							switch (num3)
							{
							case 1:
								obj = null;
								goto IL_013d;
							case 4:
								if (current == null)
								{
									num3 = 1;									continue;
								}
								obj = current.Key;
								goto IL_013d;
							case 3:
								num3 = 2;
								continue;
							case 2:
							case 5:
								goto IL_0120;
							case 6:
								goto end_IL_0120;
								IL_013d:
								if (false)
								{
									int num4 = 5;
									num3 = num4;
									continue;
								}
								goto case 3;
							}
							break;
						}
						goto IL_00df;
						IL_00df:
						current = enumerator.Current;
						num3 = 4;
						goto IL_0064;
						continue;
						end_IL_0120:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
					int num5 = 0;					switch (num5)
					{
					case 0:
						break;
					}
				}
				goto case 4;
			case 2:
				if (SettingsList != null)
				{
					num2 = 2;					break;
				}
				goto default;
			case 4:
				return jObject;
			default:
				return jObject;
			case 5:
				enumerator = SettingsList.GetEnumerator();
				num2 = 1;				break;
			case 3:
				jObject = new JObject();
				num2 = 2;
				break;
			}
		}
	}
private void vNVvwiVHC()
	{
		int num = 6;
		int num2 = num;
		List<SettingItem>.Enumerator enumerator = default(List<SettingItem>.Enumerator);
		SettingItem current = default(SettingItem);
		bool value = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 1:
				qW5UaYYmM = false;
				num2 = 2;
				break;
			case 5:
				SettingsList = DefaultSettings.ToList();
				num2 = 3;
				break;
			case 6:
				qW5UaYYmM = true;
				num2 = 5;
				break;
			case 4:
				return;
			default:
				try
				{
					Dictionary<string, bool> dictionary = JsonSerializer.Deserialize<Dictionary<string, bool>>((string?)null);
					int num3 = 3;
					while (true)
					{
						switch (num3)
						{
						case 4:
							enumerator = SettingsList.GetEnumerator();
							num3 = 1;							continue;
						case 2:
							break;
						case 1:
							try
							{
								while (true)
								{
									IL_01c1:
									int num4;
									if (!enumerator.MoveNext())
									{
										num4 = 4;
										goto IL_0140;
									}
									goto IL_0171;
									IL_0140:
									while (true)
									{
										switch (num4)
										{
										case 3:
											break;
										case 2:
											SRn2y1CoAQ0emYWNido(current, value);
											num4 = 0;											continue;
										default:
											goto IL_01c1;
										case 5:
											if (!dictionary.TryGetValue((string)ztJqSFC2ime3bJSP66C(current), out value))
											{
												num4 = 0;												continue;
											}
											goto case 2;
										case 4:
											goto end_IL_01c1;
										}
										break;
									}
									goto IL_0171;
									IL_0171:
									current = enumerator.Current;
									num4 = 1;									goto IL_0140;
									continue;
									end_IL_01c1:
									break;
								}
							}
							finally
							{
								((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
								int num5 = 0;								switch (num5)
								{
								case 0:
									break;
								}
							}
							break;
						case 3:
							if (dictionary == null)
							{
								num3 = 2;
								continue;
							}
							goto case 4;
						case 0:
							break;
						}
						break;
					}
				}
				catch
				{
					int num6 = 0;					switch (num6)
					{
					case 0:
						break;
					}
				}
				goto case 1;
			case 2:
				nut0ZDugL();
				num2 = 0;				break;
			case 3:
				if (false)
				{
					num2 = 0;					break;
				}
				goto case 1;
			}
		}
	}

	// [DEOBFUSCATED] Control flow flattening detected (initial state: 4)
private void nut0ZDugL()
	{
	int num = 4;
	int num2 = num;
	while (true)
	{
	switch (num2)
			{
			case 1:
				return;
			case 3:
				return;
			case 5:
				try
				{
					Dictionary<string, bool> value = SettingsList.ToDictionary(
(SettingItem s) => (string)_c.SWkPyIszDM89p2cg9j4(s),
(SettingItem s) => _c.o0eidv8PdE3yVmpibl3(s));
					JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions();
					string text = JsonSerializer.Serialize(value, jsonSerializerOptions);
					int num3 = 0;					while (true)
					{
						switch (num3)
						{
						case 1:
							return;
						}
						num3 = 1;					}
				}
				catch (Exception ex)
				{
					int num4 = 0;					while (true)
					{
						switch (num4)
						{
						default:
							return;
						case 1:
							num4 = 0;							break;
						case 0:
							return;
						}
					}
				}
			default:
				if (SettingsList != null)
				{
					num2 = 3;				}
				else
				{
					num2 = 0;				}
				break;
			case 4:
				if (qW5UaYYmM)
				{
					num2 = 3;
					break;
				}
				goto default;
			case 2:
				return;
			}
		}
	}
private void qFxNv8ArA()
	{
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0428: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bb: Expected O, but got Unknown
		//IL_04bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d0: Expected O, but got Unknown
		//IL_04d2: Expected O, but got Unknown
		//IL_05a9: Unknown result type (might be due to invalid IL or missing references)
		int num = 2;
		int num2 = num;
		StackPanel stackPanel = default(StackPanel);
		List<SettingItem>.Enumerator enumerator = default(List<SettingItem>.Enumerator);
		string text = default(string);
		_c__DisplayClass18_0 _c__DisplayClass18_ = default(_c__DisplayClass18_0);
		PackIconFontAwesomeKind val2 = default(PackIconFontAwesomeKind);
		PackIconFontAwesome val4 = default(PackIconFontAwesome);
		StackPanel stackPanel3 = default(StackPanel);
		Border border = default(Border);
		CheckBox checkBox = default(CheckBox);
		Viewbox viewbox2 = default(Viewbox);
		PackIconFontAwesome val = default(PackIconFontAwesome);
		TextBlock textBlock = default(TextBlock);
		while (true)
		{
			switch (num2)
			{
			case 2:
			{
				StackPanel stackPanel2 = new StackPanel();
				stackPanel = stackPanel2;
				num2 = 0;				break;
			}
			default:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 34;
							goto IL_00be;
						}
						goto IL_06c9;
						IL_00be:
						while (true)
						{
							switch (num3)
							{
							case 22:
								text = (string)g6dqAhCVCRJCTTrHelD(_c__DisplayClass18_.PhO7LXKTWg);
								num3 = 26;
								continue;
							case 1:
							case 9:
								val2 = (PackIconFontAwesomeKind)413;
								num3 = 2;
								continue;
							case 2:
							case 5:
							case 11:
							case 17:
								num3 = 13;
								continue;
							case 28:
							{
								StackPanel stackPanel4 = new StackPanel();
								stackPanel3 = stackPanel4;
								num3 = 18;
								continue;
							}
							case 26:
							{
								Border border2 = new Border();
								border = border2;
								int num4 = 28;
								num3 = num4;
								continue;
							}
							case 10:
								num3 = 11;								continue;
							case 4:
								val2 = (PackIconFontAwesomeKind)1836;
								num3 = 5;								continue;
							case 21:
								break;
							case 16:
								num3 = 19;								continue;
							case 30:
								num3 = 14;								continue;
							case 13:
								num3 = 27;
								continue;
							case 7:
								num3 = 10;
								continue;
							case 29:
								if (true)
								{
									num3 = 9;
									continue;
								}
								goto case 4;
							case 24:
								if (true)
								{
									num3 = 14;
									continue;
								}
								goto case 22;
							case 8:
								val2 = (PackIconFontAwesomeKind)463;
								num3 = 11;
								continue;
							case 32:
								val4 = val;
								num3 = 31;								continue;
							case 31:
								if (true)
								{
									num3 = 10;									continue;
								}
								goto case 8;
							case 33:
							{
								PackIconFontAwesome val3 = new PackIconFontAwesome();
								val = val3;
								num3 = 0;								continue;
							}
							case 3:
								_c__DisplayClass18_.du77upfH2V = this;
								num3 = 0;								continue;
							case 14:
							case 23:
							{
								CheckBox checkBox2 = new CheckBox();
								checkBox = checkBox2;
								num3 = 30;
								continue;
							}
							case 35:
								val2 = (PackIconFontAwesomeKind)856;
								num3 = 3;								continue;
							default:
								_c__DisplayClass18_.PhO7LXKTWg = enumerator.Current;
								num3 = 13;								continue;
							case 6:
							{
								TextBlock textBlock2 = new TextBlock();
								textBlock = textBlock2;
								num3 = 7;
								continue;
							}
							case 20:
								if (true)
								{
									num3 = 4;									continue;
								}
								goto case 35;
							case 15:
								goto IL_06c9;
							case 27:
								num3 = 1;								continue;
							case 12:
								num3 = 21;
								continue;
							case 19:
								num3 = 12;
								continue;
							case 18:
							{
								Viewbox viewbox = new Viewbox();
								viewbox2 = viewbox;
								num3 = 33;								continue;
							}
							case 25:
								num3 = 23;								continue;
							case 34:
								goto end_IL_02e3;
							}
							break;
						}
						continue;
						IL_06c9:
						_c__DisplayClass18_ = new _c__DisplayClass18_0();
						num3 = 1;						goto IL_00be;
						continue;
						end_IL_02e3:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
					int num5 = 0;					switch (num5)
					{
					case 0:
						break;
					}
				}
				goto case 3;
			case 1:
				text = null;
				num2 = 5;				break;
			case 3:
				num2 = 4;
				break;
			case 5:
				enumerator = SettingsList.GetEnumerator();
				num2 = 0;				break;
			case 4:
				return;
			}
		}
	}
/* InitializeComponent provided by .g.cs */
/* IComponentConnector\.Connect removed */
static Settings()
	{
		u4Ho54CGVUv6VrodeKK();
	}
internal static void F5qjuOCHP60aRRQqkSE(object P_0, double step, double smoothing)
	{
		SmoothScroll.Attach((ScrollViewer)P_0, step, smoothing);
	}
internal static bool lBQyWHCfXd4i3G167eF()
	{
		return drBjiACuc4tZEI5mtMN == null;
	}
internal static Settings v6AMpGClpXCUHaOn1rR()
	{
		return drBjiACuc4tZEI5mtMN;
	}
internal static object FlmbmpCno1t5tT1VApG(int P_0)
	{
		return null;
	}
internal static object ztJqSFC2ime3bJSP66C(object P_0)
	{
		return ((SettingItem)P_0).Key;
	}
internal static void SRn2y1CoAQ0emYWNido(object P_0, bool value)
	{
		((SettingItem)P_0).Value = value;
	}
internal static object g6dqAhCVCRJCTTrHelD(object P_0)
	{
		return ((SettingItem)P_0).Category;
	}
internal static object KiBYjqCciDGxpS6dtZW(object P_0)
	{
		return ((SettingItem)P_0).DisplayName;
	}
internal static object VBxsPNCmLebk5O84GcU(object P_0)
	{
		return ((SettingItem)P_0).ToolTip;
	}
internal static bool gD0JYECZ8yrkqCb820Y(object P_0)
	{
		return ((SettingItem)P_0).Value;
	}
internal static void u4Ho54CGVUv6VrodeKK()
	{
		}

private void SettingChanged_Handler(object sender, RoutedEventArgs e)
	{
		try
		{
			if (sender is System.Windows.Controls.CheckBox toggle)
			{
				string key = toggle.Name;
				bool value = toggle.IsChecked == true;
				H83eQicO1?.Invoke(key, value);
			}
			else if (sender is System.Windows.Controls.ComboBox combo)
			{
				string key = combo.Name;
				var item = combo.SelectedItem as System.Windows.Controls.ComboBoxItem;
				if (item != null)
					H83eQicO1?.Invoke(key + "_index", combo.SelectedIndex == 1);
			}
		}
		catch { }
	}

private void OpenFolder_Click(object sender, RoutedEventArgs e)
	{
		try
		{
			string path = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Potassium");
			if (!System.IO.Directory.Exists(path))
				System.IO.Directory.CreateDirectory(path);
			Process.Start(new ProcessStartInfo { FileName = path, UseShellExecute = true });
		}
		catch { }
	}
}
