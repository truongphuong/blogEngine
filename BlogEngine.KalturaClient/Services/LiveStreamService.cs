using System;
using System.Xml;
using System.Collections.Generic;
using System.IO;

namespace Kaltura
{

	public class KalturaLiveStreamService : KalturaServiceBase
	{
	public KalturaLiveStreamService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaLiveStreamAdminEntry Add(KalturaLiveStreamAdminEntry liveStreamEntry)
		{
			return this.Add(liveStreamEntry, (KalturaSourceType)(Int32.MinValue));
		}

		public KalturaLiveStreamAdminEntry Add(KalturaLiveStreamAdminEntry liveStreamEntry, KalturaSourceType sourceType)
		{
			KalturaParams kparams = new KalturaParams();
			if (liveStreamEntry != null)
				kparams.Add("liveStreamEntry", liveStreamEntry.ToParams());
			kparams.AddEnumIfNotNull("sourceType", sourceType);
			_Client.QueueServiceCall("livestream", "add", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaLiveStreamAdminEntry)KalturaObjectFactory.Create(result);
		}

		public KalturaLiveStreamEntry Get(string entryId)
		{
			return this.Get(entryId, -1);
		}

		public KalturaLiveStreamEntry Get(string entryId, int version)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			kparams.AddIntIfNotNull("version", version);
			_Client.QueueServiceCall("livestream", "get", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaLiveStreamEntry)KalturaObjectFactory.Create(result);
		}

		public KalturaLiveStreamAdminEntry Update(string entryId, KalturaLiveStreamAdminEntry liveStreamEntry)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			if (liveStreamEntry != null)
				kparams.Add("liveStreamEntry", liveStreamEntry.ToParams());
			_Client.QueueServiceCall("livestream", "update", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaLiveStreamAdminEntry)KalturaObjectFactory.Create(result);
		}

		public void Delete(string entryId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			_Client.QueueServiceCall("livestream", "delete", kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public KalturaLiveStreamListResponse List()
		{
			return this.List(null);
		}

		public KalturaLiveStreamListResponse List(KalturaLiveStreamEntryFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaLiveStreamListResponse List(KalturaLiveStreamEntryFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			if (filter != null)
				kparams.Add("filter", filter.ToParams());
			if (pager != null)
				kparams.Add("pager", pager.ToParams());
			_Client.QueueServiceCall("livestream", "list", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaLiveStreamListResponse)KalturaObjectFactory.Create(result);
		}

		public KalturaLiveStreamEntry UpdateOfflineThumbnailJpeg(string entryId, FileStream fileData)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			KalturaFiles kfiles = new KalturaFiles();
			kfiles.Add("fileData", fileData);
			_Client.QueueServiceCall("livestream", "updateOfflineThumbnailJpeg", kparams, kfiles);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaLiveStreamEntry)KalturaObjectFactory.Create(result);
		}

		public KalturaLiveStreamEntry UpdateOfflineThumbnailFromUrl(string entryId, string url)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			kparams.AddStringIfNotNull("url", url);
			_Client.QueueServiceCall("livestream", "updateOfflineThumbnailFromUrl", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaLiveStreamEntry)KalturaObjectFactory.Create(result);
		}
	}
}
