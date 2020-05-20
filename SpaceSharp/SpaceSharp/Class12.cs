using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;

// Token: 0x0200002F RID: 47
internal class Class12
{
	// Token: 0x060001EF RID: 495 RVA: 0x0000B1E8 File Offset: 0x000093E8
	public static Bitmap smethod_0()
	{
		Stopwatch stopwatch = Stopwatch.StartNew();
		Bitmap bitmap = new Bitmap(SystemInformation.VirtualScreen.Width, SystemInformation.VirtualScreen.Height);
		Graphics.FromImage(bitmap).CopyFromScreen(SystemInformation.VirtualScreen.X, SystemInformation.VirtualScreen.Y, 0, 0, SystemInformation.VirtualScreen.Size, CopyPixelOperation.SourceCopy);
		stopwatch.Stop();
		Console.WriteLine(<Module>.smethod_8<string>(4050024927u) + stopwatch.ElapsedMilliseconds.ToString() + <Module>.smethod_9<string>(256376709u));
		return bitmap;
	}

	// Token: 0x060001F0 RID: 496 RVA: 0x0000B288 File Offset: 0x00009488
	public static void smethod_1(int int_0, int int_1, int int_2, int int_3, int int_4 = 2)
	{
		Class12.Class13 @class = new Class12.Class13();
		@class.int_0 = int_0;
		@class.int_1 = int_4;
		@class.int_2 = int_3;
		@class.int_3 = int_1;
		@class.int_6 = int_2;
		@class.int_4 = @class.int_3 / 100;
		@class.int_5 = @class.int_3 / 14;
		Parallel.For(0, @class.int_1, new ParallelOptions(), new Action<int>(@class.method_0));
	}

	// Token: 0x060001F1 RID: 497 RVA: 0x0000B2FC File Offset: 0x000094FC
	public static List<GClass0> smethod_2(ref byte[] byte_1, int int_0, int int_1, int int_2, int int_3, int int_4 = 10, int int_5 = 10000, int int_6 = 1000000000, int int_7 = 3, int int_8 = 1000000000, float float_0 = 0.001f, float float_1 = 5f)
	{
		int num = int_1 / int_2;
		byte[] array = new byte[num * int_0];
		List<GClass0> list = new List<GClass0>(500);
		Stack<int> stack = new Stack<int>(500);
		Stack<int> stack2 = new Stack<int>(500);
		for (int i = 0; i < int_0; i++)
		{
			int num2 = i * int_3;
			int num3 = i * num;
			for (int j = (i % 2 == 0) ? int_2 : 0; j < int_1; j += int_2 * 2)
			{
				if (byte_1[num2 + j] != 0 && array[num3 + j / int_2] != 1)
				{
					stack.Push(j);
					stack2.Push(i);
					int num4 = 10000000;
					int num5 = -10000000;
					int num6 = 10000000;
					int num7 = -10000000;
					int int_9 = 0;
					int num8 = 0;
					while (stack.Count > 0)
					{
						int num9 = stack.Pop();
						int num10 = stack2.Pop();
						int num11 = num10 * num;
						if (array[num11 + num9 / int_2] != 1)
						{
							num8++;
							int num12 = num10 * int_3;
							num4 = Math.Min(num4, num10);
							num5 = Math.Max(num5, num10);
							num6 = Math.Min(num6, num9);
							num7 = Math.Max(num7, num9);
							int_9 = (int)byte_1[num2 + j];
							array[num11 + num9 / int_2] = 1;
							if (num9 - int_2 >= 0 && byte_1[num12 + num9 - int_2] == byte_1[num2 + j])
							{
								stack.Push(num9 - int_2);
								stack2.Push(num10);
							}
							if (num9 + int_2 < int_1 && byte_1[num12 + num9 + int_2] == byte_1[num2 + j])
							{
								stack.Push(num9 + int_2);
								stack2.Push(num10);
							}
							if (num10 + 1 < int_0 && byte_1[num12 + num9 + int_3] == byte_1[num2 + j])
							{
								stack.Push(num9);
								stack2.Push(num10 + 1);
							}
							if (num10 > 0 && byte_1[num12 + num9 - int_3] == byte_1[num2 + j])
							{
								stack.Push(num9);
								stack2.Push(num10 - 1);
							}
						}
					}
					int num13 = num5 - num4 + 1;
					int num14 = num7 - num6 + 1;
					if (num8 > int_4 && num8 < int_5 && num13 < int_8 && num14 < int_6 && num13 > int_7 && (float)(num14 * num13) * float_0 < (float)num8 && (float)(num14 * num13) * float_1 > (float)num8)
					{
						list.Add(new GClass0
						{
							int_0 = num6,
							int_1 = num4,
							int_3 = num13 + 1,
							int_2 = num14 + int_2,
							int_4 = int_9
						});
					}
				}
			}
		}
		return list.OrderBy(new Func<GClass0, int>(Class12.Class14.<>9.method_0)).ToList<GClass0>();
	}

	// Token: 0x060001F2 RID: 498 RVA: 0x0000B5B8 File Offset: 0x000097B8
	public static List<GClass0> smethod_3(List<GClass0> list_0, int int_0, int int_1, int int_2 = 5, float float_0 = 10f, float float_1 = 50f, int int_3 = 20)
	{
		List<GClass0> list = new List<GClass0>();
		for (int i = 0; i < list_0.Count; i++)
		{
			if (list_0[i].int_0 != -1)
			{
				float num = (float)list_0[i].int_2 / (float)int_0 * (float)list_0[i].int_3;
				for (int j = i + 1; j < list_0.Count; j++)
				{
					if (list_0[j].int_0 != -1)
					{
						if (list_0[j].int_0 - (list_0[i].int_0 + list_0[i].int_2) > 4 * int_0)
						{
							break;
						}
						float num2 = (float)list_0[j].int_2 / (float)int_0 * (float)list_0[j].int_3 / num;
						if (Math.Abs(list_0[j].int_1 - list_0[i].int_1) < 4 && (double)num2 > 0.25 && num2 < 4f && list_0[i].int_4 == list_0[j].int_4 && list_0[j].int_4 != 170)
						{
							int num3 = Math.Max(list_0[j].int_0 + list_0[j].int_2, list_0[i].int_0 + list_0[i].int_2);
							int num4 = Math.Max(list_0[j].int_1 + list_0[j].int_3, list_0[i].int_1 + list_0[i].int_3);
							list_0[i].int_0 = Math.Min(list_0[j].int_0, list_0[i].int_0);
							list_0[i].int_1 = Math.Min(list_0[j].int_1, list_0[i].int_1);
							list_0[i].int_3 = num4 - list_0[i].int_1;
							list_0[i].int_2 = num3 - list_0[i].int_0;
							list_0[j].int_0 = -1;
						}
					}
				}
			}
		}
		for (int k = list_0.Count - 1; k >= 0; k--)
		{
			if (list_0[k].int_0 != -1)
			{
				for (int l = k - 1; l >= 0; l--)
				{
					if (list_0[l].int_0 != -1)
					{
						if (list_0[k].int_0 - (list_0[l].int_0 + list_0[l].int_2) > int_3 * int_0)
						{
							break;
						}
						float num5 = (float)list_0[l].int_2 / (float)int_0 / (float)list_0[l].int_3;
						if ((float)Math.Abs(list_0[l].int_1 - list_0[k].int_1) < (float)int_1 / float_1 && list_0[l].int_4 != 170 && list_0[k].int_4 != 170 && list_0[l].int_4 != list_0[k].int_4 && (list_0[k].int_4 == 250 || list_0[k].int_4 == 255 || list_0[k].int_4 == 99) && num5 > 1f / float_0 && num5 < float_0)
						{
							int num6 = Math.Max(list_0[l].int_0 + list_0[l].int_2, list_0[k].int_0 + list_0[k].int_2);
							int num7 = Math.Max(list_0[l].int_1 + list_0[l].int_3, list_0[k].int_1 + list_0[k].int_3);
							list_0[k].int_0 = Math.Min(list_0[l].int_0, list_0[k].int_0);
							list_0[k].int_1 = Math.Min(list_0[l].int_1, list_0[k].int_1);
							list_0[k].int_3 = num7 - list_0[k].int_1;
							list_0[k].int_2 = num6 - list_0[k].int_0;
							list_0[l].int_0 = -1;
							list_0[k].int_4 = 99;
						}
					}
				}
			}
		}
		for (int m = 0; m < list_0.Count; m++)
		{
			if (list_0[m].int_0 != -1)
			{
				list.Add(list_0[m]);
			}
		}
		return list;
	}

