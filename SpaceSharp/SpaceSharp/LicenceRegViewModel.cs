using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Management;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Markup;
using Codename_SpaceGliderV2.Logic.Model.Settings;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using NLog;

// Token: 0x02000015 RID: 21
public class WHfCnaeAMEFPwbVHgQkWFbdtQGiZA : MetroWindow, IComponentConnector
{
	// Token: 0x060000BC RID: 188 RVA: 0x00005D68 File Offset: 0x00003F68
	public WHfCnaeAMEFPwbVHgQkWFbdtQGiZA(GClass12 gclass12_0)
	{
		this.InitializeComponent();
		this.gclass6_0 = new GClass6();
		this.method_0();
		this.method_10();
		this.settings_0 = GClass13.smethod_0();
		if (this.settings_0 != null)
		{
			this.slider_0.Value = (double)this.settings_0.WindupMultiplier;
			this.slider_1.Value = (double)this.settings_0.TotalDelayMultiplier;
			this.comboBox_1.SelectedValue = this.settings_0.DetectionHotkey;
			this.comboBox_0.SelectedValue = this.settings_0.OrbwalkHotkey;
			this.comboBox_2.SelectedValue = this.settings_0.StartStopHotkey;
			this.checkBox_1.IsChecked = new bool?(this.settings_0.ShowRangeindicator);
			this.checkBox_0.IsChecked = new bool?(this.settings_0.UseEmergencyStrategy);
		}
		else
		{
			this.settings_0 = new Settings(Keys.Space, Keys.N, Keys.Return, 0, 0, gclass12_0.String_0, this.checkBox_0.IsChecked.GetValueOrDefault(), this.checkBox_1.IsChecked.GetValueOrDefault(), this.toggleSwitch_1.IsChecked.GetValueOrDefault());
			this.comboBox_1.SelectedItem = Keys.Space;
			this.comboBox_0.SelectedItem = Keys.LControlKey;
			this.comboBox_2.SelectedItem = Keys.Return;
		}
		base.TitlebarHeight = 39;
		this.settings_0.LicenceKey = gclass12_0.String_0;
		this.label_1.Content = gclass12_0.String_1;
		this.method_5(gclass12_0.String_0);
		this.method_6();
		this.method_7(this.comboBox_1);
		this.method_7(this.comboBox_0);
		this.method_7(this.comboBox_2);
		WHfCnaeAMEFPwbVHgQkWFbdtQGiZA.GDelegate0 gdelegate0_ = new WHfCnaeAMEFPwbVHgQkWFbdtQGiZA.GDelegate0(this.method_1);
		WHfCnaeAMEFPwbVHgQkWFbdtQGiZA.GDelegate2 gdelegate2_ = new WHfCnaeAMEFPwbVHgQkWFbdtQGiZA.GDelegate2(this.method_3);
		WHfCnaeAMEFPwbVHgQkWFbdtQGiZA.GDelegate1 gdelegate1_ = new WHfCnaeAMEFPwbVHgQkWFbdtQGiZA.GDelegate1(this.method_2);
		this.class6_0 = new Class6(this.settings_0, gdelegate1_);
		this.gclass3_0 = new GClass3(this.settings_0, gdelegate0_, gdelegate2_);
		this.gclass3_0.method_0();
	}

	// Token: 0x060000BD RID: 189 RVA: 0x00005FAC File Offset: 0x000041AC
	private void method_0()
	{
		try
		{
			System.Drawing.Size size = Screen.PrimaryScreen.Bounds.Size;
			string str = string.Empty;
			string str2 = string.Empty;
			foreach (ManagementBaseObject managementBaseObject in new ManagementObjectSearcher(<Module>.smethod_9<string>(3723509191u), <Module>.smethod_8<string>(2614723247u)).Get())
			{
				str2 = ((ManagementObject)managementBaseObject)[<Module>.smethod_5<string>(2705017809u)].ToString();
			}
			foreach (ManagementBaseObject managementBaseObject2 in new ManagementObjectSearcher(<Module>.smethod_8<string>(1424092963u), <Module>.smethod_7<string>(1611301788u)).Get())
			{
				str = ((ManagementObject)managementBaseObject2)[<Module>.smethod_8<string>(392486106u)].ToString();
			}
			Logger logger = WHfCnaeAMEFPwbVHgQkWFbdtQGiZA.logger_0;
			string str3 = <Module>.smethod_5<string>(505279621u);
			System.Drawing.Size size2 = size;
			logger.Info(str3 + size2.ToString());
			WHfCnaeAMEFPwbVHgQkWFbdtQGiZA.logger_0.Info(<Module>.smethod_7<string>(3423952850u) + str);
			WHfCnaeAMEFPwbVHgQkWFbdtQGiZA.logger_0.Info(<Module>.smethod_9<string>(929228930u) + str2);
		}
		catch (Exception ex)
		{
			WHfCnaeAMEFPwbVHgQkWFbdtQGiZA.logger_0.Error(ex, <Module>.smethod_7<string>(2137215770u));
		}
	}

