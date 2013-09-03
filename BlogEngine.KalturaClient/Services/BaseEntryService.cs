using System;
using System.Xml;
using System.Collections.Generic;
using System.IO;

namespace Kaltura
{

	public class KalturaBaseEntryService : KalturaServiceBase
	{
	public KalturaBaseEntryService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaBaseEntry Add(KalturaBaseEntry entry)
		{
			return this.Add(entry, null);
		}

		public KalturaBaseEntry Add(KalturaBaseEntry entry, KalturaEntryType type)
		{
			KalturaParams kparams = new KalturaParams();
			if (entry != null)
				kparams.Add("entry", entry.ToParams());
			kparams.AddStringEnumIfNotNull("type", type);
			_Client.QueueServiceCall("baseentry", "add", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaBaseEntry)KalturaObjectFactory.Create(result);
		}

		public KalturaBaseEntry AddContent(string entryId, KalturaResource resource)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			if (resource != null)
				kparams.Add("resource", resource.ToParams());
			_Client.QueueServiceCall("baseentry", "addContent", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaBaseEntry)KalturaObjectFactory.Create(result);
		}

		public KalturaBaseEntry AddFromUploadedFile(KalturaBaseEntry entry, string uploadTokenId)
		{
			return this.AddFromUploadedFile(entry, uploadTokenId, null);
		}

		public KalturaBaseEntry AddFromUploadedFile(KalturaBaseEntry entry, string uploadTokenId, KalturaEntryType type)
		{
			KalturaParams kparams = new KalturaParams();
			if (entry != null)
				kparams.Add("entry", entry.ToParams());
			kparams.AddStringIfNotNull("uploadTokenId", uploadTokenId);
			kparams.AddStringEnumIfNotNull("type", type);
			_Client.QueueServiceCall("baseentry", "addFromUploadedFile", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaBaseEntry)KalturaObjectFactory.Create(result);
		}

		public KalturaBaseEntry Get(string entryId)
		{
			return this.Get(entryId, -1);
		}

		public KalturaBaseEntry Get(string entryId, int version)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			kparams.AddIntIfNotNull("version", version);
			_Client.QueueServiceCall("baseentry", "get", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaBaseEntry)KalturaObjectFactory.Create(result);
		}

		public KalturaRemotePathListResponse GetRemotePaths(string entryId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			_Client.QueueServiceCall("baseentry", "getRemotePaths", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaRemotePathListResponse)KalturaObjectFactory.Create(result);
		}

		public KalturaBaseEntry Update(string entryId, KalturaBaseEntry baseEntry)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			if (baseEntry != null)
				kparams.Add("baseEntry", baseEntry.ToParams());
			_Client.QueueServiceCall("baseentry", "update", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaBaseEntry)KalturaObjectFactory.Create(result);
		}

		public KalturaBaseEntry UpdateContent(string entryId, KalturaResource resource)
		{
			return this.UpdateContent(entryId, resource, Int32.MinValue);
		}

		public KalturaBaseEntry UpdateContent(string entryId, KalturaResource resource, int conversionProfileId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			if (resource != null)
				kparams.Add("resource", resource.ToParams());
			kparams.AddIntIfNotNull("conversionProfileId", conversionProfileId);
			_Client.QueueServiceCall("baseentry", "updateContent", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaBaseEntry)KalturaObjectFactory.Create(result);
		}

		public IList<KalturaBaseEntry> GetByIds(string entryIds)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryIds", entryIds);
			_Client.QueueServiceCall("baseentry", "getByIds", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			IList<KalturaBaseEntry> list = new List<KalturaBaseEntry>();
			foreach(XmlElement node in result.ChildNodes)
			{
				list.Add((KalturaBaseEntry)KalturaObjectFactory.Create(node));
			}
			return list;
		}

		public void Delete(string entryId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			_Client.QueueServiceCall("baseentry", "delete", kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public KalturaBaseEntryListResponse List()
		{
			return this.List(null);
		}

		public KalturaBaseEntryListResponse List(KalturaBaseEntryFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaBaseEntryListResponse List(KalturaBaseEntryFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			if (filter != null)
				kparams.Add("filter", filter.ToParams());
			if (pager != null)
				kparams.Add("pager", pager.ToParams());
			_Client.QueueServiceCall("baseentry", "list", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaBaseEntryListResponse)KalturaObjectFactory.Create(result);
		}

		public int Count()
		{
			return this.Count(null);
		}

		public int Count(KalturaBaseEntryFilter filter)
		{
			KalturaParams kparams = new KalturaParams();
			if (filter != null)
				kparams.Add("filter", filter.ToParams());
			_Client.QueueServiceCall("baseentry", "count", kparams);
			if (this._Client.IsMultiRequest)
				return 0;
			XmlElement result = _Client.DoQueue();
			return int.Parse(result.InnerText);
		}

		public string Upload(FileStream fileData)
		{
			KalturaParams kparams = new KalturaParams();
			KalturaFiles kfiles = new KalturaFiles();
			kfiles.Add("fileData", fileData);
			_Client.QueueServiceCall("baseentry", "upload", kparams, kfiles);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return result.InnerText;
		}

		public KalturaBaseEntry UpdateThumbnailJpeg(string entryId, FileStream fileData)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			KalturaFiles kfiles = new KalturaFiles();
			kfiles.Add("fileData", fileData);
			_Client.QueueServiceCall("baseentry", "updateThumbnailJpeg", kparams, kfiles);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaBaseEntry)KalturaObjectFactory.Create(result);
		}

		public KalturaBaseEntry UpdateThumbnailFromUrl(string entryId, string url)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			kparams.AddStringIfNotNull("url", url);
			_Client.QueueServiceCall("baseentry", "updateThumbnailFromUrl", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaBaseEntry)KalturaObjectFactory.Create(result);
		}

		public KalturaBaseEntry UpdateThumbnailFromSourceEntry(string entryId, string sourceEntryId, int timeOffset)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			kparams.AddStringIfNotNull("sourceEntryId", sourceEntryId);
			kparams.AddIntIfNotNull("timeOffset", timeOffset);
			_Client.QueueServiceCall("baseentry", "updateThumbnailFromSourceEntry", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaBaseEntry)KalturaObjectFactory.Create(result);
		}

		public void Flag(KalturaModerationFlag moderationFlag)
		{
			KalturaParams kparams = new KalturaParams();
			if (moderationFlag != null)
				kparams.Add("moderationFlag", moderationFlag.ToParams());
			_Client.QueueServiceCall("baseentry", "flag", kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public void Reject(string entryId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			_Client.QueueServiceCall("baseentry", "reject", kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public void Approve(string entryId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			_Client.QueueServiceCall("baseentry", "approve", kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public KalturaModerationFlagListResponse ListFlags(string entryId)
		{
			return this.ListFlags(entryId, null);
		}

		public KalturaModerationFlagListResponse ListFlags(string entryId, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			if (pager != null)
				kparams.Add("pager", pager.ToParams());
			_Client.QueueServiceCall("baseentry", "listFlags", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaModerationFlagListResponse)KalturaObjectFactory.Create(result);
		}

		public void AnonymousRank(string entryId, int rank)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			kparams.AddIntIfNotNull("rank", rank);
			_Client.QueueServiceCall("baseentry", "anonymousRank", kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public KalturaEntryContextDataResult GetContextData(string entryId, KalturaEntryContextDataParams contextDataParams)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			if (contextDataParams != null)
				kparams.Add("contextDataParams", contextDataParams.ToParams());
			_Client.QueueServiceCall("baseentry", "getContextData", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaEntryContextDataResult)KalturaObjectFactory.Create(result);
		}
	}
}
