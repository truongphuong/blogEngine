using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaSynacorHboDistributionProfile : KalturaConfigurableDistributionProfile
	{
		#region Private Fields
		private string _FeedUrl = null;
		private string _FeedTitle = null;
		private string _FeedSubtitle = null;
		private string _FeedLink = null;
		private string _FeedAuthorName = null;
		#endregion

		#region Properties
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
		public string FeedSubtitle
		{
			get { return _FeedSubtitle; }
			set 
			{ 
				_FeedSubtitle = value;
				OnPropertyChanged("FeedSubtitle");
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
		public string FeedAuthorName
		{
			get { return _FeedAuthorName; }
			set 
			{ 
				_FeedAuthorName = value;
				OnPropertyChanged("FeedAuthorName");
			}
		}
		#endregion

		#region CTor
		public KalturaSynacorHboDistributionProfile()
		{
		}

		public KalturaSynacorHboDistributionProfile(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "feedUrl":
						this.FeedUrl = txt;
						continue;
					case "feedTitle":
						this.FeedTitle = txt;
						continue;
					case "feedSubtitle":
						this.FeedSubtitle = txt;
						continue;
					case "feedLink":
						this.FeedLink = txt;
						continue;
					case "feedAuthorName":
						this.FeedAuthorName = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddStringIfNotNull("feedUrl", this.FeedUrl);
			kparams.AddStringIfNotNull("feedTitle", this.FeedTitle);
			kparams.AddStringIfNotNull("feedSubtitle", this.FeedSubtitle);
			kparams.AddStringIfNotNull("feedLink", this.FeedLink);
			kparams.AddStringIfNotNull("feedAuthorName", this.FeedAuthorName);
			return kparams;
		}
		#endregion
	}
}