	// Token: 0x060000BE RID: 190 RVA: 0x00006160 File Offset: 0x00004360
	private void toggleSwitch_0_IsCheckedChanged(object sender, EventArgs e)
	{
		if (!this.toggleSwitch_0.IsChecked.GetValueOrDefault())
		{
			this.class6_0.method_1();
			return;
		}
		if (!this.method_2())
		{
			return;
		}
		if (this.comboBox_3.SelectedValue == null)
		{
			DialogManager.ShowMessageAsync(this, "", <Module>.smethod_7<string>(2463282812u), 0, null);
			this.toggleSwitch_0.IsChecked = new bool?(false);
			return;
		}
		this.class6_0.method_0();
	}

	// Token: 0x060000BF RID: 191 RVA: 0x000061DC File Offset: 0x000043DC
	public void method_1()
	{
		if (!this.method_2())
		{
			return;
		}
		this.toggleSwitch_0.IsChecked = new bool?(!this.toggleSwitch_0.IsChecked.GetValueOrDefault());
		if (!this.toggleSwitch_0.IsChecked.GetValueOrDefault())
		{
			this.class6_0.method_1();
			return;
		}
		this.class6_0.method_0();
	}

	// Token: 0x060000C0 RID: 192 RVA: 0x00006244 File Offset: 0x00004444
	public bool method_2()
	{
		bool result;
		try
		{
			ValueTuple<double, double> valueTuple = this.gclass6_0.method_0();
			if (valueTuple.Item2 == 0.0)
			{
				if (valueTuple.Item1 == 0.0)
				{
					return false;
				}
			}
			result = true;
		}
		catch (Exception)
		{
			if (!base.IsAnyDialogOpen)
			{
				DialogManager.ShowMessageAsync(this, "", <Module>.smethod_9<string>(3688948521u), 0, null);
			}
			Class6 @class = this.class6_0;
			if (@class != null)
			{
				@class.method_1();
			}
			this.toggleSwitch_0.IsChecked = new bool?(false);
			result = false;
		}
		return result;
	}

	// Token: 0x060000C1 RID: 193 RVA: 0x000062E4 File Offset: 0x000044E4
	public void method_3()
	{
		if (base.WindowState == WindowState.Minimized)
		{
			base.WindowState = WindowState.Normal;
			this.method_12();
			return;
		}
		base.WindowState = WindowState.Minimized;
	}

	// Token: 0x060000C2 RID: 194 RVA: 0x00006310 File Offset: 0x00004510
	public void method_4(object sender, CancelEventArgs e)
	{
		this.class6_0.method_1();
		this.gclass3_0.method_1();
		GClass13.smethod_1(this.settings_0);
		Environment.Exit(Environment.ExitCode);
	}

