using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaGenericSyndicationFeedFilter : KalturaGenericSyndicationFeedBaseFilter
	{
		#region Private Fields
		private KalturaGenericSyndicationFeedOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public new KalturaGenericSyndicationFeedOrderBy OrderBy
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
		public KalturaGenericSyndicationFeedFilter()
		{
		}

		public KalturaGenericSyndicationFeedFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "orderBy":
						this.OrderBy = (KalturaGenericSyndicationFeedOrderBy)KalturaStringEnum.Parse(typeof(KalturaGenericSyndicationFeedOrderBy), txt);
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

