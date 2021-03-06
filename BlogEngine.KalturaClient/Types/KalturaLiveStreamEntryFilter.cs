using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaLiveStreamEntryFilter : KalturaLiveStreamEntryBaseFilter
	{
		#region Private Fields
		private KalturaLiveStreamEntryOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public new KalturaLiveStreamEntryOrderBy OrderBy
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
		public KalturaLiveStreamEntryFilter()
		{
		}

		public KalturaLiveStreamEntryFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "orderBy":
						this.OrderBy = (KalturaLiveStreamEntryOrderBy)KalturaStringEnum.Parse(typeof(KalturaLiveStreamEntryOrderBy), txt);
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

