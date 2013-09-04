using System;
using System.Xml;
using System.Collections.Generic;
using System.IO;

namespace Kaltura
{

	public class KalturaCaptionAssetService : KalturaServiceBase
	{
	public KalturaCaptionAssetService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaCaptionAsset Add(string entryId, KalturaCaptionAsset captionAsset)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			if (captionAsset != null)
				kparams.Add("captionAsset", captionAsset.ToParams());
			_Client.QueueServiceCall("caption_captionasset", "add", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaCaptionAsset)KalturaObjectFactory.Create(result);
		}

		public KalturaCaptionAsset SetContent(string id, KalturaContentResource contentResource)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("id", id);
			if (contentResource != null)
				kparams.Add("contentResource", contentResource.ToParams());
			_Client.QueueServiceCall("caption_captionasset", "setContent", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaCaptionAsset)KalturaObjectFactory.Create(result);
		}

		public KalturaCaptionAsset Update(string id, KalturaCaptionAsset captionAsset)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("id", id);
			if (captionAsset != null)
				kparams.Add("captionAsset", captionAsset.ToParams());
			_Client.QueueServiceCall("caption_captionasset", "update", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaCaptionAsset)KalturaObjectFactory.Create(result);
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
			_Client.QueueServiceCall("caption_captionasset", "getUrl", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return result.InnerText;
		}

		public KalturaRemotePathListResponse GetRemotePaths(string id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("id", id);
			_Client.QueueServiceCall("caption_captionasset", "getRemotePaths", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaRemotePathListResponse)KalturaObjectFactory.Create(result);
		}

		public void SetAsDefault(string captionAssetId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("captionAssetId", captionAssetId);
			_Client.QueueServiceCall("caption_captionasset", "setAsDefault", kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public KalturaCaptionAsset Get(string captionAssetId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("captionAssetId", captionAssetId);
			_Client.QueueServiceCall("caption_captionasset", "get", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaCaptionAsset)KalturaObjectFactory.Create(result);
		}

		public KalturaCaptionAssetListResponse List()
		{
			return this.List(null);
		}

		public KalturaCaptionAssetListResponse List(KalturaAssetFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaCaptionAssetListResponse List(KalturaAssetFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			if (filter != null)
				kparams.Add("filter", filter.ToParams());
			if (pager != null)
				kparams.Add("pager", pager.ToParams());
			_Client.QueueServiceCall("caption_captionasset", "list", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaCaptionAssetListResponse)KalturaObjectFactory.Create(result);
		}

		public void Delete(string captionAssetId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("captionAssetId", captionAssetId);
			_Client.QueueServiceCall("caption_captionasset", "delete", kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}
	}
}
