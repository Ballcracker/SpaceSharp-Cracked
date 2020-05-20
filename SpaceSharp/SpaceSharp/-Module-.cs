using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

// Token: 0x02000001 RID: 1
internal class <Module>
{
	// Token: 0x06000001 RID: 1 RVA: 0x00002A78 File Offset: 0x00000C78
	static <Module>()
	{
		<Module>.smethod_10();
		<Module>.smethod_4();
		<Module>.smethod_2();
		<Module>.smethod_0();
	}

	// Token: 0x06000002 RID: 2 RVA: 0x00002A9C File Offset: 0x00000C9C
	private static void smethod_0()
	{
		string str = <Module>.smethod_7<string>(3956881133u);
		MethodInfo method = typeof(Environment).GetMethod(<Module>.smethod_8<string>(2489674747u), new Type[]
		{
			typeof(string)
		});
		if (method != null && <Module>.smethod_8<string>(2075128716u).Equals(method.Invoke(null, new object[]
		{
			str + <Module>.smethod_5<string>(1542705053u)
		})))
		{
			Environment.FailFast(null);
		}
		new Thread(new ParameterizedThreadStart(<Module>.smethod_1))
		{
			IsBackground = true
		}.Start(null);
	}

	// Token: 0x06000003 RID: 3 RVA: 0x00002B3C File Offset: 0x00000D3C
	private static void smethod_1(object object_0)
	{
		Thread thread = object_0 as Thread;
		if (thread == null)
		{
			thread = new Thread(new ParameterizedThreadStart(<Module>.smethod_1));
			thread.IsBackground = true;
			thread.Start(Thread.CurrentThread);
			Thread.Sleep(500);
		}
		for (;;)
		{
			if (Debugger.IsAttached)
			{
				goto IL_41;
			}
			if (Debugger.IsLogging())
			{
				goto IL_41;
			}
			IL_47:
			if (!thread.IsAlive)
			{
				Environment.FailFast(null);
			}
			Thread.Sleep(1000);
			continue;
			IL_41:
			Environment.FailFast(null);
			goto IL_47;
		}
	}

	// Token: 0x06000004 RID: 4
	[DllImport("kernel32.dll")]
	internal unsafe static extern bool VirtualProtect(byte* pByte_0, int int_0, uint uint_0, ref uint uint_1);

	// Token: 0x06000005 RID: 5 RVA: 0x00002BB0 File Offset: 0x00000DB0
	internal unsafe static void smethod_2()
	{
		Module module = typeof(<Module>).Module;
		byte* ptr = (byte*)((void*)Marshal.GetHINSTANCE(module));
		byte* ptr2 = ptr + 60;
		ptr2 = ptr + *(uint*)ptr2;
		ptr2 += 6;
		ushort num = *(ushort*)ptr2;
		ptr2 += 14;
		ushort num2 = *(ushort*)ptr2;
		ptr2 = ptr2 + 4 + num2;
		byte* ptr3 = stackalloc byte[(UIntPtr)11];
		uint num5;
		if (module.FullyQualifiedName[0] == '<')
		{
			uint num3 = *(uint*)(ptr2 - 16);
			uint num4 = *(uint*)(ptr2 - 120);
			uint[] array = new uint[(int)num];
			uint[] array2 = new uint[(int)num];
			uint[] array3 = new uint[(int)num];
			for (int i = 0; i < (int)num; i++)
			{
				<Module>.VirtualProtect(ptr2, 8, 64u, ref num5);
				Marshal.Copy(new byte[8], 0, (IntPtr)((void*)ptr2), 8);
				array[i] = *(uint*)(ptr2 + 12);
				array2[i] = *(uint*)(ptr2 + 8);
				array3[i] = *(uint*)(ptr2 + 20);
				ptr2 += 40;
			}
			if (num4 != 0u)
			{
				for (int j = 0; j < (int)num; j++)
				{
					if (array[j] <= num4 && num4 < array[j] + array2[j])
					{
						num4 = num4 - array[j] + array3[j];
						break;
					}
				}
				byte* ptr4 = ptr + num4;
				uint num6 = *(uint*)ptr4;
				for (int k = 0; k < (int)num; k++)
				{
					if (array[k] <= num6 && num6 < array[k] + array2[k])
					{
						num6 = num6 - array[k] + array3[k];
						IL_15D:
						byte* ptr5 = ptr + num6;
						uint num7 = *(uint*)(ptr4 + 12);
						for (int l = 0; l < (int)num; l++)
						{
							if (array[l] <= num7 && num7 < array[l] + array2[l])
							{
								num7 = num7 - array[l] + array3[l];
								break;
							}
						}
						uint num8 = *(uint*)ptr5 + 2u;
						for (int m = 0; m < (int)num; m++)
						{
							if (array[m] <= num8 && num8 < array[m] + array2[m])
							{
								num8 = num8 - array[m] + array3[m];
								IL_1E9:
								<Module>.VirtualProtect(ptr + num7, 11, 64u, ref num5);
								*(int*)ptr3 = 1818522734;
								*(int*)(ptr3 + 4) = 1818504812;
								*(short*)(ptr3 + (IntPtr)4 * 2) = 108;
								ptr3[10] = 0;
								for (int n = 0; n < 11; n++)
								{
									(ptr + num7)[n] = ptr3[n];
								}
								<Module>.VirtualProtect(ptr + num8, 11, 64u, ref num5);
								*(int*)ptr3 = 1866691662;
								*(int*)(ptr3 + 4) = 1852404846;
								*(short*)(ptr3 + (IntPtr)4 * 2) = 25973;
								ptr3[10] = 0;
								for (int num9 = 0; num9 < 11; num9++)
								{
									(ptr + num8)[num9] = ptr3[num9];
								}
								goto IL_294;
							}
						}
						goto IL_1E9;
					}
				}
				goto IL_15D;
			}
			IL_294:
			for (int num10 = 0; num10 < (int)num; num10++)
			{
				if (array[num10] <= num3 && num3 < array[num10] + array2[num10])
				{
					num3 = num3 - array[num10] + array3[num10];
					IL_2CF:
					byte* ptr6 = ptr + num3;
					<Module>.VirtualProtect(ptr6, 72, 64u, ref num5);
					uint num11 = *(uint*)(ptr6 + 8);
					for (int num12 = 0; num12 < (int)num; num12++)
					{
						if (array[num12] <= num11 && num11 < array[num12] + array2[num12])
						{
							num11 = num11 - array[num12] + array3[num12];
							IL_326:
							*(int*)ptr6 = 0;
							*(int*)(ptr6 + 4) = 0;
							*(int*)(ptr6 + (IntPtr)2 * 4) = 0;
							*(int*)(ptr6 + (IntPtr)3 * 4) = 0;
							byte* ptr7 = ptr + num11;
							<Module>.VirtualProtect(ptr7, 4, 64u, ref num5);
							*(int*)ptr7 = 0;
							ptr7 += 12;
							ptr7 += *(uint*)ptr7;
							ptr7 = (ptr7 + 7L & -4L);
							ptr7 += 2;
							ushort num13 = (ushort)(*ptr7);
							ptr7 += 2;
							for (int num14 = 0; num14 < (int)num13; num14++)
							{
								<Module>.VirtualProtect(ptr7, 8, 64u, ref num5);
								ptr7 += 4;
								ptr7 += 4;
								for (int num15 = 0; num15 < 8; num15++)
								{
									<Module>.VirtualProtect(ptr7, 4, 64u, ref num5);
									*ptr7 = 0;
									ptr7++;
									if (*ptr7 == 0)
									{
										ptr7 += 3;
										break;
									}
									*ptr7 = 0;
									ptr7++;
									if (*ptr7 == 0)
									{
										ptr7 += 2;
										break;
									}
									*ptr7 = 0;
									ptr7++;
									if (*ptr7 == 0)
									{
										ptr7++;
										break;
									}
									*ptr7 = 0;
									ptr7++;
								}
							}
							return;
						}
					}
					goto IL_326;
				}
			}
			goto IL_2CF;
		}
		byte* ptr8 = ptr + *(uint*)(ptr2 - 16);
		if (*(uint*)(ptr2 - 120) != 0u)
		{
			byte* ptr9 = ptr + *(uint*)(ptr2 - 120);
			byte* ptr10 = ptr + *(uint*)ptr9;
			byte* ptr11 = ptr + *(uint*)(ptr9 + 12);
			byte* ptr12 = ptr + *(uint*)ptr10 + 2;
			<Module>.VirtualProtect(ptr11, 11, 64u, ref num5);
			*(int*)ptr3 = 1818522734;
			*(int*)(ptr3 + 4) = 1818504812;
			*(short*)(ptr3 + (IntPtr)4 * 2) = 108;
			ptr3[10] = 0;
			for (int num16 = 0; num16 < 11; num16++)
			{
				ptr11[num16] = ptr3[num16];
			}
			<Module>.VirtualProtect(ptr12, 11, 64u, ref num5);
			*(int*)ptr3 = 1866691662;
			*(int*)(ptr3 + 4) = 1852404846;
			*(short*)(ptr3 + (IntPtr)4 * 2) = 25973;
			ptr3[10] = 0;
			for (int num17 = 0; num17 < 11; num17++)
			{
				ptr12[num17] = ptr3[num17];
			}
		}
		for (int num18 = 0; num18 < (int)num; num18++)
		{
			<Module>.VirtualProtect(ptr2, 8, 64u, ref num5);
			Marshal.Copy(new byte[8], 0, (IntPtr)((void*)ptr2), 8);
			ptr2 += 40;
		}
		<Module>.VirtualProtect(ptr8, 72, 64u, ref num5);
		byte* ptr13 = ptr + *(uint*)(ptr8 + 8);
		*(int*)ptr8 = 0;
		*(int*)(ptr8 + 4) = 0;
		*(int*)(ptr8 + (IntPtr)2 * 4) = 0;
		*(int*)(ptr8 + (IntPtr)3 * 4) = 0;
		<Module>.VirtualProtect(ptr13, 4, 64u, ref num5);
		*(int*)ptr13 = 0;
		ptr13 += 12;
		ptr13 += *(uint*)ptr13;
		ptr13 = (ptr13 + 7L & -4L);
		ptr13 += 2;
		ushort num19 = (ushort)(*ptr13);
		ptr13 += 2;
		int num20 = 0;
		IL_654:
		while (num20 < (int)num19)
		{
			<Module>.VirtualProtect(ptr13, 8, 64u, ref num5);
			ptr13 += 4;
			ptr13 += 4;
			int num21 = 0;
			while (num21 < 8)
			{
				<Module>.VirtualProtect(ptr13, 4, 64u, ref num5);
				*ptr13 = 0;
				ptr13++;
				if (*ptr13 != 0)
				{
					*ptr13 = 0;
					ptr13++;
					if (*ptr13 != 0)
					{
						*ptr13 = 0;
						ptr13++;
						if (*ptr13 != 0)
						{
							*ptr13 = 0;
							ptr13++;
							num21++;
							continue;
						}
						ptr13++;
					}
					else
					{
						ptr13 += 2;
					}
				}
				else
				{
					ptr13 += 3;
				}
				IL_64E:
				num20++;
				goto IL_654;
			}
			goto IL_64E;
		}
	}

