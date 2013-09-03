using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaDailymotionDistributionProfileFilter : KalturaDailymotionDistributionProfileBaseFilter
	{
		#region Private Fields
		private KalturaDailymotionDistributionProfileOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public new KalturaDailymotionDistributionProfileOrderBy OrderBy
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
		public KalturaDailymotionDistributionProfileFilter()
		{
		}

		public KalturaDailymotionDistributionProfileFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "orderBy":
						this.OrderBy = (KalturaDailymotionDistributionProfileOrderBy)KalturaStringEnum.Parse(typeof(KalturaDailymotionDistributionProfileOrderBy), txt);
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

