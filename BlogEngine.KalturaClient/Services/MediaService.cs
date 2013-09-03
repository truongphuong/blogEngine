using System;
using System.Xml;
using System.Collections.Generic;
using System.IO;

namespace Kaltura
{

	public class KalturaMediaService : KalturaServiceBase
	{
	public KalturaMediaService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaMediaEntry Add(KalturaMediaEntry entry)
		{
			KalturaParams kparams = new KalturaParams();
			if (entry != null)
				kparams.Add("entry", entry.ToParams());
			_Client.QueueServiceCall("media", "add", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaMediaEntry)KalturaObjectFactory.Create(result);
		}

		public KalturaMediaEntry AddContent(string entryId)
		{
			return this.AddContent(entryId, null);
		}

		public KalturaMediaEntry AddContent(string entryId, KalturaResource resource)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			if (resource != null)
				kparams.Add("resource", resource.ToParams());
			_Client.QueueServiceCall("media", "addContent", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaMediaEntry)KalturaObjectFactory.Create(result);
		}

		public KalturaMediaEntry AddFromUrl(KalturaMediaEntry mediaEntry, string url)
		{
			KalturaParams kparams = new KalturaParams();
			if (mediaEntry != null)
				kparams.Add("mediaEntry", mediaEntry.ToParams());
			kparams.AddStringIfNotNull("url", url);
			_Client.QueueServiceCall("media", "addFromUrl", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaMediaEntry)KalturaObjectFactory.Create(result);
		}

		public KalturaMediaEntry AddFromSearchResult()
		{
			return this.AddFromSearchResult(null);
		}

		public KalturaMediaEntry AddFromSearchResult(KalturaMediaEntry mediaEntry)
		{
			return this.AddFromSearchResult(mediaEntry, null);
		}

		public KalturaMediaEntry AddFromSearchResult(KalturaMediaEntry mediaEntry, KalturaSearchResult searchResult)
		{
			KalturaParams kparams = new KalturaParams();
			if (mediaEntry != null)
				kparams.Add("mediaEntry", mediaEntry.ToParams());
			if (searchResult != null)
				kparams.Add("searchResult", searchResult.ToParams());
			_Client.QueueServiceCall("media", "addFromSearchResult", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaMediaEntry)KalturaObjectFactory.Create(result);
		}

		public KalturaMediaEntry AddFromUploadedFile(KalturaMediaEntry mediaEntry, string uploadTokenId)
		{
			KalturaParams kparams = new KalturaParams();
			if (mediaEntry != null)
				kparams.Add("mediaEntry", mediaEntry.ToParams());
			kparams.AddStringIfNotNull("uploadTokenId", uploadTokenId);
			_Client.QueueServiceCall("media", "addFromUploadedFile", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaMediaEntry)KalturaObjectFactory.Create(result);
		}

		public KalturaMediaEntry AddFromRecordedWebcam(KalturaMediaEntry mediaEntry, string webcamTokenId)
		{
			KalturaParams kparams = new KalturaParams();
			if (mediaEntry != null)
				kparams.Add("mediaEntry", mediaEntry.ToParams());
			kparams.AddStringIfNotNull("webcamTokenId", webcamTokenId);
			_Client.QueueServiceCall("media", "addFromRecordedWebcam", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaMediaEntry)KalturaObjectFactory.Create(result);
		}

		public KalturaMediaEntry AddFromEntry(string sourceEntryId)
		{
			return this.AddFromEntry(sourceEntryId, null);
		}

		public KalturaMediaEntry AddFromEntry(string sourceEntryId, KalturaMediaEntry mediaEntry)
		{
			return this.AddFromEntry(sourceEntryId, mediaEntry, Int32.MinValue);
		}

		public KalturaMediaEntry AddFromEntry(string sourceEntryId, KalturaMediaEntry mediaEntry, int sourceFlavorParamsId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("sourceEntryId", sourceEntryId);
			if (mediaEntry != null)
				kparams.Add("mediaEntry", mediaEntry.ToParams());
			kparams.AddIntIfNotNull("sourceFlavorParamsId", sourceFlavorParamsId);
			_Client.QueueServiceCall("media", "addFromEntry", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaMediaEntry)KalturaObjectFactory.Create(result);
		}

		public KalturaMediaEntry AddFromFlavorAsset(string sourceFlavorAssetId)
		{
			return this.AddFromFlavorAsset(sourceFlavorAssetId, null);
		}