	// Token: 0x06000022 RID: 34 RVA: 0x0000321C File Offset: 0x0000141C
	internal static byte[] smethod_3(byte[] byte_1)
	{
		MemoryStream memoryStream = new MemoryStream(byte_1);
		<Module>.Class1 @class = new <Module>.Class1();
		byte[] buffer = new byte[5];
		memoryStream.Read(buffer, 0, 5);
		@class.method_5(buffer);
		long num = 0L;
		for (int i = 0; i < 8; i++)
		{
			int num2 = memoryStream.ReadByte();
			num |= (long)((long)((ulong)((byte)num2)) << 8 * i);
		}
		byte[] array = new byte[(int)num];
		MemoryStream stream_ = new MemoryStream(array, true);
		long long_ = memoryStream.Length - 13L;
		@class.method_4(memoryStream, stream_, long_, num);
		return array;
	}

	// Token: 0x06000023 RID: 35 RVA: 0x000032B0 File Offset: 0x000014B0
	internal static void smethod_4()
	{
		uint num = 528u;
		uint[] array = new uint[]
		{
			2601623155u,
			480302262u,
			120093873u,
			1966707886u,
			4050486283u,
			4061588517u,
			4112781211u,
			1666672684u,
			1730166425u,
			447170996u,
			1743266832u,
			4107745241u,
			689753401u,
			3655587361u,
			2741743045u,
			2820612990u,
			2402199984u,
			3321405610u,
			2114723125u,
			2045737607u,
			1089844227u,
			3515259795u,
			1430892297u,
			3852341044u,
			10225966u,
			4107466558u,
			2658137646u,
			1512032748u,
			3769765483u,
			570027281u,
			3012420814u,
			3039097211u,
			1341553328u,
			3117523840u,
			3247414685u,
			1915577476u,
			950722741u,
			4012365482u,
			2700707995u,
			3411783913u,
			4047811746u,
			3906658263u,
			1566759173u,
			127497197u,
			1087932387u,
			71104674u,
			163546074u,
			1145824838u,
			85396127u,
			579167230u,
			2072103986u,
			4121288018u,
			57986992u,
			864521635u,
			1597355314u,
			1360753969u,
			2066489124u,
			160177882u,
			2892542839u,
			428353490u,
			4220366661u,
			239837980u,
			583710213u,
			1460103524u,
			1846208940u,
			613797697u,
			3429951553u,
			4265947453u,
			2221843138u,
			2595314507u,
			816893150u,
			14299284u,
			759523262u,
			3917404595u,
			498495212u,
			3422713572u,
			1720186849u,
			355275753u,
			2532310741u,
			3386120080u,
			3675239269u,
			3348759408u,
			659360234u,
			4203448317u,
			1602878762u,
			880432103u,
			512933171u,
			4135945763u,
			2358964770u,
			3927531875u,
			2478671057u,
			3296418067u,
			1458225981u,
			3214897429u,
			2631260199u,
			1931873968u,
			77086255u,
			3322353564u,
			4111727837u,
			2912037019u,
			15137269u,
			1818199295u,
			381998746u,
			309563489u,
			216878967u,
			2225237207u,
			382554814u,
			2382442745u,
			2245763352u,
			507666179u,
			125694536u,
			3170127920u,
			2369960852u,
			1597448339u,
			2812750525u,
			1192137896u,
			1158864049u,
			2677890645u,
			1595147005u,
			3118746963u,
			1114659955u,
			1286059741u,
			3851845352u,
			571165859u,
			2916070491u,
			70384741u,
			1072070832u,
			2759302741u,
			639339407u,
			3506988652u,
			2226999700u,
			3836232124u,
			2862587759u,
			76614999u,
			1447111608u,
			2625021099u,
			2738976960u,
			420002365u,
			931600650u,
			796709614u,
			2574222345u,
			4252285443u,
			3025136171u,
			2813101902u,
			4064000018u,
			3255300535u,
			2520605375u,
			1598774361u,
			1263642610u,
			11403496u,
			3314227550u,
			3171824661u,
			2903176442u,
			4015288726u,
			3022900726u,
			177955118u,
			500689943u,
			1823690371u,
			1176522947u,
			1429079089u,
			3737926336u,
			2543857459u,
			1626762276u,
			3319149313u,
			1101589174u,
			829649590u,
			363980533u,
			2185395647u,
			1944717536u,
			3303269190u,
			1948645672u,
			2465992653u,
			4046634077u,
			2134699560u,
			2197749862u,
			1840835426u,
			3572111661u,
			2182070188u,
			1956026615u,
			3579317955u,
			2209302204u,
			3009714034u,
			315929441u,
			4159957933u,
			464364248u,
			3025715712u,
			737999850u,
			2883741446u,
			1637404984u,
			328194254u,
			929000531u,
			924034024u,
			1229530070u,
			4033736094u,
			1665934257u,
			1795564690u,
			1034064242u,
			773489361u,
			2688249643u,
			1858930397u,
			1193398749u,
			3228656829u,
			2160338109u,
			2704375162u,
			1902026849u,
			345604745u,
			3314723656u,
			1666757410u,
			3455712064u,
			1029553945u,
			1710002348u,
			3308166719u,
			3014202334u,
			2788894399u,
			3007160671u,
			1040553368u,
			1044279798u,
			3900570196u,
			1178364177u,
			3401304110u,
			1834688614u,
			2431065372u,
			3502790832u,
			3015508015u,
			2986259742u,
			2319310795u,
			1954483796u,
			586971376u,
			1850368684u,
			1441331971u,
			3304551305u,
			3578927133u,
			41413519u,
			2931967176u,
			1135365002u,
			1038057406u,
			792261547u,
			2815265038u,
			106880127u,
			1329209632u,
			3919465800u,
			1502765427u,
			1220288035u,
			1845490740u,
			763961024u,
			3093935445u,
			260132536u,
			918849777u,
			2656408757u,
			2913346921u,
			3401021845u,
			3920660391u,
			2561666245u,
			4233695107u,
			3282953168u,
			759318354u,
			2101691745u,
			3110162208u,
			283475443u,
			2218382880u,
			1538724486u,
			3685470713u,
			3294714962u,
			1271206008u,
			1350378013u,
			3676053959u,
			1030829399u,
			3556344715u,
			2578848484u,
			912720959u,
			443975988u,
			1620686793u,
			3145355294u,
			1826416057u,
			3107997481u,
			1150043999u,
			278002651u,
			2199223932u,
			106281842u,
			901101005u,
			4138038832u,
			1216945297u,
			206275763u,
			2875940193u,
			426052409u,
			3927226283u,
			825660612u,
			4109268499u,
			1721491498u,
			2164679985u,
			1005354030u,
			4202602679u,
			939013069u,
			3173970838u,
			478218347u,
			3261678479u,
			1005738686u,
			1775006835u,
			2699463541u,
			2298207084u,
			1326449476u,
			1577705430u,
			900908906u,
			963683760u,
			1330129267u,
			344593764u,
			3076120398u,
			692520361u,
			650167960u,
			101214137u,
			4141187890u,
			3843383187u,
			4100405542u,
			3665575978u,
			3152533565u,
			3876083477u,
			2851179401u,
			3385841102u,
			3653405389u,
			1678912121u,
			841042548u,
			2234129916u,
			2452297803u,
			302745755u,
			4088820727u,
			1249789003u,
			1496173389u,
			3198138323u,
			3151893446u,
			907578226u,
			850452383u,
			516589677u,
			2625408383u,
			4049997552u,
			324577592u,
			635850183u,
			4222072801u,
			2319463968u,
			4250493000u,
			3374820913u,
			650658885u,
			3153968673u,
			1340368564u,
			3822011285u,
			866557871u,
			688577874u,
			2685421023u,
			3869096857u,
			3375315107u,
			3330919289u,
			1754191532u,
			1186567298u,
			1325673824u,
			4197419679u,
			1887730743u,
			1056008871u,
			1450778805u,
			202091160u,
			1196664169u,
			599403061u,
			949260547u,
			1317417888u,
			539995051u,
			478837813u,
			4279236016u,
			3567810325u,
			2575018265u,
			1323775340u,
			1114730053u,
			185783197u,
			1549733354u,
			3480778854u,
			873067554u,
			1642214781u,
			2905546913u,
			911366506u,
			2818875122u,
			3895657357u,
			1851420069u,
			3096997776u,
			406552859u,
			3382013479u,
			2316125767u,
			1700533618u,
			177426213u,
			3287170702u,
			2510833072u,
			2876657983u,
			1855177196u,
			304958108u,
			3748784087u,
			159750026u,
			4013580179u,
			155770503u,
			1675203990u,
			2688437617u,
			472306401u,
			2609594535u,
			2231728618u,
			1409872189u,
			65171847u,
			3730655260u,
			2010249902u,
			3511600547u,
			3553758111u,
			2155495217u,
			161671974u,
			91808519u,
			802597929u,
			3145925108u,
			671036586u,
			2461528740u,
			521106029u,
			3168688479u,
			252200631u,
			4031969411u,
			862378443u,
			588094393u,
			1432458472u,
			115994512u,
			960185678u,
			3275053520u,
			2995166837u,
			1444188107u,
			2658866002u,
			1325805492u,
			1449093345u,
			1867766860u,
			15725439u,
			3154597273u,
			355510723u,
			2128995290u,
			3451871462u,
			3752349823u,
			324732062u,
			3113636202u,
			1536640134u,
			1616325276u,
			349320981u,
			2110000125u,
			4012338370u,
			2623359563u,
			1737105974u,
			3651718475u,
			1833027005u,
			930111829u,
			551595107u,
			1317357861u,
			1800185340u,
			3428174032u,
			1505996722u,
			4062420086u,
			397682587u,
			3709015996u,
			4039294805u,
			3018265867u,
			3834635725u,
			3579068573u,
			1149698776u,
			474157331u,
			3625152712u,
			3950157069u,
			1958184715u,
			306288580u,
			3540455974u,
			1727991547u,
			2177822161u,
			4133413896u,
			2310151782u,
			4167374989u,
			1765459163u,
			723527415u,
			3665965082u,
			608982127u,
			3206442964u,
			2129358486u,
			4216368781u,
			2881899553u,
			2197739927u,
			4266867398u,
			3182317676u,
			2824067373u,
			1149536739u,
			3530770294u,
			938982663u,
			3675704833u,
			3266475830u,
			3067880906u,
			267358537u,
			1818665190u,
			1554713937u,
			3663678481u,
			4278528014u,
			4099760882u,
			1195084516u,
			3307093775u,
			3197468728u,
			1656861447u,
			1750448542u,
			2367130424u,
			1474169053u,
			2078724385u,
			2222341146u,
			3841942129u,
			4094226885u,
			2482201969u,
			1537933640u,
			2415985800u,
			347523352u,
			413807606u,
			2509781721u,
			964649376u,
			3942733302u,
			824302642u,
			2335009323u,
			1174573986u,
			2714794165u,
			1859343094u,
			4201156499u,
			3464945120u,
			2298996561u,
			1838787208u,
			2224820984u,
			1497352945u,
			2435848855u,
			615475265u,
			296173970u,
			964650975u
		};
		uint[] array2 = new uint[16];
		uint num2 = 696901008u;
		for (int i = 0; i < 16; i++)
		{
			num2 ^= num2 >> 12;
			num2 ^= num2 << 25;
			num2 ^= num2 >> 27;
			array2[i] = num2;
		}
		int num3 = 0;
		int num4 = 0;
		uint[] array3 = new uint[16];
		byte[] array4 = new byte[num * 4u];
		while ((long)num3 < (long)((ulong)num))
		{
			for (int j = 0; j < 16; j++)
			{
				array3[j] = array[num3 + j];
			}
			array3[0] = (array3[0] ^ array2[0]);
			array3[1] = (array3[1] ^ array2[1]);
			array3[2] = (array3[2] ^ array2[2]);
			array3[3] = (array3[3] ^ array2[3]);
			array3[4] = (array3[4] ^ array2[4]);
			array3[5] = (array3[5] ^ array2[5]);
			array3[6] = (array3[6] ^ array2[6]);
			array3[7] = (array3[7] ^ array2[7]);
			array3[8] = (array3[8] ^ array2[8]);
			array3[9] = (array3[9] ^ array2[9]);
			array3[10] = (array3[10] ^ array2[10]);
			array3[11] = (array3[11] ^ array2[11]);
			array3[12] = (array3[12] ^ array2[12]);
			array3[13] = (array3[13] ^ array2[13]);
			array3[14] = (array3[14] ^ array2[14]);
			array3[15] = (array3[15] ^ array2[15]);
			for (int k = 0; k < 16; k++)
			{
				uint num5 = array3[k];
				array4[num4++] = (byte)num5;
				array4[num4++] = (byte)(num5 >> 8);
				array4[num4++] = (byte)(num5 >> 16);
				array4[num4++] = (byte)(num5 >> 24);
				array2[k] ^= num5;
			}
			num3 += 16;
		}
		<Module>.byte_0 = <Module>.smethod_3(array4);
	}

