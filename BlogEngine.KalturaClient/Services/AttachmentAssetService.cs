using System;
using System.Xml;
using System.Collections.Generic;
using System.IO;

namespace Kaltura
{

	public class KalturaAttachmentAssetService : KalturaServiceBase
	{
	public KalturaAttachmentAssetService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaAttachmentAsset Add(string entryId, KalturaAttachmentAsset attachmentAsset)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			if (attachmentAsset != null)
				kparams.Add("attachmentAsset", attachmentAsset.ToParams());
			_Client.QueueServiceCall("attachment_attachmentasset", "add", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaAttachmentAsset)KalturaObjectFactory.Create(result);
		}

		public KalturaAttachmentAsset SetContent(string id, KalturaContentResource contentResource)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("id", id);
			if (contentResource != null)
				kparams.Add("contentResource", contentResource.ToParams());
			_Client.QueueServiceCall("attachment_attachmentasset", "setContent", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaAttachmentAsset)KalturaObjectFactory.Create(result);
		}

		public KalturaAttachmentAsset Update(string id, KalturaAttachmentAsset attachmentAsset)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("id", id);
			if (attachmentAsset != null)
				kparams.Add("attachmentAsset", attachmentAsset.ToParams());
			_Client.QueueServiceCall("attachment_attachmentasset", "update", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaAttachmentAsset)KalturaObjectFactory.Create(result);
		}

		public string GetUrl(string id)
		{
			return this.GetUrl(id, Int32.MinValue);
		}

		public string GetUrl(string id, int storageId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("id", id);
			kparams.AddIntIfNotNull("storageId", storageId);
			_Client.QueueServiceCall("attachment_attachmentasset", "getUrl", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return result.InnerText;
		}

		public KalturaRemotePathListResponse GetRemotePaths(string id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("id", id);
			_Client.QueueServiceCall("attachment_attachmentasset", "getRemotePaths", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaRemotePathListResponse)KalturaObjectFactory.Create(result);
		}

		public KalturaAttachmentAsset Get(string attachmentAssetId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("attachmentAssetId", attachmentAssetId);
			_Client.QueueServiceCall("attachment_attachmentasset", "get", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaAttachmentAsset)KalturaObjectFactory.Create(result);
		}

		public KalturaAttachmentAssetListResponse List()
		{
			return this.List(null);
		}

		public KalturaAttachmentAssetListResponse List(KalturaAssetFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaAttachmentAssetListResponse List(KalturaAssetFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			if (filter != null)
				kparams.Add("filter", filter.ToParams());
			if (pager != null)
				kparams.Add("pager", pager.ToParams());
			_Client.QueueServiceCall("attachment_attachmentasset", "list", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaAttachmentAssetListResponse)KalturaObjectFactory.Create(result);
		}

		public void Delete(string attachmentAssetId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("attachmentAssetId", attachmentAssetId);
			_Client.QueueServiceCall("attachment_attachmentasset", "delete", kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}
	}
}
