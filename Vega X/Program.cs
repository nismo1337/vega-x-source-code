using System;
using System.Windows.Forms;

namespace Vega_X
{
	// Token: 0x02000010 RID: 16
	internal static class Program
	{
		// Token: 0x0600029A RID: 666 RVA: 0x000027ED File Offset: 0x000009ED
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Loader());
		}
	}
}
