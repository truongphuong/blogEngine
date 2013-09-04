using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaITunesSyndicationFeedFilter : KalturaITunesSyndicationFeedBaseFilter
	{
		#region Private Fields
		private KalturaITunesSyndicationFeedOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public new KalturaITunesSyndicationFeedOrderBy OrderBy
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
		public KalturaITunesSyndicationFeedFilter()
		{
		}

		public KalturaITunesSyndicationFeedFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "orderBy":
						this.OrderBy = (KalturaITunesSyndicationFeedOrderBy)KalturaStringEnum.Parse(typeof(KalturaITunesSyndicationFeedOrderBy), txt);
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

