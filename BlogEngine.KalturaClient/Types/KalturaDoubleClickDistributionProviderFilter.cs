using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaDoubleClickDistributionProviderFilter : KalturaDoubleClickDistributionProviderBaseFilter
	{
		#region Private Fields
		private KalturaDoubleClickDistributionProviderOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public new KalturaDoubleClickDistributionProviderOrderBy OrderBy
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
		public KalturaDoubleClickDistributionProviderFilter()
		{
		}

		public KalturaDoubleClickDistributionProviderFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "orderBy":
						this.OrderBy = (KalturaDoubleClickDistributionProviderOrderBy)KalturaStringEnum.Parse(typeof(KalturaDoubleClickDistributionProviderOrderBy), txt);
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

