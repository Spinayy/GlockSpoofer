using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Media;
using System.Net;
using System.Security;
using System.Text;
using System.Windows.Forms;
using Auth.GG_Winform_Example;
using Microsoft.Win32;
using Siticone.UI.WinForms;
using Test;
using Test3;

namespace Test2
{
	// Token: 0x02000006 RID: 6
	public partial class SystemSpoofer : Form
	{
		// Token: 0x06000027 RID: 39 RVA: 0x00005F32 File Offset: 0x00004132
		public SystemSpoofer()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00005F4C File Offset: 0x0000414C
		public static void HWIDclick()
		{
			string keyName = "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\IDConfigDB\\Hardware Profiles\\0001";
			string text = (string)Registry.GetValue(keyName, "HwProfileGuid", "default");
			string value = string.Concat(new string[]
			{
				"{GlockOnTop-",
				Main.GenID(5),
				"-",
				Main.GenID(5),
				"-",
				Main.GenID(4),
				"-",
				Main.GenID(9),
				"}"
			});
			Registry.SetValue(keyName, "GUID", value);
			Registry.SetValue(keyName, "HwProfileGuid", value);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00005FEC File Offset: 0x000041EC
		public void musicv1()
		{
			WebClient webClient = new WebClient();
			string tempPath = Path.GetTempPath();
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/964942430480785408/985834860969091123/gamwtospiti.wav", tempPath + this.grwXIswrPv + ".mp3");
			new SoundPlayer(tempPath + this.grwXIswrPv + ".mp3").Play();
		}

		// Token: 0x0600002A RID: 42 RVA: 0x0000603F File Offset: 0x0000423F
		private void SystemSpoofer_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00006042 File Offset: 0x00004242
		private void siticoneControlBox1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x0600002C RID: 44 RVA: 0x0000604C File Offset: 0x0000424C
		private void siticoneRoundedButton15_Click(object sender, EventArgs e)
		{
			Login login = new Login();
			login.Show();
			base.Hide();
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00006070 File Offset: 0x00004270
		public static string rndString(int length)
		{
			return new string((from s in Enumerable.Repeat<string>("0123456789", length)
			select s[Test.random.Next(s.Length)]).ToArray<char>());
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000060BC File Offset: 0x000042BC
		public void wqyWTF47t0JP()
		{
			new Process
			{
				StartInfo = 
				{
					FileName = "cmd.exe",
					CreateNoWindow = true,
					RedirectStandardInput = true,
					RedirectStandardOutput = true,
					UseShellExecute = false,
					Verb = "runas",
					Arguments = string.Concat(new string[]
					{
						"/C cd C:/ && volumeid C: ",
						"-",
						" -nobanner"
					})
				}
			}.Start();
			bool flag = File.Exists("C:\\Volumeid.exe");
			if (flag)
			{
				File.Delete("C:\\Volumeid.exe");
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00006178 File Offset: 0x00004378
		private void siticoneRoundedButton19_Click(object sender, EventArgs e)
		{
			Main main = new Main();
			main.Show();
			base.Hide();
		}

		// Token: 0x06000030 RID: 48 RVA: 0x0000619C File Offset: 0x0000439C
		public void pancake()
		{
			WebClient webClient = new WebClient();
			string tempPath = Path.GetTempPath();
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/964942430480785408/985619618519457802/im_a_pancake_1_hour_loop.wav", tempPath + this.grwXIswrPv + ".mp3");
			new SoundPlayer(tempPath + this.grwXIswrPv + ".mp3").Play();
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000061F0 File Offset: 0x000043F0
		private void siticoneRoundedButton18_Click(object sender, EventArgs e)
		{
			Test.Loader loader = new Test.Loader();
			loader.Show();
			base.Hide();
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00006212 File Offset: 0x00004412
		private void siticoneRoundedButton9_Click(object sender, EventArgs e)
		{
			Process.Start("https://discord.gg/vQaQ2UUWU5");
			this.pancake();
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00006228 File Offset: 0x00004428
		public void ZylLF00l2wNH()
		{
			DialogResult dialogResult = MessageBox.Show("Do you want to restart your PC?", "Glock Woofer", MessageBoxButtons.YesNo);
			bool flag = dialogResult == DialogResult.Yes;
			if (flag)
			{
				Process.Start(new ProcessStartInfo("shutdown.exe", "-r -t 0")
				{
					CreateNoWindow = true,
					UseShellExecute = false,
					ErrorDialog = false
				});
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x0000627F File Offset: 0x0000447F
		private void siticoneRoundedButton2_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Spoofed PC", "Glock Woofer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			this.ZylLF00l2wNH();
		}

		// Token: 0x06000035 RID: 53 RVA: 0x0000629C File Offset: 0x0000449C
		private void siticoneRoundedButton8_Click(object sender, EventArgs e)
		{
			Class1 @class = new Class1();
			@class.spoofUserMode();
			bool flag = File.Exists("C:\\Windows\\System32\\nvml.dll");
			bool flag2 = flag;
			if (flag2)
			{
				try
				{
					File.Move("C:\\Windows\\System32\\nvml.dll", "C:\\Windows\\System32\\nvml2.dll");
					File.Move("C:\\Windows\\System32\\nvmld.dll", "C:\\Windows\\System32\\nvmld2.dll");
				}
				catch
				{
				}
			}
			MessageBox.Show("Cleaned Nvidia Logger!", "Glock Woofer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00006318 File Offset: 0x00004518
		private void siticoneRoundedButton16_Click(object sender, EventArgs e)
		{
			Test3.Loader loader = new Test3.Loader();
			loader.Show();
			base.Hide();
		}

		// Token: 0x06000037 RID: 55 RVA: 0x0000633A File Offset: 0x0000453A
		private void siticoneRoundedButton3_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Spoofed PC Name", "Glock Woofer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00006350 File Offset: 0x00004550
		public static string RandomMac()
		{
			string text = "ABCDEF0123456789";
			string text2 = "26AE";
			string text3 = "";
			Random random = new Random();
			text3 += text[random.Next(text.Length)].ToString();
			text3 += text2[random.Next(text2.Length)].ToString();
			for (int i = 0; i < 5; i++)
			{
				text3 += "-";
				text3 += text[random.Next(text.Length)].ToString();
				text3 += text[random.Next(text.Length)].ToString();
			}
			return text3;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x0000642C File Offset: 0x0000462C
		public static bool x9WBy16uhpC0()
		{
			bool result = false;
			foreach (string text in Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Class\\{4d36e972-e325-11ce-bfc1-08002be10318}").GetSubKeyNames())
			{
				bool flag = text != "Properties";
				if (flag)
				{
					try
					{
						RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Class\\{4d36e972-e325-11ce-bfc1-08002be10318}\\" + text, true);
						bool flag2 = registryKey.GetValue("BusType") != null;
						if (flag2)
						{
							registryKey.SetValue("NetworkAddress", SystemSpoofer.RandomMac());
							string adapterId = registryKey.GetValue("NetCfgInstanceId").ToString();
							SystemSpoofer.Enable_LocalAreaConection(adapterId, false);
							SystemSpoofer.Enable_LocalAreaConection(adapterId, true);
						}
					}
					catch (SecurityException)
					{
						return true;
					}
				}
			}
			return result;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00006508 File Offset: 0x00004708
		private static void Enable_LocalAreaConection(string adapterId, bool v)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00006510 File Offset: 0x00004710
		public static void e1VQVLbWdLng()
		{
			string value = SystemSpoofer.GenerateDate(8);
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", true);
			registryKey.SetValue("InstallDate", value);
			registryKey.Close();
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00006554 File Offset: 0x00004754
		private static string GenerateDate(int v)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600003D RID: 61 RVA: 0x0000655C File Offset: 0x0000475C
		private void siticoneRoundedButton1_Click(object sender, EventArgs e)
		{
			string text = Path.ChangeExtension(Path.GetTempFileName(), ".bat");
			using (StreamWriter streamWriter = new StreamWriter(text))
			{
				streamWriter.WriteLine("echo off");
				streamWriter.WriteLine("title Glock Woofer -- MAC");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("SETLOCAL ENABLEDELAYEDEXPANSION");
				streamWriter.WriteLine("SETLOCAL ENABLEEXTENSIONS");
				streamWriter.WriteLine("FOR /F tokens = 1 %%a IN ('wmic nic where physicaladapter^=true get deviceid ^| findstr [0-9]') DO (");
				streamWriter.WriteLine("CALL :MAC");
				streamWriter.WriteLine(" FOR %%b IN (0 00 000) DO (");
				streamWriter.WriteLine(" )");
				streamWriter.WriteLine(" )");
				streamWriter.WriteLine("FOR /F tokens = 1 %%a IN ('wmic nic where physicaladapter^=true get deviceid ^| findstr [0-9]') DO (");
				streamWriter.WriteLine(" FOR %%b IN (0 00 000) DO ");
				streamWriter.WriteLine(" REG QUERY HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Class\\{4D36E972-E325-11CE-BFC1-08002bE10318}\\%%b%%a >NUL 2>NUL && REG ADD HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Class\\{4D36E972-E325-11CE-BFC1-08002bE10318}\\%%b%%a /v PnPCapabilities /t REG_DWORD /d 24 /f >NUL 2>NUL");
				streamWriter.WriteLine(" )");
				streamWriter.WriteLine(" )");
				streamWriter.WriteLine(" FOR /F tokens = 2 delims =, skip = 2 %%a IN ('wmic nic where(netconnectionid like '%%') get netconnectionid, netconnectionstatus / format:csv') DO (");
				streamWriter.WriteLine(" netsh interface set interface name= %% a disable >NUL 2>NUL");
				streamWriter.WriteLine("netsh interface set interface name= %% a enable >NUL 2>NUL");
				streamWriter.WriteLine(")");
				streamWriter.WriteLine("GOTO :EOF");
				streamWriter.WriteLine(":MAC");
				streamWriter.WriteLine(" SET COUNT=0");
				streamWriter.WriteLine("SET GEN=ABCDEF0123456789");
				streamWriter.WriteLine("SET GEN2=26AE");
				streamWriter.WriteLine("SET MAC=");
				streamWriter.WriteLine(":MACLOOP");
				streamWriter.WriteLine(" SET /a COUNT+=1");
				streamWriter.WriteLine(" SET RND=%random%");
				streamWriter.WriteLine(" SET /A RND=RND%%16");
				streamWriter.WriteLine("SET RNDGEN=!GEN:~%RND%,1!");
				streamWriter.WriteLine(" SET /A RND2=RND%%4");
				streamWriter.WriteLine("SET RNDGEN2=!GEN2:~%RND2%,1!");
				streamWriter.WriteLine("IF  !COUNT!  EQU  2  (SET MAC=!MAC!!RNDGEN2!) ELSE (SET MAC=!MAC!!RNDGEN!)");
				streamWriter.WriteLine("IF !COUNT!  LEQ 11 GOTO MACLOOP ");
			}
			Process process = Process.Start(text);
			process.WaitForExit();
			File.Delete(text);
			MessageBox.Show("Spoofed MAC!", "Glock Woofer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x0000676C File Offset: 0x0000496C
		private void siticoneRoundedButton5_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600003F RID: 63 RVA: 0x0000676F File Offset: 0x0000496F
		private void siticoneRoundedButton4_Click(object sender, EventArgs e)
		{
			this.wqyWTF47t0JP();
			MessageBox.Show("Spoofed Volume Serial Number", "Glock Woofer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x0000678C File Offset: 0x0000498C
		public static void CuzqxhGdB1ly()
		{
			string value = Guid.NewGuid().ToString();
			RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SOFTWARE\\Microsoft\\Cryptography", true).SetValue("MachineGuid", value);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000067D4 File Offset: 0x000049D4
		public static void vsPHZ2U1uAah()
		{
			uint newSerial = uint.Parse(SystemSpoofer.GenerateString(8), NumberStyles.HexNumber);
			SystemSpoofer.ChangeSerialNumber('C', newSerial);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000067FC File Offset: 0x000049FC
		private static void ChangeSerialNumber(char v, uint newSerial)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00006804 File Offset: 0x00004A04
		private static string GenerateString(int v)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000044 RID: 68 RVA: 0x0000680C File Offset: 0x00004A0C
		private void siticoneRoundedButton7_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Spoofed HWID!", "Glock Woofer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00006824 File Offset: 0x00004A24
		public static void Bnc4fHNVZ7Hf()
		{
			foreach (string text in Registry.LocalMachine.OpenSubKey("HARDWARE\\DEVICEMAP\\Scsi").GetSubKeyNames())
			{
				foreach (string text2 in Registry.LocalMachine.OpenSubKey("HARDWARE\\DEVICEMAP\\Scsi\\" + text).GetSubKeyNames())
				{
					RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(string.Concat(new string[]
					{
						"HARDWARE\\DEVICEMAP\\Scsi\\",
						text,
						"\\",
						text2,
						"\\Target Id 0\\Logical Unit Id 0"
					}), true);
					bool flag = registryKey != null && registryKey.GetValue("DeviceType").ToString() == "DiskPeripheral";
					if (flag)
					{
						string text3 = SystemSpoofer.RandomId(14);
						string text4 = SystemSpoofer.RandomId(14);
						registryKey.SetValue("DeviceIdentifierPage", Encoding.UTF8.GetBytes(text4));
						registryKey.SetValue("Identifier", text3);
						registryKey.SetValue("InquiryData", Encoding.UTF8.GetBytes(text3));
						registryKey.SetValue("SerialNumber", text4);
					}
				}
			}
			foreach (string str in Registry.LocalMachine.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\MultifunctionAdapter\\0\\DiskController\\0\\DiskPeripheral").GetSubKeyNames())
			{
				Registry.LocalMachine.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\MultifunctionAdapter\\0\\DiskController\\0\\DiskPeripheral\\" + str, true).SetValue("Identifier", SystemSpoofer.RandomId(8) + "-" + SystemSpoofer.RandomId(8) + "-A");
			}
		}

		// Token: 0x06000046 RID: 70 RVA: 0x000069D3 File Offset: 0x00004BD3
		private static string RandomId(int v)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000047 RID: 71 RVA: 0x000069DB File Offset: 0x00004BDB
		private void siticoneRoundedButton6_Click_1(object sender, EventArgs e)
		{
			MessageBox.Show("Spoofed Disks", "Glock Woofer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x000087AF File Offset: 0x000069AF
		private void siticoneRoundedButton6_Click(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		// Token: 0x04000021 RID: 33
		private object Test2;

		// Token: 0x04000022 RID: 34
		private bool enable;

		// Token: 0x04000023 RID: 35
		private string grwXIswrPv;

		// Token: 0x04000024 RID: 36
		private static object random;

		// Token: 0x04000025 RID: 37
		private static object randoms;
	}
}
