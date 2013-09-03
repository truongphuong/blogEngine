using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaExampleDistributionProviderFilter : KalturaExampleDistributionProviderBaseFilter
	{
		#region Private Fields
		private KalturaExampleDistributionProviderOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public new KalturaExampleDistributionProviderOrderBy OrderBy
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
		public KalturaExampleDistributionProviderFilter()
		{
		}

		public KalturaExampleDistributionProviderFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "orderBy":
						this.OrderBy = (KalturaExampleDistributionProviderOrderBy)KalturaStringEnum.Parse(typeof(KalturaExampleDistributionProviderOrderBy), txt);
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

