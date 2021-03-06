using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaBaseSyndicationFeedFilter : KalturaBaseSyndicationFeedBaseFilter
	{
		#region Private Fields
		private KalturaBaseSyndicationFeedOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public new KalturaBaseSyndicationFeedOrderBy OrderBy
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
		public KalturaBaseSyndicationFeedFilter()
		{
		}

		public KalturaBaseSyndicationFeedFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "orderBy":
						this.OrderBy = (KalturaBaseSyndicationFeedOrderBy)KalturaStringEnum.Parse(typeof(KalturaBaseSyndicationFeedOrderBy), txt);
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

