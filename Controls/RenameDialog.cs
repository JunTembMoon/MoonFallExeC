using Border = System.Windows.Controls.Border;
using ScrollViewer = System.Windows.Controls.ScrollViewer;
using TextBox = System.Windows.Controls.TextBox;
using Timer = System.Timers.Timer;
using Button = System.Windows.Controls.Button;
using CheckBox = System.Windows.Controls.CheckBox;
using Popup = System.Windows.Controls.Primitives.Popup;
using System.Runtime.CompilerServices;
using TextBlock = System.Windows.Controls.TextBlock;
using System.Windows;
using System.Windows.Controls;
namespace Potassium_UI_V2.Controls;

public class RenameDialog : Window
{
	private TextBox p6Y793Zxir;

	private Button q0U7egTDBJ;

	[CompilerGenerated]
	private string TI471UJmvO;

	private static RenameDialog DJZHSBsTdnrne7mbZZZ;

	public string NewName
	{
[CompilerGenerated]
		get
		{
			return TI471UJmvO;
		}
[CompilerGenerated]
		private set
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
					TI471UJmvO = value;
					num2 = 0;
					break;
				case 0:
					return;
				}
			}
		}
	}
public RenameDialog(string currentName)
	{
		NOB7NasL5LOKbqguige();
		JwJIQAsuRpkApgoPFE4();
int num = 0;		StackPanel stackPanel2 = default(StackPanel);
		while (true)
		{
			switch (num)
			{
			case 5:
				num = 2;
				break;
			case 12:
				num = 3;				break;
			case 11:
			{
				Button button = new Button();
				q0U7egTDBJ = button;
				num = 2;				break;
			}
			case 14:
				num = 3;
				break;
			case 10:
				num = 6;
				break;
			case 13:
				num = 9;
				break;
			case 3:
			{
				int num4 = 10;
				num = num4;
				break;
			}
			case 4:
				num = 13;
				break;
			case 9:
				num = 0;				break;
			default:
				num = 8;
				break;
			case 6:
				num = 5;
				break;
			case 8:
				return;
			case 7:
			{
				TextBox textBox = new TextBox();
				p6Y793Zxir = textBox;
				num = 11;
				break;
			}
			case 1:
				num = 4;				break;
			case 2:
			{
				StackPanel stackPanel = new StackPanel();
				stackPanel2 = stackPanel;
				num = 7;
				break;
			}
			}
		}
	}
[CompilerGenerated]
	private void KOu7NHHepu(object P_0, RoutedEventArgs P_1)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				NewName = null;
				num2 = 0;
				break;
			default:
				num2 = 2;
				break;
			case 3:
				return;
			case 2:
				num2 = 3;
				break;
			}
		}
	}
static RenameDialog()
	{
		}
internal static bool ngB3lSsEdZj7lZaLhIK()
	{
		return DJZHSBsTdnrne7mbZZZ == null;
	}
internal static RenameDialog pqRGtesKc66ZHJqqnGR()
	{
		return DJZHSBsTdnrne7mbZZZ;
	}
internal static void NOB7NasL5LOKbqguige()
	{
		
	}
internal static void JwJIQAsuRpkApgoPFE4()
	{
		}
internal static object AYbcXosfp0A2x1o69O9(int P_0)
	{
		return null;
	}
}
