namespace Vega_X
{
	// Token: 0x02000006 RID: 6
	public partial class MiniGame : global::System.Windows.Forms.Form
	{
		// Token: 0x06000036 RID: 54 RVA: 0x00005050 File Offset: 0x00003250
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00005090 File Offset: 0x00003290
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Vega_X.MiniGame));
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			base.SuspendLayout();
			this.timer1.Enabled = true;
			this.timer1.Interval = 10;
			this.timer1.Tick += new global::System.EventHandler(this.timer1_Tick);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(60, 60, 60);
			base.ClientSize = new global::System.Drawing.Size(800, 450);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "MiniGame";
			this.Text = "MiniGame (Re-Size Window To Move)";
			base.Load += new global::System.EventHandler(this.MiniGame_Load);
			base.ResumeLayout(false);
		}

		// Token: 0x04000037 RID: 55
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000038 RID: 56
		private global::System.Windows.Forms.Timer timer1;
	}
}
