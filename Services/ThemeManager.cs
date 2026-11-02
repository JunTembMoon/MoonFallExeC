﻿﻿﻿﻿﻿﻿﻿﻿﻿﻿﻿﻿﻿using Border = System.Windows.Controls.Border;
using ScrollViewer = System.Windows.Controls.ScrollViewer;
using TextBox = System.Windows.Controls.TextBox;
using Timer = System.Timers.Timer;
using Button = System.Windows.Controls.Button;
using CheckBox = System.Windows.Controls.CheckBox;
using Popup = System.Windows.Controls.Primitives.Popup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Threading;
using TextBlock = System.Windows.Controls.TextBlock;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
namespace Potassium_UI_V2.Services;

public class ThemeManager
{
	private static readonly string iDh7DuVGOs;

	private static readonly Dictionary<string, ThemeDefinition> OaL77qOGFV;

	private static string l8w7Idgq6b;

	private static readonly Dictionary<string, DataTemplate?> o6A7tiLjTr;

	[CompilerGenerated]
	private static Action<ThemeDefinition>? lkC7g1ZGPx;

	public static readonly (string Category, string[] Keys)[] CategoryMap;

	private static ThemeManager KmAsSCOzc5WtMX0iJyi;

	public static IReadOnlyDictionary<string, ThemeDefinition> LoadedThemes
	{
get
		{
			return OaL77qOGFV;
		}
	}

	public static string CurrentThemeName
	{
get
		{
			return l8w7Idgq6b;
		}
	}

	public static event Action<ThemeDefinition>? ThemeChanged
	{
[CompilerGenerated]
		add
		{
			Action<ThemeDefinition> action = lkC7g1ZGPx;
			Action<ThemeDefinition> action2;
			do
			{
				action2 = action;
				Action<ThemeDefinition> value2 = (Action<ThemeDefinition>)null;
				action = Interlocked.CompareExchange(ref lkC7g1ZGPx, value2, action2);
			}
			while ((object)action != action2);
		}
[CompilerGenerated]
		remove
		{
			Action<ThemeDefinition> action = lkC7g1ZGPx;
			Action<ThemeDefinition> action2;
			do
			{
				action2 = action;
				Action<ThemeDefinition> value2 = (Action<ThemeDefinition>)null;
				action = Interlocked.CompareExchange(ref lkC7g1ZGPx, value2, action2);
			}
			while ((object)action != action2);
		}
	}

	// [DEOBFUSCATED] Control flow flattening detected (initial state: 2)
public static void Initialize()
{
	// NEC 字符串解密函数返回 null，跳过原始初始化逻辑
	// 主题颜色已在 App.xaml 中定义为资源
	try
	{
		if (OaL77qOGFV == null || OaL77qOGFV.Count == 0)
		{
			// 创建默认主题
			var defaultTheme = new ThemeDefinition();
			defaultTheme.Name = "Default";
			defaultTheme.EditorImage = "";
			defaultTheme.Categories = new Dictionary<string, Dictionary<string, string>>();
			OaL77qOGFV["Default"] = defaultTheme;
		}
		l8w7Idgq6b = "Default";
	}
	catch { }
}

	// [DEOBFUSCATED] Control flow flattening detected (initial state: 2)
private static void EyfDVy24c8()
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
			case 2:
				if (true)
				{
					num2 = 1;					break;
				}
				return;
			case 0:
				return;
			}
		}
	}
public static Dictionary<string, Dictionary<string, string>> CategorizeColors(Dictionary<string, string> flat)
	{
		Dictionary<string, Dictionary<string, string>> dictionary = new Dictionary<string, Dictionary<string, string>>();
		HashSet<string> hashSet = new HashSet<string>(flat.Keys);
		(string, string[])[] categoryMap = CategoryMap;
		for (int i = 0; i < categoryMap.Length; i++)
		{
			(string, string[]) tuple = categoryMap[i];
			string item = tuple.Item1;
			string[] item2 = tuple.Item2;
			Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
			string[] array = item2;
			foreach (string text in array)
			{
				if (flat.TryGetValue(text, out string value))
				{
					dictionary2[text] = value;
					hashSet.Remove(text);
				}
			}
			if (dictionary2.Count > 0)
			{
				dictionary[item] = dictionary2;
			}
		}
		if (hashSet.Count > 0)
		{
			Dictionary<string, string> dictionary3 = new Dictionary<string, string>();
			foreach (string item3 in hashSet)
			{
				dictionary3[item3] = flat[item3];
			}
			dictionary[string.Empty] = dictionary3;
		}
		return dictionary;
	}
