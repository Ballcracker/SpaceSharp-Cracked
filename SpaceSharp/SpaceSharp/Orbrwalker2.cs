using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Codename_SpaceGliderV2.Logic.Model.Settings;
using InputSimulatorStandard;
using NLog;

// Token: 0x0200001E RID: 30
public class GClass4
{
	// Token: 0x06000132 RID: 306 RVA: 0x0000702C File Offset: 0x0000522C
	public GClass4(KeyboardSimulator keyboardSimulator_1, MouseSimulator mouseSimulator_1)
	{
		this.keyboardSimulator_0 = keyboardSimulator_1;
		this.mouseSimulator_0 = mouseSimulator_1;
	}

	// Token: 0x06000133 RID: 307 RVA: 0x00007054 File Offset: 0x00005254
	public void method_0(GClass15 gclass15_1, GClass10 gclass10_0, GClass7 gclass7_1, GClass14 gclass14_1, bool bool_2, Settings settings_1)
	{
		this.bool_0 = true;
		this.settings_0 = settings_1;
		this.gclass7_0 = gclass7_1;
		this.gclass7_0.method_0();
		this.gclass7_0.Thread_0.Start(new GClass11(gclass10_0, (double)this.settings_0.WindupMultiplier, (double)this.settings_0.TotalDelayMultiplier));
		this.gclass15_0 = gclass15_1;
		this.gclass14_0 = gclass14_1;
		GClass1.smethod_0();
		this.thread_0 = new Thread(new ParameterizedThreadStart(this.method_2));
		this.thread_0.Priority = ThreadPriority.Highest;
		this.thread_0.Start(bool_2);
	}

	// Token: 0x06000134 RID: 308 RVA: 0x00007108 File Offset: 0x00005308
	public void method_1()
	{
		if (this.thread_0 != null && this.gclass7_0.Thread_0 != null)
		{
			GClass1.smethod_1();
			this.bool_0 = false;
			this.gclass7_0.method_2();
			this.thread_0.Interrupt();
			return;
		}
	}

	// Token: 0x06000135 RID: 309 RVA: 0x00007154 File Offset: 0x00005354
	private void method_2(object object_0)
	{
		bool flag = (bool)object_0;
		Stopwatch stopwatch = new Stopwatch();
		Stopwatch stopwatch2 = new Stopwatch();
		Stopwatch stopwatch3 = new Stopwatch();
		Stopwatch stopwatch_ = new Stopwatch();
		try
		{
			Thread.Sleep(10);
			while (this.bool_0)
			{
				try
				{
					stopwatch2.Reset();
					stopwatch.Reset();
					stopwatch3.Reset();
					stopwatch2.Start();
					stopwatch3.Start();
					if (flag)
					{
						GClass1.smethod_2(this.gclass7_0.Int32_0);
						ValueTuple<ValueTuple<int, int, int, int, int, int, int, ValueTuple<int>>, long> valueTuple = this.gclass15_0.method_0(this.settings_0.DebugMode);
						this.method_9(<Module>.smethod_6<string>(2564884211u) + valueTuple.Item2.ToString() + <Module>.smethod_8<string>(2166202289u));
						this.gclass14_0.method_0(this.gclass7_0.Int32_0);
						this.method_6(stopwatch, valueTuple.Item1, stopwatch2);
						if (this.method_7(stopwatch_, valueTuple.Item1))
						{
							continue;
						}
						this.method_8(valueTuple.Item1, stopwatch, stopwatch2);
					}
					else
					{
						stopwatch2.Stop();
						this.keyboardSimulator_0.KeyPress(121);
						stopwatch.Start();
					}
					GClass8 gclass8_ = this.gclass7_0.GClass8_0;
					stopwatch.Stop();
					long num = this.method_4(gclass8_, (int)stopwatch.ElapsedMilliseconds);
					this.method_9(<Module>.smethod_8<string>(3718370795u) + gclass8_.Int32_0.ToString() + <Module>.smethod_6<string>(666351105u));
					this.method_9(<Module>.smethod_7<string>(3406421762u) + (num + stopwatch.ElapsedMilliseconds).ToString() + <Module>.smethod_7<string>(1313282621u));
					this.mouseSimulator_0.RightButtonClick();
					this.method_9(<Module>.smethod_7<string>(3623799790u) + stopwatch2.ElapsedMilliseconds.ToString());
					long num2 = this.method_5(gclass8_, stopwatch2, stopwatch3);
					this.method_9(<Module>.smethod_8<string>(4185924635u) + num2.ToString());
					stopwatch3.Stop();
					this.method_9(string.Concat(new string[]
					{
						<Module>.smethod_5<string>(3394515951u),
						(gclass8_.Int32_1 + gclass8_.Int32_0).ToString(),
						<Module>.smethod_5<string>(2301657760u),
						stopwatch3.ElapsedMilliseconds.ToString(),
						<Module>.smethod_5<string>(387403200u)
					}));
				}
				catch (ThreadInterruptedException)
				{
					this.bool_0 = false;
					this.method_1();
					Thread.CurrentThread.Interrupt();
				}
				catch (TaskSchedulerException)
				{
					this.bool_0 = false;
					this.method_1();
					Thread.CurrentThread.Interrupt();
				}
				catch (Exception ex)
				{
					GClass4.logger_0.Error(ex, <Module>.smethod_5<string>(199417749u));
				}
			}
		}
		catch (ThreadInterruptedException)
		{
			this.bool_0 = false;
			this.method_1();
			Thread.CurrentThread.Interrupt();
		}
	}

