using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaFreewheelGenericDistributionProviderBaseFilter : KalturaDistributionProviderFilter
	{
		#region Private Fields
		#endregion

		#region Properties
		#endregion

		#region CTor
		public KalturaFreewheelGenericDistributionProviderBaseFilter()
		{
		}

		public KalturaFreewheelGenericDistributionProviderBaseFilter(XmlElement node) : base(node)
		{
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			return kparams;
		}
		#endregion
	}
}

