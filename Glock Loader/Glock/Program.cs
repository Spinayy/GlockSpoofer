using System;
using System.Windows.Forms;
using Auth.GG_Winform_Example;

namespace Glock
{
	// Token: 0x0200000A RID: 10
	internal static class Program
	{
		// Token: 0x0600005F RID: 95 RVA: 0x0000AC14 File Offset: 0x00008E14
		[STAThread]
		private static void Main()
		{
			OnProgramStart.Initialize("Glock Spoofer", "395100", "zi07YtzRWQSp6mOB2b0id0U57VX8X74y1L8", "1.6");
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Login());
		}
	}
}
