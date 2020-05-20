using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

// Token: 0x02000011 RID: 17
public static class GClass1
{
	// Token: 0x17000002 RID: 2
	// (get) Token: 0x06000076 RID: 118 RVA: 0x000056BC File Offset: 0x000038BC
	// (set) Token: 0x06000077 RID: 119 RVA: 0x000056D0 File Offset: 0x000038D0
	[TupleElementNames(new string[]
	{
		"region",
		"X",
		"Y"
	})]
	public static ValueTuple<GClass0, int, int> ValueTuple_0 { [return: TupleElementNames(new string[]
	{
		"region",
		"X",
		"Y"
	})] get; [param: TupleElementNames(new string[]
	{
		"region",
		"X",
		"Y"
	})] private set; }

	// Token: 0x06000079 RID: 121 RVA: 0x0000572C File Offset: 0x0000392C
	public static void smethod_0()
	{
		GClass1.thread_0 = new Thread(new ThreadStart(GClass1.smethod_3));
		GClass1.bool_0 = true;
		GClass1.thread_0.Start();
	}

	// Token: 0x0600007A RID: 122 RVA: 0x00005764 File Offset: 0x00003964
	public static void smethod_1()
	{
		if (!GClass1.thread_0.IsAlive)
		{
			return;
		}
		GClass1.bool_0 = false;
		GClass1.thread_0.Join();
	}

	// Token: 0x0600007B RID: 123 RVA: 0x00005790 File Offset: 0x00003990
	public static void smethod_2(int int_1)
	{
		GClass1.int_0 = int_1;
	}

	// Token: 0x0600007C RID: 124 RVA: 0x000057A8 File Offset: 0x000039A8
	public static void smethod_3()
	{
		while (GClass1.bool_0)
		{
			int num = Math.Max(Math.Min((int)((double)GClass1.int_0 * GClass1.double_0 * 1.25), (int)((double)GClass1.size_0.Width * 0.9)), (int)((double)GClass1.size_0.Width * 0.6));
			int num2 = Math.Min((int)((double)num / 1.22), (int)((double)GClass1.size_0.Height * 0.9));
			int num3 = Math.Max((int)((double)GClass1.size_0.Width / 2.2) - num / 2, 0);
			int num4 = Math.Max((int)((double)GClass1.size_0.Height / 2.15) - num2 / 2, 0);
			Bitmap bitmap = new Bitmap(num, num2, PixelFormat.Format32bppArgb);
			Graphics graphics = Graphics.FromImage(bitmap);
			graphics.CopyFromScreen(num3, num4, 0, 0, new Size(num, num2), CopyPixelOperation.SourceCopy);
			ValueTuple<int, int> valueTuple = GClass16.smethod_3();
			ValueTuple<GClass0, int, int> valueTuple2 = Class12.smethod_10(bitmap, valueTuple.Item1, valueTuple.Item2, num3, num4);
			graphics.Dispose();
			bitmap.Dispose();
			GClass1.ValueTuple_0 = valueTuple2;
		}
	}

	// Token: 0x0600007D RID: 125 RVA: 0x000058E4 File Offset: 0x00003AE4
	public static Bitmap smethod_4(int int_1, int int_2, int int_3, int int_4)
	{
		Bitmap bitmap = new Bitmap(int_3, int_4, PixelFormat.Format32bppArgb);
		Graphics.FromImage(bitmap).CopyFromScreen(int_1, int_2, 0, 0, new Size(int_3, int_4), CopyPixelOperation.SourceCopy);
		return bitmap;
	}

	// Token: 0x04000052 RID: 82
	[CompilerGenerated]
	[TupleElementNames(new string[]
	{
		"region",
		"X",
		"Y"
	})]
	private static ValueTuple<GClass0, int, int> valueTuple_0;

	// Token: 0x04000053 RID: 83
	private static Thread thread_0;

	// Token: 0x04000054 RID: 84
	private static Size size_0 = Screen.PrimaryScreen.Bounds.Size;

	// Token: 0x04000055 RID: 85
	private static volatile int int_0;

	// Token: 0x04000056 RID: 86
	private static double double_0 = 2.05 * (double)GClass1.size_0.Width / 2560.0;

	// Token: 0x04000057 RID: 87
	private static volatile bool bool_0;
}
