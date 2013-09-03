using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaYoutubeApiDistributionProfileFilter : KalturaYoutubeApiDistributionProfileBaseFilter
	{
		#region Private Fields
		private KalturaYoutubeApiDistributionProfileOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public new KalturaYoutubeApiDistributionProfileOrderBy OrderBy
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
		public KalturaYoutubeApiDistributionProfileFilter()
		{
		}

		public KalturaYoutubeApiDistributionProfileFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "orderBy":
						this.OrderBy = (KalturaYoutubeApiDistributionProfileOrderBy)KalturaStringEnum.Parse(typeof(KalturaYoutubeApiDistributionProfileOrderBy), txt);
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

