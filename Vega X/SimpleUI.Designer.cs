namespace Vega_X
{
	// Token: 0x0200000D RID: 13
	public partial class SimpleUI : global::System.Windows.Forms.Form
	{
		// Token: 0x06000211 RID: 529 RVA: 0x000253A4 File Offset: 0x000235A4
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000212 RID: 530 RVA: 0x000253E4 File Offset: 0x000235E4
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Vega_X.SimpleUI));
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.button1 = new global::System.Windows.Forms.Button();
			this.button10 = new global::System.Windows.Forms.Button();
			this.panel2 = new global::System.Windows.Forms.Panel();
			this.label1 = new global::System.Windows.Forms.Label();
			this.fastColoredTextBox1 = new global::FastColoredTextBoxNS.FastColoredTextBox();
			this.button3 = new global::System.Windows.Forms.Button();
			this.button2 = new global::System.Windows.Forms.Button();
			this.button4 = new global::System.Windows.Forms.Button();
			this.button5 = new global::System.Windows.Forms.Button();
			this.button6 = new global::System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.fastColoredTextBox1).BeginInit();
			base.SuspendLayout();
			this.panel1.BackColor = global::System.Drawing.Color.FromArgb(60, 60, 60);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.button10);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new global::System.Drawing.Point(0, -1);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(543, 41);
			this.panel1.TabIndex = 0;
			this.panel1.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
			this.panel1.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
			this.button1.BackColor = global::System.Drawing.Color.FromArgb(60, 60, 60);
			this.button1.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(60, 60, 60);
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button1.ForeColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.button1.Location = new global::System.Drawing.Point(509, 5);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(30, 27);
			this.button1.TabIndex = 15;
			this.button1.Text = "X";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.button10.BackColor = global::System.Drawing.Color.FromArgb(60, 60, 60);
			this.button10.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(60, 60, 60);
			this.button10.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button10.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button10.ForeColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.button10.Location = new global::System.Drawing.Point(475, 5);
			this.button10.Name = "button10";
			this.button10.Size = new global::System.Drawing.Size(28, 27);
			this.button10.TabIndex = 14;
			this.button10.Text = "—";
			this.button10.UseVisualStyleBackColor = false;
			this.button10.Click += new global::System.EventHandler(this.button10_Click);
			this.panel2.BackColor = global::System.Drawing.Color.Transparent;
			this.panel2.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("panel2.BackgroundImage");
			this.panel2.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Zoom;
			this.panel2.Location = new global::System.Drawing.Point(0, 1);
			this.panel2.Name = "panel2";
			this.panel2.Size = new global::System.Drawing.Size(44, 40);
			this.panel2.TabIndex = 11;
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Segoe UI Semibold", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.SystemColors.Window;
			this.label1.Location = new global::System.Drawing.Point(203, 9);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(144, 21);
			this.label1.TabIndex = 4;
			this.label1.Text = "Vega X - Simple UI";
			this.label1.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
			this.label1.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
			this.label1.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.label1_MouseUp);
			this.fastColoredTextBox1.AutoCompleteBracketsList = new char[]
			{
				'(',
				')',
				'{',
				'}',
				'[',
				']',
				'"',
				'"',
				'\'',
				'\''
			};
			this.fastColoredTextBox1.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>.+)\r\n";
			this.fastColoredTextBox1.AutoScrollMinSize = new global::System.Drawing.Size(195, 70);
			this.fastColoredTextBox1.BackBrush = null;
			this.fastColoredTextBox1.BackColor = global::System.Drawing.Color.FromArgb(50, 50, 50);
			this.fastColoredTextBox1.BracketsHighlightStrategy = global::FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
			this.fastColoredTextBox1.CharHeight = 14;
			this.fastColoredTextBox1.CharWidth = 8;
			this.fastColoredTextBox1.CommentPrefix = "--";
			this.fastColoredTextBox1.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.fastColoredTextBox1.DisabledColor = global::System.Drawing.Color.FromArgb(100, 180, 180, 180);
			this.fastColoredTextBox1.Font = new global::System.Drawing.Font("Courier New", 9.75f);
			this.fastColoredTextBox1.ForeColor = global::System.Drawing.Color.White;
			this.fastColoredTextBox1.IndentBackColor = global::System.Drawing.Color.FromArgb(40, 40, 40);
			this.fastColoredTextBox1.IsReplaceMode = false;
			this.fastColoredTextBox1.Language = global::FastColoredTextBoxNS.Language.Lua;
			this.fastColoredTextBox1.LeftBracket = '(';
			this.fastColoredTextBox1.LeftBracket2 = '{';
			this.fastColoredTextBox1.Location = new global::System.Drawing.Point(6, 46);
			this.fastColoredTextBox1.Name = "fastColoredTextBox1";
			this.fastColoredTextBox1.Paddings = new global::System.Windows.Forms.Padding(0);
			this.fastColoredTextBox1.RightBracket = ')';
			this.fastColoredTextBox1.RightBracket2 = '}';
			this.fastColoredTextBox1.SelectionColor = global::System.Drawing.Color.FromArgb(60, 0, 0, 255);
			this.fastColoredTextBox1.ServiceColors = (global::FastColoredTextBoxNS.ServiceColors)componentResourceManager.GetObject("fastColoredTextBox1.ServiceColors");
			this.fastColoredTextBox1.Size = new global::System.Drawing.Size(525, 154);
			this.fastColoredTextBox1.TabIndex = 25;
			this.fastColoredTextBox1.Text = "-- Vega X - Simple UI\r\n\r\n-- Full-LUA Execution\r\n\r\n-- Made By 1_F0";
			this.fastColoredTextBox1.Zoom = 100;
			this.fastColoredTextBox1.Load += new global::System.EventHandler(this.fastColoredTextBox1_Load);
			this.button3.BackColor = global::System.Drawing.Color.FromArgb(65, 65, 65);
			this.button3.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.button3.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button3.ForeColor = global::System.Drawing.SystemColors.Control;
			this.button3.Location = new global::System.Drawing.Point(12, 206);
			this.button3.Name = "button3";
			this.button3.Size = new global::System.Drawing.Size(89, 30);
			this.button3.TabIndex = 26;
			this.button3.Text = "Execute";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new global::System.EventHandler(this.button3_Click);
			this.button2.BackColor = global::System.Drawing.Color.FromArgb(65, 65, 65);
			this.button2.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button2.ForeColor = global::System.Drawing.SystemColors.Control;
			this.button2.Location = new global::System.Drawing.Point(202, 206);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(89, 30);
			this.button2.TabIndex = 27;
			this.button2.Text = "Open File";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.button4.BackColor = global::System.Drawing.Color.FromArgb(65, 65, 65);
			this.button4.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.button4.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button4.ForeColor = global::System.Drawing.SystemColors.Control;
			this.button4.Location = new global::System.Drawing.Point(107, 206);
			this.button4.Name = "button4";
			this.button4.Size = new global::System.Drawing.Size(89, 30);
			this.button4.TabIndex = 28;
			this.button4.Text = "Clear";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new global::System.EventHandler(this.button4_Click);
			this.button5.BackColor = global::System.Drawing.Color.FromArgb(65, 65, 65);
			this.button5.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.button5.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button5.ForeColor = global::System.Drawing.SystemColors.Control;
			this.button5.Location = new global::System.Drawing.Point(442, 206);
			this.button5.Name = "button5";
			this.button5.Size = new global::System.Drawing.Size(89, 30);
			this.button5.TabIndex = 29;
			this.button5.Text = "Attach";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new global::System.EventHandler(this.button5_Click);
			this.button6.BackColor = global::System.Drawing.Color.FromArgb(65, 65, 65);
			this.button6.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.button6.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button6.ForeColor = global::System.Drawing.SystemColors.Control;
			this.button6.Location = new global::System.Drawing.Point(297, 206);
			this.button6.Name = "button6";
			this.button6.Size = new global::System.Drawing.Size(89, 30);
			this.button6.TabIndex = 30;
			this.button6.Text = "Script Hub";
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new global::System.EventHandler(this.button6_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			base.ClientSize = new global::System.Drawing.Size(543, 245);
			base.Controls.Add(this.button6);
			base.Controls.Add(this.button5);
			base.Controls.Add(this.button4);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.button3);
			base.Controls.Add(this.fastColoredTextBox1);
			base.Controls.Add(this.panel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "SimpleUI";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SimpleUI";
			base.Load += new global::System.EventHandler(this.SimpleUI_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.fastColoredTextBox1).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400022F RID: 559
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000230 RID: 560
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000231 RID: 561
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000232 RID: 562
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x04000233 RID: 563
		private global::System.Windows.Forms.Button button10;

		// Token: 0x04000234 RID: 564
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000235 RID: 565
		private global::FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox1;

		// Token: 0x04000236 RID: 566
		private global::System.Windows.Forms.Button button3;

		// Token: 0x04000237 RID: 567
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04000238 RID: 568
		private global::System.Windows.Forms.Button button4;

		// Token: 0x04000239 RID: 569
		private global::System.Windows.Forms.Button button5;

		// Token: 0x0400023A RID: 570
		private global::System.Windows.Forms.Button button6;
	}
}
