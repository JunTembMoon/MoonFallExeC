﻿﻿﻿﻿﻿﻿﻿﻿﻿﻿﻿using Border = System.Windows.Controls.Border;
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
using System.Runtime.CompilerServices;
using TextBlock = System.Windows.Controls.TextBlock;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Potassium_UI_V2.Services;

namespace Potassium_UI_V2.Views.Theme;

public partial class Theme : UserControl
{
				private bool gpgS4Ao8C;

	internal static Theme VI7JLFCFAEcaM1mdxlX;
public Theme()
	{
		InitializeComponent();
	}

private void bxqw2mqTW()
	{
		int num = 1;
		List<string>.Enumerator enumerator = default(List<string>.Enumerator);
		string current = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					num2 = 2;					continue;
				case 2:
					try
					{
						while (true)
						{
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 2;								goto IL_008e;
							}
							goto IL_010f;
							IL_010f:
							current = enumerator.Current;
							num3 = 0;							goto IL_008e;
							IL_008e:
							while (true)
							{
								switch (num3)
								{
								case 1:
									num3 = 0;									continue;
								case 3:
									goto IL_010f;
								case 2:
									goto end_IL_00a8;
								}
								break;
							}
							continue;
							end_IL_00a8:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
						int num4 = 0;						switch (num4)
						{
						case 0:
							break;
						}
					}
					goto case 3;
				case 5:
					enumerator = ThemeManager.GetThemeNames().GetEnumerator();
					num2 = 2;					continue;
				case 6:
					return;
				case 3:
					num2 = 4;
					continue;
				case 1:
					num2 = 0;					continue;
				}
				break;
			}
			num = 5;
		}
	}
private void mP3ApsP6C(object P_0, SelectionChangedEventArgs P_1)
	{
		int num = 2;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				text = null as string;
				num2 = 0;				break;
			case 1:
				if (text != null)
				{
					num2 = 3;
					break;
				}
				return;
			case 3:
				ThemeManager.ApplyTheme(text);
				num2 = 0;				break;
			case 0:
				return;
			}
		}
	}
private void KNXaUSCfn(object P_0, RoutedEventArgs P_1)
	{
		int num = 5;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				num2 = 3;
				continue;
			case 4:
				if (false)
				{
					num2 = 1;					continue;
				}
				break;
			case 5:
				text = null;
				num2 = 4;
				continue;
			case 3:
				return;
			case 2:
				break;
			}
			num2 = 0;		}
	}

	// [DEOBFUSCATED] Control flow flattening detected (initial state: 2)
private void MutxveTNa(object P_0, RoutedEventArgs P_1)
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
				bxqw2mqTW();
				num2 = 0;				break;
			case 0:
				return;
			case 2:
				ey6CBoCK1ZjAhXfeVPw();
				num2 = 1;				break;
			}
		}
	}
/* InitializeComponent provided by .g.cs */
/* IComponentConnector\.Connect removed */
static Theme()
	{
	}
internal static void NnqHsQC8Wy6xt6TpAwy()
	{
		
	}
internal static void EUmuswCJLBho3NrpdRr()
	{
		}
internal static bool fIWSwmCOE6RS6uF3tyW()
	{
		return VI7JLFCFAEcaM1mdxlX == null;
	}
internal static Theme B0SXsUCsCrsgvqQuBuZ()
	{
		return VI7JLFCFAEcaM1mdxlX;
	}
internal static object r6Dw9HCTS5Rdb5ZF2Ib()
	{
		return ThemeManager.CurrentThemeName;
	}
internal static object xiHY4GCE0vc4H9HC70p(int P_0)
	{
		return null;
	}
internal static void ey6CBoCK1ZjAhXfeVPw()
	{
		ThemeManager.ReloadThemes();
	}
internal static void Dc16v2CLDg2TBVSWFma()
	{
		}
}
