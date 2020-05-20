using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

// Token: 0x0200001A RID: 26
[DebuggerNonUserCode]
[CompilerGenerated]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
internal class Class9
{
	// Token: 0x06000113 RID: 275 RVA: 0x000045F8 File Offset: 0x000027F8
	internal Class9()
	{
	}

	// Token: 0x17000003 RID: 3
	// (get) Token: 0x06000114 RID: 276 RVA: 0x00006D0C File Offset: 0x00004F0C
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager_0
	{
		get
		{
			if (Class9.resourceManager_0 == null)
			{
				Class9.resourceManager_0 = new ResourceManager(<Module>.smethod_6<string>(2916213106u), typeof(Class9).Assembly);
			}
			return Class9.resourceManager_0;
		}
	}

	// Token: 0x17000004 RID: 4
	// (get) Token: 0x06000115 RID: 277 RVA: 0x00006D48 File Offset: 0x00004F48
	// (set) Token: 0x06000116 RID: 278 RVA: 0x00006D5C File Offset: 0x00004F5C
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo CultureInfo_0
	{
		get
		{
			return Class9.cultureInfo_0;
		}
		set
		{
			Class9.cultureInfo_0 = value;
		}
	}

	// Token: 0x17000005 RID: 5
	// (get) Token: 0x06000117 RID: 279 RVA: 0x00006D70 File Offset: 0x00004F70
	internal static Bitmap Bitmap_0
	{
		get
		{
			return (Bitmap)Class9.ResourceManager_0.GetObject(<Module>.smethod_8<string>(1698648449u), Class9.cultureInfo_0);
		}
	}

	// Token: 0x17000006 RID: 6
	// (get) Token: 0x06000118 RID: 280 RVA: 0x00006D9C File Offset: 0x00004F9C
	internal static Bitmap Bitmap_1
	{
		get
		{
			return (Bitmap)Class9.ResourceManager_0.GetObject(<Module>.smethod_8<string>(2889278733u), Class9.cultureInfo_0);
		}
	}

	// Token: 0x17000007 RID: 7
	// (get) Token: 0x06000119 RID: 281 RVA: 0x00006DC8 File Offset: 0x00004FC8
	internal static byte[] Byte_0
	{
		get
		{
			return (byte[])Class9.ResourceManager_0.GetObject(<Module>.smethod_7<string>(987215579u), Class9.cultureInfo_0);
		}
	}

	// Token: 0x04000073 RID: 115
	private static ResourceManager resourceManager_0;

	// Token: 0x04000074 RID: 116
	private static CultureInfo cultureInfo_0;
}
