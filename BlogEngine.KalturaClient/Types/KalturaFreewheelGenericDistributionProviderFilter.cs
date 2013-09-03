using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaFreewheelGenericDistributionProviderFilter : KalturaFreewheelGenericDistributionProviderBaseFilter
	{
		#region Private Fields
		private KalturaFreewheelGenericDistributionProviderOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public new KalturaFreewheelGenericDistributionProviderOrderBy OrderBy
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
		public KalturaFreewheelGenericDistributionProviderFilter()
		{
		}

		public KalturaFreewheelGenericDistributionProviderFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "orderBy":
						this.OrderBy = (KalturaFreewheelGenericDistributionProviderOrderBy)KalturaStringEnum.Parse(typeof(KalturaFreewheelGenericDistributionProviderOrderBy), txt);
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

