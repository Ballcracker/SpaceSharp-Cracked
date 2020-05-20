using System;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Codename_SpaceGliderV2.Logic.Model.Settings
{
	// Token: 0x0200002A RID: 42
	[Serializable]
	public class Settings
	{
		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060001BA RID: 442 RVA: 0x0000A980 File Offset: 0x00008B80
		// (set) Token: 0x060001BB RID: 443 RVA: 0x0000A994 File Offset: 0x00008B94
		public Keys DetectionHotkey { get; set; }

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060001BC RID: 444 RVA: 0x0000A9A8 File Offset: 0x00008BA8
		// (set) Token: 0x060001BD RID: 445 RVA: 0x0000A9BC File Offset: 0x00008BBC
		public Keys OrbwalkHotkey { get; set; }

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060001BE RID: 446 RVA: 0x0000A9D0 File Offset: 0x00008BD0
		// (set) Token: 0x060001BF RID: 447 RVA: 0x0000A9E4 File Offset: 0x00008BE4
		public Keys StartStopHotkey { get; set; }

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060001C0 RID: 448 RVA: 0x0000A9F8 File Offset: 0x00008BF8
		// (set) Token: 0x060001C1 RID: 449 RVA: 0x0000AA0C File Offset: 0x00008C0C
		public int WindupMultiplier { get; set; }

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060001C2 RID: 450 RVA: 0x0000AA20 File Offset: 0x00008C20
		// (set) Token: 0x060001C3 RID: 451 RVA: 0x0000AA34 File Offset: 0x00008C34
		public int TotalDelayMultiplier { get; set; }

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060001C4 RID: 452 RVA: 0x0000AA48 File Offset: 0x00008C48
		// (set) Token: 0x060001C5 RID: 453 RVA: 0x0000AA5C File Offset: 0x00008C5C
		public string LicenceKey { get; set; }

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060001C6 RID: 454 RVA: 0x0000AA70 File Offset: 0x00008C70
		// (set) Token: 0x060001C7 RID: 455 RVA: 0x0000AA84 File Offset: 0x00008C84
		public bool UseEmergencyStrategy { get; set; }

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060001C8 RID: 456 RVA: 0x0000AA98 File Offset: 0x00008C98
		// (set) Token: 0x060001C9 RID: 457 RVA: 0x0000AAAC File Offset: 0x00008CAC
		public bool ShowRangeindicator { get; set; }

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060001CA RID: 458 RVA: 0x0000AAC0 File Offset: 0x00008CC0
		// (set) Token: 0x060001CB RID: 459 RVA: 0x0000AAD4 File Offset: 0x00008CD4
		[XmlIgnore]
		public bool DebugMode { get; set; }

		// Token: 0x060001CC RID: 460 RVA: 0x000045F8 File Offset: 0x000027F8
		public Settings()
		{
		}

		// Token: 0x060001CD RID: 461 RVA: 0x0000AAE8 File Offset: 0x00008CE8
		public Settings(Keys detectionHotkey, Keys orbwalkHotkey, Keys startStopHotkey, int windupMultiplier, int totalDelayMultiplier, string licenseKey, bool useEmergencyStrategy, bool showRangeindicator, bool debugMode)
		{
			this.DetectionHotkey = detectionHotkey;
			this.OrbwalkHotkey = orbwalkHotkey;
			this.StartStopHotkey = startStopHotkey;
			this.WindupMultiplier = windupMultiplier;
			this.TotalDelayMultiplier = totalDelayMultiplier;
			this.LicenceKey = licenseKey;
			this.UseEmergencyStrategy = useEmergencyStrategy;
			this.ShowRangeindicator = showRangeindicator;
			this.DebugMode = debugMode;
		}
	}
}
