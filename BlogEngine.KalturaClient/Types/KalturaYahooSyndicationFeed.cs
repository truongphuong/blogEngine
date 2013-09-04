using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaYahooSyndicationFeed : KalturaBaseSyndicationFeed
	{
		#region Private Fields
		private KalturaYahooSyndicationFeedCategories _Category = null;
		private KalturaYahooSyndicationFeedAdultValues _AdultContent = null;
		private string _FeedDescription = null;
		private string _FeedLandingPage = null;
		#endregion

		#region Properties
		public KalturaYahooSyndicationFeedCategories Category
		{
			get { return _Category; }
			set 
			{ 
				_Category = value;
				OnPropertyChanged("Category");
			}
		}
		public KalturaYahooSyndicationFeedAdultValues AdultContent
		{
			get { return _AdultContent; }
			set 
			{ 
				_AdultContent = value;
				OnPropertyChanged("AdultContent");
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
		public string FeedLandingPage
		{
			get { return _FeedLandingPage; }
			set 
			{ 
				_FeedLandingPage = value;
				OnPropertyChanged("FeedLandingPage");
			}
		}
		#endregion

		#region CTor
		public KalturaYahooSyndicationFeed()
		{
		}

		public KalturaYahooSyndicationFeed(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "category":
						this.Category = (KalturaYahooSyndicationFeedCategories)KalturaStringEnum.Parse(typeof(KalturaYahooSyndicationFeedCategories), txt);
						continue;
					case "adultContent":
						this.AdultContent = (KalturaYahooSyndicationFeedAdultValues)KalturaStringEnum.Parse(typeof(KalturaYahooSyndicationFeedAdultValues), txt);
						continue;
					case "feedDescription":
						this.FeedDescription = txt;
						continue;
					case "feedLandingPage":
						this.FeedLandingPage = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddStringEnumIfNotNull("category", this.Category);
			kparams.AddStringEnumIfNotNull("adultContent", this.AdultContent);
			kparams.AddStringIfNotNull("feedDescription", this.FeedDescription);
			kparams.AddStringIfNotNull("feedLandingPage", this.FeedLandingPage);
			return kparams;
		}
		#endregion
	}
}

