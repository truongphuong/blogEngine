using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaAvnDistributionProfile : KalturaConfigurableDistributionProfile
	{
		#region Private Fields
		private string _FeedUrl = null;
		private string _FeedTitle = null;
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
		#endregion

		#region CTor
		public KalturaAvnDistributionProfile()
		{
		}

		public KalturaAvnDistributionProfile(XmlElement node) : base(node)
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
			return kparams;
		}
		#endregion
	}
}

