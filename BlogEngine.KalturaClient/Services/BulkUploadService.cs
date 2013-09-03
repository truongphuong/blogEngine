using System;
using System.Xml;
using System.Collections.Generic;
using System.IO;

namespace Kaltura
{

	public class KalturaBulkUploadService : KalturaServiceBase
	{
	public KalturaBulkUploadService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaBulkUpload Add(int conversionProfileId, FileStream csvFileData)
		{
			return this.Add(conversionProfileId, csvFileData, null);
		}

		public KalturaBulkUpload Add(int conversionProfileId, FileStream csvFileData, KalturaBulkUploadType bulkUploadType)
		{
			return this.Add(conversionProfileId, csvFileData, bulkUploadType, null);
		}

		public KalturaBulkUpload Add(int conversionProfileId, FileStream csvFileData, KalturaBulkUploadType bulkUploadType, string uploadedBy)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("conversionProfileId", conversionProfileId);
			KalturaFiles kfiles = new KalturaFiles();
			kfiles.Add("csvFileData", csvFileData);
			kparams.AddStringEnumIfNotNull("bulkUploadType", bulkUploadType);
			kparams.AddStringIfNotNull("uploadedBy", uploadedBy);
			_Client.QueueServiceCall("bulkupload", "add", kparams, kfiles);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaBulkUpload)KalturaObjectFactory.Create(result);
		}

		public KalturaBulkUpload Get(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			_Client.QueueServiceCall("bulkupload", "get", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaBulkUpload)KalturaObjectFactory.Create(result);
		}

		public KalturaBulkUploadListResponse List()
		{
			return this.List(null);
		}

		public KalturaBulkUploadListResponse List(KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			if (pager != null)
				kparams.Add("pager", pager.ToParams());
			_Client.QueueServiceCall("bulkupload", "list", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaBulkUploadListResponse)KalturaObjectFactory.Create(result);
		}

		public KalturaBulkUpload Abort(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			_Client.QueueServiceCall("bulkupload", "abort", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaBulkUpload)KalturaObjectFactory.Create(result);
		}
	}
}
