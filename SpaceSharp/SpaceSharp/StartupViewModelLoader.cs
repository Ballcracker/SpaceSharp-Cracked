using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using AutoUpdaterDotNET;
using Codename_SpaceGliderV2.Logic.Model.Settings;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using Newtonsoft.Json.Linq;

// Token: 0x02000013 RID: 19
public class EmYAmnbJAmPFVoNPovNzkiULjdTGA : MetroWindow, IComponentConnector
{
	// Token: 0x0600008D RID: 141 RVA: 0x00005998 File Offset: 0x00003B98
	public EmYAmnbJAmPFVoNPovNzkiULjdTGA()
	{
		AutoUpdater.Mandatory = true;
		AutoUpdater.UpdateMode = 2;
		AutoUpdater.Start(<Module>.smethod_7<string>(2126698983u), null);
		AutoUpdater.ApplicationExitEvent += new AutoUpdater.ApplicationExitEventHandler(EmYAmnbJAmPFVoNPovNzkiULjdTGA.Class7.<>9.method_0);
		this.InitializeComponent();
		Settings settings = GClass13.smethod_0();
		if (settings != null)
		{
			this.textBox_0.Text = settings.LicenceKey;
		}
	}

	// Token: 0x0600008E RID: 142 RVA: 0x00005A0C File Offset: 0x00003C0C
	private void button_0_Click(object sender, RoutedEventArgs e)
	{
		string string_ = new GClass5().method_0(this.textBox_0.Text);
		this.method_0(string_);
	}

	// Token: 0x0600008F RID: 143 RVA: 0x00005A38 File Offset: 0x00003C38
	private void method_0(string string_0)
	{
		if (string_0 != null)
		{
			if (string_0 == <Module>.smethod_6<string>(2415970243u))
			{
				DialogManager.ShowMessageAsync(this, "", <Module>.smethod_6<string>(866424253u), 0, null);
				return;
			}
			if (string_0 == <Module>.smethod_7<string>(142248856u))
			{
				DialogManager.ShowMessageAsync(this, "", <Module>.smethod_7<string>(3785082068u), 0, null);
				return;
			}
			if (string_0 == <Module>.smethod_5<string>(3275985065u))
			{
				DialogManager.ShowMessageAsync(this, "", <Module>.smethod_8<string>(2137652966u), 0, null);
				return;
			}
		}
		JObject jobject = JObject.Parse(string_0);
		string string_ = jobject[<Module>.smethod_9<string>(1394987342u)].ToObject<string>();
		string string_2 = jobject[<Module>.smethod_9<string>(4206547938u)].ToObject<string>();
		WHfCnaeAMEFPwbVHgQkWFbdtQGiZA whfCnaeAMEFPwbVHgQkWFbdtQGiZA = new WHfCnaeAMEFPwbVHgQkWFbdtQGiZA(new GClass12(string_, string_2));
		whfCnaeAMEFPwbVHgQkWFbdtQGiZA.Owner = this;
		base.Hide();
		whfCnaeAMEFPwbVHgQkWFbdtQGiZA.ShowDialog();
	}

	// Token: 0x06000090 RID: 144 RVA: 0x00005B1C File Offset: 0x00003D1C
	public void method_1(object sender, CancelEventArgs e)
	{
		Environment.Exit(Environment.ExitCode);
	}

	// Token: 0x06000091 RID: 145 RVA: 0x00005B34 File Offset: 0x00003D34
	private void button_1_Click(object sender, RoutedEventArgs e)
	{
		Process.Start(new ProcessStartInfo(<Module>.smethod_6<string>(1071180959u)));
		e.Handled = true;
	}

	// Token: 0x06000092 RID: 146 RVA: 0x00005B60 File Offset: 0x00003D60
	private void button_2_Click(object sender, RoutedEventArgs e)
	{
		Process.Start(new ProcessStartInfo(<Module>.smethod_9<string>(515311523u)));
		e.Handled = true;
	}

	// Token: 0x06000093 RID: 147 RVA: 0x00005B8C File Offset: 0x00003D8C
	private void method_2(object sender, MouseButtonEventArgs e)
	{
		if (e.ChangedButton == MouseButton.Left)
		{
			base.DragMove();
		}
	}

	// Token: 0x06000094 RID: 148 RVA: 0x00005BA8 File Offset: 0x00003DA8
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (this.bool_0)
		{
			return;
		}
		this.bool_0 = true;
		Uri resourceLocator = new Uri(<Module>.smethod_5<string>(2433555987u), UriKind.Relative);
		Application.LoadComponent(this, resourceLocator);
	}

	// Token: 0x06000095 RID: 149 RVA: 0x00005BE0 File Offset: 0x00003DE0
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		case 1:
			((EmYAmnbJAmPFVoNPovNzkiULjdTGA)target).Closing += this.method_1;
			((EmYAmnbJAmPFVoNPovNzkiULjdTGA)target).MouseDown += this.method_2;
			return;
		case 2:
			this.textBox_0 = (TextBox)target;
			return;
		case 3:
			this.button_0 = (Button)target;
			this.button_0.Click += this.button_0_Click;
			return;
		case 4:
			this.button_1 = (Button)target;
			this.button_1.Click += this.button_1_Click;
			return;
		case 5:
			this.button_2 = (Button)target;
			this.button_2.Click += this.button_2_Click;
			return;
		default:
			this.bool_0 = true;
			return;
		}
	}

	// Token: 0x04000059 RID: 89
	internal TextBox textBox_0;

	// Token: 0x0400005A RID: 90
	internal Button button_0;

	// Token: 0x0400005B RID: 91
	internal Button button_1;

	// Token: 0x0400005C RID: 92
	internal Button button_2;

	// Token: 0x0400005D RID: 93
	private bool bool_0;

	// Token: 0x02000014 RID: 20
	[CompilerGenerated]
	[Serializable]
	private sealed class Class7
	{
		// Token: 0x060000AF RID: 175 RVA: 0x00005CD0 File Offset: 0x00003ED0
		internal void method_0()
		{
			Environment.Exit(Environment.ExitCode);
			Process.Start(new ProcessStartInfo
			{
				Arguments = <Module>.smethod_8<string>(2976261469u) + Assembly.GetExecutingAssembly().CodeBase.Replace(<Module>.smethod_9<string>(825817131u), string.Empty).Replace(<Module>.smethod_7<string>(1176545732u), <Module>.smethod_7<string>(4076086934u)) + <Module>.smethod_6<string>(1715654232u),
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = <Module>.smethod_6<string>(1236367394u)
			});
		}

		// Token: 0x0400005E RID: 94
		public static readonly EmYAmnbJAmPFVoNPovNzkiULjdTGA.Class7 <>9 = new EmYAmnbJAmPFVoNPovNzkiULjdTGA.Class7();

		// Token: 0x0400005F RID: 95
		public static AutoUpdater.ApplicationExitEventHandler <>9__0_0;
	}
}
