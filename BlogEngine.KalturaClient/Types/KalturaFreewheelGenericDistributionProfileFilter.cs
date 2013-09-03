using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaFreewheelGenericDistributionProfileFilter : KalturaFreewheelGenericDistributionProfileBaseFilter
	{
		#region Private Fields
		private KalturaFreewheelGenericDistributionProfileOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public new KalturaFreewheelGenericDistributionProfileOrderBy OrderBy
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
		public KalturaFreewheelGenericDistributionProfileFilter()
		{
		}

		public KalturaFreewheelGenericDistributionProfileFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "orderBy":
						this.OrderBy = (KalturaFreewheelGenericDistributionProfileOrderBy)KalturaStringEnum.Parse(typeof(KalturaFreewheelGenericDistributionProfileOrderBy), txt);
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

