using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaIdeticDistributionProfileFilter : KalturaIdeticDistributionProfileBaseFilter
	{
		#region Private Fields
		private KalturaIdeticDistributionProfileOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public new KalturaIdeticDistributionProfileOrderBy OrderBy
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
		public KalturaIdeticDistributionProfileFilter()
		{
		}

		public KalturaIdeticDistributionProfileFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "orderBy":
						this.OrderBy = (KalturaIdeticDistributionProfileOrderBy)KalturaStringEnum.Parse(typeof(KalturaIdeticDistributionProfileOrderBy), txt);
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

