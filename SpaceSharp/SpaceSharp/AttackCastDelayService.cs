using System;
using System.Runtime.CompilerServices;

// Token: 0x0200001C RID: 28
public class GClass2
{
	// Token: 0x17000009 RID: 9
	// (get) Token: 0x06000122 RID: 290 RVA: 0x00006E40 File Offset: 0x00005040
	// (set) Token: 0x06000123 RID: 291 RVA: 0x00006E54 File Offset: 0x00005054
	public GClass8 GClass8_0 { get; set; }

	// Token: 0x06000124 RID: 292 RVA: 0x00006E68 File Offset: 0x00005068
	public GClass2()
	{
		this.GClass8_0 = new GClass8(0, 0, 0);
	}

	// Token: 0x06000125 RID: 293 RVA: 0x00006E8C File Offset: 0x0000508C
	public GClass8 method_0(GClass10 gclass10_0, double double_0, double double_1, double double_2)
	{
		double num = 1000.0 / gclass10_0.Double_0;
		double num2 = 1000.0 / num;
		double num3 = 1000.0 / double_0;
		double num4 = (double_0 - gclass10_0.Double_0) / num2;
		double double_3 = gclass10_0.Double_1;
		double num5 = (num * double_3 / (1.0 + num4 * num4 * double_3) + (double)new Random().Next(5)) * (1.0 + double_1 / 100.0);
		double a = (num3 - num5 + 35.0) * (1.0 + double_2 / 100.0);
		return new GClass8((int)Math.Ceiling(num5), (int)Math.Ceiling(a), 5);
	}

	// Token: 0x04000076 RID: 118
	[CompilerGenerated]
	private GClass8 gclass8_0;
}
