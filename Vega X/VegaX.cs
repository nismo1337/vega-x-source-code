using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using EasyExploits;
using FastColoredTextBoxNS;
using WeAreDevs_API;

namespace Vega_X
{
	// Token: 0x0200000F RID: 15
	public partial class VegaX : Form
	{
		// Token: 0x06000217 RID: 535 RVA: 0x0000253A File Offset: 0x0000073A
		public VegaX()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00026410 File Offset: 0x00024610
		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				base.Left += e.X - this.lastPoint.X;
				base.Top += e.Y - this.lastPoint.Y;
			}
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00002568 File Offset: 0x00000768
		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			this.lastPoint = new Point(e.X, e.Y);
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00002087 File Offset: 0x00000287
		private void panel2_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00026474 File Offset: 0x00024674
		private void button1_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("Do You Really Want To Close Vega X?", "Vega X | Execution", MessageBoxButtons.YesNo);
			bool flag = dialogResult == DialogResult.Yes;
			if (flag)
			{
				Application.Exit();
			}
			else
			{
				bool flag2 = dialogResult == DialogResult.No;
				if (flag2)
				{
				}
			}
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00002582 File Offset: 0x00000782
		private void panel2_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Made By 1_F0", "Credits", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00002568 File Offset: 0x00000768
		private void label1_MouseDown(object sender, MouseEventArgs e)
		{
			this.lastPoint = new Point(e.X, e.Y);
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00026410 File Offset: 0x00024610
		private void label1_MouseMove(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				base.Left += e.X - this.lastPoint.X;
				base.Top += e.Y - this.lastPoint.Y;
			}
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00002094 File Offset: 0x00000294
		private void button2_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00002087 File Offset: 0x00000287
		private void label1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000221 RID: 545 RVA: 0x000264BC File Offset: 0x000246BC
		private void button6_Click(object sender, EventArgs e)
		{
			FastColoredTextBox fastColoredTextBox = this.TabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", true).FirstOrDefault<Control>() as FastColoredTextBox;
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			bool flag = saveFileDialog.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				using (Stream stream = File.Open(saveFileDialog.FileName, FileMode.CreateNew))
				{
					using (StreamWriter streamWriter = new StreamWriter(stream))
					{
						streamWriter.Write(fastColoredTextBox.Text);
					}
				}
			}
		}

		// Token: 0x06000222 RID: 546 RVA: 0x00026574 File Offset: 0x00024774
		private void button8_Click(object sender, EventArgs e)
		{
			FastColoredTextBox fastColoredTextBox = this.TabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", true).FirstOrDefault<Control>() as FastColoredTextBox;
			fastColoredTextBox.Text = "";
		}

