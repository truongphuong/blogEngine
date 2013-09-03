using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaAuditTrailFilter : KalturaAuditTrailBaseFilter
	{
		#region Private Fields
		private KalturaAuditTrailOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public new KalturaAuditTrailOrderBy OrderBy
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
		public KalturaAuditTrailFilter()
		{
		}

		public KalturaAuditTrailFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "orderBy":
						this.OrderBy = (KalturaAuditTrailOrderBy)KalturaStringEnum.Parse(typeof(KalturaAuditTrailOrderBy), txt);
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