	// Token: 0x06000024 RID: 36 RVA: 0x000034A4 File Offset: 0x000016A4
	internal static T smethod_5<T>(uint uint_0)
	{
		if (Assembly.GetExecutingAssembly() == Assembly.GetCallingAssembly())
		{
			uint_0 = (uint_0 * 1252740631u ^ 1544060176u);
			uint num = uint_0 >> 30;
			T result = default(T);
			uint_0 &= 1073741823u;
			uint_0 <<= 2;
			if ((ulong)num != 3UL)
			{
				if ((ulong)num == 1UL)
				{
					T[] array = new T[1];
					Buffer.BlockCopy(<Module>.byte_0, (int)uint_0, array, 0, sizeof(T));
					result = array[0];
				}
				else if ((ulong)num == 2UL)
				{
					int num2 = (int)<Module>.byte_0[(int)uint_0++] | (int)<Module>.byte_0[(int)uint_0++] << 8 | (int)<Module>.byte_0[(int)uint_0++] << 16 | (int)<Module>.byte_0[(int)uint_0++] << 24;
					int length = (int)<Module>.byte_0[(int)uint_0++] | (int)<Module>.byte_0[(int)uint_0++] << 8 | (int)<Module>.byte_0[(int)uint_0++] << 16 | (int)<Module>.byte_0[(int)uint_0++] << 24;
					Array array2 = Array.CreateInstance(typeof(T).GetElementType(), length);
					Buffer.BlockCopy(<Module>.byte_0, (int)uint_0, array2, 0, num2 - 4);
					result = (T)((object)array2);
				}
			}
			else
			{
				int count = (int)<Module>.byte_0[(int)uint_0++] | (int)<Module>.byte_0[(int)uint_0++] << 8 | (int)<Module>.byte_0[(int)uint_0++] << 16 | (int)<Module>.byte_0[(int)uint_0++] << 24;
				result = (T)((object)string.Intern(Encoding.UTF8.GetString(<Module>.byte_0, (int)uint_0, count)));
			}
			return result;
		}
		return default(T);
	}

