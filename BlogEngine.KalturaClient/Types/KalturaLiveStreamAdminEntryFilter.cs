using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaLiveStreamAdminEntryFilter : KalturaLiveStreamAdminEntryBaseFilter
	{
		#region Private Fields
		private KalturaLiveStreamAdminEntryOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public new KalturaLiveStreamAdminEntryOrderBy OrderBy
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
		public KalturaLiveStreamAdminEntryFilter()
		{
		}

		public KalturaLiveStreamAdminEntryFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "orderBy":
						this.OrderBy = (KalturaLiveStreamAdminEntryOrderBy)KalturaStringEnum.Parse(typeof(KalturaLiveStreamAdminEntryOrderBy), txt);
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

