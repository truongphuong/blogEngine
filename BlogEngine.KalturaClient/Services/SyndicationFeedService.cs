using System;
using System.Xml;
using System.Collections.Generic;
using System.IO;

namespace Kaltura
{

	public class KalturaSyndicationFeedService : KalturaServiceBase
	{
	public KalturaSyndicationFeedService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaBaseSyndicationFeed Add(KalturaBaseSyndicationFeed syndicationFeed)
		{
			KalturaParams kparams = new KalturaParams();
			if (syndicationFeed != null)
				kparams.Add("syndicationFeed", syndicationFeed.ToParams());
			_Client.QueueServiceCall("syndicationfeed", "add", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaBaseSyndicationFeed)KalturaObjectFactory.Create(result);
		}

		public KalturaBaseSyndicationFeed Get(string id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("id", id);
			_Client.QueueServiceCall("syndicationfeed", "get", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaBaseSyndicationFeed)KalturaObjectFactory.Create(result);
		}

		public KalturaBaseSyndicationFeed Update(string id, KalturaBaseSyndicationFeed syndicationFeed)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("id", id);
			if (syndicationFeed != null)
				kparams.Add("syndicationFeed", syndicationFeed.ToParams());
			_Client.QueueServiceCall("syndicationfeed", "update", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaBaseSyndicationFeed)KalturaObjectFactory.Create(result);
		}

		public void Delete(string id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("id", id);
			_Client.QueueServiceCall("syndicationfeed", "delete", kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public KalturaBaseSyndicationFeedListResponse List()
		{
			return this.List(null);
		}

		public KalturaBaseSyndicationFeedListResponse List(KalturaBaseSyndicationFeedFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaBaseSyndicationFeedListResponse List(KalturaBaseSyndicationFeedFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			if (filter != null)
				kparams.Add("filter", filter.ToParams());
			if (pager != null)
				kparams.Add("pager", pager.ToParams());
			_Client.QueueServiceCall("syndicationfeed", "list", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaBaseSyndicationFeedListResponse)KalturaObjectFactory.Create(result);
		}

		public KalturaSyndicationFeedEntryCount GetEntryCount(string feedId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("feedId", feedId);
			_Client.QueueServiceCall("syndicationfeed", "getEntryCount", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaSyndicationFeedEntryCount)KalturaObjectFactory.Create(result);
		}

		public string RequestConversion(string feedId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("feedId", feedId);
			_Client.QueueServiceCall("syndicationfeed", "requestConversion", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return result.InnerText;
		}
	}
}
