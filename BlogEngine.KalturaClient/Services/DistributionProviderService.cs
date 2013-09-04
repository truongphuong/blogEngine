using System;
using System.Xml;
using System.Collections.Generic;
using System.IO;

namespace Kaltura
{

	public class KalturaDistributionProviderService : KalturaServiceBase
	{
	public KalturaDistributionProviderService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaDistributionProviderListResponse List()
		{
			return this.List(null);
		}

		public KalturaDistributionProviderListResponse List(KalturaDistributionProviderFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaDistributionProviderListResponse List(KalturaDistributionProviderFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			if (filter != null)
				kparams.Add("filter", filter.ToParams());
			if (pager != null)
				kparams.Add("pager", pager.ToParams());
			_Client.QueueServiceCall("contentdistribution_distributionprovider", "list", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaDistributionProviderListResponse)KalturaObjectFactory.Create(result);
		}
	}
}
