using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaOperationAttributes : KalturaObjectBase
	{
		#region Private Fields
		#endregion

		#region Properties
		#endregion

		#region CTor
		public KalturaOperationAttributes()
		{
		}

		public KalturaOperationAttributes(XmlElement node)
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

