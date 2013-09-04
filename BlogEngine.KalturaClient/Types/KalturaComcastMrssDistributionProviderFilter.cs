using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaComcastMrssDistributionProviderFilter : KalturaComcastMrssDistributionProviderBaseFilter
	{
		#region Private Fields
		private KalturaComcastMrssDistributionProviderOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public new KalturaComcastMrssDistributionProviderOrderBy OrderBy
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
		public KalturaComcastMrssDistributionProviderFilter()
		{
		}

		public KalturaComcastMrssDistributionProviderFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "orderBy":
						this.OrderBy = (KalturaComcastMrssDistributionProviderOrderBy)KalturaStringEnum.Parse(typeof(KalturaComcastMrssDistributionProviderOrderBy), txt);
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

