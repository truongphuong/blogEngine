using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaTubeMogulSyndicationFeed : KalturaBaseSyndicationFeed
	{
		#region Private Fields
		private KalturaTubeMogulSyndicationFeedCategories _Category = null;
		#endregion

		#region Properties
		public KalturaTubeMogulSyndicationFeedCategories Category
		{
			get { return _Category; }
			set 
			{ 
				_Category = value;
				OnPropertyChanged("Category");
			}
		}
		#endregion

		#region CTor
		public KalturaTubeMogulSyndicationFeed()
		{
		}

		public KalturaTubeMogulSyndicationFeed(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "category":
						this.Category = (KalturaTubeMogulSyndicationFeedCategories)KalturaStringEnum.Parse(typeof(KalturaTubeMogulSyndicationFeedCategories), txt);
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
			return kparams;
		}
		#endregion
	}
}

