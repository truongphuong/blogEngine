using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaApiActionPermissionItemFilter : KalturaApiActionPermissionItemBaseFilter
	{
		#region Private Fields
		private KalturaApiActionPermissionItemOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public new KalturaApiActionPermissionItemOrderBy OrderBy
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
		public KalturaApiActionPermissionItemFilter()
		{
		}

		public KalturaApiActionPermissionItemFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "orderBy":
						this.OrderBy = (KalturaApiActionPermissionItemOrderBy)KalturaStringEnum.Parse(typeof(KalturaApiActionPermissionItemOrderBy), txt);
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

