using System;
using System.Runtime.CompilerServices;
using System.Threading;
using NLog;

// Token: 0x02000023 RID: 35
public class GClass7
{
	// Token: 0x1700000A RID: 10
	// (get) Token: 0x06000184 RID: 388 RVA: 0x00007BB4 File Offset: 0x00005DB4
	// (set) Token: 0x06000185 RID: 389 RVA: 0x00007BC8 File Offset: 0x00005DC8
	public GClass8 GClass8_0 { get; set; }

	// Token: 0x1700000B RID: 11
	// (get) Token: 0x06000186 RID: 390 RVA: 0x00007BDC File Offset: 0x00005DDC
	// (set) Token: 0x06000187 RID: 391 RVA: 0x00007BF0 File Offset: 0x00005DF0
	public int Int32_0 { get; private set; }

	// Token: 0x1700000C RID: 12
	// (get) Token: 0x06000188 RID: 392 RVA: 0x00007C04 File Offset: 0x00005E04
	// (set) Token: 0x06000189 RID: 393 RVA: 0x00007C18 File Offset: 0x00005E18
	public Thread Thread_0 { get; private set; }

	// Token: 0x0600018A RID: 394 RVA: 0x00007C2C File Offset: 0x00005E2C
	public GClass7()
	{
		this.Int32_0 = 0;
		this.gclass6_0 = new GClass6();
		this.gclass2_0 = new GClass2();
	}

	// Token: 0x0600018B RID: 395 RVA: 0x00007C5C File Offset: 0x00005E5C
	public void method_0()
	{
		this.Thread_0 = new Thread(new ParameterizedThreadStart(this.method_1));
	}

	// Token: 0x0600018C RID: 396 RVA: 0x00007C80 File Offset: 0x00005E80
	public void method_1(object object_0)
	{
		this.bool_0 = true;
		GClass11 gclass = (GClass11)object_0;
		while (this.bool_0)
		{
			try
			{
				ValueTuple<double, double> valueTuple = this.gclass6_0.method_0();
				GClass7.logger_0.Info(<Module>.smethod_9<string>(1912046337u) + valueTuple.Item2.ToString() + <Module>.smethod_6<string>(4116771980u) + valueTuple.Item1.ToString());
				if (valueTuple.Item2 == 0.0)
				{
					if (valueTuple.Item1 == 0.0)
					{
						Thread.Sleep(1000);
						continue;
					}
				}
				Console.WriteLine(valueTuple.Item1);
				this.GClass8_0 = this.gclass2_0.method_0(gclass.GClass10_0, valueTuple.Item1, gclass.Double_0, gclass.Double_1);
				this.Int32_0 = (int)valueTuple.Item2;
				Thread.Sleep(10);
			}
			catch (ThreadInterruptedException ex)
			{
				GClass7.logger_0.Error(ex, <Module>.smethod_7<string>(2656115451u));
				Thread.CurrentThread.Interrupt();
			}
			catch (Exception ex2)
			{
				GClass7.logger_0.Error(ex2, <Module>.smethod_6<string>(2697525712u));
				Thread.Sleep(1000);
			}
		}
	}

	// Token: 0x0600018D RID: 397 RVA: 0x00007DD4 File Offset: 0x00005FD4
	public void method_2()
	{
		this.bool_0 = false;
		this.Thread_0.Interrupt();
	}

	// Token: 0x0400008E RID: 142
	private static readonly Logger logger_0 = LogManager.GetCurrentClassLogger();

	// Token: 0x0400008F RID: 143
	[CompilerGenerated]
	private GClass8 gclass8_0;

	// Token: 0x04000090 RID: 144
	[CompilerGenerated]
	private int int_0;

	// Token: 0x04000091 RID: 145
	[CompilerGenerated]
	private Thread thread_0;

	// Token: 0x04000092 RID: 146
	private GClass6 gclass6_0;

	// Token: 0x04000093 RID: 147
	private GClass2 gclass2_0;

	// Token: 0x04000094 RID: 148
	private volatile bool bool_0;
}
