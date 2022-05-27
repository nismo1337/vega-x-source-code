using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using EasyExploits;
using FastColoredTextBoxNS;
using WeAreDevs_API;

namespace Vega_X
{
	// Token: 0x0200000D RID: 13
	public partial class SimpleUI : Form
	{
		// Token: 0x06000202 RID: 514 RVA: 0x000024A2 File Offset: 0x000006A2
		public SimpleUI()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000203 RID: 515 RVA: 0x0000208A File Offset: 0x0000028A
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00002094 File Offset: 0x00000294
		private void button10_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x06000205 RID: 517 RVA: 0x000024D0 File Offset: 0x000006D0
		private void button5_Click(object sender, EventArgs e)
		{
			this.module.LaunchExploit();
		}

		// Token: 0x06000206 RID: 518 RVA: 0x000252D8 File Offset: 0x000234D8
		private void button2_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			bool flag = openFileDialog.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				openFileDialog.Title = "Open";
				this.fastColoredTextBox1.Text = File.ReadAllText(openFileDialog.FileName);
			}
		}

		// Token: 0x06000207 RID: 519 RVA: 0x000024DF File Offset: 0x000006DF
		private void button3_Click(object sender, EventArgs e)
		{
			this.module.ExecuteScript(this.fastColoredTextBox1.Text);
		}

		// Token: 0x06000208 RID: 520 RVA: 0x000024F9 File Offset: 0x000006F9
		private void button4_Click(object sender, EventArgs e)
		{
			this.fastColoredTextBox1.Clear();
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00002508 File Offset: 0x00000708
		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			this.lastPoint = new Point(e.X, e.Y);
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00025324 File Offset: 0x00023524
		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				base.Left += e.X - this.lastPoint.X;
				base.Top += e.Y - this.lastPoint.Y;
			}
		}

		// Token: 0x0600020B RID: 523 RVA: 0x0000209F File Offset: 0x0000029F
		private void SimpleUI_Load(object sender, EventArgs e)
		{
			base.TopMost = true;
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00002087 File Offset: 0x00000287
		private void label1_MouseUp(object sender, MouseEventArgs e)
		{
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00025324 File Offset: 0x00023524
		private void label1_MouseMove(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				base.Left += e.X - this.lastPoint.X;
				base.Top += e.Y - this.lastPoint.Y;
			}
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00002508 File Offset: 0x00000708
		private void label1_MouseDown(object sender, MouseEventArgs e)
		{
			this.lastPoint = new Point(e.X, e.Y);
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00025388 File Offset: 0x00023588
		private void button6_Click(object sender, EventArgs e)
		{
			ScriptHub scriptHub = new ScriptHub();
			scriptHub.Show();
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00002087 File Offset: 0x00000287
		private void fastColoredTextBox1_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x0400022C RID: 556
		private ExploitAPI api = new ExploitAPI();

		// Token: 0x0400022D RID: 557
		private Module module = new Module();

		// Token: 0x0400022E RID: 558
		private Point lastPoint;
	}
}
