using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaHuluDistributionProfileFilter : KalturaHuluDistributionProfileBaseFilter
	{
		#region Private Fields
		private KalturaHuluDistributionProfileOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public new KalturaHuluDistributionProfileOrderBy OrderBy
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
		public KalturaHuluDistributionProfileFilter()
		{
		}

		public KalturaHuluDistributionProfileFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "orderBy":
						this.OrderBy = (KalturaHuluDistributionProfileOrderBy)KalturaStringEnum.Parse(typeof(KalturaHuluDistributionProfileOrderBy), txt);
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