	// Token: 0x060001F3 RID: 499 RVA: 0x0000BAE4 File Offset: 0x00009CE4
	public static byte[] smethod_4(ref byte[] byte_1, int int_0, int int_1, int int_2, int int_3, List<GClass0> list_0)
	{
		byte[] array = new byte[byte_1.Length];
		int num = int_1 / 2;
		for (int i = 0; i < list_0.Count; i++)
		{
			int num2 = list_0[i].int_3 * 6 * int_2;
			int num3 = list_0[i].int_2 / int_2 / 5;
			int num4 = 0;
			int num5 = -111110;
			int num6 = (int)Math.Max(0f, (float)list_0[i].int_1 - (float)list_0[i].int_3 * 0.1f);
			while (num6 < int_0 && (double)num6 < (double)list_0[i].int_1 + Math.Max((double)list_0[i].int_3 * 1.1, (double)num3))
			{
				int num7 = 0;
				int num8 = num6 * int_3;
				int num9 = Math.Max(0, list_0[i].int_0 - (int)((float)(list_0[i].int_2 / int_2) * 0.1f) * int_2);
				while (num9 < int_1 && (double)num9 < (double)list_0[i].int_0 + Math.Max((double)list_0[i].int_2 * 1.1, (double)num2))
				{
					byte b = byte_1[num8 + num9];
					byte b2 = byte_1[num8 + num9 + 1];
					byte b3 = byte_1[num8 + num9 + 2];
					if (b3 < 80 && b3 > 30 && b2 < 25 && b < 25)
					{
						array[num8 + num9] = 50;
						num5 = num9;
					}
					else if (b3 + b2 + b < 140 && b3 > b * 4 && b2 > b * 4 && (double)b3 > (double)b2 * 0.9 && b3 > 30 && b2 > 30 && b < 20)
					{
						array[num8 + num9] = 50;
						num5 = num9;
					}
					else if (b3 < 100 && b2 > 110 && b > 110 && (double)b > (double)(b3 + b2) * 0.8 && b > b2)
					{
						array[num8 + num9] = 150;
					}
					else if (b3 > b + b2 && b2 < 100 && b < 100 && b3 > 110 && b2 > 50 && b > 50 && Math.Abs((int)(b - b2)) < 4 && Math.Abs((int)(b3 - b - b2)) < 30)
					{
						array[num8 + num9] = 170;
					}
					else if (b3 > 80 && b2 < 150 && b < 150 && Math.Abs((int)(b - b2)) < 50 && (double)b3 > (double)(b + b2) * 0.6 && (double)b3 > (double)b * 1.4 && (double)b3 > (double)b2 * 1.4 && b2 > 10 && b > 10)
					{
						if (num9 - num5 < num)
						{
							array[num8 + num9] = byte.MaxValue;
							num4 = 2;
							num7++;
						}
					}
					else if (b3 > 170 && b2 > 140 && b < 120 && b3 > 2 * b && b2 > 2 * b && b < 120 && b3 > b2 && b2 < 230 && num9 - num5 < num && num7 < 4)
					{
						array[num8 + num9] = 250;
						num4 = 2;
					}
					num9 += int_2;
				}
				num4--;
				num6++;
			}
		}
		return array;
	}

