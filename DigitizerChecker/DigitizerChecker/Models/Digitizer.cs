using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitizerChecker.Models
{
	/// <summary>
	/// 入力デバイスのデジタイザー機能のサポート状況を表します。
	/// </summary>
	public class Digitizer
	{
		/// <summary>
		/// 入力デバイスがデジタイザーをサポートしているかどうかを示す値を取得します。
		/// </summary>
		public bool Supported { get; private set; }

		/// <summary>
		/// 入力デバイスが統合デバイスと外付けデバイスのどちらであるか、およびデバイスが複数入力をサポートしているかどうかを示すビット フィールドを取得します。
		/// </summary>
		public DigitizerType Type { get; private set; }

		/// <summary>
		/// 入力デバイスのタッチの最大数を取得します。
		/// </summary>
		public int MaxTouches { get; private set; }

		private Digitizer() { }

		/// <summary>
		/// 入力デバイスのデジタイザー機能を照会し、<see cref="Digitizer"/> オブジェクトを返します。
		/// </summary>
		public static Digitizer GetDigitizer()
		{
			var result = (DigitizerType)NativeMethods.GetSystemMetrics((int)SystemMetric.SM_DIGITIZER);

			var digitizer = new Digitizer
			{
				Supported = result != DigitizerType.NotSupported,
				Type = result,
			};

			if (digitizer.Supported)
			{
				var max = NativeMethods.GetSystemMetrics((int)SystemMetric.SM_MAXIMUMTOUCHES);
				digitizer.MaxTouches = max;
			}

			return digitizer;
		}
	}


}
