using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaMediaInfoBaseFilter : KalturaFilter
	{
		#region Private Fields
		private string _FlavorAssetIdEqual = null;
		#endregion

		#region Properties
		public string FlavorAssetIdEqual
		{
			get { return _FlavorAssetIdEqual; }
			set 
			{ 
				_FlavorAssetIdEqual = value;
				OnPropertyChanged("FlavorAssetIdEqual");
			}
		}
		#endregion

		#region CTor
		public KalturaMediaInfoBaseFilter()
		{
		}

		public KalturaMediaInfoBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "flavorAssetIdEqual":
						this.FlavorAssetIdEqual = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddStringIfNotNull("flavorAssetIdEqual", this.FlavorAssetIdEqual);
			return kparams;
		}
		#endregion
	}
}

