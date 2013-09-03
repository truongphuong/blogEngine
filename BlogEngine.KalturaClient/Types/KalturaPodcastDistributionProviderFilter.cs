using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaPodcastDistributionProviderFilter : KalturaPodcastDistributionProviderBaseFilter
	{
		#region Private Fields
		private KalturaPodcastDistributionProviderOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public new KalturaPodcastDistributionProviderOrderBy OrderBy
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
		public KalturaPodcastDistributionProviderFilter()
		{
		}

		public KalturaPodcastDistributionProviderFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "orderBy":
						this.OrderBy = (KalturaPodcastDistributionProviderOrderBy)KalturaStringEnum.Parse(typeof(KalturaPodcastDistributionProviderOrderBy), txt);
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

