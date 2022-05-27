using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Vega_X
{
	// Token: 0x02000005 RID: 5
	public partial class Loader : Form
	{
		// Token: 0x06000028 RID: 40 RVA: 0x000021B1 File Offset: 0x000003B1
		public Loader()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000021D0 File Offset: 0x000003D0
		private void Loader_Load(object sender, EventArgs e)
		{
			base.TopMost = true;
			this.timer1.Enabled = true;
			this.timer1.Interval = 100;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00004868 File Offset: 0x00002A68
		private void timer1_Tick(object sender, EventArgs e)
		{
			this.progress += 50;
			bool flag = this.progress >= 1000;
			if (flag)
			{
				this.timer1.Enabled = false;
				this.timer1.Stop();
				base.Hide();
				Thread.Sleep(500);
				VegaX vegaX = new VegaX();
				vegaX.Show();
			}
			bool flag2 = this.progress >= 650;
			if (flag2)
			{
				this.label3.Visible = true;
				this.label2.Visible = false;
			}
			this.progressBar1.Value = this.progress;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002087 File Offset: 0x00000287
		private void progressBar1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002087 File Offset: 0x00000287
		private void label2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002087 File Offset: 0x00000287
		private void label1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000021F6 File Offset: 0x000003F6
		private void button5_Click(object sender, EventArgs e)
		{
			this.timer1.Interval = 10;
		}

		// Token: 0x04000029 RID: 41
		private int progress = 0;
	}
}
