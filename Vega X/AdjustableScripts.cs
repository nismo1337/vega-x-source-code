using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using WeAreDevs_API;

namespace Vega_X
{
	// Token: 0x02000002 RID: 2
	public partial class AdjustableScripts : Form
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002064 File Offset: 0x00000264
		public AdjustableScripts()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002087 File Offset: 0x00000287
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000003 RID: 3 RVA: 0x0000208A File Offset: 0x0000028A
		private void button9_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002094 File Offset: 0x00000294
		private void button2_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002844 File Offset: 0x00000A44
		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			string text = this.textBox1.Text;
			bool flag = e.KeyChar == Convert.ToChar(Keys.Return);
			if (flag)
			{
				this.api.SendLuaScript("game.Players.LocalPlayer.Character.Humanoid.WalkSpeed = " + text);
				this.textBox1.Clear();
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002087 File Offset: 0x00000287
		private void textBox1_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000007 RID: 7 RVA: 0x0000209F File Offset: 0x0000029F
		private void AdjustableScripts_Load(object sender, EventArgs e)
		{
			base.TopMost = true;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002087 File Offset: 0x00000287
		private void label2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000028A0 File Offset: 0x00000AA0
		private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
		{
			string text = this.textBox2.Text;
			bool flag = e.KeyChar == Convert.ToChar(Keys.Return);
			if (flag)
			{
				this.api.SendLuaScript("game.Players.LocalPlayer.Character.Humanoid.JumpPower = " + text);
				this.textBox2.Clear();
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002087 File Offset: 0x00000287
		private void textBox2_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000028FC File Offset: 0x00000AFC
		private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
		{
			string text = this.textBox4.Text;
			bool flag = e.KeyChar == Convert.ToChar(Keys.Return);
			if (flag)
			{
				this.api.SendLuaScript("game.Workspace.Gravity = " + text);
				this.textBox4.Clear();
			}
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000020AA File Offset: 0x000002AA
		private void button1_Click(object sender, EventArgs e)
		{
			this.api.SendLuaScript("game.Players.LocalPlayer.Character.Humanoid.WalkSpeed = 16");
			Console.Beep();
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000020C5 File Offset: 0x000002C5
		private void button3_Click(object sender, EventArgs e)
		{
			this.api.SendLuaScript("game.Workspace.Gravity = 196.2");
			Console.Beep();
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000020E0 File Offset: 0x000002E0
		private void button4_Click(object sender, EventArgs e)
		{
			this.api.SendLuaScript("game.Players.LocalPlayer.Character.Humanoid.JumpPower = 50");
			Console.Beep();
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002958 File Offset: 0x00000B58
		private void button5_Click(object sender, EventArgs e)
		{
			this.api.SendLuaScript("game.Players.LocalPlayer.Character.Humanoid.JumpPower = 50");
			this.api.SendLuaScript("game.Workspace.Gravity = 196.2");
			this.api.SendLuaScript("game.Players.LocalPlayer.Character.Humanoid.WalkSpeed = 16");
			MessageBox.Show("All Character Modifications Have Been Reset.");
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000029A8 File Offset: 0x00000BA8
		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				base.Left += e.X - this.lastPoint.X;
				base.Top += e.Y - this.lastPoint.Y;
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000020FB File Offset: 0x000002FB
		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			this.lastPoint = new Point(e.X, e.Y);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000020FB File Offset: 0x000002FB
		private void label1_MouseDown(object sender, MouseEventArgs e)
		{
			this.lastPoint = new Point(e.X, e.Y);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000029A8 File Offset: 0x00000BA8
		private void label1_MouseMove(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				base.Left += e.X - this.lastPoint.X;
				base.Top += e.Y - this.lastPoint.Y;
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002087 File Offset: 0x00000287
		private void textBox4_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x04000001 RID: 1
		private ExploitAPI api = new ExploitAPI();

		// Token: 0x04000002 RID: 2
		private Point lastPoint;
	}
}
