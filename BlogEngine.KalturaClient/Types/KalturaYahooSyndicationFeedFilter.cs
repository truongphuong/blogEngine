using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaYahooSyndicationFeedFilter : KalturaYahooSyndicationFeedBaseFilter
	{
		#region Private Fields
		private KalturaYahooSyndicationFeedOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public new KalturaYahooSyndicationFeedOrderBy OrderBy
		{
			get { return _OrderBy; }
			set 
			{ 
				_OrderBy = value;
				OnPropertyChanged("OrderBy");
			}
		}
		#endregion

		#region CTor
		public KalturaYahooSyndicationFeedFilter()
		{
		}

		public KalturaYahooSyndicationFeedFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "orderBy":
						this.OrderBy = (KalturaYahooSyndicationFeedOrderBy)KalturaStringEnum.Parse(typeof(KalturaYahooSyndicationFeedOrderBy), txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddStringEnumIfNotNull("orderBy", this.OrderBy);
			return kparams;
		}
		#endregion
	}
}

