using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaPartnerFilter : KalturaPartnerBaseFilter
	{
		#region Private Fields
		private KalturaPartnerOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public new KalturaPartnerOrderBy OrderBy
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
		public KalturaPartnerFilter()
		{
		}

		public KalturaPartnerFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "orderBy":
						this.OrderBy = (KalturaPartnerOrderBy)KalturaStringEnum.Parse(typeof(KalturaPartnerOrderBy), txt);
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