	// Token: 0x06000025 RID: 37 RVA: 0x00003650 File Offset: 0x00001850
	internal static T smethod_6<T>(uint uint_0)
	{
		if (Assembly.GetExecutingAssembly() == Assembly.GetCallingAssembly())
		{
			uint_0 = (uint_0 * 2205042925u ^ 1739704253u);
			uint num = uint_0 >> 30;
			T result = default(T);
			uint_0 &= 1073741823u;
			uint_0 <<= 2;
			if ((ulong)num != 1UL)
			{
				if ((ulong)num != 0UL)
				{
					if ((ulong)num == 3UL)
					{
						int num2 = (int)<Module>.byte_0[(int)uint_0++] | (int)<Module>.byte_0[(int)uint_0++] << 8 | (int)<Module>.byte_0[(int)uint_0++] << 16 | (int)<Module>.byte_0[(int)uint_0++] << 24;
						int length = (int)<Module>.byte_0[(int)uint_0++] | (int)<Module>.byte_0[(int)uint_0++] << 8 | (int)<Module>.byte_0[(int)uint_0++] << 16 | (int)<Module>.byte_0[(int)uint_0++] << 24;
						Array array = Array.CreateInstance(typeof(T).GetElementType(), length);
						Buffer.BlockCopy(<Module>.byte_0, (int)uint_0, array, 0, num2 - 4);
						result = (T)((object)array);
					}
				}
				else
				{
					T[] array2 = new T[1];
					Buffer.BlockCopy(<Module>.byte_0, (int)uint_0, array2, 0, sizeof(T));
					result = array2[0];
				}
			}
			else
			{
				int count = (int)<Module>.byte_0[(int)uint_0++] | (int)<Module>.byte_0[(int)uint_0++] << 8 | (int)<Module>.byte_0[(int)uint_0++] << 16 | (int)<Module>.byte_0[(int)uint_0++] << 24;
				result = (T)((object)string.Intern(Encoding.UTF8.GetString(<Module>.byte_0, (int)uint_0, count)));
			}
			return result;
		}
		return default(T);
	}

	// Token: 0x06000026 RID: 38 RVA: 0x00003800 File Offset: 0x00001A00
	internal static T smethod_7<T>(uint uint_0)
	{
		if (Assembly.GetExecutingAssembly() == Assembly.GetCallingAssembly())
		{
			uint_0 = (uint_0 * 3441406425u ^ 1238133733u);
			uint num = uint_0 >> 30;
			T result = default(T);
			uint_0 &= 1073741823u;
			uint_0 <<= 2;
			if ((ulong)num == 3UL)
			{
				int count = (int)<Module>.byte_0[(int)uint_0++] | (int)<Module>.byte_0[(int)uint_0++] << 8 | (int)<Module>.byte_0[(int)uint_0++] << 16 | (int)<Module>.byte_0[(int)uint_0++] << 24;
				result = (T)((object)string.Intern(Encoding.UTF8.GetString(<Module>.byte_0, (int)uint_0, count)));
			}
			else if ((ulong)num == 2UL)
			{
				T[] array = new T[1];
				Buffer.BlockCopy(<Module>.byte_0, (int)uint_0, array, 0, sizeof(T));
				result = array[0];
			}
			else if ((ulong)num == 1UL)
			{
				int num2 = (int)<Module>.byte_0[(int)uint_0++] | (int)<Module>.byte_0[(int)uint_0++] << 8 | (int)<Module>.byte_0[(int)uint_0++] << 16 | (int)<Module>.byte_0[(int)uint_0++] << 24;
				int length = (int)<Module>.byte_0[(int)uint_0++] | (int)<Module>.byte_0[(int)uint_0++] << 8 | (int)<Module>.byte_0[(int)uint_0++] << 16 | (int)<Module>.byte_0[(int)uint_0++] << 24;
				Array array2 = Array.CreateInstance(typeof(T).GetElementType(), length);
				Buffer.BlockCopy(<Module>.byte_0, (int)uint_0, array2, 0, num2 - 4);
				result = (T)((object)array2);
			}
			return result;
		}
		return default(T);
	}

	// Token: 0x06000027 RID: 39 RVA: 0x000039B0 File Offset: 0x00001BB0
	internal static T smethod_8<T>(uint uint_0)
	{
		if (Assembly.GetExecutingAssembly() == Assembly.GetCallingAssembly())
		{
			uint_0 = (uint_0 * 4039212853u ^ 1103880181u);
			uint num = uint_0 >> 30;
			T result = default(T);
			uint_0 &= 1073741823u;
			uint_0 <<= 2;
			if ((ulong)num == 2UL)
			{
				int count = (int)<Module>.byte_0[(int)uint_0++] | (int)<Module>.byte_0[(int)uint_0++] << 8 | (int)<Module>.byte_0[(int)uint_0++] << 16 | (int)<Module>.byte_0[(int)uint_0++] << 24;
				result = (T)((object)string.Intern(Encoding.UTF8.GetString(<Module>.byte_0, (int)uint_0, count)));
			}
			else if ((ulong)num == 0UL)
			{
				T[] array = new T[1];
				Buffer.BlockCopy(<Module>.byte_0, (int)uint_0, array, 0, sizeof(T));
				result = array[0];
			}
			else if ((ulong)num == 1UL)
			{
				int num2 = (int)<Module>.byte_0[(int)uint_0++] | (int)<Module>.byte_0[(int)uint_0++] << 8 | (int)<Module>.byte_0[(int)uint_0++] << 16 | (int)<Module>.byte_0[(int)uint_0++] << 24;
				int length = (int)<Module>.byte_0[(int)uint_0++] | (int)<Module>.byte_0[(int)uint_0++] << 8 | (int)<Module>.byte_0[(int)uint_0++] << 16 | (int)<Module>.byte_0[(int)uint_0++] << 24;
				Array array2 = Array.CreateInstance(typeof(T).GetElementType(), length);
				Buffer.BlockCopy(<Module>.byte_0, (int)uint_0, array2, 0, num2 - 4);
				result = (T)((object)array2);
			}
			return result;
		}
		return default(T);
	}

	// Token: 0x06000028 RID: 40 RVA: 0x00003B5C File Offset: 0x00001D5C
	internal static T smethod_9<T>(uint uint_0)
	{
		if (Assembly.GetExecutingAssembly() == Assembly.GetCallingAssembly())
		{
			uint_0 = (uint_0 * 1088988973u ^ 937405489u);
			uint num = uint_0 >> 30;
			T result = default(T);
			uint_0 &= 1073741823u;
			uint_0 <<= 2;
			if ((ulong)num != 1UL)
			{
				if ((ulong)num == 0UL)
				{
					T[] array = new T[1];
					Buffer.BlockCopy(<Module>.byte_0, (int)uint_0, array, 0, sizeof(T));
					result = array[0];
				}
				else if ((ulong)num == 2UL)
				{
					int num2 = (int)<Module>.byte_0[(int)uint_0++] | (int)<Module>.byte_0[(int)uint_0++] << 8 | (int)<Module>.byte_0[(int)uint_0++] << 16 | (int)<Module>.byte_0[(int)uint_0++] << 24;
					int length = (int)<Module>.byte_0[(int)uint_0++] | (int)<Module>.byte_0[(int)uint_0++] << 8 | (int)<Module>.byte_0[(int)uint_0++] << 16 | (int)<Module>.byte_0[(int)uint_0++] << 24;
					Array array2 = Array.CreateInstance(typeof(T).GetElementType(), length);
					Buffer.BlockCopy(<Module>.byte_0, (int)uint_0, array2, 0, num2 - 4);
					result = (T)((object)array2);
				}
			}
			else
			{
				int count = (int)<Module>.byte_0[(int)uint_0++] | (int)<Module>.byte_0[(int)uint_0++] << 8 | (int)<Module>.byte_0[(int)uint_0++] << 16 | (int)<Module>.byte_0[(int)uint_0++] << 24;
				result = (T)((object)string.Intern(Encoding.UTF8.GetString(<Module>.byte_0, (int)uint_0, count)));
			}
			return result;
		}
		return default(T);
	}