		public KalturaMediaEntry AddFromFlavorAsset(string sourceFlavorAssetId, KalturaMediaEntry mediaEntry)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("sourceFlavorAssetId", sourceFlavorAssetId);
			if (mediaEntry != null)
				kparams.Add("mediaEntry", mediaEntry.ToParams());
			_Client.QueueServiceCall("media", "addFromFlavorAsset", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaMediaEntry)KalturaObjectFactory.Create(result);
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
			_Client.QueueServiceCall("media", "convert", kparams);
			if (this._Client.IsMultiRequest)
				return 0;
			XmlElement result = _Client.DoQueue();
			return int.Parse(result.InnerText);
		}

		public KalturaMediaEntry Get(string entryId)
		{
			return this.Get(entryId, -1);
		}

		public KalturaMediaEntry Get(string entryId, int version)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			kparams.AddIntIfNotNull("version", version);
			_Client.QueueServiceCall("media", "get", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaMediaEntry)KalturaObjectFactory.Create(result);
		}

		public KalturaMediaEntry Update(string entryId, KalturaMediaEntry mediaEntry)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			if (mediaEntry != null)
				kparams.Add("mediaEntry", mediaEntry.ToParams());
			_Client.QueueServiceCall("media", "update", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaMediaEntry)KalturaObjectFactory.Create(result);
		}

		public KalturaMediaEntry UpdateContent(string entryId, KalturaResource resource)
		{
			return this.UpdateContent(entryId, resource, Int32.MinValue);
		}

		public KalturaMediaEntry UpdateContent(string entryId, KalturaResource resource, int conversionProfileId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			if (resource != null)
				kparams.Add("resource", resource.ToParams());
			kparams.AddIntIfNotNull("conversionProfileId", conversionProfileId);
			_Client.QueueServiceCall("media", "updateContent", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaMediaEntry)KalturaObjectFactory.Create(result);
		}

		public void Delete(string entryId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			_Client.QueueServiceCall("media", "delete", kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public KalturaMediaEntry ApproveReplace(string entryId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			_Client.QueueServiceCall("media", "approveReplace", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaMediaEntry)KalturaObjectFactory.Create(result);
		}

		public KalturaMediaEntry CancelReplace(string entryId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			_Client.QueueServiceCall("media", "cancelReplace", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaMediaEntry)KalturaObjectFactory.Create(result);
		}

		public KalturaMediaListResponse List()
		{
			return this.List(null);
		}

		public KalturaMediaListResponse List(KalturaMediaEntryFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaMediaListResponse List(KalturaMediaEntryFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			if (filter != null)
				kparams.Add("filter", filter.ToParams());
			if (pager != null)
				kparams.Add("pager", pager.ToParams());
			_Client.QueueServiceCall("media", "list", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaMediaListResponse)KalturaObjectFactory.Create(result);
		}

		public int Count()
		{
			return this.Count(null);
		}

		public int Count(KalturaMediaEntryFilter filter)
		{
			KalturaParams kparams = new KalturaParams();
			if (filter != null)
				kparams.Add("filter", filter.ToParams());
			_Client.QueueServiceCall("media", "count", kparams);
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
			_Client.QueueServiceCall("media", "upload", kparams, kfiles);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return result.InnerText;
		}

		public KalturaMediaEntry UpdateThumbnail(string entryId, int timeOffset)
		{
			return this.UpdateThumbnail(entryId, timeOffset, Int32.MinValue);
		}

		public KalturaMediaEntry UpdateThumbnail(string entryId, int timeOffset, int flavorParamsId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			kparams.AddIntIfNotNull("timeOffset", timeOffset);
			kparams.AddIntIfNotNull("flavorParamsId", flavorParamsId);
			_Client.QueueServiceCall("media", "updateThumbnail", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaMediaEntry)KalturaObjectFactory.Create(result);
		}

		public KalturaMediaEntry UpdateThumbnailFromSourceEntry(string entryId, string sourceEntryId, int timeOffset)
		{
			return this.UpdateThumbnailFromSourceEntry(entryId, sourceEntryId, timeOffset, Int32.MinValue);
		}

		public KalturaMediaEntry UpdateThumbnailFromSourceEntry(string entryId, string sourceEntryId, int timeOffset, int flavorParamsId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			kparams.AddStringIfNotNull("sourceEntryId", sourceEntryId);
			kparams.AddIntIfNotNull("timeOffset", timeOffset);
			kparams.AddIntIfNotNull("flavorParamsId", flavorParamsId);
			_Client.QueueServiceCall("media", "updateThumbnailFromSourceEntry", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaMediaEntry)KalturaObjectFactory.Create(result);
		}

		public KalturaMediaEntry UpdateThumbnailJpeg(string entryId, FileStream fileData)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			KalturaFiles kfiles = new KalturaFiles();
			kfiles.Add("fileData", fileData);
			_Client.QueueServiceCall("media", "updateThumbnailJpeg", kparams, kfiles);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaMediaEntry)KalturaObjectFactory.Create(result);
		}

		public KalturaBaseEntry UpdateThumbnailFromUrl(string entryId, string url)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			kparams.AddStringIfNotNull("url", url);
			_Client.QueueServiceCall("media", "updateThumbnailFromUrl", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaBaseEntry)KalturaObjectFactory.Create(result);
		}

		public int RequestConversion(string entryId, string fileFormat)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			kparams.AddStringIfNotNull("fileFormat", fileFormat);
			_Client.QueueServiceCall("media", "requestConversion", kparams);
			if (this._Client.IsMultiRequest)
				return 0;
			XmlElement result = _Client.DoQueue();
			return int.Parse(result.InnerText);
		}

		public void Flag(KalturaModerationFlag moderationFlag)
		{
			KalturaParams kparams = new KalturaParams();
			if (moderationFlag != null)
				kparams.Add("moderationFlag", moderationFlag.ToParams());
			_Client.QueueServiceCall("media", "flag", kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public void Reject(string entryId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			_Client.QueueServiceCall("media", "reject", kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public void Approve(string entryId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			_Client.QueueServiceCall("media", "approve", kparams);
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
			_Client.QueueServiceCall("media", "listFlags", kparams);
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
			_Client.QueueServiceCall("media", "anonymousRank", kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}
	}
}
