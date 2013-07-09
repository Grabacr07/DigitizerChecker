using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Livet;

namespace DigitizerChecker.ViewModels
{
	class DigitizerViewModel : ViewModel
	{
		#region Key 変更通知プロパティ

		private string _Key;

		public string Key
		{
			get { return this._Key; }
			set
			{
				if (this._Key != value)
				{
					this._Key = value;
					this.RaisePropertyChanged();
				}
			}
		}

		#endregion

		#region Value 変更通知プロパティ

		private object _Value;

		public object Value
		{
			get { return this._Value; }
			set
			{
				if (this._Value != value)
				{
					this._Value = value;
					this.RaisePropertyChanged();
				}
			}
		}

		#endregion
	}
}
