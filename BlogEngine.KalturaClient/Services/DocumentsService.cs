using System;
using System.Xml;
using System.Collections.Generic;
using System.IO;

namespace Kaltura
{

	public class KalturaDocumentsService : KalturaServiceBase
	{
	public KalturaDocumentsService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaDocumentEntry AddFromUploadedFile(KalturaDocumentEntry documentEntry, string uploadTokenId)
		{
			KalturaParams kparams = new KalturaParams();
			if (documentEntry != null)
				kparams.Add("documentEntry", documentEntry.ToParams());
			kparams.AddStringIfNotNull("uploadTokenId", uploadTokenId);
			_Client.QueueServiceCall("document_documents", "addFromUploadedFile", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaDocumentEntry)KalturaObjectFactory.Create(result);
		}

		public KalturaDocumentEntry AddFromEntry(string sourceEntryId)
		{
			return this.AddFromEntry(sourceEntryId, null);
		}

		public KalturaDocumentEntry AddFromEntry(string sourceEntryId, KalturaDocumentEntry documentEntry)
		{
			return this.AddFromEntry(sourceEntryId, documentEntry, Int32.MinValue);
		}

		public KalturaDocumentEntry AddFromEntry(string sourceEntryId, KalturaDocumentEntry documentEntry, int sourceFlavorParamsId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("sourceEntryId", sourceEntryId);
			if (documentEntry != null)
				kparams.Add("documentEntry", documentEntry.ToParams());
			kparams.AddIntIfNotNull("sourceFlavorParamsId", sourceFlavorParamsId);
			_Client.QueueServiceCall("document_documents", "addFromEntry", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaDocumentEntry)KalturaObjectFactory.Create(result);
		}

		public KalturaDocumentEntry AddFromFlavorAsset(string sourceFlavorAssetId)
		{
			return this.AddFromFlavorAsset(sourceFlavorAssetId, null);
		}

		public KalturaDocumentEntry AddFromFlavorAsset(string sourceFlavorAssetId, KalturaDocumentEntry documentEntry)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("sourceFlavorAssetId", sourceFlavorAssetId);
			if (documentEntry != null)
				kparams.Add("documentEntry", documentEntry.ToParams());
			_Client.QueueServiceCall("document_documents", "addFromFlavorAsset", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaDocumentEntry)KalturaObjectFactory.Create(result);
		}

		public int Convert(string entryId)
		{
			return this.Convert(entryId, Int32.MinValue);
		}

		public int Convert(string entryId, int conversionProfileId)
		{
			return this.Convert(entryId, conversionProfileId, null);
		}

		public int Convert(string entryId, int conversionProfileId, IList<KalturaConversionAttribute> dynamicConversionAttributes)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			kparams.AddIntIfNotNull("conversionProfileId", conversionProfileId);
			foreach(KalturaConversionAttribute obj in dynamicConversionAttributes)
			{
				kparams.Add("dynamicConversionAttributes", obj.ToParams());
			}
			_Client.QueueServiceCall("document_documents", "convert", kparams);
			if (this._Client.IsMultiRequest)
				return 0;
			XmlElement result = _Client.DoQueue();
			return int.Parse(result.InnerText);
		}

		public KalturaDocumentEntry Get(string entryId)
		{
			return this.Get(entryId, -1);
		}

		public KalturaDocumentEntry Get(string entryId, int version)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			kparams.AddIntIfNotNull("version", version);
			_Client.QueueServiceCall("document_documents", "get", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaDocumentEntry)KalturaObjectFactory.Create(result);
		}

		public KalturaDocumentEntry Update(string entryId, KalturaDocumentEntry documentEntry)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			if (documentEntry != null)
				kparams.Add("documentEntry", documentEntry.ToParams());
			_Client.QueueServiceCall("document_documents", "update", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaDocumentEntry)KalturaObjectFactory.Create(result);
		}

		public void Delete(string entryId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			_Client.QueueServiceCall("document_documents", "delete", kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public KalturaDocumentListResponse List()
		{
			return this.List(null);
		}

		public KalturaDocumentListResponse List(KalturaDocumentEntryFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaDocumentListResponse List(KalturaDocumentEntryFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			if (filter != null)
				kparams.Add("filter", filter.ToParams());
			if (pager != null)
				kparams.Add("pager", pager.ToParams());
			_Client.QueueServiceCall("document_documents", "list", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaDocumentListResponse)KalturaObjectFactory.Create(result);
		}

		public string Upload(FileStream fileData)
		{
			KalturaParams kparams = new KalturaParams();
			KalturaFiles kfiles = new KalturaFiles();
			kfiles.Add("fileData", fileData);
			_Client.QueueServiceCall("document_documents", "upload", kparams, kfiles);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return result.InnerText;
		}

		public string ConvertPptToSwf(string entryId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			_Client.QueueServiceCall("document_documents", "convertPptToSwf", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return result.InnerText;
		}
	}
}
