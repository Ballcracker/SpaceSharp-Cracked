using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

// Token: 0x0200002C RID: 44
public class GClass14
{
	// Token: 0x060001DC RID: 476 RVA: 0x0000AC00 File Offset: 0x00008E00
	public GClass14(GEnum1 genum1_0)
	{
		for (;;)
		{
			IL_B8:
			this.size_0 = Screen.PrimaryScreen.Bounds.Size;
			for (;;)
			{
				IL_AB:
				this.graphicsPath_0 = new GraphicsPath();
				for (;;)
				{
					IL_9D:
					this.rectangle_0 = default(Rectangle);
					for (;;)
					{
						IL_75:
						this.double_0 = 2.05 * (double)this.size_0.Width / 2560.0;
						for (;;)
						{
							switch (genum1_0)
							{
							case GEnum1.CHAOS:
								goto IL_D3;
							case GEnum1.ORDER:
								goto IL_102;
							case GEnum1.UNKNOWN:
								return;
							default:
							{
								uint num;
								switch ((num = (num * 1130701111u ^ 3141109874u ^ 4012812697u)) % 13u)
								{
								case 0u:
									goto IL_102;
								case 2u:
									goto IL_9D;
								case 3u:
									goto IL_120;
								case 4u:
								case 7u:
									goto IL_B8;
								case 5u:
									return;
								case 6u:
									goto IL_D3;
								case 8u:
									goto IL_E2;
								case 9u:
									goto IL_75;
								case 10u:
									goto IL_111;
								case 11u:
									goto IL_AB;
								case 12u:
									continue;
								}
								goto Block_1;
							}
							}
						}
					}
				}
			}
		}
		Block_1:
		return;
		IL_D3:
		this.double_1 = 1.05;
		IL_E2:
		this.double_2 = 3.25;
		this.double_3 = 1.65;
		return;
		IL_102:
		this.double_1 = 1.0;
		IL_111:
		this.double_2 = 2.0;
		IL_120:
		this.double_3 = 2.0;
	}

	// Token: 0x060001DD RID: 477 RVA: 0x0000AD40 File Offset: 0x00008F40
	public void method_0(int int_0)
	{
		this.rectangle_0.Width = (int)((double)int_0 * this.double_0 * this.double_1);
		this.rectangle_0.Height = (int)((double)this.rectangle_0.Width / 1.22);
		this.rectangle_0.X = (int)((double)this.size_0.Width / 2.2) - (int)((double)this.rectangle_0.Width / this.double_2);
		this.rectangle_0.Y = (int)((double)this.size_0.Height / 2.15) - (int)((double)this.rectangle_0.Height / this.double_3);
		this.graphicsPath_0.Reset();
		this.graphicsPath_0.AddEllipse(this.rectangle_0);
	}

	// Token: 0x060001DE RID: 478 RVA: 0x0000AE18 File Offset: 0x00009018
	public bool method_1([TupleElementNames(new string[]
	{
		"x",
		"y",
		"width",
		"height",
		"rectX",
		"rectY",
		"startX",
		"startY",
		null
	})] ValueTuple<int, int, int, int, int, int, int, ValueTuple<int>> valueTuple_0)
	{
		int int_ = valueTuple_0.Item5 + valueTuple_0.Item7;
		int int_2 = valueTuple_0.Item6 + valueTuple_0.Rest.Item1;
		int int_3 = valueTuple_0.Item5 + valueTuple_0.Item7;
		int int_4 = valueTuple_0.Item6 + valueTuple_0.Rest.Item1 + valueTuple_0.Item4;
		int int_5 = valueTuple_0.Item5 + valueTuple_0.Item7 + valueTuple_0.Item3;
		int int_6 = valueTuple_0.Item6 + valueTuple_0.Rest.Item1;
		int int_7 = valueTuple_0.Item5 + valueTuple_0.Item7 + valueTuple_0.Item3;
		int int_8 = valueTuple_0.Item6 + valueTuple_0.Rest.Item1 + valueTuple_0.Item4;
		int int_9 = valueTuple_0.Item5 + valueTuple_0.Item7;
		int int_10 = valueTuple_0.Item6 + valueTuple_0.Rest.Item1 + valueTuple_0.Item4 / 2;
		int int_11 = valueTuple_0.Item5 + valueTuple_0.Item7 + valueTuple_0.Item3;
		int int_12 = valueTuple_0.Item6 + valueTuple_0.Rest.Item1 + valueTuple_0.Item4 / 2;
		int int_13 = valueTuple_0.Item5 + valueTuple_0.Item7 + valueTuple_0.Item3 / 2;
		int int_14 = valueTuple_0.Item6 + valueTuple_0.Rest.Item1;
		int int_15 = valueTuple_0.Item5 + valueTuple_0.Item7 + valueTuple_0.Item3 / 2;
		int int_16 = valueTuple_0.Item6 + valueTuple_0.Rest.Item1 + valueTuple_0.Item4;
		foreach (Class5 @class in new Class5[]
		{
			new Class5(int_, int_2, -1),
			new Class5(int_3, int_4, -1),
			new Class5(int_5, int_6, -1),
			new Class5(int_7, int_8, -1),
			new Class5(int_9, int_10, -1),
			new Class5(int_11, int_12, -1),
			new Class5(int_13, int_14, -1),
			new Class5(int_15, int_16, -1)
		})
		{
			if (this.graphicsPath_0.IsVisible(@class.int_0, @class.int_1))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0400013F RID: 319
	private Size size_0;

	// Token: 0x04000140 RID: 320
	private GraphicsPath graphicsPath_0;

	// Token: 0x04000141 RID: 321
	private Rectangle rectangle_0;

	// Token: 0x04000142 RID: 322
	private double double_0;

	// Token: 0x04000143 RID: 323
	private double double_1;

	// Token: 0x04000144 RID: 324
	private double double_2;

	// Token: 0x04000145 RID: 325
	private double double_3;
}
