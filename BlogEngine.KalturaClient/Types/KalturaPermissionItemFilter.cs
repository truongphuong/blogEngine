using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaPermissionItemFilter : KalturaPermissionItemBaseFilter
	{
		#region Private Fields
		private KalturaPermissionItemOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public new KalturaPermissionItemOrderBy OrderBy
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
		public KalturaPermissionItemFilter()
		{
		}

		public KalturaPermissionItemFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "orderBy":
						this.OrderBy = (KalturaPermissionItemOrderBy)KalturaStringEnum.Parse(typeof(KalturaPermissionItemOrderBy), txt);
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

