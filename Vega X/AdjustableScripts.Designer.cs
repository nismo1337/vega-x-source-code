namespace Vega_X
{
	// Token: 0x02000002 RID: 2
	public partial class AdjustableScripts : global::System.Windows.Forms.Form
	{
		// Token: 0x06000015 RID: 21 RVA: 0x00002A0C File Offset: 0x00000C0C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002A4C File Offset: 0x00000C4C
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Vega_X.AdjustableScripts));
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.button9 = new global::System.Windows.Forms.Button();
			this.button2 = new global::System.Windows.Forms.Button();
			this.panel2 = new global::System.Windows.Forms.Panel();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.textBox2 = new global::System.Windows.Forms.TextBox();
			this.textBox4 = new global::System.Windows.Forms.TextBox();
			this.label6 = new global::System.Windows.Forms.Label();
			this.button1 = new global::System.Windows.Forms.Button();
			this.button3 = new global::System.Windows.Forms.Button();
			this.button4 = new global::System.Windows.Forms.Button();
			this.button5 = new global::System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.panel1.BackColor = global::System.Drawing.Color.FromArgb(60, 60, 60);
			this.panel1.Controls.Add(this.button9);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(393, 44);
			this.panel1.TabIndex = 0;
			this.panel1.Paint += new global::System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			this.panel1.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
			this.panel1.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
			this.button9.BackColor = global::System.Drawing.Color.FromArgb(60, 60, 60);
			this.button9.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(60, 60, 60);
			this.button9.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button9.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button9.ForeColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.button9.Location = new global::System.Drawing.Point(360, 5);
			this.button9.Name = "button9";
			this.button9.Size = new global::System.Drawing.Size(30, 27);
			this.button9.TabIndex = 18;
			this.button9.Text = "X";
			this.button9.UseVisualStyleBackColor = false;
			this.button9.Click += new global::System.EventHandler(this.button9_Click);
			this.button2.BackColor = global::System.Drawing.Color.FromArgb(60, 60, 60);
			this.button2.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(60, 60, 60);
			this.button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button2.ForeColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.button2.Location = new global::System.Drawing.Point(327, 5);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(30, 27);
			this.button2.TabIndex = 17;
			this.button2.Text = "—";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.panel2.BackColor = global::System.Drawing.Color.Transparent;
			this.panel2.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("panel2.BackgroundImage");
			this.panel2.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Zoom;
			this.panel2.Location = new global::System.Drawing.Point(3, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new global::System.Drawing.Size(47, 37);
			this.panel2.TabIndex = 12;
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Segoe UI Semibold", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.SystemColors.Window;
			this.label1.Location = new global::System.Drawing.Point(127, 10);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(124, 21);
			this.label1.TabIndex = 4;
			this.label1.Text = "Vega X - Scripts";
			this.label1.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
			this.label1.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Segoe UI Semibold", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = global::System.Drawing.SystemColors.Control;
			this.label2.Location = new global::System.Drawing.Point(90, 53);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(218, 25);
			this.label2.TabIndex = 207;
			this.label2.Text = "Character Modifications";
			this.label2.Click += new global::System.EventHandler(this.label2_Click);
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font("Segoe UI Semibold", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.ForeColor = global::System.Drawing.SystemColors.Window;
			this.label3.Location = new global::System.Drawing.Point(12, 86);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(93, 21);
			this.label3.TabIndex = 208;
			this.label3.Text = "Walkspeed:";
			this.label4.AutoSize = true;
			this.label4.Font = new global::System.Drawing.Font("Segoe UI Semibold", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label4.ForeColor = global::System.Drawing.SystemColors.Window;
			this.label4.Location = new global::System.Drawing.Point(262, 87);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(103, 21);
			this.label4.TabIndex = 209;
			this.label4.Text = "Jump Power:";
			this.textBox1.Location = new global::System.Drawing.Point(15, 111);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 210;
			this.textBox1.TextChanged += new global::System.EventHandler(this.textBox1_TextChanged);
			this.textBox1.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
			this.textBox2.Location = new global::System.Drawing.Point(265, 111);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new global::System.Drawing.Size(100, 20);
			this.textBox2.TabIndex = 211;
			this.textBox2.TextChanged += new global::System.EventHandler(this.textBox2_TextChanged);
			this.textBox2.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
			this.textBox4.Location = new global::System.Drawing.Point(139, 111);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new global::System.Drawing.Size(100, 20);
			this.textBox4.TabIndex = 230;
			this.textBox4.TextChanged += new global::System.EventHandler(this.textBox4_TextChanged);
			this.textBox4.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
			this.label6.AutoSize = true;
			this.label6.Font = new global::System.Drawing.Font("Segoe UI Semibold", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label6.ForeColor = global::System.Drawing.SystemColors.Window;
			this.label6.Location = new global::System.Drawing.Point(136, 86);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(65, 21);
			this.label6.TabIndex = 228;
			this.label6.Text = "Gravity:";
			this.button1.BackColor = global::System.Drawing.Color.FromArgb(65, 65, 65);
			this.button1.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.ForeColor = global::System.Drawing.SystemColors.Control;
			this.button1.Location = new global::System.Drawing.Point(15, 136);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(100, 23);
			this.button1.TabIndex = 232;
			this.button1.Text = "RESET";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.button3.BackColor = global::System.Drawing.Color.FromArgb(65, 65, 65);
			this.button3.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.button3.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button3.ForeColor = global::System.Drawing.SystemColors.Control;
			this.button3.Location = new global::System.Drawing.Point(139, 136);
			this.button3.Name = "button3";
			this.button3.Size = new global::System.Drawing.Size(100, 23);
			this.button3.TabIndex = 233;
			this.button3.Text = "RESET";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new global::System.EventHandler(this.button3_Click);
			this.button4.BackColor = global::System.Drawing.Color.FromArgb(65, 65, 65);
			this.button4.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.button4.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button4.ForeColor = global::System.Drawing.SystemColors.Control;
			this.button4.Location = new global::System.Drawing.Point(265, 136);
			this.button4.Name = "button4";
			this.button4.Size = new global::System.Drawing.Size(100, 23);
			this.button4.TabIndex = 234;
			this.button4.Text = "RESET";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new global::System.EventHandler(this.button4_Click);
			this.button5.BackColor = global::System.Drawing.Color.FromArgb(65, 65, 65);
			this.button5.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.button5.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button5.ForeColor = global::System.Drawing.SystemColors.Control;
			this.button5.Location = new global::System.Drawing.Point(12, 167);
			this.button5.Name = "button5";
			this.button5.Size = new global::System.Drawing.Size(370, 40);
			this.button5.TabIndex = 235;
			this.button5.Text = "RESET ALL SETTINGS TO DEFAULT";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new global::System.EventHandler(this.button5_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(50, 50, 50);
			base.ClientSize = new global::System.Drawing.Size(394, 218);
			base.Controls.Add(this.button5);
			base.Controls.Add(this.button4);
			base.Controls.Add(this.button3);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.textBox4);
			base.Controls.Add(this.label6);
			base.Controls.Add(this.textBox2);
			base.Controls.Add(this.textBox1);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.panel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "AdjustableScripts";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AdjustableScripts";
			base.Load += new global::System.EventHandler(this.AdjustableScripts_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000003 RID: 3
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000004 RID: 4
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000005 RID: 5
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000006 RID: 6
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x04000007 RID: 7
		private global::System.Windows.Forms.Button button9;

		// Token: 0x04000008 RID: 8
		private global::System.Windows.Forms.Button button2;

		// Token: 0x04000009 RID: 9
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400000A RID: 10
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400000B RID: 11
		private global::System.Windows.Forms.Label label4;

		// Token: 0x0400000C RID: 12
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x0400000D RID: 13
		private global::System.Windows.Forms.TextBox textBox2;

		// Token: 0x0400000E RID: 14
		private global::System.Windows.Forms.TextBox textBox4;

		// Token: 0x0400000F RID: 15
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000010 RID: 16
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000011 RID: 17
		private global::System.Windows.Forms.Button button3;

		// Token: 0x04000012 RID: 18
		private global::System.Windows.Forms.Button button4;

		// Token: 0x04000013 RID: 19
		private global::System.Windows.Forms.Button button5;
	}
}
