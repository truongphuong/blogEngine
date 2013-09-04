using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaTVComDistributionProfileFilter : KalturaTVComDistributionProfileBaseFilter
	{
		#region Private Fields
		private KalturaTVComDistributionProfileOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public new KalturaTVComDistributionProfileOrderBy OrderBy
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
		public KalturaTVComDistributionProfileFilter()
		{
		}

		public KalturaTVComDistributionProfileFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "orderBy":
						this.OrderBy = (KalturaTVComDistributionProfileOrderBy)KalturaStringEnum.Parse(typeof(KalturaTVComDistributionProfileOrderBy), txt);
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

