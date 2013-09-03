using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaGenericSyndicationFeed : KalturaBaseSyndicationFeed
	{
		#region Private Fields
		private string _FeedDescription = null;
		private string _FeedLandingPage = null;
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
		public KalturaGenericSyndicationFeed()
		{
		}

		public KalturaGenericSyndicationFeed(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
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
			kparams.AddStringIfNotNull("feedDescription", this.FeedDescription);
			kparams.AddStringIfNotNull("feedLandingPage", this.FeedLandingPage);
			return kparams;
		}
		#endregion
	}
}

