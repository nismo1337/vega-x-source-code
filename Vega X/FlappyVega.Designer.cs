namespace Vega_X
{
	// Token: 0x02000003 RID: 3
	public partial class FlappyVega : global::System.Windows.Forms.Form
	{
		// Token: 0x06000023 RID: 35 RVA: 0x00003C58 File Offset: 0x00001E58
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00003C98 File Offset: 0x00001E98
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Vega_X.FlappyVega));
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.panel2 = new global::System.Windows.Forms.Panel();
			this.label1 = new global::System.Windows.Forms.Label();
			this.ground = new global::System.Windows.Forms.PictureBox();
			this.pipedown = new global::System.Windows.Forms.PictureBox();
			this.bird = new global::System.Windows.Forms.PictureBox();
			this.pipeup = new global::System.Windows.Forms.PictureBox();
			this.Score = new global::System.Windows.Forms.Label();
			this.gametimer = new global::System.Windows.Forms.Timer(this.components);
			this.label2 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.label6 = new global::System.Windows.Forms.Label();
			this.label7 = new global::System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.ground).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pipedown).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.bird).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pipeup).BeginInit();
			base.SuspendLayout();
			this.panel1.BackColor = global::System.Drawing.Color.FromArgb(60, 60, 60);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(800, 40);
			this.panel1.TabIndex = 1;
			this.panel1.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
			this.panel1.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
			this.panel2.BackColor = global::System.Drawing.Color.Transparent;
			this.panel2.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("panel2.BackgroundImage");
			this.panel2.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Zoom;
			this.panel2.Location = new global::System.Drawing.Point(1, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new global::System.Drawing.Size(44, 40);
			this.panel2.TabIndex = 10;
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Segoe UI Semibold", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.SystemColors.Window;
			this.label1.Location = new global::System.Drawing.Point(324, 9);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(162, 21);
			this.label1.TabIndex = 3;
			this.label1.Text = "Vega X - Flappy Vega";
			this.ground.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("ground.Image");
			this.ground.Location = new global::System.Drawing.Point(-1, 404);
			this.ground.Name = "ground";
			this.ground.Size = new global::System.Drawing.Size(800, 144);
			this.ground.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.ground.TabIndex = 2;
			this.ground.TabStop = false;
			this.pipedown.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pipedown.Image");
			this.pipedown.Location = new global::System.Drawing.Point(564, 281);
			this.pipedown.Name = "pipedown";
			this.pipedown.Size = new global::System.Drawing.Size(99, 123);
			this.pipedown.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pipedown.TabIndex = 3;
			this.pipedown.TabStop = false;
			this.bird.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("bird.Image");
			this.bird.Location = new global::System.Drawing.Point(96, 178);
			this.bird.Name = "bird";
			this.bird.Size = new global::System.Drawing.Size(49, 50);
			this.bird.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.bird.TabIndex = 4;
			this.bird.TabStop = false;
			this.pipeup.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pipeup.Image");
			this.pipeup.Location = new global::System.Drawing.Point(630, 40);
			this.pipeup.Name = "pipeup";
			this.pipeup.Size = new global::System.Drawing.Size(91, 118);
			this.pipeup.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pipeup.TabIndex = 5;
			this.pipeup.TabStop = false;
			this.Score.AutoSize = true;
			this.Score.Font = new global::System.Drawing.Font("Segoe UI Semibold", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Score.ForeColor = global::System.Drawing.SystemColors.Window;
			this.Score.Location = new global::System.Drawing.Point(12, 418);
			this.Score.Name = "Score";
			this.Score.Size = new global::System.Drawing.Size(0, 21);
			this.Score.TabIndex = 15;
			this.gametimer.Interval = 20;
			this.gametimer.Tick += new global::System.EventHandler(this.GameTimerEvent);
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Segoe UI Semibold", 18f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = global::System.Drawing.SystemColors.Window;
			this.label2.Location = new global::System.Drawing.Point(12, 55);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(208, 32);
			this.label2.TabIndex = 11;
			this.label2.Text = "Press 'E' To START";
			this.label2.Click += new global::System.EventHandler(this.label2_Click);
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font("Segoe UI Semibold", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.ForeColor = global::System.Drawing.SystemColors.Window;
			this.label3.Location = new global::System.Drawing.Point(11, 348);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(196, 21);
			this.label3.TabIndex = 16;
			this.label3.Text = "Press 'Q' For HARD Mode";
			this.label4.AutoSize = true;
			this.label4.Font = new global::System.Drawing.Font("Segoe UI Semibold", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label4.ForeColor = global::System.Drawing.SystemColors.Window;
			this.label4.Location = new global::System.Drawing.Point(11, 372);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(217, 21);
			this.label4.TabIndex = 17;
			this.label4.Text = "Press 'Z' For EXTREME Mode";
			this.label5.AutoSize = true;
			this.label5.Font = new global::System.Drawing.Font("Segoe UI Semibold", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label5.ForeColor = global::System.Drawing.SystemColors.Window;
			this.label5.Location = new global::System.Drawing.Point(11, 324);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(188, 21);
			this.label5.TabIndex = 18;
			this.label5.Text = "Press 'A' For EASY Mode";
			this.label5.Click += new global::System.EventHandler(this.label5_Click);
			this.label6.AutoSize = true;
			this.label6.Font = new global::System.Drawing.Font("Segoe UI Semibold", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label6.ForeColor = global::System.Drawing.Color.Red;
			this.label6.Location = new global::System.Drawing.Point(110, 226);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(203, 21);
			this.label6.TabIndex = 19;
			this.label6.Text = "Tip: Press 'Space' To Jump!";
			this.label7.AutoSize = true;
			this.label7.Font = new global::System.Drawing.Font("Segoe UI Semibold", 18f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label7.ForeColor = global::System.Drawing.SystemColors.Window;
			this.label7.Location = new global::System.Drawing.Point(241, 363);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(317, 32);
			this.label7.TabIndex = 20;
			this.label7.Text = "Press 'F' To Close The Game";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(50, 50, 50);
			base.ClientSize = new global::System.Drawing.Size(800, 450);
			base.Controls.Add(this.label7);
			base.Controls.Add(this.label6);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.Score);
			base.Controls.Add(this.pipeup);
			base.Controls.Add(this.bird);
			base.Controls.Add(this.pipedown);
			base.Controls.Add(this.ground);
			base.Controls.Add(this.panel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "FlappyVega";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Flappy Vega Minigame";
			base.Load += new global::System.EventHandler(this.FlappyVega_Load);
			base.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.gamekeydown);
			base.KeyUp += new global::System.Windows.Forms.KeyEventHandler(this.gamekeyup);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.ground).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pipedown).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.bird).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pipeup).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000018 RID: 24
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000019 RID: 25
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x0400001A RID: 26
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x0400001B RID: 27
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400001C RID: 28
		private global::System.Windows.Forms.PictureBox ground;

		// Token: 0x0400001D RID: 29
		private global::System.Windows.Forms.PictureBox pipedown;

		// Token: 0x0400001E RID: 30
		private global::System.Windows.Forms.PictureBox bird;

		// Token: 0x0400001F RID: 31
		private global::System.Windows.Forms.PictureBox pipeup;

		// Token: 0x04000020 RID: 32
		private global::System.Windows.Forms.Label Score;

		// Token: 0x04000021 RID: 33
		private global::System.Windows.Forms.Timer gametimer;

		// Token: 0x04000022 RID: 34
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000023 RID: 35
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000024 RID: 36
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000025 RID: 37
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000026 RID: 38
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000027 RID: 39
		private global::System.Windows.Forms.Label label7;
	}
}
