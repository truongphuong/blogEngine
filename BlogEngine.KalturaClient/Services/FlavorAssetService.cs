using System;
using System.Xml;
using System.Collections.Generic;
using System.IO;

namespace Kaltura
{

	public class KalturaFlavorAssetService : KalturaServiceBase
	{
	public KalturaFlavorAssetService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaFlavorAsset Add(string entryId, KalturaFlavorAsset flavorAsset)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			if (flavorAsset != null)
				kparams.Add("flavorAsset", flavorAsset.ToParams());
			_Client.QueueServiceCall("flavorasset", "add", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaFlavorAsset)KalturaObjectFactory.Create(result);
		}

		public KalturaFlavorAsset Update(string id, KalturaFlavorAsset flavorAsset)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("id", id);
			if (flavorAsset != null)
				kparams.Add("flavorAsset", flavorAsset.ToParams());
			_Client.QueueServiceCall("flavorasset", "update", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaFlavorAsset)KalturaObjectFactory.Create(result);
		}

		public KalturaFlavorAsset SetContent(string id, KalturaContentResource contentResource)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("id", id);
			if (contentResource != null)
				kparams.Add("contentResource", contentResource.ToParams());
			_Client.QueueServiceCall("flavorasset", "setContent", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaFlavorAsset)KalturaObjectFactory.Create(result);
		}

		public KalturaFlavorAsset Get(string id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("id", id);
			_Client.QueueServiceCall("flavorasset", "get", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaFlavorAsset)KalturaObjectFactory.Create(result);
		}

		public IList<KalturaFlavorAsset> GetByEntryId(string entryId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			_Client.QueueServiceCall("flavorasset", "getByEntryId", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			IList<KalturaFlavorAsset> list = new List<KalturaFlavorAsset>();
			foreach(XmlElement node in result.ChildNodes)
			{
				list.Add((KalturaFlavorAsset)KalturaObjectFactory.Create(node));
			}
			return list;
		}

		public KalturaFlavorAssetListResponse List()
		{
			return this.List(null);
		}

		public KalturaFlavorAssetListResponse List(KalturaAssetFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaFlavorAssetListResponse List(KalturaAssetFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			if (filter != null)
				kparams.Add("filter", filter.ToParams());
			if (pager != null)
				kparams.Add("pager", pager.ToParams());
			_Client.QueueServiceCall("flavorasset", "list", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaFlavorAssetListResponse)KalturaObjectFactory.Create(result);
		}

		public IList<KalturaFlavorAsset> GetWebPlayableByEntryId(string entryId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			_Client.QueueServiceCall("flavorasset", "getWebPlayableByEntryId", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			IList<KalturaFlavorAsset> list = new List<KalturaFlavorAsset>();
			foreach(XmlElement node in result.ChildNodes)
			{
				list.Add((KalturaFlavorAsset)KalturaObjectFactory.Create(node));
			}
			return list;
		}

		public void Convert(string entryId, int flavorParamsId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			kparams.AddIntIfNotNull("flavorParamsId", flavorParamsId);
			_Client.QueueServiceCall("flavorasset", "convert", kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public void Reconvert(string id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("id", id);
			_Client.QueueServiceCall("flavorasset", "reconvert", kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public void Delete(string id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("id", id);
			_Client.QueueServiceCall("flavorasset", "delete", kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
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
			_Client.QueueServiceCall("flavorasset", "getUrl", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return result.InnerText;
		}

		public KalturaRemotePathListResponse GetRemotePaths(string id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("id", id);
			_Client.QueueServiceCall("flavorasset", "getRemotePaths", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaRemotePathListResponse)KalturaObjectFactory.Create(result);
		}

		public string GetDownloadUrl(string id)
		{
			return this.GetDownloadUrl(id, false);
		}

		public string GetDownloadUrl(string id, bool useCdn)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("id", id);
			kparams.AddBoolIfNotNull("useCdn", useCdn);
			_Client.QueueServiceCall("flavorasset", "getDownloadUrl", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return result.InnerText;
		}

		public IList<KalturaFlavorAssetWithParams> GetFlavorAssetsWithParams(string entryId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			_Client.QueueServiceCall("flavorasset", "getFlavorAssetsWithParams", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			IList<KalturaFlavorAssetWithParams> list = new List<KalturaFlavorAssetWithParams>();
			foreach(XmlElement node in result.ChildNodes)
			{
				list.Add((KalturaFlavorAssetWithParams)KalturaObjectFactory.Create(node));
			}
			return list;
		}
	}
}
