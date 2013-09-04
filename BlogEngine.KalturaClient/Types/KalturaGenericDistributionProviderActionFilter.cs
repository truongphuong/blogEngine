using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaGenericDistributionProviderActionFilter : KalturaGenericDistributionProviderActionBaseFilter
	{
		#region Private Fields
		private KalturaGenericDistributionProviderActionOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public new KalturaGenericDistributionProviderActionOrderBy OrderBy
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
		public KalturaGenericDistributionProviderActionFilter()
		{
		}

		public KalturaGenericDistributionProviderActionFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "orderBy":
						this.OrderBy = (KalturaGenericDistributionProviderActionOrderBy)KalturaStringEnum.Parse(typeof(KalturaGenericDistributionProviderActionOrderBy), txt);
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

