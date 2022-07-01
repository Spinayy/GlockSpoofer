using System;
using System.Linq;
using System.Security.Principal;

namespace Auth.GG_Winform_Example
{
	// Token: 0x0200000F RID: 15
	internal class Constants
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000076 RID: 118 RVA: 0x0000B7B3 File Offset: 0x000099B3
		// (set) Token: 0x06000077 RID: 119 RVA: 0x0000B7BA File Offset: 0x000099BA
		public static string Token { get; set; }

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000078 RID: 120 RVA: 0x0000B7C2 File Offset: 0x000099C2
		// (set) Token: 0x06000079 RID: 121 RVA: 0x0000B7C9 File Offset: 0x000099C9
		public static string Date { get; set; }

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600007A RID: 122 RVA: 0x0000B7D1 File Offset: 0x000099D1
		// (set) Token: 0x0600007B RID: 123 RVA: 0x0000B7D8 File Offset: 0x000099D8
		public static string APIENCRYPTKEY { get; set; }

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600007C RID: 124 RVA: 0x0000B7E0 File Offset: 0x000099E0
		// (set) Token: 0x0600007D RID: 125 RVA: 0x0000B7E7 File Offset: 0x000099E7
		public static string APIENCRYPTSALT { get; set; }

		// Token: 0x0600007E RID: 126 RVA: 0x0000B7F0 File Offset: 0x000099F0
		public static string RandomString(int length)
		{
			return new string((from s in Enumerable.Repeat<string>("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789", length)
			select s[Constants.random.Next(s.Length)]).ToArray<char>());
		}

		// Token: 0x0600007F RID: 127 RVA: 0x0000B83C File Offset: 0x00009A3C
		public static string HWID()
		{
			return WindowsIdentity.GetCurrent().User.Value;
		}

		// Token: 0x04000062 RID: 98
		public static bool Breached = false;

		// Token: 0x04000063 RID: 99
		public static bool Started = false;

		// Token: 0x04000064 RID: 100
		public static string IV = null;

		// Token: 0x04000065 RID: 101
		public static string Key = null;

		// Token: 0x04000066 RID: 102
		public static string ApiUrl = "https://api.auth.gg/csharp/";

		// Token: 0x04000067 RID: 103
		public static bool Initialized = false;

		// Token: 0x04000068 RID: 104
		public static Random random = new Random();
	}
}
