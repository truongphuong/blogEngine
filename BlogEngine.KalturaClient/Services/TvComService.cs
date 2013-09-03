using System;
using System.Xml;
using System.Collections.Generic;
using System.IO;

namespace Kaltura
{

	public class KalturaTvComService : KalturaServiceBase
	{
	public KalturaTvComService(KalturaClient client)
			: base(client)
		{
		}

		public void GetFeed(int distributionProfileId, string hash)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("distributionProfileId", distributionProfileId);
			kparams.AddStringIfNotNull("hash", hash);
			_Client.QueueServiceCall("tvcomdistribution_tvcom", "getFeed", kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}
	}
}
