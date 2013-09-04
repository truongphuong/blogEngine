using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaSynacorHboDistributionProviderFilter : KalturaSynacorHboDistributionProviderBaseFilter
	{
		#region Private Fields
		private KalturaSynacorHboDistributionProviderOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public new KalturaSynacorHboDistributionProviderOrderBy OrderBy
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
		public KalturaSynacorHboDistributionProviderFilter()
		{
		}

		public KalturaSynacorHboDistributionProviderFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "orderBy":
						this.OrderBy = (KalturaSynacorHboDistributionProviderOrderBy)KalturaStringEnum.Parse(typeof(KalturaSynacorHboDistributionProviderOrderBy), txt);
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

