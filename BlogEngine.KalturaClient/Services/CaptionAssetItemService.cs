using System;
using System.Xml;
using System.Collections.Generic;
using System.IO;

namespace Kaltura
{

	public class KalturaCaptionAssetItemService : KalturaServiceBase
	{
	public KalturaCaptionAssetItemService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaCaptionAssetItemListResponse Search()
		{
			return this.Search(null);
		}

		public KalturaCaptionAssetItemListResponse Search(KalturaBaseEntryFilter entryFilter)
		{
			return this.Search(entryFilter, null);
		}

		public KalturaCaptionAssetItemListResponse Search(KalturaBaseEntryFilter entryFilter, KalturaCaptionAssetItemFilter captionAssetItemFilter)
		{
			return this.Search(entryFilter, captionAssetItemFilter, null);
		}

		public KalturaCaptionAssetItemListResponse Search(KalturaBaseEntryFilter entryFilter, KalturaCaptionAssetItemFilter captionAssetItemFilter, KalturaFilterPager captionAssetItemPager)
		{
			KalturaParams kparams = new KalturaParams();
			if (entryFilter != null)
				kparams.Add("entryFilter", entryFilter.ToParams());
			if (captionAssetItemFilter != null)
				kparams.Add("captionAssetItemFilter", captionAssetItemFilter.ToParams());
			if (captionAssetItemPager != null)
				kparams.Add("captionAssetItemPager", captionAssetItemPager.ToParams());
			_Client.QueueServiceCall("captionsearch_captionassetitem", "search", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaCaptionAssetItemListResponse)KalturaObjectFactory.Create(result);
		}
	}
}
