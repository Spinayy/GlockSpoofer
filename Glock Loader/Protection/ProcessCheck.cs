using System;
using System.Diagnostics;
using System.Threading;

namespace Protection
{
	// Token: 0x0200000C RID: 12
	internal class ProcessCheck
	{
		// Token: 0x06000068 RID: 104 RVA: 0x0000AFDC File Offset: 0x000091DC
		public static void Initialize()
		{
			new Thread(new ThreadStart(ProcessCheck.check)).Start();
		}

		// Token: 0x06000069 RID: 105 RVA: 0x0000AFF8 File Offset: 0x000091F8
		public static void check()
		{
			bool flag = ProcessCheck.IsSandboxie();
			if (flag)
			{
				ProcessCheck.msg();
			}
			bool flag2 = ProcessCheck.IsDebugger();
			if (flag2)
			{
				ProcessCheck.msg();
			}
		}

		// Token: 0x0600006A RID: 106 RVA: 0x0000B028 File Offset: 0x00009228
		internal static bool IsSandboxie()
		{
			return ProcessCheck.IsDetected();
		}

		// Token: 0x0600006B RID: 107 RVA: 0x0000B040 File Offset: 0x00009240
		internal static bool IsDebugger()
		{
			return ProcessCheck.Run();
		}

		// Token: 0x0600006C RID: 108 RVA: 0x0000B057 File Offset: 0x00009257
		internal static void msg()
		{
			Environment.Exit(0);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x0000B064 File Offset: 0x00009264
		private static IntPtr GetModuleHandle(string libName)
		{
			foreach (object obj in Process.GetCurrentProcess().Modules)
			{
				ProcessModule processModule = (ProcessModule)obj;
				bool flag = processModule.ModuleName.ToLower().Contains(libName.ToLower());
				if (flag)
				{
					return processModule.BaseAddress;
				}
			}
			return IntPtr.Zero;
		}

		// Token: 0x0600006E RID: 110 RVA: 0x0000B0F4 File Offset: 0x000092F4
		internal static bool IsDetected()
		{
			return ProcessCheck.GetModuleHandle("SbieDll.dll") != IntPtr.Zero;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x0000B11C File Offset: 0x0000931C
		internal static bool Run()
		{
			bool result = false;
			bool flag = !Debugger.IsAttached && !Debugger.IsLogging();
			if (flag)
			{
				string[] array = new string[]
				{
					"dnspy",
					"codecracker",
					"x32dbg",
					"x64dbg",
					"ollydbg",
					"ida",
					"charles",
					"simpleassembly",
					"peek",
					"httpanalyzer",
					"httpdebug",
					"fiddler",
					"wireshark",
					"dbx",
					"mdbg",
					"gdb",
					"windbg",
					"dbgclr",
					"kdb",
					"kgdb",
					"mdb",
					"processhacker",
					"scylla_x86",
					"scylla_x64",
					"scylla",
					"idau64",
					"idau",
					"idaq",
					"idaq64",
					"idaw",
					"idaw64",
					"idag",
					"idag64",
					"ida64",
					"ida",
					"ImportREC",
					"IMMUNITYDEBUGGER",
					"MegaDumper",
					"CodeBrowser",
					"reshacker",
					"cheat engine"
				};
				foreach (Process process in Process.GetProcesses())
				{
					bool flag2 = process != Process.GetCurrentProcess();
					if (flag2)
					{
						for (int j = 0; j < array.Length; j++)
						{
							bool flag3 = process.ProcessName.ToLower().Contains(array[j]);
							if (flag3)
							{
								result = true;
							}
							bool flag4 = process.MainWindowTitle.ToLower().Contains(array[j]);
							if (flag4)
							{
								result = true;
							}
						}
					}
				}
			}
			return result;
		}
	}
}