	// Token: 0x06000136 RID: 310 RVA: 0x000074A0 File Offset: 0x000056A0
	private bool method_3([TupleElementNames(new string[]
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
		return this.gclass14_0.method_1(valueTuple_0) && valueTuple_0.Item1 > 0 && valueTuple_0.Item2 > 0;
	}

	// Token: 0x06000137 RID: 311 RVA: 0x000074D0 File Offset: 0x000056D0
	private long method_4(GClass8 gclass8_0, int int_0)
	{
		Stopwatch stopwatch = Stopwatch.StartNew();
		while (stopwatch.ElapsedMilliseconds < (long)(gclass8_0.Int32_0 - int_0) && this.bool_0)
		{
			Thread.Sleep(1);
		}
		stopwatch.Stop();
		this.method_9(<Module>.smethod_9<string>(3085217640u) + stopwatch.ElapsedMilliseconds.ToString() + <Module>.smethod_5<string>(3025555952u) + int_0.ToString());
		return stopwatch.ElapsedMilliseconds;
	}

	// Token: 0x06000138 RID: 312 RVA: 0x00007548 File Offset: 0x00005748
	private long method_5(GClass8 gclass8_0, Stopwatch stopwatch_0, Stopwatch stopwatch_1)
	{
		Stopwatch stopwatch = Stopwatch.StartNew();
		int num = (int)((long)gclass8_0.Int32_1 - stopwatch_0.ElapsedMilliseconds);
		while (stopwatch.ElapsedMilliseconds < (long)num && this.bool_0 && stopwatch_1.ElapsedMilliseconds < (long)(gclass8_0.Int32_0 + gclass8_0.Int32_1))
		{
			num = (int)((long)gclass8_0.Int32_1 - stopwatch_0.ElapsedMilliseconds);
			Thread.Sleep(1);
			if (stopwatch.ElapsedMilliseconds % 150L >= 148L)
			{
				this.mouseSimulator_0.RightButtonClick();
			}
		}
		stopwatch.Stop();
		return stopwatch.ElapsedMilliseconds;
	}

	// Token: 0x06000139 RID: 313 RVA: 0x000075E0 File Offset: 0x000057E0
	private void method_6(Stopwatch stopwatch_0, [TupleElementNames(new string[]
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
	})] ValueTuple<int, int, int, int, int, int, int, ValueTuple<int>> valueTuple_0, Stopwatch stopwatch_1)
	{
		Stopwatch stopwatch = Stopwatch.StartNew();
		if (this.settings_0.UseEmergencyStrategy && !this.method_3(valueTuple_0))
		{
			stopwatch_1.Stop();
			this.keyboardSimulator_0.KeyPress(121);
			stopwatch_0.Start();
			stopwatch.Stop();
			this.method_9(<Module>.smethod_5<string>(4215912320u) + stopwatch.ElapsedMilliseconds.ToString());
			return;
		}
		stopwatch.Stop();
		this.method_9(<Module>.smethod_7<string>(4086603721u));
	}

	// Token: 0x0600013A RID: 314 RVA: 0x00007668 File Offset: 0x00005868
	private bool method_7(Stopwatch stopwatch_0, [TupleElementNames(new string[]
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
		if (!this.method_3(valueTuple_0) && !this.settings_0.UseEmergencyStrategy)
		{
			if (!stopwatch_0.IsRunning)
			{
				stopwatch_0.Start();
				this.mouseSimulator_0.RightButtonClick();
			}
			if (stopwatch_0.ElapsedMilliseconds > 140L)
			{
				this.mouseSimulator_0.RightButtonClick();
				stopwatch_0.Stop();
				stopwatch_0.Reset();
			}
			return true;
		}
		return false;
	}

	// Token: 0x0600013B RID: 315 RVA: 0x000076D4 File Offset: 0x000058D4
	private void method_8([TupleElementNames(new string[]
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
	})] ValueTuple<int, int, int, int, int, int, int, ValueTuple<int>> valueTuple_0, Stopwatch stopwatch_0, Stopwatch stopwatch_1)
	{
		Stopwatch stopwatch = Stopwatch.StartNew();
		if (!this.method_3(valueTuple_0))
		{
			return;
		}
		ValueTuple<int, int> valueTuple_ = GClass16.smethod_3();
		GClass16.smethod_0();
		GClass16.smethod_2(new ValueTuple<int, int>(valueTuple_0.Item1, valueTuple_0.Item2));
		stopwatch_1.Stop();
		this.mouseSimulator_0.RightButtonClick();
		stopwatch_0.Start();
		Thread.Sleep(30);
		GClass16.smethod_2(valueTuple_);
		GClass16.smethod_1();
		stopwatch.Stop();
		this.method_9(<Module>.smethod_6<string>(2548611744u) + stopwatch.ElapsedMilliseconds.ToString());
	}

	// Token: 0x0600013C RID: 316 RVA: 0x00007764 File Offset: 0x00005964
	private void method_9(string string_0)
	{
		if (this.bool_1)
		{
			GClass4.logger_0.Info(string_0);
		}
	}

	// Token: 0x0400007C RID: 124
	private static readonly Logger logger_0 = LogManager.GetCurrentClassLogger();

	// Token: 0x0400007D RID: 125
	private Thread thread_0;

	// Token: 0x0400007E RID: 126
	private volatile bool bool_0;

	// Token: 0x0400007F RID: 127
	private GClass15 gclass15_0;

	// Token: 0x04000080 RID: 128
	private volatile Settings settings_0;

	// Token: 0x04000081 RID: 129
	private volatile GClass7 gclass7_0;

	// Token: 0x04000082 RID: 130
	private GClass14 gclass14_0;

	// Token: 0x04000083 RID: 131
	private KeyboardSimulator keyboardSimulator_0;

	// Token: 0x04000084 RID: 132
	private MouseSimulator mouseSimulator_0;

	// Token: 0x04000085 RID: 133
	private bool bool_1 = true;
}
