using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using f0llTJhsoHDvTqsdaj7;
namespace Potassium_UI_V2.Services;

public class ThemeDefinition
{
	[CompilerGenerated]
	private string NAKDnyQQlO;

	[CompilerGenerated]
	private string FeBD20FF0y;

	[CompilerGenerated]
	private Dictionary<string, Dictionary<string, string>> eiWDol38DD;

	private static ThemeDefinition Ufvt3KOZYv7H3xjbRJF;

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return NAKDnyQQlO;
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
					NAKDnyQQlO = value;
					num2 = 0;
					break;
				}
			}
		}
	}

	public string EditorImage
	{
		[CompilerGenerated]
		get
		{
			return FeBD20FF0y;
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
					FeBD20FF0y = value;
					num2 = 0;
					break;
				case 0:
					return;
				}
			}
		}
	}

	public Dictionary<string, Dictionary<string, string>> Categories
	{
		[CompilerGenerated]
		get
		{
			return eiWDol38DD;
		}
		[CompilerGenerated]
		set
		{
			eiWDol38DD = value;
		}
	}

	[JsonIgnore]
	public Dictionary<string, string> Colors
	{
		get
		{
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			foreach (Dictionary<string, string> value in Categories.Values)
			{
				foreach (KeyValuePair<string, string> item in value)
				{
					dictionary[item.Key] = item.Value;
				}
			}
			return dictionary;
		}
		set
		{
			Categories = ThemeManager.CategorizeColors(value);
		}
	}

	public ThemeDefinition()
	{
		rRnpZeObiReCFDfVfds();
		gfZHmeO3WxMUxJ27FLo();
		NAKDnyQQlO = (string)UfGR08OYBUdwX0FnTlC(0x6195108B ^ 0);
		FeBD20FF0y = "";
		eiWDol38DD = new Dictionary<string, Dictionary<string, string>>();
		int num = 0;		switch (num)
		{
		case 0:
			break;
		}
	}

	static ThemeDefinition()
	{
		// [removed obfuscated call]
		gKCVL0O5FP0FIERiJD7();
	}

	internal static bool GBtracOG6TTQ8eOnpab()
	{
		return Ufvt3KOZYv7H3xjbRJF == null;
	}

	internal static ThemeDefinition ytmHHXOQH261saCsRSd()
	{
		return Ufvt3KOZYv7H3xjbRJF;
	}

	internal static void rRnpZeObiReCFDfVfds()
	{
		// [removed obfuscated call]
	}

	internal static void gfZHmeO3WxMUxJ27FLo()
	{
		}

	internal static object UfGR08OYBUdwX0FnTlC(int P_0)
	{
		return null;
	}

	internal static void gKCVL0O5FP0FIERiJD7()
	{
		// [removed obfuscated call]
	}
}
