using System;
using System.IO;
using System.Xml.Serialization;
using Codename_SpaceGliderV2.Logic.Model.Settings;

// Token: 0x0200002B RID: 43
public class GClass13
{
	// Token: 0x060001CE RID: 462 RVA: 0x0000AB40 File Offset: 0x00008D40
	public static Settings smethod_0()
	{
		try
		{
			Settings settings = new Settings();
			if (File.Exists(GClass13.string_0))
			{
				StreamReader streamReader = File.OpenText(GClass13.string_0);
				settings = (Settings)new XmlSerializer(settings.GetType()).Deserialize(streamReader);
				streamReader.Close();
				return settings;
			}
		}
		catch (InvalidOperationException)
		{
			return null;
		}
		return null;
	}

	// Token: 0x060001CF RID: 463 RVA: 0x0000ABA8 File Offset: 0x00008DA8
	public static void smethod_1(Settings settings_0)
	{
		StreamWriter streamWriter = File.CreateText(GClass13.string_0);
		Type type = settings_0.GetType();
		if (type.IsSerializable)
		{
			new XmlSerializer(type).Serialize(streamWriter, settings_0);
			streamWriter.Close();
		}
	}

	// Token: 0x0400013E RID: 318
	private static string string_0 = <Module>.smethod_5<string>(3031912390u);
}
