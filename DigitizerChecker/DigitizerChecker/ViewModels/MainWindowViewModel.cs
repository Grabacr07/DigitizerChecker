using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Threading.Tasks;
using DigitizerChecker.Models;
using Livet;

namespace DigitizerChecker.ViewModels
{
	internal class MainWindowViewModel : ViewModel
	{
		#region Properties 変更通知プロパティ

		private IList<DigitizerViewModel> _Properties;

		public IList<DigitizerViewModel> Properties
		{
			get { return this._Properties; }
			set
			{
				if (this._Properties != value)
				{
					this._Properties = value;
					this.RaisePropertyChanged();
				}
			}
		}

		#endregion

		public MainWindowViewModel() { }

		public void Check()
		{
			var digitizer = Digitizer.GetDigitizer();

			var list = new List<DigitizerViewModel>
			{
				new DigitizerViewModel { Key = "Supported", Value = digitizer.Supported },
				new DigitizerViewModel { Key = "NID_INTEGRATED_TOUCH", Value = digitizer.Type.HasFlag(DigitizerType.IntegratedTouch) },
				new DigitizerViewModel { Key = "NID_EXTERNAL_TOUCH", Value = digitizer.Type.HasFlag(DigitizerType.IntegratedPen) },
				new DigitizerViewModel { Key = "NID_INTEGRATED_PEN", Value = digitizer.Type.HasFlag(DigitizerType.ExternalTouch) },
				new DigitizerViewModel { Key = "NID_EXTERNAL_PEN", Value = digitizer.Type.HasFlag(DigitizerType.ExternalPen) },
				new DigitizerViewModel { Key = "NID_MULTI_INPUT", Value = digitizer.Type.HasFlag(DigitizerType.MultiInput) },
				new DigitizerViewModel { Key = "NID_READY", Value = digitizer.Type.HasFlag(DigitizerType.Ready) },
				new DigitizerViewModel { Key = "SM_MAXIMUMTOUCHES", Value = digitizer.MaxTouches },
			};

			this.Properties = list;
		}
	}
}
