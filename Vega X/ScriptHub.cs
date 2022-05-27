using System;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using EasyExploits;
using WeAreDevs_API;

namespace Vega_X
{
	// Token: 0x02000009 RID: 9
	public partial class ScriptHub : Form
	{
		// Token: 0x06000068 RID: 104 RVA: 0x0000233A File Offset: 0x0000053A
		public ScriptHub()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002094 File Offset: 0x00000294
		private void button2_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00002087 File Offset: 0x00000287
		private void label1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00007698 File Offset: 0x00005898
		private void label1_MouseMove(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				base.Left += e.X - this.lastPoint.X;
				base.Top += e.Y - this.lastPoint.Y;
			}
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00002368 File Offset: 0x00000568
		private void label1_MouseDown(object sender, MouseEventArgs e)
		{
			this.lastPoint = new Point(e.X, e.Y);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00007698 File Offset: 0x00005898
		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				base.Left += e.X - this.lastPoint.X;
				base.Top += e.Y - this.lastPoint.Y;
			}
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00002368 File Offset: 0x00000568
		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			this.lastPoint = new Point(e.X, e.Y);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00002087 File Offset: 0x00000287
		private void button4_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000070 RID: 112 RVA: 0x0000208A File Offset: 0x0000028A
		private void button1_Click_1(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000071 RID: 113 RVA: 0x0000209F File Offset: 0x0000029F
		private void ScriptHub_Load_1(object sender, EventArgs e)
		{
			base.TopMost = true;
		}

		// Token: 0x06000072 RID: 114 RVA: 0x000076FC File Offset: 0x000058FC
		private void button10_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/nmQp3H5S");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000073 RID: 115 RVA: 0x0000772C File Offset: 0x0000592C
		private void button11_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/AA1sEPj9");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x0000775C File Offset: 0x0000595C
		private void button17_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/hzhXZCDp");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x0000778C File Offset: 0x0000598C
		private void button5_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://raw.githubusercontent.com/EdgeIY/infiniteyield/master/source");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000076 RID: 118 RVA: 0x000077BC File Offset: 0x000059BC
		private void button15_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/WsTFs9cM");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x000077EC File Offset: 0x000059EC
		private void button18_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/inTV4qEb");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0000781C File Offset: 0x00005A1C
		private void button13_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/QaNEaCWQ");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x0000784C File Offset: 0x00005A4C
		private void button9_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/gCqHzmxK");
			this.module.ExecuteScript(script);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x0000787C File Offset: 0x00005A7C
		private void button7_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/7xEvhGPt");
			this.module.ExecuteScript(script);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x000078AC File Offset: 0x00005AAC
		private void button16_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/XRQZ9TRD");
			this.module.ExecuteScript(script);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x000078DC File Offset: 0x00005ADC
		private void button12_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/wwQRd376");
			this.module.ExecuteScript(script);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x0000790C File Offset: 0x00005B0C
		private void button8_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/E4xJyXVT");
			this.module.ExecuteScript(script);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x0000793C File Offset: 0x00005B3C
		private void button14_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/4Jb97VWF");
			this.module.ExecuteScript(script);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x0000796C File Offset: 0x00005B6C
		private void button4_Click_1(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/7LHqgGR7");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000080 RID: 128 RVA: 0x0000799C File Offset: 0x00005B9C
		private void button3_Click_1(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/2j26Z6hT");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x000079CC File Offset: 0x00005BCC
		private void button6_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/RaV9yQPB");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00002087 File Offset: 0x00000287
		private void panel2_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000083 RID: 131 RVA: 0x000079FC File Offset: 0x00005BFC
		private void button20_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/fub69UPC");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00007A2C File Offset: 0x00005C2C
		private void button19_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/jGSADZUs");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00007A5C File Offset: 0x00005C5C
		private void button22_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/wLEJ6YDF");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00007A8C File Offset: 0x00005C8C
		private void button23_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/ubsmRJ0N");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00007ABC File Offset: 0x00005CBC
		private void button24_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/HLVSNhG5");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00007AEC File Offset: 0x00005CEC
		private void button21_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/WBux8Zti");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00007B1C File Offset: 0x00005D1C
		private void button28_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/uJFSy4UM");
			this.module.ExecuteScript(script);
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00007B4C File Offset: 0x00005D4C
		private void button30_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/stN7rtkS");
			this.module.ExecuteScript(script);
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00007B7C File Offset: 0x00005D7C
		private void button31_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/h2sR0jjk");
			this.module.ExecuteScript(script);
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00007BAC File Offset: 0x00005DAC
		private void button35_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/9kRGN3s6");
			this.module.ExecuteScript(script);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00007BDC File Offset: 0x00005DDC
		private void button33_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/dhx6PWjs");
			this.module.ExecuteScript(script);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00007C0C File Offset: 0x00005E0C
		private void button32_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/LF6kGu3c");
			this.module.ExecuteScript(script);
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00007C3C File Offset: 0x00005E3C
		private void button29_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/npWW17Vh");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00007C6C File Offset: 0x00005E6C
		private void button34_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/v3UnMKzs");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00007C9C File Offset: 0x00005E9C
		private void button27_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/0JxYan63");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00007CCC File Offset: 0x00005ECC
		private void button26_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/rD5LM6wa");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00007CFC File Offset: 0x00005EFC
		private void button25_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/Xvh0r8Y4");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00007D2C File Offset: 0x00005F2C
		private void button39_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/qSU9Af6K");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00002087 File Offset: 0x00000287
		private void label5_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00007D5C File Offset: 0x00005F5C
		private void button40_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/8v5ke3rj");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00007D8C File Offset: 0x00005F8C
		private void button39_Click_1(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/3mi7Q7ZN");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00007DBC File Offset: 0x00005FBC
		private void button38_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/PLpP0hv4");
			this.module.ExecuteScript(script);
		}

		// Token: 0x06000099 RID: 153 RVA: 0x000076FC File Offset: 0x000058FC
		private void button36_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/nmQp3H5S");
			this.module.ExecuteScript(script);
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00007DEC File Offset: 0x00005FEC
		private void button37_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/cGvhHsmj");
			this.module.ExecuteScript(script);
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00007E1C File Offset: 0x0000601C
		private void button41_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/hxiq7ete");
			this.module.ExecuteScript(script);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00007E4C File Offset: 0x0000604C
		private void button43_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/SsG8y3HA");
			this.module.ExecuteScript(script);
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00007E7C File Offset: 0x0000607C
		private void button42_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/4APXHsG4");
			this.module.ExecuteScript(script);
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00007EAC File Offset: 0x000060AC
		private void button44_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/AcfRR2rY");
			this.module.ExecuteScript(script);
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00007EDC File Offset: 0x000060DC
		private void button45_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/Fi6DhyZ5");
			this.module.ExecuteScript(script);
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00007F0C File Offset: 0x0000610C
		private void button47_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/50Fx94Mf");
			this.module.ExecuteScript(script);
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00007F3C File Offset: 0x0000613C
		private void button48_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/ZTwaS4r6");
			this.module.ExecuteScript(script);
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00007F6C File Offset: 0x0000616C
		private void button46_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/SXTsH1ep");
			this.module.ExecuteScript(script);
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x000076FC File Offset: 0x000058FC
		private void button49_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/nmQp3H5S");
			this.module.ExecuteScript(script);
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00007F9C File Offset: 0x0000619C
		private void button50_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/ACaMSi5E");
			this.module.ExecuteScript(script);
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00007FCC File Offset: 0x000061CC
		private void button38_Click_1(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/jDimL2uE");
			this.module.ExecuteScript(script);
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00007FFC File Offset: 0x000061FC
		private void button58_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/mmSYPxWr");
			this.module.ExecuteScript(script);
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x000076FC File Offset: 0x000058FC
		private void button59_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/nmQp3H5S");
			this.module.ExecuteScript(script);
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x0000802C File Offset: 0x0000622C
		private void button60_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/eLu8bfa9");
			this.module.ExecuteScript(script);
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x0000805C File Offset: 0x0000625C
		private void button61_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/RwQJ9Hf6");
			this.module.ExecuteScript(script);
		}

		// Token: 0x060000AA RID: 170 RVA: 0x0000808C File Offset: 0x0000628C
		private void button62_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/xXa7KEm9");
			this.module.ExecuteScript(script);
		}

		// Token: 0x060000AB RID: 171 RVA: 0x000080BC File Offset: 0x000062BC
		private void button56_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/YdW7Qr4v");
			this.module.ExecuteScript(script);
		}

		// Token: 0x060000AC RID: 172 RVA: 0x000076FC File Offset: 0x000058FC
		private void button55_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/nmQp3H5S");
			this.module.ExecuteScript(script);
		}

