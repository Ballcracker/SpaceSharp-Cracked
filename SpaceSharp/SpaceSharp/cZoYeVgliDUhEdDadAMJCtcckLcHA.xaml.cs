using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Windows;

// Token: 0x02000012 RID: 18
public partial class cZoYeVgliDUhEdDadAMJCtcckLcHA : Application
{
	// Token: 0x06000086 RID: 134 RVA: 0x00005918 File Offset: 0x00003B18
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void method_0()
	{
		if (this.bool_0)
		{
			return;
		}
		this.bool_0 = true;
		base.StartupUri = new Uri(<Module>.smethod_5<string>(4013905063u), UriKind.Relative);
		Uri resourceLocator = new Uri(<Module>.smethod_7<string>(3693924142u), UriKind.Relative);
		Application.LoadComponent(this, resourceLocator);
	}

	// Token: 0x06000087 RID: 135 RVA: 0x00005964 File Offset: 0x00003B64
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[STAThread]
	public static void smethod_0()
	{
		cZoYeVgliDUhEdDadAMJCtcckLcHA cZoYeVgliDUhEdDadAMJCtcckLcHA = new cZoYeVgliDUhEdDadAMJCtcckLcHA();
		cZoYeVgliDUhEdDadAMJCtcckLcHA.method_0();
		cZoYeVgliDUhEdDadAMJCtcckLcHA.Run();
	}

	// Token: 0x04000058 RID: 88
	private bool bool_0;
}
