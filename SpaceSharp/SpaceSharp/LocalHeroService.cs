using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

// Token: 0x02000027 RID: 39
public class GClass10
{
	// Token: 0x17000013 RID: 19
	// (get) Token: 0x060001A6 RID: 422 RVA: 0x0000A7CC File Offset: 0x000089CC
	// (set) Token: 0x060001A7 RID: 423 RVA: 0x0000A7E0 File Offset: 0x000089E0
	[Bindable(true)]
	public string championName { get; set; }

	// Token: 0x17000014 RID: 20
	// (get) Token: 0x060001A8 RID: 424 RVA: 0x0000A7F4 File Offset: 0x000089F4
	// (set) Token: 0x060001A9 RID: 425 RVA: 0x0000A808 File Offset: 0x00008A08
	public double Double_0 { get; set; }

	// Token: 0x17000015 RID: 21
	// (get) Token: 0x060001AA RID: 426 RVA: 0x0000A81C File Offset: 0x00008A1C
	// (set) Token: 0x060001AB RID: 427 RVA: 0x0000A830 File Offset: 0x00008A30
	public double Double_1 { get; set; }

	// Token: 0x060001AC RID: 428 RVA: 0x0000A844 File Offset: 0x00008A44
	public GClass10(string string_1, double double_2, double double_3)
	{
		this.championName = string_1;
		this.Double_0 = double_2;
		this.Double_1 = double_3;
	}

	// Token: 0x0400012D RID: 301
	[CompilerGenerated]
	private string string_0;

	// Token: 0x0400012E RID: 302
	[CompilerGenerated]
	private double double_0;

	// Token: 0x0400012F RID: 303
	[CompilerGenerated]
	private double double_1;
}