		// Token: 0x060000AD RID: 173 RVA: 0x000080EC File Offset: 0x000062EC
		private void button51_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/sTTPWcPh");
			this.module.ExecuteScript(script);
		}

		// Token: 0x060000AE RID: 174 RVA: 0x0000811C File Offset: 0x0000631C
		private void button57_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/7Dvxr2WN");
			this.module.ExecuteScript(script);
		}

		// Token: 0x060000AF RID: 175 RVA: 0x0000814C File Offset: 0x0000634C
		private void button54_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/1EfYc1Ji");
			this.module.ExecuteScript(script);
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x0000817C File Offset: 0x0000637C
		private void button52_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/uXxLXsVb");
			this.module.ExecuteScript(script);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x000081AC File Offset: 0x000063AC
		private void button53_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/ynGZffAv");
			this.module.ExecuteScript(script);
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x0000208A File Offset: 0x0000028A
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x000081DC File Offset: 0x000063DC
		private void button67_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/kz1Et0kG");
			this.module.ExecuteScript(script);
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x000076FC File Offset: 0x000058FC
		private void button66_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/nmQp3H5S");
			this.module.ExecuteScript(script);
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x0000820C File Offset: 0x0000640C
		private void button65_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/LAMKLyMb");
			this.module.ExecuteScript(script);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x0000823C File Offset: 0x0000643C
		private void button64_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/sT56AM8k");
			this.module.ExecuteScript(script);
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x0000826C File Offset: 0x0000646C
		private void button63_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/PkstS6Mr");
			this.module.ExecuteScript(script);
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x0000829C File Offset: 0x0000649C
		private void button72_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://ghostbin.co/paste/y8rb4/raw");
			this.module.ExecuteScript(script);
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x000082CC File Offset: 0x000064CC
		private void button71_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/NwHZw2Tg");
			this.module.ExecuteScript(script);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x000082FC File Offset: 0x000064FC
		private void button70_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/jaVGYcQQ");
			this.module.ExecuteScript(script);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x0000832C File Offset: 0x0000652C
		private void button69_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/WchTMzDB");
			this.module.ExecuteScript(script);
		}

		// Token: 0x060000BC RID: 188 RVA: 0x0000835C File Offset: 0x0000655C
		private void button68_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/m7vj2Fvr");
			this.module.ExecuteScript(script);
		}

		// Token: 0x060000BD RID: 189 RVA: 0x0000838C File Offset: 0x0000658C
		private void button73_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/afLQ5vDy");
			this.module.ExecuteScript(script);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x000083BC File Offset: 0x000065BC
		private void button77_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/zP2c3Nqv");
			this.module.ExecuteScript(script);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x000083EC File Offset: 0x000065EC
		private void button74_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/rKCUB2g1");
			this.module.ExecuteScript(script);
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x0000841C File Offset: 0x0000661C
		private void button76_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/C8bmZnQ4");
			this.module.ExecuteScript(script);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x0000844C File Offset: 0x0000664C
		private void button75_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://raw.githubusercontent.com/JoshieGemFinder/gubgub/main/beeswaemfree");
			this.module.ExecuteScript(script);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x0000847C File Offset: 0x0000667C
		private void button81_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/F17Xe560");
			this.module.ExecuteScript(script);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x000076FC File Offset: 0x000058FC
		private void button80_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/nmQp3H5S");
			this.module.ExecuteScript(script);
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x000084AC File Offset: 0x000066AC
		private void button79_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/ftzpeQYz");
			this.module.ExecuteScript(script);
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x000084DC File Offset: 0x000066DC
		private void button78_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/pzvMtyyT");
			this.module.ExecuteScript(script);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x0000850C File Offset: 0x0000670C
		private void button83_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/QEzQyxDT");
			this.module.ExecuteScript(script);
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x0000853C File Offset: 0x0000673C
		private void button86_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/uLe9rWfY");
			this.module.ExecuteScript(script);
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x0000856C File Offset: 0x0000676C
		private void button85_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/Zt9FHBz7");
			this.module.ExecuteScript(script);
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x0000859C File Offset: 0x0000679C
		private void button84_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/nLwctUaw");
			this.module.ExecuteScript(script);
		}

		// Token: 0x060000CA RID: 202 RVA: 0x000085CC File Offset: 0x000067CC
		private void button87_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/g5Gz29Dr");
			this.module.ExecuteScript(script);
		}

		// Token: 0x060000CB RID: 203 RVA: 0x000085FC File Offset: 0x000067FC
		private void button82_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/GPd6QyAf");
			this.module.ExecuteScript(script);
		}

		// Token: 0x060000CC RID: 204 RVA: 0x0000862C File Offset: 0x0000682C
		private void button100_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/GwG7JhqH");
			this.module.ExecuteScript(script);
		}

		// Token: 0x060000CD RID: 205 RVA: 0x0000865C File Offset: 0x0000685C
		private void button101_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/LbuPFVK6");
			this.module.ExecuteScript(script);
		}

		// Token: 0x060000CE RID: 206 RVA: 0x0000868C File Offset: 0x0000688C
		private void button102_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/9tMDAzUL");
			this.module.ExecuteScript(script);
		}

		// Token: 0x060000CF RID: 207 RVA: 0x000086BC File Offset: 0x000068BC
		private void button103_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/vDbQR7DW");
			this.module.ExecuteScript(script);
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x000076FC File Offset: 0x000058FC
		private void button104_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/nmQp3H5S");
			this.module.ExecuteScript(script);
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x000086EC File Offset: 0x000068EC
		private void button98_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/7XKrCZMD");
			this.module.ExecuteScript(script);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x0000871C File Offset: 0x0000691C
		private void button97_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/YG2GB74g");
			this.module.ExecuteScript(script);
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x0000874C File Offset: 0x0000694C
		private void button99_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/6wXvMJu9");
			this.module.ExecuteScript(script);
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x0000877C File Offset: 0x0000697C
		private void button96_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/UhM5xJ06");
			this.module.ExecuteScript(script);
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x000076FC File Offset: 0x000058FC
		private void button94_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/nmQp3H5S");
			this.module.ExecuteScript(script);
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x000087AC File Offset: 0x000069AC
		private void button95_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/JQ1Z8Mp2");
			this.module.ExecuteScript(script);
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x000087DC File Offset: 0x000069DC
		private void button93_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/8Ye1rgN2");
			this.module.ExecuteScript(script);
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x000076FC File Offset: 0x000058FC
		private void button92_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/nmQp3H5S");
			this.module.ExecuteScript(script);
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x0000880C File Offset: 0x00006A0C
		private void button91_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/dCmUBchn");
			this.module.ExecuteScript(script);
		}

		// Token: 0x060000DA RID: 218 RVA: 0x0000883C File Offset: 0x00006A3C
		private void button90_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/7a4xBchJ");
			this.module.ExecuteScript(script);
		}

		// Token: 0x060000DB RID: 219 RVA: 0x0000886C File Offset: 0x00006A6C
		private void button89_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/pdrEDA2c");
			this.module.ExecuteScript(script);
		}

		// Token: 0x060000DC RID: 220 RVA: 0x0000889C File Offset: 0x00006A9C
		private void button88_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/4cfEp5sZ");
			this.module.ExecuteScript(script);
		}

		// Token: 0x060000DD RID: 221 RVA: 0x000088CC File Offset: 0x00006ACC
		private void button105_Click(object sender, EventArgs e)
		{
			base.Hide();
			ScriptHub2 scriptHub = new ScriptHub2();
			scriptHub.Show();
		}

		// Token: 0x060000DE RID: 222 RVA: 0x0000208A File Offset: 0x0000028A
		private void button107_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060000DF RID: 223 RVA: 0x000088F0 File Offset: 0x00006AF0
		private void button106_Click(object sender, EventArgs e)
		{
			base.Hide();
			ScriptHub3 scriptHub = new ScriptHub3();
			scriptHub.Show();
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00008914 File Offset: 0x00006B14
		private void button113_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/9SsBfmGz");
			this.module.ExecuteScript(script);
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00008944 File Offset: 0x00006B44
		private void button114_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/6zP579q2");
			this.module.ExecuteScript(script);
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00008974 File Offset: 0x00006B74
		private void button115_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/B4sNKWXd");
			this.module.ExecuteScript(script);
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x000089A4 File Offset: 0x00006BA4
		private void button116_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/8VSzrdUQ");
			this.module.ExecuteScript(script);
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x000089D4 File Offset: 0x00006BD4
		private void button111_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://raw.githubusercontent.com/Jaaaaay2/MahScriptHub/master/AFS%20Remastered");
			this.module.ExecuteScript(script);
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00008A04 File Offset: 0x00006C04
		private void button110_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/JNFM0xpb");
			this.module.ExecuteScript(script);
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00008A34 File Offset: 0x00006C34
		private void button112_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/CbVhHYNH");
			this.module.ExecuteScript(script);
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00008A64 File Offset: 0x00006C64
		private void button109_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/t2RaC3hM");
			this.module.ExecuteScript(script);
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00008A94 File Offset: 0x00006C94
		private void button102_Click_1(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/b11tUy2s");
			this.module.ExecuteScript(script);
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00008AC4 File Offset: 0x00006CC4
		private void button108_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/PgRNeLmH");
			this.module.ExecuteScript(script);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x0000844C File Offset: 0x0000664C
		private void button71_Click_1(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://raw.githubusercontent.com/JoshieGemFinder/gubgub/main/beeswaemfree");
			this.module.ExecuteScript(script);
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00008AF4 File Offset: 0x00006CF4
		private void button61_Click_1(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/Z3iAXASr");
			this.module.ExecuteScript(script);
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00008B24 File Offset: 0x00006D24
		private void button43_Click_1(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://raw.githubusercontent.com/reavscripts/sl2_autofarm/main/main.lua");
			this.module.ExecuteScript(script);
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00008B54 File Offset: 0x00006D54
		private void button33_Click_1(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/sepn88HY");
			this.module.ExecuteScript(script);
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00008B84 File Offset: 0x00006D84
		private void button30_Click_1(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://raw.githubusercontent.com/Sinscrips/roblox-scripts/main/surfhaxx.lua");
			this.module.ExecuteScript(script);
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00002087 File Offset: 0x00000287
		private void label9_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00002087 File Offset: 0x00000287
		private void label9_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00002087 File Offset: 0x00000287
		private void label9_Click_2(object sender, EventArgs e)
		{
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00008BB4 File Offset: 0x00006DB4
		private void button87_Click_1(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string script = webClient.DownloadString("https://pastebin.com/raw/BdvUGb2q");
			this.module.ExecuteScript(script);
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00002087 File Offset: 0x00000287
		private void label30_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00007698 File Offset: 0x00005898
		private void label9_MouseMove(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				base.Left += e.X - this.lastPoint.X;
				base.Top += e.Y - this.lastPoint.Y;
			}
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00002368 File Offset: 0x00000568
		private void label9_MouseDown(object sender, MouseEventArgs e)
		{
			this.lastPoint = new Point(e.X, e.Y);
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00002368 File Offset: 0x00000568
		private void label9_MouseDown_1(object sender, MouseEventArgs e)
		{
			this.lastPoint = new Point(e.X, e.Y);
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00007698 File Offset: 0x00005898
		private void label9_MouseMove_1(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				base.Left += e.X - this.lastPoint.X;
				base.Top += e.Y - this.lastPoint.Y;
			}
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00002087 File Offset: 0x00000287
		private void ScriptHub_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x04000061 RID: 97
		private ExploitAPI api = new ExploitAPI();

		// Token: 0x04000062 RID: 98
		private Module module = new Module();

		// Token: 0x04000063 RID: 99
		private Point lastPoint;
	}
}
