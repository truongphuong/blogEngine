using System;
using System.Xml;
using System.Collections.Generic;
using System.IO;

namespace Kaltura
{

	public class KalturaAnnotationService : KalturaServiceBase
	{
	public KalturaAnnotationService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaAnnotation Add(KalturaAnnotation annotation)
		{
			KalturaParams kparams = new KalturaParams();
			if (annotation != null)
				kparams.Add("annotation", annotation.ToParams());
			_Client.QueueServiceCall("annotation_annotation", "add", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaAnnotation)KalturaObjectFactory.Create(result);
		}

		public KalturaAnnotation Update(string id, KalturaAnnotation annotation)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("id", id);
			if (annotation != null)
				kparams.Add("annotation", annotation.ToParams());
			_Client.QueueServiceCall("annotation_annotation", "update", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaAnnotation)KalturaObjectFactory.Create(result);
		}

		public KalturaAnnotationListResponse List()
		{
			return this.List(null);
		}

		public KalturaAnnotationListResponse List(KalturaAnnotationFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaAnnotationListResponse List(KalturaAnnotationFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			if (filter != null)
				kparams.Add("filter", filter.ToParams());
			if (pager != null)
				kparams.Add("pager", pager.ToParams());
			_Client.QueueServiceCall("annotation_annotation", "list", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaAnnotationListResponse)KalturaObjectFactory.Create(result);
		}

		public KalturaCuePointListResponse AddFromBulk(FileStream fileData)
		{
			KalturaParams kparams = new KalturaParams();
			KalturaFiles kfiles = new KalturaFiles();
			kfiles.Add("fileData", fileData);
			_Client.QueueServiceCall("annotation_annotation", "addFromBulk", kparams, kfiles);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaCuePointListResponse)KalturaObjectFactory.Create(result);
		}

		public KalturaCuePoint Get(string id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("id", id);
			_Client.QueueServiceCall("annotation_annotation", "get", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaCuePoint)KalturaObjectFactory.Create(result);
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
			_Client.QueueServiceCall("annotation_annotation", "count", kparams);
			if (this._Client.IsMultiRequest)
				return 0;
			XmlElement result = _Client.DoQueue();
			return int.Parse(result.InnerText);
		}

		public void Delete(string id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("id", id);
			_Client.QueueServiceCall("annotation_annotation", "delete", kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}
	}
}
