using System;
using System.Xml;
using System.Collections.Generic;
using System.IO;

namespace Kaltura
{

	public class KalturaDataService : KalturaServiceBase
	{
	public KalturaDataService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaDataEntry Add(KalturaDataEntry dataEntry)
		{
			KalturaParams kparams = new KalturaParams();
			if (dataEntry != null)
				kparams.Add("dataEntry", dataEntry.ToParams());
			_Client.QueueServiceCall("data", "add", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaDataEntry)KalturaObjectFactory.Create(result);
		}

		public KalturaDataEntry Get(string entryId)
		{
			return this.Get(entryId, -1);
		}

		public KalturaDataEntry Get(string entryId, int version)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			kparams.AddIntIfNotNull("version", version);
			_Client.QueueServiceCall("data", "get", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaDataEntry)KalturaObjectFactory.Create(result);
		}

		public KalturaDataEntry Update(string entryId, KalturaDataEntry documentEntry)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			if (documentEntry != null)
				kparams.Add("documentEntry", documentEntry.ToParams());
			_Client.QueueServiceCall("data", "update", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaDataEntry)KalturaObjectFactory.Create(result);
		}

		public void Delete(string entryId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			_Client.QueueServiceCall("data", "delete", kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public KalturaDataListResponse List()
		{
			return this.List(null);
		}

		public KalturaDataListResponse List(KalturaDataEntryFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaDataListResponse List(KalturaDataEntryFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			if (filter != null)
				kparams.Add("filter", filter.ToParams());
			if (pager != null)
				kparams.Add("pager", pager.ToParams());
			_Client.QueueServiceCall("data", "list", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaDataListResponse)KalturaObjectFactory.Create(result);
		}
	}
}