	// Token: 0x060000C3 RID: 195 RVA: 0x00006348 File Offset: 0x00004548
	private void comboBox_3_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		this.class6_0.GClass10_0 = (GClass10)this.comboBox_3.SelectedValue;
	}

	// Token: 0x060000C4 RID: 196 RVA: 0x00006370 File Offset: 0x00004570
	private void method_5(string string_0)
	{
		WHfCnaeAMEFPwbVHgQkWFbdtQGiZA.Class8 @class = new WHfCnaeAMEFPwbVHgQkWFbdtQGiZA.Class8();
		@class.string_0 = string_0;
		new Thread(new ThreadStart(@class.method_0)).Start();
	}

	// Token: 0x060000C5 RID: 197 RVA: 0x000063A0 File Offset: 0x000045A0
	private void comboBox_0_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		this.settings_0.OrbwalkHotkey = (Keys)this.comboBox_0.SelectedItem;
	}

	// Token: 0x060000C6 RID: 198 RVA: 0x000063C8 File Offset: 0x000045C8
	private void comboBox_2_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		this.settings_0.StartStopHotkey = (Keys)this.comboBox_2.SelectedItem;
	}

	// Token: 0x060000C7 RID: 199 RVA: 0x000063F0 File Offset: 0x000045F0
	private void comboBox_1_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		this.settings_0.DetectionHotkey = (Keys)this.comboBox_1.SelectedItem;
	}

	// Token: 0x060000C8 RID: 200 RVA: 0x00006418 File Offset: 0x00004618
	private void method_6()
	{
		using (base.Dispatcher.DisableProcessing())
		{
			foreach (GClass10 newItem in GClass9.IEnumerable_0)
			{
				this.comboBox_3.Items.Add(newItem);
			}
		}
	}

	// Token: 0x060000C9 RID: 201 RVA: 0x00006498 File Offset: 0x00004698
	private void method_7(System.Windows.Controls.ComboBox comboBox_4)
	{
		using (base.Dispatcher.DisableProcessing())
		{
			comboBox_4.Items.Add(Keys.Return);
			comboBox_4.Items.Add(Keys.Space);
			comboBox_4.Items.Add(Keys.LShiftKey);
			comboBox_4.Items.Add(Keys.Alt);
			comboBox_4.Items.Add(Keys.LControlKey);
			comboBox_4.Items.Add(Keys.A);
			comboBox_4.Items.Add(Keys.B);
			comboBox_4.Items.Add(Keys.C);
			comboBox_4.Items.Add(Keys.D);
			comboBox_4.Items.Add(Keys.E);
			comboBox_4.Items.Add(Keys.F);
			comboBox_4.Items.Add(Keys.G);
			comboBox_4.Items.Add(Keys.H);
			comboBox_4.Items.Add(Keys.I);
			comboBox_4.Items.Add(Keys.J);
			comboBox_4.Items.Add(Keys.K);
			comboBox_4.Items.Add(Keys.L);
			comboBox_4.Items.Add(Keys.M);
			comboBox_4.Items.Add(Keys.N);
			comboBox_4.Items.Add(Keys.O);
			comboBox_4.Items.Add(Keys.P);
			comboBox_4.Items.Add(Keys.Q);
			comboBox_4.Items.Add(Keys.R);
			comboBox_4.Items.Add(Keys.S);
			comboBox_4.Items.Add(Keys.T);
			comboBox_4.Items.Add(Keys.U);
			comboBox_4.Items.Add(Keys.V);
			comboBox_4.Items.Add(Keys.W);
			comboBox_4.Items.Add(Keys.X);
			comboBox_4.Items.Add(Keys.Y);
			comboBox_4.Items.Add(Keys.Z);
			comboBox_4.Items.Add(Keys.D0);
			comboBox_4.Items.Add(Keys.D1);
			comboBox_4.Items.Add(Keys.D2);
			comboBox_4.Items.Add(Keys.D3);
			comboBox_4.Items.Add(Keys.D4);
			comboBox_4.Items.Add(Keys.D5);
			comboBox_4.Items.Add(Keys.D6);
			comboBox_4.Items.Add(Keys.D7);
			comboBox_4.Items.Add(Keys.D8);
			comboBox_4.Items.Add(Keys.D9);
			comboBox_4.Items.Add(Keys.F1);
			comboBox_4.Items.Add(Keys.F2);
			comboBox_4.Items.Add(Keys.F3);
			comboBox_4.Items.Add(Keys.F4);
			comboBox_4.Items.Add(Keys.F5);
			comboBox_4.Items.Add(Keys.F6);
			comboBox_4.Items.Add(Keys.F7);
			comboBox_4.Items.Add(Keys.F8);
			comboBox_4.Items.Add(Keys.F9);
			comboBox_4.Items.Add(Keys.F10);
			comboBox_4.Items.Add(Keys.F11);
			comboBox_4.Items.Add(Keys.F12);
		}
	}

	// Token: 0x060000CA RID: 202 RVA: 0x000068D8 File Offset: 0x00004AD8
	private void method_8(object sender, RoutedPropertyChangedEventArgs<double> e)
	{
		this.settings_0.WindupMultiplier = (int)e.NewValue;
	}

	// Token: 0x060000CB RID: 203 RVA: 0x000068F8 File Offset: 0x00004AF8
	private void method_9(object sender, RoutedPropertyChangedEventArgs<double> e)
	{
		this.settings_0.TotalDelayMultiplier = (int)e.NewValue;
	}

	// Token: 0x060000CC RID: 204 RVA: 0x00006918 File Offset: 0x00004B18
	private void method_10()
	{
		this.label_0.Content = <Module>.smethod_6<string>(1680767519u) + Assembly.GetExecutingAssembly().GetName().Version.ToString() + <Module>.smethod_5<string>(853861376u);
	}

	// Token: 0x060000CD RID: 205 RVA: 0x00005B8C File Offset: 0x00003D8C
	private void method_11(object sender, MouseButtonEventArgs e)
	{
		if (e.ChangedButton == MouseButton.Left)
		{
			base.DragMove();
		}
	}

	// Token: 0x060000CE RID: 206 RVA: 0x00006960 File Offset: 0x00004B60
	private void checkBox_0_Unchecked(object sender, RoutedEventArgs e)
	{
		this.settings_0.UseEmergencyStrategy = this.checkBox_0.IsChecked.GetValueOrDefault();
	}

	// Token: 0x060000CF RID: 207 RVA: 0x0000698C File Offset: 0x00004B8C
	private void checkBox_1_Unchecked(object sender, RoutedEventArgs e)
	{
		this.settings_0.ShowRangeindicator = this.checkBox_1.IsChecked.GetValueOrDefault();
	}

	// Token: 0x060000D0 RID: 208 RVA: 0x000069B8 File Offset: 0x00004BB8
	private void toggleSwitch_1_IsCheckedChanged(object sender, EventArgs e)
	{
		this.settings_0.DebugMode = this.toggleSwitch_1.IsChecked.GetValueOrDefault();
		DialogManager.ShowMessageAsync(this, "", <Module>.smethod_8<string>(1072071182u), 0, null);
	}

	// Token: 0x060000D1 RID: 209 RVA: 0x000069FC File Offset: 0x00004BFC
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (this.bool_0)
		{
			return;
		}
		this.bool_0 = true;
		Uri resourceLocator = new Uri(<Module>.smethod_9<string>(1187893533u), UriKind.Relative);
		System.Windows.Application.LoadComponent(this, resourceLocator);
	}

	// Token: 0x060000D2 RID: 210 RVA: 0x00006A34 File Offset: 0x00004C34
	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		case 1:
			((WHfCnaeAMEFPwbVHgQkWFbdtQGiZA)target).Closing += this.method_4;
			((WHfCnaeAMEFPwbVHgQkWFbdtQGiZA)target).MouseDown += this.method_11;
			return;
		case 2:
			this.label_0 = (System.Windows.Controls.Label)target;
			return;
		case 3:
			this.comboBox_0 = (System.Windows.Controls.ComboBox)target;
			this.comboBox_0.SelectionChanged += this.comboBox_0_SelectionChanged;
			return;
		case 4:
			this.comboBox_1 = (System.Windows.Controls.ComboBox)target;
			this.comboBox_1.SelectionChanged += this.comboBox_1_SelectionChanged;
			return;
		case 5:
			this.comboBox_2 = (System.Windows.Controls.ComboBox)target;
			this.comboBox_2.SelectionChanged += this.comboBox_2_SelectionChanged;
			return;
		case 6:
			this.slider_0 = (Slider)target;
			this.slider_0.ValueChanged += this.method_8;
			return;
		case 7:
			this.slider_1 = (Slider)target;
			this.slider_1.ValueChanged += this.method_9;
			return;
		case 8:
			this.toggleSwitch_0 = (ToggleSwitch)target;
			this.toggleSwitch_0.IsCheckedChanged += this.toggleSwitch_0_IsCheckedChanged;
			return;
		case 9:
			this.comboBox_3 = (System.Windows.Controls.ComboBox)target;
			this.comboBox_3.SelectionChanged += this.comboBox_3_SelectionChanged;
			return;
		case 10:
			this.checkBox_0 = (System.Windows.Controls.CheckBox)target;
			this.checkBox_0.Checked += this.checkBox_0_Unchecked;
			this.checkBox_0.Unchecked += this.checkBox_0_Unchecked;
			return;
		case 11:
			this.label_1 = (System.Windows.Controls.Label)target;
			return;
		case 12:
			this.checkBox_1 = (System.Windows.Controls.CheckBox)target;
			this.checkBox_1.Checked += this.checkBox_1_Unchecked;
			this.checkBox_1.Unchecked += this.checkBox_1_Unchecked;
			return;
		case 13:
			this.toggleSwitch_1 = (ToggleSwitch)target;
			this.toggleSwitch_1.IsCheckedChanged += this.toggleSwitch_1_IsCheckedChanged;
			return;
		default:
			this.bool_0 = true;
			return;
		}
	}

	// Token: 0x060000E4 RID: 228 RVA: 0x00006C7C File Offset: 0x00004E7C
	bool method_12()
	{
		return base.Focus();
	}

	// Token: 0x04000060 RID: 96
	private static readonly Logger logger_0 = LogManager.GetCurrentClassLogger();

	// Token: 0x04000061 RID: 97
	private readonly Class6 class6_0;

	// Token: 0x04000062 RID: 98
	private readonly Settings settings_0;

	// Token: 0x04000063 RID: 99
	private readonly GClass3 gclass3_0;

	// Token: 0x04000064 RID: 100
	private GClass6 gclass6_0;

	// Token: 0x04000065 RID: 101
	internal System.Windows.Controls.Label label_0;

	// Token: 0x04000066 RID: 102
	internal System.Windows.Controls.ComboBox comboBox_0;

	// Token: 0x04000067 RID: 103
	internal System.Windows.Controls.ComboBox comboBox_1;

	// Token: 0x04000068 RID: 104
	internal System.Windows.Controls.ComboBox comboBox_2;

	// Token: 0x04000069 RID: 105
	internal Slider slider_0;

	// Token: 0x0400006A RID: 106
	internal Slider slider_1;

	// Token: 0x0400006B RID: 107
	internal ToggleSwitch toggleSwitch_0;

	// Token: 0x0400006C RID: 108
	internal System.Windows.Controls.ComboBox comboBox_3;

	// Token: 0x0400006D RID: 109
	internal System.Windows.Controls.CheckBox checkBox_0;

	// Token: 0x0400006E RID: 110
	internal System.Windows.Controls.Label label_1;

	// Token: 0x0400006F RID: 111
	internal System.Windows.Controls.CheckBox checkBox_1;

	// Token: 0x04000070 RID: 112
	internal ToggleSwitch toggleSwitch_1;

	// Token: 0x04000071 RID: 113
	private bool bool_0;

	// Token: 0x02000016 RID: 22
	// (Invoke) Token: 0x06000102 RID: 258
	public delegate void GDelegate0();

	// Token: 0x02000017 RID: 23
	// (Invoke) Token: 0x06000106 RID: 262
	public delegate bool GDelegate1();

	// Token: 0x02000018 RID: 24
	// (Invoke) Token: 0x0600010A RID: 266
	public delegate void GDelegate2();

	// Token: 0x02000019 RID: 25
	[CompilerGenerated]
	private sealed class Class8
	{
		// Token: 0x0600010E RID: 270 RVA: 0x00006C90 File Offset: 0x00004E90
		internal void method_0()
		{
			int num = 0;
			GClass5 gclass = new GClass5();
			for (;;)
			{
				string a = gclass.method_0(this.string_0);
				if (a == <Module>.smethod_7<string>(3848192119u))
				{
					goto IL_32;
				}
				if (a == <Module>.smethod_6<string>(4093474176u) || a == <Module>.smethod_6<string>(3614187338u))
				{
					goto IL_32;
				}
				num = 0;
				IL_36:
				if (num > 3)
				{
					Environment.Exit(Environment.ExitCode);
				}
				Thread.Sleep(300000);
				continue;
				IL_32:
				num++;
				goto IL_36;
			}
		}

		// Token: 0x04000072 RID: 114
		public string string_0;
	}
}
