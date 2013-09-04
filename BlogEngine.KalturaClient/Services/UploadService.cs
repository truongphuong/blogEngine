using System;
using System.Xml;
using System.Collections.Generic;
using System.IO;

namespace Kaltura
{

	public class KalturaUploadService : KalturaServiceBase
	{
	public KalturaUploadService(KalturaClient client)
			: base(client)
		{
		}

		public string Upload(FileStream fileData)
		{
			KalturaParams kparams = new KalturaParams();
			KalturaFiles kfiles = new KalturaFiles();
			kfiles.Add("fileData", fileData);
			_Client.QueueServiceCall("upload", "upload", kparams, kfiles);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return result.InnerText;
		}

		public KalturaUploadResponse GetUploadedFileTokenByFileName(string fileName)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("fileName", fileName);
			_Client.QueueServiceCall("upload", "getUploadedFileTokenByFileName", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaUploadResponse)KalturaObjectFactory.Create(result);
		}
	}
}