private static ThemeDefinition? LY9Dc13M8j(object P_0)
	{
		int num = 2;
		int num2 = num;
		ThemeDefinition result = default(ThemeDefinition);
		JsonDocument jsonDocument = default(JsonDocument);
		JsonElement jsonElement7 = default(JsonElement);
		JsonElement.ObjectEnumerator objectEnumerator2 = default(JsonElement.ObjectEnumerator);
		ThemeDefinition themeDefinition = default(ThemeDefinition);
		Dictionary<string, string> dictionary = default(Dictionary<string, string>);
		JsonElement jsonElement5 = default(JsonElement);
		JsonElement jsonElement4 = default(JsonElement);
		JsonElement jsonElement2 = default(JsonElement);
		JsonElement.ObjectEnumerator enumerator = default(JsonElement.ObjectEnumerator);
		JsonElement jsonElement6 = default(JsonElement);
		JsonProperty jsonProperty = default(JsonProperty);
		JsonProperty jsonProperty3 = default(JsonProperty);
		Dictionary<string, string> dictionary3 = default(Dictionary<string, string>);
		JsonProperty jsonProperty2 = default(JsonProperty);
		JsonElement.ObjectEnumerator objectEnumerator = default(JsonElement.ObjectEnumerator);
		JsonElement jsonElement3 = default(JsonElement);
		while (true)
		{
			switch (num2)
			{
			default:
				return result;
			case 2:
				jsonDocument = null;
				num2 = 1;				break;
			case 1:
				try
				{
					JsonElement jsonElement = default;
					int num3 = 28;
					while (true)
					{
						switch (num3)
						{
						case 30:
							if (0 == JsonValueKind.Object)
							{
								num3 = 5;
								continue;
							}
							goto case 11;
						case 3:
							objectEnumerator2 = jsonElement7.EnumerateObject();
							num3 = 12;
							continue;
						case 10:
							themeDefinition.Categories = CategorizeColors(dictionary);
							num3 = 20;							continue;
						case 4:
							if (0 == JsonValueKind.Object)
							{
								num3 = 7;
								continue;
							}
							goto case 24;
						case 2:
						case 17:
							if (false)
							{
								num3 = 18;								continue;
							}
							goto case 23;
						case 15:
							if (0 == JsonValueKind.String)
							{
								num3 = 22;
								continue;
							}
							goto case 8;
						case 8:
						case 14:
						case 18:
							if (false)
							{
								num3 = 4;
								continue;
							}
							goto case 24;
						case 27:
							try
							{
								while (true)
								{
									IL_0309:
									int num4;
									if (true)
									{
										num4 = 4;
										goto IL_025c;
									}
									goto IL_02af;
									IL_025c:
									while (true)
									{
										switch (num4)
										{
										case 1:
											if (0 == JsonValueKind.String)
											{
												num4 = 3;												continue;
											}
											goto IL_0309;
										case 2:
											break;
										default:
										jsonElement6 = default;
										num4 = 0;											continue;
										case 5:
											goto IL_0309;
										case 3:
										{
											Dictionary<string, string> dictionary2 = dictionary;
											string key = null;
										jsonElement6 = default;
											dictionary2[key] = "";
											num4 = 5;											continue;
										}
										case 4:
											goto end_IL_0309;
										}
										break;
									}
									goto IL_02af;
									IL_02af:
									jsonProperty = default;
									num4 = 0;									goto IL_025c;
									continue;
									end_IL_0309:
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
							goto case 10;
						case 21:
							try
							{
								while (true)
								{
									IL_063d:
									int num6;
									if (true)
									{
										num6 = 10;
										goto IL_03de;
									}
									goto IL_0414;
									IL_03de:
									while (true)
									{
										switch (num6)
										{
										case 3:
											break;
										case 1:
											try
											{
												while (true)
												{
													IL_048f:
													int num7;
													if (true)
													{
														num7 = 1;														goto IL_0440;
													}
													goto IL_0462;
													IL_0462:
													jsonProperty3 = default;
													num7 = 0;													goto IL_0440;
													IL_0440:
													while (true)
													{
														switch (num7)
														{
														case 3:
															break;
														case 4:
															goto IL_048f;
														case 2:
															if (0 == JsonValueKind.String)
															{
																num7 = 2;																continue;
															}
															goto IL_048f;
														default:
										jsonElement6 = default;
										num7 = 2;															continue;
														case 5:
														{
															Dictionary<string, string> dictionary4 = dictionary3;
															string key2 = null;
										jsonElement6 = default;
															dictionary4[key2] = "";
															num7 = 4;
															continue;
														}
														case 1:
															goto end_IL_048f;
														}
														break;
													}
													goto IL_0462;
													continue;
													end_IL_048f:
													break;
												}
											}
											finally
											{
												((IDisposable)objectEnumerator2/*cast due to .constrained prefix*/).Dispose();
												int num8 = 0;												switch (num8)
												{
												case 0:
													break;
												}
											}
											goto case 9;
										case 2:
										jsonElement6 = default;
										num6 = 7;
											continue;
										case 9:
											themeDefinition.Categories[null] = dictionary3;
											num6 = 5;
											continue;
										case 4:
											objectEnumerator2 = objectEnumerator.GetEnumerator();
											num6 = 1;											continue;
										case 6:
											dictionary3 = new Dictionary<string, string>();
											num6 = 2;
											continue;
										case 5:
											goto IL_063d;
										default:
											if (0 == JsonValueKind.Object)
											{
												num6 = 6;												continue;
											}
											goto IL_063d;
										case 8:
										jsonElement6 = default;
										num6 = 0;											continue;
										case 7:
											objectEnumerator = jsonElement6.EnumerateObject();
											num6 = 4;
											continue;
										case 10:
											goto end_IL_063d;
										}
										break;
									}
									goto IL_0414;
									IL_0414:
									jsonProperty2 = default;
									num6 = 8;
									goto IL_03de;
									continue;
									end_IL_063d:
									break;
								}
							}
							finally
							{
								((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
								int num9 = 0;								switch (num9)
								{
								case 0:
									break;
								}
							}
							goto case 11;
						case 25:
							if (true)
							{
								num3 = 17;
								continue;
							}
							goto case 6;
						case 13:
							themeDefinition = new ThemeDefinition();
							num3 = 25;
							continue;
						case 11:
						case 20:
							result = themeDefinition;
							num3 = 0;							continue;
						case 5:
							dictionary = new Dictionary<string, string>();
							num3 = 3;
							continue;
						case 28:
							if (0 != JsonValueKind.Object)
							{
								num3 = 0;								continue;
							}
							goto case 13;
						case 12:
							enumerator = objectEnumerator2.GetEnumerator();
							num3 = 27;							continue;
						case 23:
							if (true)
							{
								num3 = 18;								continue;
							}
							goto case 15;
						default:
						{
							result = null;
							int num10 = 19;
							num3 = num10;
							continue;
						}
						case 19:
							break;
						case 9:
							enumerator = objectEnumerator2.GetEnumerator();
							num3 = 11;							continue;
						case 24:
							if (true)
							{
								num3 = 11;
								continue;
							}
							goto case 30;
						case 26:
							if (0 == JsonValueKind.String)
							{
								num3 = 4;								continue;
							}
							goto case 23;
						case 7:
							objectEnumerator2 = jsonElement5.EnumerateObject();
							num3 = 9;
							continue;
						case 6:
							if (0 == JsonValueKind.String)
							{
								num3 = 16;								continue;
							}
							goto case 2;
						case 16:
							oLjNHksRtbEC3diFkKQ(themeDefinition, null);
							num3 = 2;							continue;
						case 29:
							zEANVVshyvvyfRmqccX(themeDefinition, "");
							num3 = 8;							continue;
						case 22:
							zEANVVshyvvyfRmqccX(themeDefinition, "");
							num3 = 14;							continue;
						case 1:
							break;
						}
						break;
					}
				}
				finally
				{
					if (jsonDocument != null)
					{
						int num11 = 0;						while (true)
						{
							switch (num11)
							{
							default:
								num11 = 1;								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
				goto default;
			}
		}
	}
private static void FmuDm6CX3e()
	{
		int num = 10;
		int num3 = default(int);
		string[] array = default(string[]);
		ThemeDefinition themeDefinition2 = default(ThemeDefinition);
		string text = default(string);
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
				case 6:
					if (num3 < array.Length)
					{
						num2 = 3;
						continue;
					}
					goto case 5;
				case 9:
					goto end_IL_0019;
				case 1:
					OaL77qOGFV[(string)e3tCOPsgndDh6RALaFd(0x2EF4D45E ^ 0)] = themeDefinition2;
					num2 = 12;
					continue;
				case 7:
					num3++;
					num2 = 2;
					continue;
				case 12:
					dO7DQPQ3m8(themeDefinition2);
					num2 = 0;					continue;
				case 4:
					num3 = 0;
					num2 = 6;
					continue;
				case 8:
					try
					{
						ThemeDefinition themeDefinition = LY9Dc13M8j(null);
						int num4 = 5;
						while (true)
						{
							switch (num4)
							{
							case 2:
								OaL77qOGFV[themeDefinition.Name] = themeDefinition;
								num4 = 3;
								continue;
							case 1:
								break;
							case 0:
								break;
							case 4:
								if (false)
								{
									num4 = 1;									continue;
								}
								goto case 2;
							case 5:
								if (themeDefinition == null)
								{
									num4 = 0;									continue;
								}
								goto case 4;
							case 3:
								break;
							}
							break;
						}
					}
					catch
					{
						int num5 = 0;						switch (num5)
						{
						case 0:
							break;
						}
					}
					goto case 7;
				case 5:
					if (OaL77qOGFV.ContainsKey(null))
					{
						num2 = 11;
						continue;
					}
					break;
				case 11:
					return;
				case 3:
				case 13:
					text = array[num3];
					num2 = 8;
					continue;
				case 10:
					ar9tKGs4jqFQ7AI1ghc(OaL77qOGFV);
					num2 = 5;					continue;
				case 14:
					break;
				case 0:
					return;
				}
				themeDefinition2 = Br27WOucgw();
				num2 = 1;				continue;
				end_IL_0019:
				break;
			}
			array = null;
			num = 4;
		}
	}
public static void ReloadThemes()
	{
		YvmkFts7Vsgwyfef0or();
	}
public static List<string> GetThemeNames()
	{
		return OaL77qOGFV.Keys.OrderBy(
(string n) =>
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return n;
				default:
					return "";
				case 1:
					if (false)
					{
						num2 = 0;						break;
					}
					goto case 2;
				}
			}
		}).ToList();
	}
public static void ApplyTheme(string themeName)
	{
		// NEC 解密返回 null 时使用默认主题
		if (string.IsNullOrEmpty(themeName) || !OaL77qOGFV.ContainsKey(themeName))
		{
			themeName = "Default";
			if (!OaL77qOGFV.ContainsKey(themeName))
				return;
		}
		int num = 10;
		int num2 = num;
		Dictionary<string, string>.Enumerator enumerator = default(Dictionary<string, string>.Enumerator);
		ThemeDefinition themeDefinition = default(ThemeDefinition);
		ResourceDictionary resourceDictionary = default(ResourceDictionary);
		KeyValuePair<string, string> current = default(KeyValuePair<string, string>);
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 10:
				if (!OaL77qOGFV.ContainsKey(themeName))
				{
					num2 = 9;
					break;
				}
				goto case 7;
			case 8:
				enumerator = themeDefinition.Colors.GetEnumerator();
				num2 = 1;				break;
			case 3:
				resourceDictionary = null;
				num2 = 8;
				break;
			case 5:
				RebuildAnimatedStyles();
				num2 = 0;				break;
			default:
				rnpAnCsjdhb7scvSD6G(themeName);
				num2 = 2;
				break;
			case 7:
				themeDefinition = OaL77qOGFV[themeName];
				num2 = 6;
				break;
			case 6:
				l8w7Idgq6b = themeName;
				num2 = 3;
				break;
			case 9:
				themeName = (string)e3tCOPsgndDh6RALaFd(0x6D6BCFD2 ^ 0);
				num2 = 7;
				break;
			case 1:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 4;							goto IL_0165;
						}
						goto IL_0321;
						IL_0321:
						current = enumerator.Current;
						num3 = 1;						goto IL_0165;
						IL_0165:
						while (true)
						{
							switch (num3)
							{
							case 1:
								text = null;
								num3 = 3;
								continue;
							case 3:
								try
								{
									Color color = default(Color);
									int num4 = 2;									while (true)
									{
										switch (num4)
										{
										default:
											num4 = 1;											continue;
										case 2:
											num4 = 0;											continue;
										case 1:
											break;
										}
										break;
									}
								}
								catch
								{
									int num5 = 0;									switch (num5)
									{
									case 0:
										break;
									}
								}
								break;
							case 2:
								goto IL_0321;
							case 4:
								goto end_IL_01bb;
							}
							break;
						}
						continue;
						end_IL_01bb:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
					int num6 = 0;					switch (num6)
					{
					case 0:
						break;
					}
				}
				goto case 5;
			case 4:
				return;
			case 2:
			{
				Action<ThemeDefinition>? action = lkC7g1ZGPx;
				if (action == null)
				{
					num2 = 11;
					break;
				}
				action(themeDefinition);
				num2 = 4;				break;
			}
			case 11:
				return;
			}
		}
	}
