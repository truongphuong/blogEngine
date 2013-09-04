using System;
using System.Xml;
using System.Collections.Generic;
using System.IO;

namespace Kaltura
{

	public class KalturaCategoryService : KalturaServiceBase
	{
	public KalturaCategoryService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaCategory Add(KalturaCategory category)
		{
			KalturaParams kparams = new KalturaParams();
			if (category != null)
				kparams.Add("category", category.ToParams());
			_Client.QueueServiceCall("category", "add", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaCategory)KalturaObjectFactory.Create(result);
		}

		public KalturaCategory Get(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			_Client.QueueServiceCall("category", "get", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaCategory)KalturaObjectFactory.Create(result);
		}

		public KalturaCategory Update(int id, KalturaCategory category)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			if (category != null)
				kparams.Add("category", category.ToParams());
			_Client.QueueServiceCall("category", "update", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaCategory)KalturaObjectFactory.Create(result);
		}

		public void Delete(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			_Client.QueueServiceCall("category", "delete", kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public KalturaCategoryListResponse List()
		{
			return this.List(null);
		}

		public KalturaCategoryListResponse List(KalturaCategoryFilter filter)
		{
			KalturaParams kparams = new KalturaParams();
			if (filter != null)
				kparams.Add("filter", filter.ToParams());
			_Client.QueueServiceCall("category", "list", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaCategoryListResponse)KalturaObjectFactory.Create(result);
		}
	}
}