	// Token: 0x06000029 RID: 41 RVA: 0x00003D0C File Offset: 0x00001F0C
	internal static void smethod_10()
	{
		uint num = 112u;
		uint[] array = new uint[]
		{
			1766567401u,
			994764782u,
			692927884u,
			1969911801u,
			3226148110u,
			3662166816u,
			2276534609u,
			1711958237u,
			3703565256u,
			877585406u,
			3481345662u,
			1102222121u,
			4073251297u,
			3979824685u,
			2007169502u,
			2003356104u,
			781083288u,
			429993925u,
			3540829129u,
			132460106u,
			2949321738u,
			521557786u,
			795683845u,
			973109754u,
			1710122071u,
			364807746u,
			907685730u,
			1016317357u,
			1793561916u,
			1937848057u,
			4072641644u,
			530788709u,
			3622322611u,
			130206087u,
			689094934u,
			4138635352u,
			1668689612u,
			4147918466u,
			3466825662u,
			1067236547u,
			2906598616u,
			576727870u,
			464745859u,
			3521188555u,
			3705896060u,
			1297369366u,
			2195653013u,
			3428498888u,
			4186429660u,
			3042792563u,
			2694049819u,
			2807944266u,
			1748358451u,
			2151208605u,
			3162049666u,
			3178851786u,
			1613661352u,
			3348238634u,
			1206584931u,
			962586408u,
			2940649573u,
			3323265800u,
			305048756u,
			3611280046u,
			3860048041u,
			3692868191u,
			3995311221u,
			1123060889u,
			949892731u,
			3269497309u,
			2063368427u,
			677419994u,
			3496809345u,
			2310052391u,
			3780731663u,
			2040804255u,
			3630038808u,
			1846973178u,
			245093589u,
			2836410061u,
			2967798789u,
			2471071602u,
			3605795561u,
			139068870u,
			4193227939u,
			3250745684u,
			3036392764u,
			1235548224u,
			4181948759u,
			4274907074u,
			3013696226u,
			287389670u,
			1085672591u,
			2898299660u,
			1445803055u,
			3802277147u,
			1960319528u,
			1687605950u,
			928145616u,
			2998048592u,
			3610969281u,
			3087540720u,
			3634356431u,
			1235548224u,
			4181948759u,
			4274907074u,
			3013696226u,
			287389670u,
			1085672591u,
			2898299660u,
			1445803055u,
			3802277147u
		};
		uint[] array2 = new uint[16];
		uint num2 = 3142481882u;
		for (int i = 0; i < 16; i++)
		{
			num2 ^= num2 >> 13;
			num2 ^= num2 << 25;
			num2 ^= num2 >> 27;
			array2[i] = num2;
		}
		int num3 = 0;
		int num4 = 0;
		uint[] array3 = new uint[16];
		byte[] array4 = new byte[num * 4u];
		while ((long)num3 < (long)((ulong)num))
		{
			for (int j = 0; j < 16; j++)
			{
				array3[j] = array[num3 + j];
			}
			array3[0] = (array3[0] ^ array2[0]);
			array3[1] = (array3[1] ^ array2[1]);
			array3[2] = (array3[2] ^ array2[2]);
			array3[3] = (array3[3] ^ array2[3]);
			array3[4] = (array3[4] ^ array2[4]);
			array3[5] = (array3[5] ^ array2[5]);
			array3[6] = (array3[6] ^ array2[6]);
			array3[7] = (array3[7] ^ array2[7]);
			array3[8] = (array3[8] ^ array2[8]);
			array3[9] = (array3[9] ^ array2[9]);
			array3[10] = (array3[10] ^ array2[10]);
			array3[11] = (array3[11] ^ array2[11]);
			array3[12] = (array3[12] ^ array2[12]);
			array3[13] = (array3[13] ^ array2[13]);
			array3[14] = (array3[14] ^ array2[14]);
			array3[15] = (array3[15] ^ array2[15]);
			for (int k = 0; k < 16; k++)
			{
				uint num5 = array3[k];
				array4[num4++] = (byte)num5;
				array4[num4++] = (byte)(num5 >> 8);
				array4[num4++] = (byte)(num5 >> 16);
				array4[num4++] = (byte)(num5 >> 24);
				array2[k] ^= num5;
			}
			num3 += 16;
		}
		<Module>.assembly_0 = Assembly.Load(<Module>.smethod_3(array4));
		AppDomain.CurrentDomain.ResourceResolve += <Module>.smethod_11;
	}

	// Token: 0x0600002A RID: 42 RVA: 0x00003F18 File Offset: 0x00002118
	internal static Assembly smethod_11(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		if (Array.IndexOf<string>(<Module>.assembly_0.GetManifestResourceNames(), resolveEventArgs_0.Name) != -1)
		{
			return <Module>.assembly_0;
		}
		return null;
	}

	// Token: 0x0600002B RID: 43
	[DllImport("kernel32.dll", EntryPoint = "VirtualProtect")]
	internal static extern bool VirtualProtect_1(IntPtr intptr_0, uint uint_0, uint uint_1, ref uint uint_2);

	// Token: 0x0600002C RID: 44
	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	internal static extern bool CheckRemoteDebuggerPresent(IntPtr intptr_0, ref bool bool_0);

	// Token: 0x0600002D RID: 45 RVA: 0x00003F44 File Offset: 0x00002144
	internal unsafe static void smethod_12()
	{
		Module module = typeof(<Module>).Module;
		string fullyQualifiedName = module.FullyQualifiedName;
		bool flag = fullyQualifiedName.Length > 0 && fullyQualifiedName[0] == '<';
		byte* ptr = (byte*)((void*)Marshal.GetHINSTANCE(module));
		byte* ptr2 = ptr + *(uint*)(ptr + 60);
		ushort num = *(ushort*)(ptr2 + 6);
		ushort num2 = *(ushort*)(ptr2 + 20);
		bool flag2 = false;
		uint* ptr3 = null;
		uint num3 = 0u;
		uint* ptr4 = (uint*)(ptr2 + 24 + num2);
		uint num4 = 225804822u;
		uint num5 = 4088750590u;
		uint num6 = 292466654u;
		uint num7 = 493529141u;
		<Module>.CheckRemoteDebuggerPresent(Process.GetCurrentProcess().Handle, ref flag2);
		if (flag2)
		{
			Environment.FailFast(null);
		}
		for (int i = 0; i < (int)num; i++)
		{
			uint num8 = *(ptr4++) * *(ptr4++);
			if (num8 == 4154077322u)
			{
				ptr3 = (uint*)(ptr + (UIntPtr)(flag ? ptr4[3] : ptr4[1]) / 4);
				<Module>.CheckRemoteDebuggerPresent(Process.GetCurrentProcess().Handle, ref flag2);
				if (flag2)
				{
					Environment.FailFast(null);
				}
				num3 = (flag ? ptr4[2] : (*ptr4)) >> 2;
			}
			else if (num8 != 0u)
			{
				uint* ptr5 = (uint*)(ptr + (UIntPtr)(flag ? ptr4[3] : ptr4[1]) / 4);
				uint num9 = ptr4[2] >> 2;
				for (uint num10 = 0u; num10 < num9; num10 += 1u)
				{
					uint num11 = (num4 ^ *(ptr5++)) + num5 + num6 * num7;
					num4 = num5;
					num5 = num7;
					num7 = num11;
				}
			}
			ptr4 += 8;
		}
		uint[] array = new uint[16];
		uint[] array2 = new uint[16];
		for (int j = 0; j < 16; j++)
		{
			array[j] = num7;
			array2[j] = num5;
			num4 = (num5 >> 5 | num5 << 27);
			num5 = (num6 >> 3 | num6 << 29);
			<Module>.CheckRemoteDebuggerPresent(Process.GetCurrentProcess().Handle, ref flag2);
			if (flag2)
			{
				Environment.FailFast(null);
			}
			num6 = (num7 >> 7 | num7 << 25);
			num7 = (num4 >> 11 | num4 << 21);
		}
		array[0] = (array[0] ^ array2[0]);
		array[1] = array[1] * array2[1];
		array[2] = array[2] + array2[2];
		array[3] = (array[3] ^ array2[3]);
		array[4] = array[4] * array2[4];
		array[5] = array[5] + array2[5];
		array[6] = (array[6] ^ array2[6]);
		array[7] = array[7] * array2[7];
		array[8] = array[8] + array2[8];
		array[9] = (array[9] ^ array2[9]);
		array[10] = array[10] * array2[10];
		array[11] = array[11] + array2[11];
		array[12] = (array[12] ^ array2[12]);
		array[13] = array[13] * array2[13];
		array[14] = array[14] + array2[14];
		array[15] = (array[15] ^ array2[15]);
		uint num12 = 64u;
		<Module>.VirtualProtect_1((IntPtr)((void*)ptr3), num3 << 2, 64u, ref num12);
		if (num12 != 64u)
		{
			uint num13 = 0u;
			for (uint num14 = 0u; num14 < num3; num14 += 1u)
			{
				*ptr3 ^= array[(int)(num13 & 15u)];
				array[(int)(num13 & 15u)] = (array[(int)(num13 & 15u)] ^ *(ptr3++)) + 1035675673u;
				<Module>.CheckRemoteDebuggerPresent(Process.GetCurrentProcess().Handle, ref flag2);
				if (flag2)
				{
					Environment.FailFast(null);
				}
				num13 += 1u;
			}
			return;
		}
	}

