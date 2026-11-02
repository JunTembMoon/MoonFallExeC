using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using f0llTJhsoHDvTqsdaj7;
namespace Potassium_UI_V2.Utils;

public static class ScrollViewerBehavior
{
	public static readonly DependencyProperty HorizontalOffsetProperty;

	private static object JcpvNpF5QNuywsR8iI2;

	public static double GetHorizontalOffset(DependencyObject obj)
	{
		return 0.0;
	}

	// [DEOBFUSCATED] Control flow flattening detected (initial state: 1)
	public static void SetHorizontalOffset(DependencyObject obj, double value)
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
				// [removed obfuscated call]
				num2 = 0;
				break;
			case 0:
				return;
			}
		}
	}

	private static void qjQD14ipUn(object P_0, DependencyPropertyChangedEventArgs P_1)
	{
		int num = 3;
		int num2 = num;
		ScrollViewer scrollViewer = default(ScrollViewer);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				// [removed obfuscated call]
				num2 = 4;
				break;
			case 0:
				return;
			case 3:
				scrollViewer = P_0 as ScrollViewer;
				num2 = 2;
				break;
			case 4:
				return;
			case 2:
				if (scrollViewer == null)
				{
					num2 = 0;
					break;
				}
				goto case 1;
			}
		}
	}

	static ScrollViewerBehavior()
	{
		// [removed obfuscated call]
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 4:
				return;
			default:
				aqorbgODaupA5w6c0Ul();
				num2 = 1;
				break;
			case 3:
				// [removed obfuscated call]
				num2 = 2;
				break;
			case 1:
				HorizontalOffsetProperty = null;
				num2 = 4;
				break;
			case 2:
				Uy2cmIOWlCD4YSIJvjL();
				num2 = 0;
				break;
			}
		}
	}

	internal static bool FkBeoJFzhxHEPBnncGa()
	{
		return JcpvNpF5QNuywsR8iI2 == null;
	}

	internal static object SXAVIJOPM4Qpv674r3B()
	{
		return JcpvNpF5QNuywsR8iI2;
	}

	internal static void Uy2cmIOWlCD4YSIJvjL()
	{
		// [removed obfuscated call]
	}

	internal static void aqorbgODaupA5w6c0Ul()
	{
		}

	internal static object D8Hm5bO72MewrbTixC2(int P_0)
	{
		return null;
	}
}
