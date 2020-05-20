using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

// Token: 0x0200002D RID: 45
public class GClass15
{
	// Token: 0x060001E2 RID: 482 RVA: 0x0000B030 File Offset: 0x00009230
	public GClass15()
	{
		this.size_0 = Screen.PrimaryScreen.Bounds.Size;
	}

	// Token: 0x060001E3 RID: 483 RVA: 0x0000B05C File Offset: 0x0000925C
	[return: TupleElementNames(new string[]
	{
		"enemy",
		"elapsedTime",
		"x",
		"y",
		"width",
		"height",
		"rectX",
		"rectY",
		"startX",
		"startY",
		null
	})]
	public ValueTuple<ValueTuple<int, int, int, int, int, int, int, ValueTuple<int>>, long> method_0(bool bool_0)
	{
		Stopwatch stopwatch = Stopwatch.StartNew();
		ValueTuple<GClass0, int, int> valueTuple_ = GClass1.ValueTuple_0;
		int num = (int)((double)this.size_0.Width * 0.15);
		int num2 = (int)((double)this.size_0.Height * 0.25);
		int num3 = Math.Max(valueTuple_.Item2 - num / 2, 0);
		int num4 = Math.Max(valueTuple_.Item3 - num2 / 3, 0);
		Bitmap bitmap = GClass1.smethod_4(num3, num4, num, num2);
		ValueTuple<int, int, int, int, int, int, int, ValueTuple<int>> valueTuple = Class12.smethod_11(bitmap.Clone(new Rectangle(0, 0, num, num2), PixelFormat.Format32bppArgb), valueTuple_.Item1, valueTuple_.Item2, valueTuple_.Item3, num3, num4, bool_0);
		bitmap.Dispose();
		stopwatch.Stop();
		return new ValueTuple<ValueTuple<int, int, int, int, int, int, int, ValueTuple<int>>, long>(new ValueTuple<int, int, int, int, int, int, int, ValueTuple<int>>(valueTuple.Item1, valueTuple.Item2, valueTuple.Item3, valueTuple.Item4, valueTuple.Item5, valueTuple.Item6, valueTuple.Item7, new ValueTuple<int>(valueTuple.Rest.Item1)), stopwatch.ElapsedMilliseconds);
	}

	// Token: 0x04000146 RID: 326
	private Size size_0;
}
