using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaAssetParamsBaseFilter : KalturaFilter
	{
		#region Private Fields
		private string _SystemNameEqual = null;
		private string _SystemNameIn = null;
		private KalturaNullableBoolean _IsSystemDefaultEqual = (KalturaNullableBoolean)Int32.MinValue;
		private string _TagsEqual = null;
		#endregion

		#region Properties
		public string SystemNameEqual
		{
			get { return _SystemNameEqual; }
			set 
			{ 
				_SystemNameEqual = value;
				OnPropertyChanged("SystemNameEqual");
			}
		}
		public string SystemNameIn
		{
			get { return _SystemNameIn; }
			set 
			{ 
				_SystemNameIn = value;
				OnPropertyChanged("SystemNameIn");
			}
		}
		public KalturaNullableBoolean IsSystemDefaultEqual
		{
			get { return _IsSystemDefaultEqual; }
			set 
			{ 
				_IsSystemDefaultEqual = value;
				OnPropertyChanged("IsSystemDefaultEqual");
			}
		}
		public string TagsEqual
		{
			get { return _TagsEqual; }
			set 
			{ 
				_TagsEqual = value;
				OnPropertyChanged("TagsEqual");
			}
		}
		#endregion

		#region CTor
		public KalturaAssetParamsBaseFilter()
		{
		}

		public KalturaAssetParamsBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "systemNameEqual":
						this.SystemNameEqual = txt;
						continue;
					case "systemNameIn":
						this.SystemNameIn = txt;
						continue;
					case "isSystemDefaultEqual":
						this.IsSystemDefaultEqual = (KalturaNullableBoolean)ParseEnum(typeof(KalturaNullableBoolean), txt);
						continue;
					case "tagsEqual":
						this.TagsEqual = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddStringIfNotNull("systemNameEqual", this.SystemNameEqual);
			kparams.AddStringIfNotNull("systemNameIn", this.SystemNameIn);
			kparams.AddEnumIfNotNull("isSystemDefaultEqual", this.IsSystemDefaultEqual);
			kparams.AddStringIfNotNull("tagsEqual", this.TagsEqual);
			return kparams;
		}
		#endregion
	}
}

