using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaTVComDistributionProfile : KalturaConfigurableDistributionProfile
	{
		#region Private Fields
		private int _MetadataProfileId = Int32.MinValue;
		private string _FeedUrl = null;
		private string _FeedTitle = null;
		private string _FeedLink = null;
		private string _FeedDescription = null;
		private string _FeedLanguage = null;
		private string _FeedCopyright = null;
		private string _FeedImageTitle = null;
		private string _FeedImageUrl = null;
		private string _FeedImageLink = null;
		private int _FeedImageWidth = Int32.MinValue;
		private int _FeedImageHeight = Int32.MinValue;
		#endregion

		#region Properties
		public int MetadataProfileId
		{
			get { return _MetadataProfileId; }
			set 
			{ 
				_MetadataProfileId = value;
				OnPropertyChanged("MetadataProfileId");
			}
		}
		public string FeedUrl
		{
			get { return _FeedUrl; }
			set 
			{ 
				_FeedUrl = value;
				OnPropertyChanged("FeedUrl");
			}
		}
		public string FeedTitle
		{
			get { return _FeedTitle; }
			set 
			{ 
				_FeedTitle = value;
				OnPropertyChanged("FeedTitle");
			}
		}
		public string FeedLink
		{
			get { return _FeedLink; }
			set 
			{ 
				_FeedLink = value;
				OnPropertyChanged("FeedLink");
			}
		}
		public string FeedDescription
		{
			get { return _FeedDescription; }
			set 
			{ 
				_FeedDescription = value;
				OnPropertyChanged("FeedDescription");
			}
		}
		public string FeedLanguage
		{
			get { return _FeedLanguage; }
			set 
			{ 
				_FeedLanguage = value;
				OnPropertyChanged("FeedLanguage");
			}
		}
		public string FeedCopyright
		{
			get { return _FeedCopyright; }
			set 
			{ 
				_FeedCopyright = value;
				OnPropertyChanged("FeedCopyright");
			}
		}
		public string FeedImageTitle
		{
			get { return _FeedImageTitle; }
			set 
			{ 
				_FeedImageTitle = value;
				OnPropertyChanged("FeedImageTitle");
			}
		}
		public string FeedImageUrl
		{
			get { return _FeedImageUrl; }
			set 
			{ 
				_FeedImageUrl = value;
				OnPropertyChanged("FeedImageUrl");
			}
		}
		public string FeedImageLink
		{
			get { return _FeedImageLink; }
			set 
			{ 
				_FeedImageLink = value;
				OnPropertyChanged("FeedImageLink");
			}
		}
		public int FeedImageWidth
		{
			get { return _FeedImageWidth; }
			set 
			{ 
				_FeedImageWidth = value;
				OnPropertyChanged("FeedImageWidth");
			}
		}
		public int FeedImageHeight
		{
			get { return _FeedImageHeight; }
			set 
			{ 
				_FeedImageHeight = value;
				OnPropertyChanged("FeedImageHeight");
			}
		}
		#endregion

		#region CTor
		public KalturaTVComDistributionProfile()
		{
		}

		public KalturaTVComDistributionProfile(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "metadataProfileId":
						this.MetadataProfileId = ParseInt(txt);
						continue;
					case "feedUrl":
						this.FeedUrl = txt;
						continue;
					case "feedTitle":
						this.FeedTitle = txt;
						continue;
					case "feedLink":
						this.FeedLink = txt;
						continue;
					case "feedDescription":
						this.FeedDescription = txt;
						continue;
					case "feedLanguage":
						this.FeedLanguage = txt;
						continue;
					case "feedCopyright":
						this.FeedCopyright = txt;
						continue;
					case "feedImageTitle":
						this.FeedImageTitle = txt;
						continue;
					case "feedImageUrl":
						this.FeedImageUrl = txt;
						continue;
					case "feedImageLink":
						this.FeedImageLink = txt;
						continue;
					case "feedImageWidth":
						this.FeedImageWidth = ParseInt(txt);
						continue;
					case "feedImageHeight":
						this.FeedImageHeight = ParseInt(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddIntIfNotNull("metadataProfileId", this.MetadataProfileId);
			kparams.AddStringIfNotNull("feedUrl", this.FeedUrl);
			kparams.AddStringIfNotNull("feedTitle", this.FeedTitle);
			kparams.AddStringIfNotNull("feedLink", this.FeedLink);
			kparams.AddStringIfNotNull("feedDescription", this.FeedDescription);
			kparams.AddStringIfNotNull("feedLanguage", this.FeedLanguage);
			kparams.AddStringIfNotNull("feedCopyright", this.FeedCopyright);
			kparams.AddStringIfNotNull("feedImageTitle", this.FeedImageTitle);
			kparams.AddStringIfNotNull("feedImageUrl", this.FeedImageUrl);
			kparams.AddStringIfNotNull("feedImageLink", this.FeedImageLink);
			kparams.AddIntIfNotNull("feedImageWidth", this.FeedImageWidth);
			kparams.AddIntIfNotNull("feedImageHeight", this.FeedImageHeight);
			return kparams;
		}
		#endregion
	}
}

