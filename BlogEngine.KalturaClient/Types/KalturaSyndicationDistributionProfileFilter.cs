using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaSyndicationDistributionProfileFilter : KalturaSyndicationDistributionProfileBaseFilter
	{
		#region Private Fields
		private KalturaSyndicationDistributionProfileOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public new KalturaSyndicationDistributionProfileOrderBy OrderBy
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
		public KalturaSyndicationDistributionProfileFilter()
		{
		}

		public KalturaSyndicationDistributionProfileFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "orderBy":
						this.OrderBy = (KalturaSyndicationDistributionProfileOrderBy)KalturaStringEnum.Parse(typeof(KalturaSyndicationDistributionProfileOrderBy), txt);
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

