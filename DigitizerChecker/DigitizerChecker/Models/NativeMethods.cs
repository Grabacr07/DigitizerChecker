using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DigitizerChecker.Models
{
	static class NativeMethods
	{
		[DllImport("user32.dll")]
		public static extern int GetSystemMetrics(int nIndex);
	}

	enum SystemMetric
	{
		SM_DIGITIZER = 94,
		SM_MAXIMUMTOUCHES = 95,
	}

	//enum DigitizerStatus
	//{
	//	TABLET_CONFIG_NONE = 0x00,
	//	NID_INTEGRATED_TOUCH = 0x01,
	//	NID_EXTERNAL_TOUCH = 0x02,
	//	NID_INTEGRATED_PEN = 0x04,
	//	NID_EXTERNAL_PEN = 0x08,
	//	NID_MULTI_INPUT = 0x40,
	//	NID_READY = 0x80,
	//}
}
