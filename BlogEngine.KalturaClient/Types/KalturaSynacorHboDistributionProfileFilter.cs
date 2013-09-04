using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaSynacorHboDistributionProfileFilter : KalturaSynacorHboDistributionProfileBaseFilter
	{
		#region Private Fields
		private KalturaSynacorHboDistributionProfileOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public new KalturaSynacorHboDistributionProfileOrderBy OrderBy
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
		public KalturaSynacorHboDistributionProfileFilter()
		{
		}

		public KalturaSynacorHboDistributionProfileFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "orderBy":
						this.OrderBy = (KalturaSynacorHboDistributionProfileOrderBy)KalturaStringEnum.Parse(typeof(KalturaSynacorHboDistributionProfileOrderBy), txt);
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

