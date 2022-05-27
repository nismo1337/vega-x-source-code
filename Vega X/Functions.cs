using System;
using System.IO;
using System.Windows.Forms;

namespace Vega_X
{
	// Token: 0x02000004 RID: 4
	internal class Functions
	{
		// Token: 0x06000025 RID: 37 RVA: 0x00004818 File Offset: 0x00002A18
		public static void PopulateListBox(ListBox lsb, string Folder, string FileType)
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(Folder);
			FileInfo[] files = directoryInfo.GetFiles(FileType);
			foreach (FileInfo fileInfo in files)
			{
				lsb.Items.Add(fileInfo.Name);
			}
		}

		// Token: 0x04000028 RID: 40
		public static OpenFileDialog OpenFile = new OpenFileDialog
		{
			Filter = "Lua Files (*.lua)|*.lua|Text Files (*txt)|*.txt"
		};
	}
}
