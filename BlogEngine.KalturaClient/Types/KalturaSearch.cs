using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaSearch : KalturaObjectBase
	{
		#region Private Fields
		private string _KeyWords = null;
		private KalturaSearchProviderType _SearchSource = (KalturaSearchProviderType)Int32.MinValue;
		private KalturaMediaType _MediaType = (KalturaMediaType)Int32.MinValue;
		private string _ExtraData = null;
		private string _AuthData = null;
		#endregion

		#region Properties
		public string KeyWords
		{
			get { return _KeyWords; }
			set 
			{ 
				_KeyWords = value;
				OnPropertyChanged("KeyWords");
			}
		}
		public KalturaSearchProviderType SearchSource
		{
			get { return _SearchSource; }
			set 
			{ 
				_SearchSource = value;
				OnPropertyChanged("SearchSource");
			}
		}
		public KalturaMediaType MediaType
		{
			get { return _MediaType; }
			set 
			{ 
				_MediaType = value;
				OnPropertyChanged("MediaType");
			}
		}
		public string ExtraData
		{
			get { return _ExtraData; }
			set 
			{ 
				_ExtraData = value;
				OnPropertyChanged("ExtraData");
			}
		}
		public string AuthData
		{
			get { return _AuthData; }
			set 
			{ 
				_AuthData = value;
				OnPropertyChanged("AuthData");
			}
		}
		#endregion

		#region CTor
		public KalturaSearch()
		{
		}

		public KalturaSearch(XmlElement node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "keyWords":
						this.KeyWords = txt;
						continue;
					case "searchSource":
						this.SearchSource = (KalturaSearchProviderType)ParseEnum(typeof(KalturaSearchProviderType), txt);
						continue;
					case "mediaType":
						this.MediaType = (KalturaMediaType)ParseEnum(typeof(KalturaMediaType), txt);
						continue;
					case "extraData":
						this.ExtraData = txt;
						continue;
					case "authData":
						this.AuthData = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddStringIfNotNull("keyWords", this.KeyWords);
			kparams.AddEnumIfNotNull("searchSource", this.SearchSource);
			kparams.AddEnumIfNotNull("mediaType", this.MediaType);
			kparams.AddStringIfNotNull("extraData", this.ExtraData);
			kparams.AddStringIfNotNull("authData", this.AuthData);
			return kparams;
		}
		#endregion
	}
}

