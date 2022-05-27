using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Vega_X
{
	// Token: 0x02000008 RID: 8
	public class RButton : Button
	{
		// Token: 0x06000063 RID: 99 RVA: 0x0000731C File Offset: 0x0000551C
		public RButton()
		{
			base.FlatStyle = FlatStyle.Flat;
			base.FlatAppearance.BorderSize = 0;
			base.Size = new Size(150, 40);
			this.BackColor = Color.LightGray;
			this.ForeColor = Color.White;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x0000738C File Offset: 0x0000558C
		private GraphicsPath GetFigurePath(Rectangle rect, float radius)
		{
			GraphicsPath graphicsPath = new GraphicsPath();
			float num = radius * 2f;
			graphicsPath.StartFigure();
			graphicsPath.AddArc((float)rect.X, (float)rect.Y, num, num, 180f, 90f);
			graphicsPath.AddArc((float)rect.Right - num, (float)rect.Y, num, num, 270f, 90f);
			graphicsPath.AddArc((float)rect.Right - num, (float)rect.Bottom - num, num, num, 0f, 90f);
			graphicsPath.AddArc((float)rect.X, (float)rect.Bottom - num, num, num, 90f, 90f);
			graphicsPath.CloseFigure();
			return graphicsPath;
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00007454 File Offset: 0x00005654
		protected override void OnPaint(PaintEventArgs pevent)
		{
			base.OnPaint(pevent);
			Rectangle clientRectangle = base.ClientRectangle;
			Rectangle rect = Rectangle.Inflate(clientRectangle, -this.borderSize, -this.borderSize);
			int num = 2;
			bool flag = this.borderSize > 0;
			if (flag)
			{
				num = this.borderSize;
			}
			bool flag2 = this.borderRadius > 2;
			if (flag2)
			{
				using (GraphicsPath figurePath = this.GetFigurePath(clientRectangle, (float)this.borderRadius))
				{
					using (GraphicsPath figurePath2 = this.GetFigurePath(rect, (float)(this.borderRadius - this.borderSize)))
					{
						using (Pen pen = new Pen(base.Parent.BackColor, (float)num))
						{
							using (Pen pen2 = new Pen(this.borderColor, (float)this.borderSize))
							{
								pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
								base.Region = new Region(figurePath);
								pevent.Graphics.DrawPath(pen, figurePath);
								bool flag3 = this.borderSize >= 1;
								if (flag3)
								{
									pevent.Graphics.DrawPath(pen2, figurePath2);
								}
							}
						}
					}
				}
			}
			else
			{
				pevent.Graphics.SmoothingMode = SmoothingMode.None;
				base.Region = new Region(clientRectangle);
				bool flag4 = this.borderSize >= 1;
				if (flag4)
				{
					using (Pen pen3 = new Pen(this.borderColor, (float)this.borderSize))
					{
						pen3.Alignment = PenAlignment.Inset;
						pevent.Graphics.DrawRectangle(pen3, 0, 0, base.Width - 1, base.Height - 1);
					}
				}
			}
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00002317 File Offset: 0x00000517
		protected override void OnHandleCreated(EventArgs e)
		{
			base.OnHandleCreated(e);
			base.Parent.BackColorChanged += this.Container_BackColorChanged;
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00007674 File Offset: 0x00005874
		private void Container_BackColorChanged(object sender, EventArgs e)
		{
			bool designMode = base.DesignMode;
			if (designMode)
			{
				base.Invalidate();
			}
		}

		// Token: 0x0400005E RID: 94
		private int borderSize = 0;

		// Token: 0x0400005F RID: 95
		private int borderRadius = 20;

		// Token: 0x04000060 RID: 96
		private Color borderColor = Color.DarkGray;
	}
}
