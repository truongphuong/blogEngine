using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaContentResource : KalturaResource
	{
		#region Private Fields
		#endregion

		#region Properties
		#endregion

		#region CTor
		public KalturaContentResource()
		{
		}

		public KalturaContentResource(XmlElement node) : base(node)
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

