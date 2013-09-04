using System;
using System.Xml;
using System.Collections.Generic;
using System.IO;

namespace Kaltura
{

	public class KalturaGenericDistributionProviderService : KalturaServiceBase
	{
	public KalturaGenericDistributionProviderService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaGenericDistributionProvider Add(KalturaGenericDistributionProvider genericDistributionProvider)
		{
			KalturaParams kparams = new KalturaParams();
			if (genericDistributionProvider != null)
				kparams.Add("genericDistributionProvider", genericDistributionProvider.ToParams());
			_Client.QueueServiceCall("contentdistribution_genericdistributionprovider", "add", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaGenericDistributionProvider)KalturaObjectFactory.Create(result);
		}

		public KalturaGenericDistributionProvider Get(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			_Client.QueueServiceCall("contentdistribution_genericdistributionprovider", "get", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaGenericDistributionProvider)KalturaObjectFactory.Create(result);
		}

		public KalturaGenericDistributionProvider Update(int id, KalturaGenericDistributionProvider genericDistributionProvider)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			if (genericDistributionProvider != null)
				kparams.Add("genericDistributionProvider", genericDistributionProvider.ToParams());
			_Client.QueueServiceCall("contentdistribution_genericdistributionprovider", "update", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaGenericDistributionProvider)KalturaObjectFactory.Create(result);
		}

		public void Delete(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			_Client.QueueServiceCall("contentdistribution_genericdistributionprovider", "delete", kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public KalturaGenericDistributionProviderListResponse List()
		{
			return this.List(null);
		}

		public KalturaGenericDistributionProviderListResponse List(KalturaGenericDistributionProviderFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaGenericDistributionProviderListResponse List(KalturaGenericDistributionProviderFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			if (filter != null)
				kparams.Add("filter", filter.ToParams());
			if (pager != null)
				kparams.Add("pager", pager.ToParams());
			_Client.QueueServiceCall("contentdistribution_genericdistributionprovider", "list", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaGenericDistributionProviderListResponse)KalturaObjectFactory.Create(result);
		}
	}
}
