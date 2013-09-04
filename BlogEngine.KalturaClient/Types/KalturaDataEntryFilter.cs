using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaDataEntryFilter : KalturaDataEntryBaseFilter
	{
		#region Private Fields
		private KalturaDataEntryOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public new KalturaDataEntryOrderBy OrderBy
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
		public KalturaDataEntryFilter()
		{
		}

		public KalturaDataEntryFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "orderBy":
						this.OrderBy = (KalturaDataEntryOrderBy)KalturaStringEnum.Parse(typeof(KalturaDataEntryOrderBy), txt);
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