public static ThemeDefinition? GetCurrentTheme()
	{
		return OaL77qOGFV.GetValueOrDefault(l8w7Idgq6b);
	}
public static Color GetColor(string colorKey)
	{
		int num = 1;
		int num2 = num;
		string value = default(string);
		ThemeDefinition themeDefinition = default(ThemeDefinition);
		while (true)
		{
			switch (num2)
			{
			case 4:
			{
				Color result;
				try
				{
					result = default(Color);
					int num3 = 0;					switch (num3)
					{
					case 0:
						break;
					}
				}
				catch
				{
					int num4 = 0;					switch (num4)
					{
					}
					goto case 3;
				}
				return result;
			}
			case 2:
				if (themeDefinition.Colors.TryGetValue(colorKey, out value))
				{
					num2 = 4;
					break;
				}
				goto case 3;
			default:
				if (themeDefinition != null)
				{
					num2 = 2;					break;
				}
				goto case 3;
			case 3:
				return default;
			case 1:
				themeDefinition = (ThemeDefinition)lctgScs6LmCWjwiqxUc();
				num2 = 0;				break;
			}
		}
	}

	// [DEOBFUSCATED] Control flow flattening detected (initial state: 4)
private static void aDwDZQLrrJ()
	{
	int num = 4;
	int num2 = num;
	while (true)
	{
	switch (num2)
			{
			default:
				l8w7Idgq6b = (string)e3tCOPsgndDh6RALaFd(0x268AF076 ^ 0);
				num2 = 1;				break;
			case 2:
				return;
			case 1:
				return;
			case 4:
				try
				{
					l8w7Idgq6b = (string)zxWeO5srx2ZFTaPAAex();
					int num3 = 0;					switch (num3)
					{
					case 0:
						break;
					}
				}
				catch
				{
					int num4 = 0;					while (true)
					{
						switch (num4)
						{
						default:
							l8w7Idgq6b = (string)e3tCOPsgndDh6RALaFd(0x223B2D67 ^ 0);
							num4 = 1;							continue;
						case 1:
							break;
						}
						break;
					}
				}
				goto case 3;
			case 3:
				if (OaL77qOGFV.ContainsKey(l8w7Idgq6b))
				{
					num2 = 2;
					break;
				}
				goto default;
			}
		}
	}
