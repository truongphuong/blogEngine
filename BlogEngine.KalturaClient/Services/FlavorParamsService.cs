using System;
using System.Xml;
using System.Collections.Generic;
using System.IO;

namespace Kaltura
{

	public class KalturaFlavorParamsService : KalturaServiceBase
	{
	public KalturaFlavorParamsService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaFlavorParams Add(KalturaFlavorParams flavorParams)
		{
			KalturaParams kparams = new KalturaParams();
			if (flavorParams != null)
				kparams.Add("flavorParams", flavorParams.ToParams());
			_Client.QueueServiceCall("flavorparams", "add", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaFlavorParams)KalturaObjectFactory.Create(result);
		}

		public KalturaFlavorParams Get(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			_Client.QueueServiceCall("flavorparams", "get", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaFlavorParams)KalturaObjectFactory.Create(result);
		}

		public KalturaFlavorParams Update(int id, KalturaFlavorParams flavorParams)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			if (flavorParams != null)
				kparams.Add("flavorParams", flavorParams.ToParams());
			_Client.QueueServiceCall("flavorparams", "update", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaFlavorParams)KalturaObjectFactory.Create(result);
		}

		public void Delete(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			_Client.QueueServiceCall("flavorparams", "delete", kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public KalturaFlavorParamsListResponse List()
		{
			return this.List(null);
		}

		public KalturaFlavorParamsListResponse List(KalturaFlavorParamsFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaFlavorParamsListResponse List(KalturaFlavorParamsFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			if (filter != null)
				kparams.Add("filter", filter.ToParams());
			if (pager != null)
				kparams.Add("pager", pager.ToParams());
			_Client.QueueServiceCall("flavorparams", "list", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaFlavorParamsListResponse)KalturaObjectFactory.Create(result);
		}

		public IList<KalturaFlavorParams> GetByConversionProfileId(int conversionProfileId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("conversionProfileId", conversionProfileId);
			_Client.QueueServiceCall("flavorparams", "getByConversionProfileId", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			IList<KalturaFlavorParams> list = new List<KalturaFlavorParams>();
			foreach(XmlElement node in result.ChildNodes)
			{
				list.Add((KalturaFlavorParams)KalturaObjectFactory.Create(node));
			}
			return list;
		}
	}
}
