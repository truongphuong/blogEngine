using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaDoubleClickDistributionProfileFilter : KalturaDoubleClickDistributionProfileBaseFilter
	{
		#region Private Fields
		private KalturaDoubleClickDistributionProfileOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public new KalturaDoubleClickDistributionProfileOrderBy OrderBy
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
		public KalturaDoubleClickDistributionProfileFilter()
		{
		}

		public KalturaDoubleClickDistributionProfileFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "orderBy":
						this.OrderBy = (KalturaDoubleClickDistributionProfileOrderBy)KalturaStringEnum.Parse(typeof(KalturaDoubleClickDistributionProfileOrderBy), txt);
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

