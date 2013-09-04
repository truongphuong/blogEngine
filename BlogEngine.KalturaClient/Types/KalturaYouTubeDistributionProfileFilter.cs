using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaYouTubeDistributionProfileFilter : KalturaYouTubeDistributionProfileBaseFilter
	{
		#region Private Fields
		private KalturaYouTubeDistributionProfileOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public new KalturaYouTubeDistributionProfileOrderBy OrderBy
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
		public KalturaYouTubeDistributionProfileFilter()
		{
		}

		public KalturaYouTubeDistributionProfileFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "orderBy":
						this.OrderBy = (KalturaYouTubeDistributionProfileOrderBy)KalturaStringEnum.Parse(typeof(KalturaYouTubeDistributionProfileOrderBy), txt);
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

