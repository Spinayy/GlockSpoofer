namespace Auth.GG_Winform_Example
{
	// Token: 0x0200001A RID: 26
	public partial class Main : global::System.Windows.Forms.Form
	{
		// Token: 0x06000117 RID: 279 RVA: 0x0000F140 File Offset: 0x0000D340
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			bool flag2 = flag;
			if (flag2)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000118 RID: 280 RVA: 0x0000F17C File Offset: 0x0000D37C
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Siticone.UI.AnimatorNS.Animation animation = new global::Siticone.UI.AnimatorNS.Animation();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Auth.GG_Winform_Example.Main));
			this.siticoneDragControl1 = new global::Siticone.UI.WinForms.SiticoneDragControl(this.components);
			this.siticoneControlBox1 = new global::Siticone.UI.WinForms.SiticoneControlBox();
			this.siticoneControlBox2 = new global::Siticone.UI.WinForms.SiticoneControlBox();
			this.siticoneTransition1 = new global::Siticone.UI.WinForms.SiticoneTransition();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.welcome = new global::Siticone.UI.WinForms.SiticoneLabel();
			this.siticoneRoundedButton1 = new global::Siticone.UI.WinForms.SiticoneRoundedButton();
			this.userid = new global::Siticone.UI.WinForms.SiticoneLabel();
			this.username = new global::Siticone.UI.WinForms.SiticoneLabel();
			this.hwid = new global::Siticone.UI.WinForms.SiticoneLabel();
			this.uservariable = new global::Siticone.UI.WinForms.SiticoneLabel();
			this.userrank = new global::Siticone.UI.WinForms.SiticoneLabel();
			this.ip = new global::Siticone.UI.WinForms.SiticoneLabel();
			this.expiry = new global::Siticone.UI.WinForms.SiticoneLabel();
			this.lastlogin = new global::Siticone.UI.WinForms.SiticoneLabel();
			this.registerdate = new global::Siticone.UI.WinForms.SiticoneLabel();
			this.email = new global::Siticone.UI.WinForms.SiticoneLabel();
			this.label3 = new global::System.Windows.Forms.Label();
			this.siticoneRoundedButton5 = new global::Siticone.UI.WinForms.SiticoneRoundedButton();
			this.siticoneRoundedButton4 = new global::Siticone.UI.WinForms.SiticoneRoundedButton();
			this.siticoneRoundedButton6 = new global::Siticone.UI.WinForms.SiticoneRoundedButton();
			this.siticoneRoundedButton2 = new global::Siticone.UI.WinForms.SiticoneRoundedButton();
			this.siticoneRoundedButton7 = new global::Siticone.UI.WinForms.SiticoneRoundedButton();
			this.siticoneRoundedButton12 = new global::Siticone.UI.WinForms.SiticoneRoundedButton();
			this.siticoneRoundedButton13 = new global::Siticone.UI.WinForms.SiticoneRoundedButton();
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.groupBox2 = new global::System.Windows.Forms.GroupBox();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.siticoneRoundedButton15 = new global::Siticone.UI.WinForms.SiticoneRoundedButton();
			this.siticoneRoundedButton16 = new global::Siticone.UI.WinForms.SiticoneRoundedButton();
			this.siticoneRoundedButton17 = new global::Siticone.UI.WinForms.SiticoneRoundedButton();
			this.siticoneRoundedButton18 = new global::Siticone.UI.WinForms.SiticoneRoundedButton();
			this.siticoneRoundedButton19 = new global::Siticone.UI.WinForms.SiticoneRoundedButton();
			this.label5 = new global::System.Windows.Forms.Label();
			this.siticoneRoundedButton22 = new global::Siticone.UI.WinForms.SiticoneRoundedButton();
			this.siticoneRoundedButton25 = new global::Siticone.UI.WinForms.SiticoneRoundedButton();
			this.siticoneRoundedButton23 = new global::Siticone.UI.WinForms.SiticoneRoundedButton();
			this.siticoneCirclePictureBox1 = new global::Siticone.UI.WinForms.SiticoneCirclePictureBox();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.groupBox3 = new global::System.Windows.Forms.GroupBox();
			this.siticoneRoundedButton3 = new global::Siticone.UI.WinForms.SiticoneRoundedButton();
			this.siticoneRoundedButton8 = new global::Siticone.UI.WinForms.SiticoneRoundedButton();
			this.groupBox4 = new global::System.Windows.Forms.GroupBox();
			this.time = new global::System.Windows.Forms.Label();
			this.date = new global::System.Windows.Forms.Label();
			this.siticoneShadowForm = new global::Siticone.UI.WinForms.SiticoneShadowForm(this.components);
			this.openFileDialog1 = new global::System.Windows.Forms.OpenFileDialog();
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			this.siticoneCirclePictureBox1.BeginInit();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			base.SuspendLayout();
			this.siticoneDragControl1.TargetControl = this;
			this.siticoneControlBox1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneControlBox1.BorderRadius = 10;
			this.siticoneTransition1.SetDecoration(this.siticoneControlBox1, 0);
			this.siticoneControlBox1.FillColor = global::System.Drawing.Color.FromArgb(35, 39, 42);
			this.siticoneControlBox1.HoveredState.FillColor = global::System.Drawing.Color.FromArgb(232, 17, 35);
			this.siticoneControlBox1.HoveredState.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox1.HoveredState.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox1.Location = new global::System.Drawing.Point(809, 4);
			this.siticoneControlBox1.Name = "siticoneControlBox1";
			this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
			this.siticoneControlBox1.Size = new global::System.Drawing.Size(45, 29);
			this.siticoneControlBox1.TabIndex = 1;
			this.siticoneControlBox1.Click += new global::System.EventHandler(this.siticoneControlBox1_Click);
			this.siticoneControlBox2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.siticoneControlBox2.BorderRadius = 10;
			this.siticoneControlBox2.ControlBoxType = 0;
			this.siticoneTransition1.SetDecoration(this.siticoneControlBox2, 0);
			this.siticoneControlBox2.FillColor = global::System.Drawing.Color.FromArgb(35, 39, 42);
			this.siticoneControlBox2.HoveredState.Parent = this.siticoneControlBox2;
			this.siticoneControlBox2.IconColor = global::System.Drawing.Color.White;
			this.siticoneControlBox2.Location = new global::System.Drawing.Point(764, 4);
			this.siticoneControlBox2.Name = "siticoneControlBox2";
			this.siticoneControlBox2.ShadowDecoration.Parent = this.siticoneControlBox2;
			this.siticoneControlBox2.Size = new global::System.Drawing.Size(45, 29);
			this.siticoneControlBox2.TabIndex = 2;
			this.siticoneControlBox2.Click += new global::System.EventHandler(this.siticoneControlBox2_Click);
			this.siticoneTransition1.AnimationType = 1;
			this.siticoneTransition1.Cursor = null;
			animation.AnimateOnlyDifferences = true;
			animation.BlindCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation4.BlindCoeff");
			animation.LeafCoeff = 0f;
			animation.MaxTime = 1f;
			animation.MinTime = 0f;
			animation.MosaicCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation4.MosaicCoeff");
			animation.MosaicShift = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation4.MosaicShift");
			animation.MosaicSize = 0;
			animation.Padding = new global::System.Windows.Forms.Padding(50);
			animation.RotateCoeff = 1f;
			animation.RotateLimit = 0f;
			animation.ScaleCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation4.ScaleCoeff");
			animation.SlideCoeff = (global::System.Drawing.PointF)componentResourceManager.GetObject("animation4.SlideCoeff");
			animation.TimeCoeff = 0f;
			animation.TransparencyCoeff = 1f;
			this.siticoneTransition1.DefaultAnimation = animation;
			this.label1.AutoSize = true;
			this.siticoneTransition1.SetDecoration(this.label1, 0);
			this.label1.Font = new global::System.Drawing.Font("Segoe UI Light", 10f);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(-1, 136);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(0, 19);
			this.label1.TabIndex = 22;
			this.label2.AutoSize = true;
			this.siticoneTransition1.SetDecoration(this.label2, 0);
			this.label2.Font = new global::System.Drawing.Font("Segoe UI Semibold", 10.2f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.label2.Location = new global::System.Drawing.Point(10, 11);
			this.label2.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(98, 19);
			this.label2.TabIndex = 27;
			this.label2.Text = "Glock Spoofer";
			this.welcome.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneTransition1.SetDecoration(this.welcome, 0);
			this.welcome.Font = new global::System.Drawing.Font("Segoe UI", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.welcome.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.welcome.Location = new global::System.Drawing.Point(564, 108);
			this.welcome.Margin = new global::System.Windows.Forms.Padding(2);
			this.welcome.Name = "welcome";
			this.welcome.Size = new global::System.Drawing.Size(103, 22);
			this.welcome.TabIndex = 49;
			this.welcome.Text = "siticoneLabel1";
			this.welcome.Click += new global::System.EventHandler(this.welcome_Click);
			this.siticoneRoundedButton1.BorderThickness = 1;
			this.siticoneRoundedButton1.CheckedState.Parent = this.siticoneRoundedButton1;
			this.siticoneRoundedButton1.CustomImages.Parent = this.siticoneRoundedButton1;
			this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton1, 0);
			this.siticoneRoundedButton1.FillColor = global::System.Drawing.Color.FromArgb(128, 128, 255);
			this.siticoneRoundedButton1.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.siticoneRoundedButton1.ForeColor = global::System.Drawing.Color.White;
			this.siticoneRoundedButton1.HoveredState.BorderColor = global::System.Drawing.Color.FromArgb(213, 218, 223);
			this.siticoneRoundedButton1.HoveredState.Parent = this.siticoneRoundedButton1;
			this.siticoneRoundedButton1.Location = new global::System.Drawing.Point(651, 59);
			this.siticoneRoundedButton1.Name = "siticoneRoundedButton1";
			this.siticoneRoundedButton1.ShadowDecoration.Parent = this.siticoneRoundedButton1;
			this.siticoneRoundedButton1.Size = new global::System.Drawing.Size(181, 25);
			this.siticoneRoundedButton1.TabIndex = 50;
			this.siticoneRoundedButton1.Text = "Upload Profile Picture";
			this.siticoneRoundedButton1.Click += new global::System.EventHandler(this.siticoneRoundedButton1_Click_1);
			this.userid.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneTransition1.SetDecoration(this.userid, 0);
			this.userid.Font = new global::System.Drawing.Font("Segoe UI", 7.8f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.userid.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.userid.Location = new global::System.Drawing.Point(564, 138);
			this.userid.Margin = new global::System.Windows.Forms.Padding(2);
			this.userid.Name = "userid";
			this.userid.Size = new global::System.Drawing.Size(69, 14);
			this.userid.TabIndex = 37;
			this.userid.Text = "siticoneLabel1";
			this.userid.Click += new global::System.EventHandler(this.userid_Click);
			this.username.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneTransition1.SetDecoration(this.username, 0);
			this.username.Font = new global::System.Drawing.Font("Segoe UI", 7.8f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.username.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.username.Location = new global::System.Drawing.Point(564, 158);
			this.username.Margin = new global::System.Windows.Forms.Padding(2);
			this.username.Name = "username";
			this.username.Size = new global::System.Drawing.Size(69, 14);
			this.username.TabIndex = 38;
			this.username.Text = "siticoneLabel2";
			this.hwid.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneTransition1.SetDecoration(this.hwid, 0);
			this.hwid.Font = new global::System.Drawing.Font("Segoe UI", 7.8f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.hwid.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.hwid.Location = new global::System.Drawing.Point(564, 314);
			this.hwid.Margin = new global::System.Windows.Forms.Padding(2);
			this.hwid.Name = "hwid";
			this.hwid.Size = new global::System.Drawing.Size(69, 14);
			this.hwid.TabIndex = 40;
			this.hwid.Text = "siticoneLabel4";
			this.hwid.Click += new global::System.EventHandler(this.hwid_Click);
			this.uservariable.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneTransition1.SetDecoration(this.uservariable, 0);
			this.uservariable.Font = new global::System.Drawing.Font("Segoe UI", 7.8f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.uservariable.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.uservariable.Location = new global::System.Drawing.Point(564, 194);
			this.uservariable.Margin = new global::System.Windows.Forms.Padding(2);
			this.uservariable.Name = "uservariable";
			this.uservariable.Size = new global::System.Drawing.Size(69, 14);
			this.uservariable.TabIndex = 41;
			this.uservariable.Text = "siticoneLabel4";
			this.userrank.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneTransition1.SetDecoration(this.userrank, 0);
			this.userrank.Font = new global::System.Drawing.Font("Segoe UI", 7.8f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.userrank.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.userrank.Location = new global::System.Drawing.Point(564, 215);
			this.userrank.Margin = new global::System.Windows.Forms.Padding(2);
			this.userrank.Name = "userrank";
			this.userrank.Size = new global::System.Drawing.Size(69, 14);
			this.userrank.TabIndex = 42;
			this.userrank.Text = "siticoneLabel4";
			this.ip.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneTransition1.SetDecoration(this.ip, 0);
			this.ip.Font = new global::System.Drawing.Font("Segoe UI", 7.8f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ip.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.ip.Location = new global::System.Drawing.Point(564, 235);
			this.ip.Margin = new global::System.Windows.Forms.Padding(2);
			this.ip.Name = "ip";
			this.ip.Size = new global::System.Drawing.Size(69, 14);
			this.ip.TabIndex = 43;
			this.ip.Text = "siticoneLabel4";
			this.expiry.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneTransition1.SetDecoration(this.expiry, 0);
			this.expiry.Font = new global::System.Drawing.Font("Segoe UI", 7.8f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.expiry.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.expiry.Location = new global::System.Drawing.Point(564, 255);
			this.expiry.Margin = new global::System.Windows.Forms.Padding(2);
			this.expiry.Name = "expiry";
			this.expiry.Size = new global::System.Drawing.Size(69, 14);
			this.expiry.TabIndex = 44;
			this.expiry.Text = "siticoneLabel4";
			this.lastlogin.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneTransition1.SetDecoration(this.lastlogin, 0);
			this.lastlogin.Font = new global::System.Drawing.Font("Segoe UI", 7.8f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lastlogin.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.lastlogin.Location = new global::System.Drawing.Point(564, 276);
			this.lastlogin.Margin = new global::System.Windows.Forms.Padding(2);
			this.lastlogin.Name = "lastlogin";
			this.lastlogin.Size = new global::System.Drawing.Size(69, 14);
			this.lastlogin.TabIndex = 45;
			this.lastlogin.Text = "siticoneLabel4";
			this.registerdate.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneTransition1.SetDecoration(this.registerdate, 0);
			this.registerdate.Font = new global::System.Drawing.Font("Segoe UI", 7.8f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.registerdate.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.registerdate.Location = new global::System.Drawing.Point(564, 296);
			this.registerdate.Margin = new global::System.Windows.Forms.Padding(2);
			this.registerdate.Name = "registerdate";
			this.registerdate.Size = new global::System.Drawing.Size(69, 14);
			this.registerdate.TabIndex = 46;
			this.registerdate.Text = "siticoneLabel4";
			this.email.BackColor = global::System.Drawing.Color.Transparent;
			this.siticoneTransition1.SetDecoration(this.email, 0);
			this.email.Font = new global::System.Drawing.Font("Segoe UI", 7.8f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.email.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.email.Location = new global::System.Drawing.Point(564, 176);
			this.email.Margin = new global::System.Windows.Forms.Padding(2);
			this.email.Name = "email";
			this.email.Size = new global::System.Drawing.Size(69, 14);
			this.email.TabIndex = 39;
			this.email.Text = "siticoneLabel3";
			this.label3.AutoSize = true;
			this.siticoneTransition1.SetDecoration(this.label3, 0);
			this.label3.Font = new global::System.Drawing.Font("Javanese Text", 11.25f, global::System.Drawing.FontStyle.Bold | global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.label3.Location = new global::System.Drawing.Point(15, 349);
			this.label3.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(194, 34);
			this.label3.TabIndex = 56;
			this.label3.Text = "Made For Glock Spoofer";
			this.siticoneRoundedButton5.BorderColor = global::System.Drawing.Color.White;
			this.siticoneRoundedButton5.BorderThickness = 1;
			this.siticoneRoundedButton5.CheckedState.Parent = this.siticoneRoundedButton5;
			this.siticoneRoundedButton5.CustomImages.Parent = this.siticoneRoundedButton5;
			this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton5, 0);
			this.siticoneRoundedButton5.FillColor = global::System.Drawing.SystemColors.HotTrack;
			this.siticoneRoundedButton5.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.siticoneRoundedButton5.ForeColor = global::System.Drawing.Color.White;
			this.siticoneRoundedButton5.HoveredState.BorderColor = global::System.Drawing.Color.FromArgb(213, 218, 223);
			this.siticoneRoundedButton5.HoveredState.Parent = this.siticoneRoundedButton5;
			this.siticoneRoundedButton5.Location = new global::System.Drawing.Point(19, 107);
			this.siticoneRoundedButton5.Name = "siticoneRoundedButton5";
			this.siticoneRoundedButton5.ShadowDecoration.Parent = this.siticoneRoundedButton5;
			this.siticoneRoundedButton5.Size = new global::System.Drawing.Size(179, 44);
			this.siticoneRoundedButton5.TabIndex = 57;
			this.siticoneRoundedButton5.Text = "Dashboard";
			this.siticoneRoundedButton5.Click += new global::System.EventHandler(this.siticoneRoundedButton5_Click);
			this.siticoneRoundedButton4.BorderColor = global::System.Drawing.Color.White;
			this.siticoneRoundedButton4.BorderThickness = 1;
			this.siticoneRoundedButton4.CheckedState.Parent = this.siticoneRoundedButton4;
			this.siticoneRoundedButton4.CustomImages.Parent = this.siticoneRoundedButton4;
			this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton4, 0);
			this.siticoneRoundedButton4.FillColor = global::System.Drawing.SystemColors.HotTrack;
			this.siticoneRoundedButton4.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.siticoneRoundedButton4.ForeColor = global::System.Drawing.Color.White;
			this.siticoneRoundedButton4.HoveredState.BorderColor = global::System.Drawing.Color.FromArgb(213, 218, 223);
			this.siticoneRoundedButton4.HoveredState.Parent = this.siticoneRoundedButton4;
			this.siticoneRoundedButton4.Location = new global::System.Drawing.Point(19, 207);
			this.siticoneRoundedButton4.Name = "siticoneRoundedButton4";
			this.siticoneRoundedButton4.ShadowDecoration.Parent = this.siticoneRoundedButton4;
			this.siticoneRoundedButton4.Size = new global::System.Drawing.Size(179, 44);
			this.siticoneRoundedButton4.TabIndex = 59;
			this.siticoneRoundedButton4.Text = "Spoofer";
			this.siticoneRoundedButton4.Click += new global::System.EventHandler(this.siticoneRoundedButton4_Click_1);
			this.siticoneRoundedButton6.BorderColor = global::System.Drawing.Color.White;
			this.siticoneRoundedButton6.BorderThickness = 1;
			this.siticoneRoundedButton6.CheckedState.Parent = this.siticoneRoundedButton6;
			this.siticoneRoundedButton6.CustomImages.Parent = this.siticoneRoundedButton6;
			this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton6, 0);
			this.siticoneRoundedButton6.FillColor = global::System.Drawing.SystemColors.HotTrack;
			this.siticoneRoundedButton6.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.siticoneRoundedButton6.ForeColor = global::System.Drawing.Color.White;
			this.siticoneRoundedButton6.HoveredState.BorderColor = global::System.Drawing.Color.FromArgb(213, 218, 223);
			this.siticoneRoundedButton6.HoveredState.Parent = this.siticoneRoundedButton6;
			this.siticoneRoundedButton6.Location = new global::System.Drawing.Point(19, 157);
			this.siticoneRoundedButton6.Name = "siticoneRoundedButton6";
			this.siticoneRoundedButton6.ShadowDecoration.Parent = this.siticoneRoundedButton6;
			this.siticoneRoundedButton6.Size = new global::System.Drawing.Size(179, 44);
			this.siticoneRoundedButton6.TabIndex = 60;
			this.siticoneRoundedButton6.Text = "Methods";
			this.siticoneRoundedButton6.Click += new global::System.EventHandler(this.siticoneRoundedButton6_Click);
			this.siticoneRoundedButton2.BorderColor = global::System.Drawing.Color.White;
			this.siticoneRoundedButton2.BorderThickness = 1;
			this.siticoneRoundedButton2.CheckedState.Parent = this.siticoneRoundedButton2;
			this.siticoneRoundedButton2.CustomImages.Parent = this.siticoneRoundedButton2;
			this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton2, 0);
			this.siticoneRoundedButton2.FillColor = global::System.Drawing.SystemColors.HotTrack;
			this.siticoneRoundedButton2.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.siticoneRoundedButton2.ForeColor = global::System.Drawing.Color.White;
			this.siticoneRoundedButton2.HoveredState.BorderColor = global::System.Drawing.Color.FromArgb(213, 218, 223);
			this.siticoneRoundedButton2.HoveredState.Parent = this.siticoneRoundedButton2;
			this.siticoneRoundedButton2.Location = new global::System.Drawing.Point(19, 257);
			this.siticoneRoundedButton2.Name = "siticoneRoundedButton2";
			this.siticoneRoundedButton2.ShadowDecoration.Parent = this.siticoneRoundedButton2;
			this.siticoneRoundedButton2.Size = new global::System.Drawing.Size(179, 45);
			this.siticoneRoundedButton2.TabIndex = 61;
			this.siticoneRoundedButton2.Text = "Premium Menu";
			this.siticoneRoundedButton7.BorderThickness = 1;
			this.siticoneRoundedButton7.CheckedState.Parent = this.siticoneRoundedButton7;
			this.siticoneRoundedButton7.CustomImages.Parent = this.siticoneRoundedButton7;
			this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton7, 0);
			this.siticoneRoundedButton7.FillColor = global::System.Drawing.Color.DarkRed;
			this.siticoneRoundedButton7.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.siticoneRoundedButton7.ForeColor = global::System.Drawing.Color.White;
			this.siticoneRoundedButton7.HoveredState.BorderColor = global::System.Drawing.Color.FromArgb(213, 218, 223);
			this.siticoneRoundedButton7.HoveredState.Parent = this.siticoneRoundedButton7;
			this.siticoneRoundedButton7.Location = new global::System.Drawing.Point(19, 400);
			this.siticoneRoundedButton7.Name = "siticoneRoundedButton7";
			this.siticoneRoundedButton7.ShadowDecoration.Parent = this.siticoneRoundedButton7;
			this.siticoneRoundedButton7.Size = new global::System.Drawing.Size(96, 26);
			this.siticoneRoundedButton7.TabIndex = 62;
			this.siticoneRoundedButton7.Text = "Logout";
			this.siticoneRoundedButton7.Click += new global::System.EventHandler(this.siticoneRoundedButton7_Click_1);
			this.siticoneRoundedButton12.BorderThickness = 1;
			this.siticoneRoundedButton12.CheckedState.Parent = this.siticoneRoundedButton12;
			this.siticoneRoundedButton12.CustomImages.Parent = this.siticoneRoundedButton12;
			this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton12, 0);
			this.siticoneRoundedButton12.FillColor = global::System.Drawing.Color.Blue;
			this.siticoneRoundedButton12.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.siticoneRoundedButton12.ForeColor = global::System.Drawing.Color.White;
			this.siticoneRoundedButton12.HoveredState.BorderColor = global::System.Drawing.Color.FromArgb(213, 218, 223);
			this.siticoneRoundedButton12.HoveredState.Parent = this.siticoneRoundedButton12;
			this.siticoneRoundedButton12.Location = new global::System.Drawing.Point(31, 30);
			this.siticoneRoundedButton12.Name = "siticoneRoundedButton12";
			this.siticoneRoundedButton12.ShadowDecoration.Parent = this.siticoneRoundedButton12;
			this.siticoneRoundedButton12.Size = new global::System.Drawing.Size(96, 28);
			this.siticoneRoundedButton12.TabIndex = 68;
			this.siticoneRoundedButton12.Text = "Enable Bypass";
			this.siticoneRoundedButton12.Click += new global::System.EventHandler(this.siticoneRoundedButton12_Click_1);
			this.siticoneRoundedButton13.BorderThickness = 1;
			this.siticoneRoundedButton13.CheckedState.Parent = this.siticoneRoundedButton13;
			this.siticoneRoundedButton13.CustomImages.Parent = this.siticoneRoundedButton13;
			this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton13, 0);
			this.siticoneRoundedButton13.FillColor = global::System.Drawing.Color.Transparent;
			this.siticoneRoundedButton13.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.siticoneRoundedButton13.ForeColor = global::System.Drawing.Color.White;
			this.siticoneRoundedButton13.HoveredState.BorderColor = global::System.Drawing.Color.FromArgb(213, 218, 223);
			this.siticoneRoundedButton13.HoveredState.Parent = this.siticoneRoundedButton13;
			this.siticoneRoundedButton13.Location = new global::System.Drawing.Point(31, 64);
			this.siticoneRoundedButton13.Name = "siticoneRoundedButton13";
			this.siticoneRoundedButton13.ShadowDecoration.Parent = this.siticoneRoundedButton13;
			this.siticoneRoundedButton13.Size = new global::System.Drawing.Size(96, 28);
			this.siticoneRoundedButton13.TabIndex = 69;
			this.siticoneRoundedButton13.Text = "Disable Bypass";
			this.siticoneRoundedButton13.Click += new global::System.EventHandler(this.siticoneRoundedButton13_Click);
			this.groupBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.siticoneRoundedButton12);
			this.groupBox1.Controls.Add(this.siticoneRoundedButton13);
			this.siticoneTransition1.SetDecoration(this.groupBox1, 0);
			this.groupBox1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.groupBox1.Font = new global::System.Drawing.Font("Comic Sans MS", 8.25f, global::System.Drawing.FontStyle.Bold | global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Point, 161);
			this.groupBox1.ForeColor = global::System.Drawing.Color.DarkGoldenrod;
			this.groupBox1.Location = new global::System.Drawing.Point(336, 74);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(172, 116);
			this.groupBox1.TabIndex = 71;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Bypasser";
			this.groupBox2.BackColor = global::System.Drawing.Color.FromArgb(30, 39, 41);
			this.groupBox2.Controls.Add(this.pictureBox1);
			this.groupBox2.Controls.Add(this.siticoneRoundedButton15);
			this.groupBox2.Controls.Add(this.siticoneRoundedButton16);
			this.groupBox2.Controls.Add(this.siticoneRoundedButton17);
			this.groupBox2.Controls.Add(this.siticoneRoundedButton18);
			this.groupBox2.Controls.Add(this.siticoneRoundedButton19);
			this.groupBox2.Controls.Add(this.label5);
			this.siticoneTransition1.SetDecoration(this.groupBox2, 0);
			this.groupBox2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.groupBox2.Font = new global::System.Drawing.Font("Comic Sans MS", 9f, global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Point, 161);
			this.groupBox2.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.groupBox2.Location = new global::System.Drawing.Point(1, -2);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new global::System.Drawing.Size(227, 443);
			this.groupBox2.TabIndex = 72;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Glock Woofer";
			this.siticoneTransition1.SetDecoration(this.pictureBox1, 0);
			this.pictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox1.Image");
			this.pictureBox1.Location = new global::System.Drawing.Point(38, 19);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(136, 76);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 70;
			this.pictureBox1.TabStop = false;
			this.siticoneRoundedButton15.BorderThickness = 1;
			this.siticoneRoundedButton15.CheckedState.Parent = this.siticoneRoundedButton15;
			this.siticoneRoundedButton15.CustomImages.Parent = this.siticoneRoundedButton15;
			this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton15, 0);
			this.siticoneRoundedButton15.FillColor = global::System.Drawing.Color.DarkRed;
			this.siticoneRoundedButton15.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.siticoneRoundedButton15.ForeColor = global::System.Drawing.Color.White;
			this.siticoneRoundedButton15.HoveredState.BorderColor = global::System.Drawing.Color.FromArgb(213, 218, 223);
			this.siticoneRoundedButton15.HoveredState.Parent = this.siticoneRoundedButton15;
			this.siticoneRoundedButton15.Location = new global::System.Drawing.Point(23, 397);
			this.siticoneRoundedButton15.Name = "siticoneRoundedButton15";
			this.siticoneRoundedButton15.ShadowDecoration.Parent = this.siticoneRoundedButton15;
			this.siticoneRoundedButton15.Size = new global::System.Drawing.Size(96, 26);
			this.siticoneRoundedButton15.TabIndex = 69;
			this.siticoneRoundedButton15.Text = "Logout";
			this.siticoneRoundedButton15.Click += new global::System.EventHandler(this.siticoneRoundedButton15_Click);
			this.siticoneRoundedButton16.BorderThickness = 1;
			this.siticoneRoundedButton16.CheckedState.Parent = this.siticoneRoundedButton16;
			this.siticoneRoundedButton16.CustomImages.Parent = this.siticoneRoundedButton16;
			this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton16, 0);
			this.siticoneRoundedButton16.FillColor = global::System.Drawing.Color.DarkGoldenrod;
			this.siticoneRoundedButton16.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.siticoneRoundedButton16.ForeColor = global::System.Drawing.Color.White;
			this.siticoneRoundedButton16.HoveredState.BorderColor = global::System.Drawing.Color.FromArgb(213, 218, 223);
			this.siticoneRoundedButton16.HoveredState.Parent = this.siticoneRoundedButton16;
			this.siticoneRoundedButton16.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("siticoneRoundedButton16.Image");
			this.siticoneRoundedButton16.ImageAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.siticoneRoundedButton16.ImageSize = new global::System.Drawing.Size(35, 35);
			this.siticoneRoundedButton16.Location = new global::System.Drawing.Point(23, 260);
			this.siticoneRoundedButton16.Name = "siticoneRoundedButton16";
			this.siticoneRoundedButton16.PressedColor = global::System.Drawing.SystemColors.HotTrack;
			this.siticoneRoundedButton16.ShadowDecoration.Parent = this.siticoneRoundedButton16;
			this.siticoneRoundedButton16.Size = new global::System.Drawing.Size(179, 45);
			this.siticoneRoundedButton16.TabIndex = 68;
			this.siticoneRoundedButton16.Text = "Premium Menu";
			this.siticoneRoundedButton16.Click += new global::System.EventHandler(this.siticoneRoundedButton16_Click);
			this.siticoneRoundedButton17.BorderThickness = 1;
			this.siticoneRoundedButton17.CheckedState.Parent = this.siticoneRoundedButton17;
			this.siticoneRoundedButton17.CustomImages.Parent = this.siticoneRoundedButton17;
			this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton17, 0);
			this.siticoneRoundedButton17.FillColor = global::System.Drawing.Color.SlateBlue;
			this.siticoneRoundedButton17.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.siticoneRoundedButton17.ForeColor = global::System.Drawing.Color.White;
			this.siticoneRoundedButton17.HoveredState.BorderColor = global::System.Drawing.Color.FromArgb(213, 218, 223);
			this.siticoneRoundedButton17.HoveredState.Parent = this.siticoneRoundedButton17;
			this.siticoneRoundedButton17.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("siticoneRoundedButton17.Image");
			this.siticoneRoundedButton17.ImageAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.siticoneRoundedButton17.ImageSize = new global::System.Drawing.Size(35, 35);
			this.siticoneRoundedButton17.Location = new global::System.Drawing.Point(23, 154);
			this.siticoneRoundedButton17.Name = "siticoneRoundedButton17";
			this.siticoneRoundedButton17.PressedColor = global::System.Drawing.SystemColors.HotTrack;
			this.siticoneRoundedButton17.ShadowDecoration.Parent = this.siticoneRoundedButton17;
			this.siticoneRoundedButton17.Size = new global::System.Drawing.Size(179, 44);
			this.siticoneRoundedButton17.TabIndex = 67;
			this.siticoneRoundedButton17.Text = "System";
			this.siticoneRoundedButton17.Click += new global::System.EventHandler(this.siticoneRoundedButton17_Click);
			this.siticoneRoundedButton18.BorderThickness = 1;
			this.siticoneRoundedButton18.CheckedState.Parent = this.siticoneRoundedButton18;
			this.siticoneRoundedButton18.CustomImages.Parent = this.siticoneRoundedButton18;
			this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton18, 0);
			this.siticoneRoundedButton18.FillColor = global::System.Drawing.Color.SlateBlue;
			this.siticoneRoundedButton18.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.siticoneRoundedButton18.ForeColor = global::System.Drawing.Color.White;
			this.siticoneRoundedButton18.HoveredState.BorderColor = global::System.Drawing.Color.FromArgb(213, 218, 223);
			this.siticoneRoundedButton18.HoveredState.Parent = this.siticoneRoundedButton18;
			this.siticoneRoundedButton18.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("siticoneRoundedButton18.Image");
			this.siticoneRoundedButton18.ImageAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.siticoneRoundedButton18.ImageSize = new global::System.Drawing.Size(35, 35);
			this.siticoneRoundedButton18.Location = new global::System.Drawing.Point(23, 204);
			this.siticoneRoundedButton18.Name = "siticoneRoundedButton18";
			this.siticoneRoundedButton18.PressedColor = global::System.Drawing.SystemColors.HotTrack;
			this.siticoneRoundedButton18.ShadowDecoration.Parent = this.siticoneRoundedButton18;
			this.siticoneRoundedButton18.Size = new global::System.Drawing.Size(179, 44);
			this.siticoneRoundedButton18.TabIndex = 66;
			this.siticoneRoundedButton18.Text = "Games";
			this.siticoneRoundedButton18.Click += new global::System.EventHandler(this.siticoneRoundedButton18_Click);
			this.siticoneRoundedButton19.BorderThickness = 1;
			this.siticoneRoundedButton19.CheckedState.Parent = this.siticoneRoundedButton19;
			this.siticoneRoundedButton19.CustomImages.Parent = this.siticoneRoundedButton19;
			this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton19, 0);
			this.siticoneRoundedButton19.FillColor = global::System.Drawing.Color.SlateBlue;
			this.siticoneRoundedButton19.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.siticoneRoundedButton19.ForeColor = global::System.Drawing.SystemColors.Window;
			this.siticoneRoundedButton19.HoveredState.BorderColor = global::System.Drawing.Color.FromArgb(213, 218, 223);
			this.siticoneRoundedButton19.HoveredState.Parent = this.siticoneRoundedButton19;
			this.siticoneRoundedButton19.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("siticoneRoundedButton19.Image");
			this.siticoneRoundedButton19.ImageAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.siticoneRoundedButton19.ImageSize = new global::System.Drawing.Size(35, 35);
			this.siticoneRoundedButton19.Location = new global::System.Drawing.Point(23, 104);
			this.siticoneRoundedButton19.Name = "siticoneRoundedButton19";
			this.siticoneRoundedButton19.PressedColor = global::System.Drawing.Color.White;
			this.siticoneRoundedButton19.ShadowDecoration.Parent = this.siticoneRoundedButton19;
			this.siticoneRoundedButton19.Size = new global::System.Drawing.Size(179, 44);
			this.siticoneRoundedButton19.TabIndex = 65;
			this.siticoneRoundedButton19.Text = "Dashboard ";
			this.label5.AutoSize = true;
			this.siticoneTransition1.SetDecoration(this.label5, 0);
			this.label5.Font = new global::System.Drawing.Font("Javanese Text", 11.25f, global::System.Drawing.FontStyle.Bold | global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label5.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.label5.Location = new global::System.Drawing.Point(19, 346);
			this.label5.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(194, 34);
			this.label5.TabIndex = 64;
			this.label5.Text = "Made For Glock Spoofer";
			this.siticoneRoundedButton22.BorderThickness = 1;
			this.siticoneRoundedButton22.CheckedState.Parent = this.siticoneRoundedButton22;
			this.siticoneRoundedButton22.CustomImages.Parent = this.siticoneRoundedButton22;
			this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton22, 0);
			this.siticoneRoundedButton22.FillColor = global::System.Drawing.Color.Teal;
			this.siticoneRoundedButton22.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.siticoneRoundedButton22.ForeColor = global::System.Drawing.Color.White;
			this.siticoneRoundedButton22.HoveredState.BorderColor = global::System.Drawing.Color.FromArgb(213, 218, 223);
			this.siticoneRoundedButton22.HoveredState.Parent = this.siticoneRoundedButton22;
			this.siticoneRoundedButton22.Location = new global::System.Drawing.Point(231, 59);
			this.siticoneRoundedButton22.Name = "siticoneRoundedButton22";
			this.siticoneRoundedButton22.ShadowDecoration.Parent = this.siticoneRoundedButton22;
			this.siticoneRoundedButton22.Size = new global::System.Drawing.Size(90, 29);
			this.siticoneRoundedButton22.TabIndex = 76;
			this.siticoneRoundedButton22.Text = "Discord";
			this.siticoneRoundedButton22.Click += new global::System.EventHandler(this.siticoneRoundedButton22_Click);
			this.siticoneRoundedButton25.BorderThickness = 1;
			this.siticoneRoundedButton25.CheckedState.Parent = this.siticoneRoundedButton25;
			this.siticoneRoundedButton25.CustomImages.Parent = this.siticoneRoundedButton25;
			this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton25, 0);
			this.siticoneRoundedButton25.FillColor = global::System.Drawing.Color.SlateBlue;
			this.siticoneRoundedButton25.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.siticoneRoundedButton25.ForeColor = global::System.Drawing.Color.White;
			this.siticoneRoundedButton25.HoveredState.BorderColor = global::System.Drawing.Color.FromArgb(213, 218, 223);
			this.siticoneRoundedButton25.HoveredState.Parent = this.siticoneRoundedButton25;
			this.siticoneRoundedButton25.Location = new global::System.Drawing.Point(234, 378);
			this.siticoneRoundedButton25.Name = "siticoneRoundedButton25";
			this.siticoneRoundedButton25.ShadowDecoration.Parent = this.siticoneRoundedButton25;
			this.siticoneRoundedButton25.Size = new global::System.Drawing.Size(69, 52);
			this.siticoneRoundedButton25.TabIndex = 79;
			this.siticoneRoundedButton25.Text = "Activate Windows";
			this.siticoneRoundedButton25.Click += new global::System.EventHandler(this.siticoneRoundedButton25_Click);
			this.siticoneRoundedButton23.BorderThickness = 1;
			this.siticoneRoundedButton23.CheckedState.Parent = this.siticoneRoundedButton23;
			this.siticoneRoundedButton23.CustomImages.Parent = this.siticoneRoundedButton23;
			this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton23, 0);
			this.siticoneRoundedButton23.FillColor = global::System.Drawing.Color.Red;
			this.siticoneRoundedButton23.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.siticoneRoundedButton23.ForeColor = global::System.Drawing.Color.White;
			this.siticoneRoundedButton23.HoveredState.BorderColor = global::System.Drawing.Color.FromArgb(213, 218, 223);
			this.siticoneRoundedButton23.HoveredState.Parent = this.siticoneRoundedButton23;
			this.siticoneRoundedButton23.Location = new global::System.Drawing.Point(633, 355);
			this.siticoneRoundedButton23.Name = "siticoneRoundedButton23";
			this.siticoneRoundedButton23.ShadowDecoration.Parent = this.siticoneRoundedButton23;
			this.siticoneRoundedButton23.Size = new global::System.Drawing.Size(96, 28);
			this.siticoneRoundedButton23.TabIndex = 81;
			this.siticoneRoundedButton23.Text = "Join server";
			this.siticoneRoundedButton23.Click += new global::System.EventHandler(this.siticoneRoundedButton23_Click_1);
			this.siticoneCirclePictureBox1.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.siticoneTransition1.SetDecoration(this.siticoneCirclePictureBox1, 0);
			this.siticoneCirclePictureBox1.Location = new global::System.Drawing.Point(595, 55);
			this.siticoneCirclePictureBox1.Name = "siticoneCirclePictureBox1";
			this.siticoneCirclePictureBox1.ShadowDecoration.Mode = 1;
			this.siticoneCirclePictureBox1.ShadowDecoration.Parent = this.siticoneCirclePictureBox1;
			this.siticoneCirclePictureBox1.Size = new global::System.Drawing.Size(49, 48);
			this.siticoneCirclePictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.siticoneCirclePictureBox1.TabIndex = 52;
			this.siticoneCirclePictureBox1.TabStop = false;
			this.siticoneCirclePictureBox1.Click += new global::System.EventHandler(this.siticoneCirclePictureBox1_Click);
			this.textBox1.BackColor = global::System.Drawing.Color.Gray;
			this.siticoneTransition1.SetDecoration(this.textBox1, 0);
			this.textBox1.Location = new global::System.Drawing.Point(589, 389);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(198, 20);
			this.textBox1.TabIndex = 80;
			this.textBox1.TextChanged += new global::System.EventHandler(this.textBox1_TextChanged_1);
			this.groupBox3.BackColor = global::System.Drawing.Color.Transparent;
			this.groupBox3.Controls.Add(this.siticoneRoundedButton3);
			this.groupBox3.Controls.Add(this.siticoneRoundedButton8);
			this.siticoneTransition1.SetDecoration(this.groupBox3, 0);
			this.groupBox3.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.groupBox3.Font = new global::System.Drawing.Font("Comic Sans MS", 8.25f, global::System.Drawing.FontStyle.Bold | global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Point, 161);
			this.groupBox3.ForeColor = global::System.Drawing.Color.OrangeRed;
			this.groupBox3.Location = new global::System.Drawing.Point(336, 231);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new global::System.Drawing.Size(202, 148);
			this.groupBox3.TabIndex = 72;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Useful Tools";
			this.siticoneRoundedButton3.BorderThickness = 1;
			this.siticoneRoundedButton3.CheckedState.Parent = this.siticoneRoundedButton3;
			this.siticoneRoundedButton3.CustomImages.Parent = this.siticoneRoundedButton3;
			this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton3, 0);
			this.siticoneRoundedButton3.FillColor = global::System.Drawing.Color.DarkCyan;
			this.siticoneRoundedButton3.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.siticoneRoundedButton3.ForeColor = global::System.Drawing.Color.White;
			this.siticoneRoundedButton3.HoveredState.BorderColor = global::System.Drawing.Color.FromArgb(213, 218, 223);
			this.siticoneRoundedButton3.HoveredState.Parent = this.siticoneRoundedButton3;
			this.siticoneRoundedButton3.Location = new global::System.Drawing.Point(26, 39);
			this.siticoneRoundedButton3.Name = "siticoneRoundedButton3";
			this.siticoneRoundedButton3.ShadowDecoration.Parent = this.siticoneRoundedButton3;
			this.siticoneRoundedButton3.Size = new global::System.Drawing.Size(149, 28);
			this.siticoneRoundedButton3.TabIndex = 70;
			this.siticoneRoundedButton3.Text = "Download Serial Checker";
			this.siticoneRoundedButton3.Click += new global::System.EventHandler(this.siticoneRoundedButton3_Click_4);
			this.siticoneRoundedButton8.BorderThickness = 1;
			this.siticoneRoundedButton8.CheckedState.Parent = this.siticoneRoundedButton8;
			this.siticoneRoundedButton8.CustomImages.Parent = this.siticoneRoundedButton8;
			this.siticoneTransition1.SetDecoration(this.siticoneRoundedButton8, 0);
			this.siticoneRoundedButton8.FillColor = global::System.Drawing.Color.DarkCyan;
			this.siticoneRoundedButton8.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.siticoneRoundedButton8.ForeColor = global::System.Drawing.Color.White;
			this.siticoneRoundedButton8.HoveredState.BorderColor = global::System.Drawing.Color.FromArgb(213, 218, 223);
			this.siticoneRoundedButton8.HoveredState.Parent = this.siticoneRoundedButton8;
			this.siticoneRoundedButton8.Location = new global::System.Drawing.Point(26, 73);
			this.siticoneRoundedButton8.Name = "siticoneRoundedButton8";
			this.siticoneRoundedButton8.ShadowDecoration.Parent = this.siticoneRoundedButton8;
			this.siticoneRoundedButton8.Size = new global::System.Drawing.Size(146, 28);
			this.siticoneRoundedButton8.TabIndex = 71;
			this.siticoneRoundedButton8.Text = "Download Methods";
			this.siticoneRoundedButton8.Click += new global::System.EventHandler(this.siticoneRoundedButton8_Click_1);
			this.groupBox4.BackColor = global::System.Drawing.Color.Transparent;
			this.groupBox4.Controls.Add(this.time);
			this.groupBox4.Controls.Add(this.date);
			this.siticoneTransition1.SetDecoration(this.groupBox4, 0);
			this.groupBox4.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.groupBox4.Font = new global::System.Drawing.Font("Comic Sans MS", 8.25f, global::System.Drawing.FontStyle.Bold | global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Point, 161);
			this.groupBox4.ForeColor = global::System.Drawing.Color.DarkGoldenrod;
			this.groupBox4.Location = new global::System.Drawing.Point(228, -2);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new global::System.Drawing.Size(516, 51);
			this.groupBox4.TabIndex = 72;
			this.groupBox4.TabStop = false;
			this.time.AutoSize = true;
			this.siticoneTransition1.SetDecoration(this.time, 0);
			this.time.Font = new global::System.Drawing.Font("Courier New", 11.25f, global::System.Drawing.FontStyle.Italic);
			this.time.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.time.Location = new global::System.Drawing.Point(332, 19);
			this.time.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.time.Name = "time";
			this.time.Size = new global::System.Drawing.Size(44, 18);
			this.time.TabIndex = 29;
			this.time.Text = "Time";
			this.time.Click += new global::System.EventHandler(this.label6_Click);
			this.date.AutoSize = true;
			this.siticoneTransition1.SetDecoration(this.date, 0);
			this.date.Font = new global::System.Drawing.Font("Courier New", 11.25f, global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Point, 161);
			this.date.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.date.Location = new global::System.Drawing.Point(5, 19);
			this.date.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.date.Name = "date";
			this.date.Size = new global::System.Drawing.Size(44, 18);
			this.date.TabIndex = 28;
			this.date.Text = "Date";
			this.date.Click += new global::System.EventHandler(this.label4_Click_1);
			this.openFileDialog1.FileName = "openFileDialog1";
			this.timer1.Enabled = true;
			this.timer1.Tick += new global::System.EventHandler(this.timer1_Tick);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = global::System.Windows.Forms.AutoValidate.Disable;
			this.BackColor = global::System.Drawing.Color.FromArgb(37, 40, 39);
			base.ClientSize = new global::System.Drawing.Size(858, 440);
			base.Controls.Add(this.groupBox4);
			base.Controls.Add(this.groupBox3);
			base.Controls.Add(this.siticoneRoundedButton23);
			base.Controls.Add(this.textBox1);
			base.Controls.Add(this.siticoneRoundedButton25);
			base.Controls.Add(this.siticoneRoundedButton22);
			base.Controls.Add(this.groupBox2);
			base.Controls.Add(this.groupBox1);
			base.Controls.Add(this.siticoneRoundedButton7);
			base.Controls.Add(this.siticoneRoundedButton2);
			base.Controls.Add(this.siticoneRoundedButton6);
			base.Controls.Add(this.siticoneRoundedButton4);
			base.Controls.Add(this.siticoneRoundedButton5);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.siticoneCirclePictureBox1);
			base.Controls.Add(this.siticoneRoundedButton1);
			base.Controls.Add(this.welcome);
			base.Controls.Add(this.registerdate);
			base.Controls.Add(this.lastlogin);
			base.Controls.Add(this.expiry);
			base.Controls.Add(this.ip);
			base.Controls.Add(this.userrank);
			base.Controls.Add(this.uservariable);
			base.Controls.Add(this.hwid);
			base.Controls.Add(this.email);
			base.Controls.Add(this.username);
			base.Controls.Add(this.userid);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.siticoneControlBox2);
			base.Controls.Add(this.siticoneControlBox1);
			this.siticoneTransition1.SetDecoration(this, 1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Main";
			base.Opacity = 0.95;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Loader";
			base.TransparencyKey = global::System.Drawing.Color.Maroon;
			base.Load += new global::System.EventHandler(this.Main_Load);
			base.MouseClick += new global::System.Windows.Forms.MouseEventHandler(this.Main_MouseClick);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			this.siticoneCirclePictureBox1.EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000089 RID: 137
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400008A RID: 138
		private global::Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;

		// Token: 0x0400008B RID: 139
		private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox1;

		// Token: 0x0400008C RID: 140
		private global::Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox2;

		// Token: 0x0400008D RID: 141
		private global::Siticone.UI.WinForms.SiticoneTransition siticoneTransition1;

		// Token: 0x0400008E RID: 142
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400008F RID: 143
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000090 RID: 144
		private global::Siticone.UI.WinForms.SiticoneShadowForm siticoneShadowForm;

		// Token: 0x04000091 RID: 145
		private global::Siticone.UI.WinForms.SiticoneLabel welcome;

		// Token: 0x04000092 RID: 146
		private global::Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton1;

		// Token: 0x04000093 RID: 147
		private global::System.Windows.Forms.OpenFileDialog openFileDialog1;

		// Token: 0x04000094 RID: 148
		private global::Siticone.UI.WinForms.SiticoneCirclePictureBox siticoneCirclePictureBox1;

		// Token: 0x04000095 RID: 149
		private global::Siticone.UI.WinForms.SiticoneLabel registerdate;

		// Token: 0x04000096 RID: 150
		private global::Siticone.UI.WinForms.SiticoneLabel lastlogin;

		// Token: 0x04000097 RID: 151
		private global::Siticone.UI.WinForms.SiticoneLabel expiry;

		// Token: 0x04000098 RID: 152
		private global::Siticone.UI.WinForms.SiticoneLabel ip;

		// Token: 0x04000099 RID: 153
		private global::Siticone.UI.WinForms.SiticoneLabel userrank;

		// Token: 0x0400009A RID: 154
		private global::Siticone.UI.WinForms.SiticoneLabel uservariable;

		// Token: 0x0400009B RID: 155
		private global::Siticone.UI.WinForms.SiticoneLabel hwid;

		// Token: 0x0400009C RID: 156
		private global::Siticone.UI.WinForms.SiticoneLabel username;

		// Token: 0x0400009D RID: 157
		private global::Siticone.UI.WinForms.SiticoneLabel userid;

		// Token: 0x0400009E RID: 158
		private global::Siticone.UI.WinForms.SiticoneLabel email;

		// Token: 0x0400009F RID: 159
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040000A0 RID: 160
		private global::Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton6;

		// Token: 0x040000A1 RID: 161
		private global::Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton4;

		// Token: 0x040000A2 RID: 162
		private global::Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton5;

		// Token: 0x040000A3 RID: 163
		private global::Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton2;

		// Token: 0x040000A4 RID: 164
		private global::Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton7;

		// Token: 0x040000A5 RID: 165
		private global::Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton12;

		// Token: 0x040000A6 RID: 166
		private global::Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton13;

		// Token: 0x040000A7 RID: 167
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x040000A8 RID: 168
		private global::System.Windows.Forms.GroupBox groupBox2;

		// Token: 0x040000A9 RID: 169
		private global::Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton15;

		// Token: 0x040000AA RID: 170
		private global::Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton16;

		// Token: 0x040000AB RID: 171
		private global::Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton17;

		// Token: 0x040000AC RID: 172
		private global::Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton18;

		// Token: 0x040000AD RID: 173
		private global::Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton19;

		// Token: 0x040000AE RID: 174
		private global::System.Windows.Forms.Label label5;

		// Token: 0x040000AF RID: 175
		private global::Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton22;

		// Token: 0x040000B0 RID: 176
		private global::Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton25;

		// Token: 0x040000B1 RID: 177
		private global::Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton23;

		// Token: 0x040000B2 RID: 178
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x040000B3 RID: 179
		private global::System.Windows.Forms.GroupBox groupBox4;

		// Token: 0x040000B4 RID: 180
		private global::System.Windows.Forms.GroupBox groupBox3;

		// Token: 0x040000B5 RID: 181
		private global::Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton3;

		// Token: 0x040000B6 RID: 182
		private global::Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton8;

		// Token: 0x040000B7 RID: 183
		private global::System.Windows.Forms.Timer timer1;

		// Token: 0x040000B8 RID: 184
		private global::System.Windows.Forms.Label date;

		// Token: 0x040000B9 RID: 185
		private global::System.Windows.Forms.Label time;

		// Token: 0x040000BA RID: 186
		private global::System.Windows.Forms.PictureBox pictureBox1;
	}
}