private static void i8QDGB6feH(object P_0)
	{
		switch (1)
		{
		case 0:
			break;
		case 1:
			try
			{
				B8gpe7sdxUEHRMBBX61(P_0);
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
		}
	}
private static void dO7DQPQ3m8(object P_0)
	{
		switch (1)
		{
		case 1:
			try
			{
				string text = null;
				int num = 1;				while (true)
				{
					switch (num)
					{
					default:
						return;
					case 1:
					{
						string text2 = null;
						JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions();
						string text3 = JsonSerializer.Serialize((ThemeDefinition)P_0, jsonSerializerOptions);
						num = 0;						break;
					}
					case 0:
						return;
					}
				}
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
private static string Yi3DbIWgvA(object P_0)
	{
		int num = 1;
		int num2 = num;
		object obj;
		while (true)
		{
			switch (num2)
			{
			case 1:
			{
				object obj2 = lctgScs6LmCWjwiqxUc();
				if (obj2 == null)
				{
					num2 = 0;					continue;
				}
				obj = ((ThemeDefinition)obj2).Colors.GetValueOrDefault((string)P_0, (string)e3tCOPsgndDh6RALaFd(0x4B795711 ^ 0));
				goto IL_0086;
			}
			default:
				obj = null;
				goto IL_0086;
			case 2:
				{
					obj = null;
					break;
				}
				IL_0086:
				if (obj != null)
				{
					break;
				}
				num2 = 2;				continue;
			}
			break;
		}
		return (string)obj;
	}
private static void CgfD3Kqlai()
	{
		int num = 13;
		int num5 = default(int);
		string[] array = default(string[]);
		string text = default(string);
		DataTemplate value = default(DataTemplate);
		Style style = default(Style);
		IEnumerator<SetterBase> enumerator = default(IEnumerator<SetterBase>);
		ResourceDictionary resourceDictionary = default(ResourceDictionary);
		Setter setter = default(Setter);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
				case 14:
					if (num5 >= array.Length)
					{
						num2 = 9;
						continue;
					}
					goto case 7;
				case 8:
					o6A7tiLjTr[text] = value;
					num2 = 0;					continue;
				case 11:
					if (style == null)
					{
						num2 = 4;
						continue;
					}
					break;
				case 10:
					enumerator = style.Setters.GetEnumerator();
					num2 = 1;					continue;
				case 2:
					num5 = 0;
					num2 = 3;					continue;
				case 15:
					array = new string[4]
					{
						(string)e3tCOPsgndDh6RALaFd(0x61951119 ^ 0),
						(string)e3tCOPsgndDh6RALaFd(0x4B7957C1 ^ 0),
						(string)e3tCOPsgndDh6RALaFd(0x61951153 ^ 0),
						(string)e3tCOPsgndDh6RALaFd(0x2431B82D ^ 0)
					};
					num2 = 2;
					continue;
				case 7:
					text = array[num5];
					num2 = 16;					continue;
				case 6:
					return;
				case 12:
					resourceDictionary = null;
					num2 = 15;
					continue;
				case 13:
					if (o6A7tiLjTr.Count > 0)
					{
						return;
					}
					num2 = 12;
					continue;
				default:
					num5++;
					num2 = 1;					continue;
				case 1:
					try
					{
						while (true)
						{
							IL_02ce:
							int num3;
							if (true)
							{
								num3 = 2;
								goto IL_0262;
							}
							goto IL_02b6;
							IL_0262:
							while (true)
							{
								switch (num3)
								{
								default:
									value = null as DataTemplate;
									num3 = 1;									continue;
								case 5:
									break;
								case 1:
									goto IL_02ce;
								case 3:
									goto end_IL_02ce;
								case 4:
									if (false)
									{
										num3 = 0;										continue;
									}
									goto IL_02ce;
								case 2:
									goto end_IL_02ce;
								}
								break;
							}
							goto IL_02b6;
							IL_02b6:
							setter = (Setter)enumerator.Current;
							num3 = 4;
							goto IL_0262;
							continue;
							end_IL_02ce:
							break;
						}
					}
					finally
					{
						if (enumerator != null)
						{
							int num4 = 0;							while (true)
							{
								switch (num4)
								{
								default:
									num4 = 1;									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
					goto case 8;
				case 9:
					return;
				case 16:
					style = null as Style;
					num2 = 11;
					continue;
				case 3:
					break;
				}
				break;
			}
			value = null;
			num = 10;
		}
	}
public static void RebuildAnimatedStyles()
	{
		switch (1)
		{
		case 0:
			break;
		case 1:
			try
			{
				IyrueqsiiceKnOpjRgN();
				int num = 0;				while (true)
				{
					switch (num)
					{
					case 1:
						return;
					}
					ResourceDictionary resourceDictionary = null;
					num = 1;				}
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
		}
	}
private static ControlTemplate dShDYaOZIT()
	{
		int num = 15;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(DefaultInterpolatedStringHandler);
		string text5 = default(string);
		string text3 = default(string);
		string text6 = default(string);
		string text2 = default(string);
		string text = default(string);
		string text4 = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 17:
					num2 = 6;
					continue;
				case 21:
					num2 = 10;
					continue;
				case 7:
					text3 = (string)x9db83saMmJhLetdtcr(e3tCOPsgndDh6RALaFd(0x13901068 ^ 0));
					num2 = 0;					continue;
				case 13:
					return (ControlTemplate)null;
				case 15:
					text6 = Yi3DbIWgvA(null);
					num2 = 14;
					continue;
				case 2:
					num2 = 1;					continue;
				case 5:
					text = (string)x9db83saMmJhLetdtcr(null);
					num2 = 8;					continue;
				case 16:
					num2 = 17;
					continue;
				case 10:
					num2 = 7;					continue;
				case 8:
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5691, 7);
					num = 9;
					break;
				case 9:
					num2 = 2;					continue;
				case 3:
					num2 = 1;					continue;
				case 1:
					num2 = 11;					continue;
				case 14:
					text5 = (string)x9db83saMmJhLetdtcr(e3tCOPsgndDh6RALaFd(0x55220D61 ^ 0));
					num2 = 7;
					continue;
				default:
					text4 = (string)x9db83saMmJhLetdtcr(e3tCOPsgndDh6RALaFd(0x3F2BD66 ^ 0));
					num2 = 18;					continue;
				case 6:
					num2 = 12;
					continue;
				case 4:
					num2 = 16;
					continue;
				case 19:
					num2 = 21;
					continue;
				case 22:
					num2 = 20;
					continue;
				case 20:
					num = 4;
					break;
				case 18:
					text2 = Yi3DbIWgvA(null);
					num2 = 5;					continue;
				case 11:
					num2 = 22;
					continue;
				case 12:
					num2 = 3;					continue;
				}
				break;
			}
		}
	}
private static Style a9JD53Qp9o()
	{
		int num = 10;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(DefaultInterpolatedStringHandler);
		string text4 = default(string);
		string text8 = default(string);
		string text6 = default(string);
		string text3 = default(string);
		DataTemplate valueOrDefault = default(DataTemplate);
		Style style = default(Style);
		string text = default(string);
		string text7 = default(string);
		string text5 = default(string);
		string text2 = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 13:
					num2 = 35;
					continue;
				case 10:
					text8 = (string)x9db83saMmJhLetdtcr(e3tCOPsgndDh6RALaFd(0x7D964432 ^ 0));
					num2 = 9;					continue;
				case 35:
					num2 = 37;
					continue;
				case 34:
					num2 = 7;					continue;
				case 30:
					text6 = (string)x9db83saMmJhLetdtcr(null);
					num2 = 33;
					continue;
				default:
					num2 = 15;
					continue;
				case 4:
					num2 = 13;					continue;
				case 20:
					text3 = (string)x9db83saMmJhLetdtcr(null);
					num2 = 31;
					continue;
				case 14:
					num2 = 29;
					continue;
				case 28:
					valueOrDefault = o6A7tiLjTr.GetValueOrDefault((string)e3tCOPsgndDh6RALaFd(0x155D11B3 ^ 0));
					num2 = 23;					continue;
				case 24:
					style = (Style)null;
					num2 = 28;
					continue;
				case 33:
					text = Yi3DbIWgvA(null);
					num2 = 6;					continue;
				case 6:
					num2 = 26;					continue;
				case 3:
				case 5:
					return style;
				case 31:
					break;
				case 15:
					num2 = 19;
					continue;
				case 26:
					num2 = 27;					continue;
				case 27:
					num2 = 7;
					continue;
				case 37:
					num2 = 14;
					continue;
				case 16:
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3986, 11);
					num2 = 0;					continue;
				case 36:
					text7 = (string)x9db83saMmJhLetdtcr(e3tCOPsgndDh6RALaFd(0x251333FE ^ 0));
					num2 = 20;					continue;
				case 21:
					text5 = (string)x9db83saMmJhLetdtcr(e3tCOPsgndDh6RALaFd(0x2431E97B ^ 0));
					num2 = 30;
					continue;
				case 32:
					num2 = 11;
					continue;
				case 2:
					style.Setters.Add(new Setter(ContentControl.ContentTemplateProperty, valueOrDefault));
					num2 = 5;					continue;
				case 22:
					num2 = 6;					continue;
				case 29:
					num2 = 34;
					continue;
				case 8:
					num2 = 18;					continue;
				case 19:
					num2 = 0;					continue;
				case 11:
					num2 = 6;					continue;
				case 18:
					num2 = 4;
					continue;
				case 1:
					num2 = 22;
					continue;
				case 17:
					num2 = 32;					continue;
				case 9:
					text2 = (string)x9db83saMmJhLetdtcr(e3tCOPsgndDh6RALaFd(0x3365389F ^ 0));
					num2 = 36;
					continue;
				case 25:
					num2 = 17;
					continue;
				case 7:
					num2 = 8;					continue;
				case 12:
					num2 = 25;
					continue;
				case 23:
					if (valueOrDefault == null)
					{
						num2 = 3;						continue;
					}
					goto case 2;
				}
				break;
			}
			text4 = Yi3DbIWgvA("\" Duration=\"0:0:0.25\">\n                                     ");
			num = 21;
		}
	}
