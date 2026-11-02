using System.Collections.Generic;
using System.Runtime.CompilerServices;
using f0llTJhsoHDvTqsdaj7;
namespace Potassium_UI_V2.Services;

public class SavedTabState
{
	[CompilerGenerated]
	private int oWODlarS97;

	[CompilerGenerated]
	private List<SavedTab> Y2wDHkJQdJ;

	private static SavedTabState CRdZDlOLJXVeHmfn2c6;

	public int ActiveIndex
	{
		[CompilerGenerated]
		get
		{
			return oWODlarS97;
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
					oWODlarS97 = value;
					num2 = 0;
					break;
				case 0:
					return;
				}
			}
		}
	}

	public List<SavedTab> Tabs
	{
		[CompilerGenerated]
		get
		{
			return Y2wDHkJQdJ;
		}
		[CompilerGenerated]
		set
		{
			Y2wDHkJQdJ = value;
		}
	}

	public SavedTabState()
	{
		PiDxlNOliqbCE3G0BTi();
		KvpUyFOHY0G680ZARZW();
		Y2wDHkJQdJ = new List<SavedTab>();
		int num = 0;		switch (num)
		{
		case 0:
			break;
		}
	}

	static SavedTabState()
	{
		// [removed obfuscated call]
		kc950qOncxdTaQjhBLl();
	}

	internal static bool i8RxVsOuhA8PJOa41D7()
	{
		return CRdZDlOLJXVeHmfn2c6 == null;
	}

	internal static SavedTabState EFxxQfOfJRBvQlKd2iQ()
	{
		return CRdZDlOLJXVeHmfn2c6;
	}

	internal static void PiDxlNOliqbCE3G0BTi()
	{
		// [removed obfuscated call]
	}

	internal static void KvpUyFOHY0G680ZARZW()
	{
		}

	internal static void kc950qOncxdTaQjhBLl()
	{
		// [removed obfuscated call]
	}
}