	// Token: 0x04000001 RID: 1
	internal static byte[] byte_0;

	// Token: 0x04000002 RID: 2 RVA: 0x00002048 File Offset: 0x00000248
	internal static <Module>.Struct4 struct4_0;

	// Token: 0x04000003 RID: 3
	internal static Assembly assembly_0;

	// Token: 0x04000004 RID: 4 RVA: 0x00002888 File Offset: 0x00000A88
	internal static <Module>.Struct5 struct5_0;

	// Token: 0x02000002 RID: 2
	internal struct Struct0
	{
		// Token: 0x0600002E RID: 46 RVA: 0x000042AC File Offset: 0x000024AC
		internal void method_0()
		{
			this.uint_0 = 1024u;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000042C4 File Offset: 0x000024C4
		internal uint method_1(<Module>.Class0 class0_0)
		{
			uint num = (class0_0.uint_1 >> 11) * this.uint_0;
			if (class0_0.uint_0 < num)
			{
				class0_0.uint_1 = num;
				this.uint_0 += 2048u - this.uint_0 >> 5;
				if (class0_0.uint_1 < 16777216u)
				{
					class0_0.uint_0 = (class0_0.uint_0 << 8 | (uint)((byte)class0_0.stream_0.ReadByte()));
					class0_0.uint_1 <<= 8;
				}
				return 0u;
			}
			class0_0.uint_1 -= num;
			class0_0.uint_0 -= num;
			this.uint_0 -= this.uint_0 >> 5;
			if (class0_0.uint_1 < 16777216u)
			{
				class0_0.uint_0 = (class0_0.uint_0 << 8 | (uint)((byte)class0_0.stream_0.ReadByte()));
				class0_0.uint_1 <<= 8;
			}
			return 1u;
		}

		// Token: 0x04000005 RID: 5
		internal uint uint_0;
	}

