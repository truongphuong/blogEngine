using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaAdminUserFilter : KalturaAdminUserBaseFilter
	{
		#region Private Fields
		private KalturaAdminUserOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public new KalturaAdminUserOrderBy OrderBy
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
		public KalturaAdminUserFilter()
		{
		}

		public KalturaAdminUserFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "orderBy":
						this.OrderBy = (KalturaAdminUserOrderBy)KalturaStringEnum.Parse(typeof(KalturaAdminUserOrderBy), txt);
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

