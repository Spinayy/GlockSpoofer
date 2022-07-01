using System;
using System.Collections.Generic;

namespace Auth.GG_Winform_Example
{
	// Token: 0x0200000E RID: 14
	internal class App
	{
		// Token: 0x06000073 RID: 115 RVA: 0x0000B72C File Offset: 0x0000992C
		public static string GrabVariable(string name)
		{
			string result;
			try
			{
				bool flag = User.ID != null || User.HWID != null || User.IP != null || !Constants.Breached;
				if (flag)
				{
					result = App.Variables[name];
				}
				else
				{
					Constants.Breached = true;
					result = "User is not logged in, possible breach detected!";
				}
			}
			catch
			{
				result = "N/A";
			}
			return result;
		}

		// Token: 0x0400005C RID: 92
		public static string Error = null;

		// Token: 0x0400005D RID: 93
		public static Dictionary<string, string> Variables = new Dictionary<string, string>();
	}
}
