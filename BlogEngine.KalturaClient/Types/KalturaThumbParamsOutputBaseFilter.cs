using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaThumbParamsOutputBaseFilter : KalturaThumbParamsFilter
	{
		#region Private Fields
		private int _ThumbParamsIdEqual = Int32.MinValue;
		private string _ThumbParamsVersionEqual = null;
		private string _ThumbAssetIdEqual = null;
		private string _ThumbAssetVersionEqual = null;
		#endregion

		#region Properties
		public int ThumbParamsIdEqual
		{
			get { return _ThumbParamsIdEqual; }
			set 
			{ 
				_ThumbParamsIdEqual = value;
				OnPropertyChanged("ThumbParamsIdEqual");
			}
		}
		public string ThumbParamsVersionEqual
		{
			get { return _ThumbParamsVersionEqual; }
			set 
			{ 
				_ThumbParamsVersionEqual = value;
				OnPropertyChanged("ThumbParamsVersionEqual");
			}
		}
		public string ThumbAssetIdEqual
		{
			get { return _ThumbAssetIdEqual; }
			set 
			{ 
				_ThumbAssetIdEqual = value;
				OnPropertyChanged("ThumbAssetIdEqual");
			}
		}
		public string ThumbAssetVersionEqual
		{
			get { return _ThumbAssetVersionEqual; }
			set 
			{ 
				_ThumbAssetVersionEqual = value;
				OnPropertyChanged("ThumbAssetVersionEqual");
			}
		}
		#endregion

		#region CTor
		public KalturaThumbParamsOutputBaseFilter()
		{
		}

		public KalturaThumbParamsOutputBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "thumbParamsIdEqual":
						this.ThumbParamsIdEqual = ParseInt(txt);
						continue;
					case "thumbParamsVersionEqual":
						this.ThumbParamsVersionEqual = txt;
						continue;
					case "thumbAssetIdEqual":
						this.ThumbAssetIdEqual = txt;
						continue;
					case "thumbAssetVersionEqual":
						this.ThumbAssetVersionEqual = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddIntIfNotNull("thumbParamsIdEqual", this.ThumbParamsIdEqual);
			kparams.AddStringIfNotNull("thumbParamsVersionEqual", this.ThumbParamsVersionEqual);
			kparams.AddStringIfNotNull("thumbAssetIdEqual", this.ThumbAssetIdEqual);
			kparams.AddStringIfNotNull("thumbAssetVersionEqual", this.ThumbAssetVersionEqual);
			return kparams;
		}
		#endregion
	}
}

