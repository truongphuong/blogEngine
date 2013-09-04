using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaMediaEntry : KalturaPlayableEntry
	{
		#region Private Fields
		private KalturaMediaType _MediaType = (KalturaMediaType)Int32.MinValue;
		private string _ConversionQuality = null;
		private KalturaSourceType _SourceType = (KalturaSourceType)Int32.MinValue;
		private KalturaSearchProviderType _SearchProviderType = (KalturaSearchProviderType)Int32.MinValue;
		private string _SearchProviderId = null;
		private string _CreditUserName = null;
		private string _CreditUrl = null;
		private int _MediaDate = Int32.MinValue;
		private string _DataUrl = null;
		private string _FlavorParamsIds = null;
		#endregion

		#region Properties
		public KalturaMediaType MediaType
		{
			get { return _MediaType; }
			set 
			{ 
				_MediaType = value;
				OnPropertyChanged("MediaType");
			}
		}
		public string ConversionQuality
		{
			get { return _ConversionQuality; }
			set 
			{ 
				_ConversionQuality = value;
				OnPropertyChanged("ConversionQuality");
			}
		}
		public KalturaSourceType SourceType
		{
			get { return _SourceType; }
			set 
			{ 
				_SourceType = value;
				OnPropertyChanged("SourceType");
			}
		}
		public KalturaSearchProviderType SearchProviderType
		{
			get { return _SearchProviderType; }
			set 
			{ 
				_SearchProviderType = value;
				OnPropertyChanged("SearchProviderType");
			}
		}
		public string SearchProviderId
		{
			get { return _SearchProviderId; }
			set 
			{ 
				_SearchProviderId = value;
				OnPropertyChanged("SearchProviderId");
			}
		}
		public string CreditUserName
		{
			get { return _CreditUserName; }
			set 
			{ 
				_CreditUserName = value;
				OnPropertyChanged("CreditUserName");
			}
		}
		public string CreditUrl
		{
			get { return _CreditUrl; }
			set 
			{ 
				_CreditUrl = value;
				OnPropertyChanged("CreditUrl");
			}
		}
		public int MediaDate
		{
			get { return _MediaDate; }
			set 
			{ 
				_MediaDate = value;
				OnPropertyChanged("MediaDate");
			}
		}
		public string DataUrl
		{
			get { return _DataUrl; }
			set 
			{ 
				_DataUrl = value;
				OnPropertyChanged("DataUrl");
			}
		}
		public string FlavorParamsIds
		{
			get { return _FlavorParamsIds; }
			set 
			{ 
				_FlavorParamsIds = value;
				OnPropertyChanged("FlavorParamsIds");
			}
		}
		#endregion

		#region CTor
		public KalturaMediaEntry()
		{
		}

		public KalturaMediaEntry(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "mediaType":
						this.MediaType = (KalturaMediaType)ParseEnum(typeof(KalturaMediaType), txt);
						continue;
					case "conversionQuality":
						this.ConversionQuality = txt;
						continue;
					case "sourceType":
						this.SourceType = (KalturaSourceType)ParseEnum(typeof(KalturaSourceType), txt);
						continue;
					case "searchProviderType":
						this.SearchProviderType = (KalturaSearchProviderType)ParseEnum(typeof(KalturaSearchProviderType), txt);
						continue;
					case "searchProviderId":
						this.SearchProviderId = txt;
						continue;
					case "creditUserName":
						this.CreditUserName = txt;
						continue;
					case "creditUrl":
						this.CreditUrl = txt;
						continue;
					case "mediaDate":
						this.MediaDate = ParseInt(txt);
						continue;
					case "dataUrl":
						this.DataUrl = txt;
						continue;
					case "flavorParamsIds":
						this.FlavorParamsIds = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddEnumIfNotNull("mediaType", this.MediaType);
			kparams.AddStringIfNotNull("conversionQuality", this.ConversionQuality);
			kparams.AddEnumIfNotNull("sourceType", this.SourceType);
			kparams.AddEnumIfNotNull("searchProviderType", this.SearchProviderType);
			kparams.AddStringIfNotNull("searchProviderId", this.SearchProviderId);
			kparams.AddStringIfNotNull("creditUserName", this.CreditUserName);
			kparams.AddStringIfNotNull("creditUrl", this.CreditUrl);
			kparams.AddIntIfNotNull("mediaDate", this.MediaDate);
			kparams.AddStringIfNotNull("dataUrl", this.DataUrl);
			kparams.AddStringIfNotNull("flavorParamsIds", this.FlavorParamsIds);
			return kparams;
		}
		#endregion
	}
}

