using System;
using System.Xml;
using System.Collections.Generic;
using System.IO;

namespace Kaltura
{

	public class KalturaCaptionParamsService : KalturaServiceBase
	{
	public KalturaCaptionParamsService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaCaptionParams Add(KalturaCaptionParams captionParams)
		{
			KalturaParams kparams = new KalturaParams();
			if (captionParams != null)
				kparams.Add("captionParams", captionParams.ToParams());
			_Client.QueueServiceCall("caption_captionparams", "add", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaCaptionParams)KalturaObjectFactory.Create(result);
		}

		public KalturaCaptionParams Get(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			_Client.QueueServiceCall("caption_captionparams", "get", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaCaptionParams)KalturaObjectFactory.Create(result);
		}

		public KalturaCaptionParams Update(int id, KalturaCaptionParams captionParams)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			if (captionParams != null)
				kparams.Add("captionParams", captionParams.ToParams());
			_Client.QueueServiceCall("caption_captionparams", "update", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaCaptionParams)KalturaObjectFactory.Create(result);
		}

		public void Delete(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			_Client.QueueServiceCall("caption_captionparams", "delete", kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public KalturaCaptionParamsListResponse List()
		{
			return this.List(null);
		}

		public KalturaCaptionParamsListResponse List(KalturaCaptionParamsFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaCaptionParamsListResponse List(KalturaCaptionParamsFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			if (filter != null)
				kparams.Add("filter", filter.ToParams());
			if (pager != null)
				kparams.Add("pager", pager.ToParams());
			_Client.QueueServiceCall("caption_captionparams", "list", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaCaptionParamsListResponse)KalturaObjectFactory.Create(result);
		}
	}
}
