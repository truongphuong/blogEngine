using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaFlavorParamsOutputBaseFilter : KalturaFlavorParamsFilter
	{
		#region Private Fields
		private int _FlavorParamsIdEqual = Int32.MinValue;
		private string _FlavorParamsVersionEqual = null;
		private string _FlavorAssetIdEqual = null;
		private string _FlavorAssetVersionEqual = null;
		#endregion

		#region Properties
		public int FlavorParamsIdEqual
		{
			get { return _FlavorParamsIdEqual; }
			set 
			{ 
				_FlavorParamsIdEqual = value;
				OnPropertyChanged("FlavorParamsIdEqual");
			}
		}
		public string FlavorParamsVersionEqual
		{
			get { return _FlavorParamsVersionEqual; }
			set 
			{ 
				_FlavorParamsVersionEqual = value;
				OnPropertyChanged("FlavorParamsVersionEqual");
			}
		}
		public string FlavorAssetIdEqual
		{
			get { return _FlavorAssetIdEqual; }
			set 
			{ 
				_FlavorAssetIdEqual = value;
				OnPropertyChanged("FlavorAssetIdEqual");
			}
		}
		public string FlavorAssetVersionEqual
		{
			get { return _FlavorAssetVersionEqual; }
			set 
			{ 
				_FlavorAssetVersionEqual = value;
				OnPropertyChanged("FlavorAssetVersionEqual");
			}
		}
		#endregion

		#region CTor
		public KalturaFlavorParamsOutputBaseFilter()
		{
		}

		public KalturaFlavorParamsOutputBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "flavorParamsIdEqual":
						this.FlavorParamsIdEqual = ParseInt(txt);
						continue;
					case "flavorParamsVersionEqual":
						this.FlavorParamsVersionEqual = txt;
						continue;
					case "flavorAssetIdEqual":
						this.FlavorAssetIdEqual = txt;
						continue;
					case "flavorAssetVersionEqual":
						this.FlavorAssetVersionEqual = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddIntIfNotNull("flavorParamsIdEqual", this.FlavorParamsIdEqual);
			kparams.AddStringIfNotNull("flavorParamsVersionEqual", this.FlavorParamsVersionEqual);
			kparams.AddStringIfNotNull("flavorAssetIdEqual", this.FlavorAssetIdEqual);
			kparams.AddStringIfNotNull("flavorAssetVersionEqual", this.FlavorAssetVersionEqual);
			return kparams;
		}
		#endregion
	}
}

