using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaSearchResult : KalturaSearch
	{
		#region Private Fields
		private string _Id = null;
		private string _Title = null;
		private string _ThumbUrl = null;
		private string _Description = null;
		private string _Tags = null;
		private string _Url = null;
		private string _SourceLink = null;
		private string _Credit = null;
		private KalturaLicenseType _LicenseType = (KalturaLicenseType)Int32.MinValue;
		private string _FlashPlaybackType = null;
		#endregion

		#region Properties
		public string Id
		{
			get { return _Id; }
			set 
			{ 
				_Id = value;
				OnPropertyChanged("Id");
			}
		}
		public string Title
		{
			get { return _Title; }
			set 
			{ 
				_Title = value;
				OnPropertyChanged("Title");
			}
		}
		public string ThumbUrl
		{
			get { return _ThumbUrl; }
			set 
			{ 
				_ThumbUrl = value;
				OnPropertyChanged("ThumbUrl");
			}
		}
		public string Description
		{
			get { return _Description; }
			set 
			{ 
				_Description = value;
				OnPropertyChanged("Description");
			}
		}
		public string Tags
		{
			get { return _Tags; }
			set 
			{ 
				_Tags = value;
				OnPropertyChanged("Tags");
			}
		}
		public string Url
		{
			get { return _Url; }
			set 
			{ 
				_Url = value;
				OnPropertyChanged("Url");
			}
		}
		public string SourceLink
		{
			get { return _SourceLink; }
			set 
			{ 
				_SourceLink = value;
				OnPropertyChanged("SourceLink");
			}
		}
		public string Credit
		{
			get { return _Credit; }
			set 
			{ 
				_Credit = value;
				OnPropertyChanged("Credit");
			}
		}
		public KalturaLicenseType LicenseType
		{
			get { return _LicenseType; }
			set 
			{ 
				_LicenseType = value;
				OnPropertyChanged("LicenseType");
			}
		}
		public string FlashPlaybackType
		{
			get { return _FlashPlaybackType; }
			set 
			{ 
				_FlashPlaybackType = value;
				OnPropertyChanged("FlashPlaybackType");
			}
		}
		#endregion

		#region CTor
		public KalturaSearchResult()
		{
		}

		public KalturaSearchResult(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "id":
						this.Id = txt;
						continue;
					case "title":
						this.Title = txt;
						continue;
					case "thumbUrl":
						this.ThumbUrl = txt;
						continue;
					case "description":
						this.Description = txt;
						continue;
					case "tags":
						this.Tags = txt;
						continue;
					case "url":
						this.Url = txt;
						continue;
					case "sourceLink":
						this.SourceLink = txt;
						continue;
					case "credit":
						this.Credit = txt;
						continue;
					case "licenseType":
						this.LicenseType = (KalturaLicenseType)ParseEnum(typeof(KalturaLicenseType), txt);
						continue;
					case "flashPlaybackType":
						this.FlashPlaybackType = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddStringIfNotNull("id", this.Id);
			kparams.AddStringIfNotNull("title", this.Title);
			kparams.AddStringIfNotNull("thumbUrl", this.ThumbUrl);
			kparams.AddStringIfNotNull("description", this.Description);
			kparams.AddStringIfNotNull("tags", this.Tags);
			kparams.AddStringIfNotNull("url", this.Url);
			kparams.AddStringIfNotNull("sourceLink", this.SourceLink);
			kparams.AddStringIfNotNull("credit", this.Credit);
			kparams.AddEnumIfNotNull("licenseType", this.LicenseType);
			kparams.AddStringIfNotNull("flashPlaybackType", this.FlashPlaybackType);
			return kparams;
		}
		#endregion
	}
}

