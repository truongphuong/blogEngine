using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaTubeMogulSyndicationFeedFilter : KalturaTubeMogulSyndicationFeedBaseFilter
	{
		#region Private Fields
		private KalturaTubeMogulSyndicationFeedOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public new KalturaTubeMogulSyndicationFeedOrderBy OrderBy
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
		public KalturaTubeMogulSyndicationFeedFilter()
		{
		}

		public KalturaTubeMogulSyndicationFeedFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "orderBy":
						this.OrderBy = (KalturaTubeMogulSyndicationFeedOrderBy)KalturaStringEnum.Parse(typeof(KalturaTubeMogulSyndicationFeedOrderBy), txt);
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

