using System;
using System.Windows.Forms;
using Codename_SpaceGliderV2.Logic.Model.Settings;
using Gma.System.MouseKeyHook;

// Token: 0x0200001D RID: 29
public class GClass3
{
	// Token: 0x06000129 RID: 297 RVA: 0x00006F48 File Offset: 0x00005148
	public GClass3(Settings settings_1, WHfCnaeAMEFPwbVHgQkWFbdtQGiZA.GDelegate0 gdelegate0_1, WHfCnaeAMEFPwbVHgQkWFbdtQGiZA.GDelegate2 gdelegate2_1)
	{
		this.settings_0 = settings_1;
		this.gdelegate0_0 = gdelegate0_1;
		this.gdelegate2_0 = gdelegate2_1;
	}

	// Token: 0x0600012A RID: 298 RVA: 0x00006F70 File Offset: 0x00005170
	public void method_0()
	{
		this.ikeyboardMouseEvents_0 = Hook.GlobalEvents();
		this.ikeyboardMouseEvents_0.KeyDown += this.ikeyboardMouseEvents_0_KeyDown;
		this.bool_0 = true;
	}

	// Token: 0x0600012B RID: 299 RVA: 0x00006FA8 File Offset: 0x000051A8
	private void ikeyboardMouseEvents_0_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Insert)
		{
			this.gdelegate2_0();
		}
		if (e.KeyCode == this.settings_0.StartStopHotkey)
		{
			this.gdelegate0_0();
		}
	}

	// Token: 0x0600012C RID: 300 RVA: 0x00006FEC File Offset: 0x000051EC
	public void method_1()
	{
		if (!this.bool_0)
		{
			return;
		}
		this.ikeyboardMouseEvents_0.KeyDown -= this.ikeyboardMouseEvents_0_KeyDown;
		this.ikeyboardMouseEvents_0.Dispose();
		this.bool_0 = false;
	}

	// Token: 0x04000077 RID: 119
	private IKeyboardMouseEvents ikeyboardMouseEvents_0;

	// Token: 0x04000078 RID: 120
	private readonly Settings settings_0;

	// Token: 0x04000079 RID: 121
	private bool bool_0;

	// Token: 0x0400007A RID: 122
	private readonly WHfCnaeAMEFPwbVHgQkWFbdtQGiZA.GDelegate0 gdelegate0_0;

	// Token: 0x0400007B RID: 123
	private readonly WHfCnaeAMEFPwbVHgQkWFbdtQGiZA.GDelegate2 gdelegate2_0;
}
