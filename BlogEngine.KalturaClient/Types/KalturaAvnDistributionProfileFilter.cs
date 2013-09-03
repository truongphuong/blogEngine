using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaAvnDistributionProfileFilter : KalturaAvnDistributionProfileBaseFilter
	{
		#region Private Fields
		private KalturaAvnDistributionProfileOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public new KalturaAvnDistributionProfileOrderBy OrderBy
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
		public KalturaAvnDistributionProfileFilter()
		{
		}

		public KalturaAvnDistributionProfileFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "orderBy":
						this.OrderBy = (KalturaAvnDistributionProfileOrderBy)KalturaStringEnum.Parse(typeof(KalturaAvnDistributionProfileOrderBy), txt);
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

