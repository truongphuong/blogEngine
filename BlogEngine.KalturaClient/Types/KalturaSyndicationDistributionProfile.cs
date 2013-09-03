using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaSyndicationDistributionProfile : KalturaDistributionProfile
	{
		#region Private Fields
		private string _Xsl = null;
		private string _FeedId = null;
		#endregion

		#region Properties
		public string Xsl
		{
			get { return _Xsl; }
			set 
			{ 
				_Xsl = value;
				OnPropertyChanged("Xsl");
			}
		}
		public string FeedId
		{
			get { return _FeedId; }
			set 
			{ 
				_FeedId = value;
				OnPropertyChanged("FeedId");
			}
		}
		#endregion

		#region CTor
		public KalturaSyndicationDistributionProfile()
		{
		}

		public KalturaSyndicationDistributionProfile(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "xsl":
						this.Xsl = txt;
						continue;
					case "feedId":
						this.FeedId = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddStringIfNotNull("xsl", this.Xsl);
			kparams.AddStringIfNotNull("feedId", this.FeedId);
			return kparams;
		}
		#endregion
	}
}

