using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Media;
using System.Net;
using System.Windows.Forms;
using Siticone.UI.AnimatorNS;
using Siticone.UI.WinForms;

namespace Auth.GG_Winform_Example
{
	// Token: 0x0200001C RID: 28
	public partial class Login : Form
	{
		// Token: 0x06000126 RID: 294 RVA: 0x00013C7F File Offset: 0x00011E7F
		public Login()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00013C98 File Offset: 0x00011E98
		private void siticoneRoundedButton2_Click(object sender, EventArgs e)
		{
			base.Hide();
			Register register = new Register();
			register.Show();
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00013CBA File Offset: 0x00011EBA
		private void siticoneControlBox1_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00013CC4 File Offset: 0x00011EC4
		private void siticoneRoundedButton1_Click(object sender, EventArgs e)
		{
			bool flag = this.username.Text == "";
			if (flag)
			{
				MessageBox.Show("Username area cannot be empty!", "Glock Woofer", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			else
			{
				bool flag2 = this.password.Text != "";
				if (flag2)
				{
					bool flag3 = API.Login(this.username.Text, this.password.Text);
					if (flag3)
					{
						API.Log(User.Username, "Signed in");
						Main main = new Main();
						main.Show();
						base.Hide();
						Console.Beep();
					}
				}
				else
				{
					MessageBox.Show("Password area cannot be empty!", "Glock Woofer", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00013D80 File Offset: 0x00011F80
		public void nicetry()
		{
			WebClient webClient = new WebClient();
			string tempPath = Path.GetTempPath();
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/964942430480785408/985619618519457802/im_a_pancake_1_hour_loop.wav", tempPath + this.grwXIswrPv + ".mp3");
			new SoundPlayer(tempPath + this.grwXIswrPv + ".mp3").Play();
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00013DD4 File Offset: 0x00011FD4
		private static void DimisProtection()
		{
			Process[] processesByName = Process.GetProcessesByName("dnSpy");
			bool flag = processesByName.Length == 0;
			bool flag2 = !flag;
			if (flag2)
			{
				Process.Start(new ProcessStartInfo("shutdown.exe", "-r -t 0")
				{
					CreateNoWindow = true,
					UseShellExecute = false,
					ErrorDialog = false
				});
				Process.Start("cmd.exe", "/C choice /C Y /N /D Y /T 3 & Del " + Application.ExecutablePath);
				Application.Exit();
			}
			Process[] processesByName2 = Process.GetProcessesByName("ida64");
			bool flag3 = processesByName2.Length == 0;
			bool flag4 = !flag3;
			if (flag4)
			{
				Process.Start(new ProcessStartInfo("shutdown.exe", "-r -t 0")
				{
					CreateNoWindow = true,
					UseShellExecute = false,
					ErrorDialog = false
				});
				Process.Start("cmd.exe", "/C choice /C Y /N /D Y /T 3 & Del " + Application.ExecutablePath);
				Application.Exit();
			}
			Process[] processesByName3 = Process.GetProcessesByName("64dbg");
			bool flag5 = processesByName3.Length == 0;
			bool flag6 = !flag5;
			if (flag6)
			{
				Process.Start(new ProcessStartInfo("shutdown.exe", "-r -t 0")
				{
					CreateNoWindow = true,
					UseShellExecute = false,
					ErrorDialog = false
				});
				Process.Start("cmd.exe", "/C choice /C Y /N /D Y /T 3 & Del " + Application.ExecutablePath);
				Application.Exit();
			}
			Process[] processesByName4 = Process.GetProcessesByName("ollydbg");
			bool flag7 = processesByName4.Length == 0;
			bool flag8 = !flag7;
			if (flag8)
			{
				Process.Start(new ProcessStartInfo("shutdown.exe", "-r -t 0")
				{
					CreateNoWindow = true,
					UseShellExecute = false,
					ErrorDialog = false
				});
				Process.Start("cmd.exe", "/C choice /C Y /N /D Y /T 3 & Del " + Application.ExecutablePath);
				Application.Exit();
			}
			Process[] processesByName5 = Process.GetProcessesByName("x32dbg");
			bool flag9 = processesByName5.Length == 0;
			bool flag10 = !flag9;
			if (flag10)
			{
				Process.Start(new ProcessStartInfo("shutdown.exe", "-r -t 0")
				{
					CreateNoWindow = true,
					UseShellExecute = false,
					ErrorDialog = false
				});
				Process.Start("cmd.exe", "/C choice /C Y /N /D Y /T 3 & Del " + Application.ExecutablePath);
				Application.Exit();
			}
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00014000 File Offset: 0x00012200
		private void Login_Load(object sender, EventArgs e)
		{
			Login.DimisProtection();
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00014009 File Offset: 0x00012209
		private void label2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600012E RID: 302 RVA: 0x0001400C File Offset: 0x0001220C
		private void username_TextChanged(object sender, EventArgs e, string v)
		{
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00014010 File Offset: 0x00012210
		private void username_TextChanged(object sender, EventArgs e)
		{
			bool flag = this.username.Text == "Username";
			if (flag)
			{
				this.username.Text = "";
			}
		}

		// Token: 0x06000130 RID: 304 RVA: 0x0001404A File Offset: 0x0001224A
		private void username_Enter(object sender, EventArgs e)
		{
			this.username.Text = "";
		}

		// Token: 0x06000131 RID: 305 RVA: 0x0001405E File Offset: 0x0001225E
		private void password_Enter(object sender, EventArgs e)
		{
			this.password.Text = "";
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00014072 File Offset: 0x00012272
		private void password_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x040000C9 RID: 201
		private const string V = "";

		// Token: 0x040000CA RID: 202
		private object allahu;

		// Token: 0x040000CB RID: 203
		private string grwXIswrPv;
	}
}
