using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaCaptionParamsBaseFilter : KalturaAssetParamsFilter
	{
		#region Private Fields
		private KalturaCaptionType _FormatEqual = null;
		private string _FormatIn = null;
		#endregion

		#region Properties
		public KalturaCaptionType FormatEqual
		{
			get { return _FormatEqual; }
			set 
			{ 
				_FormatEqual = value;
				OnPropertyChanged("FormatEqual");
			}
		}
		public string FormatIn
		{
			get { return _FormatIn; }
			set 
			{ 
				_FormatIn = value;
				OnPropertyChanged("FormatIn");
			}
		}
		#endregion

		#region CTor
		public KalturaCaptionParamsBaseFilter()
		{
		}

		public KalturaCaptionParamsBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "formatEqual":
						this.FormatEqual = (KalturaCaptionType)KalturaStringEnum.Parse(typeof(KalturaCaptionType), txt);
						continue;
					case "formatIn":
						this.FormatIn = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddStringEnumIfNotNull("formatEqual", this.FormatEqual);
			kparams.AddStringIfNotNull("formatIn", this.FormatIn);
			return kparams;
		}
		#endregion
	}
}

