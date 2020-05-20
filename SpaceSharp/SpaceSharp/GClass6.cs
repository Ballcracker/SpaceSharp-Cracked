using System;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Newtonsoft.Json.Linq;

// Token: 0x02000021 RID: 33
public class GClass6
{
	// Token: 0x0600016B RID: 363 RVA: 0x0000793C File Offset: 0x00005B3C
	public GClass6()
	{
		ServicePointManager.ServerCertificateValidationCallback = (RemoteCertificateValidationCallback)Delegate.Combine(ServicePointManager.ServerCertificateValidationCallback, new RemoteCertificateValidationCallback(GClass6.Class10.<>9.method_0));
	}

	// Token: 0x0600016C RID: 364 RVA: 0x00007984 File Offset: 0x00005B84
	[return: TupleElementNames(new string[]
	{
		"Speed",
		"Range"
	})]
	public ValueTuple<double, double> method_0()
	{
		this.webRequest_0 = WebRequest.Create(<Module>.smethod_5<string>(3930428692u));
		ValueTuple<double, double> result;
		using (StreamReader streamReader = new StreamReader(this.webRequest_0.GetResponse().GetResponseStream()))
		{
			JObject jobject = JObject.Parse(streamReader.ReadToEnd());
			JToken jtoken = jobject[<Module>.smethod_7<string>(1169531431u)][<Module>.smethod_5<string>(2552086873u)];
			JToken jtoken2 = jobject[<Module>.smethod_6<string>(2253125587u)][<Module>.smethod_8<string>(3322857646u)];
			result = new ValueTuple<double, double>(jtoken.ToObject<double>(), jtoken2.ToObject<double>());
		}
		return result;
	}

	// Token: 0x0600016D RID: 365 RVA: 0x00007A38 File Offset: 0x00005C38
	public GEnum1 method_1()
	{
		this.webRequest_0 = WebRequest.Create(<Module>.smethod_5<string>(2190137777u));
		GEnum1 result;
		using (StreamReader streamReader = new StreamReader(this.webRequest_0.GetResponse().GetResponseStream()))
		{
			JArray jarray = JArray.Parse(streamReader.ReadToEnd());
			string b = this.method_2();
			foreach (JToken jtoken in jarray)
			{
				if (jtoken[<Module>.smethod_6<string>(1462080125u)].ToString() == b)
				{
					return (jtoken[<Module>.smethod_6<string>(2420653801u)].ToString() == <Module>.smethod_7<string>(2021512455u)) ? GEnum1.ORDER : GEnum1.CHAOS;
				}
			}
			result = GEnum1.UNKNOWN;
		}
		return result;
	}

	// Token: 0x0600016E RID: 366 RVA: 0x00007B20 File Offset: 0x00005D20
	private string method_2()
	{
		this.webRequest_0 = WebRequest.Create(<Module>.smethod_5<string>(3567825131u));
		string result;
		using (StreamReader streamReader = new StreamReader(this.webRequest_0.GetResponse().GetResponseStream()))
		{
			result = streamReader.ReadToEnd().Trim(new char[]
			{
				'"'
			});
		}
		return result;
	}

	// Token: 0x0400008B RID: 139
	private WebRequest webRequest_0;

	// Token: 0x02000022 RID: 34
	[CompilerGenerated]
	[Serializable]
	private sealed class Class10
	{
		// Token: 0x06000183 RID: 387 RVA: 0x00007BA4 File Offset: 0x00005DA4
		internal bool method_0(object object_0, X509Certificate x509Certificate_0, X509Chain x509Chain_0, SslPolicyErrors sslPolicyErrors_0)
		{
			return true;
		}

		// Token: 0x0400008C RID: 140
		public static readonly GClass6.Class10 <>9 = new GClass6.Class10();

		// Token: 0x0400008D RID: 141
		public static RemoteCertificateValidationCallback <>9__1_0;
	}
}
