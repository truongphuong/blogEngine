using System;
using System.Xml;
using System.Collections.Generic;
using System.IO;

namespace Kaltura
{

	public class KalturaMetadataService : KalturaServiceBase
	{
	public KalturaMetadataService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaMetadataListResponse List()
		{
			return this.List(null);
		}

		public KalturaMetadataListResponse List(KalturaMetadataFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaMetadataListResponse List(KalturaMetadataFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			if (filter != null)
				kparams.Add("filter", filter.ToParams());
			if (pager != null)
				kparams.Add("pager", pager.ToParams());
			_Client.QueueServiceCall("metadata_metadata", "list", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaMetadataListResponse)KalturaObjectFactory.Create(result);
		}

		public KalturaMetadata Add(int metadataProfileId, KalturaMetadataObjectType objectType, string objectId, string xmlData)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("metadataProfileId", metadataProfileId);
			kparams.AddStringEnumIfNotNull("objectType", objectType);
			kparams.AddStringIfNotNull("objectId", objectId);
			kparams.AddStringIfNotNull("xmlData", xmlData);
			_Client.QueueServiceCall("metadata_metadata", "add", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaMetadata)KalturaObjectFactory.Create(result);
		}

		public KalturaMetadata AddFromFile(int metadataProfileId, KalturaMetadataObjectType objectType, string objectId, FileStream xmlFile)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("metadataProfileId", metadataProfileId);
			kparams.AddStringEnumIfNotNull("objectType", objectType);
			kparams.AddStringIfNotNull("objectId", objectId);
			KalturaFiles kfiles = new KalturaFiles();
			kfiles.Add("xmlFile", xmlFile);
			_Client.QueueServiceCall("metadata_metadata", "addFromFile", kparams, kfiles);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaMetadata)KalturaObjectFactory.Create(result);
		}

		public KalturaMetadata AddFromUrl(int metadataProfileId, KalturaMetadataObjectType objectType, string objectId, string url)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("metadataProfileId", metadataProfileId);
			kparams.AddStringEnumIfNotNull("objectType", objectType);
			kparams.AddStringIfNotNull("objectId", objectId);
			kparams.AddStringIfNotNull("url", url);
			_Client.QueueServiceCall("metadata_metadata", "addFromUrl", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaMetadata)KalturaObjectFactory.Create(result);
		}

		public KalturaMetadata AddFromBulk(int metadataProfileId, KalturaMetadataObjectType objectType, string objectId, string url)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("metadataProfileId", metadataProfileId);
			kparams.AddStringEnumIfNotNull("objectType", objectType);
			kparams.AddStringIfNotNull("objectId", objectId);
			kparams.AddStringIfNotNull("url", url);
			_Client.QueueServiceCall("metadata_metadata", "addFromBulk", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaMetadata)KalturaObjectFactory.Create(result);
		}

		public void Delete(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			_Client.QueueServiceCall("metadata_metadata", "delete", kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public void Invalidate(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			_Client.QueueServiceCall("metadata_metadata", "invalidate", kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public KalturaMetadata Get(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			_Client.QueueServiceCall("metadata_metadata", "get", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaMetadata)KalturaObjectFactory.Create(result);
		}

		public KalturaMetadata Update(int id)
		{
			return this.Update(id, null);
		}

		public KalturaMetadata Update(int id, string xmlData)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			kparams.AddStringIfNotNull("xmlData", xmlData);
			_Client.QueueServiceCall("metadata_metadata", "update", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaMetadata)KalturaObjectFactory.Create(result);
		}

		public KalturaMetadata UpdateFromFile(int id)
		{
			return this.UpdateFromFile(id, null);
		}

		public KalturaMetadata UpdateFromFile(int id, FileStream xmlFile)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			KalturaFiles kfiles = new KalturaFiles();
			kfiles.Add("xmlFile", xmlFile);
			_Client.QueueServiceCall("metadata_metadata", "updateFromFile", kparams, kfiles);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaMetadata)KalturaObjectFactory.Create(result);
		}
	}
}