		// Token: 0x06000223 RID: 547 RVA: 0x000265B8 File Offset: 0x000247B8
		private void button7_Click(object sender, EventArgs e)
		{
			FastColoredTextBox fastColoredTextBox = this.TabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", true).FirstOrDefault<Control>() as FastColoredTextBox;
			OpenFileDialog openFileDialog = new OpenFileDialog();
			bool flag = openFileDialog.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				openFileDialog.Title = "Open";
				fastColoredTextBox.Text = File.ReadAllText(openFileDialog.FileName);
			}
		}

		// Token: 0x06000224 RID: 548 RVA: 0x00026624 File Offset: 0x00024824
		private void button5_Click(object sender, EventArgs e)
		{
			Options options = new Options();
			options.Show();
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00026640 File Offset: 0x00024840
		private void VegaX_Load(object sender, EventArgs e)
		{
			this.timer1.Start();
			string text = "Scriptbox " + (this.TabControl1.TabCount + 1).ToString();
			UserControl1 userControl = new UserControl1();
			userControl.Dock = DockStyle.Fill;
			TabPage tabPage = new TabPage(text);
			tabPage.Controls.Add(userControl);
			this.TabControl1.TabPages.Add(tabPage);
			base.TopMost = true;
			this.listBox1.Items.Clear();
			Functions.PopulateListBox(this.listBox1, "./Scripts", "*.txt");
			Functions.PopulateListBox(this.listBox1, "./Scripts", "*.lua");
			this.pictureBox1.AllowDrop = true;
			this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			this.EasyExploitRadioButton.Checked = true;
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00026720 File Offset: 0x00024920
		private void button9_Click(object sender, EventArgs e)
		{
			ScriptManager scriptManager = new ScriptManager();
			scriptManager.Show();
		}

		// Token: 0x06000227 RID: 551 RVA: 0x0002673C File Offset: 0x0002493C
		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			FastColoredTextBox fastColoredTextBox = this.TabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", true).FirstOrDefault<Control>() as FastColoredTextBox;
			fastColoredTextBox.Text = File.ReadAllText(string.Format("./Scripts/{0}", this.listBox1.SelectedItem));
		}

		// Token: 0x06000228 RID: 552 RVA: 0x00026794 File Offset: 0x00024994
		private void button3_Click(object sender, EventArgs e)
		{
			bool @checked = this.WrdRadioButton.Checked;
			if (@checked)
			{
				FastColoredTextBox fastColoredTextBox = this.TabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", true).FirstOrDefault<Control>() as FastColoredTextBox;
				this.api.SendLuaScript(fastColoredTextBox.Text);
			}
			else
			{
				bool checked2 = this.EasyExploitRadioButton.Checked;
				if (checked2)
				{
					FastColoredTextBox fastColoredTextBox2 = this.TabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", true).FirstOrDefault<Control>() as FastColoredTextBox;
					this.module.ExecuteScript(fastColoredTextBox2.Text);
				}
			}
		}

		// Token: 0x06000229 RID: 553 RVA: 0x0000259A File Offset: 0x0000079A
		private void button11_Click(object sender, EventArgs e)
		{
			this.api.LaunchExploit();
		}

		// Token: 0x0600022A RID: 554 RVA: 0x00025388 File Offset: 0x00023588
		private void button4_Click(object sender, EventArgs e)
		{
			ScriptHub scriptHub = new ScriptHub();
			scriptHub.Show();
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00026844 File Offset: 0x00024A44
		private void button12_Click(object sender, EventArgs e)
		{
			string text = "Scriptbox" + (this.TabControl1.TabCount + 1).ToString();
			UserControl1 userControl = new UserControl1();
			userControl.Dock = DockStyle.Fill;
			TabPage tabPage = new TabPage(text);
			tabPage.Controls.Add(userControl);
			this.TabControl1.TabPages.Add(tabPage);
		}

		// Token: 0x0600022C RID: 556 RVA: 0x000025A9 File Offset: 0x000007A9
		private void RTab_Click(object sender, EventArgs e)
		{
			this.TabControl1.TabPages.Remove(this.TabControl1.SelectedTab);
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00002087 File Offset: 0x00000287
		private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00002087 File Offset: 0x00000287
		private void loadToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00002087 File Offset: 0x00000287
		private void TabControl1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000230 RID: 560 RVA: 0x00002087 File Offset: 0x00000287
		private void panel1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00002087 File Offset: 0x00000287
		private void listBox1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00002087 File Offset: 0x00000287
		private void VegaX_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000233 RID: 563 RVA: 0x000268A8 File Offset: 0x00024AA8
		private void executeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool flag = this.listBox1.SelectedIndex != -1;
			if (flag)
			{
				this.api.SendLuaScript(File.ReadAllText("scripts\\" + this.listBox1.SelectedItem.ToString()));
				this.api.SendLuaCScript(File.ReadAllText("scripts\\" + this.listBox1.SelectedItem.ToString()));
			}
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00026928 File Offset: 0x00024B28
		private void loadToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			FastColoredTextBox fastColoredTextBox = this.TabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", true).FirstOrDefault<Control>() as FastColoredTextBox;
			bool flag = this.listBox1.SelectedIndex != -1;
			if (flag)
			{
				fastColoredTextBox.Text = File.ReadAllText("scripts\\" + this.listBox1.SelectedItem.ToString());
			}
			else
			{
				int num = (int)MessageBox.Show("Please select a script from the list before trying to loading it in tab.", "Name");
			}
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00002087 File Offset: 0x00000287
		private void timer1_Tick(object sender, EventArgs e)
		{
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00002087 File Offset: 0x00000287
		private void VegaX_FormClosing(object sender, FormClosingEventArgs e)
		{
		}

		// Token: 0x06000237 RID: 567 RVA: 0x00002087 File Offset: 0x00000287
		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000238 RID: 568 RVA: 0x00002087 File Offset: 0x00000287
		private void lightThemeToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000239 RID: 569 RVA: 0x000025C8 File Offset: 0x000007C8
		private void redThemeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form.ActiveForm.BackColor = Color.DarkRed;
		}

		// Token: 0x0600023A RID: 570 RVA: 0x000025DB File Offset: 0x000007DB
		private void orangeThemeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form.ActiveForm.BackColor = Color.Orange;
		}

		// Token: 0x0600023B RID: 571 RVA: 0x000025EE File Offset: 0x000007EE
		private void yellowThemeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form.ActiveForm.BackColor = Color.Yellow;
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00002601 File Offset: 0x00000801
		private void greenThemeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form.ActiveForm.BackColor = Color.Green;
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00002614 File Offset: 0x00000814
		private void blueThemeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form.ActiveForm.BackColor = Color.Blue;
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00002627 File Offset: 0x00000827
		private void purpleThemeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form.ActiveForm.BackColor = Color.Purple;
		}

		// Token: 0x0600023F RID: 575 RVA: 0x0000263A File Offset: 0x0000083A
		private void blackThemeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form.ActiveForm.BackColor = Color.Black;
		}

		// Token: 0x06000240 RID: 576 RVA: 0x0000264D File Offset: 0x0000084D
		private void pinkThemeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form.ActiveForm.BackColor = Color.Pink;
		}

		// Token: 0x06000241 RID: 577 RVA: 0x00002660 File Offset: 0x00000860
		private void whiteThemeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form.ActiveForm.BackColor = Color.White;
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00002673 File Offset: 0x00000873
		private void dEFAULTTHEMEToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form.ActiveForm.BackColor = this.button12.BackColor;
			this.panel1.BackColor = this.button13.BackColor;
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00002087 File Offset: 0x00000287
		private void toolStripSeparator6_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00002087 File Offset: 0x00000287
		private void cUSTOMTHEMEToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00002087 File Offset: 0x00000287
		private void pictureBox1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000246 RID: 582 RVA: 0x000026A3 File Offset: 0x000008A3
		private void pictureBox1_DragEnter(object sender, DragEventArgs e)
		{
			e.Effect = DragDropEffects.Copy;
		}

		// Token: 0x06000247 RID: 583 RVA: 0x000269B8 File Offset: 0x00024BB8
		private void pictureBox1_DragDrop(object sender, DragEventArgs e)
		{
			object data = e.Data.GetData(DataFormats.FileDrop);
			bool flag = data != null;
			if (flag)
			{
				string[] array = data as string[];
				bool flag2 = array.Length != 0;
				if (flag2)
				{
					this.pictureBox1.Image = Image.FromFile(array[0]);
				}
			}
		}

		// Token: 0x06000248 RID: 584 RVA: 0x00026A0C File Offset: 0x00024C0C
		private void rEMOVECUSTOMTHEMEToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("Do You Really Want To Remove Your Custom Theme?", "Vega X | Themes", MessageBoxButtons.YesNo);
			bool flag = dialogResult == DialogResult.Yes;
			if (flag)
			{
				this.pictureBox1.Image = null;
			}
			else
			{
				bool flag2 = dialogResult == DialogResult.No;
				if (flag2)
				{
				}
			}
		}

		// Token: 0x06000249 RID: 585 RVA: 0x000026AE File Offset: 0x000008AE
		private void lightBlueThemeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form.ActiveForm.BackColor = Color.LightBlue;
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00026A5C File Offset: 0x00024C5C
		private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
		{
			bool flag = this.checkBox1.CheckState == CheckState.Checked;
			if (flag)
			{
				Form.ActiveForm.Opacity = (double)this.trackBar1.Value / 10.0;
			}
			bool flag2 = this.checkBox1.CheckState == CheckState.Unchecked;
			if (flag2)
			{
				Form.ActiveForm.Opacity = (double)this.trackBar2.Value / 10.0;
			}
		}

		// Token: 0x0600024B RID: 587 RVA: 0x00026ADC File Offset: 0x00024CDC
		private void timer1_Tick_1(object sender, EventArgs e)
		{
			bool flag = base.Opacity < 1.0;
			if (flag)
			{
				base.Opacity += 0.15;
			}
			else
			{
				this.timer1.Stop();
			}
		}

		// Token: 0x0600024C RID: 588 RVA: 0x00002087 File Offset: 0x00000287
		private void toolStripSeparator15_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600024D RID: 589 RVA: 0x000026C1 File Offset: 0x000008C1
		private void lightBlueToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			this.panel1.BackColor = Color.CornflowerBlue;
		}

		// Token: 0x0600024E RID: 590 RVA: 0x000026D5 File Offset: 0x000008D5
		private void deepRedToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.panel1.BackColor = Color.OrangeRed;
		}

		// Token: 0x0600024F RID: 591 RVA: 0x000026E9 File Offset: 0x000008E9
		private void lightGreenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.panel1.BackColor = Color.DarkSeaGreen;
		}

		// Token: 0x06000250 RID: 592 RVA: 0x000026FD File Offset: 0x000008FD
		private void dEFAULTCOLORToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			this.panel1.BackColor = this.button13.BackColor;
		}

		// Token: 0x06000251 RID: 593 RVA: 0x00002717 File Offset: 0x00000917
		private void dimRedToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.panel1.BackColor = Color.IndianRed;
		}

		// Token: 0x06000252 RID: 594 RVA: 0x0000272B File Offset: 0x0000092B
		private void brightPurpleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.panel1.BackColor = Color.MediumPurple;
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00002087 File Offset: 0x00000287
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000254 RID: 596 RVA: 0x0000273F File Offset: 0x0000093F
		private void grayThemeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form.ActiveForm.BackColor = Color.Gray;
		}

		// Token: 0x06000255 RID: 597 RVA: 0x00002752 File Offset: 0x00000952
		private void redToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form.ActiveForm.BackColor = Color.Red;
		}

		// Token: 0x06000256 RID: 598 RVA: 0x000025DB File Offset: 0x000007DB
		private void orangeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form.ActiveForm.BackColor = Color.Orange;
		}

		// Token: 0x06000257 RID: 599 RVA: 0x000025EE File Offset: 0x000007EE
		private void yellowToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form.ActiveForm.BackColor = Color.Yellow;
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00002601 File Offset: 0x00000801
		private void greenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form.ActiveForm.BackColor = Color.Green;
		}

		// Token: 0x06000259 RID: 601 RVA: 0x00002614 File Offset: 0x00000814
		private void blueToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form.ActiveForm.BackColor = Color.Blue;
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00002627 File Offset: 0x00000827
		private void purpleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form.ActiveForm.BackColor = Color.Purple;
		}

		// Token: 0x0600025B RID: 603 RVA: 0x00002765 File Offset: 0x00000965
		private void darkGreenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form.ActiveForm.BackColor = Color.DarkGreen;
		}

		// Token: 0x0600025C RID: 604 RVA: 0x000026AE File Offset: 0x000008AE
		private void lightBlueToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			Form.ActiveForm.BackColor = Color.LightBlue;
		}

		// Token: 0x0600025D RID: 605 RVA: 0x0000263A File Offset: 0x0000083A
		private void blackToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form.ActiveForm.BackColor = Color.Black;
		}

		// Token: 0x0600025E RID: 606 RVA: 0x0000264D File Offset: 0x0000084D
		private void pinkToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form.ActiveForm.BackColor = Color.Pink;
		}

		// Token: 0x0600025F RID: 607 RVA: 0x00002778 File Offset: 0x00000978
		private void tanToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form.ActiveForm.BackColor = Color.Tan;
		}

		// Token: 0x06000260 RID: 608 RVA: 0x00002660 File Offset: 0x00000860
		private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form.ActiveForm.BackColor = Color.White;
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00002087 File Offset: 0x00000287
		private void dragAnyImageIntoTheBlankSpaceToAddACustomThemeToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000262 RID: 610 RVA: 0x0000278B File Offset: 0x0000098B
		private void cUSTOMTHEMEToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			MessageBox.Show("Drag And Drop Any Image/GIF File Next To The 'Transparent' Checkbox To Use A Custom Theme.");
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00002087 File Offset: 0x00000287
		private void tRANSPARENTTEXTBOXToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000264 RID: 612 RVA: 0x0000279A File Offset: 0x0000099A
		private void onToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.TabControl1.SendToBack();
		}

		// Token: 0x06000265 RID: 613 RVA: 0x000027A9 File Offset: 0x000009A9
		private void offToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.TabControl1.BringToFront();
		}

		// Token: 0x06000266 RID: 614 RVA: 0x00026B30 File Offset: 0x00024D30
		private void button14_Click(object sender, EventArgs e)
		{
			FastColoredTextBox fastColoredTextBox = this.TabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", true).FirstOrDefault<Control>() as FastColoredTextBox;
			OpenFileDialog openFileDialog = new OpenFileDialog();
			bool flag = openFileDialog.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				openFileDialog.Title = "Open";
				fastColoredTextBox.Text = File.ReadAllText(openFileDialog.FileName);
				this.api.SendLuaScript(fastColoredTextBox.Text);
				this.api.SendLuaCScript(fastColoredTextBox.Text);
			}
		}

		// Token: 0x06000267 RID: 615 RVA: 0x00025388 File Offset: 0x00023588
		private void button15_Click(object sender, EventArgs e)
		{
			ScriptHub scriptHub = new ScriptHub();
			scriptHub.Show();
		}

		// Token: 0x06000268 RID: 616 RVA: 0x00002087 File Offset: 0x00000287
		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00002087 File Offset: 0x00000287
		private void WrdRadioButton_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600026A RID: 618 RVA: 0x000027B8 File Offset: 0x000009B8
		private void toolStripMenuItem1_Click(object sender, EventArgs e)
		{
			this.panel1.BackColor = Color.Black;
		}

		// Token: 0x0600026B RID: 619 RVA: 0x00002087 File Offset: 0x00000287
		private void EasyExploitRadioButton_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600026C RID: 620 RVA: 0x00002087 File Offset: 0x00000287
		private void panel3_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00026574 File Offset: 0x00024774
		private void button4_Click_1(object sender, EventArgs e)
		{
			FastColoredTextBox fastColoredTextBox = this.TabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", true).FirstOrDefault<Control>() as FastColoredTextBox;
			fastColoredTextBox.Text = "";
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00002087 File Offset: 0x00000287
		private void panel4_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00026574 File Offset: 0x00024774
		private void panel4_Click(object sender, EventArgs e)
		{
			FastColoredTextBox fastColoredTextBox = this.TabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", true).FirstOrDefault<Control>() as FastColoredTextBox;
			fastColoredTextBox.Text = "";
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00026794 File Offset: 0x00024994
		private void panel3_Click(object sender, EventArgs e)
		{
			bool @checked = this.WrdRadioButton.Checked;
			if (@checked)
			{
				FastColoredTextBox fastColoredTextBox = this.TabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", true).FirstOrDefault<Control>() as FastColoredTextBox;
				this.api.SendLuaScript(fastColoredTextBox.Text);
			}
			else
			{
				bool checked2 = this.EasyExploitRadioButton.Checked;
				if (checked2)
				{
					FastColoredTextBox fastColoredTextBox2 = this.TabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", true).FirstOrDefault<Control>() as FastColoredTextBox;
					this.module.ExecuteScript(fastColoredTextBox2.Text);
				}
			}
		}

		// Token: 0x06000271 RID: 625 RVA: 0x000265B8 File Offset: 0x000247B8
		private void button8_Click_1(object sender, EventArgs e)
		{
			FastColoredTextBox fastColoredTextBox = this.TabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", true).FirstOrDefault<Control>() as FastColoredTextBox;
			OpenFileDialog openFileDialog = new OpenFileDialog();
			bool flag = openFileDialog.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				openFileDialog.Title = "Open";
				fastColoredTextBox.Text = File.ReadAllText(openFileDialog.FileName);
			}
		}

		// Token: 0x06000272 RID: 626 RVA: 0x000265B8 File Offset: 0x000247B8
		private void panel5_Click(object sender, EventArgs e)
		{
			FastColoredTextBox fastColoredTextBox = this.TabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", true).FirstOrDefault<Control>() as FastColoredTextBox;
			OpenFileDialog openFileDialog = new OpenFileDialog();
			bool flag = openFileDialog.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				openFileDialog.Title = "Open";
				fastColoredTextBox.Text = File.ReadAllText(openFileDialog.FileName);
			}
		}

		// Token: 0x06000273 RID: 627 RVA: 0x000264BC File Offset: 0x000246BC
		private void button6_Click_1(object sender, EventArgs e)
		{
			FastColoredTextBox fastColoredTextBox = this.TabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", true).FirstOrDefault<Control>() as FastColoredTextBox;
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			bool flag = saveFileDialog.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				using (Stream stream = File.Open(saveFileDialog.FileName, FileMode.CreateNew))
				{
					using (StreamWriter streamWriter = new StreamWriter(stream))
					{
						streamWriter.Write(fastColoredTextBox.Text);
					}
				}
			}
		}

		// Token: 0x06000274 RID: 628 RVA: 0x000264BC File Offset: 0x000246BC
		private void panel6_Click(object sender, EventArgs e)
		{
			FastColoredTextBox fastColoredTextBox = this.TabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", true).FirstOrDefault<Control>() as FastColoredTextBox;
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			bool flag = saveFileDialog.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				using (Stream stream = File.Open(saveFileDialog.FileName, FileMode.CreateNew))
				{
					using (StreamWriter streamWriter = new StreamWriter(stream))
					{
						streamWriter.Write(fastColoredTextBox.Text);
					}
				}
			}
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00026BC0 File Offset: 0x00024DC0
		private void button7_Click_1(object sender, EventArgs e)
		{
			FastColoredTextBox fastColoredTextBox = this.TabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", true).FirstOrDefault<Control>() as FastColoredTextBox;
			OpenFileDialog openFileDialog = new OpenFileDialog();
			bool flag = openFileDialog.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				openFileDialog.Title = "Open";
				fastColoredTextBox.Text = File.ReadAllText(openFileDialog.FileName);
				this.api.SendLuaScript(fastColoredTextBox.Text);
				this.api.SendLuaCScript(fastColoredTextBox.Text);
			}
		}

		// Token: 0x06000276 RID: 630 RVA: 0x00026B30 File Offset: 0x00024D30
		private void panel7_Click(object sender, EventArgs e)
		{
			FastColoredTextBox fastColoredTextBox = this.TabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", true).FirstOrDefault<Control>() as FastColoredTextBox;
			OpenFileDialog openFileDialog = new OpenFileDialog();
			bool flag = openFileDialog.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				openFileDialog.Title = "Open";
				fastColoredTextBox.Text = File.ReadAllText(openFileDialog.FileName);
				this.api.SendLuaScript(fastColoredTextBox.Text);
				this.api.SendLuaCScript(fastColoredTextBox.Text);
			}
		}

		// Token: 0x06000277 RID: 631 RVA: 0x00026624 File Offset: 0x00024824
		private void button14_Click_1(object sender, EventArgs e)
		{
			Options options = new Options();
			options.Show();
		}

		// Token: 0x06000278 RID: 632 RVA: 0x00026624 File Offset: 0x00024824
		private void panel8_Click(object sender, EventArgs e)
		{
			Options options = new Options();
			options.Show();
		}

		// Token: 0x06000279 RID: 633 RVA: 0x00002087 File Offset: 0x00000287
		private void panel9_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x0600027A RID: 634 RVA: 0x000027CC File Offset: 0x000009CC
		private void panel9_Click(object sender, EventArgs e)
		{
			this.contextMenuStrip1.Show(this.button16, 0, this.button16.Height);
		}

		// Token: 0x0600027B RID: 635 RVA: 0x000027CC File Offset: 0x000009CC
		private void button16_Click(object sender, EventArgs e)
		{
			this.contextMenuStrip1.Show(this.button16, 0, this.button16.Height);
		}

		// Token: 0x0600027C RID: 636 RVA: 0x00026C54 File Offset: 0x00024E54
		private void button5_Click_1(object sender, EventArgs e)
		{
			bool @checked = this.WrdRadioButton.Checked;
			if (@checked)
			{
				this.api.LaunchExploit();
			}
			else
			{
				bool checked2 = this.EasyExploitRadioButton.Checked;
				if (checked2)
				{
					this.module.LaunchExploit();
				}
			}
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00026C54 File Offset: 0x00024E54
		private void panel10_Click(object sender, EventArgs e)
		{
			bool @checked = this.WrdRadioButton.Checked;
			if (@checked)
			{
				this.api.LaunchExploit();
			}
			else
			{
				bool checked2 = this.EasyExploitRadioButton.Checked;
				if (checked2)
				{
					this.module.LaunchExploit();
				}
			}
		}

		// Token: 0x0600027E RID: 638 RVA: 0x00002087 File Offset: 0x00000287
		private void button10_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600027F RID: 639 RVA: 0x00002087 File Offset: 0x00000287
		private void panel12_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000280 RID: 640 RVA: 0x00005320 File Offset: 0x00003520
		private void button10_Click_1(object sender, EventArgs e)
		{
			SimpleUI simpleUI = new SimpleUI();
			simpleUI.Show();
		}

		// Token: 0x06000281 RID: 641 RVA: 0x00005320 File Offset: 0x00003520
		private void panel12_Click(object sender, EventArgs e)
		{
			SimpleUI simpleUI = new SimpleUI();
			simpleUI.Show();
		}

		// Token: 0x06000282 RID: 642 RVA: 0x00026720 File Offset: 0x00024920
		private void panel13_Click(object sender, EventArgs e)
		{
			ScriptManager scriptManager = new ScriptManager();
			scriptManager.Show();
		}

		// Token: 0x06000283 RID: 643 RVA: 0x00025388 File Offset: 0x00023588
		private void panel14_Click(object sender, EventArgs e)
		{
			ScriptHub scriptHub = new ScriptHub();
			scriptHub.Show();
		}

		// Token: 0x06000284 RID: 644 RVA: 0x00026CA8 File Offset: 0x00024EA8
		private void button11_Click_1(object sender, EventArgs e)
		{
			this.listBox1.Items.Clear();
			Functions.PopulateListBox(this.listBox1, "./Scripts", "*.txt");
			Functions.PopulateListBox(this.listBox1, "./Scripts", "*.lua");
		}

		// Token: 0x06000285 RID: 645 RVA: 0x00002087 File Offset: 0x00000287
		private void panel9_Leave(object sender, EventArgs e)
		{
		}

		// Token: 0x06000286 RID: 646 RVA: 0x00002087 File Offset: 0x00000287
		private void contextMenuStrip1_MouseLeave(object sender, EventArgs e)
		{
		}

		// Token: 0x06000287 RID: 647 RVA: 0x00002087 File Offset: 0x00000287
		private void panel10_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000288 RID: 648 RVA: 0x00002087 File Offset: 0x00000287
		private void panel7_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00002087 File Offset: 0x00000287
		private void panel14_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x0600028A RID: 650 RVA: 0x00026C54 File Offset: 0x00024E54
		private void rButton1_Click(object sender, EventArgs e)
		{
			bool @checked = this.WrdRadioButton.Checked;
			if (@checked)
			{
				this.api.LaunchExploit();
			}
			else
			{
				bool checked2 = this.EasyExploitRadioButton.Checked;
				if (checked2)
				{
					this.module.LaunchExploit();
				}
			}
		}

		// Token: 0x0600028B RID: 651 RVA: 0x00026794 File Offset: 0x00024994
		private void rButton2_Click(object sender, EventArgs e)
		{
			bool @checked = this.WrdRadioButton.Checked;
			if (@checked)
			{
				FastColoredTextBox fastColoredTextBox = this.TabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", true).FirstOrDefault<Control>() as FastColoredTextBox;
				this.api.SendLuaScript(fastColoredTextBox.Text);
			}
			else
			{
				bool checked2 = this.EasyExploitRadioButton.Checked;
				if (checked2)
				{
					FastColoredTextBox fastColoredTextBox2 = this.TabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", true).FirstOrDefault<Control>() as FastColoredTextBox;
					this.module.ExecuteScript(fastColoredTextBox2.Text);
				}
			}
		}

		// Token: 0x0600028C RID: 652 RVA: 0x00026574 File Offset: 0x00024774
		private void rButton3_Click(object sender, EventArgs e)
		{
			FastColoredTextBox fastColoredTextBox = this.TabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", true).FirstOrDefault<Control>() as FastColoredTextBox;
			fastColoredTextBox.Text = "";
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00026BC0 File Offset: 0x00024DC0
		private void rButton4_Click(object sender, EventArgs e)
		{
			FastColoredTextBox fastColoredTextBox = this.TabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", true).FirstOrDefault<Control>() as FastColoredTextBox;
			OpenFileDialog openFileDialog = new OpenFileDialog();
			bool flag = openFileDialog.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				openFileDialog.Title = "Open";
				fastColoredTextBox.Text = File.ReadAllText(openFileDialog.FileName);
				this.api.SendLuaScript(fastColoredTextBox.Text);
				this.api.SendLuaCScript(fastColoredTextBox.Text);
			}
		}

		// Token: 0x0600028E RID: 654 RVA: 0x000264BC File Offset: 0x000246BC
		private void rButton5_Click(object sender, EventArgs e)
		{
			FastColoredTextBox fastColoredTextBox = this.TabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", true).FirstOrDefault<Control>() as FastColoredTextBox;
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			bool flag = saveFileDialog.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				using (Stream stream = File.Open(saveFileDialog.FileName, FileMode.CreateNew))
				{
					using (StreamWriter streamWriter = new StreamWriter(stream))
					{
						streamWriter.Write(fastColoredTextBox.Text);
					}
				}
			}
		}

		// Token: 0x0600028F RID: 655 RVA: 0x000265B8 File Offset: 0x000247B8
		private void rButton6_Click(object sender, EventArgs e)
		{
			FastColoredTextBox fastColoredTextBox = this.TabControl1.SelectedTab.Controls.Find("fastColoredTextBox1", true).FirstOrDefault<Control>() as FastColoredTextBox;
			OpenFileDialog openFileDialog = new OpenFileDialog();
			bool flag = openFileDialog.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				openFileDialog.Title = "Open";
				fastColoredTextBox.Text = File.ReadAllText(openFileDialog.FileName);
			}
		}

		// Token: 0x06000290 RID: 656 RVA: 0x00026624 File Offset: 0x00024824
		private void rButton7_Click(object sender, EventArgs e)
		{
			Options options = new Options();
			options.Show();
		}

		// Token: 0x06000291 RID: 657 RVA: 0x00002087 File Offset: 0x00000287
		private void rButton8_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000292 RID: 658 RVA: 0x000027CC File Offset: 0x000009CC
		private void rButton8_Click_1(object sender, EventArgs e)
		{
			this.contextMenuStrip1.Show(this.button16, 0, this.button16.Height);
		}

		// Token: 0x06000293 RID: 659 RVA: 0x00026720 File Offset: 0x00024920
		private void rButton9_Click(object sender, EventArgs e)
		{
			ScriptManager scriptManager = new ScriptManager();
			scriptManager.Show();
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00005320 File Offset: 0x00003520
		private void rButton10_Click(object sender, EventArgs e)
		{
			SimpleUI simpleUI = new SimpleUI();
			simpleUI.Show();
		}

		// Token: 0x06000295 RID: 661 RVA: 0x00026844 File Offset: 0x00024A44
		private void rButton11_Click(object sender, EventArgs e)
		{
			string text = "Scriptbox" + (this.TabControl1.TabCount + 1).ToString();
			UserControl1 userControl = new UserControl1();
			userControl.Dock = DockStyle.Fill;
			TabPage tabPage = new TabPage(text);
			tabPage.Controls.Add(userControl);
			this.TabControl1.TabPages.Add(tabPage);
		}

		// Token: 0x06000296 RID: 662 RVA: 0x00026CA8 File Offset: 0x00024EA8
		private void rButton11_Click_1(object sender, EventArgs e)
		{
			this.listBox1.Items.Clear();
			Functions.PopulateListBox(this.listBox1, "./Scripts", "*.txt");
			Functions.PopulateListBox(this.listBox1, "./Scripts", "*.lua");
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00025388 File Offset: 0x00023588
		private void rButton8_Click_2(object sender, EventArgs e)
		{
			ScriptHub scriptHub = new ScriptHub();
			scriptHub.Show();
		}

		// Token: 0x0400023E RID: 574
		private ExploitAPI api = new ExploitAPI();

		// Token: 0x0400023F RID: 575
		private Module module = new Module();

		// Token: 0x04000240 RID: 576
		private Point lastPoint;
	}
}
