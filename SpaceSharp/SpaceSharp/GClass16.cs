using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

// Token: 0x0200002E RID: 46
public static class GClass16
{
	// Token: 0x060001E7 RID: 487
	[DllImport("user32.dll")]
	private static extern bool GetCursorPos(out Point point_0);

	// Token: 0x060001E8 RID: 488
	[DllImport("user32.dll")]
	private static extern bool SetCursorPos(int int_1, int int_2);

	// Token: 0x060001E9 RID: 489
	[SuppressUnmanagedCodeSecurity]
	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool BlockInput([MarshalAs(UnmanagedType.Bool)] bool bool_0);

	// Token: 0x060001EA RID: 490 RVA: 0x0000B164 File Offset: 0x00009364
	public static void smethod_0()
	{
		GClass16.BlockInput(true);
	}

	// Token: 0x060001EB RID: 491 RVA: 0x0000B178 File Offset: 0x00009378
	public static void smethod_1()
	{
		GClass16.BlockInput(false);
	}

	// Token: 0x060001EC RID: 492 RVA: 0x0000B18C File Offset: 0x0000938C
	public static void smethod_2([TupleElementNames(new string[]
	{
		"x",
		"y"
	})] ValueTuple<int, int> valueTuple_0)
	{
		GClass16.smethod_4(valueTuple_0);
	}

	// Token: 0x060001ED RID: 493 RVA: 0x0000B1A0 File Offset: 0x000093A0
	[return: TupleElementNames(new string[]
	{
		"x",
		"y"
	})]
	public static ValueTuple<int, int> smethod_3()
	{
		Point point;
		GClass16.GetCursorPos(out point);
		return new ValueTuple<int, int>(point.X, point.Y);
	}

	// Token: 0x060001EE RID: 494 RVA: 0x0000B1C8 File Offset: 0x000093C8
	private static bool smethod_4([TupleElementNames(new string[]
	{
		"x",
		"y"
	})] ValueTuple<int, int> valueTuple_0)
	{
		return GClass16.SetCursorPos(valueTuple_0.Item1, valueTuple_0.Item2);
	}

	// Token: 0x04000147 RID: 327
	private const int int_0 = 1;
}
