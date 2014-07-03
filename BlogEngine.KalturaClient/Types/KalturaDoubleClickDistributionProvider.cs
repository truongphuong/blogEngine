using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaDoubleClickDistributionProvider : KalturaDistributionProvider
	{
		#region Private Fields
		#endregion

		#region Properties
		#endregion

		#region CTor
		public KalturaDoubleClickDistributionProvider()
		{
		}

		public KalturaDoubleClickDistributionProvider(XmlElement node) : base(node)
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

