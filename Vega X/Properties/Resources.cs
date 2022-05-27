using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Vega_X.Properties
{
	// Token: 0x02000011 RID: 17
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x0600029B RID: 667 RVA: 0x00002808 File Offset: 0x00000A08
		internal Resources()
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600029C RID: 668 RVA: 0x0002A24C File Offset: 0x0002844C
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				bool flag = Resources.resourceMan == null;
				if (flag)
				{
					ResourceManager resourceManager = new ResourceManager("Vega_X.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600029D RID: 669 RVA: 0x0002A298 File Offset: 0x00028498
		// (set) Token: 0x0600029E RID: 670 RVA: 0x00002812 File Offset: 0x00000A12
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x04000295 RID: 661
		private static ResourceManager resourceMan;

		// Token: 0x04000296 RID: 662
		private static CultureInfo resourceCulture;
	}
}
