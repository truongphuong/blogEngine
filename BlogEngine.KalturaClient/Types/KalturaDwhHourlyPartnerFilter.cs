using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaDwhHourlyPartnerFilter : KalturaDwhHourlyPartnerBaseFilter
	{
		#region Private Fields
		private KalturaDwhHourlyPartnerOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public new KalturaDwhHourlyPartnerOrderBy OrderBy
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
		public KalturaDwhHourlyPartnerFilter()
		{
		}

		public KalturaDwhHourlyPartnerFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "orderBy":
						this.OrderBy = (KalturaDwhHourlyPartnerOrderBy)KalturaStringEnum.Parse(typeof(KalturaDwhHourlyPartnerOrderBy), txt);
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

