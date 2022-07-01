using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Siticone.UI.AnimatorNS;
using Siticone.UI.WinForms;

namespace Auth.GG_Winform_Example
{
	// Token: 0x0200001B RID: 27
	public partial class Register : Form
	{
		// Token: 0x06000119 RID: 281 RVA: 0x0001281F File Offset: 0x00010A1F
		public Register()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00012838 File Offset: 0x00010A38
		private void siticoneRoundedButton1_Click(object sender, EventArgs e)
		{
			base.Hide();
			Login login = new Login();
			login.Show();
		}

		// Token: 0x0600011B RID: 283 RVA: 0x0001285A File Offset: 0x00010A5A
		private void siticoneControlBox1_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00012864 File Offset: 0x00010A64
		private void siticoneRoundedButton2_Click(object sender, EventArgs e)
		{
			bool flag = API.Register(this.username.Text, this.password.Text, this.email.Text, this.license.Text);
			if (flag)
			{
				MessageBox.Show("Register has been successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		// Token: 0x0600011D RID: 285 RVA: 0x000128BC File Offset: 0x00010ABC
		private void username_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600011E RID: 286 RVA: 0x000128BF File Offset: 0x00010ABF
		private void Register_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x0600011F RID: 287 RVA: 0x000128C2 File Offset: 0x00010AC2
		private void siticoneControlBox2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000120 RID: 288 RVA: 0x000128C5 File Offset: 0x00010AC5
		private void username_Enter(object sender, EventArgs e)
		{
			this.username.Text = "";
		}

		// Token: 0x06000121 RID: 289 RVA: 0x000128D9 File Offset: 0x00010AD9
		private void password_Enter(object sender, EventArgs e)
		{
			this.password.Text = "";
		}

		// Token: 0x06000122 RID: 290 RVA: 0x000128ED File Offset: 0x00010AED
		private void email_Enter(object sender, EventArgs e)
		{
			this.email.Text = "";
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00012901 File Offset: 0x00010B01
		private void license_Enter(object sender, EventArgs e)
		{
			this.license.Text = "";
		}
	}
}
