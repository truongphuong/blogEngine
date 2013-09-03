using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaPdfFlavorParamsOutput : KalturaFlavorParamsOutput
	{
		#region Private Fields
		private bool? _Readonly = false;
		#endregion

		#region Properties
		public bool? Readonly
		{
			get { return _Readonly; }
			set 
			{ 
				_Readonly = value;
				OnPropertyChanged("Readonly");
			}
		}
		#endregion

		#region CTor
		public KalturaPdfFlavorParamsOutput()
		{
		}

		public KalturaPdfFlavorParamsOutput(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "readonly":
						this.Readonly = ParseBool(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddBoolIfNotNull("readonly", this.Readonly);
			return kparams;
		}
		#endregion
	}
}

