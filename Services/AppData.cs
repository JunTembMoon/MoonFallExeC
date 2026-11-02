﻿﻿﻿﻿﻿﻿﻿﻿﻿﻿﻿﻿﻿using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text.Json;
namespace Potassium_UI_V2.Services;

public class AppData
{
	private static readonly string EJmD898uE1;

	private static AppDataModel W6FDJwW2dq;

	private static bool TJJDT00DLh;

	internal static AppData q6IG1WOxV4iNvlDHW4g;

	public static double ConsoleHeight
	{
get
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return IpLHFRO0pMKC7durPBv(W6FDJwW2dq);
				case 1:
					xmZDsY2A6r();
					num2 = 0;					break;
				}
			}
		}
set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					DkxbWKOUV4PtUBuTniC(W6FDJwW2dq, value);
					num2 = 3;
					break;
				case 3:
					mnPkK8O9QtllROR5x7w();
					num2 = 2;					break;
				case 1:
					WgxYb2ON7CZoAlwLY9U();
					num2 = 0;					break;
				case 2:
					return;
				}
			}
		}
	}

	public static string SelectedTheme
	{
get
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return (string)DLiXXUOeClarAU9NwaU(W6FDJwW2dq);
				case 1:
					WgxYb2ON7CZoAlwLY9U();
					num2 = 0;					break;
				}
			}
		}
set
		{
			int num = 3;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					mnPkK8O9QtllROR5x7w();
					num2 = 1;					break;
				case 2:
					uTja1UO19h8SsBaft8B(W6FDJwW2dq, value);
					num2 = 0;					break;
				case 3:
					WgxYb2ON7CZoAlwLY9U();
					num2 = 2;
					break;
				case 1:
					return;
				}
			}
		}
	}
private static void xmZDsY2A6r()
	{
		int num = 2;
		int num2 = num;
		double value = default(double);
		string text = default(string);
		string text3 = default(string);
		AppDataModel appDataModel = default(AppDataModel);
		string text2 = default(string);
		bool flag = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (TJJDT00DLh)
				{
					num2 = 1;					continue;
				}
				TJJDT00DLh = true;
				num2 = 0;				continue;
			case 3:
				return;
			case 1:
				return;
			}
			try
			{
				int num3;
				if (false)
				{
					num3 = 12;					goto IL_006b;
				}
				goto IL_0308;
				IL_006b:
				while (true)
				{
					switch (num3)
					{
					case 22:
						DkxbWKOUV4PtUBuTniC(W6FDJwW2dq, value);
						num3 = 18;
						continue;
					case 5:
					{
						text = null;
						int num8 = 13;
						num3 = num8;
						continue;
					}
					case 7:
						W6FDJwW2dq = appDataModel;
						num3 = 24;
						continue;
					case 13:
						if (false)
						{
							num3 = 23;
							continue;
						}
						goto case 3;
					case 20:
						if (false)
						{
							num3 = 22;
							continue;
						}
						goto case 2;
					case 3:
						uTja1UO19h8SsBaft8B(W6FDJwW2dq, text);
						num3 = 25;
						continue;
					case 12:
					appDataModel = JsonSerializer.Deserialize<AppDataModel>((string?)null);
						num3 = 0;						continue;
					case 21:
						if (true)
						{
							num3 = 16;							continue;
						}
						goto case 5;
					case 4:
						flag = true;
						num3 = 11;
						continue;
					default:
						if (appDataModel == null)
						{
							num3 = 12;							continue;
						}
						goto case 7;
					case 2:
					case 9:
						text3 = null;
						num3 = 21;
						continue;
					case 18:
						try
						{
							int num6 = 0;							switch (num6)
							{
							case 0:
								break;
							}
						}
						catch
						{
							int num7 = 0;							switch (num7)
							{
							case 0:
								break;
							}
						}
						goto case 14;
					case 6:
						break;
					case 19:
						return;
					case 24:
						return;
					case 1:
						mnPkK8O9QtllROR5x7w();
						num3 = 8;
						continue;
					case 10:
						try
						{
							int num4 = 0;							switch (num4)
							{
							case 0:
								break;
							}
						}
						catch
						{
							int num5 = 0;							switch (num5)
							{
							case 0:
								break;
							}
						}
						goto case 4;
					case 15:
						if (true)
						{
							num3 = 1;							continue;
						}
						goto case 20;
					case 17:
						text2 = null;
						num3 = 15;
						continue;
					case 23:
					case 25:
						num3 = 10;
						continue;
					case 14:
						flag = true;
						num3 = 9;						continue;
					case 11:
					case 16:
						if (flag)
						{
							num3 = 1;							continue;
						}
						return;
					case 8:
						return;
					}
					break;
				}
				goto IL_0308;
				IL_0308:
				flag = false;
				num3 = 17;
				goto IL_006b;
			}
			catch
			{
				int num9 = 0;				switch (num9)
				{
				case 0:
					break;
				}
				return;
			}
		}
	}
private static void Save()
	{
		switch (1)
		{
		case 1:
			try
			{
				string text = null;
				int num = 6;
				int num2 = num;
				string text2 = default(string);
				while (true)
				{
					switch (num2)
					{
					case 4:
						if (false)
						{
							num2 = 5;
							continue;
						}
						break;
					default:
					{
						AppDataModel w6FDJwW2dq = W6FDJwW2dq;
						JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions();
						text2 = JsonSerializer.Serialize(w6FDJwW2dq, jsonSerializerOptions);
						num2 = 1;						continue;
					}
					case 6:
						if (false)
						{
							num2 = 0;							continue;
						}
						goto case 4;
					case 1:
						num2 = 3;						continue;
					case 7:
						break;
					case 3:
						return;
					}
					num2 = 2;				}
			}
			catch
			{
				int num3 = 0;				switch (num3)
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
static AppData()
	{
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 4:
				EdC8j5OXHltSHm5cjuf();
				num2 = 3;
				break;
			case 1:
				num2 = 5;
				break;
			case 3:
				en5VFFOMumdgKVvHQZO();
				num2 = 1;				break;
			case 2:
				return;
			default:
				W6FDJwW2dq = new AppDataModel();
				num2 = 0;				break;
			case 5:
				EJmD898uE1 = null;
				num2 = 0;				break;
			}
		}
	}
internal static double IpLHFRO0pMKC7durPBv(object P_0)
	{
		return ((AppDataModel)P_0).ConsoleHeight;
	}
internal static bool yIluTnOS7ElnCmPNlGY()
	{
		return q6IG1WOxV4iNvlDHW4g == null;
	}
internal static AppData xct2bgOvPcBYm7FqilI()
	{
		return q6IG1WOxV4iNvlDHW4g;
	}
internal static void WgxYb2ON7CZoAlwLY9U()
	{
		xmZDsY2A6r();
	}
internal static void DkxbWKOUV4PtUBuTniC(object P_0, double value)
	{
		((AppDataModel)P_0).ConsoleHeight = value;
	}
internal static void mnPkK8O9QtllROR5x7w()
	{
		Save();
	}
internal static object DLiXXUOeClarAU9NwaU(object P_0)
	{
		return ((AppDataModel)P_0).SelectedTheme;
	}
internal static void uTja1UO19h8SsBaft8B(object P_0, object P_1)
	{
		((AppDataModel)P_0).SelectedTheme = (string)P_1;
	}
internal static object ul7DOxOq0G2YstyZnuh(int P_0)
	{
		return null;
	}
internal static void EdC8j5OXHltSHm5cjuf()
	{
		}
internal static void en5VFFOMumdgKVvHQZO()
	{
		
	}
}