private static Style FQEDzXQapu(object P_0, bool P_1)
	{
		int num = 13;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(DefaultInterpolatedStringHandler);
		string text2 = default(string);
		string text6 = default(string);
		Style style = default(Style);
		string text3 = default(string);
		string text4 = default(string);
		string text7 = default(string);
		string text9 = default(string);
		string text10 = default(string);
		string text = default(string);
		string text8 = default(string);
		DataTemplate valueOrDefault = default(DataTemplate);
		string text5 = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 1:
					num2 = 14;
					continue;
				case 12:
					text2 = (string)x9db83saMmJhLetdtcr(e3tCOPsgndDh6RALaFd(0x2D31C758 ^ 0));
					num2 = 6;					continue;
				case 28:
					num2 = 42;					continue;
				case 39:
					style = (Style)null;
					num2 = 34;					continue;
				case 23:
					num2 = 38;
					continue;
				case 15:
					text3 = (string)x9db83saMmJhLetdtcr(e3tCOPsgndDh6RALaFd(0x600E5584 ^ 0));
					num2 = 53;
					continue;
				case 43:
					num2 = 35;
					continue;
				case 10:
					num2 = 30;
					continue;
				default:
					num2 = 21;					continue;
				case 33:
					num2 = 40;
					continue;
				case 27:
				case 32:
					return style;
				case 11:
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(7271, 17);
					num2 = 26;					continue;
				case 13:
					text4 = (string)x9db83saMmJhLetdtcr(e3tCOPsgndDh6RALaFd(0x59CC9DB5 ^ 0));
					num2 = 12;
					continue;
				case 19:
					num2 = 17;
					continue;
				case 38:
					num2 = 0;					continue;
				case 18:
					if (P_1)
					{
						num2 = 1;						continue;
					}
					goto case 36;
				case 36:
					obj = "Enables smooth cursor movement.";
					goto IL_0a94;
				case 35:
					num2 = 10;
					continue;
				case 6:
					num2 = 20;					continue;
				case 7:
					num2 = 2;					continue;
				case 4:
					text10 = (string)x9db83saMmJhLetdtcr(null);
					num2 = 48;
					continue;
				case 17:
					num2 = 31;
					continue;
				case 20:
					num2 = 37;
					continue;
				case 41:
					text7 = (string)x9db83saMmJhLetdtcr("explorer.exe");
					num2 = 49;
					continue;
				case 24:
					num2 = 7;					continue;
				case 47:
					num2 = 19;
					continue;
				case 30:
					num2 = 7;					continue;
				case 53:
					text6 = (string)x9db83saMmJhLetdtcr(null);
					num = 4;
					break;
				case 45:
					num2 = 47;
					continue;
				case 9:
					num2 = 46;
					continue;
				case 42:
					num2 = 51;					continue;
				case 40:
					num2 = 21;					continue;
				case 49:
					text9 = (string)x9db83saMmJhLetdtcr("https://files.potassium.pro/Decompiler.exe");
					num2 = 15;
					continue;
				case 50:
					text8 = (string)x9db83saMmJhLetdtcr(e3tCOPsgndDh6RALaFd(0x139046DE ^ 0));
					num2 = 18;
					continue;
				case 34:
					valueOrDefault = o6A7tiLjTr.GetValueOrDefault((string)P_0);
					num2 = 2;
					continue;
				case 44:
					style.Setters.Add(new Setter(ContentControl.ContentTemplateProperty, valueOrDefault));
					num2 = 32;					continue;
				case 14:
					num2 = 52;
					continue;
				case 2:
					if (valueOrDefault == null)
					{
						num2 = 27;
						continue;
					}
					goto case 44;
				case 37:
					num = 5;
					break;
				case 51:
					num2 = 13;					continue;
				case 46:
					num = 33;
					break;
				case 29:
					num2 = 26;
					continue;
				case 21:
					num2 = 6;
					continue;
				case 22:
					num2 = 45;
					continue;
				case 5:
					num2 = 16;					continue;
				case 48:
					text5 = (string)x9db83saMmJhLetdtcr(null);
					num = 50;
					break;
				case 26:
					num2 = 23;
					continue;
				case 52:
					num2 = 42;					continue;
				case 3:
					num2 = 28;					continue;
				case 31:
					num2 = 39;					continue;
				case 25:
					num2 = 22;					continue;
				case 16:
					num2 = 1;					continue;
				case 8:
					{
						obj = e3tCOPsgndDh6RALaFd(0x3F2CBAA ^ 0);
						goto IL_0a94;
					}
					IL_0a94:
					text = (string)obj;
					num2 = 11;
					continue;
				}
				break;
			}
		}
	}
