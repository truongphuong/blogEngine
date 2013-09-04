using System;
using System.Xml;
using System.Collections.Generic;
using System.IO;

namespace Kaltura
{

	public class KalturaThumbParamsService : KalturaServiceBase
	{
	public KalturaThumbParamsService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaThumbParams Add(KalturaThumbParams thumbParams)
		{
			KalturaParams kparams = new KalturaParams();
			if (thumbParams != null)
				kparams.Add("thumbParams", thumbParams.ToParams());
			_Client.QueueServiceCall("thumbparams", "add", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaThumbParams)KalturaObjectFactory.Create(result);
		}

		public KalturaThumbParams Get(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			_Client.QueueServiceCall("thumbparams", "get", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaThumbParams)KalturaObjectFactory.Create(result);
		}

		public KalturaThumbParams Update(int id, KalturaThumbParams thumbParams)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			if (thumbParams != null)
				kparams.Add("thumbParams", thumbParams.ToParams());
			_Client.QueueServiceCall("thumbparams", "update", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaThumbParams)KalturaObjectFactory.Create(result);
		}

		public void Delete(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			_Client.QueueServiceCall("thumbparams", "delete", kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public KalturaThumbParamsListResponse List()
		{
			return this.List(null);
		}

		public KalturaThumbParamsListResponse List(KalturaThumbParamsFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaThumbParamsListResponse List(KalturaThumbParamsFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			if (filter != null)
				kparams.Add("filter", filter.ToParams());
			if (pager != null)
				kparams.Add("pager", pager.ToParams());
			_Client.QueueServiceCall("thumbparams", "list", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaThumbParamsListResponse)KalturaObjectFactory.Create(result);
		}

		public IList<KalturaThumbParams> GetByConversionProfileId(int conversionProfileId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("conversionProfileId", conversionProfileId);
			_Client.QueueServiceCall("thumbparams", "getByConversionProfileId", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			IList<KalturaThumbParams> list = new List<KalturaThumbParams>();
			foreach(XmlElement node in result.ChildNodes)
			{
				list.Add((KalturaThumbParams)KalturaObjectFactory.Create(node));
			}
			return list;
		}
	}
}
