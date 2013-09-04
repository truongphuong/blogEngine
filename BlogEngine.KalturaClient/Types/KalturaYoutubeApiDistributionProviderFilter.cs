using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaYoutubeApiDistributionProviderFilter : KalturaYoutubeApiDistributionProviderBaseFilter
	{
		#region Private Fields
		private KalturaYoutubeApiDistributionProviderOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public new KalturaYoutubeApiDistributionProviderOrderBy OrderBy
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
		public KalturaYoutubeApiDistributionProviderFilter()
		{
		}

		public KalturaYoutubeApiDistributionProviderFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "orderBy":
						this.OrderBy = (KalturaYoutubeApiDistributionProviderOrderBy)KalturaStringEnum.Parse(typeof(KalturaYoutubeApiDistributionProviderOrderBy), txt);
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

