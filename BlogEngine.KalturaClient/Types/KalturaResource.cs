using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaResource : KalturaObjectBase
	{
		#region Private Fields
		#endregion

		#region Properties
		#endregion

		#region CTor
		public KalturaResource()
		{
		}

		public KalturaResource(XmlElement node)
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

