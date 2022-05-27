using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Vega_X
{
	// Token: 0x02000003 RID: 3
	public partial class FlappyVega : Form
	{
		// Token: 0x06000017 RID: 23 RVA: 0x00002115 File Offset: 0x00000315
		public FlappyVega()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00003878 File Offset: 0x00001A78
		private void GameTimerEvent(object sender, EventArgs e)
		{
			this.bird.Top += this.gravity;
			this.pipedown.Left -= this.pipespeed;
			this.pipeup.Left -= this.pipespeed;
			this.Score.Text = this.score.ToString();
			bool flag = this.pipedown.Left < -600;
			if (flag)
			{
				this.pipedown.Left = 800;
				this.score++;
			}
			bool flag2 = this.pipeup.Left < -650;
			if (flag2)
			{
				this.pipeup.Left = 800;
				this.score++;
			}
			bool flag3 = this.bird.Bounds.IntersectsWith(this.pipedown.Bounds) || this.bird.Bounds.IntersectsWith(this.pipeup.Bounds) || this.bird.Bounds.IntersectsWith(this.ground.Bounds) || this.bird.Bounds.IntersectsWith(this.panel1.Bounds);
			if (flag3)
			{
				this.endgame();
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000039FC File Offset: 0x00001BFC
		private void gamekeydown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.F;
			if (flag)
			{
				base.Close();
			}
			bool flag2 = e.KeyCode == Keys.A;
			if (flag2)
			{
				this.gametimer.Interval = 20;
				Label label = this.Score;
				label.Text += " ";
				Thread.Sleep(50);
				Label label2 = this.Score;
				label2.Text += "Current Mode = EASY";
			}
			bool flag3 = e.KeyCode == Keys.Z;
			if (flag3)
			{
				this.gametimer.Interval = 3;
				Label label3 = this.Score;
				label3.Text += " ";
				Thread.Sleep(50);
				Label label4 = this.Score;
				label4.Text += "Current Mode = EXPERT";
			}
			bool flag4 = e.KeyCode == Keys.Q;
			if (flag4)
			{
				this.gametimer.Interval = 10;
				Label label5 = this.Score;
				label5.Text += " ";
				Thread.Sleep(50);
				Label label6 = this.Score;
				label6.Text += "Current Mode = HARD";
			}
			bool flag5 = e.KeyCode == Keys.E;
			if (flag5)
			{
				this.gametimer.Enabled = true;
				this.label2.Visible = false;
				this.label3.Visible = false;
				this.label4.Visible = false;
				this.label5.Visible = false;
				this.label6.Visible = false;
			}
			bool flag6 = e.KeyCode == Keys.Space;
			if (flag6)
			{
				this.gravity = -7;
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002142 File Offset: 0x00000342
		private void endgame()
		{
			this.gametimer.Stop();
			Label label = this.Score;
			label.Text += "Game Over";
			base.Close();
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00003BCC File Offset: 0x00001DCC
		private void gamekeyup(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Space;
			if (flag)
			{
				this.gravity = 7;
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x0000209F File Offset: 0x0000029F
		private void FlappyVega_Load(object sender, EventArgs e)
		{
			base.TopMost = true;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002087 File Offset: 0x00000287
		private void label2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002175 File Offset: 0x00000375
		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			this.lastPoint = new Point(e.X, e.Y);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00003BF4 File Offset: 0x00001DF4
		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				base.Left += e.X - this.lastPoint.X;
				base.Top += e.Y - this.lastPoint.Y;
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x0000208A File Offset: 0x0000028A
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002094 File Offset: 0x00000294
		private void button2_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002087 File Offset: 0x00000287
		private void label5_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x04000014 RID: 20
		private int pipespeed = 5;

		// Token: 0x04000015 RID: 21
		private int gravity = 7;

		// Token: 0x04000016 RID: 22
		private int score = 0;

		// Token: 0x04000017 RID: 23
		private Point lastPoint;
	}
}