private static Style Hah7PegDmY()
	{
		int num = 12;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(DefaultInterpolatedStringHandler);
		string text5 = default(string);
		Style style = default(Style);
		string text3 = default(string);
		string text = default(string);
		string text4 = default(string);
		string text6 = default(string);
		string text2 = default(string);
		FontFamily fontFamily = default(FontFamily);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 13:
					num2 = 0;					continue;
				case 5:
					text5 = (string)x9db83saMmJhLetdtcr("\\");
					num2 = 25;
					continue;
				case 3:
					style = (Style)null;
					num2 = 10;
					continue;
				case 4:
					num2 = 19;
					continue;
				case 7:
					num2 = 4;
					continue;
				case 25:
					defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(3027, 7);
					num2 = 13;					continue;
				case 11:
					text = (string)x9db83saMmJhLetdtcr(null);
					num = 14;
					break;
				case 12:
					text3 = (string)x9db83saMmJhLetdtcr(null);
					num2 = 11;
					continue;
				case 2:
					num2 = 7;
					continue;
				case 9:
					num2 = 26;					continue;
				case 20:
					num2 = 3;					continue;
				case 1:
					num2 = 13;					continue;
				case 18:
					num2 = 6;
					continue;
				case 22:
					num2 = 2;
					continue;
				case 26:
					num2 = 22;					continue;
				case 15:
					text2 = (string)x9db83saMmJhLetdtcr(e3tCOPsgndDh6RALaFd(0x54524740 ^ 0));
					num2 = 5;
					continue;
				case 23:
					style.Setters.Add(new Setter(Control.FontFamilyProperty, fontFamily));
					num2 = 8;
					continue;
				case 14:
					text6 = (string)x9db83saMmJhLetdtcr(e3tCOPsgndDh6RALaFd(0x301E743D ^ 0));
					num2 = 16;
					continue;
				case 17:
					num2 = 24;					continue;
				case 21:
					if (fontFamily != null)
					{
						num2 = 23;
						continue;
					}
					goto case 8;
				case 8:
					return style;
				case 16:
					text4 = (string)x9db83saMmJhLetdtcr("WorkSa");
					num2 = 15;					continue;
				case 6:
					num2 = 9;					continue;
				default:
					num2 = 20;
					continue;
				case 10:
					fontFamily = null as FontFamily;
					num2 = 21;
					continue;
				case 19:
					num = 17;
					break;
				case 24:
					num2 = 0;					continue;
				}
				break;
			}
		}
	}
