using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaPermissionFilter : KalturaPermissionBaseFilter
	{
		#region Private Fields
		private KalturaPermissionOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public new KalturaPermissionOrderBy OrderBy
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
		public KalturaPermissionFilter()
		{
		}

		public KalturaPermissionFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "orderBy":
						this.OrderBy = (KalturaPermissionOrderBy)KalturaStringEnum.Parse(typeof(KalturaPermissionOrderBy), txt);
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

