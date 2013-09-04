using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaGoogleVideoSyndicationFeedFilter : KalturaGoogleVideoSyndicationFeedBaseFilter
	{
		#region Private Fields
		private KalturaGoogleVideoSyndicationFeedOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public new KalturaGoogleVideoSyndicationFeedOrderBy OrderBy
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
		public KalturaGoogleVideoSyndicationFeedFilter()
		{
		}

		public KalturaGoogleVideoSyndicationFeedFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "orderBy":
						this.OrderBy = (KalturaGoogleVideoSyndicationFeedOrderBy)KalturaStringEnum.Parse(typeof(KalturaGoogleVideoSyndicationFeedOrderBy), txt);
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