	// Token: 0x02000003 RID: 3
	internal struct Struct1
	{
		// Token: 0x06000030 RID: 48 RVA: 0x000043B0 File Offset: 0x000025B0
		internal Struct1(int int_1)
		{
			this.int_0 = int_1;
			this.struct0_0 = new <Module>.Struct0[1 << int_1];
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000043D8 File Offset: 0x000025D8
		internal void method_0()
		{
			uint num = 1u;
			while ((ulong)num < (ulong)(1L << (this.int_0 & 31)))
			{
				this.struct0_0[(int)num].method_0();
				num += 1u;
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00004410 File Offset: 0x00002610
		internal uint method_1(<Module>.Class0 class0_0)
		{
			uint num = 1u;
			for (int i = this.int_0; i > 0; i--)
			{
				num = (num << 1) + this.struct0_0[(int)num].method_1(class0_0);
			}
			return num - (1u << this.int_0);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00004454 File Offset: 0x00002654
		internal uint method_2(<Module>.Class0 class0_0)
		{
			uint num = 1u;
			uint num2 = 0u;
			for (int i = 0; i < this.int_0; i++)
			{
				uint num3 = this.struct0_0[(int)num].method_1(class0_0);
				num <<= 1;
				num += num3;
				num2 |= num3 << i;
			}
			return num2;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x0000449C File Offset: 0x0000269C
		internal static uint smethod_0(<Module>.Struct0[] struct0_1, uint uint_0, <Module>.Class0 class0_0, int int_1)
		{
			uint num = 1u;
			uint num2 = 0u;
			for (int i = 0; i < int_1; i++)
			{
				uint num3 = struct0_1[(int)(uint_0 + num)].method_1(class0_0);
				num <<= 1;
				num += num3;
				num2 |= num3 << i;
			}
			return num2;
		}

		// Token: 0x04000006 RID: 6
		internal readonly <Module>.Struct0[] struct0_0;

		// Token: 0x04000007 RID: 7
		internal readonly int int_0;
	}

	// Token: 0x02000004 RID: 4
	internal class Class0
	{
		// Token: 0x06000035 RID: 53 RVA: 0x000044DC File Offset: 0x000026DC
		internal void method_0(Stream stream_1)
		{
			this.stream_0 = stream_1;
			this.uint_0 = 0u;
			this.uint_1 = uint.MaxValue;
			for (int i = 0; i < 5; i++)
			{
				this.uint_0 = (this.uint_0 << 8 | (uint)((byte)this.stream_0.ReadByte()));
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00004528 File Offset: 0x00002728
		internal void method_1()
		{
			this.stream_0 = null;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x0000453C File Offset: 0x0000273C
		internal void method_2()
		{
			while (this.uint_1 < 16777216u)
			{
				this.uint_0 = (this.uint_0 << 8 | (uint)((byte)this.stream_0.ReadByte()));
				this.uint_1 <<= 8;
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00004584 File Offset: 0x00002784
		internal uint method_3(int int_0)
		{
			uint num = this.uint_1;
			uint num2 = this.uint_0;
			uint num3 = 0u;
			for (int i = int_0; i > 0; i--)
			{
				num >>= 1;
				uint num4 = num2 - num >> 31;
				num2 -= (num & num4 - 1u);
				num3 = (num3 << 1 | 1u - num4);
				if (num < 16777216u)
				{
					num2 = (num2 << 8 | (uint)((byte)this.stream_0.ReadByte()));
					num <<= 8;
				}
			}
			this.uint_1 = num;
			this.uint_0 = num2;
			return num3;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000045F8 File Offset: 0x000027F8
		internal Class0()
		{
		}

		// Token: 0x04000008 RID: 8
		internal uint uint_0;

		// Token: 0x04000009 RID: 9
		internal uint uint_1;

		// Token: 0x0400000A RID: 10
		internal Stream stream_0;
	}

	// Token: 0x02000005 RID: 5
	internal class Class1
	{
		// Token: 0x0600003A RID: 58 RVA: 0x0000460C File Offset: 0x0000280C
		internal Class1()
		{
			this.uint_0 = uint.MaxValue;
			int num = 0;
			while ((long)num < 4L)
			{
				this.struct1_0[num] = new <Module>.Struct1(6);
				num++;
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00004700 File Offset: 0x00002900
		internal void method_0(uint uint_3)
		{
			if (this.uint_0 != uint_3)
			{
				this.uint_0 = uint_3;
				this.uint_1 = Math.Max(this.uint_0, 1u);
				uint uint_4 = Math.Max(this.uint_1, 4096u);
				this.class4_0.method_0(uint_4);
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x0000474C File Offset: 0x0000294C
		internal void method_1(int int_0, int int_1)
		{
			this.class3_0.method_0(int_0, int_1);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00004768 File Offset: 0x00002968
		internal void method_2(int int_0)
		{
			uint num = 1u << int_0;
			this.class2_0.method_0(num);
			this.class2_1.method_0(num);
			this.uint_2 = num - 1u;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x000047A0 File Offset: 0x000029A0
		internal void method_3(Stream stream_0, Stream stream_1)
		{
			this.class0_0.method_0(stream_0);
			this.class4_0.method_1(stream_1, this.bool_0);
			for (uint num = 0u; num < 12u; num += 1u)
			{
				for (uint num2 = 0u; num2 <= this.uint_2; num2 += 1u)
				{
					uint num3 = (num << 4) + num2;
					this.struct0_0[(int)num3].method_0();
					this.struct0_1[(int)num3].method_0();
				}
				this.struct0_2[(int)num].method_0();
				this.struct0_3[(int)num].method_0();
				this.struct0_4[(int)num].method_0();
				this.struct0_5[(int)num].method_0();
			}
			this.class3_0.method_1();
			for (uint num = 0u; num < 4u; num += 1u)
			{
				this.struct1_0[(int)num].method_0();
			}
			for (uint num = 0u; num < 114u; num += 1u)
			{
				this.struct0_6[(int)num].method_0();
			}
			this.class2_0.method_1();
			this.class2_1.method_1();
			this.struct1_1.method_0();
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000048C4 File Offset: 0x00002AC4
		internal void method_4(Stream stream_0, Stream stream_1, long long_0, long long_1)
		{
			this.method_3(stream_0, stream_1);
			<Module>.Struct3 @struct = default(<Module>.Struct3);
			@struct.method_0();
			uint num = 0u;
			uint num2 = 0u;
			uint num3 = 0u;
			uint num4 = 0u;
			ulong num5 = 0UL;
			if (0L < long_1)
			{
				this.struct0_0[(int)((int)@struct.uint_0 << 4)].method_1(this.class0_0);
				@struct.method_1();
				byte byte_ = this.class3_0.method_3(this.class0_0, 0u, 0);
				this.class4_0.method_5(byte_);
				num5 += 1UL;
			}
			while (num5 < (ulong)long_1)
			{
				uint num6 = (uint)num5 & this.uint_2;
				if (this.struct0_0[(int)((@struct.uint_0 << 4) + num6)].method_1(this.class0_0) == 0u)
				{
					byte byte_2 = this.class4_0.method_6(0u);
					byte byte_3;
					if (!@struct.method_5())
					{
						byte_3 = this.class3_0.method_4(this.class0_0, (uint)num5, byte_2, this.class4_0.method_6(num));
					}
					else
					{
						byte_3 = this.class3_0.method_3(this.class0_0, (uint)num5, byte_2);
					}
					this.class4_0.method_5(byte_3);
					@struct.method_1();
					num5 += 1UL;
				}
				else
				{
					uint num7;
					if (this.struct0_2[(int)@struct.uint_0].method_1(this.class0_0) != 1u)
					{
						num4 = num3;
						num3 = num2;
						num2 = num;
						num7 = 2u + this.class2_0.method_2(this.class0_0, num6);
						@struct.method_2();
						uint num8 = this.struct1_0[(int)<Module>.Class1.smethod_0(num7)].method_1(this.class0_0);
						if (num8 < 4u)
						{
							num = num8;
						}
						else
						{
							int num9 = (int)((num8 >> 1) - 1u);
							num = (2u | (num8 & 1u)) << num9;
							if (num8 < 14u)
							{
								num += <Module>.Struct1.smethod_0(this.struct0_6, num - num8 - 1u, this.class0_0, num9);
							}
							else
							{
								num += this.class0_0.method_3(num9 - 4) << 4;
								num += this.struct1_1.method_2(this.class0_0);
							}
						}
					}
					else
					{
						if (this.struct0_3[(int)@struct.uint_0].method_1(this.class0_0) == 0u)
						{
							if (this.struct0_1[(int)((@struct.uint_0 << 4) + num6)].method_1(this.class0_0) == 0u)
							{
								@struct.method_4();
								this.class4_0.method_5(this.class4_0.method_6(num));
								num5 += 1UL;
								continue;
							}
						}
						else
						{
							uint num10;
							if (this.struct0_4[(int)@struct.uint_0].method_1(this.class0_0) == 0u)
							{
								num10 = num2;
							}
							else
							{
								if (this.struct0_5[(int)@struct.uint_0].method_1(this.class0_0) != 0u)
								{
									num10 = num4;
									num4 = num3;
								}
								else
								{
									num10 = num3;
								}
								num3 = num2;
							}
							num2 = num;
							num = num10;
						}
						num7 = this.class2_1.method_2(this.class0_0, num6) + 2u;
						@struct.method_3();
					}
					if (((ulong)num >= num5 || num >= this.uint_1) && num == 4294967295u)
					{
						break;
					}
					this.class4_0.method_4(num, num7);
					num5 += (ulong)num7;
				}
			}
			this.class4_0.method_3();
			this.class4_0.method_2();
			this.class0_0.method_1();
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00004C30 File Offset: 0x00002E30
		internal void method_5(byte[] byte_0)
		{
			int int_ = (int)(byte_0[0] % 9);
			byte b = byte_0[0] / 9;
			int int_2 = (int)(b % 5);
			int int_3 = (int)(b / 5);
			uint num = 0u;
			for (int i = 0; i < 4; i++)
			{
				num += (uint)((uint)byte_0[1 + i] << i * 8);
			}
			this.method_0(num);
			this.method_1(int_2, int_);
			this.method_2(int_3);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00004C8C File Offset: 0x00002E8C
		internal static uint smethod_0(uint uint_3)
		{
			uint_3 -= 2u;
			if (uint_3 >= 4u)
			{
				return 3u;
			}
			return uint_3;
		}

		// Token: 0x0400000B RID: 11
		internal readonly <Module>.Struct0[] struct0_0 = new <Module>.Struct0[192];

		// Token: 0x0400000C RID: 12
		internal readonly <Module>.Struct0[] struct0_1 = new <Module>.Struct0[192];

		// Token: 0x0400000D RID: 13
		internal readonly <Module>.Struct0[] struct0_2 = new <Module>.Struct0[12];

		// Token: 0x0400000E RID: 14
		internal readonly <Module>.Struct0[] struct0_3 = new <Module>.Struct0[12];

		// Token: 0x0400000F RID: 15
		internal readonly <Module>.Struct0[] struct0_4 = new <Module>.Struct0[12];

		// Token: 0x04000010 RID: 16
		internal readonly <Module>.Struct0[] struct0_5 = new <Module>.Struct0[12];

		// Token: 0x04000011 RID: 17
		internal readonly <Module>.Class1.Class2 class2_0 = new <Module>.Class1.Class2();

		// Token: 0x04000012 RID: 18
		internal readonly <Module>.Class1.Class3 class3_0 = new <Module>.Class1.Class3();

		// Token: 0x04000013 RID: 19
		internal readonly <Module>.Class4 class4_0 = new <Module>.Class4();

		// Token: 0x04000014 RID: 20
		internal readonly <Module>.Struct0[] struct0_6 = new <Module>.Struct0[114];

		// Token: 0x04000015 RID: 21
		internal readonly <Module>.Struct1[] struct1_0 = new <Module>.Struct1[4];

		// Token: 0x04000016 RID: 22
		internal readonly <Module>.Class0 class0_0 = new <Module>.Class0();

		// Token: 0x04000017 RID: 23
		internal readonly <Module>.Class1.Class2 class2_1 = new <Module>.Class1.Class2();

		// Token: 0x04000018 RID: 24
		internal bool bool_0;

		// Token: 0x04000019 RID: 25
		internal uint uint_0;

		// Token: 0x0400001A RID: 26
		internal uint uint_1;

		// Token: 0x0400001B RID: 27
		internal <Module>.Struct1 struct1_1 = new <Module>.Struct1(4);

		// Token: 0x0400001C RID: 28
		internal uint uint_2;

		// Token: 0x02000006 RID: 6
		internal class Class2
		{
			// Token: 0x06000042 RID: 66 RVA: 0x00004CA8 File Offset: 0x00002EA8
			internal void method_0(uint uint_1)
			{
				for (uint num = this.uint_0; num < uint_1; num += 1u)
				{
					this.struct1_0[(int)num] = new <Module>.Struct1(3);
					this.struct1_1[(int)num] = new <Module>.Struct1(3);
				}
				this.uint_0 = uint_1;
			}

			// Token: 0x06000043 RID: 67 RVA: 0x00004CF4 File Offset: 0x00002EF4
			internal void method_1()
			{
				this.struct0_0.method_0();
				for (uint num = 0u; num < this.uint_0; num += 1u)
				{
					this.struct1_0[(int)num].method_0();
					this.struct1_1[(int)num].method_0();
				}
				this.struct0_1.method_0();
				this.struct1_2.method_0();
			}

			// Token: 0x06000044 RID: 68 RVA: 0x00004D58 File Offset: 0x00002F58
			internal uint method_2(<Module>.Class0 class0_0, uint uint_1)
			{
				if (this.struct0_0.method_1(class0_0) == 0u)
				{
					return this.struct1_0[(int)uint_1].method_1(class0_0);
				}
				uint num = 8u;
				if (this.struct0_1.method_1(class0_0) != 0u)
				{
					num += 8u;
					num += this.struct1_2.method_1(class0_0);
				}
				else
				{
					num += this.struct1_1[(int)uint_1].method_1(class0_0);
				}
				return num;
			}

			// Token: 0x06000045 RID: 69 RVA: 0x00004DC4 File Offset: 0x00002FC4
			internal Class2()
			{
			}

			// Token: 0x0400001D RID: 29
			internal readonly <Module>.Struct1[] struct1_0 = new <Module>.Struct1[16];

			// Token: 0x0400001E RID: 30
			internal readonly <Module>.Struct1[] struct1_1 = new <Module>.Struct1[16];

			// Token: 0x0400001F RID: 31
			internal <Module>.Struct0 struct0_0;

			// Token: 0x04000020 RID: 32
			internal <Module>.Struct0 struct0_1;

			// Token: 0x04000021 RID: 33
			internal <Module>.Struct1 struct1_2 = new <Module>.Struct1(8);

			// Token: 0x04000022 RID: 34
			internal uint uint_0;
		}

		// Token: 0x02000007 RID: 7
		internal class Class3
		{
			// Token: 0x06000046 RID: 70 RVA: 0x00004E00 File Offset: 0x00003000
			internal void method_0(int int_2, int int_3)
			{
				if (this.struct2_0 != null)
				{
					if (this.int_1 == int_3)
					{
						if (this.int_0 == int_2)
						{
							return;
						}
					}
				}
				this.int_0 = int_2;
				this.uint_0 = (1u << int_2) - 1u;
				this.int_1 = int_3;
				uint num = 1u << this.int_1 + this.int_0;
				this.struct2_0 = new <Module>.Class1.Class3.Struct2[num];
				for (uint num2 = 0u; num2 < num; num2 += 1u)
				{
					this.struct2_0[(int)num2].method_0();
				}
			}

			// Token: 0x06000047 RID: 71 RVA: 0x00004E84 File Offset: 0x00003084
			internal void method_1()
			{
				uint num = 1u << this.int_1 + this.int_0;
				for (uint num2 = 0u; num2 < num; num2 += 1u)
				{
					this.struct2_0[(int)num2].method_1();
				}
			}

			// Token: 0x06000048 RID: 72 RVA: 0x00004EC4 File Offset: 0x000030C4
			internal uint method_2(uint uint_1, byte byte_0)
			{
				return ((uint_1 & this.uint_0) << this.int_1) + (uint)(byte_0 >> 8 - this.int_1);
			}

			// Token: 0x06000049 RID: 73 RVA: 0x00004EF4 File Offset: 0x000030F4
			internal byte method_3(<Module>.Class0 class0_0, uint uint_1, byte byte_0)
			{
				return this.struct2_0[(int)this.method_2(uint_1, byte_0)].method_2(class0_0);
			}

			// Token: 0x0600004A RID: 74 RVA: 0x00004F1C File Offset: 0x0000311C
			internal byte method_4(<Module>.Class0 class0_0, uint uint_1, byte byte_0, byte byte_1)
			{
				return this.struct2_0[(int)this.method_2(uint_1, byte_0)].method_3(class0_0, byte_1);
			}

			// Token: 0x0600004B RID: 75 RVA: 0x000045F8 File Offset: 0x000027F8
			internal Class3()
			{
			}

			// Token: 0x04000023 RID: 35
			internal <Module>.Class1.Class3.Struct2[] struct2_0;

			// Token: 0x04000024 RID: 36
			internal int int_0;

			// Token: 0x04000025 RID: 37
			internal int int_1;

			// Token: 0x04000026 RID: 38
			internal uint uint_0;

			// Token: 0x02000008 RID: 8
			internal struct Struct2
			{
				// Token: 0x0600004C RID: 76 RVA: 0x00004F44 File Offset: 0x00003144
				internal void method_0()
				{
					this.struct0_0 = new <Module>.Struct0[768];
				}

				// Token: 0x0600004D RID: 77 RVA: 0x00004F64 File Offset: 0x00003164
				internal void method_1()
				{
					for (int i = 0; i < 768; i++)
					{
						this.struct0_0[i].method_0();
					}
				}

				// Token: 0x0600004E RID: 78 RVA: 0x00004F94 File Offset: 0x00003194
				internal byte method_2(<Module>.Class0 class0_0)
				{
					uint num = 1u;
					do
					{
						num = (num << 1 | this.struct0_0[(int)num].method_1(class0_0));
					}
					while (num < 256u);
					return (byte)num;
				}

				// Token: 0x0600004F RID: 79 RVA: 0x00004FC8 File Offset: 0x000031C8
				internal byte method_3(<Module>.Class0 class0_0, byte byte_0)
				{
					uint num = 1u;
					for (;;)
					{
						uint num2 = (uint)(byte_0 >> 7 & 1);
						byte_0 = (byte)(byte_0 << 1);
						uint num3 = this.struct0_0[(int)((1u + num2 << 8) + num)].method_1(class0_0);
						num = (num << 1 | num3);
						if (num2 != num3)
						{
							break;
						}
						if (num >= 256u)
						{
							goto IL_5C;
						}
					}
					while (num < 256u)
					{
						num = (num << 1 | this.struct0_0[(int)num].method_1(class0_0));
					}
					IL_5C:
					return (byte)num;
				}

				// Token: 0x04000027 RID: 39
				internal <Module>.Struct0[] struct0_0;
			}
		}
	}

	// Token: 0x02000009 RID: 9
	internal class Class4
	{
		// Token: 0x06000050 RID: 80 RVA: 0x00005034 File Offset: 0x00003234
		internal void method_0(uint uint_3)
		{
			if (this.uint_2 != uint_3)
			{
				this.byte_0 = new byte[uint_3];
			}
			this.uint_2 = uint_3;
			this.uint_0 = 0u;
			this.uint_1 = 0u;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x0000506C File Offset: 0x0000326C
		internal void method_1(Stream stream_1, bool bool_0)
		{
			this.method_2();
			this.stream_0 = stream_1;
			if (!bool_0)
			{
				this.uint_1 = 0u;
				this.uint_0 = 0u;
			}
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00005098 File Offset: 0x00003298
		internal void method_2()
		{
			this.method_3();
			this.stream_0 = null;
			Buffer.BlockCopy(new byte[this.byte_0.Length], 0, this.byte_0, 0, this.byte_0.Length);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x000050D4 File Offset: 0x000032D4
		internal void method_3()
		{
			uint num = this.uint_0 - this.uint_1;
			if (num == 0u)
			{
				return;
			}
			this.stream_0.Write(this.byte_0, (int)this.uint_1, (int)num);
			if (this.uint_0 >= this.uint_2)
			{
				this.uint_0 = 0u;
			}
			this.uint_1 = this.uint_0;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x0000512C File Offset: 0x0000332C
		internal void method_4(uint uint_3, uint uint_4)
		{
			uint num = this.uint_0 - uint_3 - 1u;
			if (num >= this.uint_2)
			{
				num += this.uint_2;
			}
			while (uint_4 > 0u)
			{
				if (num >= this.uint_2)
				{
					num = 0u;
				}
				byte[] array = this.byte_0;
				uint num2 = this.uint_0;
				this.uint_0 = num2 + 1u;
				array[(int)num2] = this.byte_0[(int)num++];
				if (this.uint_0 >= this.uint_2)
				{
					this.method_3();
				}
				uint_4 -= 1u;
			}
		}

		// Token: 0x06000055 RID: 85 RVA: 0x000051A4 File Offset: 0x000033A4
		internal void method_5(byte byte_1)
		{
			byte[] array = this.byte_0;
			uint num = this.uint_0;
			this.uint_0 = num + 1u;
			array[(int)num] = byte_1;
			if (this.uint_0 >= this.uint_2)
			{
				this.method_3();
			}
		}

		// Token: 0x06000056 RID: 86 RVA: 0x000051E0 File Offset: 0x000033E0
		internal byte method_6(uint uint_3)
		{
			uint num = this.uint_0 - uint_3 - 1u;
			if (num >= this.uint_2)
			{
				num += this.uint_2;
			}
			return this.byte_0[(int)num];
		}

		// Token: 0x06000057 RID: 87 RVA: 0x000045F8 File Offset: 0x000027F8
		internal Class4()
		{
		}

		// Token: 0x04000028 RID: 40
		internal byte[] byte_0;

		// Token: 0x04000029 RID: 41
		internal uint uint_0;

		// Token: 0x0400002A RID: 42
		internal Stream stream_0;

		// Token: 0x0400002B RID: 43
		internal uint uint_1;

		// Token: 0x0400002C RID: 44
		internal uint uint_2;
	}

	// Token: 0x0200000A RID: 10
	internal struct Struct3
	{
		// Token: 0x06000058 RID: 88 RVA: 0x00005214 File Offset: 0x00003414
		internal void method_0()
		{
			this.uint_0 = 0u;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00005228 File Offset: 0x00003428
		internal void method_1()
		{
			if (this.uint_0 < 4u)
			{
				this.uint_0 = 0u;
				return;
			}
			if (this.uint_0 < 10u)
			{
				this.uint_0 -= 3u;
				return;
			}
			this.uint_0 -= 6u;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00005270 File Offset: 0x00003470
		internal void method_2()
		{
			this.uint_0 = ((this.uint_0 < 7u) ? 7u : 10u);
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00005294 File Offset: 0x00003494
		internal void method_3()
		{
			this.uint_0 = ((this.uint_0 < 7u) ? 8u : 11u);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x000052B8 File Offset: 0x000034B8
		internal void method_4()
		{
			this.uint_0 = ((this.uint_0 < 7u) ? 9u : 11u);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000052DC File Offset: 0x000034DC
		internal bool method_5()
		{
			return this.uint_0 < 7u;
		}

		// Token: 0x0400002D RID: 45
		internal uint uint_0;
	}

	// Token: 0x0200000B RID: 11
	[StructLayout(LayoutKind.Explicit, Size = 2112)]
	internal struct Struct4
	{
	}

	// Token: 0x0200000C RID: 12
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 448)]
	internal struct Struct5
	{
	}
}
