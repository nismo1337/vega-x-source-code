using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using WeAreDevs_API;

namespace Vega_X
{
	// Token: 0x0200000B RID: 11
	public partial class ScriptHub3 : Form
	{
		// Token: 0x06000171 RID: 369 RVA: 0x000023CA File Offset: 0x000005CA
		public ScriptHub3()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00002094 File Offset: 0x00000294
		private void button2_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x06000173 RID: 371 RVA: 0x0000209F File Offset: 0x0000029F
		private void ScriptHub3_Load(object sender, EventArgs e)
		{
			base.TopMost = true;
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00002087 File Offset: 0x00000287
		private void label1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00002087 File Offset: 0x00000287
		private void button15_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000176 RID: 374 RVA: 0x0000208A File Offset: 0x0000028A
		private void button9_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000177 RID: 375 RVA: 0x000023ED File Offset: 0x000005ED
		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			this.lastPoint = new Point(e.X, e.Y);
		}

		// Token: 0x06000178 RID: 376 RVA: 0x0001AF44 File Offset: 0x00019144
		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				base.Left += e.X - this.lastPoint.X;
				base.Top += e.Y - this.lastPoint.Y;
			}
		}

		// Token: 0x06000179 RID: 377 RVA: 0x0001AF44 File Offset: 0x00019144
		private void label1_MouseMove(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				base.Left += e.X - this.lastPoint.X;
				base.Top += e.Y - this.lastPoint.Y;
			}
		}

		// Token: 0x0600017A RID: 378 RVA: 0x000023ED File Offset: 0x000005ED
		private void label1_MouseDown(object sender, MouseEventArgs e)
		{
			this.lastPoint = new Point(e.X, e.Y);
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00002087 File Offset: 0x00000287
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x0600017C RID: 380 RVA: 0x000088CC File Offset: 0x00006ACC
		private void button7_Click(object sender, EventArgs e)
		{
			base.Hide();
			ScriptHub2 scriptHub = new ScriptHub2();
			scriptHub.Show();
		}

		// Token: 0x0600017D RID: 381 RVA: 0x000124C0 File Offset: 0x000106C0
		private void button6_Click(object sender, EventArgs e)
		{
			base.Hide();
			ScriptHub scriptHub = new ScriptHub();
			scriptHub.Show();
		}

		// Token: 0x0600017E RID: 382 RVA: 0x0001AFA8 File Offset: 0x000191A8
		private void button93_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/7Dvxr2WN");
			this.api.SendLuaScript(script);
		}

		// Token: 0x0600017F RID: 383 RVA: 0x0001AFD8 File Offset: 0x000191D8
		private void button92_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/50Fx94Mf");
			this.api.SendLuaScript(script);
		}

		// Token: 0x06000180 RID: 384 RVA: 0x0001B008 File Offset: 0x00019208
		private void button13_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/HxiEuLU0");
			this.api.SendLuaScript(script);
		}

		// Token: 0x06000181 RID: 385 RVA: 0x0001B038 File Offset: 0x00019238
		private void button91_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/Ki9MdWhp");
			this.api.SendLuaScript(script);
		}

		// Token: 0x06000182 RID: 386 RVA: 0x0001B068 File Offset: 0x00019268
		private void button5_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/jv68vmUE");
			this.api.SendLuaScript(script);
		}

		// Token: 0x06000183 RID: 387 RVA: 0x0001B098 File Offset: 0x00019298
		private void button4_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/WzykCZ3f");
			this.api.SendLuaScript(script);
		}

		// Token: 0x06000184 RID: 388 RVA: 0x0001B0C8 File Offset: 0x000192C8
		private void button21_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/BJR0qrVt");
			this.api.SendLuaScript(script);
		}

		// Token: 0x06000185 RID: 389 RVA: 0x0001B0F8 File Offset: 0x000192F8
		private void button20_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/nXjKtdvk");
			this.api.SendLuaScript(script);
		}

		// Token: 0x06000186 RID: 390 RVA: 0x0001B128 File Offset: 0x00019328
		private void button19_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://raw.githubusercontent.com/BunnySalf/Hentai/main/MHEEHUB");
			this.api.SendLuaScript(script);
		}

		// Token: 0x06000187 RID: 391 RVA: 0x0001B158 File Offset: 0x00019358
		private void button18_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/BGu7tyrg");
			this.api.SendLuaScript(script);
		}

		// Token: 0x06000188 RID: 392 RVA: 0x0001B188 File Offset: 0x00019388
		private void button12_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://raw.githubusercontent.com/EdgeIY/infiniteyield/master/source");
			this.api.SendLuaScript(script);
		}

		// Token: 0x06000189 RID: 393 RVA: 0x0001B1B8 File Offset: 0x000193B8
		private void button8_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/y2mXFhC0");
			this.api.SendLuaScript(script);
		}

		// Token: 0x0600018A RID: 394 RVA: 0x0001B1E8 File Offset: 0x000193E8
		private void button11_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/g9g9H95T");
			this.api.SendLuaScript(script);
		}

		// Token: 0x0600018B RID: 395 RVA: 0x0001B218 File Offset: 0x00019418
		private void button3_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/xd4p5qQN");
			this.api.SendLuaScript(script);
		}

		// Token: 0x0600018C RID: 396 RVA: 0x0001B248 File Offset: 0x00019448
		private void button14_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/KmjuMx3m");
			this.api.SendLuaScript(script);
		}

		// Token: 0x0600018D RID: 397 RVA: 0x0001B278 File Offset: 0x00019478
		private void button1_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/e4KvBszD");
			this.api.SendLuaScript(script);
		}

		// Token: 0x0600018E RID: 398 RVA: 0x0001B2A8 File Offset: 0x000194A8
		private void button10_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://paste.ee/r/I20HH/0");
			this.api.SendLuaScript(script);
		}

		// Token: 0x0600018F RID: 399 RVA: 0x0001B2D8 File Offset: 0x000194D8
		private void button28_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/YpEXtdJy");
			this.api.SendLuaScript(script);
		}

		// Token: 0x06000190 RID: 400 RVA: 0x0001B308 File Offset: 0x00019508
		private void button29_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/KpaR8t5M");
			this.api.SendLuaScript(script);
		}

		// Token: 0x06000191 RID: 401 RVA: 0x0001B338 File Offset: 0x00019538
		private void button25_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/U29siiLB");
			this.api.SendLuaScript(script);
		}

		// Token: 0x06000192 RID: 402 RVA: 0x0001B368 File Offset: 0x00019568
		private void button24_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/mpZiCUsi");
			this.api.SendLuaScript(script);
		}

		// Token: 0x06000193 RID: 403 RVA: 0x0001B398 File Offset: 0x00019598
		private void button23_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/jDCpKDyV");
			this.api.SendLuaScript(script);
		}

		// Token: 0x06000194 RID: 404 RVA: 0x0001B3C8 File Offset: 0x000195C8
		private void button27_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/Mq4FTHB1");
			this.api.SendLuaScript(script);
		}

		// Token: 0x06000195 RID: 405 RVA: 0x0001B3F8 File Offset: 0x000195F8
		private void button22_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/LH2hH9Ru");
			this.api.SendLuaScript(script);
		}

		// Token: 0x06000196 RID: 406 RVA: 0x0001B428 File Offset: 0x00019628
		private void button16_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/ArgFS8v5");
			this.api.SendLuaScript(script);
		}

		// Token: 0x06000197 RID: 407 RVA: 0x0001B458 File Offset: 0x00019658
		private void button15_Click_1(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/ygwcfXck");
			this.api.SendLuaScript(script);
		}

		// Token: 0x06000198 RID: 408 RVA: 0x0001B488 File Offset: 0x00019688
		private void button26_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/t6Wg9jkL");
			this.api.SendLuaScript(script);
		}

		// Token: 0x06000199 RID: 409 RVA: 0x0001B4B8 File Offset: 0x000196B8
		private void button31_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://paste.ee/r/qbfoU/0");
			this.api.SendLuaScript(script);
		}

		// Token: 0x0600019A RID: 410 RVA: 0x0001B4E8 File Offset: 0x000196E8
		private void button32_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/3zUavF4g");
			this.api.SendLuaScript(script);
		}

		// Token: 0x0600019B RID: 411 RVA: 0x0001B518 File Offset: 0x00019718
		private void button33_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/6YQ8YmB4");
			this.api.SendLuaScript(script);
		}

		// Token: 0x0600019C RID: 412 RVA: 0x0001B548 File Offset: 0x00019748
		private void button30_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/JTR8eQQE");
			this.api.SendLuaScript(script);
		}

		// Token: 0x0600019D RID: 413 RVA: 0x0001B578 File Offset: 0x00019778
		private void button44_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/F2kjkhip");
			this.api.SendLuaScript(script);
		}

		// Token: 0x0600019E RID: 414 RVA: 0x0001B5A8 File Offset: 0x000197A8
		private void button45_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/7xVaeDvQ");
			this.api.SendLuaScript(script);
		}

		// Token: 0x0600019F RID: 415 RVA: 0x0001B5D8 File Offset: 0x000197D8
		private void button46_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/8gyLj9mx");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x0001B608 File Offset: 0x00019808
		private void button43_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/VECiYAqd");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x0001B638 File Offset: 0x00019838
		private void button41_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/uzjXFG6u");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x0001B668 File Offset: 0x00019868
		private void button40_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/GsnRLKgE");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x0001B698 File Offset: 0x00019898
		private void button39_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/efukZQnW");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x0001B6C8 File Offset: 0x000198C8
		private void button38_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/SatDWeF6");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x0001B6F8 File Offset: 0x000198F8
		private void button37_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/4dJtXW7T");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x0001B728 File Offset: 0x00019928
		private void button36_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/YNkWWyAu");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x0001B758 File Offset: 0x00019958
		private void button35_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/y2yFfXw3");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x0001B788 File Offset: 0x00019988
		private void button34_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/yxv9CbfX");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x0001B7B8 File Offset: 0x000199B8
		private void button42_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/LVRZBuES");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00002087 File Offset: 0x00000287
		private void panel3_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x060001AB RID: 427 RVA: 0x0001B7E8 File Offset: 0x000199E8
		private void button49_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/W9WFjykQ");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001AC RID: 428 RVA: 0x0001B818 File Offset: 0x00019A18
		private void button51_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/QzaGGr3B");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001AD RID: 429 RVA: 0x0001B848 File Offset: 0x00019A48
		private void button48_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/S7g4vVH6");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001AE RID: 430 RVA: 0x0001B878 File Offset: 0x00019A78
		private void button47_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/cD8eWK4K");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00005198 File Offset: 0x00003398
		private void button50_Click(object sender, EventArgs e)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				bool flag = process.ProcessName == "RobloxPlayerBeta";
				bool flag2 = flag;
				if (flag2)
				{
					process.Kill();
				}
			}
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x0001B8A8 File Offset: 0x00019AA8
		private void button54_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/5CKaXQGP");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x0001B8A8 File Offset: 0x00019AA8
		private void button55_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/5CKaXQGP");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x0001B8A8 File Offset: 0x00019AA8
		private void button56_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/5CKaXQGP");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x0001B8A8 File Offset: 0x00019AA8
		private void button53_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/5CKaXQGP");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x0001B8A8 File Offset: 0x00019AA8
		private void button52_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/5CKaXQGP");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x0001B8D8 File Offset: 0x00019AD8
		private void button67_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/hPxNj094");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x0001B908 File Offset: 0x00019B08
		private void button66_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/3GfYx03C");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x0001B938 File Offset: 0x00019B38
		private void button65_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/Tg7VZkDm");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x0001B908 File Offset: 0x00019B08
		private void button62_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/3GfYx03C");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x0001B908 File Offset: 0x00019B08
		private void button61_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/3GfYx03C");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001BA RID: 442 RVA: 0x0001B908 File Offset: 0x00019B08
		private void button60_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/3GfYx03C");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001BB RID: 443 RVA: 0x0001B908 File Offset: 0x00019B08
		private void button59_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/3GfYx03C");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001BC RID: 444 RVA: 0x0001B908 File Offset: 0x00019B08
		private void button58_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/3GfYx03C");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001BD RID: 445 RVA: 0x0001B908 File Offset: 0x00019B08
		private void button57_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/3GfYx03C");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001BE RID: 446 RVA: 0x0001B8A8 File Offset: 0x00019AA8
		private void button63_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/5CKaXQGP");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001BF RID: 447 RVA: 0x0001B8A8 File Offset: 0x00019AA8
		private void button64_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/5CKaXQGP");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x0001B968 File Offset: 0x00019B68
		private void button71_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/ZAjeQsqV");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x0001B908 File Offset: 0x00019B08
		private void button73_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/3GfYx03C");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x0001B908 File Offset: 0x00019B08
		private void button70_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/3GfYx03C");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x0001B908 File Offset: 0x00019B08
		private void button69_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/3GfYx03C");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x0001B908 File Offset: 0x00019B08
		private void button68_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/3GfYx03C");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x0001B998 File Offset: 0x00019B98
		private void button72_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/gAZFz1jN");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x0001B998 File Offset: 0x00019B98
		private void button77_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/gAZFz1jN");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x0001B998 File Offset: 0x00019B98
		private void button79_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/gAZFz1jN");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x0001B998 File Offset: 0x00019B98
		private void button76_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/gAZFz1jN");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x0001B998 File Offset: 0x00019B98
		private void button75_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/gAZFz1jN");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001CA RID: 458 RVA: 0x0001B998 File Offset: 0x00019B98
		private void button74_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/gAZFz1jN");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001CB RID: 459 RVA: 0x0001B998 File Offset: 0x00019B98
		private void button83_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/gAZFz1jN");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001CC RID: 460 RVA: 0x0001B998 File Offset: 0x00019B98
		private void button85_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/gAZFz1jN");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001CD RID: 461 RVA: 0x0001B998 File Offset: 0x00019B98
		private void button82_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/gAZFz1jN");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001CE RID: 462 RVA: 0x0001B9C8 File Offset: 0x00019BC8
		private void button81_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/itwzEm75");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001CF RID: 463 RVA: 0x0001B998 File Offset: 0x00019B98
		private void button80_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/gAZFz1jN");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x0001B9F8 File Offset: 0x00019BF8
		private void button78_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/GCPUsDzh");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x0001BA28 File Offset: 0x00019C28
		private void button84_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/vY3eMhzX");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x0001BA58 File Offset: 0x00019C58
		private void button89_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/mHHWDbbz");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x0001BA88 File Offset: 0x00019C88
		private void button90_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/VjVT44dh");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x0001BAB8 File Offset: 0x00019CB8
		private void button94_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/tz1249Fr");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x0001BAB8 File Offset: 0x00019CB8
		private void button88_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/tz1249Fr");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x0001BAB8 File Offset: 0x00019CB8
		private void button87_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/tz1249Fr");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x0001BAB8 File Offset: 0x00019CB8
		private void button86_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/tz1249Fr");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x0001BAE8 File Offset: 0x00019CE8
		private void button98_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/ycrDXnRU");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x0001BB18 File Offset: 0x00019D18
		private void button100_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/WgnTh2Js");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001DA RID: 474 RVA: 0x0001BB48 File Offset: 0x00019D48
		private void button99_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/LRJjFxZE");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001DB RID: 475 RVA: 0x0001BB78 File Offset: 0x00019D78
		private void button97_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/n4HbYaBg");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001DC RID: 476 RVA: 0x0001BBA8 File Offset: 0x00019DA8
		private void button96_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/0QWEisXk");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001DD RID: 477 RVA: 0x0001B3F8 File Offset: 0x000195F8
		private void button95_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/LH2hH9Ru");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001DE RID: 478 RVA: 0x0001BBD8 File Offset: 0x00019DD8
		private void button114_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/RCYV2fTq");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001DF RID: 479 RVA: 0x0001BC08 File Offset: 0x00019E08
		private void button115_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/BSAWq4B7");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x0001BC38 File Offset: 0x00019E38
		private void button116_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/RECwMzDZ");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x0001BC68 File Offset: 0x00019E68
		private void button113_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/sQa24JwK");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x0001BC98 File Offset: 0x00019E98
		private void button112_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/NuJkRZU8");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x0001BCC8 File Offset: 0x00019EC8
		private void button111_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/L75chtXt");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x0001BCF8 File Offset: 0x00019EF8
		private void button110_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://raw.githubusercontent.com/Historia00012/HISTORIAHUB/main/BSS%20FREE");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x0001BD28 File Offset: 0x00019F28
		private void button109_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/hhXLbMSj");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x0001BD58 File Offset: 0x00019F58
		private void button108_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/M1ycsJvj");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x0001BD88 File Offset: 0x00019F88
		private void button107_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/Jbwm8cHr");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x0001BDB8 File Offset: 0x00019FB8
		private void button106_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/2B87nBmn");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x0001BDE8 File Offset: 0x00019FE8
		private void button105_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/k5TJREte");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001EA RID: 490 RVA: 0x0001BE18 File Offset: 0x0001A018
		private void button104_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/i7eC3vXy");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001EB RID: 491 RVA: 0x0001BE48 File Offset: 0x0001A048
		private void button103_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/5cPi1vG2");
			this.api.SendLuaScript(script);
		}

		// Token: 0x060001EC RID: 492 RVA: 0x0001BE78 File Offset: 0x0001A078
		private void button102_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/5uJMZRGn");
			this.api.SendLuaScript(script);
		}

		// Token: 0x0400018B RID: 395
		private ExploitAPI api = new ExploitAPI();

		// Token: 0x0400018C RID: 396
		private Point lastPoint;
	}
}
