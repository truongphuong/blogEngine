using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaITunesSyndicationFeed : KalturaBaseSyndicationFeed
	{
		#region Private Fields
		private string _FeedDescription = null;
		private string _Language = null;
		private string _FeedLandingPage = null;
		private string _OwnerName = null;
		private string _OwnerEmail = null;
		private string _FeedImageUrl = null;
		private KalturaITunesSyndicationFeedCategories _Category = null;
		private KalturaITunesSyndicationFeedAdultValues _AdultContent = null;
		private string _FeedAuthor = null;
		#endregion

		#region Properties
		public string FeedDescription
		{
			get { return _FeedDescription; }
			set 
			{ 
				_FeedDescription = value;
				OnPropertyChanged("FeedDescription");
			}
		}
		public string Language
		{
			get { return _Language; }
			set 
			{ 
				_Language = value;
				OnPropertyChanged("Language");
			}
		}
		public string FeedLandingPage
		{
			get { return _FeedLandingPage; }
			set 
			{ 
				_FeedLandingPage = value;
				OnPropertyChanged("FeedLandingPage");
			}
		}
		public string OwnerName
		{
			get { return _OwnerName; }
			set 
			{ 
				_OwnerName = value;
				OnPropertyChanged("OwnerName");
			}
		}
		public string OwnerEmail
		{
			get { return _OwnerEmail; }
			set 
			{ 
				_OwnerEmail = value;
				OnPropertyChanged("OwnerEmail");
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
		public KalturaITunesSyndicationFeedCategories Category
		{
			get { return _Category; }
			set 
			{ 
				_Category = value;
				OnPropertyChanged("Category");
			}
		}
		public KalturaITunesSyndicationFeedAdultValues AdultContent
		{
			get { return _AdultContent; }
			set 
			{ 
				_AdultContent = value;
				OnPropertyChanged("AdultContent");
			}
		}
		public string FeedAuthor
		{
			get { return _FeedAuthor; }
			set 
			{ 
				_FeedAuthor = value;
				OnPropertyChanged("FeedAuthor");
			}
		}
		#endregion

		#region CTor
		public KalturaITunesSyndicationFeed()
		{
		}

		public KalturaITunesSyndicationFeed(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "feedDescription":
						this.FeedDescription = txt;
						continue;
					case "language":
						this.Language = txt;
						continue;
					case "feedLandingPage":
						this.FeedLandingPage = txt;
						continue;
					case "ownerName":
						this.OwnerName = txt;
						continue;
					case "ownerEmail":
						this.OwnerEmail = txt;
						continue;
					case "feedImageUrl":
						this.FeedImageUrl = txt;
						continue;
					case "category":
						this.Category = (KalturaITunesSyndicationFeedCategories)KalturaStringEnum.Parse(typeof(KalturaITunesSyndicationFeedCategories), txt);
						continue;
					case "adultContent":
						this.AdultContent = (KalturaITunesSyndicationFeedAdultValues)KalturaStringEnum.Parse(typeof(KalturaITunesSyndicationFeedAdultValues), txt);
						continue;
					case "feedAuthor":
						this.FeedAuthor = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddStringIfNotNull("feedDescription", this.FeedDescription);
			kparams.AddStringIfNotNull("language", this.Language);
			kparams.AddStringIfNotNull("feedLandingPage", this.FeedLandingPage);
			kparams.AddStringIfNotNull("ownerName", this.OwnerName);
			kparams.AddStringIfNotNull("ownerEmail", this.OwnerEmail);
			kparams.AddStringIfNotNull("feedImageUrl", this.FeedImageUrl);
			kparams.AddStringEnumIfNotNull("category", this.Category);
			kparams.AddStringEnumIfNotNull("adultContent", this.AdultContent);
			kparams.AddStringIfNotNull("feedAuthor", this.FeedAuthor);
			return kparams;
		}
		#endregion
	}
}