private static ThemeDefinition Br27WOucgw()
	{
		return new ThemeDefinition
		{
			Name = (string)e3tCOPsgndDh6RALaFd(0x1390161A ^ 0),
			EditorImage = "",
			Colors = new Dictionary<string, string>
			{
				[null] = (string)e3tCOPsgndDh6RALaFd(0x3A2AD2BE ^ 0),
				[(string)e3tCOPsgndDh6RALaFd(0x4B0F9DCB ^ 0)] = "result",
				[(string)e3tCOPsgndDh6RALaFd(0x6D6B70E0 ^ 0)] = (string)e3tCOPsgndDh6RALaFd(0x3365D46D ^ 0),
				["tabButtonTemplate"] = (string)e3tCOPsgndDh6RALaFd(0x7BF6C878 ^ 0),
				[(string)e3tCOPsgndDh6RALaFd(0x35FA6149 ^ 0)] = (string)e3tCOPsgndDh6RALaFd(0x6D6B7074 ^ 0),
				[(string)e3tCOPsgndDh6RALaFd(0x7D96A89C ^ 0)] = null,
				[(string)e3tCOPsgndDh6RALaFd(0x7D96A8B4 ^ 0)] = (string)e3tCOPsgndDh6RALaFd(0x3A4BD2ED ^ 0),
				[(string)e3tCOPsgndDh6RALaFd(0x3A4BD283 ^ 0)] = (string)e3tCOPsgndDh6RALaFd(0x2D31344A ^ 0),
				[(string)e3tCOPsgndDh6RALaFd(-1143266951 ^ -265362213 ^ 0)] = null,
				[null] = null,
				[(string)e3tCOPsgndDh6RALaFd(0xF2D72C1 ^ 0)] = (string)e3tCOPsgndDh6RALaFd(0x4B79E98F ^ 0),
				[(string)e3tCOPsgndDh6RALaFd(0x1CE19223 ^ 0)] = "Unknown",
				[(string)e3tCOPsgndDh6RALaFd(-1716077634 ^ -1096648450 ^ 0)] = (string)e3tCOPsgndDh6RALaFd(0xBC07B1E ^ 0),
				[(string)e3tCOPsgndDh6RALaFd(0x7BE951D5 ^ 0)] = (string)e3tCOPsgndDh6RALaFd(0x3F207C2 ^ 0),
				[(string)e3tCOPsgndDh6RALaFd(0x3A2A6A9E ^ 0)] = null,
				[(string)e3tCOPsgndDh6RALaFd(0x3A2AD106 ^ 0)] = (string)e3tCOPsgndDh6RALaFd(0x7E75F8C4 ^ 0),
				["if(typeof SetEditorColors==='function')SetEditorColors('"] = null,
				[null] = (string)e3tCOPsgndDh6RALaFd(0x4B79EB8D ^ 0),
				[(string)e3tCOPsgndDh6RALaFd(0x223B9085 ^ 0)] = (string)e3tCOPsgndDh6RALaFd(0x4BF5DBC6 ^ 0),
				[(string)e3tCOPsgndDh6RALaFd(0x78D58B0E ^ 0)] = (string)e3tCOPsgndDh6RALaFd(0x7D96B560 ^ 0),
				[(string)e3tCOPsgndDh6RALaFd(0xF2D83DF ^ 0)] = (string)e3tCOPsgndDh6RALaFd(0x7BF6D5C6 ^ 0),
				[(string)e3tCOPsgndDh6RALaFd(0x77679255 ^ 0)] = "image",
				[(string)e3tCOPsgndDh6RALaFd(0x2EF4A600 ^ 0)] = "Misc",
				[(string)e3tCOPsgndDh6RALaFd(0xBC0973C ^ 0)] = (string)e3tCOPsgndDh6RALaFd(0x155DAD75 ^ 0),
				[(string)e3tCOPsgndDh6RALaFd(1541710002 ^ 0x201287E0 ^ 0)] = (string)e3tCOPsgndDh6RALaFd(0x77675C63 ^ 0),
				[(string)e3tCOPsgndDh6RALaFd(0x3F2C996 ^ 0)] = (string)e3tCOPsgndDh6RALaFd(0x1390B472 ^ 0),
				[(string)e3tCOPsgndDh6RALaFd(0x343220DE ^ 0)] = null,
				[null] = (string)e3tCOPsgndDh6RALaFd(0x7BF6D568 ^ 0),
				[(string)e3tCOPsgndDh6RALaFd(0xBC09414 ^ 0)] = (string)e3tCOPsgndDh6RALaFd(0x7C9082ED ^ 0),
				[(string)e3tCOPsgndDh6RALaFd(0x5A4101AE ^ 0)] = (string)e3tCOPsgndDh6RALaFd(0x5522A991 ^ 0),
				[(string)e3tCOPsgndDh6RALaFd(0x223B7D73 ^ 0)] = "run",
				[(string)e3tCOPsgndDh6RALaFd(0x13904578 ^ 0)] = null,
				[(string)e3tCOPsgndDh6RALaFd(0x2EF4840C ^ 0)] = (string)e3tCOPsgndDh6RALaFd(0x12E9F8B8 ^ 0),
				[(string)e3tCOPsgndDh6RALaFd(0x59CC7283 ^ 0)] = (string)e3tCOPsgndDh6RALaFd(0x1BCA3723 ^ 0),
				[null] = (string)e3tCOPsgndDh6RALaFd(0x35FA7DE3 ^ 0),
				[(string)e3tCOPsgndDh6RALaFd(0x5A414E18 ^ 0)] = (string)e3tCOPsgndDh6RALaFd(0x2513C362 ^ 0),
				[(string)e3tCOPsgndDh6RALaFd(0x7E7558DC ^ 0)] = (string)e3tCOPsgndDh6RALaFd(0x28045CFA ^ 0),
				[(string)e3tCOPsgndDh6RALaFd(0x5522A85B ^ 0)] = (string)e3tCOPsgndDh6RALaFd(0x7D96B4D2 ^ 0),
				[(string)e3tCOPsgndDh6RALaFd(0x552216A5 ^ 0)] = (string)e3tCOPsgndDh6RALaFd(0x4E0ACA5C ^ 0),
				[(string)e3tCOPsgndDh6RALaFd(0x1CE1336D ^ 0)] = (string)e3tCOPsgndDh6RALaFd(0x665AF68 ^ 0),
				["ScriptFileButtonStyle"] = (string)e3tCOPsgndDh6RALaFd(0x6195B35B ^ 0),
				[(string)e3tCOPsgndDh6RALaFd(0x4B0F3EEF ^ 0)] = (string)e3tCOPsgndDh6RALaFd(0x665AFD2 ^ 0),
				[(string)e3tCOPsgndDh6RALaFd(0x7D960AF2 ^ 0)] = (string)e3tCOPsgndDh6RALaFd(0x4B0F80DF ^ 0),
				["/Potassium;component/views/mainwindow/scriptsfolder.xaml"] = (string)e3tCOPsgndDh6RALaFd(0x35FA7DE3 ^ 0),
				[(string)e3tCOPsgndDh6RALaFd(0x663F0B84 ^ 0)] = "image",
				[(string)e3tCOPsgndDh6RALaFd(0x3A2ACC62 ^ 0)] = (string)e3tCOPsgndDh6RALaFd(0x3432F222 ^ 0),
				[(string)e3tCOPsgndDh6RALaFd(0x16338145 ^ 0)] = "System.ComponentModel.TypeConverter, Version=8.0.0.",
				[null] = "Theme_]_Color _\n.jsonb#FF808080^Button",
				["\\\\"] = (string)e3tCOPsgndDh6RALaFd(0x35515179 ^ 0),
				[null] = "\" Duration=\"0:0:0.10\"/>\n                            ",
				[(string)e3tCOPsgndDh6RALaFd(0x4B79F74F ^ 0)] = (string)e3tCOPsgndDh6RALaFd(0x7EE11827 ^ 0),
				[null] = (string)e3tCOPsgndDh6RALaFd(0x1390B760 ^ 0),
				[(string)e3tCOPsgndDh6RALaFd(0x3A4BCFB7 ^ 0)] = (string)e3tCOPsgndDh6RALaFd(0x7D96B6C4 ^ 0),
				["null"] = (string)e3tCOPsgndDh6RALaFd(0x155DB187 ^ 0),
				[null] = (string)e3tCOPsgndDh6RALaFd(0x6D6B6E3A ^ 0),
				[null] = (string)e3tCOPsgndDh6RALaFd(0x2FFA5E7F ^ 0),
				[(string)e3tCOPsgndDh6RALaFd(0x2D318CE4 ^ 0)] = (string)e3tCOPsgndDh6RALaFd(0x7E75E3AA ^ 0),
				[(string)e3tCOPsgndDh6RALaFd(0x23A65BF3 ^ 0)] = null,
				[(string)e3tCOPsgndDh6RALaFd(0x7BE951F3 ^ 0)] = (string)e3tCOPsgndDh6RALaFd(0x59CC764B ^ 0),
				[(string)e3tCOPsgndDh6RALaFd(0x7C908673 ^ 0)] = (string)e3tCOPsgndDh6RALaFd(0x268C2022 ^ 0),
				[(string)e3tCOPsgndDh6RALaFd(0x7BF66E50 ^ 0)] = (string)e3tCOPsgndDh6RALaFd(0x155DB65B ^ 0),
				[(string)e3tCOPsgndDh6RALaFd(0x4E0A6D7C ^ 0)] = (string)e3tCOPsgndDh6RALaFd(0x5A41F408 ^ 0),
				[(string)e3tCOPsgndDh6RALaFd(0x7E75E338 ^ 0)] = (string)e3tCOPsgndDh6RALaFd(0xF2D6895 ^ 0),
				[(string)e3tCOPsgndDh6RALaFd(0x4E0AF2C2 ^ 0)] = (string)e3tCOPsgndDh6RALaFd(0x2714DC96 ^ 0),
				[(string)e3tCOPsgndDh6RALaFd(0x6658AA2 ^ 0)] = (string)e3tCOPsgndDh6RALaFd(0x1390B052 ^ 0),
				["RoundedButtonBackgroundERoundedBu"] = null,
				[(string)e3tCOPsgndDh6RALaFd(0x3A4BC821 ^ 0)] = (string)e3tCOPsgndDh6RALaFd(0x3A2ACAA6 ^ 0),
				["TabShadowT"] = (string)e3tCOPsgndDh6RALaFd(0x4BF5DEE4 ^ 0),
				[(string)e3tCOPsgndDh6RALaFd(0x355156D5 ^ 0)] = (string)e3tCOPsgndDh6RALaFd(0x3D1CBC13 ^ 0),
				["\" Duration=\"0:0:0.15\">\n                                    "] = (string)e3tCOPsgndDh6RALaFd(0x78D567B4 ^ 0),
				[(string)e3tCOPsgndDh6RALaFd(0x4B79F1EF ^ 0)] = (string)e3tCOPsgndDh6RALaFd(0x155DB781 ^ 0),
				[(string)e3tCOPsgndDh6RALaFd(0x7EE100F5 ^ 0)] = (string)e3tCOPsgndDh6RALaFd(0x1390A952 ^ 0),
				[null] = (string)e3tCOPsgndDh6RALaFd(0x2EF46BF8 ^ 0),
				[(string)e3tCOPsgndDh6RALaFd(0xBC0639A ^ 0)] = null,
				[(string)e3tCOPsgndDh6RALaFd(0x4E0AD0D8 ^ 0)] = (string)e3tCOPsgndDh6RALaFd(0x7D96B3C0 ^ 0),
				[(string)e3tCOPsgndDh6RALaFd(0x776744D7 ^ 0)] = (string)e3tCOPsgndDh6RALaFd(0x1BCA30E1 ^ 0),
				[(string)e3tCOPsgndDh6RALaFd(0x3432F6AE ^ 0)] = (string)e3tCOPsgndDh6RALaFd(0x301E57FF ^ 0)
			}
		};
	}
