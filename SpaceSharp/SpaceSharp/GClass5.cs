using System;
using System.Collections.Generic;
using System.Management;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;

// Token: 0x0200001F RID: 31
public class GClass5
{
	// Token: 0x0600014E RID: 334 RVA: 0x0000779C File Offset: 0x0000599C
	public GClass5()
	{
		this.httpClient_0 = new HttpClient();
	}

	// Token: 0x0600014F RID: 335 RVA: 0x000077BC File Offset: 0x000059BC
	public string method_0(string string_0)
	{
		FormUrlEncodedContent content = new FormUrlEncodedContent(new Dictionary<string, string>
		{
			{
				<Module>.smethod_8<string>(1346626668u),
				string_0
			},
			{
				<Module>.smethod_6<string>(2087939152u),
				this.method_1()
			}
		});
		return this.httpClient_0.PostAsync(<Module>.smethod_9<string>(3792360320u), content).Result.Content.ReadAsStringAsync().Result;
	}

	// Token: 0x06000150 RID: 336 RVA: 0x00007828 File Offset: 0x00005A28
	private string method_1()
	{
		string userName = Environment.UserName;
		string str = this.method_2();
		return BitConverter.ToString(SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(userName + <Module>.smethod_5<string>(3290006871u) + str))).Replace(<Module>.smethod_7<string>(2302000534u), "");
	}

	// Token: 0x06000151 RID: 337 RVA: 0x00007880 File Offset: 0x00005A80
	private string method_2()
	{
		try
		{
			string arg = <Module>.smethod_8<string>(1558657904u);
			ManagementScope managementScope = new ManagementScope(string.Format(<Module>.smethod_8<string>(2281734348u), arg), null);
			managementScope.Connect();
			ObjectQuery query = new ObjectQuery(<Module>.smethod_7<string>(3108402595u));
			using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = new ManagementObjectSearcher(managementScope, query).Get().GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					return ((ManagementObject)enumerator.Current)[<Module>.smethod_6<string>(2713798179u)].ToString();
				}
			}
		}
		catch (Exception)
		{
			return string.Empty;
		}
		return string.Empty;
	}

	// Token: 0x04000086 RID: 134
	private readonly HttpClient httpClient_0;
}
