using System;
using System.Xml;
using System.Collections.Generic;
using System.IO;

namespace Kaltura
{

	public class KalturaCuePointService : KalturaServiceBase
	{
	public KalturaCuePointService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaCuePoint Add(KalturaCuePoint cuePoint)
		{
			KalturaParams kparams = new KalturaParams();
			if (cuePoint != null)
				kparams.Add("cuePoint", cuePoint.ToParams());
			_Client.QueueServiceCall("cuepoint_cuepoint", "add", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaCuePoint)KalturaObjectFactory.Create(result);
		}

		public KalturaCuePointListResponse AddFromBulk(FileStream fileData)
		{
			KalturaParams kparams = new KalturaParams();
			KalturaFiles kfiles = new KalturaFiles();
			kfiles.Add("fileData", fileData);
			_Client.QueueServiceCall("cuepoint_cuepoint", "addFromBulk", kparams, kfiles);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaCuePointListResponse)KalturaObjectFactory.Create(result);
		}

		public KalturaCuePoint Get(string id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("id", id);
			_Client.QueueServiceCall("cuepoint_cuepoint", "get", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaCuePoint)KalturaObjectFactory.Create(result);
		}

		public KalturaCuePointListResponse List()
		{
			return this.List(null);
		}

		public KalturaCuePointListResponse List(KalturaCuePointFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaCuePointListResponse List(KalturaCuePointFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			if (filter != null)
				kparams.Add("filter", filter.ToParams());
			if (pager != null)
				kparams.Add("pager", pager.ToParams());
			_Client.QueueServiceCall("cuepoint_cuepoint", "list", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaCuePointListResponse)KalturaObjectFactory.Create(result);
		}

		public int Count()
		{
			return this.Count(null);
		}

		public int Count(KalturaCuePointFilter filter)
		{
			KalturaParams kparams = new KalturaParams();
			if (filter != null)
				kparams.Add("filter", filter.ToParams());
			_Client.QueueServiceCall("cuepoint_cuepoint", "count", kparams);
			if (this._Client.IsMultiRequest)
				return 0;
			XmlElement result = _Client.DoQueue();
			return int.Parse(result.InnerText);
		}

		public KalturaCuePoint Update(string id, KalturaCuePoint cuePoint)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("id", id);
			if (cuePoint != null)
				kparams.Add("cuePoint", cuePoint.ToParams());
			_Client.QueueServiceCall("cuepoint_cuepoint", "update", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaCuePoint)KalturaObjectFactory.Create(result);
		}

		public void Delete(string id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("id", id);
			_Client.QueueServiceCall("cuepoint_cuepoint", "delete", kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}
	}
}
