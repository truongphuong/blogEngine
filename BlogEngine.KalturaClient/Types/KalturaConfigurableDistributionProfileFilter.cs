using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaConfigurableDistributionProfileFilter : KalturaConfigurableDistributionProfileBaseFilter
	{
		#region Private Fields
		private KalturaConfigurableDistributionProfileOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public new KalturaConfigurableDistributionProfileOrderBy OrderBy
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
		public KalturaConfigurableDistributionProfileFilter()
		{
		}

		public KalturaConfigurableDistributionProfileFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "orderBy":
						this.OrderBy = (KalturaConfigurableDistributionProfileOrderBy)KalturaStringEnum.Parse(typeof(KalturaConfigurableDistributionProfileOrderBy), txt);
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

