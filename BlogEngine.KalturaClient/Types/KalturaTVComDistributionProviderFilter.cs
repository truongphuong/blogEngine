using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaTVComDistributionProviderFilter : KalturaTVComDistributionProviderBaseFilter
	{
		#region Private Fields
		private KalturaTVComDistributionProviderOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public new KalturaTVComDistributionProviderOrderBy OrderBy
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
		public KalturaTVComDistributionProviderFilter()
		{
		}

		public KalturaTVComDistributionProviderFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "orderBy":
						this.OrderBy = (KalturaTVComDistributionProviderOrderBy)KalturaStringEnum.Parse(typeof(KalturaTVComDistributionProviderOrderBy), txt);
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

