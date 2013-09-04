using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaPodcastDistributionProfileFilter : KalturaPodcastDistributionProfileBaseFilter
	{
		#region Private Fields
		private KalturaPodcastDistributionProfileOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public new KalturaPodcastDistributionProfileOrderBy OrderBy
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
		public KalturaPodcastDistributionProfileFilter()
		{
		}

		public KalturaPodcastDistributionProfileFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "orderBy":
						this.OrderBy = (KalturaPodcastDistributionProfileOrderBy)KalturaStringEnum.Parse(typeof(KalturaPodcastDistributionProfileOrderBy), txt);
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

