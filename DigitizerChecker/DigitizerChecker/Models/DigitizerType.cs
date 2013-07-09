using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitizerChecker.Models
{
	public enum DigitizerType
	{
		/// <summary>
		/// 入力デジタイザーにタッチ機能がありません。
		/// </summary>
		NotSupported = 0x00000000,

		/// <summary>
		/// 統合型のタッチ デジタイザーが入力に使用されています。
		/// </summary>
		IntegratedTouch = 0x00000001,

		/// <summary>
		/// 外付けのタッチ デジタイザーが入力に使用されています。
		/// </summary>
		ExternalTouch = 0x00000002,

		/// <summary>
		/// 統合型のペン デジタイザーが入力に使用されています。
		/// </summary>
		IntegratedPen = 0x00000004,

		/// <summary>
		/// 外付けのペン デジタイザーが入力に使用されています。
		/// </summary>
		ExternalPen = 0x00000008,

		/// <summary>
		/// 複数入力がサポートされた入力デジタイザーが入力に使用されています。
		/// </summary>
		MultiInput = 0x00000040,

		/// <summary>
		/// 入力デジタイザーで入力の準備ができています。この値が設定されていない場合、タブレット サービスが停止されているか、デジタイザーがサポートされていないか、デジタイザー ドライバーがインストールされていない可能性があります。
		/// </summary>
		Ready = 0x00000080,
	}
}
