using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaUserRoleFilter : KalturaUserRoleBaseFilter
	{
		#region Private Fields
		private KalturaUserRoleOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public new KalturaUserRoleOrderBy OrderBy
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
		public KalturaUserRoleFilter()
		{
		}

		public KalturaUserRoleFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "orderBy":
						this.OrderBy = (KalturaUserRoleOrderBy)KalturaStringEnum.Parse(typeof(KalturaUserRoleOrderBy), txt);
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

