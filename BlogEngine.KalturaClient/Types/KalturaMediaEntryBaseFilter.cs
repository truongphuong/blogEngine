using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaMediaEntryBaseFilter : KalturaPlayableEntryFilter
	{
		#region Private Fields
		private KalturaMediaType _MediaTypeEqual = (KalturaMediaType)Int32.MinValue;
		private string _MediaTypeIn = null;
		private int _MediaDateGreaterThanOrEqual = Int32.MinValue;
		private int _MediaDateLessThanOrEqual = Int32.MinValue;
		private string _FlavorParamsIdsMatchOr = null;
		private string _FlavorParamsIdsMatchAnd = null;
		#endregion

		#region Properties
		public KalturaMediaType MediaTypeEqual
		{
			get { return _MediaTypeEqual; }
			set 
			{ 
				_MediaTypeEqual = value;
				OnPropertyChanged("MediaTypeEqual");
			}
		}
		public string MediaTypeIn
		{
			get { return _MediaTypeIn; }
			set 
			{ 
				_MediaTypeIn = value;
				OnPropertyChanged("MediaTypeIn");
			}
		}
		public int MediaDateGreaterThanOrEqual
		{
			get { return _MediaDateGreaterThanOrEqual; }
			set 
			{ 
				_MediaDateGreaterThanOrEqual = value;
				OnPropertyChanged("MediaDateGreaterThanOrEqual");
			}
		}
		public int MediaDateLessThanOrEqual
		{
			get { return _MediaDateLessThanOrEqual; }
			set 
			{ 
				_MediaDateLessThanOrEqual = value;
				OnPropertyChanged("MediaDateLessThanOrEqual");
			}
		}
		public string FlavorParamsIdsMatchOr
		{
			get { return _FlavorParamsIdsMatchOr; }
			set 
			{ 
				_FlavorParamsIdsMatchOr = value;
				OnPropertyChanged("FlavorParamsIdsMatchOr");
			}
		}
		public string FlavorParamsIdsMatchAnd
		{
			get { return _FlavorParamsIdsMatchAnd; }
			set 
			{ 
				_FlavorParamsIdsMatchAnd = value;
				OnPropertyChanged("FlavorParamsIdsMatchAnd");
			}
		}
		#endregion

		#region CTor
		public KalturaMediaEntryBaseFilter()
		{
		}

		public KalturaMediaEntryBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "mediaTypeEqual":
						this.MediaTypeEqual = (KalturaMediaType)ParseEnum(typeof(KalturaMediaType), txt);
						continue;
					case "mediaTypeIn":
						this.MediaTypeIn = txt;
						continue;
					case "mediaDateGreaterThanOrEqual":
						this.MediaDateGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "mediaDateLessThanOrEqual":
						this.MediaDateLessThanOrEqual = ParseInt(txt);
						continue;
					case "flavorParamsIdsMatchOr":
						this.FlavorParamsIdsMatchOr = txt;
						continue;
					case "flavorParamsIdsMatchAnd":
						this.FlavorParamsIdsMatchAnd = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddEnumIfNotNull("mediaTypeEqual", this.MediaTypeEqual);
			kparams.AddStringIfNotNull("mediaTypeIn", this.MediaTypeIn);
			kparams.AddIntIfNotNull("mediaDateGreaterThanOrEqual", this.MediaDateGreaterThanOrEqual);
			kparams.AddIntIfNotNull("mediaDateLessThanOrEqual", this.MediaDateLessThanOrEqual);
			kparams.AddStringIfNotNull("flavorParamsIdsMatchOr", this.FlavorParamsIdsMatchOr);
			kparams.AddStringIfNotNull("flavorParamsIdsMatchAnd", this.FlavorParamsIdsMatchAnd);
			return kparams;
		}
		#endregion
	}
}

