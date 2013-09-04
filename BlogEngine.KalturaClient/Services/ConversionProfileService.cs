using System;
using System.Xml;
using System.Collections.Generic;
using System.IO;

namespace Kaltura
{

	public class KalturaConversionProfileService : KalturaServiceBase
	{
	public KalturaConversionProfileService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaConversionProfile SetAsDefault(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			_Client.QueueServiceCall("conversionprofile", "setAsDefault", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaConversionProfile)KalturaObjectFactory.Create(result);
		}

		public KalturaConversionProfile GetDefault()
		{
			KalturaParams kparams = new KalturaParams();
			_Client.QueueServiceCall("conversionprofile", "getDefault", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaConversionProfile)KalturaObjectFactory.Create(result);
		}

		public KalturaConversionProfile Add(KalturaConversionProfile conversionProfile)
		{
			KalturaParams kparams = new KalturaParams();
			if (conversionProfile != null)
				kparams.Add("conversionProfile", conversionProfile.ToParams());
			_Client.QueueServiceCall("conversionprofile", "add", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaConversionProfile)KalturaObjectFactory.Create(result);
		}

		public KalturaConversionProfile Get(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			_Client.QueueServiceCall("conversionprofile", "get", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaConversionProfile)KalturaObjectFactory.Create(result);
		}

		public KalturaConversionProfile Update(int id, KalturaConversionProfile conversionProfile)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			if (conversionProfile != null)
				kparams.Add("conversionProfile", conversionProfile.ToParams());
			_Client.QueueServiceCall("conversionprofile", "update", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaConversionProfile)KalturaObjectFactory.Create(result);
		}

		public void Delete(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			_Client.QueueServiceCall("conversionprofile", "delete", kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public KalturaConversionProfileListResponse List()
		{
			return this.List(null);
		}

		public KalturaConversionProfileListResponse List(KalturaConversionProfileFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaConversionProfileListResponse List(KalturaConversionProfileFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			if (filter != null)
				kparams.Add("filter", filter.ToParams());
			if (pager != null)
				kparams.Add("pager", pager.ToParams());
			_Client.QueueServiceCall("conversionprofile", "list", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaConversionProfileListResponse)KalturaObjectFactory.Create(result);
		}
	}
}
