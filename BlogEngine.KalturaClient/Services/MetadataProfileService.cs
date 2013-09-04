using System;
using System.Xml;
using System.Collections.Generic;
using System.IO;

namespace Kaltura
{

	public class KalturaMetadataProfileService : KalturaServiceBase
	{
	public KalturaMetadataProfileService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaMetadataProfileListResponse List()
		{
			return this.List(null);
		}

		public KalturaMetadataProfileListResponse List(KalturaMetadataProfileFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaMetadataProfileListResponse List(KalturaMetadataProfileFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			if (filter != null)
				kparams.Add("filter", filter.ToParams());
			if (pager != null)
				kparams.Add("pager", pager.ToParams());
			_Client.QueueServiceCall("metadata_metadataprofile", "list", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaMetadataProfileListResponse)KalturaObjectFactory.Create(result);
		}

		public KalturaMetadataProfileFieldListResponse ListFields(int metadataProfileId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("metadataProfileId", metadataProfileId);
			_Client.QueueServiceCall("metadata_metadataprofile", "listFields", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaMetadataProfileFieldListResponse)KalturaObjectFactory.Create(result);
		}

		public KalturaMetadataProfile Add(KalturaMetadataProfile metadataProfile, string xsdData)
		{
			return this.Add(metadataProfile, xsdData, null);
		}

		public KalturaMetadataProfile Add(KalturaMetadataProfile metadataProfile, string xsdData, string viewsData)
		{
			KalturaParams kparams = new KalturaParams();
			if (metadataProfile != null)
				kparams.Add("metadataProfile", metadataProfile.ToParams());
			kparams.AddStringIfNotNull("xsdData", xsdData);
			kparams.AddStringIfNotNull("viewsData", viewsData);
			_Client.QueueServiceCall("metadata_metadataprofile", "add", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaMetadataProfile)KalturaObjectFactory.Create(result);
		}

		public KalturaMetadataProfile AddFromFile(KalturaMetadataProfile metadataProfile, FileStream xsdFile)
		{
			return this.AddFromFile(metadataProfile, xsdFile, null);
		}

		public KalturaMetadataProfile AddFromFile(KalturaMetadataProfile metadataProfile, FileStream xsdFile, FileStream viewsFile)
		{
			KalturaParams kparams = new KalturaParams();
			if (metadataProfile != null)
				kparams.Add("metadataProfile", metadataProfile.ToParams());
			KalturaFiles kfiles = new KalturaFiles();
			kfiles.Add("xsdFile", xsdFile);
			kfiles.Add("viewsFile", viewsFile);
			_Client.QueueServiceCall("metadata_metadataprofile", "addFromFile", kparams, kfiles);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaMetadataProfile)KalturaObjectFactory.Create(result);
		}

		public void Delete(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			_Client.QueueServiceCall("metadata_metadataprofile", "delete", kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public KalturaMetadataProfile Get(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			_Client.QueueServiceCall("metadata_metadataprofile", "get", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaMetadataProfile)KalturaObjectFactory.Create(result);
		}

		public KalturaMetadataProfile Update(int id, KalturaMetadataProfile metadataProfile)
		{
			return this.Update(id, metadataProfile, null);
		}

		public KalturaMetadataProfile Update(int id, KalturaMetadataProfile metadataProfile, string xsdData)
		{
			return this.Update(id, metadataProfile, xsdData, null);
		}

		public KalturaMetadataProfile Update(int id, KalturaMetadataProfile metadataProfile, string xsdData, string viewsData)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			if (metadataProfile != null)
				kparams.Add("metadataProfile", metadataProfile.ToParams());
			kparams.AddStringIfNotNull("xsdData", xsdData);
			kparams.AddStringIfNotNull("viewsData", viewsData);
			_Client.QueueServiceCall("metadata_metadataprofile", "update", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaMetadataProfile)KalturaObjectFactory.Create(result);
		}

		public KalturaMetadataProfile Revert(int id, int toVersion)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			kparams.AddIntIfNotNull("toVersion", toVersion);
			_Client.QueueServiceCall("metadata_metadataprofile", "revert", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaMetadataProfile)KalturaObjectFactory.Create(result);
		}

		public KalturaMetadataProfile UpdateDefinitionFromFile(int id, FileStream xsdFile)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			KalturaFiles kfiles = new KalturaFiles();
			kfiles.Add("xsdFile", xsdFile);
			_Client.QueueServiceCall("metadata_metadataprofile", "updateDefinitionFromFile", kparams, kfiles);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaMetadataProfile)KalturaObjectFactory.Create(result);
		}

		public KalturaMetadataProfile UpdateViewsFromFile(int id, FileStream viewsFile)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			KalturaFiles kfiles = new KalturaFiles();
			kfiles.Add("viewsFile", viewsFile);
			_Client.QueueServiceCall("metadata_metadataprofile", "updateViewsFromFile", kparams, kfiles);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaMetadataProfile)KalturaObjectFactory.Create(result);
		}
	}
}
