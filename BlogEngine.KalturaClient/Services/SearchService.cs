using System;
using System.Xml;
using System.Collections.Generic;
using System.IO;

namespace Kaltura
{

	public class KalturaSearchService : KalturaServiceBase
	{
	public KalturaSearchService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaSearchResultResponse Search(KalturaSearch search)
		{
			return this.Search(search, null);
		}

		public KalturaSearchResultResponse Search(KalturaSearch search, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			if (search != null)
				kparams.Add("search", search.ToParams());
			if (pager != null)
				kparams.Add("pager", pager.ToParams());
			_Client.QueueServiceCall("search", "search", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaSearchResultResponse)KalturaObjectFactory.Create(result);
		}

		public KalturaSearchResult GetMediaInfo(KalturaSearchResult searchResult)
		{
			KalturaParams kparams = new KalturaParams();
			if (searchResult != null)
				kparams.Add("searchResult", searchResult.ToParams());
			_Client.QueueServiceCall("search", "getMediaInfo", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaSearchResult)KalturaObjectFactory.Create(result);
		}

		public KalturaSearchResult SearchUrl(KalturaMediaType mediaType, string url)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddEnumIfNotNull("mediaType", mediaType);
			kparams.AddStringIfNotNull("url", url);
			_Client.QueueServiceCall("search", "searchUrl", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaSearchResult)KalturaObjectFactory.Create(result);
		}

		public KalturaSearchAuthData ExternalLogin(KalturaSearchProviderType searchSource, string userName, string password)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddEnumIfNotNull("searchSource", searchSource);
			kparams.AddStringIfNotNull("userName", userName);
			kparams.AddStringIfNotNull("password", password);
			_Client.QueueServiceCall("search", "externalLogin", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaSearchAuthData)KalturaObjectFactory.Create(result);
		}
	}
}
