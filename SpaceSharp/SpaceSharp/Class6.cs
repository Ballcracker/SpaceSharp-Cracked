using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Codename_SpaceGliderV2.Logic.Model.Settings;
using Gma.System.MouseKeyHook;
using InputSimulatorStandard;

// Token: 0x02000010 RID: 16
internal class Class6
{
	// Token: 0x06000060 RID: 96 RVA: 0x0000536C File Offset: 0x0000356C
	public Class6(Settings settings_1, WHfCnaeAMEFPwbVHgQkWFbdtQGiZA.GDelegate1 gdelegate1_1)
	{
		this.keyboardSimulator_0 = new KeyboardSimulator();
		this.mouseSimulator_0 = new MouseSimulator();
		this.gclass4_0 = new GClass4(this.keyboardSimulator_0, this.mouseSimulator_0);
		this.settings_0 = settings_1;
		this.gclass15_0 = new GClass15();
		this.gclass7_0 = new GClass7();
		this.gdelegate1_0 = gdelegate1_1;
	}

	// Token: 0x17000001 RID: 1
	// (get) Token: 0x06000061 RID: 97 RVA: 0x000053D0 File Offset: 0x000035D0
	// (set) Token: 0x06000062 RID: 98 RVA: 0x000053E4 File Offset: 0x000035E4
	public GClass10 GClass10_0 { get; set; }

	// Token: 0x06000063 RID: 99 RVA: 0x000053F8 File Offset: 0x000035F8
	public void method_0()
	{
		this.ikeyboardMouseEvents_0 = Hook.GlobalEvents();
		this.ikeyboardMouseEvents_0.KeyDown += this.ikeyboardMouseEvents_0_KeyDown;
		this.ikeyboardMouseEvents_0.KeyUp += this.ikeyboardMouseEvents_0_KeyUp;
		this.bool_1 = true;
	}

	// Token: 0x06000064 RID: 100 RVA: 0x00005448 File Offset: 0x00003648
	public void method_1()
	{
		if (this.bool_1)
		{
			for (;;)
			{
				IL_79:
				this.ikeyboardMouseEvents_0.KeyDown -= this.ikeyboardMouseEvents_0_KeyDown;
				for (;;)
				{
					IL_60:
					this.ikeyboardMouseEvents_0.KeyUp -= this.ikeyboardMouseEvents_0_KeyUp;
					for (;;)
					{
						this.ikeyboardMouseEvents_0.Dispose();
						GClass4 gclass = this.gclass4_0;
						if (gclass != null)
						{
							gclass.method_1();
							uint num;
							switch ((num = (num * 4243763548u ^ 418243807u ^ 1079495160u)) % 7u)
							{
							case 0u:
								goto IL_60;
							case 2u:
								goto IL_94;
							case 3u:
							case 4u:
								return;
							case 5u:
								continue;
							case 6u:
								goto IL_79;
							}
							goto Block_3;
						}
						goto IL_93;
					}
				}
			}
			Block_3:
			return;
			IL_93:
			IL_94:
			this.bool_1 = false;
			return;
		}
	}

	// Token: 0x06000065 RID: 101 RVA: 0x000054F0 File Offset: 0x000036F0
	private void ikeyboardMouseEvents_0_KeyUp(object sender, KeyEventArgs e)
	{
		if (e.KeyCode != this.settings_0.OrbwalkHotkey)
		{
			if (e.KeyCode != this.settings_0.DetectionHotkey)
			{
				return;
			}
		}
		this.bool_0 = false;
		this.gclass4_0.method_1();
		this.method_3();
	}

	// Token: 0x06000066 RID: 102 RVA: 0x00005540 File Offset: 0x00003740
	private void ikeyboardMouseEvents_0_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == this.settings_0.OrbwalkHotkey && !this.bool_0 && this.gdelegate1_0())
		{
			this.gclass4_0.method_0(this.gclass15_0, this.GClass10_0, this.gclass7_0, new GClass14(new GClass6().method_1()), false, this.settings_0);
			this.bool_0 = true;
			this.method_2();
			return;
		}
		if (e.KeyCode == this.settings_0.DetectionHotkey && !this.bool_0 && this.gdelegate1_0())
		{
			this.gclass4_0.method_0(this.gclass15_0, this.GClass10_0, this.gclass7_0, new GClass14(new GClass6().method_1()), true, this.settings_0);
			this.bool_0 = true;
			this.method_2();
		}
	}

	// Token: 0x06000067 RID: 103 RVA: 0x00005620 File Offset: 0x00003820
	[MethodImpl(MethodImplOptions.Synchronized)]
	private void method_2()
	{
		if (!this.bool_2)
		{
			this.keyboardSimulator_0.KeyPress(122);
			this.bool_2 = true;
		}
		if (!this.bool_3)
		{
			this.keyboardSimulator_0.KeyDown(67);
			this.bool_3 = true;
		}
	}

	// Token: 0x06000068 RID: 104 RVA: 0x00005668 File Offset: 0x00003868
	[MethodImpl(MethodImplOptions.Synchronized)]
	private void method_3()
	{
		GClass16.smethod_1();
		Thread.Sleep(10);
		if (this.bool_2)
		{
			this.keyboardSimulator_0.KeyPress(122);
			this.bool_2 = false;
		}
		if (this.bool_3)
		{
			this.keyboardSimulator_0.KeyUp(67);
			this.bool_3 = false;
		}
	}

	// Token: 0x04000045 RID: 69
	private IKeyboardMouseEvents ikeyboardMouseEvents_0;

	// Token: 0x04000046 RID: 70
	private readonly GClass4 gclass4_0;

	// Token: 0x04000047 RID: 71
	private bool bool_0;

	// Token: 0x04000048 RID: 72
	private readonly Settings settings_0;

	// Token: 0x04000049 RID: 73
	private bool bool_1;

	// Token: 0x0400004A RID: 74
	private GClass15 gclass15_0;

	// Token: 0x0400004B RID: 75
	private GClass7 gclass7_0;

	// Token: 0x0400004C RID: 76
	private readonly WHfCnaeAMEFPwbVHgQkWFbdtQGiZA.GDelegate1 gdelegate1_0;

	// Token: 0x0400004D RID: 77
	private bool bool_2;

	// Token: 0x0400004E RID: 78
	private bool bool_3;

	// Token: 0x0400004F RID: 79
	private KeyboardSimulator keyboardSimulator_0;

	// Token: 0x04000050 RID: 80
	private MouseSimulator mouseSimulator_0;

	// Token: 0x04000051 RID: 81
	[CompilerGenerated]
	private GClass10 gclass10_0;
}
