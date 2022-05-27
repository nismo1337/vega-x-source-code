using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using EasyExploits;
using WeAreDevs_API;

namespace Vega_X
{
	// Token: 0x0200000C RID: 12
	public partial class ScriptManager : Form
	{
		// Token: 0x060001EF RID: 495 RVA: 0x00002407 File Offset: 0x00000607
		public ScriptManager()
		{
			this.InitializeComponent();
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00023CA8 File Offset: 0x00021EA8
		private void ScriptManager_Load(object sender, EventArgs e)
		{
			base.TopMost = true;
			this.table = new DataTable();
			this.table.Columns.Add("Title", typeof(string));
			this.table.Columns.Add("Scripts", typeof(string));
			this.dataGridView1.DataSource = this.table;
			this.dataGridView1.Columns["Scripts"].Visible = false;
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00002087 File Offset: 0x00000287
		private void label6_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00023D3C File Offset: 0x00021F3C
		private void button8_Click(object sender, EventArgs e)
		{
			this.table.Rows.Add(new object[]
			{
				this.richTextBox1.Text,
				this.richTextBox2.Text
			});
			this.richTextBox1.Clear();
			this.richTextBox2.Clear();
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00002435 File Offset: 0x00000635
		private void button7_Click(object sender, EventArgs e)
		{
			MessageBox.Show("To use the script manager, first add a *SCRIPT TITLE* and a *SCRIPT*. Then press *SAVE*. Your script will save to the *SCRIPT LIST*. To retrieve a script, select it from the *SCRIPT LIST* and press the *OPEN SCRIPT* button. Then you can execute it with the *EXECUTE SCRIPT* button. Enjoy! ");
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00002444 File Offset: 0x00000644
		private void button4_Click(object sender, EventArgs e)
		{
			this.module.ExecuteScript(this.richTextBox2.Text);
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00023D98 File Offset: 0x00021F98
		private void button3_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			bool flag = saveFileDialog.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				using (Stream stream = File.Open(saveFileDialog.FileName, FileMode.CreateNew))
				{
					using (StreamWriter streamWriter = new StreamWriter(stream))
					{
						streamWriter.Write(this.richTextBox2.Text);
					}
				}
			}
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00002087 File Offset: 0x00000287
		private void richTextBox2_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x0000245E File Offset: 0x0000065E
		private void button1_Click(object sender, EventArgs e)
		{
			this.richTextBox1.Clear();
			this.richTextBox2.Clear();
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00023E28 File Offset: 0x00022028
		private void button6_Click(object sender, EventArgs e)
		{
			int rowIndex = this.dataGridView1.CurrentCell.RowIndex;
			bool flag = rowIndex > -1;
			if (flag)
			{
				this.richTextBox1.Text = this.table.Rows[rowIndex].ItemArray[0].ToString();
				this.richTextBox2.Text = this.table.Rows[rowIndex].ItemArray[1].ToString();
			}
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00023EA8 File Offset: 0x000220A8
		private void button5_Click(object sender, EventArgs e)
		{
			int rowIndex = this.dataGridView1.CurrentCell.RowIndex;
			this.table.Rows[rowIndex].Delete();
		}

		// Token: 0x060001FA RID: 506 RVA: 0x0000208A File Offset: 0x0000028A
		private void button107_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00002094 File Offset: 0x00000294
		private void button2_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00023EE0 File Offset: 0x000220E0
		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				base.Left += e.X - this.lastPoint.X;
				base.Top += e.Y - this.lastPoint.Y;
			}
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00002479 File Offset: 0x00000679
		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			this.lastPoint = new Point(e.X, e.Y);
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00002493 File Offset: 0x00000693
		private void button9_Click(object sender, EventArgs e)
		{
			this.module.LaunchExploit();
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00002087 File Offset: 0x00000287
		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x04000212 RID: 530
		private Module module = new Module();

		// Token: 0x04000213 RID: 531
		private ExploitAPI api = new ExploitAPI();

		// Token: 0x04000214 RID: 532
		private DataTable table;

		// Token: 0x04000215 RID: 533
		private Point lastPoint;
	}
}
