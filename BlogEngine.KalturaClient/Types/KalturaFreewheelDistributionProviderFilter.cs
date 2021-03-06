using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaFreewheelDistributionProviderFilter : KalturaFreewheelDistributionProviderBaseFilter
	{
		#region Private Fields
		private KalturaFreewheelDistributionProviderOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public new KalturaFreewheelDistributionProviderOrderBy OrderBy
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
		public KalturaFreewheelDistributionProviderFilter()
		{
		}

		public KalturaFreewheelDistributionProviderFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "orderBy":
						this.OrderBy = (KalturaFreewheelDistributionProviderOrderBy)KalturaStringEnum.Parse(typeof(KalturaFreewheelDistributionProviderOrderBy), txt);
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

