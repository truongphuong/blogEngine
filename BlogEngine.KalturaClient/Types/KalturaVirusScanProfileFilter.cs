using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaVirusScanProfileFilter : KalturaVirusScanProfileBaseFilter
	{
		#region Private Fields
		private KalturaVirusScanProfileOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public new KalturaVirusScanProfileOrderBy OrderBy
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
		public KalturaVirusScanProfileFilter()
		{
		}

		public KalturaVirusScanProfileFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "orderBy":
						this.OrderBy = (KalturaVirusScanProfileOrderBy)KalturaStringEnum.Parse(typeof(KalturaVirusScanProfileOrderBy), txt);
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

