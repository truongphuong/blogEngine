using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaEntryDistributionFilter : KalturaEntryDistributionBaseFilter
	{
		#region Private Fields
		private KalturaEntryDistributionOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public new KalturaEntryDistributionOrderBy OrderBy
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
		public KalturaEntryDistributionFilter()
		{
		}

		public KalturaEntryDistributionFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "orderBy":
						this.OrderBy = (KalturaEntryDistributionOrderBy)KalturaStringEnum.Parse(typeof(KalturaEntryDistributionOrderBy), txt);
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

