using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaApiParameterPermissionItemFilter : KalturaApiParameterPermissionItemBaseFilter
	{
		#region Private Fields
		private KalturaApiParameterPermissionItemOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public new KalturaApiParameterPermissionItemOrderBy OrderBy
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
		public KalturaApiParameterPermissionItemFilter()
		{
		}

		public KalturaApiParameterPermissionItemFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "orderBy":
						this.OrderBy = (KalturaApiParameterPermissionItemOrderBy)KalturaStringEnum.Parse(typeof(KalturaApiParameterPermissionItemOrderBy), txt);
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

