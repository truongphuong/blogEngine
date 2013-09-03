using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaAttachmentAssetBaseFilter : KalturaAssetFilter
	{
		#region Private Fields
		private KalturaAttachmentType _FormatEqual = null;
		private string _FormatIn = null;
		private KalturaAttachmentAssetStatus _StatusEqual = (KalturaAttachmentAssetStatus)Int32.MinValue;
		private string _StatusIn = null;
		private string _StatusNotIn = null;
		#endregion

		#region Properties
		public KalturaAttachmentType FormatEqual
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
		public KalturaAttachmentAssetStatus StatusEqual
		{
			get { return _StatusEqual; }
			set 
			{ 
				_StatusEqual = value;
				OnPropertyChanged("StatusEqual");
			}
		}
		public string StatusIn
		{
			get { return _StatusIn; }
			set 
			{ 
				_StatusIn = value;
				OnPropertyChanged("StatusIn");
			}
		}
		public string StatusNotIn
		{
			get { return _StatusNotIn; }
			set 
			{ 
				_StatusNotIn = value;
				OnPropertyChanged("StatusNotIn");
			}
		}
		#endregion

		#region CTor
		public KalturaAttachmentAssetBaseFilter()
		{
		}

		public KalturaAttachmentAssetBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "formatEqual":
						this.FormatEqual = (KalturaAttachmentType)KalturaStringEnum.Parse(typeof(KalturaAttachmentType), txt);
						continue;
					case "formatIn":
						this.FormatIn = txt;
						continue;
					case "statusEqual":
						this.StatusEqual = (KalturaAttachmentAssetStatus)ParseEnum(typeof(KalturaAttachmentAssetStatus), txt);
						continue;
					case "statusIn":
						this.StatusIn = txt;
						continue;
					case "statusNotIn":
						this.StatusNotIn = txt;
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
			kparams.AddEnumIfNotNull("statusEqual", this.StatusEqual);
			kparams.AddStringIfNotNull("statusIn", this.StatusIn);
			kparams.AddStringIfNotNull("statusNotIn", this.StatusNotIn);
			return kparams;
		}
		#endregion
	}
}

