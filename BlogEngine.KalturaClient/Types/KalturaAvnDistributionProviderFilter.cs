using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaAvnDistributionProviderFilter : KalturaAvnDistributionProviderBaseFilter
	{
		#region Private Fields
		private KalturaAvnDistributionProviderOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public new KalturaAvnDistributionProviderOrderBy OrderBy
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
		public KalturaAvnDistributionProviderFilter()
		{
		}

		public KalturaAvnDistributionProviderFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "orderBy":
						this.OrderBy = (KalturaAvnDistributionProviderOrderBy)KalturaStringEnum.Parse(typeof(KalturaAvnDistributionProviderOrderBy), txt);
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

