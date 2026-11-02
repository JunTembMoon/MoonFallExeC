using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json;
namespace Potassium_UI_V2.Services;

public class TabPersistence
{
	private static TabPersistence lGF7SmO2jjc93SxZJEf;
public static SavedTabState Load()
	{
		SavedTabState result = default(SavedTabState);
		switch (1)
		{
		case 1:
			try
			{
				int num2;
				string text = null;
				if (true)
				{
					int num = 4;
					num2 = num;
					goto IL_006e;
				}
				goto IL_00f8;
				IL_00f8:
				text = null;
				num2 = 0;				goto IL_006e;
				IL_006e:
				JsonDocument jsonDocument = default(JsonDocument);
				List<SavedTab> tabs = default(List<SavedTab>);
				while (true)
				{
					switch (num2)
					{
					case 2:
						goto end_IL_006e;
					default:
						jsonDocument = null;
						num2 = 1;						continue;
					case 4:
						result = new SavedTabState();
						num2 = 2;
						continue;
					case 3:
						break;
					case 1:
						try
						{
							JsonElement jsonElement = default;
							int num3 = 1;							while (true)
							{
								List<SavedTab> list;
								SavedTabState savedTabState;
								switch (num3)
								{
								case 2:
									result = new SavedTabState
									{
										Tabs = tabs
									};
									num3 = 6;
									continue;
								case 6:
									goto end_IL_0170;
								case 1:
									if (0 == JsonValueKind.Array)
									{
										num3 = 4;
										continue;
									}
									goto default;
								case 4:
									list = JsonSerializer.Deserialize<List<SavedTab>>(text);
									if (list == null)
									{
										num3 = 5;
										continue;
									}
									goto IL_023f;
								default:
									savedTabState = JsonSerializer.Deserialize<SavedTabState>(text);
									if (savedTabState == null)
									{
										num3 = 3;										continue;
									}
									break;
								case 5:
									list = new List<SavedTab>();
									goto IL_023f;
								case 7:
									savedTabState = new SavedTabState();
									break;
								case 3:
									goto end_IL_0170;
									IL_023f:
									tabs = list;
									num3 = 2;
									continue;
								}
								result = savedTabState;
								num3 = 3;								continue;
								end_IL_0170:
								break;
							}
						}
						finally
						{
							int num4;
							if (jsonDocument == null)
							{
								num4 = 1;								goto IL_02a0;
							}
							goto IL_02b6;
							IL_02a0:
							switch (num4)
							{
							case 1:
								goto end_IL_0276;
							case 2:
								goto end_IL_0276;
							}
							goto IL_02b6;
							IL_02b6:
							num4 = 2;							goto IL_02a0;
							end_IL_0276:;
						}
						goto end_IL_006e;
					}
					goto IL_00f8;
					continue;
					end_IL_006e:
					break;
				}
			}
			catch
			{
				int num5 = 1;				while (true)
				{
					switch (num5)
					{
					case 1:
						result = new SavedTabState();
						num5 = 0;						continue;
					case 0:
						break;
					}
					break;
				}
			}
			break;
		}
		return result;
	}
public static void Save(SavedTabState state)
	{
		switch (1)
		{
		case 0:
			break;
		case 1:
			try
			{
				string text = null;
				int num = 4;
				string text2 = default(string);
				while (true)
				{
					switch (num)
					{
					case 2:
						return;
					case 3:
						num = 2;						break;
					case 5:
					{
						JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions();
						text2 = JsonSerializer.Serialize(state, jsonSerializerOptions);
						num = 3;
						break;
					}
					case 1:
						num = 5;						break;
					case 4:
						if (true)
						{
							num = 0;							break;
						}
						goto case 5;
					default:
						if (true)
						{
							num = 0;							break;
						}
						goto case 5;
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
		}
	}
static TabPersistence()
	{
		aTFoPlOmOIUQo12AB3o();
	}
internal static object l3ULdVOcKjELpYYueID(int P_0)
	{
		return null;
	}
internal static bool HR5uw0OoYi7e4IRCkpW()
	{
		return lGF7SmO2jjc93SxZJEf == null;
	}
internal static TabPersistence aSSqu8OVeFqXs61ikGq()
	{
		return lGF7SmO2jjc93SxZJEf;
	}
internal static void aTFoPlOmOIUQo12AB3o()
	{
		}
}
