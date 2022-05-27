namespace Vega_X
{
	// Token: 0x0200000C RID: 12
	public partial class ScriptManager : global::System.Windows.Forms.Form
	{
		// Token: 0x06000200 RID: 512 RVA: 0x00023F44 File Offset: 0x00022144
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00023F84 File Offset: 0x00022184
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Vega_X.ScriptManager));
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.button107 = new global::System.Windows.Forms.Button();
			this.button2 = new global::System.Windows.Forms.Button();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.panel2 = new global::System.Windows.Forms.Panel();
			this.dataGridView1 = new global::System.Windows.Forms.DataGridView();
			this.richTextBox2 = new global::System.Windows.Forms.RichTextBox();
			this.button8 = new global::System.Windows.Forms.Button();
			this.button1 = new global::System.Windows.Forms.Button();
			this.button3 = new global::System.Windows.Forms.Button();
			this.button4 = new global::System.Windows.Forms.Button();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.richTextBox1 = new global::System.Windows.Forms.RichTextBox();
			this.button5 = new global::System.Windows.Forms.Button();
			this.button6 = new global::System.Windows.Forms.Button();
			this.label5 = new global::System.Windows.Forms.Label();
			this.label6 = new global::System.Windows.Forms.Label();
			this.button7 = new global::System.Windows.Forms.Button();
			this.button9 = new global::System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dataGridView1).BeginInit();
			base.SuspendLayout();
			this.panel1.BackColor = global::System.Drawing.Color.FromArgb(60, 60, 60);
			this.panel1.Controls.Add(this.button107);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(779, 44);
			this.panel1.TabIndex = 1;
			this.panel1.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
			this.panel1.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
			this.button107.BackColor = global::System.Drawing.Color.FromArgb(60, 60, 60);
			this.button107.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(60, 60, 60);
			this.button107.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button107.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button107.ForeColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.button107.Location = new global::System.Drawing.Point(744, 8);
			this.button107.Name = "button107";
			this.button107.Size = new global::System.Drawing.Size(30, 27);
			this.button107.TabIndex = 23;
			this.button107.Text = "X";
			this.button107.UseVisualStyleBackColor = false;
			this.button107.Click += new global::System.EventHandler(this.button107_Click);
			this.button2.BackColor = global::System.Drawing.Color.FromArgb(60, 60, 60);
			this.button2.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(60, 60, 60);
			this.button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button2.ForeColor = global::System.Drawing.SystemColors.ControlLightLight;
			this.button2.Location = new global::System.Drawing.Point(711, 8);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(30, 27);
			this.button2.TabIndex = 22;
			this.button2.Text = "—";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Segoe UI Semibold", 14.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = global::System.Drawing.Color.Ivory;
			this.label2.Location = new global::System.Drawing.Point(56, 8);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(0, 25);
			this.label2.TabIndex = 21;
			this.label2.Visible = false;
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Segoe UI Semibold", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.SystemColors.Window;
			this.label1.Location = new global::System.Drawing.Point(309, 11);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(186, 21);
			this.label1.TabIndex = 2;
			this.label1.Text = "Vega X - Script Manager";
			this.panel2.BackColor = global::System.Drawing.Color.Transparent;
			this.panel2.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("panel2.BackgroundImage");
			this.panel2.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Zoom;
			this.panel2.Location = new global::System.Drawing.Point(2, 2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new global::System.Drawing.Size(48, 39);
			this.panel2.TabIndex = 1;
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToResizeColumns = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new global::System.Drawing.Point(511, 108);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.Size = new global::System.Drawing.Size(246, 240);
			this.dataGridView1.TabIndex = 5;
			this.dataGridView1.CellContentClick += new global::System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			this.richTextBox2.BackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.richTextBox2.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.richTextBox2.Font = new global::System.Drawing.Font("Courier New", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.richTextBox2.ForeColor = global::System.Drawing.Color.ForestGreen;
			this.richTextBox2.Location = new global::System.Drawing.Point(135, 144);
			this.richTextBox2.Name = "richTextBox2";
			this.richTextBox2.Size = new global::System.Drawing.Size(350, 204);
			this.richTextBox2.TabIndex = 137;
			this.richTextBox2.Text = "-- Paste Your Script Here";
			this.richTextBox2.TextChanged += new global::System.EventHandler(this.richTextBox2_TextChanged);
			this.button8.BackColor = global::System.Drawing.Color.FromArgb(65, 65, 65);
			this.button8.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.button8.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button8.ForeColor = global::System.Drawing.SystemColors.Control;
			this.button8.Location = new global::System.Drawing.Point(135, 354);
			this.button8.Name = "button8";
			this.button8.Size = new global::System.Drawing.Size(83, 30);
			this.button8.TabIndex = 138;
			this.button8.Text = "Save";
			this.button8.UseVisualStyleBackColor = false;
			this.button8.Click += new global::System.EventHandler(this.button8_Click);
			this.button1.BackColor = global::System.Drawing.Color.FromArgb(65, 65, 65);
			this.button1.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.ForeColor = global::System.Drawing.SystemColors.Control;
			this.button1.Location = new global::System.Drawing.Point(402, 354);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(83, 30);
			this.button1.TabIndex = 139;
			this.button1.Text = "Clear";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.button3.BackColor = global::System.Drawing.Color.FromArgb(65, 65, 65);
			this.button3.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.button3.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button3.ForeColor = global::System.Drawing.SystemColors.Control;
			this.button3.Location = new global::System.Drawing.Point(313, 354);
			this.button3.Name = "button3";
			this.button3.Size = new global::System.Drawing.Size(83, 30);
			this.button3.TabIndex = 140;
			this.button3.Text = "File";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new global::System.EventHandler(this.button3_Click);
			this.button4.BackColor = global::System.Drawing.Color.FromArgb(65, 65, 65);
			this.button4.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.button4.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button4.ForeColor = global::System.Drawing.SystemColors.Control;
			this.button4.Location = new global::System.Drawing.Point(224, 354);
			this.button4.Name = "button4";
			this.button4.Size = new global::System.Drawing.Size(83, 30);
			this.button4.TabIndex = 141;
			this.button4.Text = "Execute";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new global::System.EventHandler(this.button4_Click);
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font("Segoe UI Semibold", 18f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.ForeColor = global::System.Drawing.SystemColors.Window;
			this.label3.Location = new global::System.Drawing.Point(50, 104);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(68, 32);
			this.label3.TabIndex = 24;
			this.label3.Text = "Title:";
			this.label4.AutoSize = true;
			this.label4.Font = new global::System.Drawing.Font("Segoe UI Semibold", 18f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label4.ForeColor = global::System.Drawing.SystemColors.Window;
			this.label4.Location = new global::System.Drawing.Point(35, 144);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(83, 32);
			this.label4.TabIndex = 142;
			this.label4.Text = "Script:";
			this.richTextBox1.BackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.richTextBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.richTextBox1.Font = new global::System.Drawing.Font("Courier New", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.richTextBox1.ForeColor = global::System.Drawing.Color.ForestGreen;
			this.richTextBox1.Location = new global::System.Drawing.Point(135, 108);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.ScrollBars = global::System.Windows.Forms.RichTextBoxScrollBars.None;
			this.richTextBox1.Size = new global::System.Drawing.Size(350, 28);
			this.richTextBox1.TabIndex = 143;
			this.richTextBox1.Text = "-- Script Name Here";
			this.button5.BackColor = global::System.Drawing.Color.FromArgb(65, 65, 65);
			this.button5.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.button5.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button5.ForeColor = global::System.Drawing.SystemColors.Control;
			this.button5.Location = new global::System.Drawing.Point(644, 354);
			this.button5.Name = "button5";
			this.button5.Size = new global::System.Drawing.Size(113, 30);
			this.button5.TabIndex = 144;
			this.button5.Text = "Delete Script";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new global::System.EventHandler(this.button5_Click);
			this.button6.BackColor = global::System.Drawing.Color.FromArgb(65, 65, 65);
			this.button6.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.button6.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button6.ForeColor = global::System.Drawing.SystemColors.Control;
			this.button6.Location = new global::System.Drawing.Point(511, 354);
			this.button6.Name = "button6";
			this.button6.Size = new global::System.Drawing.Size(127, 30);
			this.button6.TabIndex = 145;
			this.button6.Text = "Open Script";
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new global::System.EventHandler(this.button6_Click);
			this.label5.AutoSize = true;
			this.label5.Font = new global::System.Drawing.Font("Segoe UI Semibold", 18f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label5.ForeColor = global::System.Drawing.SystemColors.Window;
			this.label5.Location = new global::System.Drawing.Point(212, 65);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(182, 32);
			this.label5.TabIndex = 146;
			this.label5.Text = "Script Manager";
			this.label6.AutoSize = true;
			this.label6.Font = new global::System.Drawing.Font("Segoe UI Semibold", 18f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label6.ForeColor = global::System.Drawing.SystemColors.Window;
			this.label6.Location = new global::System.Drawing.Point(574, 66);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(121, 32);
			this.label6.TabIndex = 147;
			this.label6.Text = "Script List";
			this.label6.Click += new global::System.EventHandler(this.label6_Click);
			this.button7.BackColor = global::System.Drawing.Color.FromArgb(65, 65, 65);
			this.button7.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.button7.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button7.ForeColor = global::System.Drawing.SystemColors.Control;
			this.button7.Location = new global::System.Drawing.Point(22, 318);
			this.button7.Name = "button7";
			this.button7.Size = new global::System.Drawing.Size(96, 66);
			this.button7.TabIndex = 148;
			this.button7.Text = "How To Use The Script Manager";
			this.button7.UseVisualStyleBackColor = false;
			this.button7.Click += new global::System.EventHandler(this.button7_Click);
			this.button9.BackColor = global::System.Drawing.Color.FromArgb(65, 65, 65);
			this.button9.FlatAppearance.BorderColor = global::System.Drawing.Color.FromArgb(45, 45, 45);
			this.button9.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button9.ForeColor = global::System.Drawing.SystemColors.Control;
			this.button9.Location = new global::System.Drawing.Point(22, 267);
			this.button9.Name = "button9";
			this.button9.Size = new global::System.Drawing.Size(96, 45);
			this.button9.TabIndex = 149;
			this.button9.Text = "Attach";
			this.button9.UseVisualStyleBackColor = false;
			this.button9.Click += new global::System.EventHandler(this.button9_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(50, 50, 50);
			base.ClientSize = new global::System.Drawing.Size(780, 404);
			base.Controls.Add(this.button9);
			base.Controls.Add(this.button7);
			base.Controls.Add(this.label6);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.button6);
			base.Controls.Add(this.button5);
			base.Controls.Add(this.richTextBox1);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.button4);
			base.Controls.Add(this.button3);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.button8);
			base.Controls.Add(this.richTextBox2);
			base.Controls.Add(this.dataGridView1);
			base.Controls.Add(this.panel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "ScriptManager";
			this.Text = "ScriptManager";
			base.Load += new global::System.EventHandler(this.ScriptManager_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dataGridView1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000216 RID: 534
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000217 RID: 535
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000218 RID: 536
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000219 RID: 537
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400021A RID: 538
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x0400021B RID: 539
		private global::System.Windows.Forms.Button button107;

		// Token: 0x0400021C RID: 540
		private global::System.Windows.Forms.Button button2;

		// Token: 0x0400021D RID: 541
		private global::System.Windows.Forms.DataGridView dataGridView1;

		// Token: 0x0400021E RID: 542
		private global::System.Windows.Forms.RichTextBox richTextBox2;

		// Token: 0x0400021F RID: 543
		private global::System.Windows.Forms.Button button8;

		// Token: 0x04000220 RID: 544
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000221 RID: 545
		private global::System.Windows.Forms.Button button3;

		// Token: 0x04000222 RID: 546
		private global::System.Windows.Forms.Button button4;

		// Token: 0x04000223 RID: 547
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000224 RID: 548
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000225 RID: 549
		private global::System.Windows.Forms.RichTextBox richTextBox1;

		// Token: 0x04000226 RID: 550
		private global::System.Windows.Forms.Button button5;

		// Token: 0x04000227 RID: 551
		private global::System.Windows.Forms.Button button6;

		// Token: 0x04000228 RID: 552
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000229 RID: 553
		private global::System.Windows.Forms.Label label6;

		// Token: 0x0400022A RID: 554
		private global::System.Windows.Forms.Button button7;

		// Token: 0x0400022B RID: 555
		private global::System.Windows.Forms.Button button9;
	}
}
