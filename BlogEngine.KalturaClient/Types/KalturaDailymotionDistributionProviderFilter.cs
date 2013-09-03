using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaDailymotionDistributionProviderFilter : KalturaDailymotionDistributionProviderBaseFilter
	{
		#region Private Fields
		private KalturaDailymotionDistributionProviderOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public new KalturaDailymotionDistributionProviderOrderBy OrderBy
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
		public KalturaDailymotionDistributionProviderFilter()
		{
		}

		public KalturaDailymotionDistributionProviderFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "orderBy":
						this.OrderBy = (KalturaDailymotionDistributionProviderOrderBy)KalturaStringEnum.Parse(typeof(KalturaDailymotionDistributionProviderOrderBy), txt);
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

