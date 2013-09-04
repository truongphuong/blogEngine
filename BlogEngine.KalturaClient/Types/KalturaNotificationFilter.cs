using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaNotificationFilter : KalturaNotificationBaseFilter
	{
		#region Private Fields
		private KalturaNotificationOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public new KalturaNotificationOrderBy OrderBy
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
		public KalturaNotificationFilter()
		{
		}

		public KalturaNotificationFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "orderBy":
						this.OrderBy = (KalturaNotificationOrderBy)KalturaStringEnum.Parse(typeof(KalturaNotificationOrderBy), txt);
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

