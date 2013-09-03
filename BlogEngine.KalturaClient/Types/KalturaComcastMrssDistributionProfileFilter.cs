using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaComcastMrssDistributionProfileFilter : KalturaComcastMrssDistributionProfileBaseFilter
	{
		#region Private Fields
		private KalturaComcastMrssDistributionProfileOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public new KalturaComcastMrssDistributionProfileOrderBy OrderBy
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
		public KalturaComcastMrssDistributionProfileFilter()
		{
		}

		public KalturaComcastMrssDistributionProfileFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "orderBy":
						this.OrderBy = (KalturaComcastMrssDistributionProfileOrderBy)KalturaStringEnum.Parse(typeof(KalturaComcastMrssDistributionProfileOrderBy), txt);
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

