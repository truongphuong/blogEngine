using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaExampleDistributionProfileFilter : KalturaExampleDistributionProfileBaseFilter
	{
		#region Private Fields
		private KalturaExampleDistributionProfileOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public new KalturaExampleDistributionProfileOrderBy OrderBy
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
		public KalturaExampleDistributionProfileFilter()
		{
		}

		public KalturaExampleDistributionProfileFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "orderBy":
						this.OrderBy = (KalturaExampleDistributionProfileOrderBy)KalturaStringEnum.Parse(typeof(KalturaExampleDistributionProfileOrderBy), txt);
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

