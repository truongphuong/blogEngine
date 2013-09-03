using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaYouTubeDistributionProviderFilter : KalturaYouTubeDistributionProviderBaseFilter
	{
		#region Private Fields
		private KalturaYouTubeDistributionProviderOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public new KalturaYouTubeDistributionProviderOrderBy OrderBy
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
		public KalturaYouTubeDistributionProviderFilter()
		{
		}

		public KalturaYouTubeDistributionProviderFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "orderBy":
						this.OrderBy = (KalturaYouTubeDistributionProviderOrderBy)KalturaStringEnum.Parse(typeof(KalturaYouTubeDistributionProviderOrderBy), txt);
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

