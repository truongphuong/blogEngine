using System;
using System.Xml;
using System.Collections.Generic;
using System.IO;

namespace Kaltura
{

	public class KalturaXInternalService : KalturaServiceBase
	{
	public KalturaXInternalService(KalturaClient client)
			: base(client)
		{
		}

		public string XAddBulkDownload(string entryIds)
		{
			return this.XAddBulkDownload(entryIds, "");
		}

		public string XAddBulkDownload(string entryIds, string flavorParamsId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryIds", entryIds);
			kparams.AddStringIfNotNull("flavorParamsId", flavorParamsId);
			_Client.QueueServiceCall("xinternal", "xAddBulkDownload", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return result.InnerText;
		}
	}
}
