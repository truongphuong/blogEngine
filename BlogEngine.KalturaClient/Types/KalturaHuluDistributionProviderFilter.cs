using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaHuluDistributionProviderFilter : KalturaHuluDistributionProviderBaseFilter
	{
		#region Private Fields
		private KalturaHuluDistributionProviderOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public new KalturaHuluDistributionProviderOrderBy OrderBy
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
		public KalturaHuluDistributionProviderFilter()
		{
		}

		public KalturaHuluDistributionProviderFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "orderBy":
						this.OrderBy = (KalturaHuluDistributionProviderOrderBy)KalturaStringEnum.Parse(typeof(KalturaHuluDistributionProviderOrderBy), txt);
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

