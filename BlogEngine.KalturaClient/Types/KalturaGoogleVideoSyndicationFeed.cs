using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaGoogleVideoSyndicationFeed : KalturaBaseSyndicationFeed
	{
		#region Private Fields
		private KalturaGoogleSyndicationFeedAdultValues _AdultContent = null;
		#endregion

		#region Properties
		public KalturaGoogleSyndicationFeedAdultValues AdultContent
		{
			get { return _AdultContent; }
			set 
			{ 
				_AdultContent = value;
				OnPropertyChanged("AdultContent");
			}
		}
		#endregion

		#region CTor
		public KalturaGoogleVideoSyndicationFeed()
		{
		}

		public KalturaGoogleVideoSyndicationFeed(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "adultContent":
						this.AdultContent = (KalturaGoogleSyndicationFeedAdultValues)KalturaStringEnum.Parse(typeof(KalturaGoogleSyndicationFeedAdultValues), txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddStringEnumIfNotNull("adultContent", this.AdultContent);
			return kparams;
		}
		#endregion
	}
}

