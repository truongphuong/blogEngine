using System;
using System.Xml;
using System.Collections.Generic;
using System.IO;

namespace Kaltura
{

	public class KalturaShortLinkService : KalturaServiceBase
	{
	public KalturaShortLinkService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaShortLinkListResponse List()
		{
			return this.List(null);
		}

		public KalturaShortLinkListResponse List(KalturaShortLinkFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaShortLinkListResponse List(KalturaShortLinkFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			if (filter != null)
				kparams.Add("filter", filter.ToParams());
			if (pager != null)
				kparams.Add("pager", pager.ToParams());
			_Client.QueueServiceCall("shortlink_shortlink", "list", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaShortLinkListResponse)KalturaObjectFactory.Create(result);
		}

		public KalturaShortLink Add(KalturaShortLink shortLink)
		{
			KalturaParams kparams = new KalturaParams();
			if (shortLink != null)
				kparams.Add("shortLink", shortLink.ToParams());
			_Client.QueueServiceCall("shortlink_shortlink", "add", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaShortLink)KalturaObjectFactory.Create(result);
		}

		public KalturaShortLink Get(string id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("id", id);
			_Client.QueueServiceCall("shortlink_shortlink", "get", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaShortLink)KalturaObjectFactory.Create(result);
		}

		public KalturaShortLink Update(string id, KalturaShortLink shortLink)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("id", id);
			if (shortLink != null)
				kparams.Add("shortLink", shortLink.ToParams());
			_Client.QueueServiceCall("shortlink_shortlink", "update", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaShortLink)KalturaObjectFactory.Create(result);
		}

		public KalturaShortLink Delete(string id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("id", id);
			_Client.QueueServiceCall("shortlink_shortlink", "delete", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaShortLink)KalturaObjectFactory.Create(result);
		}
	}
}