	// Token: 0x060001F4 RID: 500 RVA: 0x0000BE64 File Offset: 0x0000A064
	public static List<GClass0> smethod_5(ref byte[] byte_1, int int_0, int int_1, int int_2, int int_3, List<GClass0> list_0)
	{
		List<GClass0> list = new List<GClass0>();
		for (int i = 0; i < list_0.Count; i++)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			int num5 = 0;
			int num6 = 0;
			int num7 = 0;
			bool flag = false;
			bool flag2 = false;
			int num8 = list_0[i].int_1;
			while (num8 < int_0 && num8 < list_0[i].int_1 + list_0[i].int_3)
			{
				int num9 = num8 * int_3;
				int num10 = list_0[i].int_0;
				while (num10 < int_1 && num10 < list_0[i].int_0 + list_0[i].int_2)
				{
					int num11 = (int)byte_1[num9 + num10];
					int num12 = (int)byte_1[num9 + num10 + 1];
					int num13 = (int)byte_1[num9 + num10 + 2];
					if (Math.Abs(num13 - 222) < 4 && Math.Abs(num12 - 199) < 4 && Math.Abs(num11 - 66) < 4)
					{
						flag2 = true;
					}
					if ((Math.Abs(num13 - 205) < 6 && Math.Abs(num12 - 101) < 6 && Math.Abs(num11 - 90) < 6) || (Math.Abs(num13 - 205) < 6 && Math.Abs(num12 - 116) < 6 && Math.Abs(num11 - 106) < 6))
					{
						flag = true;
					}
					if ((num13 > 90 && num12 < 120 && num11 < 120 && (double)num13 > (double)(num11 + num12) * 0.9 && (double)num13 > (double)num11 * 1.7 && (double)num13 > (double)num12 * 1.7 && num12 > 10 && num11 > 10) || (num13 > 170 && num12 > 140 && num11 < 120 && num13 > 2 * num11 && num12 > 2 * num11 && num11 < 120 && num13 > num12 && num12 < 230) || (num13 > num11 + num12 && num12 < 100 && num11 < 100 && num13 > 110 && num12 > 50 && num11 > 50 && Math.Abs(num11 - num12) < 4 && Math.Abs(num13 - num11 - num12) < 30))
					{
						list_0[i].float_0[0] += (float)num13;
						list_0[i].float_0[1] += (float)num12;
						list_0[i].float_0[2] += (float)num11;
						num2++;
					}
					else if (num13 < 18 && num12 < 18 && num11 < 18)
					{
						num6++;
					}
					if (num8 > list_0[i].int_1)
					{
						int num14 = num9 - int_3;
						int num15 = (int)byte_1[num14 + num10];
						int num16 = (int)byte_1[num14 + num10 + 1];
						int num17 = (int)byte_1[num14 + num10 + 2];
						float num18 = (float)(num15 + num16 + num17) / 3f - (float)(num11 + num12 + num13) / 3f;
						if (Math.Abs(num18) > 1f)
						{
							if (num17 > 90 && num16 < 120 && num15 < 120 && (double)num17 > (double)(num15 + num16) * 0.9 && (double)num17 > (double)num15 * 1.7 && (double)num17 > (double)num16 * 1.7 && num16 > 10 && num15 > 10)
							{
								list_0[i].float_2 += num18;
								num++;
								num3++;
								if (num17 > num15 + num16 - 8 && num16 < 100 && num15 < 100 && num17 > 110 && num16 > 50 && num15 > 50 && Math.Abs(num15 - num16) < 4 && Math.Abs(num17 - num15 - num16) < 30)
								{
									num5++;
								}
							}
							else if (num17 > 170 && num16 > 140 && num15 < 120 && num17 > 2 * num15 && num16 > 2 * num15 && num15 < 120 && num17 > num16 && num16 < 230)
							{
								list_0[i].float_2 += num18;
								num++;
								num4++;
							}
							else if (num17 > num15 + num16 - 8 && num16 < 100 && num15 < 100 && num17 > 110 && num16 > 50 && num15 > 50 && Math.Abs(num15 - num16) < 4 && Math.Abs(num17 - num15 - num16) < 30)
							{
								list_0[i].float_2 += num18;
								num++;
								num5++;
							}
							else if (Math.Abs(num13 - num12) < 10 && Math.Abs(num12 - num11) < 10 && Math.Abs(num11 - num13) < 10 && num11 + num12 + num13 < 200)
							{
								num5++;
							}
						}
					}
					if (num10 > list_0[i].int_0 + int_2 && num10 < list_0[i].int_0 + list_0[i].int_2 - int_2)
					{
						float num19 = (float)byte_1[num9 + num10 - int_2];
						int num20 = (int)byte_1[num9 + num10 - int_2 + 1];
						int num21 = (int)byte_1[num9 + num10 - int_2 + 2];
						float num22 = (num19 + (float)num20 + (float)num21) / 3f - (float)(num11 + num12 + num13) / 3f;
						list_0[i].float_3 += num22;
						num7++;
					}
					num10 += int_2;
				}
				num8++;
			}
			list_0[i].float_0[0] /= (float)num2;
			list_0[i].float_0[1] /= (float)num2;
			list_0[i].float_0[2] /= (float)num2;
			list_0[i].float_2 /= (float)num;
			list_0[i].float_3 /= (float)num7;
			if (num5 > num4 && num5 > num3)
			{
				list_0[i].genum0_0 = GEnum0.MINION_REGION;
			}
			else if (num4 > num3 && num4 > num5)
			{
				list_0[i].genum0_0 = GEnum0.OWN_REGION;
			}
			else
			{
				list_0[i].genum0_0 = GEnum0.ENEMY_REGION;
			}
			if (num7 > 0 && Math.Abs(list_0[i].float_3) > 8f)
			{
				list_0[i].int_0 = -1;
			}
			if (list_0[i].genum0_0 == GEnum0.ENEMY_REGION)
			{
				if (!flag || num2 == 0 || num == 0 || list_0[i].float_2 < 3f || list_0[i].float_2 > 70f || list_0[i].float_0[0] < 150f || list_0[i].float_0[0] > 190f || list_0[i].float_0[1] > 80f || list_0[i].float_0[2] > 70f || list_0[i].float_0[1] < 45f || list_0[i].float_0[2] < 35f || list_0[i].float_0[0] - (list_0[i].float_0[2] + list_0[i].float_0[1]) < 33f)
				{
					if (!flag && (double)((float)num3 / (float)num5) < 1.5 && num2 > 0 && num > 0 && list_0[i].float_2 > 6f && list_0[i].float_0[0] > list_0[i].float_0[1] + list_0[i].float_0[2] && Math.Abs(list_0[i].float_0[0] - list_0[i].float_0[1] - list_0[i].float_0[2]) < 40f && list_0[i].float_0[1] > 60f && list_0[i].float_0[2] > 60f && Math.Abs(list_0[i].float_0[2] - list_0[i].float_0[1]) < 8f)
					{
						list_0[i].genum0_0 = GEnum0.MINION_REGION;
					}
					else
					{
						list_0[i].int_0 = -1;
					}
				}
			}
			else if (list_0[i].genum0_0 == GEnum0.MINION_REGION)
			{
				if (num2 == 0 || num == 0 || list_0[i].float_2 < 6f || num2 <= 0 || num <= 0 || list_0[i].float_2 <= 6f || list_0[i].float_0[0] <= list_0[i].float_0[1] + list_0[i].float_0[2] || Math.Abs(list_0[i].float_0[0] - list_0[i].float_0[1] - list_0[i].float_0[2]) >= 40f || list_0[i].float_0[1] <= 60f || list_0[i].float_0[2] <= 60f || Math.Abs(list_0[i].float_0[2] - list_0[i].float_0[1]) >= 8f)
				{
					list_0[i].int_0 = -1;
				}
			}
			else if (!flag2 || num2 == 0 || num == 0 || list_0[i].float_2 < 4f || list_0[i].float_2 > 50f || list_0[i].float_0[0] < 195f || list_0[i].float_0[1] < 165f || list_0[i].float_0[2] > 80f || (double)list_0[i].float_0[0] < (double)list_0[i].float_0[2] * 1.5 || (double)list_0[i].float_0[1] < (double)list_0[i].float_0[2] * 1.5 || list_0[i].float_0[0] - list_0[i].float_0[1] < 20f)
			{
				list_0[i].int_0 = -1;
			}
			if (list_0[i].genum0_0 != GEnum0.MINION_REGION)
			{
				for (int j = 0; j < i; j++)
				{
					if (list_0[j].int_0 != -1 && list_0[j].genum0_0 != GEnum0.MINION_REGION && Math.Abs(list_0[i].int_0 - list_0[j].int_0) < 3 * int_2 && Math.Abs(list_0[i].int_1 - list_0[j].int_1) < 3 && Math.Abs(list_0[i].float_0[0] - list_0[j].float_0[0]) < 1f && Math.Abs(list_0[i].float_0[1] - list_0[j].float_0[1]) < 1f && Math.Abs(list_0[i].float_0[2] - list_0[j].float_0[2]) < 1f && Math.Abs(list_0[i].float_2 - list_0[j].float_2) < 1f && list_0[i].genum0_0 == list_0[j].genum0_0 && list_0[j].int_2 * list_0[j].int_3 > list_0[i].int_2 * list_0[i].int_3)
					{
						list_0[j].int_0 = -1;
					}
				}
			}
		}
		for (int k = 0; k < list_0.Count; k++)
		{
			if (list_0[k].int_0 != -1)
			{
				int num23 = 0;
				int num24 = list_0[k].int_1;
				while (num24 < int_0 && num24 < list_0[k].int_1 + list_0[k].int_3)
				{
					int num25 = num24 * int_3;
					int num26 = list_0[k].int_0;
					while (num26 < int_1 && num26 < list_0[k].int_0 + list_0[k].int_2)
					{
						int num27 = (int)byte_1[num25 + num26];
						int num28 = (int)byte_1[num25 + num26 + 1];
						int num29 = (int)byte_1[num25 + num26 + 2];
						if ((num29 > 90 && num28 < 120 && num27 < 120 && (double)num29 > (double)(num27 + num28) * 0.9 && (double)num29 > (double)num27 * 1.7 && (double)num29 > (double)num28 * 1.7 && num28 > 10 && num27 > 10) || (num29 > 170 && num28 > 140 && num27 < 120 && num29 > 2 * num27 && num28 > 2 * num27 && num27 < 120 && num29 > num28 && num28 < 230) || (num29 > num27 + num28 && num28 < 100 && num27 < 100 && num29 > 110 && num28 > 50 && num27 > 50 && Math.Abs(num27 - num28) < 4 && Math.Abs(num29 - num27 - num28) < 30))
						{
							list_0[k].float_1[0] += ((float)num29 - list_0[k].float_0[0]) * ((float)num29 - list_0[k].float_0[0]);
							list_0[k].float_1[1] += ((float)num28 - list_0[k].float_0[1]) * ((float)num28 - list_0[k].float_0[1]);
							list_0[k].float_1[2] += ((float)num27 - list_0[k].float_0[2]) * ((float)num27 - list_0[k].float_0[2]);
							num23++;
						}
						num26 += int_2;
					}
					num24++;
				}
				list_0[k].float_1[0] /= (float)num23;
				list_0[k].float_1[1] /= (float)num23;
				list_0[k].float_1[2] /= (float)num23;
				if (num23 > 0 && list_0[k].float_1[0] + list_0[k].float_1[1] + list_0[k].float_1[2] < 3500f && list_0[k].int_3 < int_0 / 5)
				{
					list.Add(list_0[k]);
				}
			}
		}
		return list;
	}

	// Token: 0x060001F5 RID: 501 RVA: 0x0000CEC8 File Offset: 0x0000B0C8
	public static List<GClass0> smethod_6(List<GClass0> list_0, int int_0)
	{
		list_0 = list_0.OrderBy(new Func<GClass0, int>(Class12.Class14.<>9.method_1)).ToList<GClass0>();
		List<GClass0> list = new List<GClass0>();
		for (int i = 0; i < list_0.Count; i++)
		{
			if (list_0[i].int_0 != -1)
			{
				for (int j = i + 1; j < list_0.Count; j++)
				{
					if (list_0[j].int_0 != -1)
					{
						if (list_0[j].int_0 - (list_0[i].int_0 + list_0[i].int_2) > 10 * int_0)
						{
							break;
						}
						if (list_0[i].genum0_0 == GEnum0.MINION_REGION && list_0[j].genum0_0 == GEnum0.MINION_REGION && list_0[j].int_0 - (list_0[i].int_0 + list_0[i].int_2) < 6 * int_0 && Math.Abs(list_0[j].int_1 - list_0[i].int_1) < 2 && Math.Abs(list_0[j].int_3 - list_0[i].int_3) < 2 && Math.Abs(list_0[j].float_0[0] - list_0[i].float_0[0]) < 5f && Math.Abs(list_0[j].float_0[1] - list_0[i].float_0[1]) < 5f && Math.Abs(list_0[j].float_0[2] - list_0[i].float_0[2]) < 5f)
						{
							int num = Math.Max(list_0[j].int_0 + list_0[j].int_2, list_0[i].int_0 + list_0[i].int_2);
							int num2 = Math.Max(list_0[j].int_1 + list_0[j].int_3, list_0[i].int_1 + list_0[i].int_3);
							list_0[i].genum0_0 = GEnum0.ENEMY_REGION;
							list_0[i].int_0 = Math.Min(list_0[j].int_0, list_0[i].int_0);
							list_0[i].int_1 = Math.Min(list_0[j].int_1, list_0[i].int_1);
							list_0[i].int_3 = num2 - list_0[i].int_1;
							list_0[i].int_2 = num - list_0[i].int_0;
							list_0[j].int_0 = -1;
						}
						else if (Math.Abs(list_0[j].int_1 - list_0[i].int_1) < 10 && list_0[i].genum0_0 == list_0[j].genum0_0 && list_0[i].genum0_0 != GEnum0.MINION_REGION)
						{
							int num3 = Math.Max(list_0[j].int_0 + list_0[j].int_2, list_0[i].int_0 + list_0[i].int_2);
							int num4 = Math.Max(list_0[j].int_1 + list_0[j].int_3, list_0[i].int_1 + list_0[i].int_3);
							list_0[i].int_0 = Math.Min(list_0[j].int_0, list_0[i].int_0);
							list_0[i].int_1 = Math.Min(list_0[j].int_1, list_0[i].int_1);
							list_0[i].int_3 = num4 - list_0[i].int_1;
							list_0[i].int_2 = num3 - list_0[i].int_0;
							list_0[j].int_0 = -1;
						}
					}
				}
			}
		}
		int num5 = 0;
		int val = 0;
		for (int k = 0; k < list_0.Count; k++)
		{
			if (list_0[k].int_0 != -1)
			{
				if (list_0[k].genum0_0 == GEnum0.OWN_REGION)
				{
					num5++;
				}
				else if (list_0[k].genum0_0 == GEnum0.ENEMY_REGION)
				{
					val = Math.Max(val, list_0[k].int_3);
				}
			}
		}
		for (int l = 0; l < list_0.Count; l++)
		{
			float num6 = (float)list_0[l].int_2 / (float)int_0 / (float)list_0[l].int_3;
			float num7 = (float)list_0[l].int_2 / (float)int_0 * (float)list_0[l].int_3;
			if (list_0[l].int_0 != -1 && (double)num6 >= 0.05 && num6 <= 16f && num7 >= 2f && num7 <= 5000f && (num5 <= 1 || list_0[l].genum0_0 != GEnum0.OWN_REGION))
			{
				list.Add(list_0[l]);
			}
		}
		return list;
	}

	// Token: 0x060001F6 RID: 502 RVA: 0x0000D458 File Offset: 0x0000B658
	public static void smethod_7(string string_0, Bitmap bitmap_0, List<GClass0> list_0, int int_0, int int_1, int int_2, bool bool_0 = false)
	{
		if (bool_0)
		{
			Bitmap bitmap = (Bitmap)bitmap_0.Clone();
			for (int i = 0; i < list_0.Count; i++)
			{
				int num = list_0[i].int_1;
				while (num < int_0 && num <= list_0[i].int_1 + list_0[i].int_3)
				{
					int num2 = list_0[i].int_0;
					while (num2 < int_1 && num2 <= list_0[i].int_0 + list_0[i].int_2)
					{
						if (list_0[i].int_1 == num || list_0[i].int_0 == num2 || num == list_0[i].int_1 + list_0[i].int_3 || num2 == list_0[i].int_0 + list_0[i].int_2 || list_0[i].int_1 == num - 1 || list_0[i].int_0 == num2 - 1 || num + 1 == list_0[i].int_1 + list_0[i].int_3 || num2 + 1 == list_0[i].int_0 + list_0[i].int_2)
						{
							bitmap.SetPixel(num2 / int_2, num, Color.FromArgb(255, 150, 255, 150));
						}
						num2 += int_2;
					}
					num++;
				}
				int num3 = list_0[i].int_10;
				while (num3 < int_0 && num3 <= list_0[i].int_10 + list_0[i].int_7)
				{
					int num4 = list_0[i].int_9;
					while (num4 < int_1 && num4 <= list_0[i].int_9 + list_0[i].int_8)
					{
						if (list_0[i].int_10 == num3 || list_0[i].int_9 == num4 || num3 == list_0[i].int_10 + list_0[i].int_7 || num4 == list_0[i].int_9 + list_0[i].int_8 || list_0[i].int_10 == num3 - 1 || list_0[i].int_9 == num4 - 1 || num3 + 1 == list_0[i].int_10 + list_0[i].int_7 || num4 + 1 == list_0[i].int_9 + list_0[i].int_8)
						{
							bitmap.SetPixel(num4 / int_2, num3, Color.FromArgb(255, 50, 50, 255));
						}
						num4 += int_2;
					}
					num3++;
				}
				if (list_0[i].int_5 > 0 && list_0[i].int_6 > 0)
				{
					bitmap.SetPixel(Math.Min(list_0[i].int_5 / int_2, int_1 / int_2 - 1), Math.Min(list_0[i].int_6, int_0 - 1), Color.FromArgb(255, 50, 180, 255));
					bitmap.SetPixel(Math.Min(Math.Max(0, list_0[i].int_5 / int_2 - 1), int_1 / int_2 - 1), Math.Min(list_0[i].int_6, int_0 - 1), Color.FromArgb(255, 50, 180, 255));
					bitmap.SetPixel(Math.Min(list_0[i].int_5 / int_2, int_1 / int_2 - 1), Math.Min(Math.Max(0, list_0[i].int_6 - 1), int_0 - 1), Color.FromArgb(255, 50, 180, 255));
					bitmap.SetPixel(Math.Min(Math.Max(0, list_0[i].int_5 / int_2 - 1), int_1 / int_2 - 1), Math.Min(Math.Max(0, list_0[i].int_6 - 1), int_0 - 1), Color.FromArgb(255, 50, 180, 255));
				}
			}
			Directory.CreateDirectory(<Module>.smethod_7<string>(3203063007u));
			bitmap.Save(<Module>.smethod_6<string>(156861112u) + string_0, ImageFormat.Png);
		}
	}

	// Token: 0x060001F7 RID: 503 RVA: 0x0000D8E8 File Offset: 0x0000BAE8
	public static List<GClass0> smethod_8(Bitmap bitmap_0, GClass0 gclass0_0, bool bool_0 = false, string string_0 = "")
	{
		Stopwatch.StartNew();
		BitmapData bitmapData = bitmap_0.LockBits(new Rectangle(0, 0, bitmap_0.Width, bitmap_0.Height), ImageLockMode.ReadWrite, bitmap_0.PixelFormat);
		int num = Image.GetPixelFormatSize(bitmap_0.PixelFormat) / 8;
		byte[] array = new byte[bitmapData.Stride * bitmap_0.Height];
		IntPtr scan = bitmapData.Scan0;
		Marshal.Copy(scan, array, 0, array.Length);
		int height = bitmapData.Height;
		int num2 = bitmapData.Width * num;
		List<GClass0> list = new List<GClass0>();
		list.Add(new GClass0
		{
			int_0 = 0,
			int_1 = 0,
			int_2 = num2 - num,
			int_3 = height - 1
		});
		if (gclass0_0 == null)
		{
			gclass0_0 = new GClass0
			{
				int_0 = 0,
				int_1 = 0,
				int_2 = 10,
				int_3 = 15,
				genum0_0 = GEnum0.ENEMY_REGION
			};
		}
		Stopwatch stopwatch = Stopwatch.StartNew();
		array = Class12.smethod_4(ref array, height, num2, num, bitmapData.Stride, list);
		stopwatch.Stop();
		Stopwatch stopwatch2 = Stopwatch.StartNew();
		list = Class12.smethod_2(ref array, height, num2, num, bitmapData.Stride, 1, num2 / num * 40, num2, 0, height, 0.001f, 5f);
		stopwatch2.Stop();
		Stopwatch stopwatch3 = Stopwatch.StartNew();
		Marshal.Copy(scan, array, 0, array.Length);
		list = Class12.smethod_5(ref array, height, num2, num, bitmapData.Stride, list);
		stopwatch3.Stop();
		Stopwatch stopwatch4 = Stopwatch.StartNew();
		list = Class12.smethod_6(list, num);
		stopwatch4.Stop();
		for (int i = 0; i < list.Count; i++)
		{
			int num3;
			int num4;
			int num5;
			int num6;
			if (list[i].genum0_0 == GEnum0.MINION_REGION)
			{
				num3 = Math.Min(Math.Max(list[i].int_1 + list[i].int_3 * 7, 0), height - 2);
				num4 = Math.Min(height, list[i].int_1 + list[i].int_3 * 12);
				num5 = Math.Min(Math.Max(list[i].int_0, 0), num2 - list[i].int_3 * 3 * num);
				num6 = Math.Min(num2, (list[i].int_0 + list[i].int_3 * 18 * num) / num * num);
			}
			else
			{
				num3 = Math.Min(Math.Max(list[i].int_1 + list[i].int_3 * 5, 0), height - 2);
				num4 = Math.Min(height, list[i].int_1 + list[i].int_3 + list[i].int_3 * 10);
				num5 = Math.Min(Math.Max(list[i].int_0, 0), num2 - 2 * num);
				num6 = Math.Min(num2, (list[i].int_0 + list[i].int_3 * 8 * num) / num * num);
			}
			int num7 = num6 - num5;
			int num8 = num4 - num3;
			byte[] array2 = new byte[num7 * num8];
			int num9 = 0;
			for (int j = num3; j < num4; j++)
			{
				int num10 = j * bitmapData.Stride;
				int num11 = num9 * num7;
				int num12 = 0;
				for (int k = num5; k < num6; k += num)
				{
					array2[num11 + num12] = array[num10 + k];
					array2[num11 + num12 + 1] = array[num10 + k + 1];
					array2[num11 + num12 + 2] = array[num10 + k + 2];
					num12 += num;
				}
				num9++;
			}
			long num13 = (long)(num7 / 2);
			int num14 = num8 / 2;
			float num15 = 100f;
			for (int l = 0; l < num8; l++)
			{
				long num16 = 0L;
				float num17 = 0f;
				int num18 = l * num7;
				int num19 = 0;
				long num20 = 0L;
				float num21 = 1f;
				if (Math.Abs((float)l - (float)num8 / 2f) > (float)(list[i].int_3 * 2))
				{
					num21 = 0.01f;
				}
				for (int m = num * 3; m < num7 - num * 2; m += num)
				{
					if ((double)Math.Abs((float)m - (float)num7 / 2f) > (double)num7 * 0.2)
					{
						num21 *= 0.01f;
					}
					int num22 = 0;
					int num23 = 0;
					int num24 = 0;
					int num25 = (int)(array2[num18 + m + 2] - array2[num18 + m + 1] - array2[num18 + m]);
					for (int n = 1; n <= 3; n++)
					{
						num22 += Math.Abs((int)(array2[num18 - n + m] - array2[num18 + m + n]));
						num23 += Math.Abs((int)(array2[num18 - n + m + 1] - array2[num18 + m + n + 1]));
						num24 += Math.Abs((int)(array2[num18 - n + m + 2] - array2[num18 + m + n + 2]));
					}
					long num26 = (long)((Math.Abs(num22) + Math.Abs(num23) + Math.Abs(num24)) / 3);
					if (num26 > 50L)
					{
						num19++;
						num16 += num26;
						num20 += (long)m * num26;
						num17 += num21 * (float)num26;
					}
					if (num25 > 0)
					{
						int num27 = num25;
						if (list[i].genum0_0 == GEnum0.MINION_REGION)
						{
							num27 *= num25;
						}
						num19++;
						num16 += (long)num27;
						num20 += (long)(m * num27);
						num17 += num21 * (float)num27;
					}
				}
				if (num15 < num17)
				{
					num15 = num17;
					num14 = l;
					num20 /= num16;
					num13 = num20;
				}
			}
			list[i].int_5 = num5 + (int)(num13 / (long)num) * num;
			list[i].int_6 = num3 + num14 + list[i].int_3 * 2;
			list[i].int_9 = num5 + (int)((float)num13 - (float)num7 * 0.3f) / num * num;
			list[i].int_10 = Math.Min(list[i].int_6 - list[i].int_3, num3 + list[i].int_3 * 2);
			list[i].int_8 = (int)((float)num7 * 0.6f);
			list[i].int_7 = Math.Min(Math.Max(list[i].int_3 * 7, list[i].int_6 - list[i].int_10), height - list[i].int_10 - 1);
		}
		Class12.smethod_7(<Module>.smethod_7<string>(3311752021u) + string_0 + <Module>.smethod_9<string>(617912689u), bitmap_0, list, height, num2, num, bool_0);
		for (int num28 = 0; num28 < list.Count; num28++)
		{
			list[num28].int_5 /= num;
			list[num28].int_0 /= num;
			list[num28].int_9 /= num;
			list[num28].int_8 /= num;
			list[num28].int_2 /= num;
		}
		bitmap_0.UnlockBits(bitmapData);
		return list;
	}

	// Token: 0x060001F8 RID: 504 RVA: 0x0000E090 File Offset: 0x0000C290
	public static List<GClass0> smethod_9(Bitmap bitmap_0, bool bool_0 = false, int int_0 = 1000)
	{
		Stopwatch stopwatch = Stopwatch.StartNew();
		Stopwatch stopwatch2 = Stopwatch.StartNew();
		BitmapData bitmapData = bitmap_0.LockBits(new Rectangle(0, 0, bitmap_0.Width, bitmap_0.Height), ImageLockMode.ReadWrite, bitmap_0.PixelFormat);
		int num = Image.GetPixelFormatSize(bitmap_0.PixelFormat) / 8;
		Class12.byte_0 = new byte[bitmapData.Stride * bitmap_0.Height];
		IntPtr scan = bitmapData.Scan0;
		Marshal.Copy(scan, Class12.byte_0, 0, Class12.byte_0.Length);
		int height = bitmapData.Height;
		int num2 = bitmapData.Width * num;
		stopwatch2.Stop();
		Stopwatch stopwatch3 = Stopwatch.StartNew();
		Class12.smethod_1(height, num2, num, bitmapData.Stride, 2);
		stopwatch3.Stop();
		Stopwatch stopwatch4 = Stopwatch.StartNew();
		List<GClass0> list = Class12.smethod_2(ref Class12.byte_0, height, num2, num, bitmapData.Stride, 0, num2 / num * 40, num2 / 2, 0, height / 20, 0.001f, 5f);
		stopwatch4.Stop();
		Stopwatch stopwatch5 = Stopwatch.StartNew();
		list = Class12.smethod_3(list, num, height, 5, 10f, 50f, 20);
		stopwatch5.Stop();
		Stopwatch stopwatch6 = Stopwatch.StartNew();
		Marshal.Copy(scan, Class12.byte_0, 0, Class12.byte_0.Length);
		Class12.byte_0 = Class12.smethod_4(ref Class12.byte_0, height, num2, num, bitmapData.Stride, list);
		stopwatch6.Stop();
		Stopwatch stopwatch7 = Stopwatch.StartNew();
		list = Class12.smethod_2(ref Class12.byte_0, height, num2, num, bitmapData.Stride, 0, num2 / num * 40, num2 / 2, 0, height / 20, 0.001f, 5f);
		stopwatch7.Stop();
		Stopwatch.StartNew().Stop();
		Stopwatch.StartNew().Stop();
		Stopwatch.StartNew().Stop();
		Stopwatch stopwatch8 = Stopwatch.StartNew();
		Marshal.Copy(scan, Class12.byte_0, 0, Class12.byte_0.Length);
		list = Class12.smethod_5(ref Class12.byte_0, height, num2, num, bitmapData.Stride, list);
		stopwatch8.Stop();
		Stopwatch stopwatch9 = Stopwatch.StartNew();
		list = Class12.smethod_6(list, num);
		stopwatch9.Stop();
		Marshal.Copy(scan, Class12.byte_0, 0, Class12.byte_0.Length);
		for (int i = 0; i < list.Count; i++)
		{
			int num3;
			int num4;
			int num5;
			int num6;
			if (list[i].genum0_0 == GEnum0.MINION_REGION)
			{
				num3 = Math.Min(Math.Max(list[i].int_1 + list[i].int_3 * 7, 0), height - 2);
				num4 = Math.Min(height, list[i].int_1 + list[i].int_3 * 12);
				num5 = Math.Min(Math.Max(list[i].int_0, 0), num2 - list[i].int_3 * 3 * num);
				num6 = Math.Min(num2, (list[i].int_0 + list[i].int_3 * 18 * num) / num * num);
			}
			else
			{
				num3 = Math.Min(Math.Max(list[i].int_1 + list[i].int_3 * 5, 0), height - 2);
				num4 = Math.Min(height, list[i].int_1 + list[i].int_3 + list[i].int_3 * 10);
				num5 = Math.Min(Math.Max(list[i].int_0, 0), num2 - 2 * num);
				num6 = Math.Min(num2, (list[i].int_0 + list[i].int_3 * 8 * num) / num * num);
			}
			int num7 = num6 - num5;
			int num8 = num4 - num3;
			byte[] array = new byte[num7 * num8];
			int num9 = 0;
			for (int j = num3; j < num4; j++)
			{
				int num10 = j * bitmapData.Stride;
				int num11 = num9 * num7;
				int num12 = 0;
				for (int k = num5; k < num6; k += num)
				{
					array[num11 + num12] = Class12.byte_0[num10 + k];
					array[num11 + num12 + 1] = Class12.byte_0[num10 + k + 1];
					array[num11 + num12 + 2] = Class12.byte_0[num10 + k + 2];
					num12 += num;
				}
				num9++;
			}
			long num13 = (long)(num7 / 2);
			int num14 = num8 / 2;
			float num15 = 100f;
			for (int l = 0; l < num8; l++)
			{
				long num16 = 0L;
				float num17 = 0f;
				int num18 = l * num7;
				int num19 = 0;
				long num20 = 0L;
				float num21 = 1f;
				if (Math.Abs((float)l - (float)num8 / 2f) > (float)(list[i].int_3 * 2))
				{
					num21 = 0.01f;
				}
				for (int m = num * 3; m < num7 - num * 2; m += num)
				{
					if ((double)Math.Abs((float)m - (float)num7 / 2f) > (double)num7 * 0.2)
					{
						num21 *= 0.01f;
					}
					int num22 = 0;
					int num23 = 0;
					int num24 = 0;
					int num25 = (int)(array[num18 + m + 2] - array[num18 + m + 1] - array[num18 + m]);
					for (int n = 1; n <= 3; n++)
					{
						num22 += Math.Abs((int)(array[num18 - n + m] - array[num18 + m + n]));
						num23 += Math.Abs((int)(array[num18 - n + m + 1] - array[num18 + m + n + 1]));
						num24 += Math.Abs((int)(array[num18 - n + m + 2] - array[num18 + m + n + 2]));
					}
					long num26 = (long)((Math.Abs(num22) + Math.Abs(num23) + Math.Abs(num24)) / 3);
					if (num26 > 50L)
					{
						num19++;
						num16 += num26;
						num20 += (long)m * num26;
						num17 += num21 * (float)num26;
					}
					if (num25 > 0)
					{
						int num27 = num25;
						if (list[i].genum0_0 == GEnum0.MINION_REGION)
						{
							num27 *= num25;
						}
						num19++;
						num16 += (long)num27;
						num20 += (long)(m * num27);
						num17 += num21 * (float)num27;
					}
				}
				if (num15 < num17)
				{
					num15 = num17;
					num14 = l;
					num20 /= num16;
					num13 = num20;
				}
			}
			list[i].int_5 = num5 + (int)(num13 / (long)num) * num;
			list[i].int_6 = num3 + num14 + list[i].int_3 * 2;
			list[i].int_9 = num5 + (int)((float)num13 - (float)num7 * 0.3f) / num * num;
			list[i].int_10 = Math.Min(list[i].int_6 - list[i].int_3, num3 + list[i].int_3 * 2);
			list[i].int_8 = (int)((float)num7 * 0.6f);
			list[i].int_7 = Math.Min(Math.Max(list[i].int_3 * 7, list[i].int_6 - list[i].int_10), height - list[i].int_10 - 1);
		}
		Class12.smethod_7(<Module>.smethod_8<string>(222611471u) + int_0.ToString() + <Module>.smethod_7<string>(1807636913u), bitmap_0, list, height, num2, num, bool_0);
		for (int num28 = 0; num28 < list.Count; num28++)
		{
			list[num28].int_5 /= num;
			list[num28].int_0 /= num;
			list[num28].int_9 /= num;
			list[num28].int_8 /= num;
			list[num28].int_2 /= num;
		}
		bitmap_0.UnlockBits(bitmapData);
		stopwatch.Stop();
		return list;
	}

	// Token: 0x060001F9 RID: 505 RVA: 0x0000E8DC File Offset: 0x0000CADC
	[return: TupleElementNames(new string[]
	{
		"region",
		"x",
		"y"
	})]
	public static ValueTuple<GClass0, int, int> smethod_10(Bitmap bitmap_0, int int_0, int int_1, int int_2, int int_3)
	{
		List<GClass0> list = Class12.smethod_9(bitmap_0, false, 1000);
		Class12.logger_0.Info(<Module>.smethod_9<string>(635193024u) + list.Count.ToString());
		double num = 100000.0;
		int item = 0;
		int item2 = 0;
		GClass0 item3 = null;
		foreach (GClass0 gclass in list)
		{
			if (gclass.genum0_0 == GEnum0.ENEMY_REGION && (gclass.int_5 > 0 || gclass.int_6 > 0))
			{
				double num2 = Math.Sqrt((double)((gclass.int_5 + int_2 - int_0) * (gclass.int_5 + int_2 - int_0) + (gclass.int_6 + int_3 - int_1) * (gclass.int_6 + int_3 - int_1)));
				if (num2 < num)
				{
					num = num2;
					item = gclass.int_0 + int_2;
					item2 = gclass.int_1 + int_3;
					item3 = gclass;
				}
			}
		}
		return new ValueTuple<GClass0, int, int>(item3, item, item2);
	}

	// Token: 0x060001FA RID: 506 RVA: 0x0000E9F4 File Offset: 0x0000CBF4
	[return: TupleElementNames(new string[]
	{
		"x",
		"y",
		"width",
		"height",
		"rectX",
		"rectY",
		"offsetX",
		"offsetY",
		null
	})]
	public static ValueTuple<int, int, int, int, int, int, int, ValueTuple<int>> smethod_11(Bitmap bitmap_0, GClass0 gclass0_0, int int_0, int int_1, int int_2, int int_3, bool bool_0)
	{
		List<GClass0> list = Class12.smethod_8(bitmap_0, gclass0_0, bool_0, DateTime.Now.ToString(<Module>.smethod_6<string>(175475358u)));
		Class12.logger_0.Info(<Module>.smethod_6<string>(2462565851u) + list.Count.ToString());
		bitmap_0.Dispose();
		double num = 100000.0;
		int item = 0;
		int item2 = 0;
		int item3 = 0;
		int item4 = 0;
		int item5 = 0;
		int item6 = 0;
		foreach (GClass0 gclass in list)
		{
			if (gclass.genum0_0 == GEnum0.ENEMY_REGION && (gclass.int_5 > 0 || gclass.int_6 > 0))
			{
				double num2 = Math.Sqrt((double)((gclass.int_0 + int_2 - int_0) * (gclass.int_0 + int_2 - int_0) + (gclass.int_1 + int_3 - int_1) * (gclass.int_1 + int_3 - int_1)));
				if (num2 < num)
				{
					num = num2;
					item = gclass.int_5 + int_2;
					item2 = gclass.int_6 + int_3;
					item3 = gclass.int_8;
					item4 = gclass.int_7;
					item5 = gclass.int_9;
					item6 = gclass.int_10;
				}
			}
		}
		return new ValueTuple<int, int, int, int, int, int, int, ValueTuple<int>>(item, item2, item3, item4, item5, item6, int_2, new ValueTuple<int>(int_3));
	}

	// Token: 0x04000148 RID: 328
	private static byte[] byte_0 = null;

	// Token: 0x04000149 RID: 329
	private static readonly Logger logger_0 = LogManager.GetCurrentClassLogger();

	// Token: 0x02000030 RID: 48
	[CompilerGenerated]
	private sealed class Class13
	{
		// Token: 0x06000211 RID: 529 RVA: 0x0000EB64 File Offset: 0x0000CD64
		internal unsafe void method_0(int int_7)
		{
			byte[] array;
			byte* ptr;
			if ((array = Class12.byte_0) != null && array.Length != 0)
			{
				ptr = &array[0];
			}
			else
			{
				ptr = null;
			}
			for (int i = int_7 * this.int_0 / this.int_1; i < (int_7 + 1) * this.int_0 / this.int_1; i++)
			{
				int num = -111110;
				int num2 = -111110;
				int num3 = i * this.int_2;
				byte* ptr2 = ptr + num3;
				for (int j = 0; j < this.int_3; j += this.int_6)
				{
					byte* ptr3 = ptr2 + j;
					byte b = *ptr3;
					*ptr3 = 0;
					ptr3++;
					byte b2 = *ptr3;
					*ptr3 = 0;
					ptr3++;
					byte b3 = *ptr3;
					*ptr3 = 0;
					ptr3 -= 2;
					if (b3 < 80 && b3 > 25 && b2 < 40 && b < 40 && b3 > (b + b2) * 3)
					{
						*ptr3 = 50;
						num = j;
					}
					else if (b3 + b2 + b < 140 && b3 > 30 && b2 > 30 && b < 20 && b3 > b * 4 && b2 > b * 4 && (double)b3 > (double)b2 * 0.9)
					{
						*ptr3 = 50;
						num = j;
					}
					else if (b3 < 80 && b3 > 5 && b3 - b > 5 && b3 - b2 > 5 && Math.Abs((int)(b - b2)) < 18)
					{
						if (j - num < this.int_3 / 14)
						{
							*ptr3 = 100;
							num2 = j;
						}
					}
					else if (b3 > 110 && b2 > 70 && b > 70 && (double)b3 > (double)(b + b2) * 0.75 && (double)b3 < (double)(b + b2) * 0.9)
					{
						if (j - num < this.int_4)
						{
							*ptr3 = 150;
							num2 = j;
						}
					}
					else if (b3 > b + b2 && b2 < 100 && b < 100 && b3 > 110 && b2 > 50 && b > 50 && Math.Abs((int)(b - b2)) < 4 && Math.Abs((int)(b3 - b - b2)) < 30)
					{
						*ptr3 = 170;
					}
					else if (b3 > 120 && b2 < 120 && b < 120 && b2 > 20 && b > 20 && Math.Abs((int)(b - b2)) < 50 && (double)b3 > (double)(b + b2) * 0.8 && (double)b3 > (double)b * 1.6 && (double)b3 > (double)b2 * 1.6)
					{
						if (j - num2 < this.int_5 || j - num < this.int_5)
						{
							*ptr3 = byte.MaxValue;
						}
					}
					else if (b3 > 170 && b2 > 140 && b < 120 && b < 120 && b3 > b2 && b2 < 230 && b3 > b * 2 && b2 > b * 2 && (j - num2 < this.int_5 || j - num < this.int_5))
					{
						*ptr3 = 250;
					}
				}
			}
			array = null;
		}

		// Token: 0x0400014A RID: 330
		public int int_0;

		// Token: 0x0400014B RID: 331
		public int int_1;

		// Token: 0x0400014C RID: 332
		public int int_2;

		// Token: 0x0400014D RID: 333
		public int int_3;

		// Token: 0x0400014E RID: 334
		public int int_4;

		// Token: 0x0400014F RID: 335
		public int int_5;

		// Token: 0x04000150 RID: 336
		public int int_6;
	}

	// Token: 0x02000031 RID: 49
	[CompilerGenerated]
	[Serializable]
	private sealed class Class14
	{
		// Token: 0x06000215 RID: 533 RVA: 0x00002A6E File Offset: 0x00000C6E
		internal int method_0(GClass0 gclass0_0)
		{
			return gclass0_0.int_0;
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00002A6E File Offset: 0x00000C6E
		internal int method_1(GClass0 gclass0_0)
		{
			return gclass0_0.int_0;
		}

		// Token: 0x04000151 RID: 337
		public static readonly Class12.Class14 <>9 = new Class12.Class14();

		// Token: 0x04000152 RID: 338
		public static Func<GClass0, int> <>9__4_0;

		// Token: 0x04000153 RID: 339
		public static Func<GClass0, int> <>9__8_0;
	}
}