static ThemeManager()
{
	l8w7Idgq6b = "Default";
	iDh7DuVGOs = null;
	OaL77qOGFV = new Dictionary<string, ThemeDefinition>();
	o6A7tiLjTr = new Dictionary<string, DataTemplate>();
	CategoryMap = new(string, string[])[5]
	{
		("Editor", new string[23]
		{
			"Theme_WindowBackground", null, null, "https://scriptblox.com/api/script/search?q=",
			"Theme_PageBackground", null, "Theme_ContentBackground", "Theme_InputBackground",
			"Theme_TitleBarBackground", "Theme_DialogBackground", null, "Theme_PrimaryText",
			"Theme_TitleText", "Theme_SecondaryText", "Theme_Border", "Theme_DialogBorder",
			"Theme_Accent", "Theme_AccentHover", "Theme_ButtonBackground", "Theme_ButtonHover",
			"Theme_ButtonForeground", null, ".lua"
		}),
		(null, new string[20]
		{
			"Theme_ConsoleBackground", "Theme_ConsoleText", "Theme_ConsoleInputBorder",
			"Theme_ConsoleInputBackground", null, "Theme_TabBarBackground", "Theme_TabBarBorder",
			"()", "Theme_TabInactive", "Theme_TabHover", "Theme_TabActive",
			"Theme_ScriptsFolderBackground", "Theme_SearchBackground", "Theme_SearchIcon",
			null, ".webp", "Theme_ProgressBarBackground", "Theme_LoadingOverlay",
			"Theme_LoginOverlay", "Theme_IconTextForeground"
		}),
		("Settings", new string[21]
		{
			"Setting_EditorFontSize", "Setting_EditorFontFamily", "Setting_EditorTabSize",
			"Setting_EditorWordWrap", null, "/Potassium;component/views/settings/settings.xaml",
			"Setting_MinimapEnabled", "Setting_AutoIndent", "Setting_LineNumbers",
			"Setting_CodeCompletion", "Setting_BracketMatching", "Setting_HighlightActiveLine",
			"Setting_Theme", "Setting_Language", null, "Setting_WebSocketPort",
			"Setting_AutoAttach", "Setting_AutoInject", "Setting_TopMost",
			"Setting_Transparency", "Setting_AutoUpdate"
		}),
		("Injector", new string[9]
		{
			"Injector_ProcessName", "Injector_DLLPath", "Injector_InjectionMethod",
			null, "Injector_AutoInject", null, "pid", "Injector_Level", "Injector_Status"
		}),
		(null, new string[4]
		{
			"ScriptHub_SearchPlaceholder", "ScriptHub_NoResults", "ScriptHub_Loading",
			"ScriptHub_Error"
		})
	};
}
internal static void dy3ANSsDh7PpI4DdRio()
	{
		EyfDVy24c8();
	}
internal static void YvmkFts7Vsgwyfef0or()
	{
		FmuDm6CX3e();
	}
internal static void ixyGEjsIKvk1vFp75OA()
	{
		aDwDZQLrrJ();
	}
internal static void nCBwYcstp14lyxQlE2l(object P_0)
	{
		ApplyTheme((string)P_0);
	}
internal static bool OLD9OysP0BdoBuEgfAy()
	{
		return KmAsSCOzc5WtMX0iJyi == null;
	}
internal static ThemeManager wXnVs2sWofLWGPA7IW6()
	{
		return KmAsSCOzc5WtMX0iJyi;
	}
internal static object e3tCOPsgndDh6RALaFd(int P_0)
	{
		return null;
	}
internal static void oLjNHksRtbEC3diFkKQ(object P_0, object P_1)
	{
		((ThemeDefinition)P_0).Name = (string)P_1;
	}
internal static void zEANVVshyvvyfRmqccX(object P_0, object P_1)
	{
		((ThemeDefinition)P_0).EditorImage = (string)P_1;
	}
internal static void ar9tKGs4jqFQ7AI1ghc(object P_0)
	{
		((Dictionary<string, ThemeDefinition>)P_0).Clear();
	}
internal static object CCnenSskaTg3iau8VdP(object P_0)
	{
		return ((ThemeDefinition)P_0).Name;
	}
internal static void rnpAnCsjdhb7scvSD6G(object P_0)
	{
		i8QDGB6feH(P_0);
	}
internal static object lctgScs6LmCWjwiqxUc()
	{
		return GetCurrentTheme();
	}
internal static object zxWeO5srx2ZFTaPAAex()
	{
		return AppData.SelectedTheme;
	}
internal static void B8gpe7sdxUEHRMBBX61(object P_0)
	{
		AppData.SelectedTheme = (string)P_0;
	}
internal static void IyrueqsiiceKnOpjRgN()
	{
		CgfD3Kqlai();
	}
internal static object XJwTO7syfMU7J0t3u0J()
	{
		return a9JD53Qp9o();
	}
internal static object LQ81EbsweHILBK8flfq(object P_0, bool P_1)
	{
		return FQEDzXQapu(P_0, P_1);
	}
internal static object jlVOsesAy7UL34Annv6()
	{
		return Hah7PegDmY();
	}
internal static object x9db83saMmJhLetdtcr(object P_0)
	{
		return Yi3DbIWgvA(P_0);
	}
internal static void O3AZaUsxVWfKTu279oJ()
	{
		}
}
