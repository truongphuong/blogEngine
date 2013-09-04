using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaAssetParamsOutputBaseFilter : KalturaAssetParamsFilter
	{
		#region Private Fields
		private int _AssetParamsIdEqual = Int32.MinValue;
		private string _AssetParamsVersionEqual = null;
		private string _AssetIdEqual = null;
		private string _AssetVersionEqual = null;
		private KalturaContainerFormat _FormatEqual = null;
		#endregion

		#region Properties
		public int AssetParamsIdEqual
		{
			get { return _AssetParamsIdEqual; }
			set 
			{ 
				_AssetParamsIdEqual = value;
				OnPropertyChanged("AssetParamsIdEqual");
			}
		}
		public string AssetParamsVersionEqual
		{
			get { return _AssetParamsVersionEqual; }
			set 
			{ 
				_AssetParamsVersionEqual = value;
				OnPropertyChanged("AssetParamsVersionEqual");
			}
		}
		public string AssetIdEqual
		{
			get { return _AssetIdEqual; }
			set 
			{ 
				_AssetIdEqual = value;
				OnPropertyChanged("AssetIdEqual");
			}
		}
		public string AssetVersionEqual
		{
			get { return _AssetVersionEqual; }
			set 
			{ 
				_AssetVersionEqual = value;
				OnPropertyChanged("AssetVersionEqual");
			}
		}
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
		public KalturaAssetParamsOutputBaseFilter()
		{
		}

		public KalturaAssetParamsOutputBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "assetParamsIdEqual":
						this.AssetParamsIdEqual = ParseInt(txt);
						continue;
					case "assetParamsVersionEqual":
						this.AssetParamsVersionEqual = txt;
						continue;
					case "assetIdEqual":
						this.AssetIdEqual = txt;
						continue;
					case "assetVersionEqual":
						this.AssetVersionEqual = txt;
						continue;
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
			kparams.AddIntIfNotNull("assetParamsIdEqual", this.AssetParamsIdEqual);
			kparams.AddStringIfNotNull("assetParamsVersionEqual", this.AssetParamsVersionEqual);
			kparams.AddStringIfNotNull("assetIdEqual", this.AssetIdEqual);
			kparams.AddStringIfNotNull("assetVersionEqual", this.AssetVersionEqual);
			kparams.AddStringEnumIfNotNull("formatEqual", this.FormatEqual);
			return kparams;
		}
		#endregion
	}
}

