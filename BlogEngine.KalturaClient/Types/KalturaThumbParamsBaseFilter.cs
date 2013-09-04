using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaThumbParamsBaseFilter : KalturaAssetParamsFilter
	{
		#region Private Fields
		private KalturaContainerFormat _FormatEqual = null;
		#endregion

		#region Properties
		public KalturaContainerFormat FormatEqual
		{
			get { return _FormatEqual; }
			set 
			{ 
				_FormatEqual = value;
				OnPropertyChanged("FormatEqual");
			}
		}
		#endregion

		#region CTor
		public KalturaThumbParamsBaseFilter()
		{
		}

		public KalturaThumbParamsBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "formatEqual":
						this.FormatEqual = (KalturaContainerFormat)KalturaStringEnum.Parse(typeof(KalturaContainerFormat), txt);
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
			return kparams;
		}
		#endregion
	}
}

