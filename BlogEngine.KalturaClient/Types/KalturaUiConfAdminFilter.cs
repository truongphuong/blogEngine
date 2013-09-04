using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaUiConfAdminFilter : KalturaUiConfAdminBaseFilter
	{
		#region Private Fields
		private KalturaUiConfAdminOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public new KalturaUiConfAdminOrderBy OrderBy
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
		public KalturaUiConfAdminFilter()
		{
		}

		public KalturaUiConfAdminFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "orderBy":
						this.OrderBy = (KalturaUiConfAdminOrderBy)KalturaStringEnum.Parse(typeof(KalturaUiConfAdminOrderBy), txt);
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

